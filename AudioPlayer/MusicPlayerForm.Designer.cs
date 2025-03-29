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
            labelStatus = new Label();
            timerSeek = new System.Windows.Forms.Timer(components);
            pictureBoxAlbumArt = new PictureBox();
            folderBrowserDialog = new FolderBrowserDialog();
            trackBarVolume = new MaterialSkin.Controls.MaterialSlider();
            Label = new MaterialSkin.Controls.MaterialLabel();
            trackBarSeek = new MaterialSkin.Controls.MaterialSlider();
            listBoxPlaylist = new MaterialSkin.Controls.MaterialListBox();
            buttonBrowse = new MaterialSkin.Controls.MaterialButton();
            buttonPrevious = new MaterialSkin.Controls.MaterialButton();
            buttonNext = new MaterialSkin.Controls.MaterialButton();
            buttonPlayPause = new MaterialSkin.Controls.MaterialButton();
            checkBoxShuffle = new MaterialSkin.Controls.MaterialCheckbox();
            checkBoxRepeat = new MaterialSkin.Controls.MaterialCheckbox();
            PictureBoxPrevious = new PictureBox();
            PictureBoxNext = new PictureBox();
            PictureBoxPlayPause = new PictureBox();
            PictureBoxShuffle = new PictureBox();
            PictureBoxRepeat = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAlbumArt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxPrevious).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxNext).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxPlayPause).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxShuffle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxRepeat).BeginInit();
            SuspendLayout();
            // 
            // labelStatus
            // 
            labelStatus.AutoEllipsis = true;
            labelStatus.AutoSize = true;
            labelStatus.BackColor = SystemColors.ButtonFace;
            labelStatus.Font = new Font("Segoe UI", 15F);
            labelStatus.Location = new Point(399, 419);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(92, 28);
            labelStatus.TabIndex = 6;
            labelStatus.Text = "Waiting...";
            // 
            // pictureBoxAlbumArt
            // 
            pictureBoxAlbumArt.Location = new Point(635, 64);
            pictureBoxAlbumArt.Name = "pictureBoxAlbumArt";
            pictureBoxAlbumArt.Size = new Size(328, 346);
            pictureBoxAlbumArt.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAlbumArt.TabIndex = 10;
            pictureBoxAlbumArt.TabStop = false;
            // 
            // trackBarVolume
            // 
            trackBarVolume.Depth = 0;
            trackBarVolume.ForeColor = Color.FromArgb(222, 0, 0, 0);
            trackBarVolume.Location = new Point(369, 376);
            trackBarVolume.MouseState = MaterialSkin.MouseState.HOVER;
            trackBarVolume.Name = "trackBarVolume";
            trackBarVolume.ShowText = false;
            trackBarVolume.ShowValue = false;
            trackBarVolume.Size = new Size(234, 40);
            trackBarVolume.TabIndex = 14;
            trackBarVolume.Text = "";
            trackBarVolume.onValueChanged += trackBarVolume_onValueChanged;
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.BackColor = SystemColors.ActiveCaptionText;
            Label.Depth = 0;
            Label.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Label.ForeColor = SystemColors.ControlText;
            Label.Location = new Point(459, 354);
            Label.MouseState = MaterialSkin.MouseState.HOVER;
            Label.Name = "Label";
            Label.Size = new Size(55, 19);
            Label.TabIndex = 15;
            Label.Text = "Volume";
            // 
            // trackBarSeek
            // 
            trackBarSeek.Depth = 0;
            trackBarSeek.Dock = DockStyle.Bottom;
            trackBarSeek.ForeColor = Color.FromArgb(222, 0, 0, 0);
            trackBarSeek.Location = new Point(360, 562);
            trackBarSeek.MouseState = MaterialSkin.MouseState.HOVER;
            trackBarSeek.Name = "trackBarSeek";
            trackBarSeek.ShowText = false;
            trackBarSeek.ShowValue = false;
            trackBarSeek.Size = new Size(862, 40);
            trackBarSeek.TabIndex = 16;
            trackBarSeek.Text = "";
            trackBarSeek.Value = 0;
            trackBarSeek.onValueChanged += trackBarSeek_onValueChanged;
            // 
            // listBoxPlaylist
            // 
            listBoxPlaylist.BackColor = Color.White;
            listBoxPlaylist.BorderColor = Color.LightGray;
            listBoxPlaylist.Depth = 0;
            listBoxPlaylist.Dock = DockStyle.Left;
            listBoxPlaylist.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            listBoxPlaylist.Location = new Point(3, 64);
            listBoxPlaylist.MouseState = MaterialSkin.MouseState.HOVER;
            listBoxPlaylist.Name = "listBoxPlaylist";
            listBoxPlaylist.SelectedIndex = -1;
            listBoxPlaylist.SelectedItem = null;
            listBoxPlaylist.Size = new Size(357, 538);
            listBoxPlaylist.TabIndex = 17;
            listBoxPlaylist.SelectedIndexChanged += listBoxPlaylist_SelectedIndexChanged;
            // 
            // buttonBrowse
            // 
            buttonBrowse.AutoSize = false;
            buttonBrowse.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonBrowse.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonBrowse.Depth = 0;
            buttonBrowse.Font = new Font("Segoe UI", 8F);
            buttonBrowse.HighEmphasis = true;
            buttonBrowse.Icon = null;
            buttonBrowse.Location = new Point(367, 70);
            buttonBrowse.Margin = new Padding(4, 6, 4, 6);
            buttonBrowse.MouseState = MaterialSkin.MouseState.HOVER;
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.NoAccentTextColor = Color.Empty;
            buttonBrowse.Size = new Size(130, 45);
            buttonBrowse.TabIndex = 18;
            buttonBrowse.Text = "Select Folder 📁";
            buttonBrowse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonBrowse.UseAccentColor = false;
            buttonBrowse.UseVisualStyleBackColor = true;
            buttonBrowse.Click += buttonBrowse_Click;
            // 
            // buttonPrevious
            // 
            buttonPrevious.AutoSize = false;
            buttonPrevious.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonPrevious.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonPrevious.Depth = 0;
            buttonPrevious.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPrevious.HighEmphasis = true;
            buttonPrevious.Icon = null;
            buttonPrevious.Location = new Point(399, 199);
            buttonPrevious.Margin = new Padding(4, 6, 4, 6);
            buttonPrevious.MouseState = MaterialSkin.MouseState.HOVER;
            buttonPrevious.Name = "buttonPrevious";
            buttonPrevious.NoAccentTextColor = Color.Empty;
            buttonPrevious.Size = new Size(106, 99);
            buttonPrevious.TabIndex = 19;
            buttonPrevious.Text = "⏮️";
            buttonPrevious.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonPrevious.UseAccentColor = false;
            buttonPrevious.UseVisualStyleBackColor = true;
            buttonPrevious.Click += buttonPrevious_Click;
            // 
            // buttonNext
            // 
            buttonNext.AutoSize = false;
            buttonNext.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonNext.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonNext.Depth = 0;
            buttonNext.HighEmphasis = true;
            buttonNext.Icon = null;
            buttonNext.Location = new Point(1066, 199);
            buttonNext.Margin = new Padding(4, 6, 4, 6);
            buttonNext.MouseState = MaterialSkin.MouseState.HOVER;
            buttonNext.Name = "buttonNext";
            buttonNext.NoAccentTextColor = Color.Empty;
            buttonNext.Size = new Size(106, 98);
            buttonNext.TabIndex = 20;
            buttonNext.Text = "⏭️";
            buttonNext.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonNext.UseAccentColor = false;
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // buttonPlayPause
            // 
            buttonPlayPause.AutoSize = false;
            buttonPlayPause.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonPlayPause.BackgroundImageLayout = ImageLayout.None;
            buttonPlayPause.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonPlayPause.Depth = 0;
            buttonPlayPause.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPlayPause.HighEmphasis = true;
            buttonPlayPause.Icon = null;
            buttonPlayPause.Location = new Point(752, 454);
            buttonPlayPause.Margin = new Padding(4, 6, 4, 6);
            buttonPlayPause.MouseState = MaterialSkin.MouseState.HOVER;
            buttonPlayPause.Name = "buttonPlayPause";
            buttonPlayPause.NoAccentTextColor = Color.Empty;
            buttonPlayPause.Size = new Size(105, 100);
            buttonPlayPause.TabIndex = 21;
            buttonPlayPause.Text = "Play";
            buttonPlayPause.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonPlayPause.UseAccentColor = false;
            buttonPlayPause.UseVisualStyleBackColor = true;
            buttonPlayPause.Click += buttonPlayPause_Click;
            // 
            // checkBoxShuffle
            // 
            checkBoxShuffle.Depth = 0;
            checkBoxShuffle.Location = new Point(656, 529);
            checkBoxShuffle.Margin = new Padding(0);
            checkBoxShuffle.MouseLocation = new Point(-1, -1);
            checkBoxShuffle.MouseState = MaterialSkin.MouseState.HOVER;
            checkBoxShuffle.Name = "checkBoxShuffle";
            checkBoxShuffle.ReadOnly = false;
            checkBoxShuffle.Ripple = true;
            checkBoxShuffle.Size = new Size(36, 30);
            checkBoxShuffle.TabIndex = 22;
            checkBoxShuffle.UseVisualStyleBackColor = true;
            checkBoxShuffle.CheckedChanged += checkBoxShuffle_CheckedChanged;
            // 
            // checkBoxRepeat
            // 
            checkBoxRepeat.Depth = 0;
            checkBoxRepeat.Location = new Point(909, 529);
            checkBoxRepeat.Margin = new Padding(0);
            checkBoxRepeat.MouseLocation = new Point(-1, -1);
            checkBoxRepeat.MouseState = MaterialSkin.MouseState.HOVER;
            checkBoxRepeat.Name = "checkBoxRepeat";
            checkBoxRepeat.ReadOnly = false;
            checkBoxRepeat.RightToLeft = RightToLeft.Yes;
            checkBoxRepeat.Ripple = true;
            checkBoxRepeat.Size = new Size(36, 30);
            checkBoxRepeat.TabIndex = 23;
            checkBoxRepeat.UseVisualStyleBackColor = true;
            checkBoxRepeat.CheckedChanged += checkBoxRepeat_CheckedChanged;
            // 
            // PictureBoxPrevious
            // 
            PictureBoxPrevious.Location = new Point(397, 199);
            PictureBoxPrevious.Name = "PictureBoxPrevious";
            PictureBoxPrevious.Size = new Size(108, 99);
            PictureBoxPrevious.TabIndex = 24;
            PictureBoxPrevious.TabStop = false;
            PictureBoxPrevious.Click += PictureBoxPrevious_Click;
            // 
            // PictureBoxNext
            // 
            PictureBoxNext.ImageLocation = "";
            PictureBoxNext.Location = new Point(1066, 197);
            PictureBoxNext.Name = "PictureBoxNext";
            PictureBoxNext.Size = new Size(108, 100);
            PictureBoxNext.TabIndex = 25;
            PictureBoxNext.TabStop = false;
            PictureBoxNext.Click += PictureBoxNext_Click;
            // 
            // PictureBoxPlayPause
            // 
            PictureBoxPlayPause.Location = new Point(752, 454);
            PictureBoxPlayPause.Name = "PictureBoxPlayPause";
            PictureBoxPlayPause.Size = new Size(105, 100);
            PictureBoxPlayPause.TabIndex = 26;
            PictureBoxPlayPause.TabStop = false;
            PictureBoxPlayPause.Click += PictureBoxPlayPause_Click;
            // 
            // PictureBoxShuffle
            // 
            PictureBoxShuffle.Location = new Point(635, 454);
            PictureBoxShuffle.Name = "PictureBoxShuffle";
            PictureBoxShuffle.Size = new Size(75, 75);
            PictureBoxShuffle.TabIndex = 27;
            PictureBoxShuffle.TabStop = false;
            // 
            // PictureBoxRepeat
            // 
            PictureBoxRepeat.Location = new Point(888, 454);
            PictureBoxRepeat.Name = "PictureBoxRepeat";
            PictureBoxRepeat.Size = new Size(75, 75);
            PictureBoxRepeat.TabIndex = 28;
            PictureBoxRepeat.TabStop = false;
            // 
            // MusicPlayerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1225, 605);
            Controls.Add(PictureBoxRepeat);
            Controls.Add(PictureBoxShuffle);
            Controls.Add(PictureBoxPlayPause);
            Controls.Add(PictureBoxNext);
            Controls.Add(PictureBoxPrevious);
            Controls.Add(checkBoxRepeat);
            Controls.Add(checkBoxShuffle);
            Controls.Add(buttonPlayPause);
            Controls.Add(buttonNext);
            Controls.Add(buttonPrevious);
            Controls.Add(buttonBrowse);
            Controls.Add(trackBarSeek);
            Controls.Add(Label);
            Controls.Add(trackBarVolume);
            Controls.Add(labelStatus);
            Controls.Add(pictureBoxAlbumArt);
            Controls.Add(listBoxPlaylist);
            MaximizeBox = false;
            Name = "MusicPlayerForm";
            Text = "Audiofy";
            Load += MusicPlayerForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxAlbumArt).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxPrevious).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxNext).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxPlayPause).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxShuffle).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxRepeat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelStatus;
        private System.Windows.Forms.Timer timerSeek;
        private PictureBox pictureBoxAlbumArt;
        private FolderBrowserDialog folderBrowserDialog;
        private MaterialSkin.Controls.MaterialSlider trackBarVolume;
        private MaterialSkin.Controls.MaterialLabel Label;
        private MaterialSkin.Controls.MaterialSlider trackBarSeek;
        private MaterialSkin.Controls.MaterialListBox listBoxPlaylist;
        private MaterialSkin.Controls.MaterialButton buttonBrowse;
        private MaterialSkin.Controls.MaterialButton buttonPrevious;
        private MaterialSkin.Controls.MaterialButton buttonNext;
        private MaterialSkin.Controls.MaterialButton buttonPlayPause;
        private MaterialSkin.Controls.MaterialCheckbox checkBoxShuffle;
        private MaterialSkin.Controls.MaterialCheckbox checkBoxRepeat;
        private PictureBox PictureBoxPrevious;
        private PictureBox PictureBoxNext;
        private PictureBox PictureBoxPlayPause;
        private PictureBox PictureBoxShuffle;
        private PictureBox PictureBoxRepeat;
    }
}
