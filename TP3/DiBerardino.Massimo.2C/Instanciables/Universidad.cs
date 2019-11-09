using System;
using System.Collections.Generic;
using System.Text;
using Excepciones;
using Archivos;

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
            get { return this.alumnos; }
            set { this.alumnos = value; }
        }

        public List<Profesor> Instructores
        {
            get { return this.profesores; }
            set { this.profesores = value; }
        }

        public List<Jornada> Jornadas
        {
            get { return this.jornadas; }
            set { this.jornadas = value; }
        }

        public Jornada this[int i] 
        {
            get { return this.jornadas[i]; }
            set { this.jornadas[i] = value; }
        }

    #endregion

        #region CONSTRUCTORES
            
        public Universidad ()
        {
            this.jornadas = new List<Jornada>();
            this.alumnos = new List<Alumno>();
            this.profesores = new List<Profesor>();
        }

    #endregion

        #region OPERADORES
            
        public static bool operator ==(Universidad g, Alumno a)
        {
            return g.alumnos.Contains(a);
        }

        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }
            
        public static bool operator ==(Universidad g, Profesor i)
        {
            return g.profesores.Contains(i);
        }

        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }

        public static Profesor operator ==(Universidad u, EClases clase)
        {
            foreach (var item in u.profesores)
            {
                if(item == clase)
                {
                    return item;
                }
            }

            throw new SinProfesorException();
        }

        public static Profesor operator !=(Universidad u, EClases clase)
        {
            foreach (var item in u.profesores)
            {
                if (item != clase)
                {
                    return item;
                }
            }
            throw new SinProfesorException();
        }

        public static Universidad operator +(Universidad g, EClases clase)
        {
            Jornada j = new Jornada(clase, (g == clase));
            foreach (var item in g.alumnos)
            {
                if(item == clase)
                {
                    j.Alumnos.Add(item);
                }
            }
            g.jornadas.Add(j);
            return g;
        }

        public static Universidad operator +(Universidad g, Alumno a)
        {
            if(g != a)
            {
                g.alumnos.Add(a);
            }
            else
            {
                throw new AlumnoRepetidoException();
            }
            return g;
        }

        public static Universidad operator +(Universidad g, Profesor i)
        {
            if(g != i)
            {
                g.profesores.Add(i);
            }
            return g;
        }

        #endregion

        #region SOBRECARGAS

        public override string ToString()
        {
            return this.MostrarDatos(this);
        }

        #endregion

        #region METODOS

        public static bool Guardar (Universidad uni)
        {
            Xml<Universidad> xml = new Xml<Universidad>();
            return xml.Guardar("universidad.xml", uni);
        }

        public static Universidad Leer ()
        {
            Universidad u;
            Xml<Universidad> xml = new Xml<Universidad>();
            xml.Leer("universidad.xml", out u);
            return u;
        }

        private string MostrarDatos (Universidad uni)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in uni.jornadas)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

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
