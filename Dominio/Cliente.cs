using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veterinaria_1._3
{
    internal class Cliente
    {
        private int codCliente;
        private string nombre;
        private string sexo;
        private int dni;
        private string apellido;

        public string Apellido
        {
            set { apellido = value; }
            get { return apellido; }
        }
        public int CodCliente
        {
            get { return codCliente; }
            set { codCliente = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public Cliente(int codCliente,string nombre,string apellido, string sexo, int dni)
        {
            this.apellido = apellido;
            this.codCliente = codCliente;
            this.nombre = nombre;
            this.Sexo = sexo;
            this.dni = dni;
        }
        public Cliente()
        {
            this.apellido="";
            this.nombre="";
            this.codCliente=0;
            this.Sexo="";
            this.dni=0;
        }
        public override string ToString()
        {
            return "Cliente:" + apellido + "," + nombre + " -Dni: " + dni ;
        }
    }
}
