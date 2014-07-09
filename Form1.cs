using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

// Tosil Velkov - tosil@velkoff.net

namespace Youtube_dl_WinGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Check_YoutubeDL();
            
        }

        private static bool Check_YoutubeDL()
        {
            if (!File.Exists("youtube-dl.exe"))
            {
                MessageBox.Show("Cannot find Youtube-dl.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private void Checkbutton_Click(object sender, EventArgs e)
        {
            if (Check_YoutubeDL()) return;
            Process startprog = new Process();
            
           // ProcessStartInfo startprog = new ProcessStartInfo();        
            startprog.StartInfo.FileName = "youtube-dl.exe";
            startprog.StartInfo.Arguments = "-F " + URLbox.Text;
            startprog.StartInfo.UseShellExecute = false;
            startprog.StartInfo.RedirectStandardOutput = true;
            startprog.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startprog.StartInfo.CreateNoWindow = true;
            startprog.Start();
            string output = startprog.StandardOutput.ReadToEnd();
            startprog.WaitForExit();

            string[] output1 = output.Split('\n');
            Formatbox.Items.Clear();

            int showPlace = 0;
            for (int i = 0; i < output1.Length; i++ )
            {
                if (output1[i].Contains("[info] Available formats for")) showPlace = i;
            }
            if (File.Exists("ffmpeg.exe"))
                Formatbox.Items.Add("bestvideo+bestaudio           BEST VIDEO+AUDIO - FFMPEG MERGE");
            Formatbox.Items.Add("bestvideo              BEST VIDEO");
            Formatbox.Items.Add("bestaudio              BEST Audio");

            for (int i = showPlace + 2; i < output1.Length; i++ )
            {
                Formatbox.Items.Add(output1[i]);
            }

        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            if (Check_YoutubeDL()) return;
            if (this.Formatbox.SelectedIndex == -1) return;
            string choice = Formatbox.SelectedItem.ToString();
            choice = choice.Substring(0, choice.IndexOf(" "));
            //DebugLabel.Text = choice;

            Process startprogd = new Process();

            // ProcessStartInfo startprog = new ProcessStartInfo();        
            startprogd.StartInfo.FileName = "youtube-dl.exe";

            //DebugLabel.Text = "DestBox = " + this.DestinationBox.Text.ToString() + "\n";

            if (string.IsNullOrWhiteSpace(this.DestinationBox.Text.ToString()))
            {
                startprogd.StartInfo.Arguments = "-f " + choice + " " + URLbox.Text;
               // DebugLabel.Text = "-f " + choice + " " + URLbox.Text;
            }
            else
            {
                startprogd.StartInfo.Arguments = "-f " + choice + " " + URLbox.Text + @" -o """ + this.DestinationBox.Text.ToString().Trim() + @"\%(title)s-%(id)s.%(ext)s""";
               // DebugLabel.Text = startprogd.StartInfo.Arguments.ToString() + "\n";
            }
           
            // startprogd.StartInfo.UseShellExecute = false;
            // startprogd.StartInfo.RedirectStandardOutput = true;
            // startprogd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            // startprogd.StartInfo.CreateNoWindow = true;
            startprogd.Start();
            // string output = startprogd.StandardOutput.ReadToEnd();
            // startprogd.WaitForExit();
            // DebugLabel.Text += output;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.DestinationBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void URLbox_Click(object sender, EventArgs e)
        {

            URLbox.Text = Clipboard.GetText();
            URLbox.SelectAll();
        }
    }
}
