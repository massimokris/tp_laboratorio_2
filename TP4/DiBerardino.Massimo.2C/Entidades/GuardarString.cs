using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class GuardarString
    {
        public static bool Guardar(this string texto, string archivo)
        {
            bool validation = true;
            try
            {
                string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), archivo);

                using (StreamWriter writer = new StreamWriter(ruta))
                {
                    writer.WriteLine(texto, true);
                }
            }
            catch (Exception e)
            {
                validation = false;
            }
            return validation;
        }
    }
}
