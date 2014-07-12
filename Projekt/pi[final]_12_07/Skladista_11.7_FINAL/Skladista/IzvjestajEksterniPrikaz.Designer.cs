namespace Skladista
{
    partial class IzvjestajEksterniPrikaz
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IzvjestajEksterniPrikaz));
            this.eksterniIzvjestajBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PISkladiste2DataSet = new Skladista.PISkladiste2DataSet();
            this.eksterniStavkeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.eksterniIzvjestajTableAdapter = new Skladista.PISkladiste2DataSetTableAdapters.eksterniIzvjestajTableAdapter();
            this.eksterniStavkeTableAdapter = new Skladista.PISkladiste2DataSetTableAdapters.eksterniStavkeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.eksterniIzvjestajBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PISkladiste2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eksterniStavkeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // eksterniIzvjestajBindingSource
            // 
            this.eksterniIzvjestajBindingSource.DataMember = "eksterniIzvjestaj";
            this.eksterniIzvjestajBindingSource.DataSource = this.PISkladiste2DataSet;
            // 
            // PISkladiste2DataSet
            // 
            this.PISkladiste2DataSet.DataSetName = "PISkladiste2DataSet";
            this.PISkladiste2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eksterniStavkeBindingSource
            // 
            this.eksterniStavkeBindingSource.DataMember = "eksterniStavke";
            this.eksterniStavkeBindingSource.DataSource = this.PISkladiste2DataSet;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.eksterniIzvjestajBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.eksterniStavkeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Skladista.EksterniIzvjestaj.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(804, 592);
            this.reportViewer1.TabIndex = 0;
            // 
            // eksterniIzvjestajTableAdapter
            // 
            this.eksterniIzvjestajTableAdapter.ClearBeforeFill = true;
            // 
            // eksterniStavkeTableAdapter
            // 
            this.eksterniStavkeTableAdapter.ClearBeforeFill = true;
            // 
            // IzvjestajEksterniPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 604);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IzvjestajEksterniPrikaz";
            this.Text = "Izvještaj - eksterni dokument";
            this.Load += new System.EventHandler(this.IzvjestajEksterniPrikaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eksterniIzvjestajBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PISkladiste2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eksterniStavkeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource eksterniIzvjestajBindingSource;
        private PISkladiste2DataSet PISkladiste2DataSet;
        private System.Windows.Forms.BindingSource eksterniStavkeBindingSource;
        private PISkladiste2DataSetTableAdapters.eksterniIzvjestajTableAdapter eksterniIzvjestajTableAdapter;
        private PISkladiste2DataSetTableAdapters.eksterniStavkeTableAdapter eksterniStavkeTableAdapter;
    }
}