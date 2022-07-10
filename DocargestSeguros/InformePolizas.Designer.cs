
namespace DocargestSeguros
{
    partial class InformePolizas
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
            this.polizasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSeguros = new DocargestSeguros.DataSetSeguros();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.polizasTableAdapter = new DocargestSeguros.DataSetSegurosTableAdapters.polizasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.polizasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSeguros)).BeginInit();
            this.SuspendLayout();
            // 
            // polizasBindingSource
            // 
            this.polizasBindingSource.DataMember = "polizas";
            this.polizasBindingSource.DataSource = this.dataSetSeguros;
            // 
            // dataSetSeguros
            // 
            this.dataSetSeguros.DataSetName = "DataSetSeguros";
            this.dataSetSeguros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.DarkGray;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.polizasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DocargestSeguros.Informes.InformePolizas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // polizasTableAdapter
            // 
            this.polizasTableAdapter.ClearBeforeFill = true;
            // 
            // InformePolizas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "InformePolizas";
            this.Text = "InformePolizas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InformePolizas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.polizasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSeguros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource polizasBindingSource;
        private DataSetSeguros dataSetSeguros;
        private DataSetSegurosTableAdapters.polizasTableAdapter polizasTableAdapter;
    }
}