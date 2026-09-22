using Services.Models;
using Desktop.Services;

namespace Desktop.Views
{
    public partial class LocalidadesApiView : Form
    {
        LocalidadesApiService localidadesApiService = new LocalidadesApiService();
        ProvinciasApiService provinciasApiService = new ProvinciasApiService();
        PaisesApiService paisesApiService = new PaisesApiService();
        Localidad? localidadModificada;
        public LocalidadesApiView()
        {
            InitializeComponent();
            _ = LoadLocalidades();
            _ = LoadComboProvincias();
            _ = LoadComboPaises();
        }

        private async Task LoadComboPaises()
        {
            var paises = await paisesApiService.GetAllAsync();
            if (paises != null)
            {
                comboPaises.DisplayMember = "Name";
                comboPaises.ValueMember = "Id";
                comboPaises.DataSource = paises;
                comboPaises.SelectedValue = -1; // No seleccionar ningún elemento por defecto
            }
        }

        private async Task LoadComboProvincias()
        {
           var provincias = await provinciasApiService.GetAllAsync();
            if (provincias != null)
            {
                comboProvincias.DisplayMember = "Name";
                comboProvincias.ValueMember = "Id";
                comboProvincias.DataSource = provincias;
                comboProvincias.SelectedValue = -1; // No seleccionar ningún elemento por defecto
            }
        }

        private async Task LoadLocalidades()
        {
            var localidades = await localidadesApiService.GetAllAsync();
            if (localidades != null)
            {
                dataGridLocalidades.DataSource = localidades;
            }
        }

        private void ClearTextBox()
        {
            txtNombre.Clear();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            var localidades = await localidadesApiService.GetAllWithFilterAsync(txtBusqueda.Text);
            if (localidades != null)
            {
                dataGridLocalidades.DataSource = localidades;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            this.tabControlLista.SelectedTab = tabPageAgregarEditar;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //capturamos el cliente seleccionado en el DataGridView
            if (dataGridLocalidades.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una localidad para modificar");
                return;
            }
            localidadModificada = (Localidad)dataGridLocalidades.CurrentRow.DataBoundItem;
            //llenamos los campos del formulario con los datos de la localidad seleccionada
            txtNombre.Text = localidadModificada.Name;
            
            if (localidadModificada.ProvinciaId != 0)
            {
                comboProvincias.SelectedValue = localidadModificada.ProvinciaId;
            }
            //cambiamos a la pestaña de agregar/editar
            tabControlLista.SelectedTab = tabPageAgregarEditar;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            bool localidadGuardada;
            Localidad localidad = new Localidad
            {
                Name = txtNombre.Text,
                ProvinciaId = comboProvincias.SelectedValue != null ? (int)comboProvincias.SelectedValue : 0,
                
            };
            if (localidadModificada == null)
            {
                localidadGuardada = await localidadesApiService.AddLocalidadAsync(localidad);
            }
            else
            {
                localidad.Id = localidadModificada.Id;
                localidad.ProvinciaId = localidadModificada.ProvinciaId;
                localidadGuardada = await localidadesApiService.UpdateLocalidadAsync(localidad);
            }

            if (!localidadGuardada)
            {
                MessageBox.Show("Error al guardar la localidad");
                return;
            }
            MessageBox.Show("Localidad guardada correctamente");
            await LoadLocalidades();
            ClearTextBox();
            tabControlLista.SelectedTab = tabPageLista;
            localidadModificada = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.tabControlLista.SelectedTab = tabPageLista;
            ClearTextBox();
            localidadModificada = null;
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
            //capturamos a la localidad seleccionada en la grilla
            if (dataGridLocalidades.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una localidad para eliminar");
                return;
            }
            var localidadAEliminar = (Localidad)dataGridLocalidades.CurrentRow.DataBoundItem;
            //preguntamos si está seguro de eliminar a la localidad
            var result = MessageBox.Show($"¿Está seguro de eliminar a la localidad {localidadAEliminar.Name}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                //eliminamos a la localidad
                var localidadEliminada = await localidadesApiService.DeleteLocalidadAsync((int)localidadAEliminar.Id!);
                if (!localidadEliminada)
                {
                    MessageBox.Show("Error al eliminar a la localidad");
                    return;
                }
                MessageBox.Show($"Localidad {localidadAEliminar.Name} eliminada correctamente");
                await LoadLocalidades();
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
                await LoadLocalidades();
            }

        }

        private async Task LoadDeleteds()
        {
            var localidades = await localidadesApiService.GetDeletedsAsync();
            if (localidades != null)
            {
                dataGridLocalidades.DataSource = localidades;
            }
        }

        private async void btnRestaurar_Click(object sender, EventArgs e)
        {
            //capturamos las localidades seleccionadas en la grilla
            if (dataGridLocalidades.CurrentRow != null)
            {
                var localidadARetaurado = (Localidad)dataGridLocalidades.CurrentRow.DataBoundItem;
                //preguntamos si está seguro de restaurar la localidad
                var result = MessageBox.Show($"¿Está seguro de restaurar la localidad {localidadARetaurado.Name}?", "Confirmar restauración", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //restauramos la localidad
                    var localidadRestaurada = await localidadesApiService.RestoreLocalidadAsync(localidadARetaurado.Id);
                    if (localidadRestaurada)
                    {
                        MessageBox.Show($"Localidad {localidadARetaurado.Name} restaurada correctamente");
                        await LoadLocalidades();
                    }
                    else
                    {
                        MessageBox.Show("Error al restaurar la localidad");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una localidad para restaurar");
                }

            }

        }
    }
}
