using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void DelegadoEstado();
    public class Paquete : IMostrar<Paquete>
    {
        private string direccionEntrega;
        private EEstado estado;
        private string trakingID;
        public event DelegadoEstado InformaEstado; 

        public string DireccionEntrega
        {
            get;
            set;
        }

        public EEstado Estado
        {
            get;
            set;
        }

        public string TrakingID
        {
            get;
            set;
        }

        public Paquete(string direccionEntrega, string trakingID);
        public void MockCicloDeVida();
        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            return String.Format("{0} para {1}", this.trakingID, this.direccionEntrega, elemento.ToString);
        }
        public override string ToString()
        {
            return base.ToString();
        }

        public static bool operator ==(Paquete p1, Paquete p2);
        public static bool operator !=(Paquete p1, Paquete p2);

        public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        }
    }
}
