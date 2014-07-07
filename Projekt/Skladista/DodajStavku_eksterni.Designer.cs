namespace Skladista
{
    partial class DodajStavku_eksterni
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
            System.Windows.Forms.Label nazivLabel;
            System.Windows.Forms.Label sifraLabel;
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cmbCijena = new System.Windows.Forms.ComboBox();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbNaziv = new System.Windows.Forms.ComboBox();
            this.cmbSifra = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbKolicina = new System.Windows.Forms.TextBox();
            nazivLabel = new System.Windows.Forms.Label();
            sifraLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.BackColor = System.Drawing.Color.Transparent;
            nazivLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            nazivLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            nazivLabel.Location = new System.Drawing.Point(36, 78);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(97, 20);
            nazivLabel.TabIndex = 75;
            nazivLabel.Text = "Naziv artikla:";
            nazivLabel.Click += new System.EventHandler(this.nazivLabel_Click);
            // 
            // sifraLabel
            // 
            sifraLabel.AutoSize = true;
            sifraLabel.BackColor = System.Drawing.Color.Transparent;
            sifraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            sifraLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            sifraLabel.Location = new System.Drawing.Point(37, 46);
            sifraLabel.Name = "sifraLabel";
            sifraLabel.Size = new System.Drawing.Size(96, 20);
            sifraLabel.TabIndex = 74;
            sifraLabel.Text = "Šifra artikla: ";
            sifraLabel.Click += new System.EventHandler(this.sifraLabel_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackgroundImage = global::Skladista.Properties.Resources.Close;
            this.btnZatvori.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnZatvori.Location = new System.Drawing.Point(200, 218);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(60, 52);
            this.btnZatvori.TabIndex = 80;
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackgroundImage = global::Skladista.Properties.Resources.Add;
            this.btnDodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDodaj.Location = new System.Drawing.Point(117, 218);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(62, 52);
            this.btnDodaj.TabIndex = 79;
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // cmbCijena
            // 
            this.cmbCijena.DataSource = this.artiklBindingSource;
            this.cmbCijena.DisplayMember = "nabavna_cijena";
            this.cmbCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbCijena.FormatString = "C2";
            this.cmbCijena.FormattingEnabled = true;
            this.cmbCijena.Location = new System.Drawing.Point(171, 148);
            this.cmbCijena.Name = "cmbCijena";
            this.cmbCijena.Size = new System.Drawing.Size(216, 28);
            this.cmbCijena.TabIndex = 78;
            this.cmbCijena.ValueMember = "sifra_artikla";
            // 
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataSource = typeof(Skladista.Artikl);
            // 
            // cmbNaziv
            // 
            this.cmbNaziv.DataSource = this.artiklBindingSource;
            this.cmbNaziv.DisplayMember = "naziv";
            this.cmbNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbNaziv.FormattingEnabled = true;
            this.cmbNaziv.Location = new System.Drawing.Point(171, 80);
            this.cmbNaziv.Name = "cmbNaziv";
            this.cmbNaziv.Size = new System.Drawing.Size(216, 28);
            this.cmbNaziv.TabIndex = 77;
            this.cmbNaziv.ValueMember = "sifra";
            // 
            // cmbSifra
            // 
            this.cmbSifra.DataSource = this.artiklBindingSource;
            this.cmbSifra.DisplayMember = "sifra";
            this.cmbSifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbSifra.FormattingEnabled = true;
            this.cmbSifra.Location = new System.Drawing.Point(171, 45);
            this.cmbSifra.Name = "cmbSifra";
            this.cmbSifra.Size = new System.Drawing.Size(85, 28);
            this.cmbSifra.TabIndex = 76;
            this.cmbSifra.ValueMember = "sifra";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(37, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 73;
            this.label6.Text = "Količina:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(36, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 72;
            this.label5.Text = "Jedinična cijena:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cmbKolicina
            // 
            this.cmbKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbKolicina.Location = new System.Drawing.Point(171, 111);
            this.cmbKolicina.Name = "cmbKolicina";
            this.cmbKolicina.Size = new System.Drawing.Size(85, 26);
            this.cmbKolicina.TabIndex = 71;
            // 
            // DodajStavku_eksterni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(438, 332);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cmbCijena);
            this.Controls.Add(this.cmbNaziv);
            this.Controls.Add(this.cmbSifra);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(sifraLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbKolicina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "DodajStavku_eksterni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje stavke";
            this.Load += new System.EventHandler(this.DodajStavku_eksterni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cmbCijena;
        private System.Windows.Forms.ComboBox cmbNaziv;
        private System.Windows.Forms.ComboBox cmbSifra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cmbKolicina;
        private System.Windows.Forms.BindingSource artiklBindingSource;
    }
}