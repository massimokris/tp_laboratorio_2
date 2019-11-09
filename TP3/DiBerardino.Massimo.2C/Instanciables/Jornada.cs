using System;
using System.Collections.Generic;
using System.Text;
using Archivos;

namespace Instanciables
{
    public class Jornada
    {

        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;

        #region PROPIEDADES

        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos = value; }
        }

        public Universidad.EClases Clase
        {
            get { return this.clase; }
            set { this.clase = value; }
        }

        public Profesor Instructor
        {
            get { return this.instructor; }
            set { this.instructor = value; }
        }

        #endregion

        #region CONSTRUCTORES

        private Jornada ()
        {
            this.alumnos = new List<Alumno>();
        }

        public Jornada(Universidad.EClases clase, Profesor profesor) : this()
        {
            this.clase = clase;
            this.instructor = profesor;
        }

        #endregion

        #region OPERADORES

        public static bool operator ==(Jornada j, Alumno a)
        {
            
            return j.Alumnos.Contains(a);
        }

        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        public static Jornada operator +(Jornada j, Alumno a)
        {
            if(j != a)
            {
                j.alumnos.Add(a);
            }

            return j;
        }

        #endregion

        #region SOBRECARGAS

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Jornada:");
            sb.AppendLine($"Clase: {this.clase}");
            sb.AppendLine($"Profesor: {this.instructor}");
            sb.AppendLine("Alumnos:");
            foreach (var item in this.alumnos)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        #endregion

        #region METODOS

        public static bool Guardar (Jornada jornada)
        {
            Texto txt = new Texto();
            return txt.Guardar("jornada", jornada.ToString());
        }

        public static string Leer ()
        {
            string datos;

            Texto archivoTexto = new Texto();
            archivoTexto.Leer("jornada", out datos);

            return datos;
        }

        #endregion
    }
}
