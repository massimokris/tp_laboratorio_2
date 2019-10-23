using System;
using System.Collections.Generic;
using System.Text;

namespace Abstractas
{
    public abstract class Universitario : Persona
    {
        private int legajo;

        #region CONSTRUCTORES

        Universitario () { }

        Universitario (int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base (nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }

        #endregion

        #region OPERADORES

        public static bool operator ==(Universitario pg1, Universitario pg2) { }

        public static bool operator !=(Universitario pg1, Universitario pg2) { }

        #endregion

        #region SOBRECARGAS

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        #endregion

        #region METODOS 

        protected string MostrarDatos () { }

        protected string ParticiparEnClase () { }

        #endregion
    }
}
