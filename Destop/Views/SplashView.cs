using Desktop.Services;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.Reporting.WinForms;
using Services.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Views
{
    public partial class SplashView : Form
    {
        bool dataReady = false;
        bool printReady = false;
        public SplashView()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 99)
            {
                progressBar1.Increment(5);
            }
            if(dataReady && printReady)
            {
                timer1.Enabled = false;
                this.Visible = false;
                var menuPrincipalView = new MenuPrincipalView();
                menuPrincipalView.ShowDialog();
                this.Close();
            }

        }


        private async void SplashView_Activated(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            var dataTask = GetData();
            var printTask = PrintReport();
            await Task.WhenAll(dataTask, printTask);
        }

        private async Task GetData()
        {
            await Task.Run(() =>
            {
                ClientesApiService _clientesApiService = new ClientesApiService();
                var clientes = _clientesApiService.GetAllAsync().Result;
                dataReady = true;
            });
        }

        private async Task PrintReport()
        {
            await Task.Run(() =>
            {
                ReportViewer _report = new ReportViewer();
                _report.LocalReport.ReportEmbeddedResource = "Desktop.Reports.Clientes.rdlc";

                var clientes = new List<Cliente>();
                {
                    new Cliente { Id = 1, Firstname = "Juan", Lastname = "Pérez", Address = "Calle Falsa 123", Dni = "12345678" }
                };

                _report.LocalReport.DataSources.Add(new ReportDataSource("DSClientes", clientes));
                _report.SetDisplayMode(DisplayMode.PrintLayout);
                _report.ZoomMode = ZoomMode.Percent;
                _report.ZoomPercent = 100;

                _report.RefreshReport();
                printReady = true;

            });

        }
    }
}

