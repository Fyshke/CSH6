using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CSHSeminarskiRad6
{
    public partial class CSH6 : Form
    {

        private string originalText;

        public CSH6()
        {
            InitializeComponent();
        }

        private void Spremi_Click_1(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, textbox.Text);
                }
            }
        }

        private void Učitaj_Click_1(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textbox.Text = File.ReadAllText(openFileDialog.FileName);
                    originalText = textbox.Text;
                }
            }
        }

        private void SvaVelika_Click_1(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text.ToUpper();
        }

        private void PremaPravopisu_Click(object sender, EventArgs e)
        {
            textbox.Text = PremaPravopis(textbox.Text);
        }

        private string PremaPravopis(string input)
        {
            var text = new StringBuilder();
            bool velikoSlovo = true;
           

            foreach (char c in input)
            {

                //provjera je li znak slovo
                if (char.IsLetter(c))
                {
                    if (velikoSlovo)
                    {
                        text.Append(char.ToUpper(c));
                        velikoSlovo = false;
                    }
                    else
                    {
                        text.Append(char.ToLower(c));
                    }
                }

                //provjera interpunkcije
                else if (char.IsPunctuation(c))
                {
                    text.Append(c);
                    velikoSlovo = true;
                }
                else
                {
                    text.Append(c);
                }
            }

            return text.ToString();
        }

        private void Original_Click(object sender, EventArgs e)
        {
            textbox.Text = originalText;
        }
    }
}
