using System;
using System.Collections.Generic;
using System.Text;

namespace Excepciones
{
    public class NacionalidadInvalidaException : Exception
    {

        public NacionalidadInvalidaException () : this("Nacionalidad invalida para el dni") { }

        public NacionalidadInvalidaException (string message) : base(message) { }
    }
}
