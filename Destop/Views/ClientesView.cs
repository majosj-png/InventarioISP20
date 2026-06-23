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
using System.Windows.Controls;
using System.Windows.Forms;

namespace Desktop.Views
{
    public partial class ClientesView : Form
    {
        ClientesService clientesService = new ClientesService();
        Cliente clienteModificado;
        public ClientesView()
        {
            InitializeComponent();
            LoadClientes();
        }

        private async void LoadClientes()
        {
            var clientes = await clientesService.GetAllAsync();
            if (clientes != null)
            {
                dataGridClientes.DataSource = clientes;
            }
        }

        private void ClearTextBox()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtDireccion.Clear();
        }
        private void labelApellido_Click(object sender, EventArgs e)
        {

        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            var clientes = await clientesService.GetAllWithFilterAsync(txtBusqueda.Text);
            if (clientes != null)
            {
                dataGridClientes.DataSource = clientes;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.tabControlLista.SelectedTab = tabPageAgregarEditar;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //capturamos el cliente seleccionado en el DataGridView
            if (dataGridClientes.CurrentRow != null)
            {
                clienteModificado = (Cliente)dataGridClientes.CurrentRow.DataBoundItem;
                //llenamos los campos del formulario con los datos del cliente seleccionado
                txtNombre.Text = clienteModificado.firstname;
                txtApellido.Text = clienteModificado.lastname;
                txtDni.Text = clienteModificado.dni;
                txtDireccion.Text = clienteModificado.address;
                //cambiamos a la pestaña de agregar/editar
                tabControlLista.SelectedTab = tabPageAgregarEditar;
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            bool clienteGuardado;
            Cliente cliente = new Cliente
            {
                firstname = txtNombre.Text,
                lastname = txtApellido.Text,
                dni = txtDni.Text,
                address = txtDireccion.Text,
            };
            if (clienteModificado == null)
            {
                clienteGuardado = await clientesService.AddClienteAsync(cliente);
            }
            else
            {
                cliente.id = clienteModificado.id;
                cliente.created_at = clienteModificado.created_at;
                clienteGuardado = await clientesService.UpdateClienteAsync(cliente);
            }

            if (clienteGuardado)
            {
                MessageBox.Show("Cliente guardado correctamente");
                LoadClientes();
                ClearTextBox();
                tabControlLista.SelectedTab = tabPageLista;
            }
            else
            {
                MessageBox.Show("Error al guardar el cliente");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.tabControlLista.SelectedTab = tabPageLista;
            ClearTextBox();
            clienteModificado = null;
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            //chequeamos si la tecla presionada es Enter y pulsamos el botón de buscar
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnBuscar.PerformClick();
                e.Handled = true; // Evita que el sonido de "ding" se reproduzca
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            //capturamos el cliente seleccionado en la grilla
            if (dataGridClientes.CurrentRow != null)
            {
                var clienteAEliminar = (Cliente)dataGridClientes.CurrentRow.DataBoundItem;
                //preguntamos si está seguro de eliminar el cliente
                var result = MessageBox.Show($"¿Está seguro de eliminar al cliente {clienteAEliminar.firstname} {clienteAEliminar.lastname}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //eliminamos el cliente
                    var clienteEliminado = await clientesService.DeleteClienteAsync(clienteAEliminar.id);
                    if (clienteEliminado)
                    {
                        MessageBox.Show($"Cliente {clienteAEliminar.firstname} {clienteAEliminar.lastname} eliminado correctamente");
                        LoadClientes();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el cliente");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un cliente para eliminar");
                }

            }
        }
    }
}
