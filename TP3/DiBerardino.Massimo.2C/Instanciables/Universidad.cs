using System;
using System.Collections.Generic;
using System.Text;

namespace Instanciables
{
    public class Universidad
    {

        private List<Alumno> alumnos;
        private List<Jornada> jornadas;
        private List<Profesor> profesores;

        #region PROPIEDADES

        public List<Alumno> Alumnos
        {
            get;
            set;
        }

        public List<Profesor> Instructores
        {
            get;
            set;
        }

        public List<Jornada> Jornadas
        {
            get;
            set;
        }

        public this[int i] 
        {    
            get;
            set;
        }

    #endregion

        #region CONSTRUCTORES
            
            Universidad () { }

    #endregion

        #region OPERADORES
            
            public static bool operator ==(Universidad g, Alumno a) { }

            public static bool operator !=(Universidad g, Alumno a) { }
            
            public static bool operator ==(Universidad g, Profesor i) { }

            public static bool operator !=(Universidad g, Profesor i) { }

            public static Profesor operator ==(Universidad u, EClases clase) { }

            public static Profesor operator !=(Universidad u, EClases clase) { }

            public static Universidad operator +(Universidad g, EClases clase) { }

            public static Universidad operator +(Universidad g, Alumno a) { }

            public static Universidad operator +(Universidad g, Profesor i) { }

        #endregion

        #region SOBRECARGAS

        public override string ToString()
        {
            return base.ToString();
        }

        #endregion

        #region METODOS

        public bool Guardar (Universidad uni) { }

        public Universidad Leer () { }

        private string MostrarDatos (Universidad uni) { }

        #endregion

        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }
    }
}
