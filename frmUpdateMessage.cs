using recTimer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static recTimer.clsUpdate;

namespace recTimer
{
    public partial class frmUpdateMessage : Form
    {
        public static string downloadURL = "https://github.com/zekroTJA/zekros-recording-Tool/releases", newestversion;

        public frmUpdateMessage()
        {
            InitializeComponent();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {

            //System.Diagnostics.Process.Start(downloadURL);
            WebClient client = new WebClient();

            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(dlProgressChanged);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(dlComplete);
            client.DownloadFileAsync(new Uri(getUpdateUrl()), "recTimerUpdate.exe");
            

        }

        private void dlProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            lbDlStatus.Text = "Downloading: " + (e.BytesReceived / 1024) + " kB / " + (e.TotalBytesToReceive / 1024) + " kB"; 
            pbDownload.Value = e.ProgressPercentage;
        }

        private void dlComplete(object sender, AsyncCompletedEventArgs e)
        {
            pbDownload.Style = ProgressBarStyle.Marquee;
            MessageBox.Show("Erfolgreich heruntergeladen! Das Programm wird jetzt neu gestartet um den Updatevorgang zu beenden.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            updateInstaller();
            System.Diagnostics.Process.Start("update.bat");
            Application.Exit();
        }

        private void frmUpdateMessage_Load(object sender, EventArgs e)
        {
            lbVersion.Text =        "Installierte Version:    " + clsConst.buildVersion;
            lbUpdateVersion.Text =  "Aktuellste Version:    " + clsUpdate.newestversion;
            rtbChangelog.Text = getChangelog(clsConst.cangelogUrl);
        }

        private void updateInstaller()
        {
            StreamWriter writer = new StreamWriter("update.bat");
            writer.WriteLine("@echo off");
            writer.WriteLine("title updater");
            writer.WriteLine("if exist recTimer.exe (");
            writer.WriteLine("  del recTimer.exe");
            writer.WriteLine("  if exist recTimerUpdate.exe (");
            writer.WriteLine("	    ren recTimerUpdate.exe recTimer.exe )");
            writer.WriteLine("      start recTimer.exe");
            writer.WriteLine("      del update.bat");
            writer.WriteLine(") else (");
            writer.WriteLine("	echo ACHTUNG! Sie habe die Datei recTimer.exe höchst wahrscheinlich umbenannt!");
            writer.WriteLine("	echo Dies führt dazu, dass die Applikation nicht mit der Update-Datei ersetzt werden kann!");
            writer.WriteLine("	pause > nul");
            writer.WriteLine("  del update.bat )");
            writer.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbNotification_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNotification.Checked)
                Settings.Default.updates = false;
        }

        public string getChangelog(string onlineFileUrl)
        {
            WebClient client = new WebClient();
            Stream stream = client.OpenRead(onlineFileUrl);
            StreamReader reader = new StreamReader(stream);
            return reader.ReadToEnd();
        }
    }
}
