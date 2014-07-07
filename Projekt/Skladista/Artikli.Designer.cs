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
            this.button1 = new System.Windows.Forms.Button();
            this.pododjelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSifraKor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMinKolicina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbPododjel = new System.Windows.Forms.ComboBox();
            this.pododjelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pISkladiste2DataSet = new Skladista.PISkladiste2DataSet();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.pododjelTableAdapter = new Skladista.PISkladiste2DataSetTableAdapters.PododjelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pododjelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pododjelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pISkladiste2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Skladista.Properties.Resources.Floppy;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(817, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 41);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pododjelBindingSource
            // 
            this.pododjelBindingSource.DataSource = typeof(Skladista.Pododjel);
            // 
            // txtSifraKor
            // 
            this.txtSifraKor.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(16, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Šifra:";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(588, 11);
            this.txtKolicina.Margin = new System.Windows.Forms.Padding(2);
            this.txtKolicina.Multiline = true;
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(205, 41);
            this.txtKolicina.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(425, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Količina:";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(16, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Naziv:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(16, 190);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nabavna cijena:";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(425, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Minimalna količina:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(425, 142);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Mjerna jedinica:";
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(329, 190);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "KN";
            this.label10.Click += new System.EventHandler(this.label10_Click);
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
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.cmbPododjel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtMinKolicina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSifraKor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
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

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSifraKor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMinKolicina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbPododjel;
        private System.Windows.Forms.BindingSource pododjelBindingSource;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label label10;
        private PISkladiste2DataSet pISkladiste2DataSet;
        private System.Windows.Forms.BindingSource pododjelBindingSource1;
        private PISkladiste2DataSetTableAdapters.PododjelTableAdapter pododjelTableAdapter;
    }
}