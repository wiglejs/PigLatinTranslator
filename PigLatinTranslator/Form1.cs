using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PigLatinTranslator
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txt_english.Text = "";
            txt_piglatin.Text = "";
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            string englsih = txt_english.Text.Trim();
            if (!String.IsNullOrEmpty(txt_english.Text))
            { 
                string[] words = englsih.Split(' ');
                string piglatin = "";
                foreach (string word in words)
                {
                    piglatin += TranslateWord(word) + " ";
                }
                txt_piglatin.Text = piglatin;
            }
            else
            {
                MessageBox.Show("You must enter text.", "Enter");
                txt_english.Focus();
            }
        }

        private string TranslateWord(string word)
        {
            return word;
        }
    }
}
