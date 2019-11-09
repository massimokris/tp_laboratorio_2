using System;

namespace Excepciones
{
    public class AlumnoRepetidoException : Exception
    {

        public AlumnoRepetidoException ():base("El alumno ya esta en la lista") { }
    }
}
