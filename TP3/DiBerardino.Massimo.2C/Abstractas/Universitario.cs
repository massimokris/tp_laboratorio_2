using System;
using System.Collections.Generic;
using System.Text;

namespace Abstractas
{
    public abstract class Universitario : Persona
    {
        private int legajo;

        #region CONSTRUCTORES

        public Universitario () : base() { }

        public Universitario (int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base (nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }

        #endregion

        #region OPERADORES

        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            return pg1.GetType() == pg2.GetType() && (pg1.legajo.Equals(pg2.legajo) || pg1.DNI.Equals(pg2.DNI));
        }

        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }

        #endregion

        #region SOBRECARGAS

        public override bool Equals(object obj)
        {
            return obj.GetType() == typeof(Universitario) &&  this == (Universitario)obj; ;
        }

        #endregion

        #region METODOS 

        protected virtual string MostrarDatos ()
        {
            StringBuilder st = new StringBuilder(base.ToString());
            st.AppendLine($"Legajo: {this.legajo}");

            return st.ToString();
        }

        protected abstract string ParticiparEnClase();

        #endregion
    }
}
