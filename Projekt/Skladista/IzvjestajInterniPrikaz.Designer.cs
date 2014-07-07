namespace Skladista
{
    partial class IzvjestajInterniPrikaz
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
            this.InterniIzvjestajBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PISkladiste2DataSet = new Skladista.PISkladiste2DataSet();
            this.InterniStvakeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.InterniIzvjestajTableAdapter = new Skladista.PISkladiste2DataSetTableAdapters.InterniIzvjestajTableAdapter();
            this.InterniStvakeTableAdapter = new Skladista.PISkladiste2DataSetTableAdapters.InterniStvakeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.InterniIzvjestajBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PISkladiste2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InterniStvakeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // InterniIzvjestajBindingSource
            // 
            this.InterniIzvjestajBindingSource.DataMember = "InterniIzvjestaj";
            this.InterniIzvjestajBindingSource.DataSource = this.PISkladiste2DataSet;
            // 
            // PISkladiste2DataSet
            // 
            this.PISkladiste2DataSet.DataSetName = "PISkladiste2DataSet";
            this.PISkladiste2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // InterniStvakeBindingSource
            // 
            this.InterniStvakeBindingSource.DataMember = "InterniStvake";
            this.InterniStvakeBindingSource.DataSource = this.PISkladiste2DataSet;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetInterni";
            reportDataSource1.Value = this.InterniIzvjestajBindingSource;
            reportDataSource2.Name = "DataSetStavke";
            reportDataSource2.Value = this.InterniStvakeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Skladista.interniIzvjestaj.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(882, 509);
            this.reportViewer1.TabIndex = 0;
            // 
            // InterniIzvjestajTableAdapter
            // 
            this.InterniIzvjestajTableAdapter.ClearBeforeFill = true;
            // 
            // InterniStvakeTableAdapter
            // 
            this.InterniStvakeTableAdapter.ClearBeforeFill = true;
            // 
            // IzvjestajInterniPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 509);
            this.Controls.Add(this.reportViewer1);
            this.Name = "IzvjestajInterniPrikaz";
            this.Text = "IzvjestajInterniPrikaz";
            this.Load += new System.EventHandler(this.IzvjestajInterniPrikaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InterniIzvjestajBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PISkladiste2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InterniStvakeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource InterniIzvjestajBindingSource;
        private PISkladiste2DataSet PISkladiste2DataSet;
        private System.Windows.Forms.BindingSource InterniStvakeBindingSource;
        private PISkladiste2DataSetTableAdapters.InterniIzvjestajTableAdapter InterniIzvjestajTableAdapter;
        private PISkladiste2DataSetTableAdapters.InterniStvakeTableAdapter InterniStvakeTableAdapter;
    }
}