namespace Desktop.Views
{
    partial class LocalidadesApiView
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
            labelLocalidades = new Label();
            tabControlLista = new TabControl();
            tabPageLista = new TabPage();
            btnRestaurar = new FontAwesome.Sharp.IconButton();
            verEliminadoscheck = new CheckBox();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnModificar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            dataGridLocalidades = new DataGridView();
            txtBusqueda = new TextBox();
            labelBuscar = new Label();
            tabPageAgregarEditar = new TabPage();
            label1 = new Label();
            comboProvincias = new ComboBox();
            txtNombre = new TextBox();
            labelNombre = new Label();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            comboPaises = new ComboBox();
            tabControlLista.SuspendLayout();
            tabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridLocalidades).BeginInit();
            tabPageAgregarEditar.SuspendLayout();
            SuspendLayout();
            // 
            // labelLocalidades
            // 
            labelLocalidades.AutoSize = true;
            labelLocalidades.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic);
            labelLocalidades.Location = new Point(27, 19);
            labelLocalidades.Name = "labelLocalidades";
            labelLocalidades.Size = new Size(253, 30);
            labelLocalidades.TabIndex = 0;
            labelLocalidades.Text = "Localidades Api Service";
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
            tabPageLista.Controls.Add(btnRestaurar);
            tabPageLista.Controls.Add(verEliminadoscheck);
            tabPageLista.Controls.Add(btnBuscar);
            tabPageLista.Controls.Add(btnEliminar);
            tabPageLista.Controls.Add(btnModificar);
            tabPageLista.Controls.Add(btnNuevo);
            tabPageLista.Controls.Add(dataGridLocalidades);
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
            // btnRestaurar
            // 
            btnRestaurar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnRestaurar.IconColor = Color.Black;
            btnRestaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRestaurar.Location = new Point(677, 275);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(75, 23);
            btnRestaurar.TabIndex = 9;
            btnRestaurar.Text = "Restaurar";
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // verEliminadoscheck
            // 
            verEliminadoscheck.AutoSize = true;
            verEliminadoscheck.Location = new Point(663, 230);
            verEliminadoscheck.Name = "verEliminadoscheck";
            verEliminadoscheck.Size = new Size(106, 19);
            verEliminadoscheck.TabIndex = 8;
            verEliminadoscheck.Text = "Ver eliminados ";
            verEliminadoscheck.UseVisualStyleBackColor = true;
            verEliminadoscheck.CheckedChanged += verEliminadoscheck_CheckedChanged;
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
            // dataGridLocalidades
            // 
            dataGridLocalidades.AllowUserToAddRows = false;
            dataGridLocalidades.AllowUserToDeleteRows = false;
            dataGridLocalidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridLocalidades.Location = new Point(18, 92);
            dataGridLocalidades.Name = "dataGridLocalidades";
            dataGridLocalidades.ReadOnly = true;
            dataGridLocalidades.RowHeadersWidth = 51;
            dataGridLocalidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridLocalidades.Size = new Size(631, 269);
            dataGridLocalidades.TabIndex = 3;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(68, 39);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(581, 23);
            txtBusqueda.TabIndex = 1;
            txtBusqueda.KeyPress += txtBusqueda_KeyPress;
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
            tabPageAgregarEditar.Controls.Add(label2);
            tabPageAgregarEditar.Controls.Add(comboPaises);
            tabPageAgregarEditar.Controls.Add(label1);
            tabPageAgregarEditar.Controls.Add(comboProvincias);
            tabPageAgregarEditar.Controls.Add(txtNombre);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 111);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 11;
            label1.Text = "Provincia";
            // 
            // comboProvincias
            // 
            comboProvincias.FormattingEnabled = true;
            comboProvincias.Location = new Point(102, 108);
            comboProvincias.Name = "comboProvincias";
            comboProvincias.Size = new Size(453, 23);
            comboProvincias.TabIndex = 10;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(102, 43);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(453, 23);
            txtNombre.TabIndex = 6;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 180);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 13;
            label2.Text = "Pais";
            // 
            // comboPaises
            // 
            comboPaises.FormattingEnabled = true;
            comboPaises.Location = new Point(102, 177);
            comboPaises.Name = "comboPaises";
            comboPaises.Size = new Size(453, 23);
            comboPaises.TabIndex = 12;
            // 
            // LocalidadesApiView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 450);
            Controls.Add(tabControlLista);
            Controls.Add(labelLocalidades);
            Name = "LocalidadesApiView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Localidades";
            tabControlLista.ResumeLayout(false);
            tabPageLista.ResumeLayout(false);
            tabPageLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridLocalidades).EndInit();
            tabPageAgregarEditar.ResumeLayout(false);
            tabPageAgregarEditar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLocalidades;
        private TabControl tabControlLista;
        private TabPage tabPageLista;
        private TabPage tabPageAgregarEditar;
        private TextBox txtBusqueda;
        private Label labelBuscar;
        private DataGridView dataGridLocalidades;
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
        private CheckBox verEliminadoscheck;
        private FontAwesome.Sharp.IconButton btnRestaurar;
        private Label label1;
        private ComboBox comboProvincias;
        private Label label2;
        private ComboBox comboPaises;
    }
}