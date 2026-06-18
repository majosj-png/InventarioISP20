namespace Desktop.Views
{
    partial class ClientesView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelClientes = new Label();
            tabControlLista = new TabControl();
            tabPageLista = new TabPage();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnModificar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            dataGridClientes = new DataGridView();
            txtBusqueda = new TextBox();
            labelBuscar = new Label();
            tabPageAgregarEditar = new TabPage();
            txtDireccion = new TextBox();
            txtDni = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            labelApellido = new Label();
            labelNombre = new Label();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            tabControlLista.SuspendLayout();
            tabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridClientes).BeginInit();
            tabPageAgregarEditar.SuspendLayout();
            SuspendLayout();
            // 
            // labelClientes
            // 
            labelClientes.AutoSize = true;
            labelClientes.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic);
            labelClientes.Location = new Point(27, 19);
            labelClientes.Name = "labelClientes";
            labelClientes.Size = new Size(94, 30);
            labelClientes.TabIndex = 0;
            labelClientes.Text = "Clientes";
            // 
            // tabControlLista
            // 
            tabControlLista.Controls.Add(tabPageLista);
            tabControlLista.Controls.Add(tabPageAgregarEditar);
            tabControlLista.Location = new Point(12, 52);
            tabControlLista.Name = "tabControlLista";
            tabControlLista.SelectedIndex = 0;
            tabControlLista.Size = new Size(783, 394);
            tabControlLista.TabIndex = 1;
            // 
            // tabPageLista
            // 
            tabPageLista.Controls.Add(btnBuscar);
            tabPageLista.Controls.Add(btnEliminar);
            tabPageLista.Controls.Add(btnModificar);
            tabPageLista.Controls.Add(btnNuevo);
            tabPageLista.Controls.Add(dataGridClientes);
            tabPageLista.Controls.Add(txtBusqueda);
            tabPageLista.Controls.Add(labelBuscar);
            tabPageLista.Location = new Point(4, 24);
            tabPageLista.Name = "tabPageLista";
            tabPageLista.Padding = new Padding(3);
            tabPageLista.Size = new Size(775, 366);
            tabPageLista.TabIndex = 0;
            tabPageLista.Text = "Lista";
            tabPageLista.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.Location = new Point(680, 38);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.Location = new Point(677, 175);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnModificar.IconColor = Color.Black;
            btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnModificar.Location = new Point(677, 129);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.None;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevo.Location = new Point(677, 80);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // dataGridClientes
            // 
            dataGridClientes.AllowUserToAddRows = false;
            dataGridClientes.AllowUserToDeleteRows = false;
            dataGridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridClientes.Location = new Point(18, 92);
            dataGridClientes.Name = "dataGridClientes";
            dataGridClientes.ReadOnly = true;
            dataGridClientes.Size = new Size(631, 269);
            dataGridClientes.TabIndex = 3;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(68, 39);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(581, 23);
            txtBusqueda.TabIndex = 1;
            // 
            // labelBuscar
            // 
            labelBuscar.AutoSize = true;
            labelBuscar.Location = new Point(11, 43);
            labelBuscar.Name = "labelBuscar";
            labelBuscar.Size = new Size(42, 15);
            labelBuscar.TabIndex = 0;
            labelBuscar.Text = "Buscar";
            // 
            // tabPageAgregarEditar
            // 
            tabPageAgregarEditar.Controls.Add(txtDireccion);
            tabPageAgregarEditar.Controls.Add(txtDni);
            tabPageAgregarEditar.Controls.Add(txtApellido);
            tabPageAgregarEditar.Controls.Add(txtNombre);
            tabPageAgregarEditar.Controls.Add(label4);
            tabPageAgregarEditar.Controls.Add(label3);
            tabPageAgregarEditar.Controls.Add(labelApellido);
            tabPageAgregarEditar.Controls.Add(labelNombre);
            tabPageAgregarEditar.Controls.Add(btnCancelar);
            tabPageAgregarEditar.Controls.Add(btnGuardar);
            tabPageAgregarEditar.Location = new Point(4, 24);
            tabPageAgregarEditar.Name = "tabPageAgregarEditar";
            tabPageAgregarEditar.Padding = new Padding(3);
            tabPageAgregarEditar.Size = new Size(775, 366);
            tabPageAgregarEditar.TabIndex = 1;
            tabPageAgregarEditar.Text = "Agregar/Editar";
            tabPageAgregarEditar.UseVisualStyleBackColor = true;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(102, 218);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(453, 23);
            txtDireccion.TabIndex = 9;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(102, 144);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(453, 23);
            txtDni.TabIndex = 8;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(102, 87);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(453, 23);
            txtApellido.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(102, 43);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(453, 23);
            txtNombre.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 218);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 5;
            label4.Text = "Dirección";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 152);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 4;
            label3.Text = "DNI";
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Location = new Point(30, 90);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(51, 15);
            labelApellido.TabIndex = 3;
            labelApellido.Text = "Apellido";
            labelApellido.Click += labelApellido_Click;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(30, 43);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(51, 15);
            labelNombre.TabIndex = 2;
            labelNombre.Text = "Nombre";
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.Location = new Point(680, 90);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.Location = new Point(680, 29);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // ClientesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlLista);
            Controls.Add(labelClientes);
            Name = "ClientesView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            tabControlLista.ResumeLayout(false);
            tabPageLista.ResumeLayout(false);
            tabPageLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridClientes).EndInit();
            tabPageAgregarEditar.ResumeLayout(false);
            tabPageAgregarEditar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelClientes;
        private TabControl tabControlLista;
        private TabPage tabPageLista;
        private TabPage tabPageAgregarEditar;
        private TextBox txtBusqueda;
        private Label labelBuscar;
        private DataGridView dataGridClientes;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private Label label4;
        private Label label3;
        private Label labelApellido;
        private Label labelNombre;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private TextBox txtNombre;
        private TextBox txtDireccion;
        private TextBox txtDni;
        private TextBox txtApellido;
        private FontAwesome.Sharp.IconButton btnBuscar;
    }
}