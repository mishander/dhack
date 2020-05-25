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
            if (res.TryGetValue("NameText", out KeyValuePair<string, bool> nameText))
            {
                NameText.Text = nameText.Key;
            }
            if (res.TryGetValue("RecognizedMainText", out KeyValuePair<string, bool> mainText))
            {
                RecognizedMainText.Text = mainText.Key;
            }
            if (res.TryGetValue("DocNumberText", out KeyValuePair<string, bool> docNum))
            {
                DocNumberText.Text = docNum.Key;
            }
            if (res.TryGetValue("DocNumberDate", out KeyValuePair<string, bool> docDate))
            {
                DocNumberDate.Text = docDate.Key;
            }
            if (res.TryGetValue("ApplicantText", out KeyValuePair<string, bool> appName))
            {
                ApplicantText.Text = appName.Key;
            }
            if (res.TryGetValue("INNumberText", out KeyValuePair<string, bool> intext))
            {
                INNumberText.Text = intext.Key;
            }
            if (res.TryGetValue("INNumberDate", out KeyValuePair<string, bool> indate))
            {
                INNumberDate.Text = indate.Key;
            }
            if (res.TryGetValue("InventionText", out KeyValuePair<string, bool> invention))
            {
                InventionText.Text = invention.Key;
            }
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

        private void LoadFile(string filename)
        {
            this.MainText.Text = "";
            this.ApplicantText.Clear();
            this.DocNumberDate.Clear();
            this.DocNumberText.Clear();
            this.NameText.Clear();
            this.RecognizedMainText.Clear();
            this.INNumberText.Clear();
            this.INNumberDate.Clear();
            this.InventionText.Clear();
            this.pictureBox1.Image = Image.FromFile(filename);
            this.pictureBox1.Refresh();
            var proc = new Process();
            proc.StartInfo.WorkingDirectory = Environment.CurrentDirectory;
            proc.StartInfo.FileName = "..\\..\\..\\..\\Tesseract_bin\\tesseract.exe";
            proc.StartInfo.Arguments = "-l ukr+eng " + filename + " " + filename;
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
                    //line = Regex.Replace(line, @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline);
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

        public Form1()
        {
            InitializeComponent();
            string line = MainText.Text;
            RegexSearch(line);
            //Open();
            SetForegroundWindow(Handle.ToInt32());
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
