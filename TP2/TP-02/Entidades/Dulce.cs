using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    public class Dulce : Producto
    {
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor del dulce
        /// </summary>
        /// <param name="codigo">codigo dulce</param>
        /// <param name="marca">marca dulce</param>
        /// <param name="color">color dulce</param>
        public Dulce(string codigo, EMarca marca, ConsoleColor color) : base (codigo, marca, color)
        {
        }
        #endregion

        #region PROP
        /// <summary>
        /// Cantidad de calorias del producto
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 80;
            }
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Mostrar la descripcion del dulce
        /// </summary>
        /// <returns>string con la descripcion del dulce</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DULCE");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"CALORIAS : {this.CantidadCalorias}");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
