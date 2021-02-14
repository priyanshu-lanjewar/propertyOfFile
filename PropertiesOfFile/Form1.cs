using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertiesOfFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void selectFile_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Select A File";
            openDialog.Filter =  "Microsoft Office Document (*.docx)|*.docx";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string file = openDialog.FileName;
                fileName.Text = file;
               }
        }

        private void fileName_TextChanged(object sender, EventArgs e)
        {

        }
        private void calculate_Click(object sender, EventArgs e)
        {
            if (fileName.Text == "" || fileName.Text == "Please Choose .docx File To Proceed.")
            {
                fileName.Text = "Please Choose .docx File To Proceed.";
            }
            else
            {
                Program.FileProcess F = new Program.FileProcess(fileName.Text,confFileLoc.Text);
                calculate.Enabled = false;
                calculate.Text = "Processing...";
                Cursor.Current = Cursors.WaitCursor;
                F.StartCount();
                Cursor.Current = Cursors.Default;
                calculate.Enabled = true;
                calculate.Text = "Click here to Start";
                process.Value = 0;
            }

        }

        public static void setMax(int max)
        {
            process.Maximum = max;
            process.Minimum = 0;
            process.Value = 0;
        }
        public static void updateProgressbar()
        {
            process.Value++;
        }

        private void anekaConfig_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Select Configuration File";
            openDialog.Filter = "Configuration File (*.xml)|*.xml";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string file = openDialog.FileName;
                confFileLoc.Text = file;
            }
        }
    }
}
