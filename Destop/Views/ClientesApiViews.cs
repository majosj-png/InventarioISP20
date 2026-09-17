using Services.Models;
using Desktop.Services;
using System.Runtime.CompilerServices;

namespace Desktop.Views
{
    public partial class ClientesApiView : Form
    {
        ClientesApiService clientesApiService = new ClientesApiService();
        LocalidadesApiService localidadesApiService = new LocalidadesApiService();
        Cliente? clienteApiModificado;
        public ClientesApiView()
        {
            InitializeComponent();
            _ = LoadClientes();
            _ = LoadComboLocalidades();
        }

        private async Task LoadComboLocalidades()
        {
           var localidades = await localidadesApiService.GetAllAsync();
            if (localidades != null)
            {
                comboLocalidades.DataSource = localidades;
                comboLocalidades.DisplayMember = "Name";
                comboLocalidades.ValueMember = "Id";
                comboLocalidades.SelectedValue = -1; // No seleccionar ningún elemento por defecto
            }
        }

        private async Task LoadClientes()
        {
            var clientes = await clientesApiService.GetAllAsync();
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

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            var clientes = await clientesApiService.GetAllWithFilterAsync(txtBusqueda.Text);
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
            if (dataGridClientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cliente para modificar");
                return;
            }
            clienteApiModificado = (Cliente)dataGridClientes.CurrentRow.DataBoundItem;
            //llenamos los campos del formulario con los datos del cliente seleccionado
            txtNombre.Text = clienteApiModificado.Firstname;
            txtApellido.Text = clienteApiModificado.Lastname;
            txtDni.Text = clienteApiModificado.Dni;
            txtDireccion.Text = clienteApiModificado.Address;
            if (clienteApiModificado.LocalidadId != null)
            {
                comboLocalidades.SelectedValue = clienteApiModificado.LocalidadId;
            }
            //cambiamos a la pestaña de agregar/editar
            tabControlLista.SelectedTab = tabPageAgregarEditar;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            bool clienteGuardado;
            Cliente cliente = new Cliente
            {
                Firstname = txtNombre.Text,
                Lastname = txtApellido.Text,
                Dni = txtDni.Text,
                Address = txtDireccion.Text,
                LocalidadId = 1 // Asignar un valor predeterminado para LocalidadId
            };
            if (clienteApiModificado == null)
            {
                clienteGuardado = await clientesApiService.AddClienteAsync(cliente);
            }
            else
            {
                cliente.Id = clienteApiModificado.Id;
                cliente.Created_at = clienteApiModificado.Created_at;
                cliente.LocalidadId = clienteApiModificado.LocalidadId;
                clienteGuardado = await clientesApiService.UpdateClienteAsync(cliente);
            }

            if (!clienteGuardado)
            {
                MessageBox.Show("Error al guardar el cliente");
                return;
            }
            MessageBox.Show("Cliente guardado correctamente");
            await LoadClientes();
            ClearTextBox();
            tabControlLista.SelectedTab = tabPageLista;
            clienteApiModificado = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.tabControlLista.SelectedTab = tabPageLista;
            ClearTextBox();
            clienteApiModificado = null;
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
            if (dataGridClientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cliente para eliminar");
                return;
            }
            var clienteAEliminar = (Cliente)dataGridClientes.CurrentRow.DataBoundItem;
            //preguntamos si está seguro de eliminar el cliente
            var result = MessageBox.Show($"¿Está seguro de eliminar al cliente {clienteAEliminar.Firstname} {clienteAEliminar.Lastname}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                //eliminamos el cliente
                var clienteEliminado = await clientesApiService.DeleteClienteAsync((int)clienteAEliminar.Id!);
                if (!clienteEliminado)
                {
                    MessageBox.Show("Error al eliminar el cliente");
                    return;
                }
                MessageBox.Show($"Cliente {clienteAEliminar.Firstname} {clienteAEliminar.Lastname} eliminado correctamente");
                await LoadClientes();
            }

        }


        private async void verEliminadoscheck_CheckedChanged(object sender, EventArgs e)
        {
            txtBusqueda.Enabled = !verEliminadoscheck.Checked;
            btnBuscar.Enabled = !verEliminadoscheck.Checked;
            btnNuevo.Enabled = !verEliminadoscheck.Checked;
            btnModificar.Enabled = !verEliminadoscheck.Checked;
            btnEliminar.Enabled = !verEliminadoscheck.Checked;
            btnRestaurar.Enabled = verEliminadoscheck.Checked;

            if (verEliminadoscheck.Checked)
            {
                await LoadDeleteds();
            }
            else
            {
                await LoadClientes();
            }

        }

        private async Task LoadDeleteds()
        {
            var clientes = await clientesApiService.GetDeletedsAsync();
            if (clientes != null)
            {
                dataGridClientes.DataSource = clientes;
            }
        }

        private async void btnRestaurar_Click(object sender, EventArgs e)
        {
            //capturamos el cliente seleccionado en la grilla
            if (dataGridClientes.CurrentRow != null)
            {
                var clienteARetaurado = (Cliente)dataGridClientes.CurrentRow.DataBoundItem;
                //preguntamos si está seguro de restaurar el cliente
                var result = MessageBox.Show($"¿Está seguro de restaurar al cliente {clienteARetaurado.Firstname} {clienteARetaurado.Lastname}?", "Confirmar restauración", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //restauramos el cliente
                    var clienteRestaurado = await clientesApiService.RestoreClienteAsync(clienteARetaurado.Id);
                    if (clienteRestaurado)
                    {
                        MessageBox.Show($"Cliente {clienteARetaurado.Firstname} {clienteARetaurado.Lastname} restaurado correctamente");
                        await LoadClientes();
                    }
                    else
                    {
                        MessageBox.Show("Error al restaurar el cliente");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un cliente para restaurar");
                }

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
