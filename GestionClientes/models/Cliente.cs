using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClientes.models
{
    internal class Cliente
    {
        private string id;
        private string nombre;
        private string apellido;
        private string tlf;
        private string crCard;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Tlf
        {
            get { return tlf; }
            set { tlf = value; }
        }

        public string CrCard
        {
            get { return crCard; }
            set { crCard = value; }

        }

        public string nombreCompleto
        {
            get { return nombre + " " + apellido; }
        }

        public override string ToString() //La clase ya trae el metodo toString asi que vamos a customizarlo
        {
            return nombreCompleto;
        }
    }
}
