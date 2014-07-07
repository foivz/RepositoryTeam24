namespace Skladista
{
    partial class Izdatnica
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
            this.nabavna_cijenaComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jedinicna_cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeinternogDokumentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artiklBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaposlenikTableAdapter = new Skladista.PISkladiste2DataSetTableAdapters.ZaposlenikTableAdapter();
            this.imeComboBox = new System.Windows.Forms.ComboBox();
            this.prezimeComboBox = new System.Windows.Forms.ComboBox();
            sifraLabel = new System.Windows.Forms.Label();
            nazivLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pISkladiste2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeinternogDokumentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sifraLabel
            // 
            sifraLabel.AutoSize = true;
            sifraLabel.BackColor = System.Drawing.Color.Transparent;
            sifraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            sifraLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            sifraLabel.Location = new System.Drawing.Point(83, 197);
            sifraLabel.Name = "sifraLabel";
            sifraLabel.Size = new System.Drawing.Size(47, 17);
            sifraLabel.TabIndex = 71;
            sifraLabel.Text = "Šifra:";
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.BackColor = System.Drawing.Color.Transparent;
            nazivLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            nazivLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            nazivLabel.Location = new System.Drawing.Point(77, 237);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(53, 17);
            nazivLabel.TabIndex = 72;
            nazivLabel.Text = "Naziv:";
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Skladista.Properties.Resources.Close1;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Location = new System.Drawing.Point(608, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 42);
            this.button3.TabIndex = 70;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(296, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 69;
            this.label6.Text = "Količina:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(296, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 68;
            this.label5.Text = "Jedinična cijena:";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Skladista.Properties.Resources.Floppy;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Location = new System.Drawing.Point(608, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 40);
            this.button2.TabIndex = 67;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Skladista.Properties.Resources.Add;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(608, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 46);
            this.button1.TabIndex = 66;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(443, 197);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(130, 20);
            this.textBox3.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(38, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 63;
            this.label1.Text = "Izradio:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Location = new System.Drawing.Point(145, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(189, 26);
            this.dateTimePicker1.TabIndex = 62;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtSifraNar
            // 
            this.txtSifraNar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSifraNar.Location = new System.Drawing.Point(145, 34);
            this.txtSifraNar.Margin = new System.Windows.Forms.Padding(2);
            this.txtSifraNar.Multiline = true;
            this.txtSifraNar.Name = "txtSifraNar";
            this.txtSifraNar.ReadOnly = true;
            this.txtSifraNar.Size = new System.Drawing.Size(275, 35);
            this.txtSifraNar.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(38, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 60;
            this.label3.Text = "Datum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(38, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 59;
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
            this.sifraComboBox.FormattingEnabled = true;
            this.sifraComboBox.Location = new System.Drawing.Point(145, 197);
            this.sifraComboBox.Name = "sifraComboBox";
            this.sifraComboBox.Size = new System.Drawing.Size(121, 21);
            this.sifraComboBox.TabIndex = 72;
            this.sifraComboBox.ValueMember = "sifra";
            // 
            // nazivComboBox
            // 
            this.nazivComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artiklBindingSource, "naziv", true));
            this.nazivComboBox.DataSource = this.artiklBindingSource;
            this.nazivComboBox.DisplayMember = "naziv";
            this.nazivComboBox.FormattingEnabled = true;
            this.nazivComboBox.Location = new System.Drawing.Point(145, 233);
            this.nazivComboBox.Name = "nazivComboBox";
            this.nazivComboBox.Size = new System.Drawing.Size(121, 21);
            this.nazivComboBox.TabIndex = 73;
            this.nazivComboBox.ValueMember = "sifra";
            // 
            // nabavna_cijenaComboBox
            // 
            this.nabavna_cijenaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artiklBindingSource, "nabavna_cijena", true));
            this.nabavna_cijenaComboBox.DataSource = this.artiklBindingSource;
            this.nabavna_cijenaComboBox.DisplayMember = "nabavna_cijena";
            this.nabavna_cijenaComboBox.FormatString = "N2";
            this.nabavna_cijenaComboBox.FormattingEnabled = true;
            this.nabavna_cijenaComboBox.Location = new System.Drawing.Point(443, 233);
            this.nabavna_cijenaComboBox.Name = "nabavna_cijenaComboBox";
            this.nabavna_cijenaComboBox.Size = new System.Drawing.Size(130, 21);
            this.nabavna_cijenaComboBox.TabIndex = 74;
            this.nabavna_cijenaComboBox.ValueMember = "sifra";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.Kolicina,
            this.Jedinicna_cijena,
            this.Suma});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(43, 295);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(530, 180);
            this.dataGridView1.TabIndex = 75;
            // 
            // Naziv
            // 
            this.Naziv.HeaderText = "Naziv artikla";
            this.Naziv.Name = "Naziv";
            this.Naziv.Width = 120;
            // 
            // Kolicina
            // 
            this.Kolicina.HeaderText = "Količina";
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.Width = 110;
            // 
            // Jedinicna_cijena
            // 
            this.Jedinicna_cijena.HeaderText = "Jedinična cijena";
            this.Jedinicna_cijena.Name = "Jedinicna_cijena";
            this.Jedinicna_cijena.Width = 140;
            // 
            // Suma
            // 
            this.Suma.HeaderText = "Suma";
            this.Suma.Name = "Suma";
            this.Suma.Width = 110;
            // 
            // stavkeinternogDokumentaBindingSource
            // 
            this.stavkeinternogDokumentaBindingSource.DataSource = typeof(Skladista.stavke_internogDokumenta);
            // 
            // artiklBindingSource1
            // 
            this.artiklBindingSource1.DataSource = typeof(Skladista.Artikl);
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
            this.imeComboBox.DisplayMember = "ime";
            this.imeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imeComboBox.FormattingEnabled = true;
            this.imeComboBox.Location = new System.Drawing.Point(145, 132);
            this.imeComboBox.Name = "imeComboBox";
            this.imeComboBox.Size = new System.Drawing.Size(121, 28);
            this.imeComboBox.TabIndex = 76;
            this.imeComboBox.ValueMember = "sifra";
            this.imeComboBox.SelectedIndexChanged += new System.EventHandler(this.imeComboBox_SelectedIndexChanged);
            // 
            // prezimeComboBox
            // 
            this.prezimeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "prezime", true));
            this.prezimeComboBox.DataSource = this.zaposlenikBindingSource;
            this.prezimeComboBox.DisplayMember = "prezime";
            this.prezimeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prezimeComboBox.FormattingEnabled = true;
            this.prezimeComboBox.Location = new System.Drawing.Point(299, 132);
            this.prezimeComboBox.Name = "prezimeComboBox";
            this.prezimeComboBox.Size = new System.Drawing.Size(151, 28);
            this.prezimeComboBox.TabIndex = 77;
            this.prezimeComboBox.ValueMember = "sifra";
            this.prezimeComboBox.SelectedIndexChanged += new System.EventHandler(this.prezimeComboBox_SelectedIndexChanged);
            // 
            // Izdatnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 494);
            this.Controls.Add(this.prezimeComboBox);
            this.Controls.Add(this.imeComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.nabavna_cijenaComboBox);
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
            this.Name = "Izdatnica";
            this.Text = "Kreiranje izdatnice";
            this.Load += new System.EventHandler(this.Izdatnica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pISkladiste2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeinternogDokumentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
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
        private System.Windows.Forms.ComboBox nabavna_cijenaComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource stavkeinternogDokumentaBindingSource;
        private System.Windows.Forms.BindingSource artiklBindingSource1;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private PISkladiste2DataSetTableAdapters.ZaposlenikTableAdapter zaposlenikTableAdapter;
        private System.Windows.Forms.ComboBox imeComboBox;
        private System.Windows.Forms.ComboBox prezimeComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jedinicna_cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Suma;
    }
}