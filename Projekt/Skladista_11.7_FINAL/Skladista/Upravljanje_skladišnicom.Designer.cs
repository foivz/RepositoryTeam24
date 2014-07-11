namespace Skladista
{
    partial class Upravljanje_skladišnicom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Upravljanje_skladišnicom));
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.brnAzuriraj = new System.Windows.Forms.Button();
            this.dgvPrikazSkladisnica = new System.Windows.Forms.DataGridView();
            this.iddokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vrstainternogdokumentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.izradioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaposlenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstainternogdokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeinternogDokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.interniDokumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPretrazi = new System.Windows.Forms.Label();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.btnIzvjestaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazSkladisnica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstainternogdokumentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interniDokumentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.BackgroundImage = global::Skladista.Properties.Resources.Add;
            this.btnKreiraj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKreiraj.Location = new System.Drawing.Point(741, 120);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(134, 78);
            this.btnKreiraj.TabIndex = 0;
            this.btnKreiraj.Text = "Kreiraj skladišnicu";
            this.btnKreiraj.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // brnAzuriraj
            // 
            this.brnAzuriraj.BackgroundImage = global::Skladista.Properties.Resources.Up;
            this.brnAzuriraj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.brnAzuriraj.Location = new System.Drawing.Point(741, 232);
            this.brnAzuriraj.Name = "brnAzuriraj";
            this.brnAzuriraj.Size = new System.Drawing.Size(134, 78);
            this.brnAzuriraj.TabIndex = 1;
            this.brnAzuriraj.Text = "Ažuriraj skladišnicu";
            this.brnAzuriraj.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.brnAzuriraj.UseVisualStyleBackColor = true;
            this.brnAzuriraj.Click += new System.EventHandler(this.brnAzuriraj_Click);
            // 
            // dgvPrikazSkladisnica
            // 
            this.dgvPrikazSkladisnica.AutoGenerateColumns = false;
            this.dgvPrikazSkladisnica.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvPrikazSkladisnica.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPrikazSkladisnica.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvPrikazSkladisnica.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrikazSkladisnica.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrikazSkladisnica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikazSkladisnica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddokumentaDataGridViewTextBoxColumn,
            this.sifraDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.vrstaDataGridViewTextBoxColumn,
            this.izradioDataGridViewTextBoxColumn,
            this.zaposlenikDataGridViewTextBoxColumn,
            this.vrstainternogdokumentaDataGridViewTextBoxColumn,
            this.stavkeinternogDokumentaDataGridViewTextBoxColumn,
            this.dataGridViewComboBoxColumn1});
            this.dgvPrikazSkladisnica.DataSource = this.interniDokumentBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrikazSkladisnica.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrikazSkladisnica.Location = new System.Drawing.Point(42, 120);
            this.dgvPrikazSkladisnica.Name = "dgvPrikazSkladisnica";
            this.dgvPrikazSkladisnica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrikazSkladisnica.Size = new System.Drawing.Size(678, 320);
            this.dgvPrikazSkladisnica.TabIndex = 2;
            // 
            // iddokumentaDataGridViewTextBoxColumn
            // 
            this.iddokumentaDataGridViewTextBoxColumn.DataPropertyName = "id_dokumenta";
            this.iddokumentaDataGridViewTextBoxColumn.HeaderText = "id_dokumenta";
            this.iddokumentaDataGridViewTextBoxColumn.Name = "iddokumentaDataGridViewTextBoxColumn";
            this.iddokumentaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iddokumentaDataGridViewTextBoxColumn.Visible = false;
            // 
            // sifraDataGridViewTextBoxColumn
            // 
            this.sifraDataGridViewTextBoxColumn.DataPropertyName = "sifra";
            this.sifraDataGridViewTextBoxColumn.HeaderText = "Šifra skladišnice";
            this.sifraDataGridViewTextBoxColumn.Name = "sifraDataGridViewTextBoxColumn";
            this.sifraDataGridViewTextBoxColumn.Width = 170;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // vrstaDataGridViewTextBoxColumn
            // 
            this.vrstaDataGridViewTextBoxColumn.DataPropertyName = "vrsta";
            this.vrstaDataGridViewTextBoxColumn.DataSource = this.vrstainternogdokumentaBindingSource;
            this.vrstaDataGridViewTextBoxColumn.DisplayMember = "naziv";
            this.vrstaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.vrstaDataGridViewTextBoxColumn.HeaderText = "Vrsta dokumenta";
            this.vrstaDataGridViewTextBoxColumn.Name = "vrstaDataGridViewTextBoxColumn";
            this.vrstaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vrstaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.vrstaDataGridViewTextBoxColumn.ValueMember = "sifra";
            this.vrstaDataGridViewTextBoxColumn.Width = 150;
            // 
            // vrstainternogdokumentaBindingSource
            // 
            this.vrstainternogdokumentaBindingSource.DataSource = typeof(Skladista.vrsta_internog_dokumenta);
            // 
            // izradioDataGridViewTextBoxColumn
            // 
            this.izradioDataGridViewTextBoxColumn.DataPropertyName = "izradio";
            this.izradioDataGridViewTextBoxColumn.DataSource = this.zaposlenikBindingSource;
            this.izradioDataGridViewTextBoxColumn.DisplayMember = "prezime";
            this.izradioDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.izradioDataGridViewTextBoxColumn.HeaderText = "Prezime";
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
            this.zaposlenikDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.zaposlenikDataGridViewTextBoxColumn.Visible = false;
            // 
            // vrstainternogdokumentaDataGridViewTextBoxColumn
            // 
            this.vrstainternogdokumentaDataGridViewTextBoxColumn.DataPropertyName = "vrsta_internog_dokumenta";
            this.vrstainternogdokumentaDataGridViewTextBoxColumn.HeaderText = "vrsta_internog_dokumenta";
            this.vrstainternogdokumentaDataGridViewTextBoxColumn.Name = "vrstainternogdokumentaDataGridViewTextBoxColumn";
            this.vrstainternogdokumentaDataGridViewTextBoxColumn.Visible = false;
            // 
            // stavkeinternogDokumentaDataGridViewTextBoxColumn
            // 
            this.stavkeinternogDokumentaDataGridViewTextBoxColumn.DataPropertyName = "stavke_internogDokumenta";
            this.stavkeinternogDokumentaDataGridViewTextBoxColumn.HeaderText = "stavke_internogDokumenta";
            this.stavkeinternogDokumentaDataGridViewTextBoxColumn.Name = "stavkeinternogDokumentaDataGridViewTextBoxColumn";
            this.stavkeinternogDokumentaDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DataPropertyName = "izradio";
            this.dataGridViewComboBoxColumn1.DataSource = this.zaposlenikBindingSource;
            this.dataGridViewComboBoxColumn1.DisplayMember = "ime";
            this.dataGridViewComboBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn1.HeaderText = "Ime";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn1.ValueMember = "sifra";
            // 
            // interniDokumentBindingSource
            // 
            this.interniDokumentBindingSource.DataSource = typeof(Skladista.interniDokument);
            // 
            // lblPretrazi
            // 
            this.lblPretrazi.AutoSize = true;
            this.lblPretrazi.BackColor = System.Drawing.Color.Transparent;
            this.lblPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPretrazi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPretrazi.Location = new System.Drawing.Point(38, 34);
            this.lblPretrazi.Name = "lblPretrazi";
            this.lblPretrazi.Size = new System.Drawing.Size(239, 24);
            this.lblPretrazi.TabIndex = 3;
            this.lblPretrazi.Text = "Pretraživanje prema šifri:";
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPretrazi.Location = new System.Drawing.Point(42, 72);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(185, 26);
            this.txtPretrazi.TabIndex = 4;
            this.txtPretrazi.TextChanged += new System.EventHandler(this.txtPretrazi_TextChanged);
            // 
            // btnIzvjestaj
            // 
            this.btnIzvjestaj.BackgroundImage = global::Skladista.Properties.Resources.oie_transparent_1_;
            this.btnIzvjestaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIzvjestaj.Location = new System.Drawing.Point(741, 343);
            this.btnIzvjestaj.Name = "btnIzvjestaj";
            this.btnIzvjestaj.Size = new System.Drawing.Size(134, 69);
            this.btnIzvjestaj.TabIndex = 5;
            this.btnIzvjestaj.Text = "Izvještaj";
            this.btnIzvjestaj.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIzvjestaj.UseVisualStyleBackColor = true;
            this.btnIzvjestaj.Click += new System.EventHandler(this.btnIzvjestaj_Click);
            // 
            // Upravljanje_skladišnicom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(932, 452);
            this.Controls.Add(this.btnIzvjestaj);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.lblPretrazi);
            this.Controls.Add(this.dgvPrikazSkladisnica);
            this.Controls.Add(this.brnAzuriraj);
            this.Controls.Add(this.btnKreiraj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Upravljanje_skladišnicom";
            this.Text = "Upravljanje skladišnicom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Upravljanje_skladišnicom_FormClosing);
            this.Load += new System.EventHandler(this.Upravljanje_skladišnicom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazSkladisnica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstainternogdokumentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interniDokumentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.Button brnAzuriraj;
        private System.Windows.Forms.DataGridView dgvPrikazSkladisnica;
        private System.Windows.Forms.BindingSource interniDokumentBindingSource;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private System.Windows.Forms.BindingSource vrstainternogdokumentaBindingSource;
        private System.Windows.Forms.Label lblPretrazi;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddokumentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn vrstaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn izradioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposlenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstainternogdokumentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkeinternogDokumentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.Button btnIzvjestaj;
    }
}