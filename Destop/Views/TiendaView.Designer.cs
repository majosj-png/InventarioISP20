namespace Desktop.Views
{
    partial class TiendaView
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
            tabControlLista = new TabControl();
            tabPageLista = new TabPage();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnModificar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            dataGridTiendas = new DataGridView();
            txtBusqueda = new TextBox();
            labelBuscar = new Label();
            tabPageAgregarEditar = new TabPage();
            txtEstacion = new TextBox();
            label1 = new Label();
            txtPrecio = new TextBox();
            txtTipoArticulo = new TextBox();
            txtTipoCliente = new TextBox();
            txtMarca = new TextBox();
            label4 = new Label();
            labelTipoArticulo = new Label();
            labeltipoCliente = new Label();
            labelMarca = new Label();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            labelArticulos = new Label();
            tabControlLista.SuspendLayout();
            tabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridTiendas).BeginInit();
            tabPageAgregarEditar.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlLista
            // 
            tabControlLista.Controls.Add(tabPageLista);
            tabControlLista.Controls.Add(tabPageAgregarEditar);
            tabControlLista.Location = new Point(9, 45);
            tabControlLista.Name = "tabControlLista";
            tabControlLista.SelectedIndex = 0;
            tabControlLista.Size = new Size(783, 394);
            tabControlLista.TabIndex = 3;
            // 
            // tabPageLista
            // 
            tabPageLista.Controls.Add(btnBuscar);
            tabPageLista.Controls.Add(btnEliminar);
            tabPageLista.Controls.Add(btnModificar);
            tabPageLista.Controls.Add(btnNuevo);
            tabPageLista.Controls.Add(dataGridTiendas);
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
            btnEliminar.Click += btnEliminar_Click;
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
            // dataGridTiendas
            // 
            dataGridTiendas.AllowUserToAddRows = false;
            dataGridTiendas.AllowUserToDeleteRows = false;
            dataGridTiendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTiendas.Location = new Point(18, 92);
            dataGridTiendas.Name = "dataGridTiendas";
            dataGridTiendas.ReadOnly = true;
            dataGridTiendas.Size = new Size(631, 269);
            dataGridTiendas.TabIndex = 3;
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
            labelBuscar.Location = new Point(14, 46);
            labelBuscar.Name = "labelBuscar";
            labelBuscar.Size = new Size(42, 15);
            labelBuscar.TabIndex = 0;
            labelBuscar.Text = "Buscar";
            // 
            // tabPageAgregarEditar
            // 
            tabPageAgregarEditar.Controls.Add(txtEstacion);
            tabPageAgregarEditar.Controls.Add(label1);
            tabPageAgregarEditar.Controls.Add(txtPrecio);
            tabPageAgregarEditar.Controls.Add(txtTipoArticulo);
            tabPageAgregarEditar.Controls.Add(txtTipoCliente);
            tabPageAgregarEditar.Controls.Add(txtMarca);
            tabPageAgregarEditar.Controls.Add(label4);
            tabPageAgregarEditar.Controls.Add(labelTipoArticulo);
            tabPageAgregarEditar.Controls.Add(labeltipoCliente);
            tabPageAgregarEditar.Controls.Add(labelMarca);
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
            // txtEstacion
            // 
            txtEstacion.Location = new Point(105, 269);
            txtEstacion.Name = "txtEstacion";
            txtEstacion.Size = new Size(450, 23);
            txtEstacion.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 274);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 10;
            label1.Text = "Estación";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(105, 213);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(453, 23);
            txtPrecio.TabIndex = 9;
            // 
            // txtTipoArticulo
            // 
            txtTipoArticulo.Location = new Point(102, 144);
            txtTipoArticulo.Name = "txtTipoArticulo";
            txtTipoArticulo.Size = new Size(453, 23);
            txtTipoArticulo.TabIndex = 8;
            // 
            // txtTipoCliente
            // 
            txtTipoCliente.Location = new Point(102, 87);
            txtTipoCliente.Name = "txtTipoCliente";
            txtTipoCliente.Size = new Size(453, 23);
            txtTipoCliente.TabIndex = 7;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(102, 43);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(453, 23);
            txtMarca.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 221);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 5;
            label4.Text = "Precio";
            label4.Click += label4_Click;
            // 
            // labelTipoArticulo
            // 
            labelTipoArticulo.AutoSize = true;
            labelTipoArticulo.Location = new Point(21, 152);
            labelTipoArticulo.Name = "labelTipoArticulo";
            labelTipoArticulo.Size = new Size(75, 15);
            labelTipoArticulo.TabIndex = 4;
            labelTipoArticulo.Text = "Tipo_articulo";
            // 
            // labeltipoCliente
            // 
            labeltipoCliente.AutoSize = true;
            labeltipoCliente.Location = new Point(21, 94);
            labeltipoCliente.Name = "labeltipoCliente";
            labeltipoCliente.Size = new Size(70, 15);
            labeltipoCliente.TabIndex = 3;
            labeltipoCliente.Text = "Tipo_cliente";
            // 
            // labelMarca
            // 
            labelMarca.AutoSize = true;
            labelMarca.Location = new Point(33, 46);
            labelMarca.Name = "labelMarca";
            labelMarca.Size = new Size(40, 15);
            labelMarca.TabIndex = 2;
            labelMarca.Text = "Marca";
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
            // labelArticulos
            // 
            labelArticulos.AutoSize = true;
            labelArticulos.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic);
            labelArticulos.Location = new Point(24, 12);
            labelArticulos.Name = "labelArticulos";
            labelArticulos.Size = new Size(105, 30);
            labelArticulos.TabIndex = 2;
            labelArticulos.Text = "Articulos";
            // 
            // TiendaView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlLista);
            Controls.Add(labelArticulos);
            Name = "TiendaView";
            Text = "TiendaView";
            tabControlLista.ResumeLayout(false);
            tabPageLista.ResumeLayout(false);
            tabPageLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridTiendas).EndInit();
            tabPageAgregarEditar.ResumeLayout(false);
            tabPageAgregarEditar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControlLista;
        private TabPage tabPageLista;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private DataGridView dataGridTiendas;
        private TextBox txtBusqueda;
        private Label labelBuscar;
        private TabPage tabPageAgregarEditar;
        private TextBox txtPrecio;
        private TextBox txtTipoArticulo;
        private TextBox txtTipoCliente;
        private TextBox txtMarca;
        private Label label4;
        private Label labelTipoArticulo;
        private Label labeltipoCliente;
        private Label labelMarca;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private Label labelArticulos;
        private TextBox txtEstacion;
        private Label label1;
    }
}