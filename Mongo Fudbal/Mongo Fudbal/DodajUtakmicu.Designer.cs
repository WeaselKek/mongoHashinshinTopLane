﻿namespace Mongo_Fudbal
{
    partial class DodajUtakmicu
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
            this.btnTrue = new System.Windows.Forms.Button();
            this.cbxH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxA = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.golH = new System.Windows.Forms.TextBox();
            this.golA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTrue
            // 
            this.btnTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrue.Location = new System.Drawing.Point(193, 325);
            this.btnTrue.Name = "btnTrue";
            this.btnTrue.Size = new System.Drawing.Size(83, 31);
            this.btnTrue.TabIndex = 0;
            this.btnTrue.Text = "Dodaj";
            this.btnTrue.UseVisualStyleBackColor = true;
            this.btnTrue.Click += new System.EventHandler(this.btnTrue_Click);
            // 
            // cbxH
            // 
            this.cbxH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxH.FormattingEnabled = true;
            this.cbxH.Location = new System.Drawing.Point(74, 150);
            this.cbxH.Name = "cbxH";
            this.cbxH.Size = new System.Drawing.Size(150, 25);
            this.cbxH.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Domaci tim";
            // 
            // cbxA
            // 
            this.cbxA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxA.FormattingEnabled = true;
            this.cbxA.Location = new System.Drawing.Point(287, 150);
            this.cbxA.Name = "cbxA";
            this.cbxA.Size = new System.Drawing.Size(150, 25);
            this.cbxA.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gostujuci tim";
            // 
            // dtp1
            // 
            this.dtp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp1.Location = new System.Drawing.Point(130, 60);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(249, 26);
            this.dtp1.TabIndex = 6;
            // 
            // golH
            // 
            this.golH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.golH.Location = new System.Drawing.Point(184, 194);
            this.golH.Name = "golH";
            this.golH.Size = new System.Drawing.Size(40, 24);
            this.golH.TabIndex = 7;
            this.golH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.golH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.golH_KeyPress);
            // 
            // golA
            // 
            this.golA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.golA.Location = new System.Drawing.Point(287, 194);
            this.golA.Name = "golA";
            this.golA.Size = new System.Drawing.Size(40, 24);
            this.golA.TabIndex = 8;
            this.golA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.golA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.golA_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Golovi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(190, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Datum odigravanja:";
            // 
            // DodajUtakmicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 418);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.golA);
            this.Controls.Add(this.golH);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxH);
            this.Controls.Add(this.btnTrue);
            this.Name = "DodajUtakmicu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Utakmica";
            this.Load += new System.EventHandler(this.DodajUtakmicu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTrue;
        private System.Windows.Forms.ComboBox cbxH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.TextBox golH;
        private System.Windows.Forms.TextBox golA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}