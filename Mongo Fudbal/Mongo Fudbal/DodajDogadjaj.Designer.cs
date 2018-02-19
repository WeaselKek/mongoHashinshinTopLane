namespace Mongo_Fudbal
{
    partial class DodajDogadjaj
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
            this.txtMinut = new System.Windows.Forms.TextBox();
            this.cbxIgrac = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTrue = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTip = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMinut
            // 
            this.txtMinut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinut.Location = new System.Drawing.Point(81, 69);
            this.txtMinut.Name = "txtMinut";
            this.txtMinut.Size = new System.Drawing.Size(59, 24);
            this.txtMinut.TabIndex = 0;
            this.txtMinut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinut_KeyPress);
            // 
            // cbxIgrac
            // 
            this.cbxIgrac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIgrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxIgrac.FormattingEnabled = true;
            this.cbxIgrac.Location = new System.Drawing.Point(81, 142);
            this.cbxIgrac.Name = "cbxIgrac";
            this.cbxIgrac.Size = new System.Drawing.Size(203, 25);
            this.cbxIgrac.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Igrac";
            // 
            // btnTrue
            // 
            this.btnTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrue.Location = new System.Drawing.Point(138, 284);
            this.btnTrue.Name = "btnTrue";
            this.btnTrue.Size = new System.Drawing.Size(75, 32);
            this.btnTrue.TabIndex = 3;
            this.btnTrue.Text = "Dodaj";
            this.btnTrue.UseVisualStyleBackColor = true;
            this.btnTrue.Click += new System.EventHandler(this.btnTrue_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Minut";
            // 
            // cbxTip
            // 
            this.cbxTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTip.FormattingEnabled = true;
            this.cbxTip.Items.AddRange(new object[] {
            "Gol",
            "Autogol",
            "Crveni Karton",
            "Zuti Karton"});
            this.cbxTip.Location = new System.Drawing.Point(81, 213);
            this.cbxTip.Name = "cbxTip";
            this.cbxTip.Size = new System.Drawing.Size(174, 25);
            this.cbxTip.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tip";
            // 
            // DodajDogadjaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxTip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTrue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxIgrac);
            this.Controls.Add(this.txtMinut);
            this.Name = "DodajDogadjaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DodajDogadjaj";
            this.Load += new System.EventHandler(this.DodajDogadjaj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMinut;
        private System.Windows.Forms.ComboBox cbxIgrac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTrue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTip;
        private System.Windows.Forms.Label label3;
    }
}