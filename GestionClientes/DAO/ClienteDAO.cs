using GestionClientes.models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionClientes.DAO
{
    internal class ClienteDAO
    {
        public MySqlConnection Conectar() 
        {
            //PREPRAMOS LA CONEXION
            string sevidor = "localhost"; //es lo mismo que la direccion ipv4
            string usuario = "root";
            string password = "";
            string baseDatos = "clientescsharp";
            string puerto = "3307";
            

            string cadenaConexión = "Database=" + baseDatos + "; Data Source=" + sevidor + ";Port=" + puerto + "; User Id=" + usuario + ";Password=" + password + "";

            MySqlConnection conexionDB = new MySqlConnection(cadenaConexión);
            conexionDB.Open(); //Hay q abrir la conexion

            return conexionDB;//Pasmaos la conexion

        }

        public List<Cliente> obtenerClientes() 
        {
            List<Cliente> lista = new List<Cliente>();

            //CREAMOS CONSULTA
            string query = "SELECT * FROM clientes";
            MySqlCommand comando = new MySqlCommand(query); //El statement de java
            comando.Connection = Conectar(); //le pasamos la conexion que nos devuleve la funcion conectar
            MySqlDataReader lecturaBD = comando.ExecuteReader(); //Esto es el resultset

            
            while (lecturaBD.Read()) //Es como el resultset que hay que recorrer
            {
                Cliente cliente = new Cliente(); //Creamos el cliente y rellenamos los parametros con la info de la base de datos
                cliente.Id = lecturaBD.GetString("id");
                cliente.Nombre = lecturaBD.GetString("nombre");
                cliente.Apellido = lecturaBD.GetString("apellido");
                cliente.Tlf = lecturaBD.GetString("phone");
                cliente.CrCard = lecturaBD.GetString("tarjeta_de_credito");
                lista.Add(cliente); //agregasmos a la lista
            }
            comando.Connection.Close(); //Cerramos la conexion para no saturar a la base de datos

            return lista;
        
        }

        public void Guardar(Cliente cliente)
        {
            if (cliente.Id == null) //Si esta vacio se crea
            {
                insert(cliente);
            }
            else
            {
                update(cliente); //Si no lo esta se actualiza
            }
        }

        public void insert(Cliente cliente)
        {
            string query = "INSERT INTO clientes (nombre,apellido,phone,tarjeta_de_credito) VALUES ('" + cliente.Nombre + "','" + cliente.Apellido + "','" + cliente.Tlf + "','" + cliente.CrCard + "');";
            MySqlCommand comando = new MySqlCommand(query);
            comando.Connection = Conectar();

            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }

        private void update(Cliente cliente)
        {
            string query = "UPDATE clientes SET nombre='" + cliente.Nombre + "', apellido='" + cliente.Apellido + "' , phone='" + cliente.Tlf + "', tarjeta_de_credito= '" + cliente.CrCard + "' WHERE id= "+cliente.Id+";";
            MySqlCommand comando = new MySqlCommand(query);
            comando.Connection = Conectar();

            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }

        public void Eliminar(Cliente cliente)
        {
            string query = "DELETE FROM clientes WHERE id = " + cliente.Id +";";
            MySqlCommand comando = new MySqlCommand(query);
            comando.Connection = Conectar();

            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }
        
    }
}
