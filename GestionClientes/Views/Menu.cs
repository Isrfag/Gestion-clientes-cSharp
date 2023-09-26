namespace GestionClientes
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.Text = "Empresa random Software";
        }

        private void buttonMnuGest_Click(object sender, EventArgs e)
        {
            
            GestionClientes ventanaGestionClientes = new GestionClientes(); //Instanciamos el objeto 
            ventanaGestionClientes.Text="Gestor de clientes";
            ventanaGestionClientes.ShowDialog(); //Showdialog abre la ventana.
        }
    }
}