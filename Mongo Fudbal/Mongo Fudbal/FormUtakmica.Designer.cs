namespace Mongo_Fudbal
{
    partial class FormUtakmica
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
            this.lblDomacin = new System.Windows.Forms.Label();
            this.lblGost = new System.Windows.Forms.Label();
            this.lblRezultat = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblStadion = new System.Windows.Forms.Label();
            this.listBoxDogadjaji = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDomacin
            // 
            this.lblDomacin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomacin.Location = new System.Drawing.Point(12, 74);
            this.lblDomacin.Name = "lblDomacin";
            this.lblDomacin.Size = new System.Drawing.Size(289, 33);
            this.lblDomacin.TabIndex = 0;
            this.lblDomacin.Text = "lblDomacin";
            this.lblDomacin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGost
            // 
            this.lblGost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGost.Location = new System.Drawing.Point(443, 73);
            this.lblGost.Name = "lblGost";
            this.lblGost.Size = new System.Drawing.Size(274, 32);
            this.lblGost.TabIndex = 1;
            this.lblGost.Text = "lblGost";
            this.lblGost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRezultat
            // 
            this.lblRezultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRezultat.Location = new System.Drawing.Point(322, 70);
            this.lblRezultat.Name = "lblRezultat";
            this.lblRezultat.Size = new System.Drawing.Size(106, 37);
            this.lblRezultat.TabIndex = 2;
            this.lblRezultat.Text = "lblRezultat";
            this.lblRezultat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDatum
            // 
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(12, 24);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(729, 23);
            this.lblDatum.TabIndex = 3;
            this.lblDatum.Text = "lblDatum";
            this.lblDatum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStadion
            // 
            this.lblStadion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStadion.Location = new System.Drawing.Point(12, 130);
            this.lblStadion.Name = "lblStadion";
            this.lblStadion.Size = new System.Drawing.Size(729, 23);
            this.lblStadion.TabIndex = 4;
            this.lblStadion.Text = "lblStadion";
            this.lblStadion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxDogadjaji
            // 
            this.listBoxDogadjaji.FormattingEnabled = true;
            this.listBoxDogadjaji.ItemHeight = 16;
            this.listBoxDogadjaji.Location = new System.Drawing.Point(66, 231);
            this.listBoxDogadjaji.Name = "listBoxDogadjaji";
            this.listBoxDogadjaji.Size = new System.Drawing.Size(595, 212);
            this.listBoxDogadjaji.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dogadjaju na mecu:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(66, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Dodaj dogadjaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormUtakmica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 529);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxDogadjaji);
            this.Controls.Add(this.lblStadion);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblRezultat);
            this.Controls.Add(this.lblGost);
            this.Controls.Add(this.lblDomacin);
            this.Name = "FormUtakmica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUtakmica";
            this.Load += new System.EventHandler(this.FormUtakmica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDomacin;
        private System.Windows.Forms.Label lblGost;
        private System.Windows.Forms.Label lblRezultat;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblStadion;
        private System.Windows.Forms.ListBox listBoxDogadjaji;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}