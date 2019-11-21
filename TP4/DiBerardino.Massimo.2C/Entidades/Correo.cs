using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Correo
    {

        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;

        public List<Paquete> 
        {
            get;
            set;
        }

        public static Correo();

        public void FinEntregas();

        public string MostrarDatos(IMostrar<List<Paquete>> elementos);

        public static Correo operator +(Correo c, Paquete p);
    }
}
