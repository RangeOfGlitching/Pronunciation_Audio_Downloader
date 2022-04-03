using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace Pronounciation
{
    public partial class Form1 : Form
    {
        private string cmdOutput;
        private delegate void delegateMethod();

        public Form1()
        {
            InitializeComponent();
            textBox_path.Text = Directory.GetCurrentDirectory();
        }

        private void ExecuteCommand(string command)
        {
            Thread thread = new Thread(() => thread_executeCommand(command));
            thread.Start();

            button_play.Enabled = false;
            button_search.Enabled = false;
            button_open_brownser.Enabled = false;
            textBox_search.Enabled = true;
            UseWaitCursor = true;
        }

        private void RecoverControls()
        {
            // terminate the searching bar
            progressBar_searching.Visible = false;
            UseWaitCursor = false;

            if(cmdOutput.Trim().IndexOf(".mp3") > 0)
            {
                label_result.Text = "File saved successfully!";
                button_play.Enabled = true;
                button_play_Click(null, null);
            }
            else
            {
                string errMessage = "Cannot find the specified word: " + textBox_search.Text;
                label_result.Text = errMessage;
                MessageBox.Show(errMessage, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // enable the other common controls
            button_search.Enabled = true;
            button_open_brownser.Enabled = true;
            textBox_search.Enabled = true;
        }

        public void thread_executeCommand(string command)
        {
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true; //不跳出cmd視窗
            p.StartInfo.Arguments = "/c " + command;

            p.Start();

            p.WaitForExit();
            cmdOutput = p.StandardOutput.ReadToEnd();

            Invoke(new delegateMethod(RecoverControls));
        }

        private void button_open_brownser_Click(object sender, EventArgs e)
        {
            OpenFileDialog folderBrowser = new OpenFileDialog();
            // Set validate names and check file exists to false
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            folderBrowser.FileName = "default.";
            folderBrowser.InitialDirectory = @textBox_path.Text;
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string folderPath = Path.GetDirectoryName(folderBrowser.FileName);
                textBox_path.Text = folderPath;
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            if (textBox_path.TextLength == 0)
                MessageBox.Show("請選擇目錄", "Pronounciation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (textBox_search.TextLength == 0)
                MessageBox.Show("請輸入查詢文字", "Pronounciation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {   // start to execute the programme
                string dir = textBox_path.Text;
                string search_word = textBox_search.Text.ToLower();
                string option_accent = (radioButton_uk.Checked ? "gb" : "us");
                string option_speed = (radioButton_speed_normal.Checked ? "1" : "2");

                ExecuteCommand("start.bat \"" + dir + "\" \"" + search_word + "\" " + option_accent + " " + option_speed);

                button_open_brownser.Enabled = false;
                button_search.Enabled = false;
                textBox_search.Enabled = false;
                label_result.Text = "Searching...";
                progressBar_searching.Visible = true;
            }
        }

        private void textBox_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                button_search_Click(null, null);
            }
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            string dir = textBox_path.Text;

            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = dir + "\\" + cmdOutput;
            wplayer.controls.play();
        }

        private void button_open_dir_Click(object sender, EventArgs e)
        { Process.Start(@textBox_path.Text); }

        private void linkLabel_creditor1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { System.Diagnostics.Process.Start("https://github.com/RangeOfGlitching"); }

        private void linkLabel_creditor2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { System.Diagnostics.Process.Start("https://github.com/Bill-Tsou"); }
    }
}
