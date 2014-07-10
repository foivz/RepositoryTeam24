namespace Skladista
{
    partial class Upravljanje_izdatnicom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Upravljanje_izdatnicom));
            this.dtgPrikaz = new System.Windows.Forms.DataGridView();
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
            this.interniDokumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.lblPretrazi = new System.Windows.Forms.Label();
            this.btnIzvjestaj = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnPrikazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrikaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstainternogdokumentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interniDokumentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgPrikaz
            // 
            this.dtgPrikaz.AutoGenerateColumns = false;
            this.dtgPrikaz.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dtgPrikaz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgPrikaz.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtgPrikaz.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPrikaz.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgPrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPrikaz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddokumentaDataGridViewTextBoxColumn,
            this.sifraDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.vrstaDataGridViewTextBoxColumn,
            this.izradioDataGridViewTextBoxColumn,
            this.zaposlenikDataGridViewTextBoxColumn,
            this.vrstainternogdokumentaDataGridViewTextBoxColumn,
            this.stavkeinternogDokumentaDataGridViewTextBoxColumn});
            this.dtgPrikaz.DataSource = this.interniDokumentBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgPrikaz.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgPrikaz.Location = new System.Drawing.Point(29, 113);
            this.dtgPrikaz.Name = "dtgPrikaz";
            this.dtgPrikaz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPrikaz.Size = new System.Drawing.Size(601, 271);
            this.dtgPrikaz.TabIndex = 0;
            // 
            // iddokumentaDataGridViewTextBoxColumn
            // 
            this.iddokumentaDataGridViewTextBoxColumn.DataPropertyName = "id_dokumenta";
            this.iddokumentaDataGridViewTextBoxColumn.HeaderText = "Id dokumenta";
            this.iddokumentaDataGridViewTextBoxColumn.Name = "iddokumentaDataGridViewTextBoxColumn";
            // 
            // sifraDataGridViewTextBoxColumn
            // 
            this.sifraDataGridViewTextBoxColumn.DataPropertyName = "sifra";
            this.sifraDataGridViewTextBoxColumn.HeaderText = "Šifra";
            this.sifraDataGridViewTextBoxColumn.Name = "sifraDataGridViewTextBoxColumn";
            this.sifraDataGridViewTextBoxColumn.Width = 120;
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
            this.vrstaDataGridViewTextBoxColumn.HeaderText = "Vrsta";
            this.vrstaDataGridViewTextBoxColumn.Name = "vrstaDataGridViewTextBoxColumn";
            this.vrstaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vrstaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.vrstaDataGridViewTextBoxColumn.ValueMember = "sifra";
            this.vrstaDataGridViewTextBoxColumn.Width = 120;
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
            // interniDokumentBindingSource
            // 
            this.interniDokumentBindingSource.DataSource = typeof(Skladista.interniDokument);
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Location = new System.Drawing.Point(29, 62);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(185, 20);
            this.txtPretrazi.TabIndex = 6;
            this.txtPretrazi.TextChanged += new System.EventHandler(this.txtPretrazi_TextChanged);
            // 
            // lblPretrazi
            // 
            this.lblPretrazi.AutoSize = true;
            this.lblPretrazi.BackColor = System.Drawing.Color.Transparent;
            this.lblPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPretrazi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPretrazi.Location = new System.Drawing.Point(25, 24);
            this.lblPretrazi.Name = "lblPretrazi";
            this.lblPretrazi.Size = new System.Drawing.Size(239, 24);
            this.lblPretrazi.TabIndex = 5;
            this.lblPretrazi.Text = "Pretraživanje prema šifri:";
            // 
            // btnIzvjestaj
            // 
            this.btnIzvjestaj.BackgroundImage = global::Skladista.Properties.Resources.oie_transparent_1_;
            this.btnIzvjestaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIzvjestaj.Location = new System.Drawing.Point(671, 314);
            this.btnIzvjestaj.Name = "btnIzvjestaj";
            this.btnIzvjestaj.Size = new System.Drawing.Size(114, 70);
            this.btnIzvjestaj.TabIndex = 7;
            this.btnIzvjestaj.Text = "Izvještaj";
            this.btnIzvjestaj.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIzvjestaj.UseVisualStyleBackColor = true;
            this.btnIzvjestaj.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAzuriraj.BackgroundImage")));
            this.btnAzuriraj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAzuriraj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAzuriraj.Location = new System.Drawing.Point(671, 219);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(114, 70);
            this.btnAzuriraj.TabIndex = 2;
            this.btnAzuriraj.Text = "Ažuriraj izdatnicu";
            this.btnAzuriraj.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrikazi.BackgroundImage")));
            this.btnPrikazi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrikazi.Location = new System.Drawing.Point(671, 113);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(114, 74);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.button1_Click);
            // 
            // Upravljanje_izdatnicom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 407);
            this.Controls.Add(this.btnIzvjestaj);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.lblPretrazi);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.dtgPrikaz);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Upravljanje_izdatnicom";
            this.Text = "Upravljanje izdatnicom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Upravljanje_izdatnicom_FormClosing);
            this.Load += new System.EventHandler(this.Upravljanje_izdatnicom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrikaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstainternogdokumentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interniDokumentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgPrikaz;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.Label lblPretrazi;
        private System.Windows.Forms.BindingSource interniDokumentBindingSource;
        private System.Windows.Forms.BindingSource vrstainternogdokumentaBindingSource;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddokumentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn vrstaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn izradioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposlenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstainternogdokumentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkeinternogDokumentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnIzvjestaj;
    }
}