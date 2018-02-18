namespace Mongo_Fudbal
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbxH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxA = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.golH = new System.Windows.Forms.TextBox();
            this.golA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTrue
            // 
            this.btnTrue.Location = new System.Drawing.Point(106, 450);
            this.btnTrue.Name = "btnTrue";
            this.btnTrue.Size = new System.Drawing.Size(75, 23);
            this.btnTrue.TabIndex = 0;
            this.btnTrue.Text = "Accept";
            this.btnTrue.UseVisualStyleBackColor = true;
            this.btnTrue.Click += new System.EventHandler(this.btnTrue_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(508, 450);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cbxH
            // 
            this.cbxH.FormattingEnabled = true;
            this.cbxH.Location = new System.Drawing.Point(49, 226);
            this.cbxH.Name = "cbxH";
            this.cbxH.Size = new System.Drawing.Size(150, 21);
            this.cbxH.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Home";
            // 
            // cbxA
            // 
            this.cbxA.FormattingEnabled = true;
            this.cbxA.Location = new System.Drawing.Point(244, 226);
            this.cbxA.Name = "cbxA";
            this.cbxA.Size = new System.Drawing.Size(150, 21);
            this.cbxA.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Away";
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(49, 38);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(206, 20);
            this.dtp1.TabIndex = 6;
            // 
            // golH
            // 
            this.golH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.golH.Location = new System.Drawing.Point(97, 253);
            this.golH.Name = "golH";
            this.golH.Size = new System.Drawing.Size(40, 26);
            this.golH.TabIndex = 7;
            // 
            // golA
            // 
            this.golA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.golA.Location = new System.Drawing.Point(296, 253);
            this.golA.Name = "golA";
            this.golA.Size = new System.Drawing.Size(40, 26);
            this.golA.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Goals";
            // 
            // DodajUtakmicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 512);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.golA);
            this.Controls.Add(this.golH);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxH);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnTrue);
            this.Name = "DodajUtakmicu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DodajUtakmicu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTrue;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbxH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.TextBox golH;
        private System.Windows.Forms.TextBox golA;
        private System.Windows.Forms.Label label3;
    }
}