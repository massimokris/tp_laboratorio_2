using System;
using System.Collections.Generic;
using System.Text;

namespace Excepciones
{
    public class DniInvalidoException : Exception
    {

        private const string mensajeBase = "DNI invalido";

        public DniInvalidoException () : this(mensajeBase) { }

        public DniInvalidoException (Exception e) : this(mensajeBase, e){ }

        public DniInvalidoException (string message) : base(message){ }

        public DniInvalidoException (string message, Exception e) : base(message, e) { }
    }
}
