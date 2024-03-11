using Deber.DataSet;
using Deber.DataSet.DataSetReportingTableAdapters;
using System;
using System.IO;
using System.Windows.Forms;

namespace Deber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // para q aparesca el diceño del reporte
        private void Form1_Load(object sender, EventArgs e)
        {
            //string dni = txt_buscarDni.Text;
            //this.clientDataTableAdapter.Fill(this.dataSetReporting.ClientData, dni);
            //this.reportViewer1.RefreshReport();
        }

        //buscar por dni
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string dni = txt_buscarDni.Text;

            if (!string.IsNullOrEmpty(dni))
            {
                try
                {
                    DataSetReporting dataSet = new DataSetReporting();

                    ClientDataTableAdapter clientDataTableAdapter = new ClientDataTableAdapter();

                    clientDataTableAdapter.Fill(dataSet.ClientData, dni);

                    reportViewer1.Reset();
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetClient", dataSet.Tables["ClientData"]));


                    reportViewer1.LocalReport.ReportPath = @"C:\Users\rober\Escritorio\semaestre\programacion visual\ReportViewer\Deber\ClientReporting.rdlc";

                    reportViewer1.RefreshReport();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar en la base de datos: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un valor para buscar.");
            }

        }
        // para exportar el reporte en pdf
        private void btn_report_Click(object sender, EventArgs e)
        {
            try
            {
                string deviceInfo = "<DeviceInfo><OutputFormat>PDF</OutputFormat></DeviceInfo>";
                byte[] bytes = reportViewer1.LocalReport.Render("PDF", deviceInfo);

                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Reporte.pdf");
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    fs.Write(bytes, 0, bytes.Length);
                }

                MessageBox.Show("El informe se ha guardado como PDF en el escritorio.", "Informe Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el informe como PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cerrar el formulario actual
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
