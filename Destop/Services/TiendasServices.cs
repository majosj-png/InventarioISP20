using Desktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Desktop.Services
{
    public class TiendasServices
    {
        HttpClient httpClient;
        const string urlApi = "https://mayclnkieddfcmtdlcuc.supabase.co/rest/v1/Articulos"; // Endpoint

        public TiendasServices()
        {
            // Inicializar el HttpClient y configurar la base address y los headers necesarios
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(urlApi);
            // agregar la apikey y el header de aceptacion de json
            httpClient.DefaultRequestHeaders.Add("apikey", "sb_publishable_G3DAS1w88uUU4UQouTM-FQ_hXlJCboc");
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        public async Task<List<Tienda>?> GetAllAsync()
        {
            try
            {
                var response = await httpClient.GetAsync(urlApi);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var tiendas = System.Text.Json.JsonSerializer.Deserialize<List<Models.Tienda>>(json);
                    return tiendas;
                }
                else
                {
                    throw new Exception("Error al obtener las tiendas" + response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener tiendas desde la Api: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<List<Tienda>?> GetAllWithFilterAsync(string filter)
        {
            try
            {
                string filtrosupabase = $"?or=(marca.ilike.*{filter}*, tipo_cliente.ilike.*{filter}*, tipo_articulo.ilike.*{filter}*, estacion.ilike.*{filter}*)";
                var response = await httpClient.GetAsync(filtrosupabase);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var tiendas = System.Text.Json.JsonSerializer.Deserialize<List<Models.Tienda>>(json);
                    return tiendas;
                }
                else
                {
                    throw new Exception("Error al obtener las tiendas" + response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener tiendas desde la Api: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<bool> AddTiendaAsync(Tienda tienda)
        {
            try
            {
                // Configuramos las opciones de serialización para ignorar propiedades nulas y hacer que la búsqueda de propiedades sea insensible a mayúsculas
                var options = new JsonSerializerOptions
                {
                    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                    PropertyNameCaseInsensitive = true,
                };

                var json = JsonSerializer.Serialize(tienda, options);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync("", content);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Error al crear la tienda: " + response.ReasonPhrase);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la tienda desde la Api: " + ex.Message);
                return false;
            }

        }

        public async Task<bool> UpdateTiendaAsync(Tienda tienda)
        {
            try
            {
                // Configuramos las opciones de serialización para ignorar propiedades nulas y hacer que la búsqueda de propiedades sea insensible a mayúsculas
                var options = new JsonSerializerOptions
                {
                    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                    PropertyNameCaseInsensitive = true,
                };

                var json = JsonSerializer.Serialize(tienda, options);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                string urlUpdate = $"?id=eq.{tienda.id}";
                var response = await httpClient.PutAsync(urlUpdate, content);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Error al actualizar la tienda: " + response.ReasonPhrase);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la tienda desde la Api: " + ex.Message);
                return false;
            }
        }

        public async Task<bool> DeleteTiendaAsync(int? id)
        {
            try
            {
                string urlDelete = $"?id=eq.{id}";
                var response = httpClient.DeleteAsync(urlDelete).Result;
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Error al eliminar la tienda: " + response.ReasonPhrase);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la tienda desde la Api: " + ex.Message);
                return false;
            }
        }
    }
}
