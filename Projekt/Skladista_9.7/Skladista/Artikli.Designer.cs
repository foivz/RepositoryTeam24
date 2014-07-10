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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Artikli));
            this.btnSpremi = new System.Windows.Forms.Button();
            this.pododjelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSifraArt = new System.Windows.Forms.TextBox();
            this.lblSifra = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblCijena = new System.Windows.Forms.Label();
            this.txtMinKolicina = new System.Windows.Forms.TextBox();
            this.lblMinKol = new System.Windows.Forms.Label();
            this.lblVrsta = new System.Windows.Forms.Label();
            this.cmbPododjel = new System.Windows.Forms.ComboBox();
            this.pododjelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pISkladiste2DataSet = new Skladista.PISkladiste2DataSet();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.lblKn = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.pododjelTableAdapter = new Skladista.PISkladiste2DataSetTableAdapters.PododjelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pododjelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pododjelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pISkladiste2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackgroundImage = global::Skladista.Properties.Resources.Floppy;
            this.btnSpremi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSpremi.Location = new System.Drawing.Point(817, 20);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(125, 41);
            this.btnSpremi.TabIndex = 1;
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.button1_Click);
            // 
            // pododjelBindingSource
            // 
            this.pododjelBindingSource.DataSource = typeof(Skladista.Pododjel);
            // 
            // txtSifraArt
            // 
            this.txtSifraArt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifraArt.Enabled = false;
            this.txtSifraArt.Location = new System.Drawing.Point(174, 11);
            this.txtSifraArt.Margin = new System.Windows.Forms.Padding(2);
            this.txtSifraArt.Multiline = true;
            this.txtSifraArt.Name = "txtSifraArt";
            this.txtSifraArt.Size = new System.Drawing.Size(205, 41);
            this.txtSifraArt.TabIndex = 9;
            // 
            // lblSifra
            // 
            this.lblSifra.AutoSize = true;
            this.lblSifra.BackColor = System.Drawing.Color.Transparent;
            this.lblSifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSifra.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSifra.Location = new System.Drawing.Point(16, 20);
            this.lblSifra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(52, 20);
            this.lblSifra.TabIndex = 8;
            this.lblSifra.Text = "Šifra:";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Enabled = false;
            this.txtKolicina.Location = new System.Drawing.Point(588, 11);
            this.txtKolicina.Margin = new System.Windows.Forms.Padding(2);
            this.txtKolicina.Multiline = true;
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(205, 41);
            this.txtKolicina.TabIndex = 11;
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.BackColor = System.Drawing.Color.Transparent;
            this.lblKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKolicina.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblKolicina.Location = new System.Drawing.Point(425, 11);
            this.lblKolicina.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(76, 20);
            this.lblKolicina.TabIndex = 10;
            this.lblKolicina.Text = "Količina:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(174, 76);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(2);
            this.txtNaziv.Multiline = true;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(205, 41);
            this.txtNaziv.TabIndex = 13;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.BackColor = System.Drawing.Color.Transparent;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaziv.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblNaziv.Location = new System.Drawing.Point(16, 87);
            this.lblNaziv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(57, 20);
            this.lblNaziv.TabIndex = 12;
            this.lblNaziv.Text = "Naziv:";
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.BackColor = System.Drawing.Color.Transparent;
            this.lblCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCijena.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCijena.Location = new System.Drawing.Point(16, 190);
            this.lblCijena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(136, 20);
            this.lblCijena.TabIndex = 14;
            this.lblCijena.Text = "Nabavna cijena:";
            // 
            // txtMinKolicina
            // 
            this.txtMinKolicina.Location = new System.Drawing.Point(588, 76);
            this.txtMinKolicina.Margin = new System.Windows.Forms.Padding(2);
            this.txtMinKolicina.Multiline = true;
            this.txtMinKolicina.Name = "txtMinKolicina";
            this.txtMinKolicina.Size = new System.Drawing.Size(205, 41);
            this.txtMinKolicina.TabIndex = 18;
            // 
            // lblMinKol
            // 
            this.lblMinKol.AutoSize = true;
            this.lblMinKol.BackColor = System.Drawing.Color.Transparent;
            this.lblMinKol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMinKol.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMinKol.Location = new System.Drawing.Point(425, 76);
            this.lblMinKol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinKol.Name = "lblMinKol";
            this.lblMinKol.Size = new System.Drawing.Size(159, 20);
            this.lblMinKol.TabIndex = 17;
            this.lblMinKol.Text = "Minimalna količina:";
            // 
            // lblVrsta
            // 
            this.lblVrsta.AutoSize = true;
            this.lblVrsta.BackColor = System.Drawing.Color.Transparent;
            this.lblVrsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVrsta.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblVrsta.Location = new System.Drawing.Point(425, 142);
            this.lblVrsta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVrsta.Name = "lblVrsta";
            this.lblVrsta.Size = new System.Drawing.Size(134, 20);
            this.lblVrsta.TabIndex = 19;
            this.lblVrsta.Text = "Mjerna jedinica:";
            // 
            // cmbPododjel
            // 
            this.cmbPododjel.DataSource = this.pododjelBindingSource1;
            this.cmbPododjel.DisplayMember = "naziv";
            this.cmbPododjel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbPododjel.FormattingEnabled = true;
            this.cmbPododjel.IntegralHeight = false;
            this.cmbPododjel.Location = new System.Drawing.Point(588, 141);
            this.cmbPododjel.Name = "cmbPododjel";
            this.cmbPododjel.Size = new System.Drawing.Size(205, 28);
            this.cmbPododjel.TabIndex = 18;
            this.cmbPododjel.ValueMember = "sifra";
            // 
            // pododjelBindingSource1
            // 
            this.pododjelBindingSource1.DataMember = "Pododjel";
            this.pododjelBindingSource1.DataSource = this.pISkladiste2DataSet;
            // 
            // pISkladiste2DataSet
            // 
            this.pISkladiste2DataSet.DataSetName = "PISkladiste2DataSet";
            this.pISkladiste2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackgroundImage = global::Skladista.Properties.Resources.Close;
            this.btnZatvori.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnZatvori.Location = new System.Drawing.Point(817, 87);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(125, 41);
            this.btnZatvori.TabIndex = 21;
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // lblKn
            // 
            this.lblKn.AutoSize = true;
            this.lblKn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblKn.Location = new System.Drawing.Point(329, 190);
            this.lblKn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKn.Name = "lblKn";
            this.lblKn.Size = new System.Drawing.Size(32, 20);
            this.lblKn.TabIndex = 20;
            this.lblKn.Text = "KN";
            this.lblKn.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(174, 181);
            this.txtCijena.Margin = new System.Windows.Forms.Padding(2);
            this.txtCijena.Multiline = true;
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(136, 29);
            this.txtCijena.TabIndex = 16;
            this.txtCijena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCijena_KeyPress);
            // 
            // pododjelTableAdapter
            // 
            this.pododjelTableAdapter.ClearBeforeFill = true;
            // 
            // Artikli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 453);
            this.Controls.Add(this.lblKn);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.cmbPododjel);
            this.Controls.Add(this.lblVrsta);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtMinKolicina);
            this.Controls.Add(this.lblMinKol);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.txtSifraArt);
            this.Controls.Add(this.lblSifra);
            this.Controls.Add(this.btnSpremi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Artikli";
            this.Text = "Artikli";
            this.Load += new System.EventHandler(this.Artikli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pododjelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pododjelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pISkladiste2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.TextBox txtSifraArt;
        private System.Windows.Forms.Label lblSifra;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.TextBox txtMinKolicina;
        private System.Windows.Forms.Label lblMinKol;
        private System.Windows.Forms.Label lblVrsta;
        private System.Windows.Forms.ComboBox cmbPododjel;
        private System.Windows.Forms.BindingSource pododjelBindingSource;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label lblKn;
        private PISkladiste2DataSet pISkladiste2DataSet;
        private System.Windows.Forms.BindingSource pododjelBindingSource1;
        private PISkladiste2DataSetTableAdapters.PododjelTableAdapter pododjelTableAdapter;
    }
}