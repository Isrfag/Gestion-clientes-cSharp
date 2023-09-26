using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionClientes.models;
using GestionClientes.DAO;
using MySqlX.XDevAPI;

namespace GestionClientes
{
    public partial class GestionClientes : Form
    {
        public GestionClientes()
        {
            InitializeComponent();
            
        }

        private void GestionClientes_Load(object sender, EventArgs e) //Al abrirse la ventana
        {

            renderizarLista();

        }

        private void renderizarLista()
        {
            ClienteDAO baseDatos = new ClienteDAO();
            List<Cliente> listaDB = baseDatos.obtenerClientes(); //Traemos el listado de la base de datos

            listClientes.Items.Clear(); //Con esto limpiamos el listado visible
            for (int i = 0; i < listaDB.Count; i++)
            {
                Cliente cliente = listaDB[i]; //Recorremos la lista de la base de datos y lo guardamos
                listClientes.Items.Add(cliente); //Añadimos el cliente en cuestion a la lista visible
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = txtNombre.Text; //No se hace como en JAVA al ponerle el set te deja tocar pero no estas cambiando directamente la variable privada
            cliente.Apellido = txtApellido.Text;
            cliente.Tlf = txtTlf.Text;
            cliente.CrCard = textCredit.Text;

            if (lblId.Text != "") //Le preguntamos i el id esta vacio o no, si lo esta es un nuevo cliente entonces, si no le ponemos el id
            {
                cliente.Id = lblId.Text;

            }
            ClienteDAO baseDeDatos = new ClienteDAO(); //Enviamos info a la base datos
            baseDeDatos.Guardar(cliente);
            renderizarLista();
            limpiarListado();
            
        }

            private void btnEliminar_Click(object sender, EventArgs e)
            {
                Cliente cliente = (Cliente)listClientes.SelectedItem;//Creamos el cliente con lo que se obtiene de la lista

                ClienteDAO baseDeDatos = new ClienteDAO(); //Enviamos info a la base datos
                baseDeDatos.Eliminar(cliente);
                renderizarLista();
            }


            private void button1_Click_1(object sender, EventArgs e) //Es el editar pero no le cambie el nombre
            {
                Cliente cliente = (Cliente)listClientes.SelectedItem;//Lo mismo queremos el seleccionado
                                                                     //Le decimos que nos cargue los cambios para editarlos
                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                txtTlf.Text = cliente.Tlf;
                textCredit.Text = cliente.CrCard;
                lblId.Text = cliente.Id;

            }

            private void btnAgregar_Click(object sender, EventArgs e)
            {
                limpiarListado();
            }

            private void limpiarListado()
            {
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtTlf.Text = "";
                textCredit.Text = "";
                lblId.Text = "";
            }
    }
  }

