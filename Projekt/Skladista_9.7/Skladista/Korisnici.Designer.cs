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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Korisnici));
            this.lblSifra = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblKorIme = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.lblUloga = new System.Windows.Forms.Label();
            this.txtSifraKor = new System.Windows.Forms.TextBox();
            this.txtImeKor = new System.Windows.Forms.TextBox();
            this.txtPrezimeKor = new System.Windows.Forms.TextBox();
            this.txtKorImeKor = new System.Windows.Forms.TextBox();
            this.txtLozinkaKor = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnZatvori = new System.Windows.Forms.Button();
            this.cmbUloga = new System.Windows.Forms.ComboBox();
            this.ulogaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ulogaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ulogaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSifra
            // 
            this.lblSifra.AutoSize = true;
            this.lblSifra.BackColor = System.Drawing.Color.Transparent;
            this.lblSifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSifra.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSifra.Location = new System.Drawing.Point(44, 46);
            this.lblSifra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(52, 20);
            this.lblSifra.TabIndex = 0;
            this.lblSifra.Text = "Šifra:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.BackColor = System.Drawing.Color.Transparent;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIme.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblIme.Location = new System.Drawing.Point(44, 89);
            this.lblIme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(44, 20);
            this.lblIme.TabIndex = 2;
            this.lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.BackColor = System.Drawing.Color.Transparent;
            this.lblPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrezime.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPrezime.Location = new System.Drawing.Point(44, 137);
            this.lblPrezime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(78, 20);
            this.lblPrezime.TabIndex = 3;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblKorIme
            // 
            this.lblKorIme.AutoSize = true;
            this.lblKorIme.BackColor = System.Drawing.Color.Transparent;
            this.lblKorIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKorIme.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblKorIme.Location = new System.Drawing.Point(44, 240);
            this.lblKorIme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKorIme.Name = "lblKorIme";
            this.lblKorIme.Size = new System.Drawing.Size(129, 20);
            this.lblKorIme.TabIndex = 4;
            this.lblKorIme.Text = "Korisničko ime:";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.BackColor = System.Drawing.Color.Transparent;
            this.lblLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLozinka.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblLozinka.Location = new System.Drawing.Point(44, 291);
            this.lblLozinka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(76, 20);
            this.lblLozinka.TabIndex = 5;
            this.lblLozinka.Text = "Lozinka:";
            // 
            // lblUloga
            // 
            this.lblUloga.AutoSize = true;
            this.lblUloga.BackColor = System.Drawing.Color.Transparent;
            this.lblUloga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUloga.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblUloga.Location = new System.Drawing.Point(44, 181);
            this.lblUloga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUloga.Name = "lblUloga";
            this.lblUloga.Size = new System.Drawing.Size(61, 20);
            this.lblUloga.TabIndex = 6;
            this.lblUloga.Text = "Uloga:";
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
            this.txtKorImeKor.Location = new System.Drawing.Point(200, 234);
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
            this.btnDodaj.Location = new System.Drawing.Point(406, 42);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(88, 65);
            this.btnDodaj.TabIndex = 13;
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataSource = typeof(Skladista.Zaposlenik);
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackgroundImage = global::Skladista.Properties.Resources.Close1;
            this.btnZatvori.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnZatvori.Location = new System.Drawing.Point(406, 137);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(88, 64);
            this.btnZatvori.TabIndex = 15;
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.button2_Click);
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
            this.ClientSize = new System.Drawing.Size(522, 362);
            this.Controls.Add(this.cmbUloga);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtLozinkaKor);
            this.Controls.Add(this.txtKorImeKor);
            this.Controls.Add(this.txtPrezimeKor);
            this.Controls.Add(this.txtImeKor);
            this.Controls.Add(this.txtSifraKor);
            this.Controls.Add(this.lblUloga);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblKorIme);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lblSifra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Korisnici";
            this.Text = "Korisnici";
            this.Load += new System.EventHandler(this.Korisnici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSifra;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblKorIme;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Label lblUloga;
        private System.Windows.Forms.TextBox txtSifraKor;
        private System.Windows.Forms.TextBox txtImeKor;
        private System.Windows.Forms.TextBox txtPrezimeKor;
        private System.Windows.Forms.TextBox txtKorImeKor;
        private System.Windows.Forms.TextBox txtLozinkaKor;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.ComboBox cmbUloga;
        private System.Windows.Forms.BindingSource ulogaBindingSource;
        private System.Windows.Forms.BindingSource ulogaBindingSource2;
        private System.Windows.Forms.BindingSource ulogaBindingSource1;
    }
}