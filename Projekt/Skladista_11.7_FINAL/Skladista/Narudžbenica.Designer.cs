namespace Skladista
{
    partial class Narudžbenica
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
            System.Windows.Forms.Label nazivLabel;
            System.Windows.Forms.Label sifraLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Narudžbenica));
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavkeeksternogDokumentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbNazivPartner = new System.Windows.Forms.ComboBox();
            this.poslovniPartnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvPrikaz = new System.Windows.Forms.DataGridView();
            this.id_artikla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCijena = new System.Windows.Forms.ComboBox();
            this.prezimeComboBox = new System.Windows.Forms.ComboBox();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imeComboBox = new System.Windows.Forms.ComboBox();
            this.lblIzradio = new System.Windows.Forms.Label();
            this.cmbNaziv = new System.Windows.Forms.ComboBox();
            this.cmbSifra = new System.Windows.Forms.ComboBox();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.kolivinaLabel = new System.Windows.Forms.Label();
            this.cijenaLabel = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cmbKolicina = new System.Windows.Forms.TextBox();
            this.lblPoslovniPartner = new System.Windows.Forms.Label();
            this.dtpKreiranje = new System.Windows.Forms.DateTimePicker();
            this.txtSifraNar = new System.Windows.Forms.TextBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblSifra = new System.Windows.Forms.Label();
            this.pISkladiste2DataSet = new Skladista.PISkladiste2DataSet();
            this.poslovniPartnerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.poslovniPartnerTableAdapter = new Skladista.PISkladiste2DataSetTableAdapters.poslovniPartnerTableAdapter();
            this.tableAdapterManager = new Skladista.PISkladiste2DataSetTableAdapters.TableAdapterManager();
            this.artiklTableAdapter = new Skladista.PISkladiste2DataSetTableAdapters.ArtiklTableAdapter();
            this.artiklBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.cmbAdresa = new System.Windows.Forms.ComboBox();
            nazivLabel = new System.Windows.Forms.Label();
            sifraLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeeksternogDokumentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovniPartnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pISkladiste2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovniPartnerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.BackColor = System.Drawing.Color.Transparent;
            nazivLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            nazivLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            nazivLabel.Location = new System.Drawing.Point(84, 303);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(53, 17);
            nazivLabel.TabIndex = 110;
            nazivLabel.Text = "Naziv:";
            // 
            // sifraLabel
            // 
            sifraLabel.AutoSize = true;
            sifraLabel.BackColor = System.Drawing.Color.Transparent;
            sifraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            sifraLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            sifraLabel.Location = new System.Drawing.Point(84, 272);
            sifraLabel.Name = "sifraLabel";
            sifraLabel.Size = new System.Drawing.Size(47, 17);
            sifraLabel.TabIndex = 108;
            sifraLabel.Text = "Šifra:";
            // 
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataSource = typeof(Skladista.Artikl);
            // 
            // stavkeeksternogDokumentaBindingSource
            // 
            this.stavkeeksternogDokumentaBindingSource.DataSource = typeof(Skladista.stavke_eksternogDokumenta);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tag";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // cmbNazivPartner
            // 
            this.cmbNazivPartner.DataSource = this.poslovniPartnerBindingSource;
            this.cmbNazivPartner.DisplayMember = "naziv";
            this.cmbNazivPartner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbNazivPartner.FormattingEnabled = true;
            this.cmbNazivPartner.Location = new System.Drawing.Point(237, 144);
            this.cmbNazivPartner.Name = "cmbNazivPartner";
            this.cmbNazivPartner.Size = new System.Drawing.Size(186, 28);
            this.cmbNazivPartner.TabIndex = 117;
            this.cmbNazivPartner.ValueMember = "sifra";
            // 
            // poslovniPartnerBindingSource
            // 
            this.poslovniPartnerBindingSource.DataSource = typeof(Skladista.poslovniPartner);
            // 
            // dgvPrikaz
            // 
            this.dgvPrikaz.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvPrikaz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPrikaz.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvPrikaz.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrikaz.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikaz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_artikla,
            this.naziv,
            this.kolicina,
            this.cijena,
            this.suma});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrikaz.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrikaz.Location = new System.Drawing.Point(46, 368);
            this.dgvPrikaz.Name = "dgvPrikaz";
            this.dgvPrikaz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrikaz.Size = new System.Drawing.Size(535, 127);
            this.dgvPrikaz.TabIndex = 116;
            // 
            // id_artikla
            // 
            this.id_artikla.HeaderText = "Šifra artikla";
            this.id_artikla.Name = "id_artikla";
            this.id_artikla.Visible = false;
            this.id_artikla.Width = 250;
            // 
            // naziv
            // 
            this.naziv.HeaderText = "Naziv artikla";
            this.naziv.Name = "naziv";
            this.naziv.Width = 120;
            // 
            // kolicina
            // 
            this.kolicina.HeaderText = "Količina";
            this.kolicina.Name = "kolicina";
            // 
            // cijena
            // 
            this.cijena.HeaderText = "Jedinična cijena";
            this.cijena.Name = "cijena";
            this.cijena.Width = 140;
            // 
            // suma
            // 
            this.suma.HeaderText = "Ukupna cijena";
            this.suma.Name = "suma";
            this.suma.Width = 130;
            // 
            // cmbCijena
            // 
            this.cmbCijena.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artiklBindingSource, "nabavna_cijena", true));
            this.cmbCijena.DataSource = this.artiklBindingSource;
            this.cmbCijena.DisplayMember = "nabavna_cijena";
            this.cmbCijena.FormatString = "N2";
            this.cmbCijena.FormattingEnabled = true;
            this.cmbCijena.Location = new System.Drawing.Point(429, 300);
            this.cmbCijena.Name = "cmbCijena";
            this.cmbCijena.Size = new System.Drawing.Size(152, 21);
            this.cmbCijena.TabIndex = 115;
            this.cmbCijena.ValueMember = "sifra";
            // 
            // prezimeComboBox
            // 
            this.prezimeComboBox.DataSource = this.zaposlenikBindingSource;
            this.prezimeComboBox.DisplayMember = "ime";
            this.prezimeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prezimeComboBox.FormattingEnabled = true;
            this.prezimeComboBox.Location = new System.Drawing.Point(275, 184);
            this.prezimeComboBox.Name = "prezimeComboBox";
            this.prezimeComboBox.Size = new System.Drawing.Size(153, 28);
            this.prezimeComboBox.TabIndex = 114;
            this.prezimeComboBox.ValueMember = "sifra";
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataSource = typeof(Skladista.Zaposlenik);
            // 
            // imeComboBox
            // 
            this.imeComboBox.DataSource = this.zaposlenikBindingSource;
            this.imeComboBox.DisplayMember = "prezime";
            this.imeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imeComboBox.FormattingEnabled = true;
            this.imeComboBox.Location = new System.Drawing.Point(148, 184);
            this.imeComboBox.Name = "imeComboBox";
            this.imeComboBox.Size = new System.Drawing.Size(121, 28);
            this.imeComboBox.TabIndex = 113;
            this.imeComboBox.ValueMember = "sifra";
            // 
            // lblIzradio
            // 
            this.lblIzradio.AutoSize = true;
            this.lblIzradio.BackColor = System.Drawing.Color.Transparent;
            this.lblIzradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIzradio.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblIzradio.Location = new System.Drawing.Point(41, 183);
            this.lblIzradio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIzradio.Name = "lblIzradio";
            this.lblIzradio.Size = new System.Drawing.Size(90, 25);
            this.lblIzradio.TabIndex = 112;
            this.lblIzradio.Text = "Izradio:";
            // 
            // cmbNaziv
            // 
            this.cmbNaziv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artiklBindingSource, "naziv", true));
            this.cmbNaziv.DataSource = this.artiklBindingSource;
            this.cmbNaziv.DisplayMember = "naziv";
            this.cmbNaziv.FormattingEnabled = true;
            this.cmbNaziv.Location = new System.Drawing.Point(148, 301);
            this.cmbNaziv.Name = "cmbNaziv";
            this.cmbNaziv.Size = new System.Drawing.Size(121, 21);
            this.cmbNaziv.TabIndex = 111;
            this.cmbNaziv.ValueMember = "sifra";
            // 
            // cmbSifra
            // 
            this.cmbSifra.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artiklBindingSource, "sifra", true));
            this.cmbSifra.DataSource = this.artiklBindingSource;
            this.cmbSifra.DisplayMember = "sifra";
            this.cmbSifra.FormattingEnabled = true;
            this.cmbSifra.Location = new System.Drawing.Point(148, 268);
            this.cmbSifra.Name = "cmbSifra";
            this.cmbSifra.Size = new System.Drawing.Size(121, 21);
            this.cmbSifra.TabIndex = 109;
            this.cmbSifra.ValueMember = "sifra";
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackgroundImage = global::Skladista.Properties.Resources.Close;
            this.btnZatvori.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnZatvori.Location = new System.Drawing.Point(616, 95);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(118, 42);
            this.btnZatvori.TabIndex = 107;
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // kolivinaLabel
            // 
            this.kolivinaLabel.AutoSize = true;
            this.kolivinaLabel.BackColor = System.Drawing.Color.Transparent;
            this.kolivinaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kolivinaLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.kolivinaLabel.Location = new System.Drawing.Point(291, 272);
            this.kolivinaLabel.Name = "kolivinaLabel";
            this.kolivinaLabel.Size = new System.Drawing.Size(70, 17);
            this.kolivinaLabel.TabIndex = 106;
            this.kolivinaLabel.Text = "Količina:";
            // 
            // cijenaLabel
            // 
            this.cijenaLabel.AutoSize = true;
            this.cijenaLabel.BackColor = System.Drawing.Color.Transparent;
            this.cijenaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cijenaLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cijenaLabel.Location = new System.Drawing.Point(291, 305);
            this.cijenaLabel.Name = "cijenaLabel";
            this.cijenaLabel.Size = new System.Drawing.Size(130, 17);
            this.cijenaLabel.TabIndex = 105;
            this.cijenaLabel.Text = "Jedinična cijena:";
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackgroundImage = global::Skladista.Properties.Resources.Floppy;
            this.btnSpremi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSpremi.Location = new System.Drawing.Point(616, 36);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(118, 40);
            this.btnSpremi.TabIndex = 104;
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackgroundImage = global::Skladista.Properties.Resources.Add;
            this.btnDodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDodaj.Location = new System.Drawing.Point(616, 368);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(118, 46);
            this.btnDodaj.TabIndex = 103;
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // cmbKolicina
            // 
            this.cmbKolicina.Location = new System.Drawing.Point(429, 268);
            this.cmbKolicina.Name = "cmbKolicina";
            this.cmbKolicina.Size = new System.Drawing.Size(152, 20);
            this.cmbKolicina.TabIndex = 102;
            this.cmbKolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPoslovniPartner
            // 
            this.lblPoslovniPartner.AutoSize = true;
            this.lblPoslovniPartner.BackColor = System.Drawing.Color.Transparent;
            this.lblPoslovniPartner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPoslovniPartner.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPoslovniPartner.Location = new System.Drawing.Point(41, 143);
            this.lblPoslovniPartner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPoslovniPartner.Name = "lblPoslovniPartner";
            this.lblPoslovniPartner.Size = new System.Drawing.Size(191, 25);
            this.lblPoslovniPartner.TabIndex = 101;
            this.lblPoslovniPartner.Text = "Poslovni partner:";
            // 
            // dtpKreiranje
            // 
            this.dtpKreiranje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpKreiranje.Location = new System.Drawing.Point(148, 98);
            this.dtpKreiranje.Name = "dtpKreiranje";
            this.dtpKreiranje.Size = new System.Drawing.Size(189, 26);
            this.dtpKreiranje.TabIndex = 100;
            // 
            // txtSifraNar
            // 
            this.txtSifraNar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSifraNar.Location = new System.Drawing.Point(148, 42);
            this.txtSifraNar.Margin = new System.Windows.Forms.Padding(2);
            this.txtSifraNar.Multiline = true;
            this.txtSifraNar.Name = "txtSifraNar";
            this.txtSifraNar.ReadOnly = true;
            this.txtSifraNar.Size = new System.Drawing.Size(275, 35);
            this.txtSifraNar.TabIndex = 99;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.BackColor = System.Drawing.Color.Transparent;
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDatum.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDatum.Location = new System.Drawing.Point(41, 95);
            this.lblDatum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(86, 25);
            this.lblDatum.TabIndex = 98;
            this.lblDatum.Text = "Datum:";
            // 
            // lblSifra
            // 
            this.lblSifra.AutoSize = true;
            this.lblSifra.BackColor = System.Drawing.Color.Transparent;
            this.lblSifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSifra.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSifra.Location = new System.Drawing.Point(41, 52);
            this.lblSifra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(68, 25);
            this.lblSifra.TabIndex = 97;
            this.lblSifra.Text = "Šifra:";
            // 
            // pISkladiste2DataSet
            // 
            this.pISkladiste2DataSet.DataSetName = "PISkladiste2DataSet";
            this.pISkladiste2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // poslovniPartnerBindingSource1
            // 
            this.poslovniPartnerBindingSource1.DataMember = "poslovniPartner";
            this.poslovniPartnerBindingSource1.DataSource = this.pISkladiste2DataSet;
            // 
            // poslovniPartnerTableAdapter
            // 
            this.poslovniPartnerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArtiklTableAdapter = this.artiklTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.eksterniDokumentTableAdapter = null;
            this.tableAdapterManager.interniDokumentTableAdapter = null;
            this.tableAdapterManager.PododjelTableAdapter = null;
            this.tableAdapterManager.poslovniPartnerTableAdapter = this.poslovniPartnerTableAdapter;
            this.tableAdapterManager.SkladisteTableAdapter = null;
            this.tableAdapterManager.stavke_eksternogDokumentaTableAdapter = null;
            this.tableAdapterManager.stavke_internogDokumentaTableAdapter = null;
            this.tableAdapterManager.UlogaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Skladista.PISkladiste2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vrsta_eksternog_dokumentaTableAdapter = null;
            this.tableAdapterManager.vrsta_internog_dokumentaTableAdapter = null;
            this.tableAdapterManager.ZaposlenikTableAdapter = null;
            // 
            // artiklTableAdapter
            // 
            this.artiklTableAdapter.ClearBeforeFill = true;
            // 
            // artiklBindingSource1
            // 
            this.artiklBindingSource1.DataMember = "Artikl";
            this.artiklBindingSource1.DataSource = this.pISkladiste2DataSet;
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.BackgroundImage = global::Skladista.Properties.Resources.Delete;
            this.btnIzbrisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIzbrisi.Location = new System.Drawing.Point(616, 420);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(118, 46);
            this.btnIzbrisi.TabIndex = 118;
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // cmbAdresa
            // 
            this.cmbAdresa.DataSource = this.poslovniPartnerBindingSource;
            this.cmbAdresa.DisplayMember = "adresa";
            this.cmbAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbAdresa.FormattingEnabled = true;
            this.cmbAdresa.Location = new System.Drawing.Point(429, 144);
            this.cmbAdresa.Name = "cmbAdresa";
            this.cmbAdresa.Size = new System.Drawing.Size(131, 28);
            this.cmbAdresa.TabIndex = 119;
            this.cmbAdresa.ValueMember = "sifra";
            // 
            // Narudžbenica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 534);
            this.Controls.Add(this.cmbAdresa);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.cmbNazivPartner);
            this.Controls.Add(this.dgvPrikaz);
            this.Controls.Add(this.cmbCijena);
            this.Controls.Add(this.prezimeComboBox);
            this.Controls.Add(this.imeComboBox);
            this.Controls.Add(this.lblIzradio);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.cmbNaziv);
            this.Controls.Add(sifraLabel);
            this.Controls.Add(this.cmbSifra);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.kolivinaLabel);
            this.Controls.Add(this.cijenaLabel);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cmbKolicina);
            this.Controls.Add(this.lblPoslovniPartner);
            this.Controls.Add(this.dtpKreiranje);
            this.Controls.Add(this.txtSifraNar);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblSifra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Narudžbenica";
            this.Text = "Kreiranje narudžbenice";
            this.Load += new System.EventHandler(this.Narudžbenica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeeksternogDokumentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovniPartnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pISkladiste2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovniPartnerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddokumentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artiklDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eksterniDokumentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource stavkeeksternogDokumentaBindingSource;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicnaCijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmbNazivPartner;
        private System.Windows.Forms.DataGridView dgvPrikaz;
        private System.Windows.Forms.ComboBox cmbCijena;
        private System.Windows.Forms.ComboBox prezimeComboBox;
        private System.Windows.Forms.ComboBox imeComboBox;
        private System.Windows.Forms.Label lblIzradio;
        private System.Windows.Forms.ComboBox cmbNaziv;
        private System.Windows.Forms.ComboBox cmbSifra;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Label kolivinaLabel;
        private System.Windows.Forms.Label cijenaLabel;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox cmbKolicina;
        private System.Windows.Forms.Label lblPoslovniPartner;
        private System.Windows.Forms.DateTimePicker dtpKreiranje;
        private System.Windows.Forms.TextBox txtSifraNar;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblSifra;
        private System.Windows.Forms.BindingSource poslovniPartnerBindingSource;
        private PISkladiste2DataSet pISkladiste2DataSet;
        private System.Windows.Forms.BindingSource poslovniPartnerBindingSource1;
        private PISkladiste2DataSetTableAdapters.poslovniPartnerTableAdapter poslovniPartnerTableAdapter;
        private PISkladiste2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private PISkladiste2DataSetTableAdapters.ArtiklTableAdapter artiklTableAdapter;
        private System.Windows.Forms.BindingSource artiklBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_artikla;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn suma;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.ComboBox cmbAdresa;
    }
}