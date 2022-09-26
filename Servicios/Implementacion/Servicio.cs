using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using veterinaria_1._3.Datos.Implementacion;

namespace veterinaria_1._3.Servicios
{
    internal class Servicio : IServicio
    {
        private DaoMascota dao;

        public Servicio()
        {
            dao = new DaoMascota();
        }
        public int ObtenerProximo()
        {
            return ObtenerProximo();
        }
    }
}
