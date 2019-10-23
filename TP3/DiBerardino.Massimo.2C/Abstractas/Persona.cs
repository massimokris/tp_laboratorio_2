using System;

namespace Abstractas
{
    public abstract class Persona
    {

        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        private string nombre;

        #region PROPRIEDADES
        public string Apellido
        {
            get;
            set;
        }

        public int DNI
        {
            get;
            set;
        }

        public ENacionalidad Nacionalidad
        {
            get;
            set;
        }

        public string Nombre
        {
            get;
            set;
        }

        public string StringToDNI
        {
            set;
        }
        #endregion

        #region CONSTRUCTORES

        public Persona() { }

        public Persona (string nombre, string apellido, ENacionalidad nacionalidad) { }

        public Persona (string nombre, string apellido, int dni, ENacionalidad nacionalidad) { }

        public Persona (string nombre, string apellido, string dni, ENacionalidad nacionalidad) { }

        #endregion

        #region SOBRECARGA

        public override string ToString()
        {
            return base.ToString();
        }

        #endregion

        #region METODOS

        private int ValidarDni (ENacionalidad nacionalidad, int dato) { }

        private int ValidarDni (ENacionalidad nacionalidad, string dato) { }

        private ValidarNombreApellido (string dato) { }

        #endregion

        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }
    }
}
