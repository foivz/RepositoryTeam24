namespace Skladista
{
    partial class Prijava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prijava));
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKorisnickoIme.Location = new System.Drawing.Point(186, 54);
            this.txtKorisnickoIme.Margin = new System.Windows.Forms.Padding(2);
            this.txtKorisnickoIme.Multiline = true;
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(198, 41);
            this.txtKorisnickoIme.TabIndex = 0;
            this.txtKorisnickoIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLozinka.Location = new System.Drawing.Point(186, 113);
            this.txtLozinka.Margin = new System.Windows.Forms.Padding(2);
            this.txtLozinka.Multiline = true;
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(198, 41);
            this.txtLozinka.TabIndex = 1;
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.BackColor = System.Drawing.Color.Transparent;
            this.lblKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKorisnickoIme.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(44, 54);
            this.lblKorisnickoIme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(129, 20);
            this.lblKorisnickoIme.TabIndex = 2;
            this.lblKorisnickoIme.Text = "Korisničko ime:";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.BackColor = System.Drawing.Color.Transparent;
            this.lblLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLozinka.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblLozinka.Location = new System.Drawing.Point(44, 113);
            this.lblLozinka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(76, 20);
            this.lblLozinka.TabIndex = 3;
            this.lblLozinka.Text = "Lozinka:";
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundImage = global::Skladista.Properties.Resources.login;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnLogin.Location = new System.Drawing.Point(107, 202);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(81, 52);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackgroundImage = global::Skladista.Properties.Resources.Close1;
            this.btnZatvori.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnZatvori.Location = new System.Drawing.Point(222, 202);
            this.btnZatvori.Margin = new System.Windows.Forms.Padding(2);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 52);
            this.btnZatvori.TabIndex = 6;
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.button2_Click);
            // 
            // Prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(428, 294);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorisnickoIme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Prijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.Load += new System.EventHandler(this.Prijava_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnZatvori;
    }
}