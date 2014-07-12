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
            this.lblKolicina = new System.Windows.Forms.Label();
            this.lblCijena = new System.Windows.Forms.Label();
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
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.BackColor = System.Drawing.Color.Transparent;
            this.lblKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKolicina.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblKolicina.Location = new System.Drawing.Point(37, 111);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(67, 20);
            this.lblKolicina.TabIndex = 73;
            this.lblKolicina.Text = "Količina:";
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.BackColor = System.Drawing.Color.Transparent;
            this.lblCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCijena.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCijena.Location = new System.Drawing.Point(36, 146);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(125, 20);
            this.lblCijena.TabIndex = 72;
            this.lblCijena.Text = "Jedinična cijena:";
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
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.lblCijena);
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
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.TextBox cmbKolicina;
        private System.Windows.Forms.BindingSource artiklBindingSource;
    }
}