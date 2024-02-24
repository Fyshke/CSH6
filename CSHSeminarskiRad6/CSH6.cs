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

        private void Spremi_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, textbox.Text);
                }
            }
        }

        private void Učitaj_Click(object sender, EventArgs e)
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

        private void SvaVelika_Click(object sender, EventArgs e)
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
       
        private string[] genText = new string[]
        {
            "C# je razvijen od strane Microsofta! prvi put je objavljen 2000. godine.",
            "Ključne karakteristike C# jezika uključuju tipiziranje, nasljeđivanje, polimorfizam i apstrakciju.",
            "stringovi su nepromjenjivi (immutable)! što znači da se ne mogu mijenjati nakon što su kreirani.",
            "Dž, lj, nj su slova koja se koriste u hrvatskom i drugim jezicima koji koriste latinično pismo, a često se sreću u riječima kao što su džem, ljubav, njega.",
            "C# podržava LINQ (Language Integrated Query), što omogućava programerima da pišu upite direktno unutar koda.",
            "C# ima bogat ekosustav alata i okvira, uključujući ASP.NET za web razvoj, xamarin za razvoj mobilnih aplikacija, Unity za razvoj igara.",
            "koristi li C# Garbage Collector? on nam služi za upravljanje memorijom! oslobađa programere od brige o ručnom upravljanju memorijom.",
            "visual Studio je najpopularnije integrirano razvojno okruženje (IDE) za razvoj C# aplikacija.",
            "C# podržava koncept delegata i događaja! omogućavajući programerima da osjete snagu Observer uzorka, gdje objekti mogu promatrati i reagirati na događaje, kao tajni agenti u svijetu softvera!",
            "windows Forms je tehnologija za stvaranje korisničkih sučelja (GUI) u .NET okruženju, omogućavajući jednostavnu integraciju s drugim .NET tehnologijama."
        };

        private void GenerirajText_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int rgenText = random.Next(genText.Length);
            textbox.Text = genText[rgenText];
        }
    }
}
