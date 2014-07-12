namespace Skladista
{
    partial class Skladišnica
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
            System.Windows.Forms.Label sifraLabel;
            System.Windows.Forms.Label nazivLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Skladišnica));
            this.btnZatvori = new System.Windows.Forms.Button();
            this.kolicinaLabel = new System.Windows.Forms.Label();
            this.labelCijena = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.lblIzradio = new System.Windows.Forms.Label();
            this.dtpDatumKreiranja = new System.Windows.Forms.DateTimePicker();
            this.txtSifraSkl = new System.Windows.Forms.TextBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblSifra = new System.Windows.Forms.Label();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbSifraArtikla = new System.Windows.Forms.ComboBox();
            this.cmbNazivArtikla = new System.Windows.Forms.ComboBox();
            this.cmbCijena = new System.Windows.Forms.ComboBox();
            this.povijestCijenaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pISkladiste2DataSet = new Skladista.PISkladiste2DataSet();
            this.artiklBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.artiklTableAdapter = new Skladista.PISkladiste2DataSetTableAdapters.ArtiklTableAdapter();
            this.tableAdapterManager = new Skladista.PISkladiste2DataSetTableAdapters.TableAdapterManager();
            this.txtIzradioIme = new System.Windows.Forms.ComboBox();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtIzradioPrezime = new System.Windows.Forms.ComboBox();
            this.dgvPrikaz = new System.Windows.Forms.DataGridView();
            this.id_artikla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_dokumenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ukupno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            sifraLabel = new System.Windows.Forms.Label();
            nazivLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.povijestCijenaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pISkladiste2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikaz)).BeginInit();
            this.SuspendLayout();
            // 
            // sifraLabel
            // 
            sifraLabel.AutoSize = true;
            sifraLabel.BackColor = System.Drawing.Color.Transparent;
            sifraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            sifraLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            sifraLabel.Location = new System.Drawing.Point(82, 212);
            sifraLabel.Name = "sifraLabel";
            sifraLabel.Size = new System.Drawing.Size(96, 20);
            sifraLabel.TabIndex = 56;
            sifraLabel.Text = "Šifra artikla: ";
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.BackColor = System.Drawing.Color.Transparent;
            nazivLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            nazivLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            nazivLabel.Location = new System.Drawing.Point(82, 242);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(97, 20);
            nazivLabel.TabIndex = 57;
            nazivLabel.Text = "Naziv artikla:";
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackgroundImage = global::Skladista.Properties.Resources.Close1;
            this.btnZatvori.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnZatvori.Location = new System.Drawing.Point(804, 114);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(112, 42);
            this.btnZatvori.TabIndex = 55;
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // kolicinaLabel
            // 
            this.kolicinaLabel.AutoSize = true;
            this.kolicinaLabel.BackColor = System.Drawing.Color.Transparent;
            this.kolicinaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kolicinaLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.kolicinaLabel.Location = new System.Drawing.Point(389, 209);
            this.kolicinaLabel.Name = "kolicinaLabel";
            this.kolicinaLabel.Size = new System.Drawing.Size(67, 20);
            this.kolicinaLabel.TabIndex = 52;
            this.kolicinaLabel.Text = "Količina:";
            // 
            // labelCijena
            // 
            this.labelCijena.AutoSize = true;
            this.labelCijena.BackColor = System.Drawing.Color.Transparent;
            this.labelCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCijena.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelCijena.Location = new System.Drawing.Point(389, 242);
            this.labelCijena.Name = "labelCijena";
            this.labelCijena.Size = new System.Drawing.Size(125, 20);
            this.labelCijena.TabIndex = 50;
            this.labelCijena.Text = "Jedinična cijena:";
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackgroundImage = global::Skladista.Properties.Resources.Floppy;
            this.btnSpremi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSpremi.Location = new System.Drawing.Point(804, 39);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(112, 40);
            this.btnSpremi.TabIndex = 49;
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackgroundImage = global::Skladista.Properties.Resources.Add;
            this.btnDodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDodaj.Location = new System.Drawing.Point(804, 300);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(112, 46);
            this.btnDodaj.TabIndex = 48;
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click_1);
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(520, 214);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(184, 20);
            this.txtKolicina.TabIndex = 46;
            // 
            // lblIzradio
            // 
            this.lblIzradio.AutoSize = true;
            this.lblIzradio.BackColor = System.Drawing.Color.Transparent;
            this.lblIzradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIzradio.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblIzradio.Location = new System.Drawing.Point(48, 142);
            this.lblIzradio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIzradio.Name = "lblIzradio";
            this.lblIzradio.Size = new System.Drawing.Size(90, 25);
            this.lblIzradio.TabIndex = 45;
            this.lblIzradio.Text = "Izradio:";
            // 
            // dtpDatumKreiranja
            // 
            this.dtpDatumKreiranja.Location = new System.Drawing.Point(155, 100);
            this.dtpDatumKreiranja.Name = "dtpDatumKreiranja";
            this.dtpDatumKreiranja.ShowUpDown = true;
            this.dtpDatumKreiranja.Size = new System.Drawing.Size(216, 20);
            this.dtpDatumKreiranja.TabIndex = 44;
            // 
            // txtSifraSkl
            // 
            this.txtSifraSkl.Enabled = false;
            this.txtSifraSkl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSifraSkl.Location = new System.Drawing.Point(155, 44);
            this.txtSifraSkl.Margin = new System.Windows.Forms.Padding(2);
            this.txtSifraSkl.Multiline = true;
            this.txtSifraSkl.Name = "txtSifraSkl";
            this.txtSifraSkl.ReadOnly = true;
            this.txtSifraSkl.Size = new System.Drawing.Size(275, 35);
            this.txtSifraSkl.TabIndex = 43;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.BackColor = System.Drawing.Color.Transparent;
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDatum.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDatum.Location = new System.Drawing.Point(48, 97);
            this.lblDatum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(86, 25);
            this.lblDatum.TabIndex = 42;
            this.lblDatum.Text = "Datum:";
            // 
            // lblSifra
            // 
            this.lblSifra.AutoSize = true;
            this.lblSifra.BackColor = System.Drawing.Color.Transparent;
            this.lblSifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSifra.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSifra.Location = new System.Drawing.Point(48, 54);
            this.lblSifra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(68, 25);
            this.lblSifra.TabIndex = 41;
            this.lblSifra.Text = "Šifra:";
            // 
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataSource = typeof(Skladista.Artikl);
            // 
            // cmbSifraArtikla
            // 
            this.cmbSifraArtikla.DataSource = this.artiklBindingSource;
            this.cmbSifraArtikla.DisplayMember = "sifra";
            this.cmbSifraArtikla.FormattingEnabled = true;
            this.cmbSifraArtikla.Location = new System.Drawing.Point(185, 211);
            this.cmbSifraArtikla.Name = "cmbSifraArtikla";
            this.cmbSifraArtikla.Size = new System.Drawing.Size(186, 21);
            this.cmbSifraArtikla.TabIndex = 58;
            this.cmbSifraArtikla.ValueMember = "sifra";
            // 
            // cmbNazivArtikla
            // 
            this.cmbNazivArtikla.DataSource = this.artiklBindingSource;
            this.cmbNazivArtikla.DisplayMember = "naziv";
            this.cmbNazivArtikla.FormattingEnabled = true;
            this.cmbNazivArtikla.Location = new System.Drawing.Point(185, 242);
            this.cmbNazivArtikla.Name = "cmbNazivArtikla";
            this.cmbNazivArtikla.Size = new System.Drawing.Size(186, 21);
            this.cmbNazivArtikla.TabIndex = 59;
            this.cmbNazivArtikla.ValueMember = "sifra";
            // 
            // cmbCijena
            // 
            this.cmbCijena.DataSource = this.artiklBindingSource;
            this.cmbCijena.DisplayMember = "nabavna_cijena";
            this.cmbCijena.FormatString = "N2";
            this.cmbCijena.FormattingEnabled = true;
            this.cmbCijena.Location = new System.Drawing.Point(520, 244);
            this.cmbCijena.Name = "cmbCijena";
            this.cmbCijena.Size = new System.Drawing.Size(184, 21);
            this.cmbCijena.TabIndex = 60;
            this.cmbCijena.ValueMember = "sifra_artikla";
            // 
            // pISkladiste2DataSet
            // 
            this.pISkladiste2DataSet.DataSetName = "PISkladiste2DataSet";
            this.pISkladiste2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artiklBindingSource1
            // 
            this.artiklBindingSource1.DataMember = "Artikl";
            this.artiklBindingSource1.DataSource = this.pISkladiste2DataSet;
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
            // txtIzradioIme
            // 
            this.txtIzradioIme.DataSource = this.zaposlenikBindingSource;
            this.txtIzradioIme.DisplayMember = "prezime";
            this.txtIzradioIme.FormattingEnabled = true;
            this.txtIzradioIme.Location = new System.Drawing.Point(155, 145);
            this.txtIzradioIme.Name = "txtIzradioIme";
            this.txtIzradioIme.Size = new System.Drawing.Size(162, 21);
            this.txtIzradioIme.TabIndex = 62;
            this.txtIzradioIme.ValueMember = "sifra";
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataSource = typeof(Skladista.Zaposlenik);
            // 
            // korisniciBindingSource
            // 
            this.korisniciBindingSource.DataSource = typeof(Skladista.Korisnici);
            // 
            // txtIzradioPrezime
            // 
            this.txtIzradioPrezime.DataSource = this.zaposlenikBindingSource;
            this.txtIzradioPrezime.DisplayMember = "ime";
            this.txtIzradioPrezime.FormattingEnabled = true;
            this.txtIzradioPrezime.Location = new System.Drawing.Point(323, 145);
            this.txtIzradioPrezime.Name = "txtIzradioPrezime";
            this.txtIzradioPrezime.Size = new System.Drawing.Size(176, 21);
            this.txtIzradioPrezime.TabIndex = 63;
            this.txtIzradioPrezime.ValueMember = "sifra";
            // 
            // dgvPrikaz
            // 
            this.dgvPrikaz.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvPrikaz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPrikaz.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvPrikaz.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrikaz.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikaz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_artikla,
            this.id_dokumenta,
            this.kolicin,
            this.Cijena,
            this.Ukupno});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrikaz.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrikaz.Location = new System.Drawing.Point(53, 300);
            this.dgvPrikaz.Name = "dgvPrikaz";
            this.dgvPrikaz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrikaz.Size = new System.Drawing.Size(731, 169);
            this.dgvPrikaz.TabIndex = 64;
            // 
            // id_artikla
            // 
            this.id_artikla.HeaderText = "Šifra artikla";
            this.id_artikla.Name = "id_artikla";
            this.id_artikla.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_artikla.Visible = false;
            this.id_artikla.Width = 250;
            // 
            // id_dokumenta
            // 
            this.id_dokumenta.HeaderText = "Naziv artikla";
            this.id_dokumenta.Name = "id_dokumenta";
            this.id_dokumenta.Width = 200;
            // 
            // kolicin
            // 
            this.kolicin.HeaderText = "Količina";
            this.kolicin.Name = "kolicin";
            this.kolicin.Width = 150;
            // 
            // Cijena
            // 
            this.Cijena.HeaderText = "Jedinična cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.Width = 200;
            // 
            // Ukupno
            // 
            this.Ukupno.HeaderText = "Ukupna cijena";
            this.Ukupno.Name = "Ukupno";
            this.Ukupno.Width = 130;
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.BackgroundImage = global::Skladista.Properties.Resources.Delete;
            this.btnIzbrisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIzbrisi.Location = new System.Drawing.Point(804, 352);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(112, 46);
            this.btnIzbrisi.TabIndex = 120;
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // Skladišnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 508);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.dgvPrikaz);
            this.Controls.Add(this.txtIzradioPrezime);
            this.Controls.Add(this.txtIzradioIme);
            this.Controls.Add(this.cmbCijena);
            this.Controls.Add(this.cmbNazivArtikla);
            this.Controls.Add(this.cmbSifraArtikla);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(sifraLabel);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.kolicinaLabel);
            this.Controls.Add(this.labelCijena);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.lblIzradio);
            this.Controls.Add(this.dtpDatumKreiranja);
            this.Controls.Add(this.txtSifraSkl);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblSifra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Skladišnica";
            this.Text = "Kreiranje skladišnice";
            this.Load += new System.EventHandler(this.Skladišnica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.povijestCijenaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pISkladiste2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikaz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Label kolicinaLabel;
        private System.Windows.Forms.Label labelCijena;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label lblIzradio;
        private System.Windows.Forms.DateTimePicker dtpDatumKreiranja;
        private System.Windows.Forms.TextBox txtSifraSkl;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblSifra;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private System.Windows.Forms.ComboBox cmbSifraArtikla;
        private System.Windows.Forms.ComboBox cmbNazivArtikla;
        private System.Windows.Forms.ComboBox cmbCijena;
        private PISkladiste2DataSet pISkladiste2DataSet;
        private System.Windows.Forms.BindingSource artiklBindingSource1;
        private PISkladiste2DataSetTableAdapters.ArtiklTableAdapter artiklTableAdapter;
        private PISkladiste2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox txtIzradioIme;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private System.Windows.Forms.BindingSource korisniciBindingSource;
        private System.Windows.Forms.ComboBox txtIzradioPrezime;
        private System.Windows.Forms.BindingSource povijestCijenaBindingSource;
        private System.Windows.Forms.DataGridView dgvPrikaz;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_artikla;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_dokumenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ukupno;
        private System.Windows.Forms.Button btnIzbrisi;
    }
}