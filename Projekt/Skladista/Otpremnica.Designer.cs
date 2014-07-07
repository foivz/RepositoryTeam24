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
            System.Windows.Forms.Label sifraLabel;
            System.Windows.Forms.Label nazivLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Otpremnica));
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtSifraNar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pISkladiste2DataSet = new Skladista.PISkladiste2DataSet();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artiklTableAdapter = new Skladista.PISkladiste2DataSetTableAdapters.ArtiklTableAdapter();
            this.tableAdapterManager = new Skladista.PISkladiste2DataSetTableAdapters.TableAdapterManager();
            this.sifraComboBox = new System.Windows.Forms.ComboBox();
            this.nazivComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.poslovniPartnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poslovniPartnerTableAdapter = new Skladista.PISkladiste2DataSetTableAdapters.poslovniPartnerTableAdapter();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaposlenikTableAdapter = new Skladista.PISkladiste2DataSetTableAdapters.ZaposlenikTableAdapter();
            this.imeComboBox = new System.Windows.Forms.ComboBox();
            this.prezimeComboBox = new System.Windows.Forms.ComboBox();
            this.nabavna_cijenaComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_artikla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavke_eksternogDokumentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nazivComboBox1 = new System.Windows.Forms.ComboBox();
            this.adresaTextBox = new System.Windows.Forms.TextBox();
            sifraLabel = new System.Windows.Forms.Label();
            nazivLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pISkladiste2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovniPartnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavke_eksternogDokumentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sifraLabel
            // 
            sifraLabel.AutoSize = true;
            sifraLabel.BackColor = System.Drawing.Color.Transparent;
            sifraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            sifraLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            sifraLabel.Location = new System.Drawing.Point(66, 261);
            sifraLabel.Name = "sifraLabel";
            sifraLabel.Size = new System.Drawing.Size(47, 17);
            sifraLabel.TabIndex = 86;
            sifraLabel.Text = "Šifra:";
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.BackColor = System.Drawing.Color.Transparent;
            nazivLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            nazivLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            nazivLabel.Location = new System.Drawing.Point(60, 290);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(53, 17);
            nazivLabel.TabIndex = 87;
            nazivLabel.Text = "Naziv:";
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Skladista.Properties.Resources.Close;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Location = new System.Drawing.Point(630, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 42);
            this.button3.TabIndex = 85;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(320, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 84;
            this.label6.Text = "Količina:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(269, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 83;
            this.label5.Text = "Jedinična cijena:";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Skladista.Properties.Resources.Floppy;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Location = new System.Drawing.Point(630, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 40);
            this.button2.TabIndex = 82;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Skladista.Properties.Resources.Add;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(630, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 46);
            this.button1.TabIndex = 81;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.Location = new System.Drawing.Point(420, 250);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(153, 23);
            this.textBox3.TabIndex = 79;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(34, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 78;
            this.label1.Text = "Poslovni partner:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Location = new System.Drawing.Point(141, 96);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(189, 26);
            this.dateTimePicker1.TabIndex = 77;
            // 
            // txtSifraNar
            // 
            this.txtSifraNar.Enabled = false;
            this.txtSifraNar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSifraNar.Location = new System.Drawing.Point(141, 40);
            this.txtSifraNar.Margin = new System.Windows.Forms.Padding(2);
            this.txtSifraNar.Multiline = true;
            this.txtSifraNar.Name = "txtSifraNar";
            this.txtSifraNar.ReadOnly = true;
            this.txtSifraNar.Size = new System.Drawing.Size(275, 35);
            this.txtSifraNar.TabIndex = 76;
            this.txtSifraNar.TextChanged += new System.EventHandler(this.txtSifraNar_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(34, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 75;
            this.label3.Text = "Datum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(34, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 74;
            this.label2.Text = "Šifra:";
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
            // sifraComboBox
            // 
            this.sifraComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artiklBindingSource, "sifra", true));
            this.sifraComboBox.DataSource = this.artiklBindingSource;
            this.sifraComboBox.DisplayMember = "sifra";
            this.sifraComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sifraComboBox.FormattingEnabled = true;
            this.sifraComboBox.Location = new System.Drawing.Point(129, 258);
            this.sifraComboBox.Name = "sifraComboBox";
            this.sifraComboBox.Size = new System.Drawing.Size(121, 24);
            this.sifraComboBox.TabIndex = 87;
            this.sifraComboBox.ValueMember = "sifra";
            // 
            // nazivComboBox
            // 
            this.nazivComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artiklBindingSource, "naziv", true));
            this.nazivComboBox.DataSource = this.artiklBindingSource;
            this.nazivComboBox.DisplayMember = "naziv";
            this.nazivComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazivComboBox.FormattingEnabled = true;
            this.nazivComboBox.Location = new System.Drawing.Point(129, 287);
            this.nazivComboBox.Name = "nazivComboBox";
            this.nazivComboBox.Size = new System.Drawing.Size(121, 24);
            this.nazivComboBox.TabIndex = 88;
            this.nazivComboBox.ValueMember = "sifra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(34, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 89;
            this.label4.Text = "Izradio:";
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
            // imeComboBox
            // 
            this.imeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "ime", true));
            this.imeComboBox.DataSource = this.zaposlenikBindingSource;
            this.imeComboBox.DisplayMember = "prezime";
            this.imeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imeComboBox.FormattingEnabled = true;
            this.imeComboBox.Location = new System.Drawing.Point(129, 182);
            this.imeComboBox.Name = "imeComboBox";
            this.imeComboBox.Size = new System.Drawing.Size(121, 28);
            this.imeComboBox.TabIndex = 91;
            this.imeComboBox.ValueMember = "sifra";
            // 
            // prezimeComboBox
            // 
            this.prezimeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "prezime", true));
            this.prezimeComboBox.DataSource = this.zaposlenikBindingSource;
            this.prezimeComboBox.DisplayMember = "ime";
            this.prezimeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prezimeComboBox.FormattingEnabled = true;
            this.prezimeComboBox.Location = new System.Drawing.Point(263, 182);
            this.prezimeComboBox.Name = "prezimeComboBox";
            this.prezimeComboBox.Size = new System.Drawing.Size(153, 28);
            this.prezimeComboBox.TabIndex = 92;
            this.prezimeComboBox.ValueMember = "sifra";
            // 
            // nabavna_cijenaComboBox
            // 
            this.nabavna_cijenaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artiklBindingSource, "nabavna_cijena", true));
            this.nabavna_cijenaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nabavna_cijenaComboBox.FormattingEnabled = true;
            this.nabavna_cijenaComboBox.Location = new System.Drawing.Point(420, 286);
            this.nabavna_cijenaComboBox.Name = "nabavna_cijenaComboBox";
            this.nabavna_cijenaComboBox.Size = new System.Drawing.Size(153, 24);
            this.nabavna_cijenaComboBox.TabIndex = 93;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_artikla,
            this.naziv,
            this.kolicina,
            this.cijena,
            this.suma});
            this.dataGridView1.Location = new System.Drawing.Point(50, 337);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(536, 148);
            this.dataGridView1.TabIndex = 94;
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
            // nazivComboBox1
            // 
            this.nazivComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.poslovniPartnerBindingSource, "naziv", true));
            this.nazivComboBox1.DataSource = this.poslovniPartnerBindingSource;
            this.nazivComboBox1.DisplayMember = "naziv";
            this.nazivComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazivComboBox1.FormattingEnabled = true;
            this.nazivComboBox1.Location = new System.Drawing.Point(230, 142);
            this.nazivComboBox1.Name = "nazivComboBox1";
            this.nazivComboBox1.Size = new System.Drawing.Size(186, 28);
            this.nazivComboBox1.TabIndex = 95;
            this.nazivComboBox1.ValueMember = "sifra";
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.poslovniPartnerBindingSource, "adresa", true));
            this.adresaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adresaTextBox.Location = new System.Drawing.Point(422, 144);
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.Size = new System.Drawing.Size(151, 26);
            this.adresaTextBox.TabIndex = 96;
            // 
            // Otpremnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 508);
            this.Controls.Add(this.adresaTextBox);
            this.Controls.Add(this.nazivComboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.nabavna_cijenaComboBox);
            this.Controls.Add(this.prezimeComboBox);
            this.Controls.Add(this.imeComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.nazivComboBox);
            this.Controls.Add(sifraLabel);
            this.Controls.Add(this.sifraComboBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtSifraNar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Otpremnica";
            this.Text = "Kreiranje otpremnice";
            this.Load += new System.EventHandler(this.Otpremnica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pISkladiste2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovniPartnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavke_eksternogDokumentaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtSifraNar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private PISkladiste2DataSet pISkladiste2DataSet;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private PISkladiste2DataSetTableAdapters.ArtiklTableAdapter artiklTableAdapter;
        private PISkladiste2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox sifraComboBox;
        private System.Windows.Forms.ComboBox nazivComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource poslovniPartnerBindingSource;
        private PISkladiste2DataSetTableAdapters.poslovniPartnerTableAdapter poslovniPartnerTableAdapter;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private PISkladiste2DataSetTableAdapters.ZaposlenikTableAdapter zaposlenikTableAdapter;
        private System.Windows.Forms.ComboBox imeComboBox;
        private System.Windows.Forms.ComboBox prezimeComboBox;
        private System.Windows.Forms.ComboBox nabavna_cijenaComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource stavke_eksternogDokumentaBindingSource;
        private System.Windows.Forms.ComboBox nazivComboBox1;
        private System.Windows.Forms.TextBox adresaTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_artikla;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn suma;
    }
}