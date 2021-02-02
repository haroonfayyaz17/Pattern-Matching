using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AlgorithmsAssignment5
{
    public partial class Findbox : Form
    {
        public List<String> fileNames = new List<string>();
        private static int asciiCharacters = 256;
        private static int primeNumber = 97;
        public Findbox()
        {
            InitializeComponent();
            //FormBorderStyle = FormBorderStyle.None;
            //WindowState = FormWindowState.Maximized;
        }

        private void Findbox_Load(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (dropdownAlgo.Text == "")
            {
                MessageBox.Show("Please Select an Algorithm");
                return;

            }
            else if (txtWord.Text.Equals(""))
            {
                MessageBox.Show("Please enter a word");
                return;
            }
            if (fileNames.Capacity == 0)
            {
                MessageBox.Show("No Folder Selected");
                return;

            }
            richFileContent.Text = "";
            bool searchFile = true;
            for (int i = 0; i < fileNames.Count; i++)
            {
                String fileName = Path.GetFileName(fileNames[i]);
                String line;
                StreamReader file = new StreamReader(fileNames[i]);
                int row = 0;
                if (searchFile)
                {
                    while ((line = file.ReadLine()) != null)
                    {
                        row++;
                        if (dropdownAlgo.Text.Equals("Brute Force"))
                        {
                            if (checkboxMatchCase.Checked)
                            {
                                BruteForce(line, txtWord.Text, row, fileName, checkboxWholeWord.Checked);


                            }
                            else
                            {
                                BruteForce(line.ToLower(), txtWord.Text.ToLower(), row, fileName, checkboxWholeWord.Checked);

                            }
                        }
                        else if (dropdownAlgo.Text.Equals("Knuth-Morris-Pratt"))
                        {
                            if (checkboxMatchCase.Checked)
                            {
                                KMP(line, txtWord.Text, row, fileName, checkboxWholeWord.Checked);


                            }
                            else
                            {
                                KMP(line.ToLower(), txtWord.Text.ToLower(), row, fileName, checkboxWholeWord.Checked);

                            }
                        }
                        else if (dropdownAlgo.Text.Equals("Rabin-Karp"))
                        {
                            if (checkboxMatchCase.Checked)
                            {
                                RabinKarp(line, txtWord.Text, row, fileName, checkboxWholeWord.Checked);


                            }
                            else
                            {
                                RabinKarp(line.ToLower(), txtWord.Text.ToLower(), row, fileName, checkboxWholeWord.Checked);

                            }
                        }
                        else
                        {
                            MessageBox.Show("Not a valid algorithm");
                        }


                    }
                }
                if (i + 1 >= fileNames.Count)
                {
                    MessageBox.Show("Finish Searching all files in current folder");
                    return;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to search " + Path.GetFileName(fileNames[i + 1]) + " ?", "Searching", MessageBoxButtons.YesNoCancel);
                    if (dialogResult == DialogResult.Cancel)
                    {
                        break;
                    }

                    else if (dialogResult == DialogResult.Yes)
                    {
                        searchFile = true;
                    }
                    else
                    {
                        i++;
                        searchFile = false;
                    }

                }
            }
        }

        private void checkboxMatchCase_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {

            //OpenFileDialog openFileDialog1 = new OpenFileDialog
            //{
            //    InitialDirectory = @"C:\Desktop",
            //    Title = "Browse Text Files",

            //    CheckFileExists = true,
            //    CheckPathExists = true,

            //    DefaultExt = "txt",
            //    Filter = "txt files (*.txt)|*.txt",
            //    FilterIndex = 2,
            //    RestoreDirectory = true,

            //    ReadOnlyChecked = true,
            //    ShowReadOnly = true
            //};


            using (var fbd = new FolderBrowserDialog { })
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    foreach (string file in Directory.EnumerateFiles(fbd.SelectedPath, "*.txt"))
                    {
                        fileNames.Add(file);
                    }


                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        void BruteForce(String row, String pattern, int rowNo, String fileName, bool whole)
        {
            int rowLength = row.Length;
            int patternLength = pattern.Length;
            int j = 0;
            for (int i = 0; i < rowLength; i++)
            {
                if (row[i] == pattern[j])
                {
                    j++;
                }
                else
                {
                    j = 0;
                }

                if (j == patternLength)
                {
                    if (whole)
                    {
                        bool checkBefore = false;
                        bool checkAfter = false;

                        if (i - j == -1 || row[i - j] == ' ')
                            checkBefore = true;
                        if (i + 1 == row.Length || row[i + 1] == ' ')
                            checkAfter = true;
                        if (checkBefore && checkAfter)
                            richFileContent.Text = richFileContent.Text + "Found in file:" + fileName + " at:- Row: " + rowNo.ToString() + ",  column: " + (i-j+2).ToString() + "\n";

                    }
                    else
                        richFileContent.Text = richFileContent.Text + "Found in file:" + fileName + " at:- Row: " + rowNo.ToString() + ",  column: " + (i-j+2).ToString() + "\n";

                    //MessageBox.Show("Found At:-\nRow: "+rowNo.ToString()+",  column: " + (i + 1).ToString());

                    //return i;
                    j = 0;
                }


            }
            //return -1;
            return;

        }


        void KMP(String row, String pattern, int rowNo, String fileName, bool whole)
        {
            int rowLength = row.Length;
            int patternLength = pattern.Length;

            int[] prefixArray = new int[patternLength];
            int j = 0;

            getLPrefixArray(pattern, patternLength, prefixArray);

            int i = 0;
            while (i < rowLength)
            {
                if (pattern[j] == row[i])
                {
                    j++;
                    i++;
                }
                if (j == patternLength)
                {
                    if (whole)
                    {
                        bool checkBefore = false;
                        bool checkAfter = false;

                        if (i-j >= -1 || row[i - j] == ' ')
                            checkBefore = true;
                        if (i + j == row.Length || row[i + j] == ' ')
                            checkAfter = true;
                        if (checkBefore && checkAfter)
                            richFileContent.Text = richFileContent.Text + "Found in file:" + fileName + " at:- Row: " + rowNo.ToString() + ",  column: " + (i - j + 1).ToString() + "\n";

                    }
                    else
                        richFileContent.Text = richFileContent.Text + "Found in file:" + fileName + " at:- Row: " + rowNo.ToString() + ",  column: " + (i - j + 1).ToString() + "\n";
                    j = prefixArray[j - 1];
                }

                else if (i < rowLength && pattern[j] != row[i])
                {

                    if (j != 0)
                        j = prefixArray[j - 1];
                    else
                        i = i + 1;
                }
            }
        }

        void getLPrefixArray(string pattern, int patternLength, int[] prefixArray)
        {
            int i = 1;
            int prefixLength = 0;
            prefixArray[0] = 0;

            while (i < patternLength)
            {
                if (pattern[i] == pattern[prefixLength])
                {
                    prefixLength++;
                    prefixArray[i] = prefixLength;
                    i++;
                }
                else
                {
                    if (prefixLength != 0)
                    {
                        prefixLength = prefixArray[prefixLength - 1];

                    }
                    else
                    {
                        prefixArray[i] = prefixLength;
                        i++;
                    }
                }
            }
        }

        void RabinKarp(String row, String pattern, int rowNo, String fileName, bool whole)
        {
            int rowLength = row.Length;
            int patternLength = pattern.Length;

            if (rowLength < patternLength)
                return;

            int patternHash = 0;
            int rowHash = 0;
            int hashValue = 1;


            for (int i = 0; i < patternLength - 1; i++)
                hashValue = (hashValue * asciiCharacters) % primeNumber;

            for (int i = 0; i < patternLength; i++)
            {
                patternHash = (asciiCharacters * patternHash + pattern[i]) % primeNumber;
                rowHash = (asciiCharacters * rowHash + row[i]) % primeNumber;
            }

            for (int i = 0; i <= rowLength - patternLength; i++)
            {
                if (patternHash == rowHash)
                {
                    int j;
                    for (j = 0; j < patternLength; j++)
                    {
                        if (row[i + j] != pattern[j])
                            break;
                    }

                    if (j == patternLength)
                    {
                        if (whole)
                        {
                            bool checkBefore = false;
                            bool checkAfter = false;

                            if (i - 1 == -1 || row[i - 1] == ' ')
                                checkBefore = true;
                            if (i + j == row.Length || row[i + j] == ' ')
                                checkAfter = true;
                            if (checkBefore && checkAfter)
                                richFileContent.Text = richFileContent.Text + "Found in file:" + fileName + " at:- Row: " + rowNo.ToString() + ",  column: " + (i+1).ToString() + "\n";

                        }
                        else
                            richFileContent.Text = richFileContent.Text + "Found in file:" + fileName + " at:- Row: " + rowNo.ToString() + ",  column: " + (i + 1).ToString() + "\n";

                    }
                    
                }
                if (i < rowLength - patternLength)
                {
                    rowHash = (asciiCharacters * (rowHash - row[i] * hashValue) + row[i + patternLength]) % primeNumber;
                    if (rowHash < 0)
                        rowHash = (rowHash + primeNumber);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
