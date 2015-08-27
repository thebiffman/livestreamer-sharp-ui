﻿namespace LiveStreamerGUI
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.cbQuality = new System.Windows.Forms.ComboBox();
            this.tbStreamURL = new System.Windows.Forms.TextBox();
            this.lblStreamURL = new System.Windows.Forms.Label();
            this.btnApplicationBrowse = new System.Windows.Forms.Button();
            this.lblOpenWith = new System.Windows.Forms.Label();
            this.tbApplication = new System.Windows.Forms.TextBox();
            this.btnLivestreamerLocBrowse = new System.Windows.Forms.Button();
            this.lblLivestreamerLoc = new System.Windows.Forms.Label();
            this.tbLivestreamerLoc = new System.Windows.Forms.TextBox();
            this.gbOutput = new System.Windows.Forms.GroupBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.cbUseCustomApp = new System.Windows.Forms.CheckBox();
            this.gbOpenStream.SuspendLayout();
            this.gbOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOpenStream
            // 
            this.gbOpenStream.Controls.Add(this.cbUseCustomApp);
            this.gbOpenStream.Controls.Add(this.btnLivestreamerLocBrowse);
            this.gbOpenStream.Controls.Add(this.lblLivestreamerLoc);
            this.gbOpenStream.Controls.Add(this.tbLivestreamerLoc);
            this.gbOpenStream.Controls.Add(this.btnOpen);
            this.gbOpenStream.Controls.Add(this.cbQuality);
            this.gbOpenStream.Controls.Add(this.tbStreamURL);
            this.gbOpenStream.Controls.Add(this.lblStreamURL);
            this.gbOpenStream.Controls.Add(this.btnApplicationBrowse);
            this.gbOpenStream.Controls.Add(this.lblOpenWith);
            this.gbOpenStream.Controls.Add(this.tbApplication);
            this.gbOpenStream.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpenStream.Location = new System.Drawing.Point(12, 10);
            this.gbOpenStream.Name = "gbOpenStream";
            this.gbOpenStream.Size = new System.Drawing.Size(559, 213);
            this.gbOpenStream.TabIndex = 0;
            this.gbOpenStream.TabStop = false;
            this.gbOpenStream.Text = "Open stream";
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
            // tbStreamURL
            // 
            this.tbStreamURL.Location = new System.Drawing.Point(11, 170);
            this.tbStreamURL.Name = "tbStreamURL";
            this.tbStreamURL.Size = new System.Drawing.Size(352, 27);
            this.tbStreamURL.TabIndex = 5;
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
            // gbOutput
            // 
            this.gbOutput.Controls.Add(this.tbOutput);
            this.gbOutput.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gbOutput.Location = new System.Drawing.Point(12, 229);
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
            // LivestreamerGuiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 521);
            this.Controls.Add(this.gbOutput);
            this.Controls.Add(this.gbOpenStream);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LivestreamerGuiForm";
            this.Text = "Livestreamer GUI";
            this.gbOpenStream.ResumeLayout(false);
            this.gbOpenStream.PerformLayout();
            this.gbOutput.ResumeLayout(false);
            this.gbOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOpenStream;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ComboBox cbQuality;
        private System.Windows.Forms.TextBox tbStreamURL;
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
    }
}

