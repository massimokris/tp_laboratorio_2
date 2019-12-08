using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void DelegadoEstado(Object sender, EventArgs e);
    public class Paquete : IMostrar<Paquete>
    {
        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;
        public event DelegadoEstado InformarEstado;

        public string DireccionEntrega
        {
            get
            {
                return this.direccionEntrega;
            }
            set
            {
                this.direccionEntrega = value;
            }
        }

        public EEstado Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }

        public string TrackingID
        {
            get
            {
                return this.trackingID;
            }
            set
            {
                this.trackingID = value;
            }
        }

        public Paquete(string direccionEntrega, string trackingId)
        {
            this.direccionEntrega = direccionEntrega;
            this.trackingID = trackingId;
            this.estado = EEstado.Ingresado;
        }
        public void MockCicloDeVida()
        {
            while (this.estado != EEstado.Entregado)
            {
                Thread.Sleep(2000);
                this.estado++;
                this.InformarEstado.Invoke(this, null);
            }
            PaqueteDAO.Insertar(this);
        }
        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            Paquete p = (Paquete)elemento;
            return String.Format($"{p.TrackingID} para {p.DireccionEntrega}");
        }
        public override string ToString()
        {
            return this.MostrarDatos(this);
        }

        public static bool operator ==(Paquete p1, Paquete p2)
        {
            return (p1.trackingID == p2.trackingID);
        }
        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }

        public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        }
    }
}
