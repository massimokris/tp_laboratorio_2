using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades_2018
{
    class Leche : Producto
    {
        
        ETipo tipo;

        #region CONSTRUCTORES
        /// <summary>
        /// Constructo del producto leche
        /// </summary>
        /// <param name="marca">marca de la leche</param>
        /// <param name="codigo">codigo de la leche</param>
        /// <param name="color">Color de la leche</param>
        /// <param name="tipo">Tipo de leche</param>
        public Leche(string codigo, EMarca marca, ConsoleColor color, ETipo tipo) : base(codigo, marca, color)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Constructo del producto leche, Por defecto, TIPO será ENTERA
        /// </summary>
        /// <param name="marca">marca de la leche</param>
        /// <param name="codigo">codigo de la leche</param>
        /// <param name="color">Color de la leche</param>
        /// <param name="tipo">Tipo de leche</param>
        public Leche(string codigo, EMarca marca, ConsoleColor color) : this(codigo, marca, color, ETipo.Entera)
        { 
        }
        #endregion

        #region PROP
        /// <summary>
        /// Cantidad de calorias de la leche
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 20;
            }
        }
        #endregion

        #region METODOS
        /// <summary>
        /// mostrar la descripcion de la leche
        /// </summary>
        /// <returns>string con toda la descripcion de la leche</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LECHE");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"CALORIAS : {this.CantidadCalorias}");
            sb.AppendLine($"TIPO      : {this.tipo}");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion

        public enum ETipo
        {
            Entera,
            Descremada
        }
    }
}
