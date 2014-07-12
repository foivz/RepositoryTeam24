namespace Skladista
{
    partial class Otpremnica
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
            System.Windows.Forms.Label lblSifraArtikla;
            System.Windows.Forms.Label lblNaziv;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Otpremnica));
            this.btnZatvori = new System.Windows.Forms.Button();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.lblCijena = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.lblPartner = new System.Windows.Forms.Label();
            this.dtmIzrada = new System.Windows.Forms.DateTimePicker();
            this.txtSifraOtp = new System.Windows.Forms.TextBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblSifra = new System.Windows.Forms.Label();
            this.pISkladiste2DataSet = new Skladista.PISkladiste2DataSet();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artiklTableAdapter = new Skladista.PISkladiste2DataSetTableAdapters.ArtiklTableAdapter();
            this.tableAdapterManager = new Skladista.PISkladiste2DataSetTableAdapters.TableAdapterManager();
            this.cmbSifraArtikla = new System.Windows.Forms.ComboBox();
            this.cmbNazivArtikla = new System.Windows.Forms.ComboBox();
            this.lblIzradio = new System.Windows.Forms.Label();
            this.poslovniPartnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poslovniPartnerTableAdapter = new Skladista.PISkladiste2DataSetTableAdapters.poslovniPartnerTableAdapter();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaposlenikTableAdapter = new Skladista.PISkladiste2DataSetTableAdapters.ZaposlenikTableAdapter();
            this.cmbIme = new System.Windows.Forms.ComboBox();
            this.cmbPrezime = new System.Windows.Forms.ComboBox();
            this.cmbCijena = new System.Windows.Forms.ComboBox();
            this.dgvPrikaz = new System.Windows.Forms.DataGridView();
            this.id_artikla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavke_eksternogDokumentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbPoslovniNaziv = new System.Windows.Forms.ComboBox();
            this.cmbAdresa = new System.Windows.Forms.TextBox();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            lblSifraArtikla = new System.Windows.Forms.Label();
            lblNaziv = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pISkladiste2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovniPartnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavke_eksternogDokumentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSifraArtikla
            // 
            lblSifraArtikla.AutoSize = true;
            lblSifraArtikla.BackColor = System.Drawing.Color.Transparent;
            lblSifraArtikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            lblSifraArtikla.ForeColor = System.Drawing.SystemColors.HotTrack;
            lblSifraArtikla.Location = new System.Drawing.Point(66, 261);
            lblSifraArtikla.Name = "lblSifraArtikla";
            lblSifraArtikla.Size = new System.Drawing.Size(47, 17);
            lblSifraArtikla.TabIndex = 86;
            lblSifraArtikla.Text = "Šifra:";
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.BackColor = System.Drawing.Color.Transparent;
            lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            lblNaziv.ForeColor = System.Drawing.SystemColors.HotTrack;
            lblNaziv.Location = new System.Drawing.Point(60, 290);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new System.Drawing.Size(53, 17);
            lblNaziv.TabIndex = 87;
            lblNaziv.Text = "Naziv:";
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackgroundImage = global::Skladista.Properties.Resources.Close;
            this.btnZatvori.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnZatvori.Location = new System.Drawing.Point(630, 88);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(109, 42);
            this.btnZatvori.TabIndex = 85;
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.BackColor = System.Drawing.Color.Transparent;
            this.lblKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKolicina.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblKolicina.Location = new System.Drawing.Point(320, 256);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(70, 17);
            this.lblKolicina.TabIndex = 84;
            this.lblKolicina.Text = "Količina:";
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.BackColor = System.Drawing.Color.Transparent;
            this.lblCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCijena.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCijena.Location = new System.Drawing.Point(269, 289);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(130, 17);
            this.lblCijena.TabIndex = 83;
            this.lblCijena.Text = "Jedinična cijena:";
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackgroundImage = global::Skladista.Properties.Resources.Floppy;
            this.btnSpremi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSpremi.Location = new System.Drawing.Point(630, 37);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(109, 40);
            this.btnSpremi.TabIndex = 82;
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackgroundImage = global::Skladista.Properties.Resources.Add;
            this.btnDodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDodaj.Location = new System.Drawing.Point(630, 337);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(109, 46);
            this.btnDodaj.TabIndex = 81;
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtKolicina
            // 
            this.txtKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKolicina.Location = new System.Drawing.Point(420, 250);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(153, 23);
            this.txtKolicina.TabIndex = 79;
            this.txtKolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPartner
            // 
            this.lblPartner.AutoSize = true;
            this.lblPartner.BackColor = System.Drawing.Color.Transparent;
            this.lblPartner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPartner.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPartner.Location = new System.Drawing.Point(34, 138);
            this.lblPartner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPartner.Name = "lblPartner";
            this.lblPartner.Size = new System.Drawing.Size(191, 25);
            this.lblPartner.TabIndex = 78;
            this.lblPartner.Text = "Poslovni partner:";
            // 
            // dtmIzrada
            // 
            this.dtmIzrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtmIzrada.Location = new System.Drawing.Point(141, 96);
            this.dtmIzrada.Name = "dtmIzrada";
            this.dtmIzrada.Size = new System.Drawing.Size(189, 26);
            this.dtmIzrada.TabIndex = 77;
            // 
            // txtSifraOtp
            // 
            this.txtSifraOtp.Enabled = false;
            this.txtSifraOtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSifraOtp.Location = new System.Drawing.Point(141, 40);
            this.txtSifraOtp.Margin = new System.Windows.Forms.Padding(2);
            this.txtSifraOtp.Multiline = true;
            this.txtSifraOtp.Name = "txtSifraOtp";
            this.txtSifraOtp.ReadOnly = true;
            this.txtSifraOtp.Size = new System.Drawing.Size(275, 35);
            this.txtSifraOtp.TabIndex = 76;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.BackColor = System.Drawing.Color.Transparent;
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDatum.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDatum.Location = new System.Drawing.Point(34, 94);
            this.lblDatum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(86, 25);
            this.lblDatum.TabIndex = 75;
            this.lblDatum.Text = "Datum:";
            // 
            // lblSifra
            // 
            this.lblSifra.AutoSize = true;
            this.lblSifra.BackColor = System.Drawing.Color.Transparent;
            this.lblSifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSifra.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSifra.Location = new System.Drawing.Point(34, 50);
            this.lblSifra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(68, 25);
            this.lblSifra.TabIndex = 74;
            this.lblSifra.Text = "Šifra:";
            // 
            // pISkladiste2DataSet
            // 
            this.pISkladiste2DataSet.DataSetName = "PISkladiste2DataSet";
            this.pISkladiste2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataMember = "Artikl";
            this.artiklBindingSource.DataSource = this.pISkladiste2DataSet;
            // 
            // artiklTableAdapter
            // 
            this.artiklTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArtiklTableAdapter = this.artiklTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.eksterniDokumentTableAdapter = null;
            this.tableAdapterManager.interniDokumentTableAdapter = null;
            this.tableAdapterManager.PododjelTableAdapter = null;
            this.tableAdapterManager.poslovniPartnerTableAdapter = null;
            this.tableAdapterManager.SkladisteTableAdapter = null;
            this.tableAdapterManager.stavke_eksternogDokumentaTableAdapter = null;
            this.tableAdapterManager.stavke_internogDokumentaTableAdapter = null;
            this.tableAdapterManager.UlogaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Skladista.PISkladiste2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vrsta_eksternog_dokumentaTableAdapter = null;
            this.tableAdapterManager.vrsta_internog_dokumentaTableAdapter = null;
            this.tableAdapterManager.ZaposlenikTableAdapter = null;
            // 
            // cmbSifraArtikla
            // 
            this.cmbSifraArtikla.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artiklBindingSource, "sifra", true));
            this.cmbSifraArtikla.DataSource = this.artiklBindingSource;
            this.cmbSifraArtikla.DisplayMember = "sifra";
            this.cmbSifraArtikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbSifraArtikla.FormattingEnabled = true;
            this.cmbSifraArtikla.Location = new System.Drawing.Point(129, 258);
            this.cmbSifraArtikla.Name = "cmbSifraArtikla";
            this.cmbSifraArtikla.Size = new System.Drawing.Size(121, 24);
            this.cmbSifraArtikla.TabIndex = 87;
            this.cmbSifraArtikla.ValueMember = "sifra";
            // 
            // cmbNazivArtikla
            // 
            this.cmbNazivArtikla.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artiklBindingSource, "naziv", true));
            this.cmbNazivArtikla.DataSource = this.artiklBindingSource;
            this.cmbNazivArtikla.DisplayMember = "naziv";
            this.cmbNazivArtikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbNazivArtikla.FormattingEnabled = true;
            this.cmbNazivArtikla.Location = new System.Drawing.Point(129, 287);
            this.cmbNazivArtikla.Name = "cmbNazivArtikla";
            this.cmbNazivArtikla.Size = new System.Drawing.Size(121, 24);
            this.cmbNazivArtikla.TabIndex = 88;
            this.cmbNazivArtikla.ValueMember = "sifra";
            // 
            // lblIzradio
            // 
            this.lblIzradio.AutoSize = true;
            this.lblIzradio.BackColor = System.Drawing.Color.Transparent;
            this.lblIzradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIzradio.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblIzradio.Location = new System.Drawing.Point(34, 181);
            this.lblIzradio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIzradio.Name = "lblIzradio";
            this.lblIzradio.Size = new System.Drawing.Size(90, 25);
            this.lblIzradio.TabIndex = 89;
            this.lblIzradio.Text = "Izradio:";
            // 
            // poslovniPartnerBindingSource
            // 
            this.poslovniPartnerBindingSource.DataMember = "poslovniPartner";
            this.poslovniPartnerBindingSource.DataSource = this.pISkladiste2DataSet;
            // 
            // poslovniPartnerTableAdapter
            // 
            this.poslovniPartnerTableAdapter.ClearBeforeFill = true;
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataMember = "Zaposlenik";
            this.zaposlenikBindingSource.DataSource = this.pISkladiste2DataSet;
            // 
            // zaposlenikTableAdapter
            // 
            this.zaposlenikTableAdapter.ClearBeforeFill = true;
            // 
            // cmbIme
            // 
            this.cmbIme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "ime", true));
            this.cmbIme.DataSource = this.zaposlenikBindingSource;
            this.cmbIme.DisplayMember = "prezime";
            this.cmbIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbIme.FormattingEnabled = true;
            this.cmbIme.Location = new System.Drawing.Point(129, 182);
            this.cmbIme.Name = "cmbIme";
            this.cmbIme.Size = new System.Drawing.Size(121, 28);
            this.cmbIme.TabIndex = 91;
            this.cmbIme.ValueMember = "sifra";
            // 
            // cmbPrezime
            // 
            this.cmbPrezime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "prezime", true));
            this.cmbPrezime.DataSource = this.zaposlenikBindingSource;
            this.cmbPrezime.DisplayMember = "ime";
            this.cmbPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbPrezime.FormattingEnabled = true;
            this.cmbPrezime.Location = new System.Drawing.Point(263, 182);
            this.cmbPrezime.Name = "cmbPrezime";
            this.cmbPrezime.Size = new System.Drawing.Size(153, 28);
            this.cmbPrezime.TabIndex = 92;
            this.cmbPrezime.ValueMember = "sifra";
            // 
            // cmbCijena
            // 
            this.cmbCijena.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artiklBindingSource, "nabavna_cijena", true));
            this.cmbCijena.DataSource = this.artiklBindingSource;
            this.cmbCijena.DisplayMember = "nabavna_cijena";
            this.cmbCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbCijena.FormatString = "N2";
            this.cmbCijena.FormattingEnabled = true;
            this.cmbCijena.Location = new System.Drawing.Point(420, 287);
            this.cmbCijena.Name = "cmbCijena";
            this.cmbCijena.Size = new System.Drawing.Size(153, 24);
            this.cmbCijena.TabIndex = 93;
            this.cmbCijena.ValueMember = "nabavna_cijena";
            // 
            // dgvPrikaz
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvPrikaz.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrikaz.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrikaz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPrikaz.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrikaz.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikaz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_artikla,
            this.naziv,
            this.kolicina,
            this.cijena,
            this.suma});
            this.dgvPrikaz.Location = new System.Drawing.Point(50, 337);
            this.dgvPrikaz.Name = "dgvPrikaz";
            this.dgvPrikaz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrikaz.Size = new System.Drawing.Size(548, 148);
            this.dgvPrikaz.TabIndex = 94;
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
            // stavke_eksternogDokumentaBindingSource
            // 
            this.stavke_eksternogDokumentaBindingSource.DataSource = typeof(Skladista.stavke_eksternogDokumenta);
            // 
            // cmbPoslovniNaziv
            // 
            this.cmbPoslovniNaziv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.poslovniPartnerBindingSource, "naziv", true));
            this.cmbPoslovniNaziv.DataSource = this.poslovniPartnerBindingSource;
            this.cmbPoslovniNaziv.DisplayMember = "naziv";
            this.cmbPoslovniNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbPoslovniNaziv.FormattingEnabled = true;
            this.cmbPoslovniNaziv.Location = new System.Drawing.Point(230, 142);
            this.cmbPoslovniNaziv.Name = "cmbPoslovniNaziv";
            this.cmbPoslovniNaziv.Size = new System.Drawing.Size(186, 28);
            this.cmbPoslovniNaziv.TabIndex = 95;
            this.cmbPoslovniNaziv.ValueMember = "sifra";
            // 
            // cmbAdresa
            // 
            this.cmbAdresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.poslovniPartnerBindingSource, "adresa", true));
            this.cmbAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbAdresa.Location = new System.Drawing.Point(422, 144);
            this.cmbAdresa.Name = "cmbAdresa";
            this.cmbAdresa.Size = new System.Drawing.Size(151, 26);
            this.cmbAdresa.TabIndex = 96;
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.BackgroundImage = global::Skladista.Properties.Resources.Delete;
            this.btnIzbrisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIzbrisi.Location = new System.Drawing.Point(630, 389);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(109, 46);
            this.btnIzbrisi.TabIndex = 119;
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // Otpremnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 508);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.cmbAdresa);
            this.Controls.Add(this.cmbPoslovniNaziv);
            this.Controls.Add(this.dgvPrikaz);
            this.Controls.Add(this.cmbCijena);
            this.Controls.Add(this.cmbPrezime);
            this.Controls.Add(this.cmbIme);
            this.Controls.Add(this.lblIzradio);
            this.Controls.Add(lblNaziv);
            this.Controls.Add(this.cmbNazivArtikla);
            this.Controls.Add(lblSifraArtikla);
            this.Controls.Add(this.cmbSifraArtikla);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.lblPartner);
            this.Controls.Add(this.dtmIzrada);
            this.Controls.Add(this.txtSifraOtp);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblSifra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Otpremnica";
            this.Text = "Kreiranje otpremnice";
            this.Load += new System.EventHandler(this.Otpremnica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pISkladiste2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovniPartnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavke_eksternogDokumentaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label lblPartner;
        private System.Windows.Forms.DateTimePicker dtmIzrada;
        private System.Windows.Forms.TextBox txtSifraOtp;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblSifra;
        private PISkladiste2DataSet pISkladiste2DataSet;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private PISkladiste2DataSetTableAdapters.ArtiklTableAdapter artiklTableAdapter;
        private PISkladiste2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbSifraArtikla;
        private System.Windows.Forms.ComboBox cmbNazivArtikla;
        private System.Windows.Forms.Label lblIzradio;
        private System.Windows.Forms.BindingSource poslovniPartnerBindingSource;
        private PISkladiste2DataSetTableAdapters.poslovniPartnerTableAdapter poslovniPartnerTableAdapter;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private PISkladiste2DataSetTableAdapters.ZaposlenikTableAdapter zaposlenikTableAdapter;
        private System.Windows.Forms.ComboBox cmbIme;
        private System.Windows.Forms.ComboBox cmbPrezime;
        private System.Windows.Forms.ComboBox cmbCijena;
        private System.Windows.Forms.DataGridView dgvPrikaz;
        private System.Windows.Forms.BindingSource stavke_eksternogDokumentaBindingSource;
        private System.Windows.Forms.ComboBox cmbPoslovniNaziv;
        private System.Windows.Forms.TextBox cmbAdresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_artikla;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn suma;
        private System.Windows.Forms.Button btnIzbrisi;
    }
}