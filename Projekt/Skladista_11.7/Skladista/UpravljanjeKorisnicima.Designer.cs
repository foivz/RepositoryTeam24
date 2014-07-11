namespace Skladista
{
    partial class UpravljanjeKorisnicima
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpravljanjeKorisnicima));
            this.lblPrikaz = new System.Windows.Forms.Label();
            this.prikazKorisnika = new System.Windows.Forms.DataGridView();
            this.Azuriraj = new System.Windows.Forms.Button();
            this.Kreiraj = new System.Windows.Forms.Button();
            this.txtPretraziIme = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtPretraziPrezime = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.sifraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnickoimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lozinkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulogaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ulogaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eksterniDokumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interniDokumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uloga1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.prikazKorisnika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrikaz
            // 
            this.lblPrikaz.AutoSize = true;
            this.lblPrikaz.BackColor = System.Drawing.Color.Transparent;
            this.lblPrikaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrikaz.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPrikaz.Location = new System.Drawing.Point(8, 100);
            this.lblPrikaz.Name = "lblPrikaz";
            this.lblPrikaz.Size = new System.Drawing.Size(139, 20);
            this.lblPrikaz.TabIndex = 18;
            this.lblPrikaz.Text = "Prikaz korisnika:";
            // 
            // prikazKorisnika
            // 
            this.prikazKorisnika.AutoGenerateColumns = false;
            this.prikazKorisnika.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.prikazKorisnika.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.prikazKorisnika.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prikazKorisnika.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.prikazKorisnika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prikazKorisnika.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sifraDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.korisnickoimeDataGridViewTextBoxColumn,
            this.lozinkaDataGridViewTextBoxColumn,
            this.ulogaDataGridViewTextBoxColumn,
            this.eksterniDokumentDataGridViewTextBoxColumn,
            this.interniDokumentDataGridViewTextBoxColumn,
            this.uloga1DataGridViewTextBoxColumn});
            this.prikazKorisnika.DataSource = this.zaposlenikBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.prikazKorisnika.DefaultCellStyle = dataGridViewCellStyle2;
            this.prikazKorisnika.Location = new System.Drawing.Point(12, 133);
            this.prikazKorisnika.Name = "prikazKorisnika";
            this.prikazKorisnika.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prikazKorisnika.Size = new System.Drawing.Size(603, 324);
            this.prikazKorisnika.TabIndex = 17;
            // 
            // Azuriraj
            // 
            this.Azuriraj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Azuriraj.BackgroundImage")));
            this.Azuriraj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Azuriraj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Azuriraj.Location = new System.Drawing.Point(686, 239);
            this.Azuriraj.Name = "Azuriraj";
            this.Azuriraj.Size = new System.Drawing.Size(114, 70);
            this.Azuriraj.TabIndex = 20;
            this.Azuriraj.Text = "Ažuriraj korisnika";
            this.Azuriraj.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Azuriraj.UseVisualStyleBackColor = true;
            this.Azuriraj.Click += new System.EventHandler(this.Azuriraj_Click);
            // 
            // Kreiraj
            // 
            this.Kreiraj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Kreiraj.BackgroundImage")));
            this.Kreiraj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Kreiraj.Location = new System.Drawing.Point(686, 133);
            this.Kreiraj.Name = "Kreiraj";
            this.Kreiraj.Size = new System.Drawing.Size(114, 74);
            this.Kreiraj.TabIndex = 19;
            this.Kreiraj.UseVisualStyleBackColor = true;
            this.Kreiraj.Click += new System.EventHandler(this.Kreiraj_Click);
            // 
            // txtPretraziIme
            // 
            this.txtPretraziIme.Location = new System.Drawing.Point(331, 9);
            this.txtPretraziIme.Name = "txtPretraziIme";
            this.txtPretraziIme.Size = new System.Drawing.Size(185, 20);
            this.txtPretraziIme.TabIndex = 22;
            this.txtPretraziIme.TextChanged += new System.EventHandler(this.txtPretraziIme_TextChanged);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.BackColor = System.Drawing.Color.Transparent;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIme.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblIme.Location = new System.Drawing.Point(12, 9);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(265, 24);
            this.lblIme.TabIndex = 21;
            this.lblIme.Text = "Pretraživanje prema imenu:";
            // 
            // txtPretraziPrezime
            // 
            this.txtPretraziPrezime.Location = new System.Drawing.Point(331, 50);
            this.txtPretraziPrezime.Name = "txtPretraziPrezime";
            this.txtPretraziPrezime.Size = new System.Drawing.Size(185, 20);
            this.txtPretraziPrezime.TabIndex = 24;
            this.txtPretraziPrezime.TextChanged += new System.EventHandler(this.txtPretraziPrezime_TextChanged);
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.BackColor = System.Drawing.Color.Transparent;
            this.lblPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrezime.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPrezime.Location = new System.Drawing.Point(12, 46);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(306, 24);
            this.lblPrezime.TabIndex = 23;
            this.lblPrezime.Text = "Pretraživanje prema prezimenu:";
            // 
            // sifraDataGridViewTextBoxColumn
            // 
            this.sifraDataGridViewTextBoxColumn.DataPropertyName = "sifra";
            this.sifraDataGridViewTextBoxColumn.HeaderText = "sifra";
            this.sifraDataGridViewTextBoxColumn.Name = "sifraDataGridViewTextBoxColumn";
            this.sifraDataGridViewTextBoxColumn.Visible = false;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.Width = 150;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // korisnickoimeDataGridViewTextBoxColumn
            // 
            this.korisnickoimeDataGridViewTextBoxColumn.DataPropertyName = "korisnicko_ime";
            this.korisnickoimeDataGridViewTextBoxColumn.HeaderText = "Korisničko ime";
            this.korisnickoimeDataGridViewTextBoxColumn.Name = "korisnickoimeDataGridViewTextBoxColumn";
            this.korisnickoimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // lozinkaDataGridViewTextBoxColumn
            // 
            this.lozinkaDataGridViewTextBoxColumn.DataPropertyName = "lozinka";
            this.lozinkaDataGridViewTextBoxColumn.HeaderText = "lozinka";
            this.lozinkaDataGridViewTextBoxColumn.Name = "lozinkaDataGridViewTextBoxColumn";
            this.lozinkaDataGridViewTextBoxColumn.Visible = false;
            // 
            // ulogaDataGridViewTextBoxColumn
            // 
            this.ulogaDataGridViewTextBoxColumn.DataPropertyName = "uloga";
            this.ulogaDataGridViewTextBoxColumn.DataSource = this.ulogaBindingSource;
            this.ulogaDataGridViewTextBoxColumn.DisplayMember = "naziv";
            this.ulogaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ulogaDataGridViewTextBoxColumn.HeaderText = "Uloga";
            this.ulogaDataGridViewTextBoxColumn.Name = "ulogaDataGridViewTextBoxColumn";
            this.ulogaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ulogaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ulogaDataGridViewTextBoxColumn.ValueMember = "sifra";
            // 
            // ulogaBindingSource
            // 
            this.ulogaBindingSource.DataSource = typeof(Skladista.Uloga);
            // 
            // eksterniDokumentDataGridViewTextBoxColumn
            // 
            this.eksterniDokumentDataGridViewTextBoxColumn.DataPropertyName = "eksterniDokument";
            this.eksterniDokumentDataGridViewTextBoxColumn.HeaderText = "eksterniDokument";
            this.eksterniDokumentDataGridViewTextBoxColumn.Name = "eksterniDokumentDataGridViewTextBoxColumn";
            this.eksterniDokumentDataGridViewTextBoxColumn.Visible = false;
            // 
            // interniDokumentDataGridViewTextBoxColumn
            // 
            this.interniDokumentDataGridViewTextBoxColumn.DataPropertyName = "interniDokument";
            this.interniDokumentDataGridViewTextBoxColumn.HeaderText = "interniDokument";
            this.interniDokumentDataGridViewTextBoxColumn.Name = "interniDokumentDataGridViewTextBoxColumn";
            this.interniDokumentDataGridViewTextBoxColumn.Visible = false;
            // 
            // uloga1DataGridViewTextBoxColumn
            // 
            this.uloga1DataGridViewTextBoxColumn.DataPropertyName = "Uloga1";
            this.uloga1DataGridViewTextBoxColumn.HeaderText = "Uloga1";
            this.uloga1DataGridViewTextBoxColumn.Name = "uloga1DataGridViewTextBoxColumn";
            this.uloga1DataGridViewTextBoxColumn.Visible = false;
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataSource = typeof(Skladista.Zaposlenik);
            // 
            // UpravljanjeKorisnicima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 469);
            this.Controls.Add(this.txtPretraziPrezime);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.txtPretraziIme);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.Azuriraj);
            this.Controls.Add(this.Kreiraj);
            this.Controls.Add(this.lblPrikaz);
            this.Controls.Add(this.prikazKorisnika);
            this.Name = "UpravljanjeKorisnicima";
            this.Text = "UpravljanjeKorisnicima";
            this.Load += new System.EventHandler(this.UpravljanjeKorisnicima_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prikazKorisnika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrikaz;
        private System.Windows.Forms.DataGridView prikazKorisnika;
        private System.Windows.Forms.Button Azuriraj;
        private System.Windows.Forms.Button Kreiraj;
        private System.Windows.Forms.TextBox txtPretraziIme;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtPretraziPrezime;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private System.Windows.Forms.BindingSource ulogaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnickoimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lozinkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ulogaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eksterniDokumentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interniDokumentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uloga1DataGridViewTextBoxColumn;
    }
}