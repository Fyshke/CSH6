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
            this.textbox = new System.Windows.Forms.TextBox();
            this.Original = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Spremi
            // 
            this.Spremi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Spremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spremi.Location = new System.Drawing.Point(225, 29);
            this.Spremi.Name = "Spremi";
            this.Spremi.Size = new System.Drawing.Size(143, 57);
            this.Spremi.TabIndex = 2;
            this.Spremi.Text = "Spremi";
            this.Spremi.UseVisualStyleBackColor = false;
            this.Spremi.Click += new System.EventHandler(this.Spremi_Click_1);
            // 
            // Učitaj
            // 
            this.Učitaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Učitaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Učitaj.Location = new System.Drawing.Point(76, 29);
            this.Učitaj.Name = "Učitaj";
            this.Učitaj.Size = new System.Drawing.Size(143, 57);
            this.Učitaj.TabIndex = 3;
            this.Učitaj.Text = "Učitaj";
            this.Učitaj.UseVisualStyleBackColor = false;
            this.Učitaj.Click += new System.EventHandler(this.Učitaj_Click_1);
            // 
            // SvaVelika
            // 
            this.SvaVelika.BackColor = System.Drawing.Color.IndianRed;
            this.SvaVelika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SvaVelika.Location = new System.Drawing.Point(738, 167);
            this.SvaVelika.Name = "SvaVelika";
            this.SvaVelika.Size = new System.Drawing.Size(143, 69);
            this.SvaVelika.TabIndex = 4;
            this.SvaVelika.Text = "Sva velika";
            this.SvaVelika.UseVisualStyleBackColor = false;
            this.SvaVelika.Click += new System.EventHandler(this.SvaVelika_Click_1);
            // 
            // PremaPravopisu
            // 
            this.PremaPravopisu.BackColor = System.Drawing.Color.IndianRed;
            this.PremaPravopisu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PremaPravopisu.Location = new System.Drawing.Point(738, 92);
            this.PremaPravopisu.Name = "PremaPravopisu";
            this.PremaPravopisu.Size = new System.Drawing.Size(143, 69);
            this.PremaPravopisu.TabIndex = 5;
            this.PremaPravopisu.Text = "Prema pravopisu";
            this.PremaPravopisu.UseVisualStyleBackColor = false;
            this.PremaPravopisu.Click += new System.EventHandler(this.PremaPravopisu_Click);
            // 
            // textbox
            // 
            this.textbox.BackColor = System.Drawing.SystemColors.Window;
            this.textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox.Location = new System.Drawing.Point(76, 92);
            this.textbox.Multiline = true;
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(656, 219);
            this.textbox.TabIndex = 6;
            // 
            // Original
            // 
            this.Original.BackColor = System.Drawing.Color.IndianRed;
            this.Original.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Original.Location = new System.Drawing.Point(738, 242);
            this.Original.Name = "Original";
            this.Original.Size = new System.Drawing.Size(143, 69);
            this.Original.TabIndex = 7;
            this.Original.Text = "Original";
            this.Original.UseVisualStyleBackColor = false;
            this.Original.Click += new System.EventHandler(this.Original_Click);
            // 
            // CSH6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 371);
            this.Controls.Add(this.Original);
            this.Controls.Add(this.textbox);
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
        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.Button Original;
    }
}

