namespace recTimer
{
    partial class frmUpdateMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateMessage));
            this.label1 = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.lbUpdateVersion = new System.Windows.Forms.Label();
            this.btUpdate = new System.Windows.Forms.Button();
            this.pbDownload = new System.Windows.Forms.ProgressBar();
            this.lbDlStatus = new System.Windows.Forms.Label();
            this.rtbChangelog = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbNotification = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ein Update ist verfügbar! Möchsten sie das Update jetzt installieren?";
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Location = new System.Drawing.Point(15, 33);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(35, 13);
            this.lbVersion.TabIndex = 1;
            this.lbVersion.Text = "label2";
            // 
            // lbUpdateVersion
            // 
            this.lbUpdateVersion.AutoSize = true;
            this.lbUpdateVersion.Location = new System.Drawing.Point(15, 48);
            this.lbUpdateVersion.Name = "lbUpdateVersion";
            this.lbUpdateVersion.Size = new System.Drawing.Size(35, 13);
            this.lbUpdateVersion.TabIndex = 2;
            this.lbUpdateVersion.Text = "label2";
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(413, 267);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 3;
            this.btUpdate.Text = "Start Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // pbDownload
            // 
            this.pbDownload.Location = new System.Drawing.Point(15, 267);
            this.pbDownload.Name = "pbDownload";
            this.pbDownload.Size = new System.Drawing.Size(311, 22);
            this.pbDownload.TabIndex = 4;
            // 
            // lbDlStatus
            // 
            this.lbDlStatus.AutoSize = true;
            this.lbDlStatus.Location = new System.Drawing.Point(15, 251);
            this.lbDlStatus.Name = "lbDlStatus";
            this.lbDlStatus.Size = new System.Drawing.Size(0, 13);
            this.lbDlStatus.TabIndex = 5;
            // 
            // rtbChangelog
            // 
            this.rtbChangelog.Location = new System.Drawing.Point(6, 19);
            this.rtbChangelog.Name = "rtbChangelog";
            this.rtbChangelog.ReadOnly = true;
            this.rtbChangelog.Size = new System.Drawing.Size(461, 135);
            this.rtbChangelog.TabIndex = 6;
            this.rtbChangelog.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbChangelog);
            this.groupBox1.Location = new System.Drawing.Point(15, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 160);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Changelog";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Abbrechen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbNotification
            // 
            this.cbNotification.AutoSize = true;
            this.cbNotification.Location = new System.Drawing.Point(278, 35);
            this.cbNotification.Name = "cbNotification";
            this.cbNotification.Size = new System.Drawing.Size(182, 30);
            this.cbNotification.TabIndex = 9;
            this.cbNotification.Text = "Diese Meldung das Nächste mal \r\nnicht mehr anzeigen.\r\n";
            this.cbNotification.UseVisualStyleBackColor = true;
            this.cbNotification.CheckedChanged += new System.EventHandler(this.cbNotification_CheckedChanged);
            // 
            // frmUpdateMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 302);
            this.Controls.Add(this.cbNotification);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbDlStatus);
            this.Controls.Add(this.pbDownload);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.lbUpdateVersion);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUpdateMessage";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.frmUpdateMessage_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Label lbUpdateVersion;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.ProgressBar pbDownload;
        private System.Windows.Forms.Label lbDlStatus;
        private System.Windows.Forms.RichTextBox rtbChangelog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbNotification;
    }
}