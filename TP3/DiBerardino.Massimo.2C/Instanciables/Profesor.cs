using System;
using System.Collections.Generic;
using System.Text;
using Abstractas;

namespace Instanciables
{
    sealed class Profesor : Universitario
    {

        private Queue<EClases> clasesDelDia;
        private Random random;

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
            return base.ToString();
        }

        #endregion

        #region METODOS

        protected string MostrarDatos () { }

        protected string ParticiparEnClase () { }

        private void _randomClases () { }

        #endregion
    }
}
