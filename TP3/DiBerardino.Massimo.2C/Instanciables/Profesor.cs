using System;
using System.Collections.Generic;
using System.Text;
using Abstractas;

namespace Instanciables
{
    public sealed class Profesor : Universitario
    {

        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;

        #region CONSTRUCTORES

        public Profesor () : base () { }

        static Profesor() 
        {
            random = new Random();
        }

        public Profesor (int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base (id, nombre, apellido, dni, nacionalidad)
        {
            clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();
            this._randomClases();
        }

        #endregion

        #region OPERADORES

        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            return i.clasesDelDia.Contains(clase);
        }

        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }

        #endregion

        #region SOBRECARGAS

        public override string ToString()
        {
            return this.MostrarDatos();
        }

        #endregion

        #region METODOS

        protected new string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder(base.MostrarDatos());
            sb.AppendLine(this.ParticiparEnClase());
            return sb.ToString();
        }

        protected override string ParticiparEnClase ()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Clases del dia:");
            foreach (var item in this.clasesDelDia)
            {
                sb.AppendLine($"{item}");
            }

            return sb.ToString();
        }

        private void _randomClases ()
        {
            int length = Enum.GetNames(typeof(Universidad.EClases)).Length;
            this.clasesDelDia.Enqueue((Universidad.EClases)(Profesor.random.Next(length)));  
        }

        #endregion
    }
}
