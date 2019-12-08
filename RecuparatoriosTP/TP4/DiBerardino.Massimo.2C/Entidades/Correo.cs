using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>>
    {

        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;

        /// <summary>
        /// propiedad para obtener o setear la lista de paquetes
        /// </summary>
        public List<Paquete> Paquetes
        {
            get
            {
                return this.paquetes;
            }
            set
            {
                this.paquetes = value;
            }
        }

        /// <summary>
        /// Constructor de clase vacio que inicializa sus los atributos de la misma
        /// </summary>
        public Correo()
        {
            this.paquetes = new List<Paquete>();
            this.mockPaquetes = new List<Thread>();
        }

        /// <summary>
        /// Termina los hilos
        /// </summary>
        public void FinEntregas()
        {
            foreach (Thread item in this.mockPaquetes)
            {
                if (item != null && item.IsAlive) item.Abort();
            }
        }

        /// <summary>
        /// Mostrar todos los datos de una lista de paquetes
        /// </summary>
        /// <param name="elemento">lista de paquetes</param>
        /// <returns></returns>
        public string MostrarDatos(IMostrar<List<Paquete>> elemento)
        {
            string retorno = "";
            Correo c = (Correo)elemento;
            foreach (Paquete item in c.paquetes)
            {
                retorno += String.Format("{0} para {1} ({2})\n", item.TrackingID, item.DireccionEntrega, item.Estado.ToString());
            }
            return retorno;
        }

        /// <summary>
        /// Agregar el paquete a la lista de paquetes solo si no existe, e iniciar su proceso de envio
        /// </summary>
        /// <param name="c">sistema de correo</param>
        /// <param name="p">paquete a procesar</param>
        /// <returns></returns>
        public static Correo operator +(Correo c, Paquete p)
        {
            foreach (Paquete item in c.paquetes)
            {
                if (item == p)
                {
                    throw new TrackingIdRepetidoException($"El paquete {p.TrackingID} ya esta en el sistema con el estado de : {p.Estado}");
                }
            }
            c.paquetes.Add(p);      
            Thread t1 = new Thread(p.MockCicloDeVida);
            c.mockPaquetes.Add(t1);
            try
            {
                t1.Start();
            }
            catch (Exception e)
            {
                throw new Exception("Problemas al iniciar el hilo ", e);
            }
            return c;

        }
    }
}
