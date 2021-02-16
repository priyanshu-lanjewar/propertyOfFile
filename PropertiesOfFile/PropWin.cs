using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertiesOfFile
{
    public partial class PropWin : Form
    {
        public PropWin(String locn, String page, String words, String charAll,String charAllWOS, String upper, String lower, String special)
        {
            InitializeComponent();
            loc.Text = locn;
            noPages.Text = page;
            totalWords.Text = words;
            totalCharAll.Text = charAll;
            totalUpper.Text = upper;
            totalLower.Text = lower;
            totalSpecial.Text = special;
            totalCharAllWithoutSpace.Text = charAllWOS;


        }
        public PropWin(String kk)
        {
            InitializeComponent();
            loc.Text = kk;
        }
        private void tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PropWin_Load(object sender, EventArgs e)
        {

        }
        private void PropWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
