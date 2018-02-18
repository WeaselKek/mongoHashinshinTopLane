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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnTrue = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTip = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMinut
            // 
            this.txtMinut.Location = new System.Drawing.Point(56, 107);
            this.txtMinut.Name = "txtMinut";
            this.txtMinut.Size = new System.Drawing.Size(73, 20);
            this.txtMinut.TabIndex = 0;
            // 
            // cbxIgrac
            // 
            this.cbxIgrac.FormattingEnabled = true;
            this.cbxIgrac.Location = new System.Drawing.Point(247, 106);
            this.cbxIgrac.Name = "cbxIgrac";
            this.cbxIgrac.Size = new System.Drawing.Size(144, 21);
            this.cbxIgrac.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Igrac";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(440, 357);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnTrue
            // 
            this.btnTrue.Location = new System.Drawing.Point(38, 357);
            this.btnTrue.Name = "btnTrue";
            this.btnTrue.Size = new System.Drawing.Size(75, 23);
            this.btnTrue.TabIndex = 3;
            this.btnTrue.Text = "Accept";
            this.btnTrue.UseVisualStyleBackColor = true;
            this.btnTrue.Click += new System.EventHandler(this.btnTrue_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Minut";
            // 
            // cbxTip
            // 
            this.cbxTip.FormattingEnabled = true;
            this.cbxTip.Items.AddRange(new object[] {
            "Goal",
            "Autogoal",
            "Red Card",
            "Yellow Card"});
            this.cbxTip.Location = new System.Drawing.Point(155, 217);
            this.cbxTip.Name = "cbxTip";
            this.cbxTip.Size = new System.Drawing.Size(163, 21);
            this.cbxTip.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tip";
            // 
            // DodajDogadjaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 406);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxTip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnTrue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxIgrac);
            this.Controls.Add(this.txtMinut);
            this.Name = "DodajDogadjaj";
            this.Text = "DodajDogadjaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMinut;
        private System.Windows.Forms.ComboBox cbxIgrac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnTrue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTip;
        private System.Windows.Forms.Label label3;
    }
}