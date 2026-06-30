using Desktop.Models;
using Desktop.Services;
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
    public partial class TiendaView : Form
    {
        TiendasServices tiendasService = new TiendasServices();
        Tienda tiendasModificado;

        public TiendaView()
        {
            InitializeComponent();
            LoadTiendas();
        }

        private async void LoadTiendas()
        {
            var tiendas = await tiendasService.GetAllAsync();
            if (tiendas != null)
            {
                dataGridTiendas.DataSource = tiendas;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            var tiendas = await tiendasService.GetAllWithFilterAsync(txtBusqueda.Text);
            if (tiendas != null)
            {
                dataGridTiendas.DataSource = tiendas;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.tabControlLista.SelectedTab = tabPageAgregarEditar;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //capturamos la tienda seleccionada en el DataGridView
            if (dataGridTiendas.CurrentRow != null)
            {
                tiendasModificado = (Tienda)dataGridTiendas.CurrentRow.DataBoundItem;
                //llenamos los campos del formulario con los datos de la tienda seleccionada
                txtMarca.Text = tiendasModificado.marca;
                txtPrecio.Text = tiendasModificado.precio.ToString();
                txtTipoCliente.Text = tiendasModificado.tipo_cliente;
                txtTipoArticulo.Text = tiendasModificado.tipo_articulo;
                txtEstacion.Text = tiendasModificado.estacion;
                //cambiamos a la pestaña de agregar/editar
                tabControlLista.SelectedTab = tabPageAgregarEditar;
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            //capturamos la tienda seleccionada en el DataGridView
            if (dataGridTiendas.CurrentRow != null)
            {
                var tiendaAEliminar = (Tienda)dataGridTiendas.CurrentRow.DataBoundItem;
                // Preguntamos al usuario si está seguro de eliminar la tienda
                var confirmResult = MessageBox.Show($"¿Está seguro de eliminar la tienda {tiendaAEliminar.marca}?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    bool borradoOk = await tiendasService.DeleteTiendaAsync(tiendaAEliminar.id);
                    if (!borradoOk)
                    {
                        tabControlLista.SelectedTab = tabPageLista;
                    }
                    else
                    {
                        MessageBox.Show($"Tienda {tiendaAEliminar.marca} eliminada correctamente");
                        LoadTiendas();
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.tabControlLista.SelectedTab = tabPageLista;
            ClearTextBox();
            tiendasModificado = null;
        }

        private void ClearTextBox()
        {
            txtMarca.Clear();
            txtPrecio.Clear();
            txtTipoCliente.Clear();
            txtTipoArticulo.Clear();
            txtEstacion.Clear();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            bool tiendaGuardado;
            Tienda tienda = new Tienda
            {
                marca = txtMarca.Text,
                precio = float.Parse(txtPrecio.Text),
                tipo_cliente = txtTipoCliente.Text,
                tipo_articulo = txtTipoArticulo.Text,
                estacion = txtEstacion.Text,
            };
            if (tiendasModificado == null)
            {
                tiendaGuardado = await tiendasService.AddTiendaAsync(tienda);
            }
            else
            {
                tienda.id = tiendasModificado.id;
                tienda.created_at = tiendasModificado.created_at;
                tiendaGuardado = await tiendasService.UpdateTiendaAsync(tienda);
            }

            if (tiendaGuardado)
            {
                MessageBox.Show("Tienda guardada correctamente");
                LoadTiendas();
                ClearTextBox();
                tabControlLista.SelectedTab = tabPageLista;
            }
            else
            {
                MessageBox.Show("Error al guardar el cliente");
            }
        }
    }
}
