namespace Skladista
{
    partial class azurirajNarudzbenicu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(azurirajNarudzbenicu));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.poslovniPartnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnIzmjeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.nazivComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbIzradioSifra = new System.Windows.Forms.ComboBox();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cmbIzradio = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavkeeksternogDokumentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.povijestCijenaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.datumIzrade = new System.Windows.Forms.DateTimePicker();
            this.txtSifraNar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artiklDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eksterniDokumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijena_artikla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.poslovniPartnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeeksternogDokumentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.povijestCijenaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.poslovniPartnerBindingSource;
            this.comboBox1.DisplayMember = "sifra";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(244, 180);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 28);
            this.comboBox1.TabIndex = 103;
            this.comboBox1.ValueMember = "sifra";
            // 
            // poslovniPartnerBindingSource
            // 
            this.poslovniPartnerBindingSource.DataSource = typeof(Skladista.poslovniPartner);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.BackgroundImage = global::Skladista.Properties.Resources.Delete;
            this.btnIzbrisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIzbrisi.Location = new System.Drawing.Point(652, 374);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(167, 38);
            this.btnIzbrisi.TabIndex = 102;
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.BackgroundImage = global::Skladista.Properties.Resources.ssssssss;
            this.btnIzmjeni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIzmjeni.Location = new System.Drawing.Point(652, 315);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(167, 38);
            this.btnIzmjeni.TabIndex = 101;
            this.btnIzmjeni.UseVisualStyleBackColor = true;
            this.btnIzmjeni.Click += new System.EventHandler(this.btnIzmjeni_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackgroundImage = global::Skladista.Properties.Resources.Add;
            this.btnDodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDodaj.Location = new System.Drawing.Point(652, 254);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(167, 38);
            this.btnDodaj.TabIndex = 100;
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackgroundImage = global::Skladista.Properties.Resources.Close;
            this.btnZatvori.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnZatvori.Location = new System.Drawing.Point(652, 114);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(167, 42);
            this.btnZatvori.TabIndex = 99;
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackgroundImage = global::Skladista.Properties.Resources.Floppy;
            this.btnSpremi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSpremi.Location = new System.Drawing.Point(652, 51);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(167, 40);
            this.btnSpremi.TabIndex = 98;
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // nazivComboBox
            // 
            this.nazivComboBox.DataSource = this.poslovniPartnerBindingSource;
            this.nazivComboBox.DisplayMember = "naziv";
            this.nazivComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazivComboBox.FormattingEnabled = true;
            this.nazivComboBox.Location = new System.Drawing.Point(367, 180);
            this.nazivComboBox.Name = "nazivComboBox";
            this.nazivComboBox.Size = new System.Drawing.Size(248, 28);
            this.nazivComboBox.TabIndex = 97;
            this.nazivComboBox.ValueMember = "sifra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(40, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 25);
            this.label4.TabIndex = 96;
            this.label4.Text = "Poslovni partner:";
            // 
            // cmbIzradioSifra
            // 
            this.cmbIzradioSifra.DataSource = this.zaposlenikBindingSource;
            this.cmbIzradioSifra.DisplayMember = "sifra";
            this.cmbIzradioSifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbIzradioSifra.FormattingEnabled = true;
            this.cmbIzradioSifra.Location = new System.Drawing.Point(147, 145);
            this.cmbIzradioSifra.Name = "cmbIzradioSifra";
            this.cmbIzradioSifra.Size = new System.Drawing.Size(64, 28);
            this.cmbIzradioSifra.TabIndex = 95;
            this.cmbIzradioSifra.ValueMember = "sifra";
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataSource = typeof(Skladista.Zaposlenik);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.zaposlenikBindingSource;
            this.comboBox2.DisplayMember = "prezime";
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(423, 145);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(192, 28);
            this.comboBox2.TabIndex = 94;
            this.comboBox2.ValueMember = "sifra";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cmbIzradio
            // 
            this.cmbIzradio.DataSource = this.zaposlenikBindingSource;
            this.cmbIzradio.DisplayMember = "ime";
            this.cmbIzradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbIzradio.FormattingEnabled = true;
            this.cmbIzradio.Location = new System.Drawing.Point(228, 145);
            this.cmbIzradio.Name = "cmbIzradio";
            this.cmbIzradio.Size = new System.Drawing.Size(189, 28);
            this.cmbIzradio.TabIndex = 93;
            this.cmbIzradio.ValueMember = "sifra";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idartiklaDataGridViewTextBoxColumn,
            this.Naziv,
            this.kolicinaDataGridViewTextBoxColumn,
            this.iddokumentaDataGridViewTextBoxColumn,
            this.artiklDataGridViewTextBoxColumn,
            this.eksterniDokumentDataGridViewTextBoxColumn,
            this.cijena_artikla});
            this.dataGridView1.DataSource = this.stavkeeksternogDokumentaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(45, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(517, 183);
            this.dataGridView1.TabIndex = 92;
            // 
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataSource = typeof(Skladista.Artikl);
            // 
            // stavkeeksternogDokumentaBindingSource
            // 
            this.stavkeeksternogDokumentaBindingSource.DataSource = typeof(Skladista.stavke_eksternogDokumenta);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(40, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 91;
            this.label1.Text = "Izradio:";
            // 
            // datumIzrade
            // 
            this.datumIzrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datumIzrade.Location = new System.Drawing.Point(147, 97);
            this.datumIzrade.Name = "datumIzrade";
            this.datumIzrade.Size = new System.Drawing.Size(189, 26);
            this.datumIzrade.TabIndex = 90;
            // 
            // txtSifraNar
            // 
            this.txtSifraNar.Enabled = false;
            this.txtSifraNar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSifraNar.Location = new System.Drawing.Point(147, 41);
            this.txtSifraNar.Margin = new System.Windows.Forms.Padding(2);
            this.txtSifraNar.Multiline = true;
            this.txtSifraNar.Name = "txtSifraNar";
            this.txtSifraNar.Size = new System.Drawing.Size(275, 35);
            this.txtSifraNar.TabIndex = 89;
            this.txtSifraNar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(40, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 88;
            this.label3.Text = "Datum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(40, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 87;
            this.label2.Text = "Šifra:";
            // 
            // idartiklaDataGridViewTextBoxColumn
            // 
            this.idartiklaDataGridViewTextBoxColumn.DataPropertyName = "id_artikla";
            this.idartiklaDataGridViewTextBoxColumn.HeaderText = "Id artikla";
            this.idartiklaDataGridViewTextBoxColumn.Name = "idartiklaDataGridViewTextBoxColumn";
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "id_artikla";
            this.Naziv.DataSource = this.artiklBindingSource;
            this.Naziv.DisplayMember = "naziv";
            this.Naziv.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Naziv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Naziv.ValueMember = "sifra";
            this.Naziv.Width = 170;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // iddokumentaDataGridViewTextBoxColumn
            // 
            this.iddokumentaDataGridViewTextBoxColumn.DataPropertyName = "id_dokumenta";
            this.iddokumentaDataGridViewTextBoxColumn.HeaderText = "id_dokumenta";
            this.iddokumentaDataGridViewTextBoxColumn.Name = "iddokumentaDataGridViewTextBoxColumn";
            this.iddokumentaDataGridViewTextBoxColumn.Visible = false;
            // 
            // artiklDataGridViewTextBoxColumn
            // 
            this.artiklDataGridViewTextBoxColumn.DataPropertyName = "Artikl";
            this.artiklDataGridViewTextBoxColumn.HeaderText = "Artikl";
            this.artiklDataGridViewTextBoxColumn.Name = "artiklDataGridViewTextBoxColumn";
            this.artiklDataGridViewTextBoxColumn.Visible = false;
            // 
            // eksterniDokumentDataGridViewTextBoxColumn
            // 
            this.eksterniDokumentDataGridViewTextBoxColumn.DataPropertyName = "eksterniDokument";
            this.eksterniDokumentDataGridViewTextBoxColumn.HeaderText = "Eksterni dokument";
            this.eksterniDokumentDataGridViewTextBoxColumn.Name = "eksterniDokumentDataGridViewTextBoxColumn";
            this.eksterniDokumentDataGridViewTextBoxColumn.Visible = false;
            // 
            // cijena_artikla
            // 
            this.cijena_artikla.DataPropertyName = "cijena_artikla";
            this.cijena_artikla.HeaderText = "Cijena";
            this.cijena_artikla.Name = "cijena_artikla";
            // 
            // azurirajNarudzbenicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 474);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnIzmjeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.nazivComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbIzradioSifra);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.cmbIzradio);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datumIzrade);
            this.Controls.Add(this.txtSifraNar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "azurirajNarudzbenicu";
            this.Text = "Ažuriranje narudžbenice";
            this.Load += new System.EventHandler(this.azurirajNarudzbenicu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.poslovniPartnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeeksternogDokumentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.povijestCijenaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnIzmjeni;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.ComboBox nazivComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbIzradioSifra;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox cmbIzradio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datumIzrade;
        private System.Windows.Forms.TextBox txtSifraNar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource stavkeeksternogDokumentaBindingSource;
        private System.Windows.Forms.BindingSource poslovniPartnerBindingSource;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private System.Windows.Forms.BindingSource povijestCijenaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddokumentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artiklDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eksterniDokumentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijena_artikla;
    }
}