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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDomacin = new System.Windows.Forms.Label();
            this.lblGost = new System.Windows.Forms.Label();
            this.lblRezultat = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblStadion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridViewDogadjaji = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDogadjaji)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDomacin
            // 
            this.lblDomacin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomacin.Location = new System.Drawing.Point(8, 59);
            this.lblDomacin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDomacin.Name = "lblDomacin";
            this.lblDomacin.Size = new System.Drawing.Size(216, 27);
            this.lblDomacin.TabIndex = 0;
            this.lblDomacin.Text = "lblDomacin";
            this.lblDomacin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGost
            // 
            this.lblGost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGost.Location = new System.Drawing.Point(316, 59);
            this.lblGost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGost.Name = "lblGost";
            this.lblGost.Size = new System.Drawing.Size(221, 26);
            this.lblGost.TabIndex = 1;
            this.lblGost.Text = "lblGost";
            this.lblGost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRezultat
            // 
            this.lblRezultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRezultat.Location = new System.Drawing.Point(229, 57);
            this.lblRezultat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRezultat.Name = "lblRezultat";
            this.lblRezultat.Size = new System.Drawing.Size(83, 30);
            this.lblRezultat.TabIndex = 2;
            this.lblRezultat.Text = "lblRezultat";
            this.lblRezultat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDatum
            // 
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(9, 20);
            this.lblDatum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(529, 19);
            this.lblDatum.TabIndex = 3;
            this.lblDatum.Text = "lblDatum";
            this.lblDatum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStadion
            // 
            this.lblStadion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStadion.Location = new System.Drawing.Point(9, 106);
            this.lblStadion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStadion.Name = "lblStadion";
            this.lblStadion.Size = new System.Drawing.Size(529, 19);
            this.lblStadion.TabIndex = 4;
            this.lblStadion.Text = "lblStadion";
            this.lblStadion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dogadjaji na mecu:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(50, 365);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Dodaj dogadjaj";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(192, 365);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(34, 37);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridViewDogadjaji
            // 
            this.dataGridViewDogadjaji.AllowUserToAddRows = false;
            this.dataGridViewDogadjaji.AllowUserToDeleteRows = false;
            this.dataGridViewDogadjaji.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewDogadjaji.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDogadjaji.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDogadjaji.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDogadjaji.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDogadjaji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDogadjaji.ColumnHeadersVisible = false;
            this.dataGridViewDogadjaji.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridViewDogadjaji.Location = new System.Drawing.Point(50, 184);
            this.dataGridViewDogadjaji.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDogadjaji.MultiSelect = false;
            this.dataGridViewDogadjaji.Name = "dataGridViewDogadjaji";
            this.dataGridViewDogadjaji.ReadOnly = true;
            this.dataGridViewDogadjaji.RowHeadersVisible = false;
            this.dataGridViewDogadjaji.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewDogadjaji.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewDogadjaji.RowTemplate.Height = 28;
            this.dataGridViewDogadjaji.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDogadjaji.Size = new System.Drawing.Size(449, 176);
            this.dataGridViewDogadjaji.TabIndex = 9;
            // 
            // FormUtakmica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 430);
            this.Controls.Add(this.dataGridViewDogadjaji);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStadion);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblRezultat);
            this.Controls.Add(this.lblGost);
            this.Controls.Add(this.lblDomacin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormUtakmica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Utakmica";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUtakmica_FormClosing);
            this.Load += new System.EventHandler(this.FormUtakmica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDogadjaji)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDomacin;
        private System.Windows.Forms.Label lblGost;
        private System.Windows.Forms.Label lblRezultat;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblStadion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridViewDogadjaji;
    }
}