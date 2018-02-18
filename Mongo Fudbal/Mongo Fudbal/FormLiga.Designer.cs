namespace Mongo_Fudbal
{
    partial class FormLiga
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
            this.lblNazivLige = new System.Windows.Forms.Label();
            this.Klubovi = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Klubovi.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNazivLige
            // 
            this.lblNazivLige.AutoSize = true;
            this.lblNazivLige.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivLige.Location = new System.Drawing.Point(248, 39);
            this.lblNazivLige.Name = "lblNazivLige";
            this.lblNazivLige.Size = new System.Drawing.Size(245, 32);
            this.lblNazivLige.TabIndex = 0;
            this.lblNazivLige.Text = "Naziv lige i drzava";
            // 
            // Klubovi
            // 
            this.Klubovi.Controls.Add(this.tabPage1);
            this.Klubovi.Controls.Add(this.tabPage2);
            this.Klubovi.Controls.Add(this.tabPage3);
            this.Klubovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Klubovi.Location = new System.Drawing.Point(12, 98);
            this.Klubovi.Name = "Klubovi";
            this.Klubovi.SelectedIndex = 0;
            this.Klubovi.Size = new System.Drawing.Size(750, 432);
            this.Klubovi.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(742, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Klubovi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(742, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Utakmice";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(742, 418);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tabela";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // FormLiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 542);
            this.Controls.Add(this.Klubovi);
            this.Controls.Add(this.lblNazivLige);
            this.Name = "FormLiga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLiga";
            this.Load += new System.EventHandler(this.FormLiga_Load);
            this.Klubovi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNazivLige;
        private System.Windows.Forms.TabControl Klubovi;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}