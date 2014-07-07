namespace Skladista
{
    partial class azurirajIzdatnicu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(azurirajIzdatnicu));
            this.cmbIzradioSifra = new System.Windows.Forms.ComboBox();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cmbIzradio = new System.Windows.Forms.ComboBox();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnIzmjeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_artikla = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijena_artikla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artiklDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interniDokumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artikl1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeinternogDokumentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.datumIzrade = new System.Windows.Forms.DateTimePicker();
            this.txtSifraNar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeinternogDokumentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbIzradioSifra
            // 
            this.cmbIzradioSifra.DataSource = this.zaposlenikBindingSource;
            this.cmbIzradioSifra.DisplayMember = "sifra";
            this.cmbIzradioSifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbIzradioSifra.FormattingEnabled = true;
            this.cmbIzradioSifra.Location = new System.Drawing.Point(128, 137);
            this.cmbIzradioSifra.Name = "cmbIzradioSifra";
            this.cmbIzradioSifra.Size = new System.Drawing.Size(64, 28);
            this.cmbIzradioSifra.TabIndex = 83;
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
            this.comboBox2.Location = new System.Drawing.Point(404, 137);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(192, 28);
            this.comboBox2.TabIndex = 82;
            this.comboBox2.ValueMember = "sifra";
            // 
            // cmbIzradio
            // 
            this.cmbIzradio.DataSource = this.zaposlenikBindingSource;
            this.cmbIzradio.DisplayMember = "ime";
            this.cmbIzradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbIzradio.FormattingEnabled = true;
            this.cmbIzradio.Location = new System.Drawing.Point(209, 137);
            this.cmbIzradio.Name = "cmbIzradio";
            this.cmbIzradio.Size = new System.Drawing.Size(189, 28);
            this.cmbIzradio.TabIndex = 81;
            this.cmbIzradio.ValueMember = "sifra";
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.BackgroundImage = global::Skladista.Properties.Resources.Delete;
            this.btnIzbrisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIzbrisi.Location = new System.Drawing.Point(758, 309);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(167, 40);
            this.btnIzbrisi.TabIndex = 80;
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.BackgroundImage = global::Skladista.Properties.Resources.ssssssss;
            this.btnIzmjeni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIzmjeni.Location = new System.Drawing.Point(758, 266);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(167, 40);
            this.btnIzmjeni.TabIndex = 79;
            this.btnIzmjeni.UseVisualStyleBackColor = true;
            this.btnIzmjeni.Click += new System.EventHandler(this.btnIzmjeni_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackgroundImage = global::Skladista.Properties.Resources.Add;
            this.btnDodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDodaj.Location = new System.Drawing.Point(758, 225);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(167, 40);
            this.btnDodaj.TabIndex = 78;
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idartiklaDataGridViewTextBoxColumn,
            this.id_artikla,
            this.kolicinaDataGridViewTextBoxColumn,
            this.cijena_artikla,
            this.iddokumentaDataGridViewTextBoxColumn,
            this.artiklDataGridViewTextBoxColumn,
            this.interniDokumentDataGridViewTextBoxColumn,
            this.artikl1DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stavkeinternogDokumentaBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(44, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(597, 183);
            this.dataGridView1.TabIndex = 77;
            // 
            // idartiklaDataGridViewTextBoxColumn
            // 
            this.idartiklaDataGridViewTextBoxColumn.DataPropertyName = "id_artikla";
            this.idartiklaDataGridViewTextBoxColumn.HeaderText = "Id artikla";
            this.idartiklaDataGridViewTextBoxColumn.Name = "idartiklaDataGridViewTextBoxColumn";
            this.idartiklaDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.cijena_artikla.HeaderText = "Cijena";
            this.cijena_artikla.Name = "cijena_artikla";
            this.cijena_artikla.ReadOnly = true;
            // 
            // iddokumentaDataGridViewTextBoxColumn
            // 
            this.iddokumentaDataGridViewTextBoxColumn.DataPropertyName = "id_dokumenta";
            this.iddokumentaDataGridViewTextBoxColumn.HeaderText = "id_dokumenta";
            this.iddokumentaDataGridViewTextBoxColumn.Name = "iddokumentaDataGridViewTextBoxColumn";
            this.iddokumentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iddokumentaDataGridViewTextBoxColumn.Visible = false;
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
            // artikl1DataGridViewTextBoxColumn
            // 
            this.artikl1DataGridViewTextBoxColumn.DataPropertyName = "Artikl1";
            this.artikl1DataGridViewTextBoxColumn.HeaderText = "Artikl1";
            this.artikl1DataGridViewTextBoxColumn.Name = "artikl1DataGridViewTextBoxColumn";
            this.artikl1DataGridViewTextBoxColumn.ReadOnly = true;
            this.artikl1DataGridViewTextBoxColumn.Visible = false;
            // 
            // stavkeinternogDokumentaBindingSource
            // 
            this.stavkeinternogDokumentaBindingSource.DataSource = typeof(Skladista.stavke_internogDokumenta);
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackgroundImage = global::Skladista.Properties.Resources.Close1;
            this.btnZatvori.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnZatvori.Location = new System.Drawing.Point(758, 92);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(167, 44);
            this.btnZatvori.TabIndex = 76;
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackgroundImage = global::Skladista.Properties.Resources.Floppy1;
            this.btnSpremi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSpremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpremi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSpremi.Location = new System.Drawing.Point(758, 20);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(167, 51);
            this.btnSpremi.TabIndex = 75;
            this.btnSpremi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(21, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 74;
            this.label1.Text = "Izradio:";
            // 
            // datumIzrade
            // 
            this.datumIzrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datumIzrade.Location = new System.Drawing.Point(128, 89);
            this.datumIzrade.Name = "datumIzrade";
            this.datumIzrade.Size = new System.Drawing.Size(189, 26);
            this.datumIzrade.TabIndex = 73;
            // 
            // txtSifraNar
            // 
            this.txtSifraNar.Enabled = false;
            this.txtSifraNar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSifraNar.Location = new System.Drawing.Point(128, 31);
            this.txtSifraNar.Margin = new System.Windows.Forms.Padding(2);
            this.txtSifraNar.Multiline = true;
            this.txtSifraNar.Name = "txtSifraNar";
            this.txtSifraNar.Size = new System.Drawing.Size(275, 37);
            this.txtSifraNar.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(21, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 71;
            this.label3.Text = "Datum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(21, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 70;
            this.label2.Text = "Šifra:";
            // 
            // azurirajIzdatnicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 420);
            this.Controls.Add(this.cmbIzradioSifra);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.cmbIzradio);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnIzmjeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datumIzrade);
            this.Controls.Add(this.txtSifraNar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "azurirajIzdatnicu";
            this.Text = "Ažuriraj izdatnicu";
            this.Load += new System.EventHandler(this.azurirajIzdatnicu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeinternogDokumentaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbIzradioSifra;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox cmbIzradio;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnIzmjeni;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datumIzrade;
        private System.Windows.Forms.TextBox txtSifraNar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource stavkeinternogDokumentaBindingSource;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn id_artikla;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijena_artikla;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddokumentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artiklDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interniDokumentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artikl1DataGridViewTextBoxColumn;
    }
}