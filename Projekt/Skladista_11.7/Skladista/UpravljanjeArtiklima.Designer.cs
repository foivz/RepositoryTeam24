namespace Skladista
{
    partial class UpravljanjeArtiklima
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpravljanjeArtiklima));
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnKreitaj = new System.Windows.Forms.Button();
            this.txtPretraziNaziv = new System.Windows.Forms.TextBox();
            this.lblPretrazi = new System.Windows.Forms.Label();
            this.sifraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nabavnacijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimalnakolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pododjelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pododjelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pododjel1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeeksternogDokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeinternogDokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeinternogDokumenta1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pododjelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.AutoGenerateColumns = false;
            this.dgvArtikli.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvArtikli.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvArtikli.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvArtikli.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArtikli.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sifraDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.nabavnacijenaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.minimalnakolicinaDataGridViewTextBoxColumn,
            this.pododjelDataGridViewTextBoxColumn,
            this.pododjel1DataGridViewTextBoxColumn,
            this.stavkeeksternogDokumentaDataGridViewTextBoxColumn,
            this.stavkeinternogDokumentaDataGridViewTextBoxColumn,
            this.stavkeinternogDokumenta1DataGridViewTextBoxColumn});
            this.dgvArtikli.DataSource = this.artiklBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArtikli.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArtikli.Location = new System.Drawing.Point(31, 114);
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvArtikli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArtikli.Size = new System.Drawing.Size(815, 276);
            this.dgvArtikli.TabIndex = 3;
            this.dgvArtikli.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.BackgroundImage = global::Skladista.Properties.Resources.Up;
            this.btnAzuriraj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAzuriraj.Location = new System.Drawing.Point(864, 210);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(97, 73);
            this.btnAzuriraj.TabIndex = 5;
            this.btnAzuriraj.Text = "Ažuriraj artikl";
            this.btnAzuriraj.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnKreitaj
            // 
            this.btnKreitaj.BackgroundImage = global::Skladista.Properties.Resources.Add;
            this.btnKreitaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKreitaj.Location = new System.Drawing.Point(864, 114);
            this.btnKreitaj.Name = "btnKreitaj";
            this.btnKreitaj.Size = new System.Drawing.Size(97, 78);
            this.btnKreitaj.TabIndex = 4;
            this.btnKreitaj.Text = "Kreiraj Artikl";
            this.btnKreitaj.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKreitaj.UseVisualStyleBackColor = true;
            this.btnKreitaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPretraziNaziv
            // 
            this.txtPretraziNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPretraziNaziv.Location = new System.Drawing.Point(31, 49);
            this.txtPretraziNaziv.Name = "txtPretraziNaziv";
            this.txtPretraziNaziv.Size = new System.Drawing.Size(185, 26);
            this.txtPretraziNaziv.TabIndex = 7;
            this.txtPretraziNaziv.TextChanged += new System.EventHandler(this.txtPretrazi_TextChanged);
            // 
            // lblPretrazi
            // 
            this.lblPretrazi.AutoSize = true;
            this.lblPretrazi.BackColor = System.Drawing.Color.Transparent;
            this.lblPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPretrazi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPretrazi.Location = new System.Drawing.Point(27, 9);
            this.lblPretrazi.Name = "lblPretrazi";
            this.lblPretrazi.Size = new System.Drawing.Size(267, 24);
            this.lblPretrazi.TabIndex = 8;
            this.lblPretrazi.Text = "Pretraživanje prema nazivu:";
            this.lblPretrazi.Click += new System.EventHandler(this.label2_Click);
            // 
            // sifraDataGridViewTextBoxColumn
            // 
            this.sifraDataGridViewTextBoxColumn.DataPropertyName = "sifra";
            this.sifraDataGridViewTextBoxColumn.HeaderText = "Šifra";
            this.sifraDataGridViewTextBoxColumn.Name = "sifraDataGridViewTextBoxColumn";
            this.sifraDataGridViewTextBoxColumn.Width = 120;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv artikla";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // nabavnacijenaDataGridViewTextBoxColumn
            // 
            this.nabavnacijenaDataGridViewTextBoxColumn.DataPropertyName = "nabavna_cijena";
            this.nabavnacijenaDataGridViewTextBoxColumn.HeaderText = "Nabavna cijena";
            this.nabavnacijenaDataGridViewTextBoxColumn.Name = "nabavnacijenaDataGridViewTextBoxColumn";
            this.nabavnacijenaDataGridViewTextBoxColumn.Width = 120;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina na skladištu";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.Width = 160;
            // 
            // minimalnakolicinaDataGridViewTextBoxColumn
            // 
            this.minimalnakolicinaDataGridViewTextBoxColumn.DataPropertyName = "minimalna_kolicina";
            this.minimalnakolicinaDataGridViewTextBoxColumn.HeaderText = "Minimalna potrebna količina";
            this.minimalnakolicinaDataGridViewTextBoxColumn.Name = "minimalnakolicinaDataGridViewTextBoxColumn";
            this.minimalnakolicinaDataGridViewTextBoxColumn.Width = 170;
            // 
            // pododjelDataGridViewTextBoxColumn
            // 
            this.pododjelDataGridViewTextBoxColumn.DataPropertyName = "pododjel";
            this.pododjelDataGridViewTextBoxColumn.DataSource = this.pododjelBindingSource;
            this.pododjelDataGridViewTextBoxColumn.DisplayMember = "naziv";
            this.pododjelDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.pododjelDataGridViewTextBoxColumn.HeaderText = "Odjel";
            this.pododjelDataGridViewTextBoxColumn.Name = "pododjelDataGridViewTextBoxColumn";
            this.pododjelDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pododjelDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pododjelDataGridViewTextBoxColumn.ValueMember = "sifra";
            // 
            // pododjelBindingSource
            // 
            this.pododjelBindingSource.DataSource = typeof(Skladista.Pododjel);
            // 
            // pododjel1DataGridViewTextBoxColumn
            // 
            this.pododjel1DataGridViewTextBoxColumn.DataPropertyName = "Pododjel1";
            this.pododjel1DataGridViewTextBoxColumn.HeaderText = "Pododjel1";
            this.pododjel1DataGridViewTextBoxColumn.Name = "pododjel1DataGridViewTextBoxColumn";
            this.pododjel1DataGridViewTextBoxColumn.Visible = false;
            // 
            // stavkeeksternogDokumentaDataGridViewTextBoxColumn
            // 
            this.stavkeeksternogDokumentaDataGridViewTextBoxColumn.DataPropertyName = "stavke_eksternogDokumenta";
            this.stavkeeksternogDokumentaDataGridViewTextBoxColumn.HeaderText = "stavke_eksternogDokumenta";
            this.stavkeeksternogDokumentaDataGridViewTextBoxColumn.Name = "stavkeeksternogDokumentaDataGridViewTextBoxColumn";
            this.stavkeeksternogDokumentaDataGridViewTextBoxColumn.Visible = false;
            // 
            // stavkeinternogDokumentaDataGridViewTextBoxColumn
            // 
            this.stavkeinternogDokumentaDataGridViewTextBoxColumn.DataPropertyName = "stavke_internogDokumenta";
            this.stavkeinternogDokumentaDataGridViewTextBoxColumn.HeaderText = "stavke_internogDokumenta";
            this.stavkeinternogDokumentaDataGridViewTextBoxColumn.Name = "stavkeinternogDokumentaDataGridViewTextBoxColumn";
            this.stavkeinternogDokumentaDataGridViewTextBoxColumn.Visible = false;
            // 
            // stavkeinternogDokumenta1DataGridViewTextBoxColumn
            // 
            this.stavkeinternogDokumenta1DataGridViewTextBoxColumn.DataPropertyName = "stavke_internogDokumenta1";
            this.stavkeinternogDokumenta1DataGridViewTextBoxColumn.HeaderText = "stavke_internogDokumenta1";
            this.stavkeinternogDokumenta1DataGridViewTextBoxColumn.Name = "stavkeinternogDokumenta1DataGridViewTextBoxColumn";
            this.stavkeinternogDokumenta1DataGridViewTextBoxColumn.Visible = false;
            // 
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataSource = typeof(Skladista.Artikl);
            // 
            // UpravljanjeArtiklima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1002, 442);
            this.Controls.Add(this.lblPretrazi);
            this.Controls.Add(this.txtPretraziNaziv);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnKreitaj);
            this.Controls.Add(this.dgvArtikli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpravljanjeArtiklima";
            this.Text = "Upravljanje artiklima";
            this.Load += new System.EventHandler(this.UpravljanjeArtiklima_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pododjelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnKreitaj;
        private System.Windows.Forms.TextBox txtPretraziNaziv;
        private System.Windows.Forms.Label lblPretrazi;
        private System.Windows.Forms.BindingSource pododjelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nabavnacijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimalnakolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn pododjelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pododjel1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkeeksternogDokumentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkeinternogDokumentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn povijestCijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkeinternogDokumenta1DataGridViewTextBoxColumn;

    }
}