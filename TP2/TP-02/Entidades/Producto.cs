using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    /// <summary>
    /// La clase Producto no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Producto
    {
        
        private EMarca marca;
        private string codigoDeBarras;
        private ConsoleColor colorPrimarioEmpaque;

        #region PROP
        /// <summary>
        /// ReadOnly: Retornará la cantidad de calorias del producto
        /// </summary>
        protected abstract short CantidadCalorias { get; }
        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// Constructor del producto
        /// </summary>
        /// <param name="codigo">codigo del producto</param>
        /// <param name="marca">marca del producto</param>
        /// <param name="color">color del producto</param>
        public Producto(string codigo, EMarca marca, ConsoleColor color)
        {
            this.codigoDeBarras = codigo;
            this.marca = marca;
            this.colorPrimarioEmpaque = color;
        }

        #endregion

        #region METODOS
        /// <summary>
        /// Publica todos los datos del Producto.
        /// </summary>
        /// <returns>String con la descripcion del producto</returns>
        public virtual string Mostrar()
        {
            
            return (string)this;
        }
        #endregion

        #region OPERADORES
        /// <summary>
        /// retorna la descripcion del producto
        /// </summary>
        /// <param name="p">producto a transformar en su descripcion</param>
        public static explicit operator string(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"CODIGO DE BARRAS: {p.codigoDeBarras}");
            sb.AppendLine($"MARCA           : {p.marca}");
            sb.AppendLine($"COLOR EMPAQUE   : {p.colorPrimarioEmpaque}");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        
        /// <summary>
        /// Dos productos son iguales si comparten el mismo código de barras
        /// </summary>
        /// <param name="v1">producto 1</param>
        /// <param name="v2">producto 2</param>
        /// <returns>booleano para la igualdad de los porductos</returns>
        public static bool operator ==(Producto v1, Producto v2)
        {
            return (v1.codigoDeBarras == v2.codigoDeBarras);
        }

        /// <summary>
        /// Dos productos son distintos si su código de barras es distinto
        /// </summary>
        /// <param name="v1">producto 1</param>
        /// <param name="v2">producto 2</param>
        /// <returns>booleano para la desigualdad de los productos</returns>
        public static bool operator !=(Producto v1, Producto v2)
        {
            return !(v1 == v2);
        }
        #endregion

        public enum EMarca
        {
            Serenisima,
            Campagnola,
            Arcor,
            Ilolay,
            Sancor,
            Pepsico
        }
    }
}
