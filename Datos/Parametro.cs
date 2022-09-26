using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veterinaria_1._3.Datos
{
    internal class Parametro
    {
        private string clave { get; set; }
        private object valor { get; set; }
        public Parametro( string clave, object valor)
        {
            this.clave = clave;
            this.valor = valor;
        }
    }
}
