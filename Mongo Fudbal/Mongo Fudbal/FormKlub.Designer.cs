namespace Mongo_Fudbal
{
    partial class FormKlub
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblGrad = new System.Windows.Forms.Label();
            this.lblGodina = new System.Windows.Forms.Label();
            this.lblLiga = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dataGridViewIgraci = new System.Windows.Forms.DataGridView();
            this.btnVidi = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIgraci)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.Location = new System.Drawing.Point(9, 25);
            this.lblNaziv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(518, 37);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "ime kluba";
            this.lblNaziv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrad
            // 
            this.lblGrad.AutoSize = true;
            this.lblGrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrad.Location = new System.Drawing.Point(33, 78);
            this.lblGrad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrad.Name = "lblGrad";
            this.lblGrad.Size = new System.Drawing.Size(37, 18);
            this.lblGrad.TabIndex = 1;
            this.lblGrad.Text = "grad";
            // 
            // lblGodina
            // 
            this.lblGodina.AutoSize = true;
            this.lblGodina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGodina.Location = new System.Drawing.Point(33, 109);
            this.lblGodina.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGodina.Name = "lblGodina";
            this.lblGodina.Size = new System.Drawing.Size(118, 18);
            this.lblGodina.TabIndex = 2;
            this.lblGodina.Text = "godina osnivanja";
            // 
            // lblLiga
            // 
            this.lblLiga.AutoSize = true;
            this.lblLiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiga.Location = new System.Drawing.Point(33, 141);
            this.lblLiga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLiga.Name = "lblLiga";
            this.lblLiga.Size = new System.Drawing.Size(30, 18);
            this.lblLiga.TabIndex = 3;
            this.lblLiga.Text = "liga";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 184);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Igraci:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(386, 64);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(36, 411);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(116, 31);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "Dodaj Igraca";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dataGridViewIgraci
            // 
            this.dataGridViewIgraci.AllowUserToAddRows = false;
            this.dataGridViewIgraci.AllowUserToDeleteRows = false;
            this.dataGridViewIgraci.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewIgraci.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewIgraci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewIgraci.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewIgraci.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewIgraci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIgraci.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewIgraci.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewIgraci.Location = new System.Drawing.Point(36, 212);
            this.dataGridViewIgraci.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewIgraci.MultiSelect = false;
            this.dataGridViewIgraci.Name = "dataGridViewIgraci";
            this.dataGridViewIgraci.ReadOnly = true;
            this.dataGridViewIgraci.RowHeadersVisible = false;
            this.dataGridViewIgraci.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewIgraci.RowTemplate.Height = 28;
            this.dataGridViewIgraci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewIgraci.Size = new System.Drawing.Size(463, 194);
            this.dataGridViewIgraci.TabIndex = 8;
            // 
            // btnVidi
            // 
            this.btnVidi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVidi.Location = new System.Drawing.Point(170, 411);
            this.btnVidi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVidi.Name = "btnVidi";
            this.btnVidi.Size = new System.Drawing.Size(116, 31);
            this.btnVidi.TabIndex = 9;
            this.btnVidi.Text = "Prikazi igraca";
            this.btnVidi.UseVisualStyleBackColor = true;
            this.btnVidi.Click += new System.EventHandler(this.btnVidi_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnUpdate.Location = new System.Drawing.Point(326, 411);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 30);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Azuriraj";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FormKlub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 461);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnVidi);
            this.Controls.Add(this.dataGridViewIgraci);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblLiga);
            this.Controls.Add(this.lblGodina);
            this.Controls.Add(this.lblGrad);
            this.Controls.Add(this.lblNaziv);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormKlub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKlub";
            this.Load += new System.EventHandler(this.FormKlub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIgraci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblGrad;
        private System.Windows.Forms.Label lblGodina;
        private System.Windows.Forms.Label lblLiga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dataGridViewIgraci;
        private System.Windows.Forms.Button btnVidi;
        private System.Windows.Forms.Button btnUpdate;
    }
}