using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using veterinaria_1._3.Datos.Interfaz;

namespace veterinaria_1._3.Datos.Implementacion
{
    internal class DaoMascota : IDaoMascota
    {
        public int ObtenerProximo()
        {
            string sp_nombre = "Proximo_mascota";
            string nombreOutPut = "@next";
            return Helper.ObtenerInstancia().ObtenerProximo(sp_nombre,nombreOutPut);
        }
    }
}
