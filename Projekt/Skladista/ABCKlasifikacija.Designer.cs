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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PISkladiste2DataSet = new Skladista.PISkladiste2DataSet();
            this.ArtiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ArtiklTableAdapter = new Skladista.PISkladiste2DataSetTableAdapters.ArtiklTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PISkladiste2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArtiklBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ArtiklBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Skladista.ABC.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(691, 442);
            this.reportViewer1.TabIndex = 0;
            // 
            // PISkladiste2DataSet
            // 
            this.PISkladiste2DataSet.DataSetName = "PISkladiste2DataSet";
            this.PISkladiste2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ArtiklBindingSource
            // 
            this.ArtiklBindingSource.DataMember = "Artikl";
            this.ArtiklBindingSource.DataSource = this.PISkladiste2DataSet;
            // 
            // ArtiklTableAdapter
            // 
            this.ArtiklTableAdapter.ClearBeforeFill = true;
            // 
            // ABCKlasifikacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 500);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ABCKlasifikacija";
            this.Text = "ABCKlasifikacija";
            this.Load += new System.EventHandler(this.ABCKlasifikacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PISkladiste2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArtiklBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ArtiklBindingSource;
        private PISkladiste2DataSet PISkladiste2DataSet;
        private PISkladiste2DataSetTableAdapters.ArtiklTableAdapter ArtiklTableAdapter;
    }
}