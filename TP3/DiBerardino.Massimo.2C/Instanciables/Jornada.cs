using System;
using System.Collections.Generic;
using System.Text;

namespace Instanciables
{
    public class Jornada
    {

        private List<Alumno> alumnos;
        private EClases clases;
        private Profesor instructor;

        #region PROPIEDADES

        public List<Alumno> Alumnos
        {
            get;
            set;
        }

        public EClases Clase
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

        public Jornada (EClases clase, Profesor profesor) { }

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

        public bool Guardad (Jornada jornada) { }

        public string Leer () { }

        #endregion
    }
}
