namespace Deber
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.clientDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetReporting = new Deber.DataSet.DataSetReporting();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.txt_buscarDni = new System.Windows.Forms.TextBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.clientDataTableAdapter = new Deber.DataSet.DataSetReportingTableAdapters.ClientDataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReporting)).BeginInit();
            this.SuspendLayout();
            // 
            // clientDataBindingSource
            // 
            this.clientDataBindingSource.DataMember = "ClientData";
            this.clientDataBindingSource.DataSource = this.dataSetReporting;
            // 
            // dataSetReporting
            // 
            this.dataSetReporting.DataSetName = "DataSetReporting";
            this.dataSetReporting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetClient";
            reportDataSource1.Value = this.clientDataBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Deber.ClientReporting.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 64);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(692, 254);
            this.reportViewer1.TabIndex = 0;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(344, 26);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 1;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_report
            // 
            this.btn_report.Location = new System.Drawing.Point(533, 335);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(76, 27);
            this.btn_report.TabIndex = 2;
            this.btn_report.Text = "Reporte";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // txt_buscarDni
            // 
            this.txt_buscarDni.Location = new System.Drawing.Point(132, 26);
            this.txt_buscarDni.Name = "txt_buscarDni";
            this.txt_buscarDni.Size = new System.Drawing.Size(161, 20);
            this.txt_buscarDni.TabIndex = 4;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(43, 340);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(78, 22);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // clientDataTableAdapter
            // 
            this.clientDataTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 374);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.txt_buscarDni);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReporting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.TextBox txt_buscarDni;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.BindingSource clientDataBindingSource;
        private DataSet.DataSetReporting dataSetReporting;
        private DataSet.DataSetReportingTableAdapters.ClientDataTableAdapter clientDataTableAdapter;
    }
}

