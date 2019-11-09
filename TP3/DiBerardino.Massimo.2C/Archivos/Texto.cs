using System;
using System.IO;
using Excepciones;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {

        public bool Guardar (string archivo, string datos)
        {
            bool validation = true;
            try
            {
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), archivo);

                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine(datos);
                }
            }
            catch (Exception e)
            {
                validation = false;
                throw new ArchivosException(e);
            }
            return validation;
        }

        public bool Leer (string archivo, out string datos)
        {
            bool validation = true;
            try
            {
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), archivo);
                using (StreamReader reader = new StreamReader(path))
                {
                    datos = reader.ReadToEnd();
                }
            }
            catch (Exception e)
            {

                validation = false;
                datos = "No se pudo leer";
                throw new ArchivosException(e);
            }
            return validation;
        }
    }
}
