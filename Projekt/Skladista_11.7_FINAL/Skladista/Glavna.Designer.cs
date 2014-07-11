namespace Skladista
{
    partial class Glavna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Glavna));
            this.IzbornikTool = new System.Windows.Forms.ToolStrip();
            this.tsPrijava = new System.Windows.Forms.ToolStripDropDownButton();
            this.prijavaIzbornik = new System.Windows.Forms.ToolStripMenuItem();
            this.odjavaIzbornik = new System.Windows.Forms.ToolStripMenuItem();
            this.zatvoriPodizbornik = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDokumenti = new System.Windows.Forms.ToolStripDropDownButton();
            this.narudzbenicaPodizbornik = new System.Windows.Forms.ToolStripMenuItem();
            this.otpremnicaPodizbornik = new System.Windows.Forms.ToolStripMenuItem();
            this.skladišnicaPodizbornik = new System.Windows.Forms.ToolStripMenuItem();
            this.izdatnicaPodizbornik = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsKorisnici = new System.Windows.Forms.ToolStripDropDownButton();
            this.UpravljanjeKorisnikaPodizbornik = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSkladiste = new System.Windows.Forms.ToolStripDropDownButton();
            this.stanjePodizbornik = new System.Windows.Forms.ToolStripMenuItem();
            this.podizbornikABC = new System.Windows.Forms.ToolStripMenuItem();
            this.tsArtikli = new System.Windows.Forms.ToolStripDropDownButton();
            this.kreiranjeArtikla = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpDropDownButton = new System.Windows.Forms.ToolStripButton();
            this.sat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.IzbornikTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // IzbornikTool
            // 
            this.IzbornikTool.BackColor = System.Drawing.Color.MintCream;
            this.IzbornikTool.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.IzbornikTool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPrijava,
            this.tsDokumenti,
            this.toolStripSeparator1,
            this.tsKorisnici,
            this.toolStripSeparator3,
            this.tsSkladiste,
            this.tsArtikli,
            this.HelpDropDownButton});
            this.IzbornikTool.Location = new System.Drawing.Point(0, 0);
            this.IzbornikTool.Name = "IzbornikTool";
            this.IzbornikTool.Size = new System.Drawing.Size(750, 28);
            this.IzbornikTool.TabIndex = 0;
            this.IzbornikTool.Text = "IzbornikTool";
            // 
            // tsPrijava
            // 
            this.tsPrijava.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsPrijava.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prijavaIzbornik,
            this.odjavaIzbornik,
            this.zatvoriPodizbornik});
            this.tsPrijava.Image = global::Skladista.Properties.Resources.Home;
            this.tsPrijava.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPrijava.Name = "tsPrijava";
            this.tsPrijava.Size = new System.Drawing.Size(78, 25);
            this.tsPrijava.Text = "Početna";
            // 
            // prijavaIzbornik
            // 
            this.prijavaIzbornik.Name = "prijavaIzbornik";
            this.prijavaIzbornik.Size = new System.Drawing.Size(184, 26);
            this.prijavaIzbornik.Text = "Prijava";
            this.prijavaIzbornik.Click += new System.EventHandler(this.prijavaToolStripMenuItem_Click);
            // 
            // odjavaIzbornik
            // 
            this.odjavaIzbornik.Name = "odjavaIzbornik";
            this.odjavaIzbornik.Size = new System.Drawing.Size(184, 26);
            this.odjavaIzbornik.Text = "Odjava";
            this.odjavaIzbornik.Click += new System.EventHandler(this.odjavaIzbornik_Click);
            // 
            // zatvoriPodizbornik
            // 
            this.zatvoriPodizbornik.Name = "zatvoriPodizbornik";
            this.zatvoriPodizbornik.ShortcutKeyDisplayString = "";
            this.zatvoriPodizbornik.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.zatvoriPodizbornik.Size = new System.Drawing.Size(184, 26);
            this.zatvoriPodizbornik.Text = "Zatvori";
            this.zatvoriPodizbornik.Click += new System.EventHandler(this.zatvoriToolStripMenuItem_Click);
            // 
            // tsDokumenti
            // 
            this.tsDokumenti.BackColor = System.Drawing.Color.MintCream;
            this.tsDokumenti.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsDokumenti.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.narudzbenicaPodizbornik,
            this.otpremnicaPodizbornik,
            this.skladišnicaPodizbornik,
            this.izdatnicaPodizbornik});
            this.tsDokumenti.Image = ((System.Drawing.Image)(resources.GetObject("tsDokumenti.Image")));
            this.tsDokumenti.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDokumenti.Name = "tsDokumenti";
            this.tsDokumenti.Size = new System.Drawing.Size(100, 25);
            this.tsDokumenti.Text = "Dokumenti";
            // 
            // narudzbenicaPodizbornik
            // 
            this.narudzbenicaPodizbornik.Name = "narudzbenicaPodizbornik";
            this.narudzbenicaPodizbornik.Size = new System.Drawing.Size(176, 26);
            this.narudzbenicaPodizbornik.Text = "Narudžbenica";
            this.narudzbenicaPodizbornik.Click += new System.EventHandler(this.narudzbenicaToolStripMenuItem_Click);
            // 
            // otpremnicaPodizbornik
            // 
            this.otpremnicaPodizbornik.Name = "otpremnicaPodizbornik";
            this.otpremnicaPodizbornik.Size = new System.Drawing.Size(176, 26);
            this.otpremnicaPodizbornik.Text = "Otpremnica";
            this.otpremnicaPodizbornik.Click += new System.EventHandler(this.otpremnicaToolStripMenuItem_Click);
            // 
            // skladišnicaPodizbornik
            // 
            this.skladišnicaPodizbornik.Name = "skladišnicaPodizbornik";
            this.skladišnicaPodizbornik.Size = new System.Drawing.Size(176, 26);
            this.skladišnicaPodizbornik.Text = "Skladišnica";
            this.skladišnicaPodizbornik.Click += new System.EventHandler(this.skladišnicaToolStripMenuItem1_Click);
            // 
            // izdatnicaPodizbornik
            // 
            this.izdatnicaPodizbornik.Name = "izdatnicaPodizbornik";
            this.izdatnicaPodizbornik.Size = new System.Drawing.Size(176, 26);
            this.izdatnicaPodizbornik.Text = "Izdatnica";
            this.izdatnicaPodizbornik.Click += new System.EventHandler(this.izdatnicaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // tsKorisnici
            // 
            this.tsKorisnici.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsKorisnici.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpravljanjeKorisnikaPodizbornik});
            this.tsKorisnici.Image = ((System.Drawing.Image)(resources.GetObject("tsKorisnici.Image")));
            this.tsKorisnici.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsKorisnici.Name = "tsKorisnici";
            this.tsKorisnici.Size = new System.Drawing.Size(82, 25);
            this.tsKorisnici.Text = "Korisnici";
            // 
            // UpravljanjeKorisnikaPodizbornik
            // 
            this.UpravljanjeKorisnikaPodizbornik.Name = "UpravljanjeKorisnikaPodizbornik";
            this.UpravljanjeKorisnikaPodizbornik.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.K)));
            this.UpravljanjeKorisnikaPodizbornik.Size = new System.Drawing.Size(292, 26);
            this.UpravljanjeKorisnikaPodizbornik.Text = "Upravljanje korisnicima";
            this.UpravljanjeKorisnikaPodizbornik.Click += new System.EventHandler(this.kreiranjeKorisnikaToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // tsSkladiste
            // 
            this.tsSkladiste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsSkladiste.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stanjePodizbornik,
            this.podizbornikABC});
            this.tsSkladiste.Image = ((System.Drawing.Image)(resources.GetObject("tsSkladiste.Image")));
            this.tsSkladiste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSkladiste.Name = "tsSkladiste";
            this.tsSkladiste.Size = new System.Drawing.Size(85, 25);
            this.tsSkladiste.Text = "Skladište";
            // 
            // stanjePodizbornik
            // 
            this.stanjePodizbornik.Name = "stanjePodizbornik";
            this.stanjePodizbornik.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.stanjePodizbornik.Size = new System.Drawing.Size(172, 26);
            this.stanjePodizbornik.Text = "Stanje";
            this.stanjePodizbornik.Click += new System.EventHandler(this.uvidUStanjeNaSkladištuToolStripMenuItem_Click);
            // 
            // podizbornikABC
            // 
            this.podizbornikABC.Name = "podizbornikABC";
            this.podizbornikABC.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.K)));
            this.podizbornikABC.Size = new System.Drawing.Size(172, 26);
            this.podizbornikABC.Text = "ABC ";
            this.podizbornikABC.Click += new System.EventHandler(this.podizbornikABC_Click);
            // 
            // tsArtikli
            // 
            this.tsArtikli.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsArtikli.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreiranjeArtikla});
            this.tsArtikli.Image = ((System.Drawing.Image)(resources.GetObject("tsArtikli.Image")));
            this.tsArtikli.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsArtikli.Name = "tsArtikli";
            this.tsArtikli.Size = new System.Drawing.Size(64, 25);
            this.tsArtikli.Text = "Artikli";
            // 
            // kreiranjeArtikla
            // 
            this.kreiranjeArtikla.AutoSize = false;
            this.kreiranjeArtikla.Name = "kreiranjeArtikla";
            this.kreiranjeArtikla.ShortcutKeyDisplayString = "Alt +A";
            this.kreiranjeArtikla.Size = new System.Drawing.Size(159, 26);
            this.kreiranjeArtikla.Text = "Upravljanje";
            this.kreiranjeArtikla.Click += new System.EventHandler(this.kreiranjeToolStripMenuItem4_Click);
            // 
            // HelpDropDownButton
            // 
            this.HelpDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.HelpDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("HelpDropDownButton.Image")));
            this.HelpDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HelpDropDownButton.Name = "HelpDropDownButton";
            this.HelpDropDownButton.Size = new System.Drawing.Size(62, 25);
            this.HelpDropDownButton.Text = "Pomoć";
            this.HelpDropDownButton.Click += new System.EventHandler(this.HelpDropDownButton_Click);
            // 
            // sat
            // 
            this.sat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sat.AutoEllipsis = true;
            this.sat.BackColor = System.Drawing.Color.Transparent;
            this.sat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sat.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sat.ForeColor = System.Drawing.SystemColors.Window;
            this.sat.Location = new System.Drawing.Point(566, 382);
            this.sat.Name = "sat";
            this.sat.Size = new System.Drawing.Size(141, 63);
            this.sat.TabIndex = 4;
            this.sat.Text = "sat";
            this.sat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Skladista.Properties.Resources.slik3;
            this.ClientSize = new System.Drawing.Size(750, 480);
            this.Controls.Add(this.sat);
            this.Controls.Add(this.IzbornikTool);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Glavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skladište";
            this.Load += new System.EventHandler(this.Glavna_Load);
            this.IzbornikTool.ResumeLayout(false);
            this.IzbornikTool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStrip IzbornikTool;
        public System.Windows.Forms.ToolStripDropDownButton tsDokumenti;
        public System.Windows.Forms.ToolStripMenuItem narudzbenicaPodizbornik;
        public System.Windows.Forms.ToolStripMenuItem otpremnicaPodizbornik;
        public System.Windows.Forms.ToolStripMenuItem skladišnicaPodizbornik;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripDropDownButton tsSkladiste;
        private System.Windows.Forms.ToolStripMenuItem stanjePodizbornik;
        public System.Windows.Forms.ToolStripDropDownButton tsArtikli;
        private System.Windows.Forms.ToolStripMenuItem kreiranjeArtikla;
        public System.Windows.Forms.ToolStripDropDownButton tsPrijava;
        public System.Windows.Forms.ToolStripMenuItem prijavaIzbornik;
        public System.Windows.Forms.ToolStripMenuItem odjavaIzbornik;
        private System.Windows.Forms.ToolStripMenuItem zatvoriPodizbornik;
        public System.Windows.Forms.ToolStripMenuItem izdatnicaPodizbornik;
        private System.Windows.Forms.Label sat;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ToolStripDropDownButton tsKorisnici;
        private System.Windows.Forms.ToolStripMenuItem UpravljanjeKorisnikaPodizbornik;
        private System.Windows.Forms.ToolStripMenuItem podizbornikABC;
        private System.Windows.Forms.ToolStripButton HelpDropDownButton;
    }
}

