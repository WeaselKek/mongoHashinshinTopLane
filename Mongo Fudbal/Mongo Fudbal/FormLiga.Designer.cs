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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNazivLige = new System.Windows.Forms.Label();
            this.tabLiga = new System.Windows.Forms.TabControl();
            this.tabUtakmice = new System.Windows.Forms.TabPage();
            this.dataGridViewUtakmice = new System.Windows.Forms.DataGridView();
            this.btnDodajUtakmicu = new System.Windows.Forms.Button();
            this.tabTabela = new System.Windows.Forms.TabPage();
            this.dataGridViewTabela = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dodajKlubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabLiga.SuspendLayout();
            this.tabUtakmice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUtakmice)).BeginInit();
            this.tabTabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabela)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            // tabLiga
            // 
            this.tabLiga.Controls.Add(this.tabUtakmice);
            this.tabLiga.Controls.Add(this.tabTabela);
            this.tabLiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLiga.Location = new System.Drawing.Point(12, 98);
            this.tabLiga.Name = "tabLiga";
            this.tabLiga.SelectedIndex = 0;
            this.tabLiga.Size = new System.Drawing.Size(750, 478);
            this.tabLiga.TabIndex = 1;
            this.tabLiga.SelectedIndexChanged += new System.EventHandler(this.tabLiga_SelectedIndexChanged);
            // 
            // tabUtakmice
            // 
            this.tabUtakmice.Controls.Add(this.dataGridViewUtakmice);
            this.tabUtakmice.Controls.Add(this.btnDodajUtakmicu);
            this.tabUtakmice.Location = new System.Drawing.Point(4, 29);
            this.tabUtakmice.Name = "tabUtakmice";
            this.tabUtakmice.Padding = new System.Windows.Forms.Padding(3);
            this.tabUtakmice.Size = new System.Drawing.Size(742, 445);
            this.tabUtakmice.TabIndex = 1;
            this.tabUtakmice.Text = "Utakmice";
            this.tabUtakmice.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUtakmice
            // 
            this.dataGridViewUtakmice.AllowUserToAddRows = false;
            this.dataGridViewUtakmice.AllowUserToDeleteRows = false;
            this.dataGridViewUtakmice.AllowUserToResizeColumns = false;
            this.dataGridViewUtakmice.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewUtakmice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewUtakmice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUtakmice.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUtakmice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewUtakmice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUtakmice.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridViewUtakmice.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewUtakmice.MultiSelect = false;
            this.dataGridViewUtakmice.Name = "dataGridViewUtakmice";
            this.dataGridViewUtakmice.ReadOnly = true;
            this.dataGridViewUtakmice.RowHeadersVisible = false;
            this.dataGridViewUtakmice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewUtakmice.RowTemplate.Height = 28;
            this.dataGridViewUtakmice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUtakmice.Size = new System.Drawing.Size(730, 364);
            this.dataGridViewUtakmice.TabIndex = 3;
            // 
            // btnDodajUtakmicu
            // 
            this.btnDodajUtakmicu.Location = new System.Drawing.Point(6, 388);
            this.btnDodajUtakmicu.Name = "btnDodajUtakmicu";
            this.btnDodajUtakmicu.Size = new System.Drawing.Size(180, 35);
            this.btnDodajUtakmicu.TabIndex = 1;
            this.btnDodajUtakmicu.Text = "Dodaj utakmicu";
            this.btnDodajUtakmicu.UseVisualStyleBackColor = true;
            this.btnDodajUtakmicu.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabTabela
            // 
            this.tabTabela.Controls.Add(this.dataGridViewTabela);
            this.tabTabela.Location = new System.Drawing.Point(4, 29);
            this.tabTabela.Name = "tabTabela";
            this.tabTabela.Padding = new System.Windows.Forms.Padding(3);
            this.tabTabela.Size = new System.Drawing.Size(742, 445);
            this.tabTabela.TabIndex = 2;
            this.tabTabela.Text = "Tabela";
            this.tabTabela.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTabela
            // 
            this.dataGridViewTabela.AllowUserToAddRows = false;
            this.dataGridViewTabela.AllowUserToDeleteRows = false;
            this.dataGridViewTabela.AllowUserToResizeColumns = false;
            this.dataGridViewTabela.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTabela.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTabela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTabela.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTabela.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTabela.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridViewTabela.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewTabela.MultiSelect = false;
            this.dataGridViewTabela.Name = "dataGridViewTabela";
            this.dataGridViewTabela.ReadOnly = true;
            this.dataGridViewTabela.RowHeadersVisible = false;
            this.dataGridViewTabela.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewTabela.RowTemplate.Height = 28;
            this.dataGridViewTabela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTabela.Size = new System.Drawing.Size(730, 433);
            this.dataGridViewTabela.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajKlubToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dodajKlubToolStripMenuItem
            // 
            this.dodajKlubToolStripMenuItem.Name = "dodajKlubToolStripMenuItem";
            this.dodajKlubToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.dodajKlubToolStripMenuItem.Text = "Dodaj klub";
            this.dodajKlubToolStripMenuItem.Click += new System.EventHandler(this.dodajKlubToolStripMenuItem_Click);
            // 
            // FormLiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 587);
            this.Controls.Add(this.tabLiga);
            this.Controls.Add(this.lblNazivLige);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormLiga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLiga";
            this.Load += new System.EventHandler(this.FormLiga_Load);
            this.tabLiga.ResumeLayout(false);
            this.tabUtakmice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUtakmice)).EndInit();
            this.tabTabela.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabela)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNazivLige;
        private System.Windows.Forms.TabControl tabLiga;
        private System.Windows.Forms.TabPage tabUtakmice;
        private System.Windows.Forms.TabPage tabTabela;
        private System.Windows.Forms.Button btnDodajUtakmicu;
        private System.Windows.Forms.DataGridView dataGridViewUtakmice;
        private System.Windows.Forms.DataGridView dataGridViewTabela;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodajKlubToolStripMenuItem;
    }
}