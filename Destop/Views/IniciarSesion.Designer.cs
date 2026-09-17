namespace Desktop.Views
{
    partial class IniciarSesion
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
            pictureBoxLogo = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            txtContrasenia = new TextBox();
            btnIniciarSesion = new Button();
            btnCancelar = new Button();
            chkVerContrasenia = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.logo_isp20;
            pictureBoxLogo.Location = new Point(12, 59);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(278, 263);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(334, 92);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(324, 144);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(423, 94);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(377, 23);
            txtUsuario.TabIndex = 3;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(423, 141);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '*';
            txtContrasenia.Size = new Size(377, 23);
            txtContrasenia.TabIndex = 4;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Location = new Point(423, 281);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(94, 41);
            btnIniciarSesion.TabIndex = 5;
            btnIniciarSesion.Text = "Iniciar Sesion";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(691, 281);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 41);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // chkVerContrasenia
            // 
            chkVerContrasenia.AutoSize = true;
            chkVerContrasenia.Location = new Point(488, 205);
            chkVerContrasenia.Name = "chkVerContrasenia";
            chkVerContrasenia.Size = new Size(105, 19);
            chkVerContrasenia.TabIndex = 7;
            chkVerContrasenia.Text = "Ver Contraseña";
            chkVerContrasenia.UseVisualStyleBackColor = true;
            chkVerContrasenia.CheckedChanged += chkVerContrasenia_CheckedChanged;
            // 
            // IniciarSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 392);
            Controls.Add(chkVerContrasenia);
            Controls.Add(btnCancelar);
            Controls.Add(btnIniciarSesion);
            Controls.Add(txtContrasenia);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBoxLogo);
            Name = "IniciarSesion";
            Text = "Iniciar Sesion";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogo;
        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtContrasenia;
        private Button btnIniciarSesion;
        private Button btnCancelar;
        private CheckBox chkVerContrasenia;
    }
}