namespace Skladista
{
    partial class azurirajSkladisnicu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(azurirajSkladisnicu));
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.lblIzradio = new System.Windows.Forms.Label();
            this.datumIzrade = new System.Windows.Forms.DateTimePicker();
            this.txtSifraSkl = new System.Windows.Forms.TextBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblSifra = new System.Windows.Forms.Label();
            this.dgvPrikaz = new System.Windows.Forms.DataGridView();
            this.iddokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_artikla = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijena_artikla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artiklDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interniDokumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupnaCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeinternogDokumentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzmjeni = new System.Windows.Forms.Button();
            this.cmbIzradioIme = new System.Windows.Forms.ComboBox();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbIzradioPrezime = new System.Windows.Forms.ComboBox();
            this.cmbIzradioSifra = new System.Windows.Forms.ComboBox();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeinternogDokumentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackgroundImage = global::Skladista.Properties.Resources.Close1;
            this.btnZatvori.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnZatvori.Location = new System.Drawing.Point(821, 88);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(167, 42);
            this.btnZatvori.TabIndex = 62;
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackgroundImage = global::Skladista.Properties.Resources.Floppy;
            this.btnSpremi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSpremi.Location = new System.Drawing.Point(821, 25);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(167, 40);
            this.btnSpremi.TabIndex = 61;
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // lblIzradio
            // 
            this.lblIzradio.AutoSize = true;
            this.lblIzradio.BackColor = System.Drawing.Color.Transparent;
            this.lblIzradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIzradio.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblIzradio.Location = new System.Drawing.Point(31, 145);
            this.lblIzradio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIzradio.Name = "lblIzradio";
            this.lblIzradio.Size = new System.Drawing.Size(90, 25);
            this.lblIzradio.TabIndex = 60;
            this.lblIzradio.Text = "Izradio:";
            // 
            // datumIzrade
            // 
            this.datumIzrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datumIzrade.Location = new System.Drawing.Point(138, 103);
            this.datumIzrade.Name = "datumIzrade";
            this.datumIzrade.Size = new System.Drawing.Size(189, 26);
            this.datumIzrade.TabIndex = 59;
            // 
            // txtSifraSkl
            // 
            this.txtSifraSkl.Enabled = false;
            this.txtSifraSkl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSifraSkl.Location = new System.Drawing.Point(138, 47);
            this.txtSifraSkl.Margin = new System.Windows.Forms.Padding(2);
            this.txtSifraSkl.Multiline = true;
            this.txtSifraSkl.Name = "txtSifraSkl";
            this.txtSifraSkl.Size = new System.Drawing.Size(275, 35);
            this.txtSifraSkl.TabIndex = 58;
            this.txtSifraSkl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.BackColor = System.Drawing.Color.Transparent;
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDatum.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDatum.Location = new System.Drawing.Point(31, 100);
            this.lblDatum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(86, 25);
            this.lblDatum.TabIndex = 57;
            this.lblDatum.Text = "Datum:";
            // 
            // lblSifra
            // 
            this.lblSifra.AutoSize = true;
            this.lblSifra.BackColor = System.Drawing.Color.Transparent;
            this.lblSifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSifra.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSifra.Location = new System.Drawing.Point(31, 57);
            this.lblSifra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(68, 25);
            this.lblSifra.TabIndex = 56;
            this.lblSifra.Text = "Šifra:";
            // 
            // dgvPrikaz
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvPrikaz.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrikaz.AutoGenerateColumns = false;
            this.dgvPrikaz.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvPrikaz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPrikaz.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrikaz.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikaz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddokumentaDataGridViewTextBoxColumn,
            this.idartiklaDataGridViewTextBoxColumn,
            this.id_artikla,
            this.kolicinaDataGridViewTextBoxColumn,
            this.cijena_artikla,
            this.artiklDataGridViewTextBoxColumn,
            this.interniDokumentDataGridViewTextBoxColumn,
            this.UkupnaCijena});
            this.dgvPrikaz.DataSource = this.stavkeinternogDokumentaBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrikaz.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPrikaz.Location = new System.Drawing.Point(36, 215);
            this.dgvPrikaz.Name = "dgvPrikaz";
            this.dgvPrikaz.ReadOnly = true;
            this.dgvPrikaz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrikaz.Size = new System.Drawing.Size(763, 183);
            this.dgvPrikaz.TabIndex = 63;
            // 
            // iddokumentaDataGridViewTextBoxColumn
            // 
            this.iddokumentaDataGridViewTextBoxColumn.DataPropertyName = "id_dokumenta";
            this.iddokumentaDataGridViewTextBoxColumn.HeaderText = "id_dokumenta";
            this.iddokumentaDataGridViewTextBoxColumn.Name = "iddokumentaDataGridViewTextBoxColumn";
            this.iddokumentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iddokumentaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idartiklaDataGridViewTextBoxColumn
            // 
            this.idartiklaDataGridViewTextBoxColumn.DataPropertyName = "id_artikla";
            this.idartiklaDataGridViewTextBoxColumn.HeaderText = "Šifra artikla";
            this.idartiklaDataGridViewTextBoxColumn.Name = "idartiklaDataGridViewTextBoxColumn";
            this.idartiklaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idartiklaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idartiklaDataGridViewTextBoxColumn.Width = 120;
            // 
            // id_artikla
            // 
            this.id_artikla.DataPropertyName = "id_artikla";
            this.id_artikla.DataSource = this.artiklBindingSource;
            this.id_artikla.DisplayMember = "naziv";
            this.id_artikla.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.id_artikla.HeaderText = "Naziv artikla";
            this.id_artikla.Name = "id_artikla";
            this.id_artikla.ReadOnly = true;
            this.id_artikla.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_artikla.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.id_artikla.ValueMember = "sifra";
            this.id_artikla.Width = 250;
            // 
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataSource = typeof(Skladista.Artikl);
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cijena_artikla
            // 
            this.cijena_artikla.DataPropertyName = "cijena_artikla";
            this.cijena_artikla.HeaderText = "Cijena artikla";
            this.cijena_artikla.Name = "cijena_artikla";
            this.cijena_artikla.ReadOnly = true;
            this.cijena_artikla.Width = 150;
            // 
            // artiklDataGridViewTextBoxColumn
            // 
            this.artiklDataGridViewTextBoxColumn.DataPropertyName = "Artikl";
            this.artiklDataGridViewTextBoxColumn.HeaderText = "Artikl";
            this.artiklDataGridViewTextBoxColumn.Name = "artiklDataGridViewTextBoxColumn";
            this.artiklDataGridViewTextBoxColumn.ReadOnly = true;
            this.artiklDataGridViewTextBoxColumn.Visible = false;
            // 
            // interniDokumentDataGridViewTextBoxColumn
            // 
            this.interniDokumentDataGridViewTextBoxColumn.DataPropertyName = "interniDokument";
            this.interniDokumentDataGridViewTextBoxColumn.HeaderText = "interniDokument";
            this.interniDokumentDataGridViewTextBoxColumn.Name = "interniDokumentDataGridViewTextBoxColumn";
            this.interniDokumentDataGridViewTextBoxColumn.ReadOnly = true;
            this.interniDokumentDataGridViewTextBoxColumn.Visible = false;
            // 
            // UkupnaCijena
            // 
            this.UkupnaCijena.DataPropertyName = "UkupnaCijena";
            this.UkupnaCijena.HeaderText = "Ukupna Cijena";
            this.UkupnaCijena.Name = "UkupnaCijena";
            this.UkupnaCijena.ReadOnly = true;
            // 
            // stavkeinternogDokumentaBindingSource
            // 
            this.stavkeinternogDokumentaBindingSource.DataSource = typeof(Skladista.stavke_internogDokumenta);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackgroundImage = global::Skladista.Properties.Resources.Add;
            this.btnDodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDodaj.Location = new System.Drawing.Point(821, 215);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(167, 40);
            this.btnDodaj.TabIndex = 64;
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.BackgroundImage = global::Skladista.Properties.Resources.ssssssss;
            this.btnIzmjeni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIzmjeni.Location = new System.Drawing.Point(821, 270);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(167, 40);
            this.btnIzmjeni.TabIndex = 65;
            this.btnIzmjeni.UseVisualStyleBackColor = true;
            this.btnIzmjeni.Click += new System.EventHandler(this.btnIzmjeni_Click);
            // 
            // cmbIzradioIme
            // 
            this.cmbIzradioIme.DataSource = this.zaposlenikBindingSource;
            this.cmbIzradioIme.DisplayMember = "ime";
            this.cmbIzradioIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbIzradioIme.FormattingEnabled = true;
            this.cmbIzradioIme.Location = new System.Drawing.Point(219, 151);
            this.cmbIzradioIme.Name = "cmbIzradioIme";
            this.cmbIzradioIme.Size = new System.Drawing.Size(189, 28);
            this.cmbIzradioIme.TabIndex = 67;
            this.cmbIzradioIme.ValueMember = "sifra";
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataSource = typeof(Skladista.Zaposlenik);
            // 
            // cmbIzradioPrezime
            // 
            this.cmbIzradioPrezime.DataSource = this.zaposlenikBindingSource;
            this.cmbIzradioPrezime.DisplayMember = "prezime";
            this.cmbIzradioPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbIzradioPrezime.FormattingEnabled = true;
            this.cmbIzradioPrezime.Location = new System.Drawing.Point(414, 151);
            this.cmbIzradioPrezime.Name = "cmbIzradioPrezime";
            this.cmbIzradioPrezime.Size = new System.Drawing.Size(192, 28);
            this.cmbIzradioPrezime.TabIndex = 68;
            this.cmbIzradioPrezime.ValueMember = "sifra";
            // 
            // cmbIzradioSifra
            // 
            this.cmbIzradioSifra.DataSource = this.zaposlenikBindingSource;
            this.cmbIzradioSifra.DisplayMember = "sifra";
            this.cmbIzradioSifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbIzradioSifra.FormattingEnabled = true;
            this.cmbIzradioSifra.Location = new System.Drawing.Point(138, 151);
            this.cmbIzradioSifra.Name = "cmbIzradioSifra";
            this.cmbIzradioSifra.Size = new System.Drawing.Size(64, 28);
            this.cmbIzradioSifra.TabIndex = 69;
            this.cmbIzradioSifra.ValueMember = "sifra";
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DataSource = this.stavkeinternogDokumentaBindingSource;
            this.dataGridViewComboBoxColumn1.DisplayMember = "cijena_artikla";
            this.dataGridViewComboBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn1.HeaderText = "Cijena artikla";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn1.Width = 120;
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.BackgroundImage = global::Skladista.Properties.Resources.Delete;
            this.btnIzbrisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIzbrisi.Location = new System.Drawing.Point(821, 326);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(167, 40);
            this.btnIzbrisi.TabIndex = 70;
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click_1);
            // 
            // azurirajSkladisnicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 432);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.cmbIzradioSifra);
            this.Controls.Add(this.cmbIzradioPrezime);
            this.Controls.Add(this.cmbIzradioIme);
            this.Controls.Add(this.btnIzmjeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvPrikaz);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.lblIzradio);
            this.Controls.Add(this.datumIzrade);
            this.Controls.Add(this.txtSifraSkl);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblSifra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "azurirajSkladisnicu";
            this.RightToLeftLayout = true;
            this.Text = "Ažuriranje skladišnice";
            this.Load += new System.EventHandler(this.azurirajSkladisnicu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeinternogDokumentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label lblIzradio;
        private System.Windows.Forms.DateTimePicker datumIzrade;
        private System.Windows.Forms.TextBox txtSifraSkl;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblSifra;
        private System.Windows.Forms.DataGridView dgvPrikaz;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmjeni;
        private System.Windows.Forms.BindingSource stavkeinternogDokumentaBindingSource;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private System.Windows.Forms.ComboBox cmbIzradioIme;
        private System.Windows.Forms.ComboBox cmbIzradioPrezime;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private System.Windows.Forms.ComboBox cmbIzradioSifra;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddokumentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn id_artikla;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijena_artikla;
        private System.Windows.Forms.DataGridViewTextBoxColumn artiklDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interniDokumentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupnaCijena;
        private System.Windows.Forms.Button btnIzbrisi;
    }
}