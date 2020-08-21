namespace OSU__Radio
{
    partial class mainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startButton = new System.Windows.Forms.Button();
            this.volumeController = new System.Windows.Forms.NumericUpDown();
            this.shuffleButton = new System.Windows.Forms.Button();
            this.curPlayingLabel = new System.Windows.Forms.Label();
            this.pauseButton = new System.Windows.Forms.Button();
            this.updater = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pickOSUDIR = new System.Windows.Forms.Button();
            this.osuDirBox = new System.Windows.Forms.TextBox();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.changeSearch = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.songTime = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.volumeController)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Play";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // volumeController
            // 
            this.volumeController.Location = new System.Drawing.Point(63, 41);
            this.volumeController.Name = "volumeController";
            this.volumeController.Size = new System.Drawing.Size(186, 20);
            this.volumeController.TabIndex = 1;
            this.volumeController.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.volumeController.ValueChanged += new System.EventHandler(this.volumeController_ValueChanged);
            // 
            // shuffleButton
            // 
            this.shuffleButton.Location = new System.Drawing.Point(93, 12);
            this.shuffleButton.Name = "shuffleButton";
            this.shuffleButton.Size = new System.Drawing.Size(75, 23);
            this.shuffleButton.TabIndex = 2;
            this.shuffleButton.Text = "Shuffle";
            this.shuffleButton.UseVisualStyleBackColor = true;
            this.shuffleButton.Click += new System.EventHandler(this.shuffleButton_Click);
            // 
            // curPlayingLabel
            // 
            this.curPlayingLabel.AutoSize = true;
            this.curPlayingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.curPlayingLabel.Location = new System.Drawing.Point(12, 73);
            this.curPlayingLabel.Name = "curPlayingLabel";
            this.curPlayingLabel.Size = new System.Drawing.Size(95, 15);
            this.curPlayingLabel.TabIndex = 3;
            this.curPlayingLabel.Text = "Nothing is playing.";
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(174, 12);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(75, 23);
            this.pauseButton.TabIndex = 4;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // updater
            // 
            this.updater.Interval = 80;
            this.updater.Tick += new System.EventHandler(this.updater_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Volume:";
            // 
            // pickOSUDIR
            // 
            this.pickOSUDIR.Location = new System.Drawing.Point(15, 153);
            this.pickOSUDIR.Name = "pickOSUDIR";
            this.pickOSUDIR.Size = new System.Drawing.Size(232, 23);
            this.pickOSUDIR.TabIndex = 7;
            this.pickOSUDIR.Text = "Change OSU Directory";
            this.pickOSUDIR.UseVisualStyleBackColor = true;
            this.pickOSUDIR.Click += new System.EventHandler(this.pickOSUDIR_Click);
            // 
            // osuDirBox
            // 
            this.osuDirBox.Location = new System.Drawing.Point(15, 127);
            this.osuDirBox.Name = "osuDirBox";
            this.osuDirBox.Size = new System.Drawing.Size(232, 20);
            this.osuDirBox.TabIndex = 8;
            // 
            // searchBar
            // 
            this.searchBar.Location = new System.Drawing.Point(15, 235);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(232, 20);
            this.searchBar.TabIndex = 10;
            this.searchBar.TextChanged += new System.EventHandler(this.searchBar_TextChanged);
            // 
            // changeSearch
            // 
            this.changeSearch.Location = new System.Drawing.Point(15, 206);
            this.changeSearch.Name = "changeSearch";
            this.changeSearch.Size = new System.Drawing.Size(232, 23);
            this.changeSearch.TabIndex = 11;
            this.changeSearch.Text = "Change to Search Song";
            this.changeSearch.UseVisualStyleBackColor = true;
            this.changeSearch.Click += new System.EventHandler(this.changeSearch_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(14, 190);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(44, 13);
            this.searchLabel.TabIndex = 12;
            this.searchLabel.Text = "Search:";
            // 
            // songTime
            // 
            this.songTime.AutoSize = true;
            this.songTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.songTime.Location = new System.Drawing.Point(15, 109);
            this.songTime.Name = "songTime";
            this.songTime.Size = new System.Drawing.Size(30, 15);
            this.songTime.TabIndex = 13;
            this.songTime.Text = "0:00";
            this.songTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lengthLabel.Location = new System.Drawing.Point(51, 109);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(45, 15);
            this.lengthLabel.TabIndex = 14;
            this.lengthLabel.Text = "Length:";
            this.lengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 267);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.songTime);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.changeSearch);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.osuDirBox);
            this.Controls.Add(this.pickOSUDIR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.curPlayingLabel);
            this.Controls.Add(this.shuffleButton);
            this.Controls.Add(this.volumeController);
            this.Controls.Add(this.startButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mainWindow";
            this.Text = "OSU! Radio | Dan";
            ((System.ComponentModel.ISupportInitialize)(this.volumeController)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.NumericUpDown volumeController;
        private System.Windows.Forms.Button shuffleButton;
        private System.Windows.Forms.Label curPlayingLabel;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Timer updater;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pickOSUDIR;
        private System.Windows.Forms.TextBox osuDirBox;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Button changeSearch;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label songTime;
        private System.Windows.Forms.Label lengthLabel;
    }
}

