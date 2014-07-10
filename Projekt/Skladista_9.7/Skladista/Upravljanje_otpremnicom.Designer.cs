namespace Skladista
{
    partial class Upravljanje_otpremnicom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Upravljanje_otpremnicom));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iddokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poslovnipartnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.poslovniPartnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.izradioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poslovniPartnerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaeksternogdokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeeksternogDokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eksterniDokumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovniPartnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eksterniDokumentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Skladista.Properties.Resources.Add1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(730, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 72);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kreiraj Otpremnicu";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Skladista.Properties.Resources.Up;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Location = new System.Drawing.Point(730, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 71);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ažuriraj otpremnicu";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddokumentaDataGridViewTextBoxColumn,
            this.sifraDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.vrstaDataGridViewTextBoxColumn,
            this.poslovnipartnerDataGridViewTextBoxColumn,
            this.izradioDataGridViewTextBoxColumn,
            this.poslovniPartnerDataGridViewTextBoxColumn1,
            this.vrstaeksternogdokumentaDataGridViewTextBoxColumn,
            this.zaposlenikDataGridViewTextBoxColumn,
            this.stavkeeksternogDokumentaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eksterniDokumentBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(38, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(667, 288);
            this.dataGridView1.TabIndex = 2;
            // 
            // iddokumentaDataGridViewTextBoxColumn
            // 
            this.iddokumentaDataGridViewTextBoxColumn.DataPropertyName = "id_dokumenta";
            this.iddokumentaDataGridViewTextBoxColumn.HeaderText = "id_dokumenta";
            this.iddokumentaDataGridViewTextBoxColumn.Name = "iddokumentaDataGridViewTextBoxColumn";
            // 
            // sifraDataGridViewTextBoxColumn
            // 
            this.sifraDataGridViewTextBoxColumn.DataPropertyName = "sifra";
            this.sifraDataGridViewTextBoxColumn.HeaderText = "sifra";
            this.sifraDataGridViewTextBoxColumn.Name = "sifraDataGridViewTextBoxColumn";
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // vrstaDataGridViewTextBoxColumn
            // 
            this.vrstaDataGridViewTextBoxColumn.DataPropertyName = "vrsta";
            this.vrstaDataGridViewTextBoxColumn.HeaderText = "vrsta";
            this.vrstaDataGridViewTextBoxColumn.Name = "vrstaDataGridViewTextBoxColumn";
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
            // 
            // poslovniPartnerBindingSource
            // 
            this.poslovniPartnerBindingSource.DataSource = typeof(Skladista.poslovniPartner);
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
            // zaposlenikDataGridViewTextBoxColumn
            // 
            this.zaposlenikDataGridViewTextBoxColumn.DataPropertyName = "Zaposlenik";
            this.zaposlenikDataGridViewTextBoxColumn.HeaderText = "Zaposlenik";
            this.zaposlenikDataGridViewTextBoxColumn.Name = "zaposlenikDataGridViewTextBoxColumn";
            this.zaposlenikDataGridViewTextBoxColumn.Visible = false;
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
            // txtPretrazi
            // 
            this.txtPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPretrazi.Location = new System.Drawing.Point(38, 70);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(185, 26);
            this.txtPretrazi.TabIndex = 6;
            this.txtPretrazi.TextChanged += new System.EventHandler(this.txtPretrazi_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pretraživanje prema šifri:";
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Skladista.Properties.Resources.oie_transparent_1_;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Location = new System.Drawing.Point(730, 323);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 71);
            this.button3.TabIndex = 7;
            this.button3.Text = "Izvještaj";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Upravljanje_otpremnicom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(890, 424);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Upravljanje_otpremnicom";
            this.Text = "Upravljanje otpremnicom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Upravljanje_otpremnicom_FormClosing);
            this.Load += new System.EventHandler(this.Upravljanje_otpremnicom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovniPartnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eksterniDokumentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource eksterniDokumentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddokumentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn poslovnipartnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource poslovniPartnerBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn izradioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poslovniPartnerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstaeksternogdokumentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposlenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkeeksternogDokumentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
    }
}