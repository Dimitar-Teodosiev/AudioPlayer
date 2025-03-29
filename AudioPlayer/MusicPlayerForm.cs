using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using NAudio.Wave;
using TagLib;

namespace AudioPlayer
{
    public partial class MusicPlayerForm : MaterialForm
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
            timerSeek.Interval = 100;


            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800,
                                                              Primary.BlueGrey900,
                                                              Primary.BlueGrey500,
                                                              Accent.LightBlue200,
                                                              TextShade.WHITE);
            this.Icon = new Icon(@"..\..\..\Pictures\AudioPlayer.ico");
            this.AutoScaleMode = AutoScaleMode.Font;

            PictureBoxPlayPause.SizeMode = PictureBoxSizeMode.Zoom;

            pictureBoxAlbumArt.Image = Image.FromFile(@"..\..\..\Pictures\GoTo.png");

            PictureBoxNext.Image = Image.FromFile(@"..\..\..\Pictures\next.png");
            PictureBoxNext.SizeMode = PictureBoxSizeMode.Zoom;

            PictureBoxPrevious.Image = Image.FromFile(@"..\..\..\Pictures\previous.png");
            PictureBoxPrevious.SizeMode = PictureBoxSizeMode.Zoom;

            PictureBoxShuffle.Image = Image.FromFile(@"..\..\..\Pictures\shuffle.png");
            PictureBoxShuffle.SizeMode = PictureBoxSizeMode.Zoom;

            PictureBoxRepeat.Image = Image.FromFile(@"..\..\..\Pictures\repeat.png");
            PictureBoxRepeat.SizeMode = PictureBoxSizeMode.Zoom;


            trackBarVolume.Value = 50;
            outputDevice.Volume = trackBarVolume.Value / 100f;


            UpdatePlayPauseImage();
        }

        private void LoadPlaylist(string musicDirectory)
        {
            try
            {
                playlist = Directory.GetFiles(musicDirectory)
                                           .Where(file =>
                                           file.EndsWith(".mp3") ||
                                           file.EndsWith(".wav") ||
                                           file.EndsWith(".mp4"))
                                           .ToArray();

                listBoxPlaylist.Items.Clear();
                foreach (var file in playlist)
                {
                    listBoxPlaylist.Items.Add(new MaterialListBoxItem(Path.GetFileName(file)));
                }
                listBoxPlaylist.Items.Add(new MaterialListBoxItem(""));
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
                if (index >= 0 && index <= playlist.Length)
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
                    trackBarSeek.RangeMax = (int)audioFile.TotalTime.TotalSeconds;
                    timerSeek.Start();

                    LoadAlbumArt(playlist[currentTrackIndex]);
                    UpdatePlayPauseImage();
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
                    pictureBoxAlbumArt.Image = Image.FromFile(@"..\..\..\Pictures\GoTo.png");
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
                try
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
                catch (Exception)
                {
                    MessageBox.Show("Please select a folder");
                }


            }
            UpdatePlayPauseImage();
        }

        private void UpdatePlayPauseImage()
        {
            PictureBoxPlayPause.Image = isPlaying ? Image.FromFile(@"..\..\..\Pictures\Pause.png") : Image.FromFile(@"..\..\..\Pictures\Play.png");
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (isShuffle)
            {
                PlayTrack(random.Next(playlist.Length));
            }
            else
            {
                PlayTrack((currentTrackIndex + 1 + playlist.Length) % playlist.Length);
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

        private void trackBarSeek_onValueChanged(object sender, int newValue)
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
                double threshold = 0.1;
                if (audioFile.TotalTime.TotalSeconds - audioFile.CurrentTime.TotalSeconds <= threshold)
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

        private void listBoxPlaylist_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            if (listBoxPlaylist.SelectedIndex != -1)
            {
                PlayTrack(listBoxPlaylist.SelectedIndex);
            }
        }

        private void trackBarVolume_onValueChanged(object sender, int newValue)
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

        private void PictureBoxPrevious_Click(object sender, EventArgs e)
        {
            buttonPrevious_Click(sender, e);
        }

        private void PictureBoxNext_Click(object sender, EventArgs e)
        {
            buttonNext_Click(sender, e);
        }

        private void PictureBoxPlayPause_Click(object sender, EventArgs e)
        {
            buttonPlayPause_Click(sender, e);
        }
    }
}