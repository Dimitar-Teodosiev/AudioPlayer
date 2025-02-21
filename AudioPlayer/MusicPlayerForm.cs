using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using NAudio.Wave;
using TagLib;

namespace AudioPlayer
{
    public partial class MusicPlayerForm : Form
    {
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        private string[] playlist;
        private int currentTrackIndex = 0;
        private bool isPlaying = false;
        private bool isShuffle = false;
        private bool isRepeat = false;
        private Random random = new Random();

        public MusicPlayerForm()
        {
            InitializeComponent();
            outputDevice = new WaveOutEvent();
            timerSeek.Tick += TimerSeek_Tick;
            timerSeek.Interval = 500;

            trackBarVolume.Value = 50;
            outputDevice.Volume = trackBarVolume.Value / 100f;

            UpdatePlayPauseButtonText();
        }

        private void LoadPlaylist(string musicDirectory)
        {
            try
            {
                playlist = Directory.GetFiles(musicDirectory)
                                           .Where(file => file.EndsWith(".mp3") || file.EndsWith(".wav") || file.EndsWith(".mp4"))
                                           .ToArray();

                listBoxPlaylist.Items.Clear();
                listBoxPlaylist.Items.AddRange(playlist.Select(Path.GetFileName).ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading playlist: " + ex.Message);
            }


        }

        private void PlayTrack(int index)
        {
            try
            {
                if (index >= 0 && index < playlist.Length)
                {
                    // Stop and dispose of the current playback
                    if (outputDevice != null)
                    {
                        outputDevice.Stop();
                        outputDevice.Dispose();
                        outputDevice = new WaveOutEvent(); // Reinitialize outputDevice
                    }

                    if (audioFile != null)
                    {
                        audioFile.Dispose();
                    }

                    // Load the new track
                    currentTrackIndex = index;
                    audioFile = new AudioFileReader(playlist[currentTrackIndex]);
                    outputDevice.Init(audioFile);
                    outputDevice.Play();
                    isPlaying = true;
                    UpdateStatusLabel("Now Playing: " + Path.GetFileName(playlist[currentTrackIndex]));
                    trackBarSeek.Maximum = (int)audioFile.TotalTime.TotalSeconds;
                    timerSeek.Start();

                    LoadAlbumArt(playlist[currentTrackIndex]);
                    UpdatePlayPauseButtonText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error playing track: " + ex.Message);
            }
        }

        private void LoadAlbumArt(string filePath)
        {
            try
            {
                var file = TagLib.File.Create(filePath);
                var picture = file.Tag.Pictures.FirstOrDefault();
                if (picture != null)
                {
                    using (var ms = new MemoryStream(picture.Data.Data))
                    {
                        pictureBoxAlbumArt.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBoxAlbumArt.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading album art: " + ex.Message);
            }
        }

        private void buttonPlayPause_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                outputDevice.Pause();
                isPlaying = false;
                UpdateStatusLabel("Paused: " + Path.GetFileName(playlist[currentTrackIndex]));
            }
            else
            {
                if (audioFile == null && playlist.Length > 0)
                {
                    PlayTrack(0);
                }
                else
                {
                    outputDevice.Play();
                    isPlaying = true;
                    UpdateStatusLabel("Now Playing: " + Path.GetFileName(playlist[currentTrackIndex]));
                }
            }

            UpdatePlayPauseButtonText();
            buttonPlayPause.ImageAlign = ContentAlignment.MiddleCenter;
        }

        private void UpdatePlayPauseButtonText()
        {
            buttonPlayPause.Text = isPlaying ? "▶️" : "⏸️";
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (isShuffle)
            {
                PlayTrack(random.Next(playlist.Length));
            }
            else
            {
                PlayTrack((currentTrackIndex + 1) % playlist.Length);
            }
        }
        private void UpdateStatusLabel(string text)
        {
            int maxLength = 80;

            if (text.Length > maxLength)
            {
                text = text.Substring(0, maxLength - 6) + "..." + $"{audioFile.CurrentTime:mm\\:ss} / {audioFile.TotalTime:mm\\:ss}";
            }

            labelStatus.Text = text;
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (isShuffle)
            {
                PlayTrack(random.Next(playlist.Length));
            }
            else
            {
                PlayTrack((currentTrackIndex - 1 + playlist.Length) % playlist.Length);
            }
        }

        private void trackBarSeek_Scroll(object sender, EventArgs e)
        {
            if (audioFile != null)
            {
                audioFile.CurrentTime = TimeSpan.FromSeconds(trackBarSeek.Value);
            }
        }

        private void TimerSeek_Tick(object sender, EventArgs e)
        {
            if (audioFile != null && isPlaying)
            {
                trackBarSeek.Value = (int)audioFile.CurrentTime.TotalSeconds;
                UpdateStatusLabel($"Now Playing: {Path.GetFileName(playlist[currentTrackIndex])} - {audioFile.CurrentTime:mm\\:ss} / {audioFile.TotalTime:mm\\:ss}");

                // Automatically play the next track if repeat is enabled
                if (audioFile.CurrentTime >= audioFile.TotalTime)
                {
                    if (isRepeat)
                    {
                        PlayTrack(currentTrackIndex);
                    }
                    else
                    {
                        buttonNext_Click(null, null);
                    }
                }
            }
        }

        private void listBoxPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPlaylist.SelectedIndex != -1)
            {
                PlayTrack(listBoxPlaylist.SelectedIndex);
            }
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            outputDevice.Volume = trackBarVolume.Value / 100f;
        }

        private void checkBoxShuffle_CheckedChanged(object sender, EventArgs e)
        {
            isShuffle = checkBoxShuffle.Checked;
        }

        private void checkBoxRepeat_CheckedChanged(object sender, EventArgs e)
        {
            isRepeat = checkBoxRepeat.Checked;
        }

        private void MusicPlayerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (outputDevice != null)
            {
                outputDevice.Stop();
                outputDevice.Dispose();
            }

            if (audioFile != null)
            {
                audioFile.Dispose();
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();

            // Check if the user selected a folder and clicked OK
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                LoadPlaylist(folderBrowserDialog.SelectedPath);
            }
        }

        private void MusicPlayerForm_Load(object sender, EventArgs e)
        {

        }
    }
}