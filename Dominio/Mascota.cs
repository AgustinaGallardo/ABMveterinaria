using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veterinaria_1._3
{
    internal class Mascota
    {
        private int codMascota;
        private string nombre;
        private int edad;
        private int tipo;
        private Cliente cliente;

        List<Atencion> atenciones { get; set; }

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        public int CodMascota
        {
            get { return codMascota; }
            set { codMascota = value; } 
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public Mascota(int codMacota, string nombre, int edad, int tipo,Cliente cliente)
        {
            this.codMascota=codMacota;
            this.nombre=nombre;
            this.tipo=tipo;
            this.edad=edad;
            this.cliente=cliente;
        }
        public Mascota()
        {
            this.codMascota=0;
            this.nombre="";
            this.edad = 0;
            this.tipo = 0;
            this.cliente = new Cliente();
        }
        public override string ToString()
        {
            return cliente.ToString() + "--Mascota: "+ nombre + " , Edad: " + edad  ;
        }


    }
}
