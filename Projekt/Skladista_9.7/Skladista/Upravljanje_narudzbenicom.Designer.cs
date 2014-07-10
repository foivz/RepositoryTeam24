namespace Skladista
{
    partial class Upravljanje_narudzbenicom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Upravljanje_narudzbenicom));
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.lblPretrazi = new System.Windows.Forms.Label();
            this.dgvPrikaz = new System.Windows.Forms.DataGridView();
            this.sifraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vrstaeksternogdokumentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.izradioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaposlenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poslovnipartnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.poslovniPartnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iddokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poslovniPartnerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaeksternogdokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeeksternogDokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eksterniDokumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.btnIzvjestaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaeksternogdokumentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovniPartnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eksterniDokumentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPretrazi.Location = new System.Drawing.Point(41, 62);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(185, 26);
            this.txtPretrazi.TabIndex = 11;
            this.txtPretrazi.TextChanged += new System.EventHandler(this.txtPretrazi_TextChanged);
            // 
            // lblPretrazi
            // 
            this.lblPretrazi.AutoSize = true;
            this.lblPretrazi.BackColor = System.Drawing.Color.Transparent;
            this.lblPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPretrazi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPretrazi.Location = new System.Drawing.Point(37, 24);
            this.lblPretrazi.Name = "lblPretrazi";
            this.lblPretrazi.Size = new System.Drawing.Size(239, 24);
            this.lblPretrazi.TabIndex = 10;
            this.lblPretrazi.Text = "Pretraživanje prema šifri:";
            // 
            // dgvPrikaz
            // 
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LimeGreen;
            this.dgvPrikaz.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrikaz.AutoGenerateColumns = false;
            this.dgvPrikaz.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvPrikaz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPrikaz.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvPrikaz.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
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
            this.sifraDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.vrstaDataGridViewTextBoxColumn,
            this.izradioDataGridViewTextBoxColumn,
            this.zaposlenikDataGridViewTextBoxColumn,
            this.poslovnipartnerDataGridViewTextBoxColumn,
            this.iddokumentaDataGridViewTextBoxColumn,
            this.poslovniPartnerDataGridViewTextBoxColumn1,
            this.vrstaeksternogdokumentaDataGridViewTextBoxColumn,
            this.stavkeeksternogDokumentaDataGridViewTextBoxColumn});
            this.dgvPrikaz.DataSource = this.eksterniDokumentBindingSource;
            this.dgvPrikaz.Location = new System.Drawing.Point(41, 109);
            this.dgvPrikaz.Name = "dgvPrikaz";
            this.dgvPrikaz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrikaz.Size = new System.Drawing.Size(705, 302);
            this.dgvPrikaz.TabIndex = 9;
            // 
            // sifraDataGridViewTextBoxColumn
            // 
            this.sifraDataGridViewTextBoxColumn.DataPropertyName = "sifra";
            this.sifraDataGridViewTextBoxColumn.HeaderText = "Šifra";
            this.sifraDataGridViewTextBoxColumn.Name = "sifraDataGridViewTextBoxColumn";
            this.sifraDataGridViewTextBoxColumn.Width = 150;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.Width = 150;
            // 
            // vrstaDataGridViewTextBoxColumn
            // 
            this.vrstaDataGridViewTextBoxColumn.DataPropertyName = "vrsta";
            this.vrstaDataGridViewTextBoxColumn.DataSource = this.vrstaeksternogdokumentaBindingSource;
            this.vrstaDataGridViewTextBoxColumn.DisplayMember = "naziv";
            this.vrstaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.vrstaDataGridViewTextBoxColumn.HeaderText = "Vrsta";
            this.vrstaDataGridViewTextBoxColumn.Name = "vrstaDataGridViewTextBoxColumn";
            this.vrstaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vrstaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.vrstaDataGridViewTextBoxColumn.ValueMember = "sifra";
            this.vrstaDataGridViewTextBoxColumn.Width = 120;
            // 
            // vrstaeksternogdokumentaBindingSource
            // 
            this.vrstaeksternogdokumentaBindingSource.DataSource = typeof(Skladista.vrsta_eksternog_dokumenta);
            // 
            // izradioDataGridViewTextBoxColumn
            // 
            this.izradioDataGridViewTextBoxColumn.DataPropertyName = "izradio";
            this.izradioDataGridViewTextBoxColumn.DataSource = this.zaposlenikBindingSource;
            this.izradioDataGridViewTextBoxColumn.DisplayMember = "prezime";
            this.izradioDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.izradioDataGridViewTextBoxColumn.HeaderText = "Izradio";
            this.izradioDataGridViewTextBoxColumn.Name = "izradioDataGridViewTextBoxColumn";
            this.izradioDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.izradioDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.izradioDataGridViewTextBoxColumn.ValueMember = "sifra";
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataSource = typeof(Skladista.Zaposlenik);
            // 
            // zaposlenikDataGridViewTextBoxColumn
            // 
            this.zaposlenikDataGridViewTextBoxColumn.DataPropertyName = "Zaposlenik";
            this.zaposlenikDataGridViewTextBoxColumn.HeaderText = "Zaposlenik";
            this.zaposlenikDataGridViewTextBoxColumn.Name = "zaposlenikDataGridViewTextBoxColumn";
            this.zaposlenikDataGridViewTextBoxColumn.Visible = false;
            // 
            // poslovnipartnerDataGridViewTextBoxColumn
            // 
            this.poslovnipartnerDataGridViewTextBoxColumn.DataPropertyName = "poslovni_partner";
            this.poslovnipartnerDataGridViewTextBoxColumn.DataSource = this.poslovniPartnerBindingSource;
            this.poslovnipartnerDataGridViewTextBoxColumn.DisplayMember = "naziv";
            this.poslovnipartnerDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.poslovnipartnerDataGridViewTextBoxColumn.HeaderText = "Poslovni partner";
            this.poslovnipartnerDataGridViewTextBoxColumn.Name = "poslovnipartnerDataGridViewTextBoxColumn";
            this.poslovnipartnerDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.poslovnipartnerDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.poslovnipartnerDataGridViewTextBoxColumn.ValueMember = "sifra";
            this.poslovnipartnerDataGridViewTextBoxColumn.Width = 140;
            // 
            // poslovniPartnerBindingSource
            // 
            this.poslovniPartnerBindingSource.DataSource = typeof(Skladista.poslovniPartner);
            // 
            // iddokumentaDataGridViewTextBoxColumn
            // 
            this.iddokumentaDataGridViewTextBoxColumn.DataPropertyName = "id_dokumenta";
            this.iddokumentaDataGridViewTextBoxColumn.HeaderText = "id_dokumenta";
            this.iddokumentaDataGridViewTextBoxColumn.Name = "iddokumentaDataGridViewTextBoxColumn";
            this.iddokumentaDataGridViewTextBoxColumn.Visible = false;
            // 
            // poslovniPartnerDataGridViewTextBoxColumn1
            // 
            this.poslovniPartnerDataGridViewTextBoxColumn1.DataPropertyName = "poslovniPartner";
            this.poslovniPartnerDataGridViewTextBoxColumn1.HeaderText = "poslovniPartner";
            this.poslovniPartnerDataGridViewTextBoxColumn1.Name = "poslovniPartnerDataGridViewTextBoxColumn1";
            this.poslovniPartnerDataGridViewTextBoxColumn1.Visible = false;
            // 
            // vrstaeksternogdokumentaDataGridViewTextBoxColumn
            // 
            this.vrstaeksternogdokumentaDataGridViewTextBoxColumn.DataPropertyName = "vrsta_eksternog_dokumenta";
            this.vrstaeksternogdokumentaDataGridViewTextBoxColumn.HeaderText = "vrsta_eksternog_dokumenta";
            this.vrstaeksternogdokumentaDataGridViewTextBoxColumn.Name = "vrstaeksternogdokumentaDataGridViewTextBoxColumn";
            this.vrstaeksternogdokumentaDataGridViewTextBoxColumn.Visible = false;
            // 
            // stavkeeksternogDokumentaDataGridViewTextBoxColumn
            // 
            this.stavkeeksternogDokumentaDataGridViewTextBoxColumn.DataPropertyName = "stavke_eksternogDokumenta";
            this.stavkeeksternogDokumentaDataGridViewTextBoxColumn.HeaderText = "stavke_eksternogDokumenta";
            this.stavkeeksternogDokumentaDataGridViewTextBoxColumn.Name = "stavkeeksternogDokumentaDataGridViewTextBoxColumn";
            this.stavkeeksternogDokumentaDataGridViewTextBoxColumn.Visible = false;
            // 
            // eksterniDokumentBindingSource
            // 
            this.eksterniDokumentBindingSource.DataSource = typeof(Skladista.eksterniDokument);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.BackgroundImage = global::Skladista.Properties.Resources.Up;
            this.btnAzuriraj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAzuriraj.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAzuriraj.Location = new System.Drawing.Point(776, 215);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(97, 88);
            this.btnAzuriraj.TabIndex = 8;
            this.btnAzuriraj.Text = "Ažuriraj narudžbenicu";
            this.btnAzuriraj.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.BackgroundImage = global::Skladista.Properties.Resources.Add;
            this.btnKreiraj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKreiraj.Location = new System.Drawing.Point(776, 109);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(97, 84);
            this.btnKreiraj.TabIndex = 7;
            this.btnKreiraj.Text = "Kreiraj Narudžbenicu";
            this.btnKreiraj.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIzvjestaj
            // 
            this.btnIzvjestaj.BackgroundImage = global::Skladista.Properties.Resources.oie_transparent_1_;
            this.btnIzvjestaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIzvjestaj.Location = new System.Drawing.Point(776, 323);
            this.btnIzvjestaj.Name = "btnIzvjestaj";
            this.btnIzvjestaj.Size = new System.Drawing.Size(97, 88);
            this.btnIzvjestaj.TabIndex = 12;
            this.btnIzvjestaj.Text = "Izvještaj";
            this.btnIzvjestaj.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIzvjestaj.UseVisualStyleBackColor = true;
            this.btnIzvjestaj.Click += new System.EventHandler(this.button3_Click);
            // 
            // Upravljanje_narudzbenicom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(932, 439);
            this.Controls.Add(this.btnIzvjestaj);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.lblPretrazi);
            this.Controls.Add(this.dgvPrikaz);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnKreiraj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Upravljanje_narudzbenicom";
            this.Text = "Upravljanje narudžbenicom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Upravljanje_otpremnicom_FormClosing);
            this.Load += new System.EventHandler(this.Upravljanje_narudzbenicom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaeksternogdokumentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovniPartnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eksterniDokumentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.Label lblPretrazi;
        private System.Windows.Forms.DataGridView dgvPrikaz;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.BindingSource poslovniPartnerBindingSource;
        private System.Windows.Forms.BindingSource eksterniDokumentBindingSource;
        private System.Windows.Forms.BindingSource vrstaeksternogdokumentaBindingSource;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private System.Windows.Forms.Button btnIzvjestaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn vrstaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn izradioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposlenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn poslovnipartnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddokumentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poslovniPartnerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstaeksternogdokumentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkeeksternogDokumentaDataGridViewTextBoxColumn;
    }
}