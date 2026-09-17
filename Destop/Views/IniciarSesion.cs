using Firebase.Auth;
using Firebase.Auth.Providers;

namespace Desktop.Views
{
    public partial class IniciarSesion : Form
    {
        FirebaseAuthClient? firebaseAuthClient;
        int intentos = 0;
        public IniciarSesion()
        {
            InitializeComponent();
            ConfiguracionFirebaseAuthClient();
        }

        private void ConfiguracionFirebaseAuthClient()
        {
            var configAuthClient = new FirebaseAuthConfig
            {
                ApiKey = "AIzaSyCe5V5k3nV4OsEvLbkF0Q8QlpZzN1AMR_k",
                AuthDomain = "inventarioisp20majo.firebaseapp.com",
                Providers = new FirebaseAuthProvider[]
                {
                    new EmailProvider()
                }
            };

            firebaseAuthClient = new FirebaseAuthClient(configAuthClient);
        }

        private async void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                var user = firebaseAuthClient!.SignInWithEmailAndPasswordAsync(txtUsuario.Text,
                    txtContrasenia.Text);
                if (user == null)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                    intentos++;
                    return;
                }

                MessageBox.Show("Bienvenido");
                this.Hide();
                var mainView = new MenuPrincipalView();
                mainView.ShowDialog();
                this.Close();
            }

            catch (FirebaseAuthException error)
            {
                MessageBox.Show($"Error al iniciar sesión: {error.Reason}");
                intentos++;

            }

            if (intentos >= 3)
            {
                MessageBox.Show("Has superado el número máximo de intentos. La aplicación se cerrará.");
                Application.Exit();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkVerContrasenia_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVerContrasenia.Checked)
            {
                txtContrasenia.PasswordChar = '\0';
            }
            else
            {
                txtContrasenia.PasswordChar = '*';
            }
        }
    }
}
