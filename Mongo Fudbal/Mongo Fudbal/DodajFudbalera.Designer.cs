﻿namespace Mongo_Fudbal
{
    partial class DodajFudbalera
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
            this.txbIme = new System.Windows.Forms.TextBox();
            this.txbPrez = new System.Windows.Forms.TextBox();
            this.txbGod = new System.Windows.Forms.TextBox();
            this.btnTrue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbDrzava = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSlika = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txbIme
            // 
            this.txbIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIme.Location = new System.Drawing.Point(95, 65);
            this.txbIme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbIme.Name = "txbIme";
            this.txbIme.Size = new System.Drawing.Size(491, 28);
            this.txbIme.TabIndex = 0;
            // 
            // txbPrez
            // 
            this.txbPrez.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrez.Location = new System.Drawing.Point(95, 138);
            this.txbPrez.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbPrez.Name = "txbPrez";
            this.txbPrez.Size = new System.Drawing.Size(491, 28);
            this.txbPrez.TabIndex = 1;
            // 
            // txbGod
            // 
            this.txbGod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGod.Location = new System.Drawing.Point(95, 219);
            this.txbGod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbGod.Name = "txbGod";
            this.txbGod.Size = new System.Drawing.Size(100, 28);
            this.txbGod.TabIndex = 2;
            this.txbGod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbGod_KeyPress);
            // 
            // btnTrue
            // 
            this.btnTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrue.Location = new System.Drawing.Point(234, 382);
            this.btnTrue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTrue.Name = "btnTrue";
            this.btnTrue.Size = new System.Drawing.Size(181, 46);
            this.btnTrue.TabIndex = 3;
            this.btnTrue.Text = "Dodaj";
            this.btnTrue.UseVisualStyleBackColor = true;
            this.btnTrue.Click += new System.EventHandler(this.btnTrue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(91, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(91, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Godina rodjenja";
            // 
            // txbDrzava
            // 
            this.txbDrzava.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDrzava.Location = new System.Drawing.Point(352, 219);
            this.txbDrzava.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbDrzava.Name = "txbDrzava";
            this.txbDrzava.Size = new System.Drawing.Size(234, 28);
            this.txbDrzava.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(348, 190);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Drzava";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(95, 306);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "Izaberi sliku";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSlika
            // 
            this.lblSlika.BackColor = System.Drawing.Color.Transparent;
            this.lblSlika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlika.ForeColor = System.Drawing.Color.White;
            this.lblSlika.Location = new System.Drawing.Point(268, 314);
            this.lblSlika.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSlika.Name = "lblSlika";
            this.lblSlika.Size = new System.Drawing.Size(318, 25);
            this.lblSlika.TabIndex = 13;
            this.lblSlika.Text = "Nije izbrana slika";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DodajFudbalera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(678, 461);
            this.Controls.Add(this.lblSlika);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbDrzava);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTrue);
            this.Controls.Add(this.txbGod);
            this.Controls.Add(this.txbPrez);
            this.Controls.Add(this.txbIme);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DodajFudbalera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fudbaler";
            this.Load += new System.EventHandler(this.DodajFudbalera_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbIme;
        private System.Windows.Forms.TextBox txbPrez;
        private System.Windows.Forms.TextBox txbGod;
        private System.Windows.Forms.Button btnTrue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbDrzava;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSlika;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}