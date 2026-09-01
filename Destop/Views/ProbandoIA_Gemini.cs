using Desktop.Models;
using DotNetEnv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Views
{
    public partial class ProbandoIA_Gemini : Form
    {
        public ProbandoIA_Gemini()
        {
            InitializeComponent();
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            txtRespuesta.Text = "Procesando...";
            Env.Load("../../../");
            var apikey = Environment.GetEnvironmentVariable("APIKEY_GEMINI");
            //txtRespuesta.Text = $"API Key:{apikey}";
            if (apikey == null)
            {
                txtConsulta.Text = "No se encontró la API Key en las variables de entorno.";
                return;
            }

            if (string.IsNullOrEmpty(txtConsulta.Text))
            {
                txtConsulta.Text ="Por favor ingrese una consulta.";
                return;
            }
            //creamos un hhtpclient para hacer la peticion a la api de gemini con using
            using (var client = new HttpClient())
            {
                var url = "https://generativelanguage.googleapis.com/v1beta/interactions";
                var requestBody = new
                {
                    model = "gemini-3.5-flash",
                    input = txtConsulta.Text

                };
                client.DefaultRequestHeaders.Add("x-goog-api-key", $"{apikey}");

                var response = await client.PostAsJsonAsync(url, requestBody);
                if (response == null)
                {
                    txtConsulta.Text = "Error en la respuesta de la API.";
                    return;
                }

                ResponseGemini? responseGemini = await response.Content.ReadFromJsonAsync<ResponseGemini>();
                if (responseGemini == null)
                {
                    txtConsulta.Text = "Error al deserializar la respuesta de la API.";
                    return;
                }
                txtRespuesta.Text = responseGemini.steps[1].content[0].text;
            }
        }
    }
}

