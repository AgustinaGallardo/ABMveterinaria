using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veterinaria_1._3
{
    internal class Atencion
    {
        private Mascota mascota;
        private double importe;
        private DateTime fecha;
       

        public Mascota Mascota
        { get { return mascota; } set { mascota = value; } }
        public double Importe { get { return importe; } set { importe = value; } }
        public DateTime Fecha { get { return fecha; } set { fecha = value; } }
        

        public Atencion(Mascota mascota,double importe, DateTime fecha)
        {
            this.Fecha=fecha;
            this.mascota = mascota;           
            this.Importe=importe;
            
        }
        public Atencion()
        {          
            this.mascota=new Mascota();
            this.importe=0;
            this.Fecha=DateTime.Today;
        }
        public override string ToString()
        {
            return mascota.ToString() + ", Costo:"+importe +" $ " ;
        }
    }
}
