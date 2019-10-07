using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    public class Snacks : Producto
    {
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor del snack
        /// </summary>
        /// <param name="codigo">codigo snack</param>
        /// <param name="marca">marca snack</param>
        /// <param name="color">color snack</param>
        public Snacks(string codigo, EMarca marca, ConsoleColor color) : base(codigo, marca, color)
        {
        }
        #endregion

        #region PROP
        /// <summary>
        /// Cantidad de calorias del snack
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 104;
            }
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Mostrar la descripcion del snack
        /// </summary>
        /// <returns>string con toda la descripcion del snack</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SNACKS");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"CALORIAS : {this.CantidadCalorias}");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
