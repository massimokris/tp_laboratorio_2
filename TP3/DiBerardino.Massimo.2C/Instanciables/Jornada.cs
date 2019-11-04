using System;
using System.Collections.Generic;
using System.Text;

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
            get;
            set;
        }

        public Universidad.EClases Clase
        {
            get;
            set;
        }

        public Profesor Instructor
        {
            get;
            set;
        }

        #endregion

        #region CONSTRUCTORES

        private Jornada () { }

        public Jornada (Universidad.EClases clase, Profesor profesor)
        {
            alumnos = new List<Alumno>();
            this.clase = clase;
            this.instructor = profesor;
        }

        #endregion

        #region OPERADORES

        public static bool operator ==(Jornada j, Alumno a) { }

        public static bool operator !=(Jornada j, Alumno a) { }

        public static Jornada operator +(Jornada j, Alumno a) { }

        #endregion

        #region SOBRECARGAS

        public override string ToString()
        {
            return base.ToString();
        }

        #endregion

        #region METODOS

        public bool Guardar (Jornada jornada) { }

        public string Leer () { }

        #endregion
    }
}
