using Desktop.Services;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.ViewReports
{
    public partial class ClientesViewReports : Form
    {
        ReportViewer _report;
        ClientesApiService _clientesApiService = new ClientesApiService();
        public ClientesViewReports()
        {
            InitializeComponent();
            _report = new ReportViewer();
            _report.Dock = DockStyle.Fill;
            this.Controls.Add(_report);
        }

        private async void ClientesViewReports_Load(object sender, EventArgs e)
        {
            _report.LocalReport.ReportEmbeddedResource = "Desktop.Reports.Clientes.rdlc";

            var clientes = await _clientesApiService.GetAllAsync();
            _report.LocalReport.DataSources.Add(new ReportDataSource("DSClientes", clientes));
            _report.SetDisplayMode(DisplayMode.PrintLayout);
            _report.ZoomMode = ZoomMode.Percent;
            _report.ZoomPercent = 100;

            _report.RefreshReport();
        }
    }
}
