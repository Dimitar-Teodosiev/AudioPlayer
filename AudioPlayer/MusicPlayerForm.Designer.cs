namespace AudioPlayer
{
    partial class MusicPlayerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listBoxPlaylist = new ListBox();
            buttonNext = new Button();
            buttonPlayPause = new Button();
            buttonPrevious = new Button();
            trackBarSeek = new TrackBar();
            labelStatus = new Label();
            checkBoxShuffle = new CheckBox();
            checkBoxRepeat = new CheckBox();
            timerSeek = new System.Windows.Forms.Timer(components);
            trackBarVolume = new TrackBar();
            pictureBoxAlbumArt = new PictureBox();
            folderBrowserDialog = new FolderBrowserDialog();
            buttonBrowse = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBarSeek).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarVolume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAlbumArt).BeginInit();
            SuspendLayout();
            // 
            // listBoxPlaylist
            // 
            listBoxPlaylist.FormattingEnabled = true;
            listBoxPlaylist.ItemHeight = 15;
            listBoxPlaylist.Location = new Point(5, -3);
            listBoxPlaylist.Name = "listBoxPlaylist";
            listBoxPlaylist.Size = new Size(358, 604);
            listBoxPlaylist.TabIndex = 0;
            listBoxPlaylist.SelectedIndexChanged += listBoxPlaylist_SelectedIndexChanged;
            // 
            // buttonNext
            // 
            buttonNext.Font = new Font("Segoe UI", 50F);
            buttonNext.Location = new Point(399, 496);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(92, 99);
            buttonNext.TabIndex = 1;
            buttonNext.Text = "⏮️";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // buttonPlayPause
            // 
            buttonPlayPause.Font = new Font("Segoe UI", 50F);
            buttonPlayPause.Location = new Point(741, 496);
            buttonPlayPause.Name = "buttonPlayPause";
            buttonPlayPause.Size = new Size(92, 99);
            buttonPlayPause.TabIndex = 2;
            buttonPlayPause.Text = "▶️";
            buttonPlayPause.UseVisualStyleBackColor = true;
            buttonPlayPause.Click += buttonPlayPause_Click;
            // 
            // buttonPrevious
            // 
            buttonPrevious.Font = new Font("Segoe UI", 50F);
            buttonPrevious.Location = new Point(1080, 496);
            buttonPrevious.Name = "buttonPrevious";
            buttonPrevious.Size = new Size(92, 99);
            buttonPrevious.TabIndex = 4;
            buttonPrevious.Text = "⏭️";
            buttonPrevious.TextAlign = ContentAlignment.TopCenter;
            buttonPrevious.UseVisualStyleBackColor = true;
            buttonPrevious.Click += buttonPrevious_Click;
            // 
            // trackBarSeek
            // 
            trackBarSeek.Location = new Point(399, 445);
            trackBarSeek.Maximum = 100;
            trackBarSeek.Name = "trackBarSeek";
            trackBarSeek.Size = new Size(773, 45);
            trackBarSeek.TabIndex = 5;
            trackBarSeek.Scroll += trackBarSeek_Scroll;
            // 
            // labelStatus
            // 
            labelStatus.AutoEllipsis = true;
            labelStatus.AutoSize = true;
            labelStatus.BackColor = SystemColors.ButtonFace;
            labelStatus.Font = new Font("Segoe UI", 15F);
            labelStatus.Location = new Point(399, 414);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(92, 28);
            labelStatus.TabIndex = 6;
            labelStatus.Text = "Waiting...";
            // 
            // checkBoxShuffle
            // 
            checkBoxShuffle.AutoSize = true;
            checkBoxShuffle.BackColor = SystemColors.ButtonFace;
            checkBoxShuffle.Font = new Font("Segoe UI", 20F);
            checkBoxShuffle.Location = new Point(560, 529);
            checkBoxShuffle.Name = "checkBoxShuffle";
            checkBoxShuffle.Size = new Size(73, 41);
            checkBoxShuffle.TabIndex = 7;
            checkBoxShuffle.Text = "🔀";
            checkBoxShuffle.UseVisualStyleBackColor = false;
            checkBoxShuffle.CheckedChanged += checkBoxShuffle_CheckedChanged;
            // 
            // checkBoxRepeat
            // 
            checkBoxRepeat.AutoSize = true;
            checkBoxRepeat.BackColor = SystemColors.ButtonFace;
            checkBoxRepeat.Font = new Font("Segoe UI", 20F);
            checkBoxRepeat.Location = new Point(928, 529);
            checkBoxRepeat.Name = "checkBoxRepeat";
            checkBoxRepeat.Size = new Size(73, 41);
            checkBoxRepeat.TabIndex = 8;
            checkBoxRepeat.Text = "🔁";
            checkBoxRepeat.UseVisualStyleBackColor = false;
            checkBoxRepeat.CheckedChanged += checkBoxRepeat_CheckedChanged;
            // 
            // trackBarVolume
            // 
            trackBarVolume.Location = new Point(365, 27);
            trackBarVolume.Maximum = 100;
            trackBarVolume.Name = "trackBarVolume";
            trackBarVolume.Orientation = Orientation.Vertical;
            trackBarVolume.Size = new Size(45, 460);
            trackBarVolume.TabIndex = 9;
            trackBarVolume.Scroll += trackBarVolume_Scroll;
            // 
            // pictureBoxAlbumArt
            // 
            pictureBoxAlbumArt.Location = new Point(601, 12);
            pictureBoxAlbumArt.Name = "pictureBoxAlbumArt";
            pictureBoxAlbumArt.Size = new Size(376, 387);
            pictureBoxAlbumArt.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAlbumArt.TabIndex = 10;
            pictureBoxAlbumArt.TabStop = false;
            // 
            // buttonBrowse
            // 
            buttonBrowse.Font = new Font("Segoe UI", 10F);
            buttonBrowse.Location = new Point(239, 559);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(124, 42);
            buttonBrowse.TabIndex = 11;
            buttonBrowse.Text = "Select Folder 📁";
            buttonBrowse.UseVisualStyleBackColor = true;
            buttonBrowse.Click += buttonBrowse_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(365, 9);
            label1.Name = "label1";
            label1.Size = new Size(55, 19);
            label1.TabIndex = 12;
            label1.Text = "Volume";
            // 
            // MusicPlayerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1224, 606);
            Controls.Add(labelStatus);
            Controls.Add(label1);
            Controls.Add(buttonBrowse);
            Controls.Add(trackBarSeek);
            Controls.Add(pictureBoxAlbumArt);
            Controls.Add(trackBarVolume);
            Controls.Add(checkBoxRepeat);
            Controls.Add(checkBoxShuffle);
            Controls.Add(buttonPrevious);
            Controls.Add(buttonPlayPause);
            Controls.Add(buttonNext);
            Controls.Add(listBoxPlaylist);
            Enabled = false;
            MaximizeBox = false;
            Name = "MusicPlayerForm";
            Text = "Player";
            Load += MusicPlayerForm_Load;
            ((System.ComponentModel.ISupportInitialize)trackBarSeek).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarVolume).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAlbumArt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxPlaylist;
        private Button buttonNext;
        private Button buttonPlayPause;
        private Button buttonPrevious;
        private TrackBar trackBarSeek;
        private Label labelStatus;
        private CheckBox checkBoxShuffle;
        private CheckBox checkBoxRepeat;
        private System.Windows.Forms.Timer timerSeek;
        private TrackBar trackBarVolume;
        private PictureBox pictureBoxAlbumArt;
        private Label label1;
        private FolderBrowserDialog folderBrowserDialog;
        private Button buttonBrowse;
    }
}
