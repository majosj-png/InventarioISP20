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
    public partial class ProbandoMistralAI : Form
    {
        public ProbandoMistralAI()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            txtRespuesta.Text = "Procesando...";
            Env.Load("../../../");
            var apikey = Environment.GetEnvironmentVariable("APIKEY_MISTRAL");
            //txtRespuesta.Text = $"API Key:{apikey}";
            if (apikey == null)
            {
                txtConsulta.Text = "No se encontró la API Key en las variables de entorno.";
                return;
            }

            if (string.IsNullOrEmpty(txtConsulta.Text))
            {
                txtConsulta.Text = "Por favor ingrese una consulta.";
                return;
            }
            //creamos un hhtpclient para hacer la peticion a la api de gemini con using
            using (var client = new HttpClient())
            {
                var url = "https://api.mistral.ai/v1/chat/completions";
                //Creamos un requesbody con el modelo y la consulta del usuario para mistral
                var requestBody = new
                {
                    model = "mistral-large-latest",
                    messages = new[]
                    {
                        new { role = "user", content = txtConsulta.Text }
                    }
                };
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apikey}");

                var response = await client.PostAsJsonAsync(url, requestBody);
                if (response == null)
                {
                    txtConsulta.Text = "Error en la respuesta de la API.";
                    return;
                }

                ResponseMistral? responseMistral = await response.Content.ReadFromJsonAsync<ResponseMistral>();
                if (responseMistral == null)
                {
                    txtConsulta.Text = "Error al deserializar la respuesta de la API.";
                    return;
                }
                txtRespuesta.Text = responseMistral.choices[0].message.content;
            }
        }
    }
}
