namespace LiveStreamerGUI
{
    partial class LivestreamerGuiForm
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
            this.gbOpenStream = new System.Windows.Forms.GroupBox();
            this.cbStreamURLs = new System.Windows.Forms.ComboBox();
            this.cbUseCustomApp = new System.Windows.Forms.CheckBox();
            this.btnLivestreamerLocBrowse = new System.Windows.Forms.Button();
            this.lblLivestreamerLoc = new System.Windows.Forms.Label();
            this.tbLivestreamerLoc = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.cbQuality = new System.Windows.Forms.ComboBox();
            this.lblStreamURL = new System.Windows.Forms.Label();
            this.btnApplicationBrowse = new System.Windows.Forms.Button();
            this.lblOpenWith = new System.Windows.Forms.Label();
            this.tbApplication = new System.Windows.Forms.TextBox();
            this.gbOutput = new System.Windows.Forms.GroupBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkPlugins = new System.Windows.Forms.LinkLabel();
            this.linkPlayers = new System.Windows.Forms.LinkLabel();
            this.linkDownload = new System.Windows.Forms.LinkLabel();
            this.gbOpenStream.SuspendLayout();
            this.gbOutput.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOpenStream
            // 
            this.gbOpenStream.Controls.Add(this.linkDownload);
            this.gbOpenStream.Controls.Add(this.linkPlayers);
            this.gbOpenStream.Controls.Add(this.linkPlugins);
            this.gbOpenStream.Controls.Add(this.cbStreamURLs);
            this.gbOpenStream.Controls.Add(this.cbUseCustomApp);
            this.gbOpenStream.Controls.Add(this.btnLivestreamerLocBrowse);
            this.gbOpenStream.Controls.Add(this.lblLivestreamerLoc);
            this.gbOpenStream.Controls.Add(this.tbLivestreamerLoc);
            this.gbOpenStream.Controls.Add(this.btnOpen);
            this.gbOpenStream.Controls.Add(this.cbQuality);
            this.gbOpenStream.Controls.Add(this.lblStreamURL);
            this.gbOpenStream.Controls.Add(this.btnApplicationBrowse);
            this.gbOpenStream.Controls.Add(this.lblOpenWith);
            this.gbOpenStream.Controls.Add(this.tbApplication);
            this.gbOpenStream.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpenStream.Location = new System.Drawing.Point(12, 34);
            this.gbOpenStream.Name = "gbOpenStream";
            this.gbOpenStream.Size = new System.Drawing.Size(559, 213);
            this.gbOpenStream.TabIndex = 0;
            this.gbOpenStream.TabStop = false;
            this.gbOpenStream.Text = "Open stream";
            // 
            // cbStreamURLs
            // 
            this.cbStreamURLs.FormattingEnabled = true;
            this.cbStreamURLs.Location = new System.Drawing.Point(13, 170);
            this.cbStreamURLs.Name = "cbStreamURLs";
            this.cbStreamURLs.Size = new System.Drawing.Size(350, 28);
            this.cbStreamURLs.TabIndex = 10;
            // 
            // cbUseCustomApp
            // 
            this.cbUseCustomApp.AutoSize = true;
            this.cbUseCustomApp.Location = new System.Drawing.Point(13, 115);
            this.cbUseCustomApp.Name = "cbUseCustomApp";
            this.cbUseCustomApp.Size = new System.Drawing.Size(15, 14);
            this.cbUseCustomApp.TabIndex = 9;
            this.cbUseCustomApp.UseVisualStyleBackColor = true;
            this.cbUseCustomApp.CheckedChanged += new System.EventHandler(this.cbUseCustomApp_CheckedChanged);
            // 
            // btnLivestreamerLocBrowse
            // 
            this.btnLivestreamerLocBrowse.Location = new System.Drawing.Point(520, 49);
            this.btnLivestreamerLocBrowse.Name = "btnLivestreamerLocBrowse";
            this.btnLivestreamerLocBrowse.Size = new System.Drawing.Size(28, 27);
            this.btnLivestreamerLocBrowse.TabIndex = 2;
            this.btnLivestreamerLocBrowse.Text = "...";
            this.btnLivestreamerLocBrowse.UseVisualStyleBackColor = true;
            this.btnLivestreamerLocBrowse.Click += new System.EventHandler(this.btnLivestreamerLocBrowse_Click);
            // 
            // lblLivestreamerLoc
            // 
            this.lblLivestreamerLoc.AutoSize = true;
            this.lblLivestreamerLoc.Location = new System.Drawing.Point(7, 26);
            this.lblLivestreamerLoc.Name = "lblLivestreamerLoc";
            this.lblLivestreamerLoc.Size = new System.Drawing.Size(151, 20);
            this.lblLivestreamerLoc.TabIndex = 8;
            this.lblLivestreamerLoc.Text = "Livestreamer location";
            // 
            // tbLivestreamerLoc
            // 
            this.tbLivestreamerLoc.Location = new System.Drawing.Point(11, 49);
            this.tbLivestreamerLoc.Name = "tbLivestreamerLoc";
            this.tbLivestreamerLoc.Size = new System.Drawing.Size(503, 27);
            this.tbLivestreamerLoc.TabIndex = 1;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(473, 169);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 30);
            this.btnOpen.TabIndex = 7;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // cbQuality
            // 
            this.cbQuality.FormattingEnabled = true;
            this.cbQuality.Location = new System.Drawing.Point(369, 170);
            this.cbQuality.Name = "cbQuality";
            this.cbQuality.Size = new System.Drawing.Size(99, 28);
            this.cbQuality.TabIndex = 6;
            // 
            // lblStreamURL
            // 
            this.lblStreamURL.AutoSize = true;
            this.lblStreamURL.Location = new System.Drawing.Point(7, 147);
            this.lblStreamURL.Name = "lblStreamURL";
            this.lblStreamURL.Size = new System.Drawing.Size(86, 20);
            this.lblStreamURL.TabIndex = 3;
            this.lblStreamURL.Text = "Stream URL";
            // 
            // btnApplicationBrowse
            // 
            this.btnApplicationBrowse.Location = new System.Drawing.Point(520, 109);
            this.btnApplicationBrowse.Name = "btnApplicationBrowse";
            this.btnApplicationBrowse.Size = new System.Drawing.Size(28, 27);
            this.btnApplicationBrowse.TabIndex = 4;
            this.btnApplicationBrowse.Text = "...";
            this.btnApplicationBrowse.UseVisualStyleBackColor = true;
            this.btnApplicationBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblOpenWith
            // 
            this.lblOpenWith.AutoSize = true;
            this.lblOpenWith.Location = new System.Drawing.Point(7, 86);
            this.lblOpenWith.Name = "lblOpenWith";
            this.lblOpenWith.Size = new System.Drawing.Size(77, 20);
            this.lblOpenWith.TabIndex = 1;
            this.lblOpenWith.Text = "Open with";
            // 
            // tbApplication
            // 
            this.tbApplication.Location = new System.Drawing.Point(33, 109);
            this.tbApplication.Name = "tbApplication";
            this.tbApplication.Size = new System.Drawing.Size(481, 27);
            this.tbApplication.TabIndex = 3;
            // 
            // gbOutput
            // 
            this.gbOutput.Controls.Add(this.tbOutput);
            this.gbOutput.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gbOutput.Location = new System.Drawing.Point(12, 253);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Size = new System.Drawing.Size(559, 280);
            this.gbOutput.TabIndex = 1;
            this.gbOutput.TabStop = false;
            this.gbOutput.Text = "Output";
            // 
            // tbOutput
            // 
            this.tbOutput.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOutput.Location = new System.Drawing.Point(11, 26);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbOutput.Size = new System.Drawing.Size(537, 238);
            this.tbOutput.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(583, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // linkPlugins
            // 
            this.linkPlugins.AutoSize = true;
            this.linkPlugins.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkPlugins.Location = new System.Drawing.Point(92, 152);
            this.linkPlugins.Name = "linkPlugins";
            this.linkPlugins.Size = new System.Drawing.Size(110, 13);
            this.linkPlugins.TabIndex = 11;
            this.linkPlugins.TabStop = true;
            this.linkPlugins.Text = "(Supported plugins)";
            this.linkPlugins.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPlugins_LinkClicked);
            // 
            // linkPlayers
            // 
            this.linkPlayers.AutoSize = true;
            this.linkPlayers.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkPlayers.Location = new System.Drawing.Point(82, 91);
            this.linkPlayers.Name = "linkPlayers";
            this.linkPlayers.Size = new System.Drawing.Size(107, 13);
            this.linkPlayers.TabIndex = 12;
            this.linkPlayers.TabStop = true;
            this.linkPlayers.Text = "(Supported players)";
            this.linkPlayers.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPlayers_LinkClicked);
            // 
            // linkDownload
            // 
            this.linkDownload.AutoSize = true;
            this.linkDownload.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkDownload.Location = new System.Drawing.Point(157, 31);
            this.linkDownload.Name = "linkDownload";
            this.linkDownload.Size = new System.Drawing.Size(93, 13);
            this.linkDownload.TabIndex = 13;
            this.linkDownload.TabStop = true;
            this.linkDownload.Text = "(Download here)";
            this.linkDownload.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDownload_LinkClicked);
            // 
            // LivestreamerGuiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 548);
            this.Controls.Add(this.gbOutput);
            this.Controls.Add(this.gbOpenStream);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LivestreamerGuiForm";
            this.Text = "Livestreamer Sharp UI";
            this.gbOpenStream.ResumeLayout(false);
            this.gbOpenStream.PerformLayout();
            this.gbOutput.ResumeLayout(false);
            this.gbOutput.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOpenStream;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ComboBox cbQuality;
        private System.Windows.Forms.Label lblStreamURL;
        private System.Windows.Forms.Button btnApplicationBrowse;
        private System.Windows.Forms.Label lblOpenWith;
        private System.Windows.Forms.TextBox tbApplication;
        private System.Windows.Forms.Button btnLivestreamerLocBrowse;
        private System.Windows.Forms.Label lblLivestreamerLoc;
        private System.Windows.Forms.TextBox tbLivestreamerLoc;
        private System.Windows.Forms.GroupBox gbOutput;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.CheckBox cbUseCustomApp;
        private System.Windows.Forms.ComboBox cbStreamURLs;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkPlugins;
        private System.Windows.Forms.LinkLabel linkPlayers;
        private System.Windows.Forms.LinkLabel linkDownload;
    }
}

