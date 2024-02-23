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
                    File.WriteAllText(saveFileDialog.FileName, textBox1.Text);
                }
            }
        }



    }
}
