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
 
        #endregion

        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }
    }
}
