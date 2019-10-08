using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public class Changuito
    {
        private List<Producto> productos;
        private int espacioDisponible;
        

        #region CONSTRUCTORES
        /// <summary>
        /// Constructor del Changuito
        /// </summary>
        private Changuito()
        {
            this.productos = new List<Producto>();
        }

        /// <summary>
        /// Constructor del changuito y su espacio disponible
        /// </summary>
        /// <param name="espacioDisponible">espacio disponible para productos</param>
        public Changuito(int espacioDisponible) : this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region SOBRECARGAS
        /// <summary>
        /// Muestro el Changuito y TODOS los Productos
        /// </summary>
        /// <returns>Descripcion de todo el changuito con su contenido</returns>
        public override string ToString()
        {
            return Mostrar(this, ETipo.Todos);
        }
        #endregion

        #region METODOS

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="c">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns>string con la descripcion del producto</returns>
        public static string Mostrar(Changuito c, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Tenemos {c.productos.Count} lugares ocupados de un total de {c.espacioDisponible} disponibles");
            
            foreach (Producto v in c.productos)
            {
                switch (tipo)
                {
                    case ETipo.Snacks:
                        if(v is Snacks) sb.AppendLine(v.Mostrar());
                        break;
                    case ETipo.Dulce:
                        if( v is Dulce) sb.AppendLine(v.Mostrar());
                        break;
                    case ETipo.Leche:
                        if(v is Leche) sb.AppendLine(v.Mostrar());
                        break;
                    default:
                        sb.AppendLine(v.Mostrar());
                        break;
                }
            }

            return sb.ToString();
        }
        #endregion

        #region OPERADORES
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="c">Objeto donde se agregará el elemento</param>
        /// <param name="p">Objeto a agregar</param>
        /// <returns>EL changuito con un producto agregado, si es que lo pudo agregar</returns>
        public static Changuito operator +(Changuito c, Producto p)
        {
            if(!(c is null) && !(p is null) 
                && !c.productos.Exists( x => x == p) 
                && c.productos.Count < c.espacioDisponible )
            {
                c.productos.Add(p);
            }

            
            return c;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="c">Objeto donde se quitará el elemento</param>
        /// <param name="p">Objeto a quitar</param>
        /// <returns></returns>
        public static Changuito operator -(Changuito c, Producto p)
        {
            if ( !(c is null) && !(p is null) 
                && c.productos.Exists(k => k == p))
            {
                c.productos.Remove(p);
            }

            return c;
        }
        #endregion

        public enum ETipo
        {
            Dulce,
            Leche,
            Snacks,
            Todos
        }
    }
}
