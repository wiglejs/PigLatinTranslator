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

        private string TranslateWordWithCaps(string word)
        {
            string punct = "";
            if (word.EndsWith(".") || word.EndsWith(",") || word.EndsWith(";") ||
                word.EndsWith(":") || word.EndsWith("!") || word.EndsWith("?"))
            {
                punct = word.Substring(word.Length - 1);
                word = word.Remove(word.Length - 1, 1);
            }

            word = TranslateWord(word);
            word += punct;
             
            return word;
            
        }


            private string TranslateWord(string word)
        {
            char c = word[0];
            if (c == 'a' || c== 'e' || c == 'i' || c == 'o' || c == 'u' ||
                c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
            {
                word += "way";
            }
            else
            {
                if (c == 'y' || c == 'Y')
                {
                    word = word.Remove(0, 1);
                    word += c.ToString();
                    c = word[0];
                }
                while (c != 'a' && c != 'e' && c != 'i' && c != 'o' && c != 'u' && c != 'y' &&
                       c != 'A' && c != 'E' && c != 'I' && c != 'O' && c != 'U' && c != 'Y')
                {
                    word = word.Remove(0, 1);
                    word += c.ToString();
                    c = word[0];
                }
                word += "ay";
            }


            return word;
        }
    }
}
