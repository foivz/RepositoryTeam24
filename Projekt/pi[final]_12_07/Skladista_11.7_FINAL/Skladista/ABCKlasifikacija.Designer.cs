namespace Skladista
{
    partial class ABCKlasifikacija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABCKlasifikacija));
            this.dgvABC = new System.Windows.Forms.DataGridView();
            this.naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukupno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postotak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postotakZbroj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klasifikacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvABC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvABC
            // 
            this.dgvABC.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvABC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvABC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.naziv,
            this.cijena,
            this.kolicina,
            this.ukupno,
            this.postotak,
            this.postotakZbroj,
            this.klasifikacija});
            this.dgvABC.GridColor = System.Drawing.Color.CadetBlue;
            this.dgvABC.Location = new System.Drawing.Point(1, 1);
            this.dgvABC.Name = "dgvABC";
            this.dgvABC.ReadOnly = true;
            this.dgvABC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvABC.Size = new System.Drawing.Size(814, 478);
            this.dgvABC.TabIndex = 2;
            // 
            // naziv
            // 
            this.naziv.HeaderText = "Naziv";
            this.naziv.Name = "naziv";
            this.naziv.ReadOnly = true;
            this.naziv.Width = 150;
            // 
            // cijena
            // 
            this.cijena.HeaderText = "Cijena po jedinici";
            this.cijena.Name = "cijena";
            this.cijena.ReadOnly = true;
            // 
            // kolicina
            // 
            this.kolicina.HeaderText = "Količina";
            this.kolicina.Name = "kolicina";
            this.kolicina.ReadOnly = true;
            // 
            // ukupno
            // 
            this.ukupno.HeaderText = "Vrijednost zaliha";
            this.ukupno.Name = "ukupno";
            this.ukupno.ReadOnly = true;
            this.ukupno.Width = 120;
            // 
            // postotak
            // 
            this.postotak.HeaderText = "% zaliha";
            this.postotak.Name = "postotak";
            this.postotak.ReadOnly = true;
            // 
            // postotakZbroj
            // 
            this.postotakZbroj.HeaderText = "Ukupni %";
            this.postotakZbroj.Name = "postotakZbroj";
            this.postotakZbroj.ReadOnly = true;
            // 
            // klasifikacija
            // 
            this.klasifikacija.HeaderText = "ABC klasifikacija";
            this.klasifikacija.Name = "klasifikacija";
            this.klasifikacija.ReadOnly = true;
            // 
            // ABCKlasifikacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 491);
            this.Controls.Add(this.dgvABC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ABCKlasifikacija";
            this.Text = "ABC klasifikacija";
            this.Load += new System.EventHandler(this.ABCKlasifikacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvABC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvABC;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn ukupno;
        private System.Windows.Forms.DataGridViewTextBoxColumn postotak;
        private System.Windows.Forms.DataGridViewTextBoxColumn postotakZbroj;
        private System.Windows.Forms.DataGridViewTextBoxColumn klasifikacija;

    }
}