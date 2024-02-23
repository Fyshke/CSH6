using System;

namespace CSHSeminarskiRad6
{
    partial class CSH6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Spremi = new System.Windows.Forms.Button();
            this.Učitaj = new System.Windows.Forms.Button();
            this.SvaVelika = new System.Windows.Forms.Button();
            this.PremaPravopisu = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Spremi
            // 
            this.Spremi.Location = new System.Drawing.Point(613, 120);
            this.Spremi.Name = "Spremi";
            this.Spremi.Size = new System.Drawing.Size(131, 57);
            this.Spremi.TabIndex = 2;
            this.Spremi.Text = "Spremi";
            this.Spremi.UseVisualStyleBackColor = true;
            this.Spremi.Click += new System.EventHandler(this.Spremi_Click_1);
            // 
            // Učitaj
            // 
            this.Učitaj.Location = new System.Drawing.Point(613, 57);
            this.Učitaj.Name = "Učitaj";
            this.Učitaj.Size = new System.Drawing.Size(131, 57);
            this.Učitaj.TabIndex = 3;
            this.Učitaj.Text = "Učitaj";
            this.Učitaj.UseVisualStyleBackColor = true;
            this.Učitaj.Click += new System.EventHandler(this.Učitaj_Click_1);
            // 
            // SvaVelika
            // 
            this.SvaVelika.Location = new System.Drawing.Point(613, 411);
            this.SvaVelika.Name = "SvaVelika";
            this.SvaVelika.Size = new System.Drawing.Size(131, 57);
            this.SvaVelika.TabIndex = 4;
            this.SvaVelika.Text = "Sva velika";
            this.SvaVelika.UseVisualStyleBackColor = true;
            this.SvaVelika.Click += new System.EventHandler(this.SvaVelika_Click_1);
            // 
            // PremaPravopisu
            // 
            this.PremaPravopisu.Location = new System.Drawing.Point(613, 348);
            this.PremaPravopisu.Name = "PremaPravopisu";
            this.PremaPravopisu.Size = new System.Drawing.Size(131, 57);
            this.PremaPravopisu.TabIndex = 5;
            this.PremaPravopisu.Text = "Prema pravopisu";
            this.PremaPravopisu.UseVisualStyleBackColor = true;
            this.PremaPravopisu.Click += new System.EventHandler(this.PremaPravopisu_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 57);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(500, 411);
            this.textBox1.TabIndex = 6;
            // 
            // CSH6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 568);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PremaPravopisu);
            this.Controls.Add(this.SvaVelika);
            this.Controls.Add(this.Učitaj);
            this.Controls.Add(this.Spremi);
            this.Name = "CSH6";
            this.Text = "CSH6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Spremi;
        private System.Windows.Forms.Button Učitaj;
        private System.Windows.Forms.Button SvaVelika;
        private System.Windows.Forms.Button PremaPravopisu;
        private System.Windows.Forms.TextBox textBox1;
    }
}

