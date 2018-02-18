namespace Mongo_Fudbal
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbGol = new System.Windows.Forms.TextBox();
            this.txbDrzava = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbIme
            // 
            this.txbIme.Location = new System.Drawing.Point(27, 59);
            this.txbIme.Name = "txbIme";
            this.txbIme.Size = new System.Drawing.Size(369, 20);
            this.txbIme.TabIndex = 0;
            // 
            // txbPrez
            // 
            this.txbPrez.Location = new System.Drawing.Point(27, 118);
            this.txbPrez.Name = "txbPrez";
            this.txbPrez.Size = new System.Drawing.Size(368, 20);
            this.txbPrez.TabIndex = 1;
            // 
            // txbGod
            // 
            this.txbGod.Location = new System.Drawing.Point(27, 171);
            this.txbGod.Name = "txbGod";
            this.txbGod.Size = new System.Drawing.Size(95, 20);
            this.txbGod.TabIndex = 2;
            // 
            // btnTrue
            // 
            this.btnTrue.Location = new System.Drawing.Point(31, 448);
            this.btnTrue.Name = "btnTrue";
            this.btnTrue.Size = new System.Drawing.Size(180, 28);
            this.btnTrue.TabIndex = 3;
            this.btnTrue.Text = "Prihvati";
            this.btnTrue.UseVisualStyleBackColor = true;
            this.btnTrue.Click += new System.EventHandler(this.btnTrue_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(409, 448);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(163, 27);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Godina rodjenja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Broj Golova";
            // 
            // txbGol
            // 
            this.txbGol.Location = new System.Drawing.Point(27, 240);
            this.txbGol.Name = "txbGol";
            this.txbGol.Size = new System.Drawing.Size(85, 20);
            this.txbGol.TabIndex = 9;
            // 
            // txbDrzava
            // 
            this.txbDrzava.Location = new System.Drawing.Point(220, 175);
            this.txbDrzava.Name = "txbDrzava";
            this.txbDrzava.Size = new System.Drawing.Size(175, 20);
            this.txbDrzava.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Drzava";
            // 
            // FormFudbaler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 494);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbDrzava);
            this.Controls.Add(this.txbGol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnTrue);
            this.Controls.Add(this.txbGod);
            this.Controls.Add(this.txbPrez);
            this.Controls.Add(this.txbIme);
            this.Name = "FormFudbaler";
            this.Text = "FormFudbaler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbIme;
        private System.Windows.Forms.TextBox txbPrez;
        private System.Windows.Forms.TextBox txbGod;
        private System.Windows.Forms.Button btnTrue;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbGol;
        private System.Windows.Forms.TextBox txbDrzava;
        private System.Windows.Forms.Label label5;
    }
}