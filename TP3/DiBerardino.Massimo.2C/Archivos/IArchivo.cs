using System;
using System.Collections.Generic;
using System.Text;

namespace Archivos
{
    public interface IArchivo<T>
    {
        bool Guardar(string archivo, T datos);
        bool Leer(string archivo, out T datos);
    }
}
