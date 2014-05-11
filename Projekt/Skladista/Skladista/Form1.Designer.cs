namespace Skladista
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.skladišnicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreiranjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreiranjeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.upravljanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otpremnicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ažuriranjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreiranjeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.upravljanjeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.skladišnicaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ažuriranjeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kreiranjeToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.upravljanjeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.kreiranjeKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ažuriranjeKoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.uvidUStanjeNaSkladištuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.kreiranjeArtikla = new System.Windows.Forms.ToolStripMenuItem();
            this.ažuriranjeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.upravljanjeToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.Prijava = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.toolStripDropDownButton3,
            this.toolStripSeparator3,
            this.toolStripDropDownButton4,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(610, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.skladišnicaToolStripMenuItem,
            this.otpremnicaToolStripMenuItem,
            this.skladišnicaToolStripMenuItem1});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(116, 25);
            this.toolStripDropDownButton1.Text = "Dokumenti";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // skladišnicaToolStripMenuItem
            // 
            this.skladišnicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreiranjeToolStripMenuItem,
            this.kreiranjeToolStripMenuItem1,
            this.upravljanjeToolStripMenuItem});
            this.skladišnicaToolStripMenuItem.Name = "skladišnicaToolStripMenuItem";
            this.skladišnicaToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.skladišnicaToolStripMenuItem.Text = "Narudžbenica";
            // 
            // kreiranjeToolStripMenuItem
            // 
            this.kreiranjeToolStripMenuItem.Name = "kreiranjeToolStripMenuItem";
            this.kreiranjeToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.kreiranjeToolStripMenuItem.Text = "Kreiranje";
            this.kreiranjeToolStripMenuItem.Click += new System.EventHandler(this.kreiranjeToolStripMenuItem_Click);
            // 
            // kreiranjeToolStripMenuItem1
            // 
            this.kreiranjeToolStripMenuItem1.Name = "kreiranjeToolStripMenuItem1";
            this.kreiranjeToolStripMenuItem1.Size = new System.Drawing.Size(159, 26);
            this.kreiranjeToolStripMenuItem1.Text = "Ažuriranje";
            // 
            // upravljanjeToolStripMenuItem
            // 
            this.upravljanjeToolStripMenuItem.Name = "upravljanjeToolStripMenuItem";
            this.upravljanjeToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.upravljanjeToolStripMenuItem.Text = "Upravljanje";
            // 
            // otpremnicaToolStripMenuItem
            // 
            this.otpremnicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ažuriranjeToolStripMenuItem,
            this.kreiranjeToolStripMenuItem2,
            this.upravljanjeToolStripMenuItem1});
            this.otpremnicaToolStripMenuItem.Name = "otpremnicaToolStripMenuItem";
            this.otpremnicaToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.otpremnicaToolStripMenuItem.Text = "Otpremnica";
            // 
            // ažuriranjeToolStripMenuItem
            // 
            this.ažuriranjeToolStripMenuItem.Name = "ažuriranjeToolStripMenuItem";
            this.ažuriranjeToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.ažuriranjeToolStripMenuItem.Text = "Kreiranje";
            // 
            // kreiranjeToolStripMenuItem2
            // 
            this.kreiranjeToolStripMenuItem2.Name = "kreiranjeToolStripMenuItem2";
            this.kreiranjeToolStripMenuItem2.Size = new System.Drawing.Size(159, 26);
            this.kreiranjeToolStripMenuItem2.Text = "Ažuriranje";
            // 
            // upravljanjeToolStripMenuItem1
            // 
            this.upravljanjeToolStripMenuItem1.Name = "upravljanjeToolStripMenuItem1";
            this.upravljanjeToolStripMenuItem1.Size = new System.Drawing.Size(159, 26);
            this.upravljanjeToolStripMenuItem1.Text = "Upravljanje";
            // 
            // skladišnicaToolStripMenuItem1
            // 
            this.skladišnicaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ažuriranjeToolStripMenuItem1,
            this.kreiranjeToolStripMenuItem3,
            this.upravljanjeToolStripMenuItem2});
            this.skladišnicaToolStripMenuItem1.Name = "skladišnicaToolStripMenuItem1";
            this.skladišnicaToolStripMenuItem1.Size = new System.Drawing.Size(176, 26);
            this.skladišnicaToolStripMenuItem1.Text = "Skladišnica";
            this.skladišnicaToolStripMenuItem1.Click += new System.EventHandler(this.skladišnicaToolStripMenuItem1_Click);
            // 
            // ažuriranjeToolStripMenuItem1
            // 
            this.ažuriranjeToolStripMenuItem1.Name = "ažuriranjeToolStripMenuItem1";
            this.ažuriranjeToolStripMenuItem1.Size = new System.Drawing.Size(159, 26);
            this.ažuriranjeToolStripMenuItem1.Text = "Kreiranje";
            // 
            // kreiranjeToolStripMenuItem3
            // 
            this.kreiranjeToolStripMenuItem3.Name = "kreiranjeToolStripMenuItem3";
            this.kreiranjeToolStripMenuItem3.Size = new System.Drawing.Size(159, 26);
            this.kreiranjeToolStripMenuItem3.Text = "Ažuriranje";
            // 
            // upravljanjeToolStripMenuItem2
            // 
            this.upravljanjeToolStripMenuItem2.Name = "upravljanjeToolStripMenuItem2";
            this.upravljanjeToolStripMenuItem2.Size = new System.Drawing.Size(159, 26);
            this.upravljanjeToolStripMenuItem2.Text = "Upravljanje";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreiranjeKorisnikaToolStripMenuItem,
            this.ažuriranjeKoToolStripMenuItem});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(98, 25);
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
            this.toolStripDropDownButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uvidUStanjeNaSkladištuToolStripMenuItem});
            this.toolStripDropDownButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton4.Image")));
            this.toolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            this.toolStripDropDownButton4.Size = new System.Drawing.Size(101, 25);
            this.toolStripDropDownButton4.Text = "Skladište";
            // 
            // uvidUStanjeNaSkladištuToolStripMenuItem
            // 
            this.uvidUStanjeNaSkladištuToolStripMenuItem.Name = "uvidUStanjeNaSkladištuToolStripMenuItem";
            this.uvidUStanjeNaSkladištuToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.uvidUStanjeNaSkladištuToolStripMenuItem.Text = "Uvid u stanje na skladištu";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreiranjeArtikla,
            this.ažuriranjeToolStripMenuItem2,
            this.upravljanjeToolStripMenuItem3});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(80, 25);
            this.toolStripDropDownButton2.Text = "Artikli";
            // 
            // kreiranjeArtikla
            // 
            this.kreiranjeArtikla.Name = "kreiranjeArtikla";
            this.kreiranjeArtikla.Size = new System.Drawing.Size(159, 26);
            this.kreiranjeArtikla.Text = "Kreiranje";
            this.kreiranjeArtikla.Click += new System.EventHandler(this.kreiranjeToolStripMenuItem4_Click);
            // 
            // ažuriranjeToolStripMenuItem2
            // 
            this.ažuriranjeToolStripMenuItem2.Name = "ažuriranjeToolStripMenuItem2";
            this.ažuriranjeToolStripMenuItem2.Size = new System.Drawing.Size(159, 26);
            this.ažuriranjeToolStripMenuItem2.Text = "Ažuriranje";
            this.ažuriranjeToolStripMenuItem2.Click += new System.EventHandler(this.ažuriranjeToolStripMenuItem2_Click_1);
            // 
            // upravljanjeToolStripMenuItem3
            // 
            this.upravljanjeToolStripMenuItem3.Name = "upravljanjeToolStripMenuItem3";
            this.upravljanjeToolStripMenuItem3.Size = new System.Drawing.Size(159, 26);
            this.upravljanjeToolStripMenuItem3.Text = "Upravljanje";
            // 
            // Prijava
            // 
            this.Prijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Prijava.Location = new System.Drawing.Point(268, 267);
            this.Prijava.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Prijava.Name = "Prijava";
            this.Prijava.Size = new System.Drawing.Size(70, 41);
            this.Prijava.TabIndex = 1;
            this.Prijava.Text = "Prijava";
            this.Prijava.UseVisualStyleBackColor = true;
            this.Prijava.Click += new System.EventHandler(this.prijava_u_sustav);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(128, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 117);
            this.label1.TabIndex = 2;
            this.label1.Text = "Skladište";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(240, 246);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 83);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(427, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 61);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(610, 483);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Prijava);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Skladište";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem skladišnicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreiranjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreiranjeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem upravljanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otpremnicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ažuriranjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreiranjeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem upravljanjeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem skladišnicaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ažuriranjeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kreiranjeToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem upravljanjeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem kreiranjeKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ažuriranjeKoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton4;
        private System.Windows.Forms.ToolStripMenuItem uvidUStanjeNaSkladištuToolStripMenuItem;
        private System.Windows.Forms.Button Prijava;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem kreiranjeArtikla;
        private System.Windows.Forms.ToolStripMenuItem ažuriranjeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem upravljanjeToolStripMenuItem3;
        private System.Windows.Forms.Button button1;
    }
}

