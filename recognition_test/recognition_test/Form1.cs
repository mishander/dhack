using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using Parser;

namespace recognition_test
{
    public partial class Form1 : Form
    {
        [DllImport("User32.dll")]
        public static extern Int32 SetForegroundWindow(int hWnd);


        private string[] files;
        private int current_index = 0;
        private void RegexSearch(string line)
        {
            Dictionary<string, KeyValuePair<string, bool>> res = RegexParser.RegexSearch(line);
            NameText.Text = res["NameText"].Key;
            RecognizedMainText.Text = res["RecognizedMainText"].Key;
            DocNumberText.Text = res["DocNumberText"].Key;
            DocNumberFullText.Text = res["DocNumberFullText"].Key;
            ppText.Text = res["ppText"].Key;
        }
        private void Open()
        {
            using (var fbd = folderBrowserDialog1)
            {
                fbd.Description = "Select a folder for recognition:";
                fbd.ShowNewFolderButton = false;
                fbd.SelectedPath = Properties.Settings.Default.Folder_Path;
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    files = Directory.GetFiles(fbd.SelectedPath, "*.jpg");
                }
                else {
                    Environment.Exit(1);
                }
            }
            string filename = files[current_index];
            current_index++;
            LoadFile(filename);
            buttonNext.Enabled = true;
            buttonPrev.Enabled = true;
        }
        public Form1()
        {
            InitializeComponent();
            string line = MainText.Text;
            RegexSearch(line);
            //Open();
            SetForegroundWindow(Handle.ToInt32());
        }

        private void LoadFile(string filename)
        {
            this.MainText.Text = "";
            this.ppText.Clear();
            this.DocNumberFullText.Clear();
            this.DocNumberText.Clear();
            this.NameText.Clear();
            this.RecognizedMainText.Clear();
            this.pictureBox1.Image = Image.FromFile(filename);
            this.pictureBox1.Refresh();
            var proc = new Process();
            proc.StartInfo.FileName = "C:\\Program Files\\Tesseract-OCR\\tesseract.exe";
            proc.StartInfo.Arguments = "-l ukr " + filename + " " + filename;
            proc.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            proc.Start();
            proc.WaitForExit();
            var exitCode = proc.ExitCode;
            proc.Close();
            string line = "";
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(filename + ".txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    line = sr.ReadToEnd();
                    line = Regex.Replace(line, @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline);
                    line = Regex.Replace(line, @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline);
                    this.MainText.Text = line;
                }
            }
            catch (IOException ee)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ee.Message);
            }

            //regex:
            RegexSearch(line);
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                LoadFile(files[current_index++]);
            }
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            LoadFile(files[current_index--]);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            LoadFile(files[current_index++]);
        }
    }
}
