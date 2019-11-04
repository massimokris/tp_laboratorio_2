using System;
using System.Collections.Generic;
using System.Text;
using Abstractas;

namespace Instanciables
{
    sealed class Profesor : Universitario
    {

        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;

        #region CONSTRUCTORES

        Profesor () { }

        private Profesor () { }

        Profesor (int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad) { }

        #endregion

        #region OPERADORES

        public static bool operator ==(Profesor i, EClases clase) { }

        public static bool operator !=(Profesor i, EClases clase) { }

        #endregion

        #region SOBRECARGAS

        public override string ToString()
        {
            return this.MostrarDatos();
        }

        #endregion

        #region METODOS

        protected string MostrarDatos ()
        {
            StringBuilder sb = new StringBuilder(base.MostrarDatos());
            sb.AppendLine(this.ParticiparEnClase());
            return sb.ToString();
        }

        protected string ParticiparEnClase ()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Clases del dia:");
            foreach (var item in this.clasesDelDia)
            {
                sb.AppendLine($"{item}");
            }

            return sb.ToString();
        }

        private void _randomClases () { }

        #endregion
    }
}
