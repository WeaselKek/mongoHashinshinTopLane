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
            this.txtMinut.Location = new System.Drawing.Point(139, 67);
            this.txtMinut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMinut.Name = "txtMinut";
            this.txtMinut.Size = new System.Drawing.Size(66, 28);
            this.txtMinut.TabIndex = 0;
            this.txtMinut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinut_KeyPress);
            // 
            // cbxIgrac
            // 
            this.cbxIgrac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIgrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxIgrac.FormattingEnabled = true;
            this.cbxIgrac.Location = new System.Drawing.Point(139, 157);
            this.cbxIgrac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxIgrac.Name = "cbxIgrac";
            this.cbxIgrac.Size = new System.Drawing.Size(286, 30);
            this.cbxIgrac.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(135, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Igrac";
            // 
            // btnTrue
            // 
            this.btnTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrue.Location = new System.Drawing.Point(241, 326);
            this.btnTrue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTrue.Name = "btnTrue";
            this.btnTrue.Size = new System.Drawing.Size(100, 39);
            this.btnTrue.TabIndex = 3;
            this.btnTrue.Text = "Dodaj";
            this.btnTrue.UseVisualStyleBackColor = true;
            this.btnTrue.Click += new System.EventHandler(this.btnTrue_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(135, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
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
            this.cbxTip.Location = new System.Drawing.Point(139, 244);
            this.cbxTip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxTip.Name = "cbxTip";
            this.cbxTip.Size = new System.Drawing.Size(231, 30);
            this.cbxTip.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(135, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tip";
            // 
            // DodajDogadjaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(614, 412);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxTip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTrue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxIgrac);
            this.Controls.Add(this.txtMinut);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DodajDogadjaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dogadjaj";
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