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
            this.toolStripDropDownButton5 = new System.Windows.Forms.ToolStripDropDownButton();
            this.prijavaIzbornik = new System.Windows.Forms.ToolStripMenuItem();
            this.odjavaIzbornik = new System.Windows.Forms.ToolStripMenuItem();
            this.zatvoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.narudzbenicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otpremnicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skladišnicaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.izdatnicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.kreiranjeKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ažuriranjeKoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.uvidUStanjeNaSkladištuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.kreiranjeArtikla = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripDropDownButton5,
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.toolStripDropDownButton3,
            this.toolStripSeparator3,
            this.toolStripDropDownButton4,
            this.toolStripDropDownButton2});
            this.IzbornikTool.Location = new System.Drawing.Point(0, 0);
            this.IzbornikTool.Name = "IzbornikTool";
            this.IzbornikTool.Size = new System.Drawing.Size(750, 28);
            this.IzbornikTool.TabIndex = 0;
            this.IzbornikTool.Text = "IzbornikTool";
            this.IzbornikTool.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripDropDownButton5
            // 
            this.toolStripDropDownButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prijavaIzbornik,
            this.odjavaIzbornik,
            this.zatvoriToolStripMenuItem});
            this.toolStripDropDownButton5.Image = global::Skladista.Properties.Resources.Home;
            this.toolStripDropDownButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton5.Name = "toolStripDropDownButton5";
            this.toolStripDropDownButton5.Size = new System.Drawing.Size(78, 25);
            this.toolStripDropDownButton5.Text = "Početna";
            this.toolStripDropDownButton5.Click += new System.EventHandler(this.toolStripDropDownButton5_Click);
            // 
            // prijavaIzbornik
            // 
            this.prijavaIzbornik.Name = "prijavaIzbornik";
            this.prijavaIzbornik.Size = new System.Drawing.Size(129, 26);
            this.prijavaIzbornik.Text = "Prijava";
            this.prijavaIzbornik.Click += new System.EventHandler(this.prijavaToolStripMenuItem_Click);
            // 
            // odjavaIzbornik
            // 
            this.odjavaIzbornik.Name = "odjavaIzbornik";
            this.odjavaIzbornik.Size = new System.Drawing.Size(129, 26);
            this.odjavaIzbornik.Text = "Odjava";
            this.odjavaIzbornik.Click += new System.EventHandler(this.odjavaIzbornik_Click);
            // 
            // zatvoriToolStripMenuItem
            // 
            this.zatvoriToolStripMenuItem.Name = "zatvoriToolStripMenuItem";
            this.zatvoriToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.zatvoriToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.zatvoriToolStripMenuItem.Text = "Zatvori";
            this.zatvoriToolStripMenuItem.Click += new System.EventHandler(this.zatvoriToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.BackColor = System.Drawing.Color.MintCream;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.narudzbenicaToolStripMenuItem,
            this.otpremnicaToolStripMenuItem,
            this.skladišnicaToolStripMenuItem1,
            this.izdatnicaToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(100, 25);
            this.toolStripDropDownButton1.Text = "Dokumenti";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // narudzbenicaToolStripMenuItem
            // 
            this.narudzbenicaToolStripMenuItem.Name = "narudzbenicaToolStripMenuItem";
            this.narudzbenicaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.narudzbenicaToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.narudzbenicaToolStripMenuItem.Text = "Narudžbenica";
            this.narudzbenicaToolStripMenuItem.Click += new System.EventHandler(this.narudzbenicaToolStripMenuItem_Click);
            // 
            // otpremnicaToolStripMenuItem
            // 
            this.otpremnicaToolStripMenuItem.Name = "otpremnicaToolStripMenuItem";
            this.otpremnicaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.otpremnicaToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.otpremnicaToolStripMenuItem.Text = "Otpremnica";
            this.otpremnicaToolStripMenuItem.Click += new System.EventHandler(this.otpremnicaToolStripMenuItem_Click);
            // 
            // skladišnicaToolStripMenuItem1
            // 
            this.skladišnicaToolStripMenuItem1.Name = "skladišnicaToolStripMenuItem1";
            this.skladišnicaToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.skladišnicaToolStripMenuItem1.Size = new System.Drawing.Size(228, 26);
            this.skladišnicaToolStripMenuItem1.Text = "Skladišnica";
            this.skladišnicaToolStripMenuItem1.Click += new System.EventHandler(this.skladišnicaToolStripMenuItem1_Click);
            // 
            // izdatnicaToolStripMenuItem
            // 
            this.izdatnicaToolStripMenuItem.Name = "izdatnicaToolStripMenuItem";
            this.izdatnicaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.izdatnicaToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.izdatnicaToolStripMenuItem.Text = "Izdatnica";
            this.izdatnicaToolStripMenuItem.Click += new System.EventHandler(this.izdatnicaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreiranjeKorisnikaToolStripMenuItem,
            this.ažuriranjeKoToolStripMenuItem});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(82, 25);
            this.toolStripDropDownButton3.Text = "Korisnici";
            this.toolStripDropDownButton3.Click += new System.EventHandler(this.toolStripDropDownButton3_Click);
            // 
            // kreiranjeKorisnikaToolStripMenuItem
            // 
            this.kreiranjeKorisnikaToolStripMenuItem.Name = "kreiranjeKorisnikaToolStripMenuItem";
            this.kreiranjeKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.kreiranjeKorisnikaToolStripMenuItem.Text = "Kreiranje korisnika";
            this.kreiranjeKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.kreiranjeKorisnikaToolStripMenuItem_Click);
            // 
            // ažuriranjeKoToolStripMenuItem
            // 
            this.ažuriranjeKoToolStripMenuItem.Name = "ažuriranjeKoToolStripMenuItem";
            this.ažuriranjeKoToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.ažuriranjeKoToolStripMenuItem.Text = "Ažuriranje korisnika";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripDropDownButton4
            // 
            this.toolStripDropDownButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uvidUStanjeNaSkladištuToolStripMenuItem});
            this.toolStripDropDownButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton4.Image")));
            this.toolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            this.toolStripDropDownButton4.Size = new System.Drawing.Size(85, 25);
            this.toolStripDropDownButton4.Text = "Skladište";
            // 
            // uvidUStanjeNaSkladištuToolStripMenuItem
            // 
            this.uvidUStanjeNaSkladištuToolStripMenuItem.Name = "uvidUStanjeNaSkladištuToolStripMenuItem";
            this.uvidUStanjeNaSkladištuToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.uvidUStanjeNaSkladištuToolStripMenuItem.Text = "Uvid u stanje na skladištu";
            this.uvidUStanjeNaSkladištuToolStripMenuItem.Click += new System.EventHandler(this.uvidUStanjeNaSkladištuToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreiranjeArtikla});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(64, 25);
            this.toolStripDropDownButton2.Text = "Artikli";
            // 
            // kreiranjeArtikla
            // 
            this.kreiranjeArtikla.AutoSize = false;
            this.kreiranjeArtikla.Name = "kreiranjeArtikla";
            this.kreiranjeArtikla.Size = new System.Drawing.Size(159, 26);
            this.kreiranjeArtikla.Text = "Upravljanje";
            this.kreiranjeArtikla.Click += new System.EventHandler(this.kreiranjeToolStripMenuItem4_Click);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            this.IzbornikTool.ResumeLayout(false);
            this.IzbornikTool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStrip IzbornikTool;
        public System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        public System.Windows.Forms.ToolStripMenuItem narudzbenicaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem otpremnicaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem skladišnicaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem kreiranjeKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ažuriranjeKoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton4;
        private System.Windows.Forms.ToolStripMenuItem uvidUStanjeNaSkladištuToolStripMenuItem;
        public System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem kreiranjeArtikla;
        public System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton5;
        public System.Windows.Forms.ToolStripMenuItem prijavaIzbornik;
        public System.Windows.Forms.ToolStripMenuItem odjavaIzbornik;
        private System.Windows.Forms.ToolStripMenuItem zatvoriToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem izdatnicaToolStripMenuItem;
        private System.Windows.Forms.Label sat;
        private System.Windows.Forms.Timer timer1;
    }
}

