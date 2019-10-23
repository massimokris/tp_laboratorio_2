using System;
using Abstractas;

namespace Instanciables
{
    sealed class Alumno : Universitario
    {

        private EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;

        #region CONSTRUCTORES

        Alumno () { }

        Alumno (int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, EClases claseQueToma) { }

        Alumno (int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, EClases claseQueToma, EEstadoCuenta estadoCuenta) { }

        #endregion

        #region OPERADORES

        public static bool operator ==(Alumno a, EClases clase) { }

        public static bool operator !=(Alumno a, EClases clase) { }

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

        #endregion

        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }
    }
}
