namespace Skladista
{
    partial class Korisnici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Korisnici));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSifraKor = new System.Windows.Forms.TextBox();
            this.txtImeKor = new System.Windows.Forms.TextBox();
            this.txtPrezimeKor = new System.Windows.Forms.TextBox();
            this.txtKorImeKor = new System.Windows.Forms.TextBox();
            this.txtLozinkaKor = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sifraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnickoimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lozinkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulogaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eksterniDokumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interniDokumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uloga1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnZatvori = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbUloga = new System.Windows.Forms.ComboBox();
            this.ulogaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ulogaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ulogaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(44, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Šifra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(44, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(44, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prezime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(44, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Korisničko ime:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(44, 291);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Lozinka:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(44, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Uloga:";
            // 
            // txtSifraKor
            // 
            this.txtSifraKor.Enabled = false;
            this.txtSifraKor.Location = new System.Drawing.Point(165, 46);
            this.txtSifraKor.Margin = new System.Windows.Forms.Padding(2);
            this.txtSifraKor.MaximumSize = new System.Drawing.Size(210, 50);
            this.txtSifraKor.Name = "txtSifraKor";
            this.txtSifraKor.Size = new System.Drawing.Size(205, 20);
            this.txtSifraKor.TabIndex = 7;
            this.txtSifraKor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtImeKor
            // 
            this.txtImeKor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtImeKor.Location = new System.Drawing.Point(165, 81);
            this.txtImeKor.Margin = new System.Windows.Forms.Padding(2);
            this.txtImeKor.Name = "txtImeKor";
            this.txtImeKor.Size = new System.Drawing.Size(205, 26);
            this.txtImeKor.TabIndex = 8;
            this.txtImeKor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrezimeKor
            // 
            this.txtPrezimeKor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPrezimeKor.Location = new System.Drawing.Point(165, 122);
            this.txtPrezimeKor.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrezimeKor.Name = "txtPrezimeKor";
            this.txtPrezimeKor.Size = new System.Drawing.Size(205, 26);
            this.txtPrezimeKor.TabIndex = 9;
            this.txtPrezimeKor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrezimeKor.TextChanged += new System.EventHandler(this.txtPrezimeKor_TextChanged);
            // 
            // txtKorImeKor
            // 
            this.txtKorImeKor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKorImeKor.Location = new System.Drawing.Point(200, 228);
            this.txtKorImeKor.Margin = new System.Windows.Forms.Padding(2);
            this.txtKorImeKor.Name = "txtKorImeKor";
            this.txtKorImeKor.Size = new System.Drawing.Size(170, 26);
            this.txtKorImeKor.TabIndex = 11;
            this.txtKorImeKor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLozinkaKor
            // 
            this.txtLozinkaKor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLozinkaKor.Location = new System.Drawing.Point(165, 288);
            this.txtLozinkaKor.Margin = new System.Windows.Forms.Padding(2);
            this.txtLozinkaKor.Name = "txtLozinkaKor";
            this.txtLozinkaKor.PasswordChar = '*';
            this.txtLozinkaKor.Size = new System.Drawing.Size(205, 26);
            this.txtLozinkaKor.TabIndex = 12;
            this.txtLozinkaKor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackgroundImage = global::Skladista.Properties.Resources.Add;
            this.btnDodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDodaj.Location = new System.Drawing.Point(498, 62);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(88, 65);
            this.btnDodaj.TabIndex = 13;
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
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
            this.sifraDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.korisnickoimeDataGridViewTextBoxColumn,
            this.lozinkaDataGridViewTextBoxColumn,
            this.ulogaDataGridViewTextBoxColumn,
            this.eksterniDokumentDataGridViewTextBoxColumn,
            this.interniDokumentDataGridViewTextBoxColumn,
            this.uloga1DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zaposlenikBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(46, 408);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(678, 138);
            this.dataGridView1.TabIndex = 14;
            // 
            // sifraDataGridViewTextBoxColumn
            // 
            this.sifraDataGridViewTextBoxColumn.DataPropertyName = "sifra";
            this.sifraDataGridViewTextBoxColumn.HeaderText = "Šifra";
            this.sifraDataGridViewTextBoxColumn.Name = "sifraDataGridViewTextBoxColumn";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // korisnickoimeDataGridViewTextBoxColumn
            // 
            this.korisnickoimeDataGridViewTextBoxColumn.DataPropertyName = "korisnicko_ime";
            this.korisnickoimeDataGridViewTextBoxColumn.HeaderText = "Korisničko ime";
            this.korisnickoimeDataGridViewTextBoxColumn.Name = "korisnickoimeDataGridViewTextBoxColumn";
            this.korisnickoimeDataGridViewTextBoxColumn.Width = 130;
            // 
            // lozinkaDataGridViewTextBoxColumn
            // 
            this.lozinkaDataGridViewTextBoxColumn.DataPropertyName = "lozinka";
            this.lozinkaDataGridViewTextBoxColumn.HeaderText = "Lozinka";
            this.lozinkaDataGridViewTextBoxColumn.Name = "lozinkaDataGridViewTextBoxColumn";
            // 
            // ulogaDataGridViewTextBoxColumn
            // 
            this.ulogaDataGridViewTextBoxColumn.DataPropertyName = "uloga";
            this.ulogaDataGridViewTextBoxColumn.HeaderText = "Uloga";
            this.ulogaDataGridViewTextBoxColumn.Name = "ulogaDataGridViewTextBoxColumn";
            // 
            // eksterniDokumentDataGridViewTextBoxColumn
            // 
            this.eksterniDokumentDataGridViewTextBoxColumn.DataPropertyName = "eksterniDokument";
            this.eksterniDokumentDataGridViewTextBoxColumn.HeaderText = "eksterniDokument";
            this.eksterniDokumentDataGridViewTextBoxColumn.Name = "eksterniDokumentDataGridViewTextBoxColumn";
            this.eksterniDokumentDataGridViewTextBoxColumn.Visible = false;
            // 
            // interniDokumentDataGridViewTextBoxColumn
            // 
            this.interniDokumentDataGridViewTextBoxColumn.DataPropertyName = "interniDokument";
            this.interniDokumentDataGridViewTextBoxColumn.HeaderText = "interniDokument";
            this.interniDokumentDataGridViewTextBoxColumn.Name = "interniDokumentDataGridViewTextBoxColumn";
            this.interniDokumentDataGridViewTextBoxColumn.Visible = false;
            // 
            // uloga1DataGridViewTextBoxColumn
            // 
            this.uloga1DataGridViewTextBoxColumn.DataPropertyName = "Uloga1";
            this.uloga1DataGridViewTextBoxColumn.HeaderText = "Uloga1";
            this.uloga1DataGridViewTextBoxColumn.Name = "uloga1DataGridViewTextBoxColumn";
            this.uloga1DataGridViewTextBoxColumn.Visible = false;
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataSource = typeof(Skladista.Zaposlenik);
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackgroundImage = global::Skladista.Properties.Resources.Close1;
            this.btnZatvori.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnZatvori.Location = new System.Drawing.Point(498, 155);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(88, 64);
            this.btnZatvori.TabIndex = 15;
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(42, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Prikaz korisnika:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cmbUloga
            // 
            this.cmbUloga.DataSource = this.ulogaBindingSource;
            this.cmbUloga.DisplayMember = "naziv";
            this.cmbUloga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbUloga.FormattingEnabled = true;
            this.cmbUloga.Location = new System.Drawing.Point(165, 173);
            this.cmbUloga.Name = "cmbUloga";
            this.cmbUloga.Size = new System.Drawing.Size(205, 28);
            this.cmbUloga.TabIndex = 17;
            this.cmbUloga.ValueMember = "sifra";
            this.cmbUloga.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ulogaBindingSource
            // 
            this.ulogaBindingSource.DataSource = typeof(Skladista.Uloga);
            // 
            // ulogaBindingSource2
            // 
            this.ulogaBindingSource2.DataSource = typeof(Skladista.Uloga);
            // 
            // ulogaBindingSource1
            // 
            this.ulogaBindingSource1.DataSource = typeof(Skladista.Uloga);
            // 
            // Korisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(756, 558);
            this.Controls.Add(this.cmbUloga);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtLozinkaKor);
            this.Controls.Add(this.txtKorImeKor);
            this.Controls.Add(this.txtPrezimeKor);
            this.Controls.Add(this.txtImeKor);
            this.Controls.Add(this.txtSifraKor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Korisnici";
            this.Text = "Korisnici";
            this.Load += new System.EventHandler(this.Korisnici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSifraKor;
        private System.Windows.Forms.TextBox txtImeKor;
        private System.Windows.Forms.TextBox txtPrezimeKor;
        private System.Windows.Forms.TextBox txtKorImeKor;
        private System.Windows.Forms.TextBox txtLozinkaKor;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbUloga;
        private System.Windows.Forms.BindingSource ulogaBindingSource;
        private System.Windows.Forms.BindingSource ulogaBindingSource2;
        private System.Windows.Forms.BindingSource ulogaBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnickoimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lozinkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulogaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eksterniDokumentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interniDokumentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uloga1DataGridViewTextBoxColumn;
    }
}