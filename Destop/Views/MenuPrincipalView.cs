namespace Desktop.Views
{
    public partial class MenuPrincipalView : Form
    {
        public MenuPrincipalView()
        {
            InitializeComponent();
        }

        #region Codigo del boton de saludo
        private void BtnSaludo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola, apretaste el boton!");
        }
        #endregion

        private void SubMenuSalirDelSistema_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubMenuArticulos_Click(object sender, EventArgs e)
        {
            ArticulosView articulosView = new ArticulosView();
            articulosView.MdiParent = this;
            articulosView.Show();

        }


        private void SubMenuCategorías_Click_1(object sender, EventArgs e)
        {
            CategoriasView categoriasView = new();
            categoriasView.MdiParent = this;
            categoriasView.Show();
        }

        private void subMenuClientes_Click(object sender, EventArgs e)
        {
            ClientesView clientesView = new();
            clientesView.ShowDialog();
        }
    }
}
