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

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                char nextChar = i < input.Length - 1 ? input[i + 1] : '\0'; // ako je i manji od niza, prima sljedeci znak, inace null

                // provjera je li znak slovo
                if (char.IsLetter(currentChar))
                {
                    if (velikoSlovo)
                    {
                        text.Append(char.ToUpper(currentChar));
                        velikoSlovo = false;

                        //provjera dž/DŽ, lj/LJ i nj/NJ
                        if ((currentChar == 'd' || currentChar == 'D' && nextChar == 'ž' || nextChar == 'Ž') ||
                            (currentChar == 'l' || currentChar == 'L' && nextChar == 'j' || nextChar == 'J') ||
                            (currentChar == 'n' || currentChar == 'N' && nextChar == 'j' || nextChar == 'J'))
                        {
                            text.Append(char.ToUpper(nextChar));
                            i++; // nastavlja petlju nakon obrade
                        }
                    }
                    else
                    {
                        text.Append(char.ToLower(currentChar));
                    }
                }

                // provjera interpunkcije
                else if (char.IsPunctuation(currentChar))
                {
                    text.Append(currentChar);
                    velikoSlovo = true; 
                }
                else
                {
                    text.Append(currentChar);
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
