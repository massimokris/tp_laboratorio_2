using System;
using Abstractas;
using System.Text;

namespace Instanciables
{
    sealed class Alumno : Universitario
    {

        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;

        #region CONSTRUCTORES

        public Alumno () { }

        public Alumno (int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma) : base (id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }

        public Alumno (int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta) : this (id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }

        #endregion

        #region OPERADORES

        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            return (a.claseQueToma.Equals(clase) && a.estadoCuenta != EEstadoCuenta.Deudor);
        }

        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            return !(a.claseQueToma.Equals(clase));
        }

        #endregion

        #region SOBRECARGAS

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(this.MostrarDatos());
           
            return sb.ToString();
        }

        #endregion

        #region METODOS

        protected new string MostrarDatos ()
        {
            StringBuilder sb = new StringBuilder(base.MostrarDatos());
            sb.AppendLine(this.ParticiparEnClase());
            sb.AppendLine($"Estado de cuenta: {this.estadoCuenta}");
            return sb.ToString();
        }

        protected string ParticiparEnClase ()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Toma clase de: {this.claseQueToma}");
            return sb.ToString();
        }

        #endregion

        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }
    }
}
