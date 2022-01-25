namespace VideoPlayer
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listViewPlaylist = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.trackBarTime = new System.Windows.Forms.TrackBar();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonPlayPlaylist = new System.Windows.Forms.Button();
            this.buttonPlaylistMenu = new System.Windows.Forms.Button();
            this.panelPlaylistMenu = new System.Windows.Forms.Panel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonMiniatures = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.labelRemain = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonURL = new System.Windows.Forms.Button();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.buttonOFD = new System.Windows.Forms.Button();
            this.panelURL = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelVideo = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonLarge = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.textBoxParameters = new System.Windows.Forms.TextBox();
            this.buttonFull = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTime)).BeginInit();
            this.panelPlaylistMenu.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.panelURL.SuspendLayout();
            this.panelVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewPlaylist
            // 
            this.listViewPlaylist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewPlaylist.HideSelection = false;
            this.listViewPlaylist.Location = new System.Drawing.Point(12, 67);
            this.listViewPlaylist.MultiSelect = false;
            this.listViewPlaylist.Name = "listViewPlaylist";
            this.listViewPlaylist.Size = new System.Drawing.Size(365, 318);
            this.listViewPlaylist.TabIndex = 5;
            this.listViewPlaylist.UseCompatibleStateImageBehavior = false;
            this.listViewPlaylist.View = System.Windows.Forms.View.Details;
            this.listViewPlaylist.DoubleClick += new System.EventHandler(this.listViewPlaylist_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tytuł";
            this.columnHeader1.Width = 105;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Lokalizacja";
            this.columnHeader2.Width = 255;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LightGreen;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdd.Location = new System.Drawing.Point(12, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(34, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.LightCoral;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.Location = new System.Drawing.Point(52, 5);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(34, 23);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "-";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonPlay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPlay.Location = new System.Drawing.Point(95, 193);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(41, 23);
            this.buttonPlay.TabIndex = 8;
            this.buttonPlay.Text = "▶️";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // trackBarTime
            // 
            this.trackBarTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarTime.Location = new System.Drawing.Point(0, 155);
            this.trackBarTime.Name = "trackBarTime";
            this.trackBarTime.Size = new System.Drawing.Size(276, 45);
            this.trackBarTime.TabIndex = 9;
            this.trackBarTime.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarTime.Scroll += new System.EventHandler(this.trackBarTime_Scroll);
            this.trackBarTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBarTime_MouseDown);
            this.trackBarTime.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarTime_MouseUp);
            // 
            // buttonPause
            // 
            this.buttonPause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonPause.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPause.Location = new System.Drawing.Point(142, 193);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(41, 23);
            this.buttonPause.TabIndex = 10;
            this.buttonPause.Text = "| |";
            this.buttonPause.UseVisualStyleBackColor = false;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonPlayPlaylist
            // 
            this.buttonPlayPlaylist.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPlayPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonPlayPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPlayPlaylist.Location = new System.Drawing.Point(335, 386);
            this.buttonPlayPlaylist.Name = "buttonPlayPlaylist";
            this.buttonPlayPlaylist.Size = new System.Drawing.Size(42, 29);
            this.buttonPlayPlaylist.TabIndex = 11;
            this.buttonPlayPlaylist.Text = "🎬";
            this.buttonPlayPlaylist.UseVisualStyleBackColor = false;
            this.buttonPlayPlaylist.Click += new System.EventHandler(this.buttonPlayPlaylist_Click);
            // 
            // buttonPlaylistMenu
            // 
            this.buttonPlaylistMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPlaylistMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPlaylistMenu.Location = new System.Drawing.Point(13, 28);
            this.buttonPlaylistMenu.Name = "buttonPlaylistMenu";
            this.buttonPlaylistMenu.Size = new System.Drawing.Size(23, 23);
            this.buttonPlaylistMenu.TabIndex = 12;
            this.buttonPlaylistMenu.Text = "=";
            this.buttonPlaylistMenu.UseVisualStyleBackColor = false;
            this.buttonPlaylistMenu.Click += new System.EventHandler(this.buttonPlaylistMenu_Click);
            // 
            // panelPlaylistMenu
            // 
            this.panelPlaylistMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelPlaylistMenu.Controls.Add(this.buttonReset);
            this.panelPlaylistMenu.Controls.Add(this.buttonMiniatures);
            this.panelPlaylistMenu.Controls.Add(this.buttonDown);
            this.panelPlaylistMenu.Controls.Add(this.buttonUp);
            this.panelPlaylistMenu.Controls.Add(this.buttonAdd);
            this.panelPlaylistMenu.Controls.Add(this.buttonDelete);
            this.panelPlaylistMenu.Location = new System.Drawing.Point(42, 23);
            this.panelPlaylistMenu.Name = "panelPlaylistMenu";
            this.panelPlaylistMenu.Size = new System.Drawing.Size(335, 42);
            this.panelPlaylistMenu.TabIndex = 13;
            this.panelPlaylistMenu.Visible = false;
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonReset.Location = new System.Drawing.Point(201, 5);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(34, 23);
            this.buttonReset.TabIndex = 11;
            this.buttonReset.Text = "↪️";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonMiniatures
            // 
            this.buttonMiniatures.BackColor = System.Drawing.Color.White;
            this.buttonMiniatures.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonMiniatures.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMiniatures.Location = new System.Drawing.Point(279, 5);
            this.buttonMiniatures.Name = "buttonMiniatures";
            this.buttonMiniatures.Size = new System.Drawing.Size(48, 33);
            this.buttonMiniatures.TabIndex = 10;
            this.buttonMiniatures.Text = "🖼️";
            this.buttonMiniatures.UseVisualStyleBackColor = false;
            this.buttonMiniatures.Click += new System.EventHandler(this.buttonMiniatures_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonDown.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDown.Location = new System.Drawing.Point(146, 5);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(33, 23);
            this.buttonDown.TabIndex = 9;
            this.buttonDown.Text = "⬇️";
            this.buttonDown.UseVisualStyleBackColor = false;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonUp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUp.Location = new System.Drawing.Point(107, 5);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(33, 23);
            this.buttonUp.TabIndex = 8;
            this.buttonUp.Text = "⬆️";
            this.buttonUp.UseVisualStyleBackColor = false;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNext.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonNext.Location = new System.Drawing.Point(232, 193);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(41, 23);
            this.buttonNext.TabIndex = 14;
            this.buttonNext.Text = "▶️|";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPrev.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPrev.Location = new System.Drawing.Point(6, 193);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(41, 23);
            this.buttonPrev.TabIndex = 15;
            this.buttonPrev.Text = "|◀️";
            this.buttonPrev.UseVisualStyleBackColor = false;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // labelRemain
            // 
            this.labelRemain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelRemain.AutoSize = true;
            this.labelRemain.Location = new System.Drawing.Point(3, 177);
            this.labelRemain.Name = "labelRemain";
            this.labelRemain.Size = new System.Drawing.Size(65, 13);
            this.labelRemain.TabIndex = 17;
            this.labelRemain.Text = "labelRemain";
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(224, 177);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(52, 13);
            this.labelTime.TabIndex = 18;
            this.labelTime.Text = "labelTime";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonURL
            // 
            this.buttonURL.Location = new System.Drawing.Point(31, 10);
            this.buttonURL.Name = "buttonURL";
            this.buttonURL.Size = new System.Drawing.Size(75, 23);
            this.buttonURL.TabIndex = 19;
            this.buttonURL.Text = "Z URL";
            this.buttonURL.UseVisualStyleBackColor = true;
            this.buttonURL.Click += new System.EventHandler(this.buttonURL_Click);
            // 
            // panelAdd
            // 
            this.panelAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAdd.Controls.Add(this.buttonOFD);
            this.panelAdd.Controls.Add(this.buttonURL);
            this.panelAdd.Location = new System.Drawing.Point(28, 57);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(138, 76);
            this.panelAdd.TabIndex = 20;
            this.panelAdd.Visible = false;
            // 
            // buttonOFD
            // 
            this.buttonOFD.Location = new System.Drawing.Point(31, 39);
            this.buttonOFD.Name = "buttonOFD";
            this.buttonOFD.Size = new System.Drawing.Size(75, 23);
            this.buttonOFD.TabIndex = 20;
            this.buttonOFD.Text = "Z systemu";
            this.buttonOFD.UseVisualStyleBackColor = true;
            this.buttonOFD.Click += new System.EventHandler(this.buttonOFD_Click);
            // 
            // panelURL
            // 
            this.panelURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelURL.Controls.Add(this.label1);
            this.panelURL.Controls.Add(this.textBox1);
            this.panelURL.Location = new System.Drawing.Point(28, 56);
            this.panelURL.Name = "panelURL";
            this.panelURL.Size = new System.Drawing.Size(270, 73);
            this.panelURL.TabIndex = 21;
            this.panelURL.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Podaj URL";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // panelVideo
            // 
            this.panelVideo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVideo.Controls.Add(this.axWindowsMediaPlayer1);
            this.panelVideo.Controls.Add(this.labelRemain);
            this.panelVideo.Controls.Add(this.labelTime);
            this.panelVideo.Controls.Add(this.buttonNext);
            this.panelVideo.Controls.Add(this.buttonPrev);
            this.panelVideo.Controls.Add(this.buttonPlay);
            this.panelVideo.Controls.Add(this.buttonPause);
            this.panelVideo.Controls.Add(this.trackBarTime);
            this.panelVideo.Location = new System.Drawing.Point(383, 167);
            this.panelVideo.Name = "panelVideo";
            this.panelVideo.Size = new System.Drawing.Size(278, 218);
            this.panelVideo.TabIndex = 22;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(276, 154);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            this.axWindowsMediaPlayer1.MediaChange += new AxWMPLib._WMPOCXEvents_MediaChangeEventHandler(this.axWindowsMediaPlayer1_MediaChange);
            // 
            // buttonLarge
            // 
            this.buttonLarge.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLarge.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLarge.Location = new System.Drawing.Point(620, 138);
            this.buttonLarge.Name = "buttonLarge";
            this.buttonLarge.Size = new System.Drawing.Size(41, 21);
            this.buttonLarge.TabIndex = 23;
            this.buttonLarge.Text = "↔️";
            this.buttonLarge.UseVisualStyleBackColor = false;
            this.buttonLarge.Click += new System.EventHandler(this.buttonLarge_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSave.Location = new System.Drawing.Point(12, 386);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(42, 29);
            this.buttonSave.TabIndex = 25;
            this.buttonSave.Text = "💾";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLoad.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLoad.Location = new System.Drawing.Point(60, 386);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(42, 29);
            this.buttonLoad.TabIndex = 26;
            this.buttonLoad.Text = "📂";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // textBoxParameters
            // 
            this.textBoxParameters.Location = new System.Drawing.Point(383, 43);
            this.textBoxParameters.Multiline = true;
            this.textBoxParameters.Name = "textBoxParameters";
            this.textBoxParameters.ReadOnly = true;
            this.textBoxParameters.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxParameters.Size = new System.Drawing.Size(275, 89);
            this.textBoxParameters.TabIndex = 27;
            this.textBoxParameters.WordWrap = false;
            // 
            // buttonFull
            // 
            this.buttonFull.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonFull.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFull.Location = new System.Drawing.Point(12, 1);
            this.buttonFull.Name = "buttonFull";
            this.buttonFull.Size = new System.Drawing.Size(41, 21);
            this.buttonFull.TabIndex = 28;
            this.buttonFull.Text = "🔎";
            this.buttonFull.UseVisualStyleBackColor = false;
            this.buttonFull.Visible = false;
            this.buttonFull.Click += new System.EventHandler(this.buttonFull_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(684, 420);
            this.Controls.Add(this.buttonFull);
            this.Controls.Add(this.buttonLarge);
            this.Controls.Add(this.panelVideo);
            this.Controls.Add(this.panelURL);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.panelPlaylistMenu);
            this.Controls.Add(this.buttonPlaylistMenu);
            this.Controls.Add(this.buttonPlayPlaylist);
            this.Controls.Add(this.listViewPlaylist);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.textBoxParameters);
            this.Name = "Form1";
            this.Text = "Video Player";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTime)).EndInit();
            this.panelPlaylistMenu.ResumeLayout(false);
            this.panelAdd.ResumeLayout(false);
            this.panelURL.ResumeLayout(false);
            this.panelURL.PerformLayout();
            this.panelVideo.ResumeLayout(false);
            this.panelVideo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListView listViewPlaylist;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.TrackBar trackBarTime;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonPlayPlaylist;
        private System.Windows.Forms.Button buttonPlaylistMenu;
        private System.Windows.Forms.Panel panelPlaylistMenu;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Label labelRemain;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonMiniatures;
        private System.Windows.Forms.Button buttonURL;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Button buttonOFD;
        private System.Windows.Forms.Panel panelURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelVideo;
        private System.Windows.Forms.Button buttonLarge;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox textBoxParameters;
        private System.Windows.Forms.Button buttonFull;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

