using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public int DNI
        {
            get { return this.dni; }
            set;
        }

        public ENacionalidad Nacionalidad
        {
            get { return this.nacionalidad; }
            set { this.nacionalidad = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set;
        }

        public string StringToDNI
        {
            set;
        }
        #endregion

        #region CONSTRUCTORES

        public Persona() { }

        public Persona (string nombre, string apellido, ENacionalidad nacionalidad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Nacionalidad = nacionalidad;
        }

        public Persona (string nombre, string apellido, int dni, ENacionalidad nacionalidad) : this (nombre, apellido, nacionalidad)
        {
            DNI = dni;
        }

        public Persona (string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this (nombre, apellido, nacionalidad)
        {
            StringToDNI = dni;
        }

        #endregion

        #region SOBRECARGA

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre completo: {this.apellido}, {this.nombre}");
            sb.AppendLine($"Nacionalidad: {this.nacionalidad}");
            sb.AppendLine($"DNI: {this.dni}");
            return base.ToString();
        }

        #endregion

        #region METODOS

        private int ValidarDni (ENacionalidad nacionalidad, int dato)
        {
            int validar = 0;

            if(nacionalidad == ENacionalidad.Argentino)
            {
                if(dato >= 1 && dato <= 89999999)
                {
                    validar = 1;
                }
            }
            else
            {
                if(dato >= 90000000 && dato <= 99999999)
                {
                    validar = 1;
                }
            }

            return validar;
        }

        private int ValidarDni (ENacionalidad nacionalidad, string dato)
        {
            int dni;
            int validar = 0;
            if(int.TryParse(dato, out dni))
            {
                validar = ValidarDni(nacionalidad, dni);
            }

            return validar;
        }

        private string ValidarNombreApellido (string dato)
        {

        }

        #endregion

        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }
    }
}
