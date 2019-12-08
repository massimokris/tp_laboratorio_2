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

        /// <summary>
        /// obtener o asignar el atributo direccion entrega
        /// </summary>
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

        /// <summary>
        /// obtener o asignar el atributo Eestado
        /// </summary>
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

        /// <summary>
        /// obtener o asignar el atributo Tracking ID
        /// </summary>
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

        /// <summary>
        /// constructor de clase Paquete
        /// </summary>
        /// <param name="direccionEntrega">direccion de entrega</param>
        /// <param name="trackingId">id del envio</param>
        public Paquete(string direccionEntrega, string trackingId)
        {
            this.direccionEntrega = direccionEntrega;
            this.trackingID = trackingId;
            this.estado = EEstado.Ingresado;
        }

        /// <summary>
        /// simular el ciclo de vida del envio de un paquete
        /// </summary>
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

        /// <summary>
        /// Mostrar informacion de un paquete en especifico
        /// </summary>
        /// <param name="elemento">paquete a mostrar informacion</param>
        /// <returns>datos del pauqete como texto</returns>
        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            Paquete p = (Paquete)elemento;
            return String.Format($"{p.TrackingID} para {p.DireccionEntrega}");
        }
        /// <summary>
        /// Mostrar los datos de la instancia de ese paquete
        /// </summary>
        /// <returns>datos del paquete como texto</returns>
        public override string ToString()
        {
            return this.MostrarDatos(this);
        }

        /// <summary>
        /// Igualdad entre dos paquetes
        /// </summary>
        /// <param name="p1">paquete 1</param>
        /// <param name="p2">paquete 2</param>
        /// <returns>verdadero si son iguales, caso contrario falso</returns>
        public static bool operator ==(Paquete p1, Paquete p2)
        {
            return (p1.trackingID == p2.trackingID);
        }

        /// <summary>
        /// diferencia entre dos paquetes
        /// </summary>
        /// <param name="p1">paquete 1</param>
        /// <param name="p2">paquete 2</param>
        /// <returns>verdadero si son diferentes, caso contrario falso</returns>
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
