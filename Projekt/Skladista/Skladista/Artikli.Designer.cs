namespace Skladista
{
    partial class Artikli
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sifraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nabavnacijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimalnakolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pododjelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pododjelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pododjel1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeeksternogDokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeinternogDokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSifraKor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNabavnaCijena = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMinKolicina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbPododjel = new System.Windows.Forms.ComboBox();
            this.btnZatvori = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pododjelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(512, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 96);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kreiraj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sifraDataGridViewTextBoxColumn,
            this.nabavnacijenaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.minimalnakolicinaDataGridViewTextBoxColumn,
            this.pododjelDataGridViewTextBoxColumn,
            this.pododjel1DataGridViewTextBoxColumn,
            this.stavkeeksternogDokumentaDataGridViewTextBoxColumn,
            this.stavkeinternogDokumentaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.artiklBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(310, 358);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(632, 276);
            this.dataGridView1.TabIndex = 2;
           
            // sifraDataGridViewTextBoxColumn
            // 
            this.sifraDataGridViewTextBoxColumn.DataPropertyName = "sifra";
            this.sifraDataGridViewTextBoxColumn.HeaderText = "sifra";
            this.sifraDataGridViewTextBoxColumn.Name = "sifraDataGridViewTextBoxColumn";
            // 
            // nabavnacijenaDataGridViewTextBoxColumn
            // 
            this.nabavnacijenaDataGridViewTextBoxColumn.DataPropertyName = "nabavna_cijena";
            this.nabavnacijenaDataGridViewTextBoxColumn.HeaderText = "nabavna_cijena";
            this.nabavnacijenaDataGridViewTextBoxColumn.Name = "nabavnacijenaDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // minimalnakolicinaDataGridViewTextBoxColumn
            // 
            this.minimalnakolicinaDataGridViewTextBoxColumn.DataPropertyName = "minimalna_kolicina";
            this.minimalnakolicinaDataGridViewTextBoxColumn.HeaderText = "minimalna_kolicina";
            this.minimalnakolicinaDataGridViewTextBoxColumn.Name = "minimalnakolicinaDataGridViewTextBoxColumn";
            // 
            // pododjelDataGridViewTextBoxColumn
            // 
            this.pododjelDataGridViewTextBoxColumn.DataPropertyName = "pododjel";
            this.pododjelDataGridViewTextBoxColumn.DataSource = this.pododjelBindingSource;
            this.pododjelDataGridViewTextBoxColumn.DisplayMember = "naziv";
            this.pododjelDataGridViewTextBoxColumn.HeaderText = "pododjel";
            this.pododjelDataGridViewTextBoxColumn.Name = "pododjelDataGridViewTextBoxColumn";
            this.pododjelDataGridViewTextBoxColumn.ReadOnly = true;
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
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataSource = typeof(Skladista.Artikl);
            // 
            // txtSifraKor
            // 
            this.txtSifraKor.Enabled = false;
            this.txtSifraKor.Location = new System.Drawing.Point(174, 11);
            this.txtSifraKor.Margin = new System.Windows.Forms.Padding(2);
            this.txtSifraKor.Multiline = true;
            this.txtSifraKor.Name = "txtSifraKor";
            this.txtSifraKor.Size = new System.Drawing.Size(205, 41);
            this.txtSifraKor.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(11, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Šifra:";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Enabled = false;
            this.txtKolicina.Location = new System.Drawing.Point(174, 183);
            this.txtKolicina.Margin = new System.Windows.Forms.Padding(2);
            this.txtKolicina.Multiline = true;
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(205, 41);
            this.txtKolicina.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(11, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Količina:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(174, 126);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(2);
            this.txtNaziv.Multiline = true;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(205, 41);
            this.txtNaziv.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(11, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Naziv:";
            // 
            // txtNabavnaCijena
            // 
            this.txtNabavnaCijena.Location = new System.Drawing.Point(174, 71);
            this.txtNabavnaCijena.Margin = new System.Windows.Forms.Padding(2);
            this.txtNabavnaCijena.Multiline = true;
            this.txtNabavnaCijena.Name = "txtNabavnaCijena";
            this.txtNabavnaCijena.Size = new System.Drawing.Size(205, 41);
            this.txtNabavnaCijena.TabIndex = 15;
            this.txtNabavnaCijena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNabavnaCijena_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(11, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nabavna cijena:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(11, 358);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Popis artikala: ";
            // 
            // txtMinKolicina
            // 
            this.txtMinKolicina.Location = new System.Drawing.Point(174, 248);
            this.txtMinKolicina.Margin = new System.Windows.Forms.Padding(2);
            this.txtMinKolicina.Multiline = true;
            this.txtMinKolicina.Name = "txtMinKolicina";
            this.txtMinKolicina.Size = new System.Drawing.Size(205, 41);
            this.txtMinKolicina.TabIndex = 18;
         
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(11, 248);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Minimalna količina:";
       
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(11, 314);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Pododjel:";
            // 
            // cmbPododjel
            // 
            this.cmbPododjel.DataSource = this.pododjelBindingSource;
            this.cmbPododjel.DisplayMember = "naziv";
            this.cmbPododjel.FormattingEnabled = true;
            this.cmbPododjel.Location = new System.Drawing.Point(174, 316);
            this.cmbPododjel.Name = "cmbPododjel";
            this.cmbPododjel.Size = new System.Drawing.Size(205, 21);
            this.cmbPododjel.TabIndex = 20;
            this.cmbPododjel.ValueMember = "sifra";
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(512, 50);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(216, 96);
            this.btnZatvori.TabIndex = 21;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // Artikli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 646);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.cmbPododjel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMinKolicina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNabavnaCijena);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSifraKor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Artikli";
            this.Text = "Artikli";
            this.Load += new System.EventHandler(this.Artikli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pododjelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private System.Windows.Forms.TextBox txtSifraKor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNabavnaCijena;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMinKolicina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbPododjel;
        private System.Windows.Forms.BindingSource pododjelBindingSource;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nabavnacijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimalnakolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn pododjelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pododjel1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkeeksternogDokumentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkeinternogDokumentaDataGridViewTextBoxColumn;
    }
}