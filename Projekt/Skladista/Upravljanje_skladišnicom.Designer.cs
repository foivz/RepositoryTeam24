﻿namespace Skladista
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstainternogdokumentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interniDokumentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Skladista.Properties.Resources.Add;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(741, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 78);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kreiraj skladišnicu";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Skladista.Properties.Resources.Up;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Location = new System.Drawing.Point(741, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 78);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ažuriraj skladišnicu";
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
            this.izradioDataGridViewTextBoxColumn,
            this.zaposlenikDataGridViewTextBoxColumn,
            this.vrstainternogdokumentaDataGridViewTextBoxColumn,
            this.stavkeinternogDokumentaDataGridViewTextBoxColumn,
            this.dataGridViewComboBoxColumn1});
            this.dataGridView1.DataSource = this.interniDokumentBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(42, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(668, 224);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(38, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pretraživanje prema šifri:";
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(741, 371);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 69);
            this.button3.TabIndex = 5;
            this.button3.Text = "Izvještaj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Upravljanje_skladišnicom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(932, 452);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Upravljanje_skladišnicom";
            this.Text = "Upravljanje skladišnicom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Upravljanje_skladišnicom_FormClosing);
            this.Load += new System.EventHandler(this.Upravljanje_skladišnicom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstainternogdokumentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interniDokumentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource interniDokumentBindingSource;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private System.Windows.Forms.BindingSource vrstainternogdokumentaBindingSource;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button button3;
    }
}