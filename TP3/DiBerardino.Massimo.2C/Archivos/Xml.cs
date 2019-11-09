using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using Excepciones;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public bool Guardar(string archivo, T datos)
        {
            bool validation = true;
            
            try
            {
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), archivo);
                XmlTextWriter writer = new XmlTextWriter(path, System.Text.Encoding.UTF8);
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(writer, datos);
                writer.Close();
            }
            catch (Exception e)
            {
                validation = false;
                throw new ArchivosException(e);
            }
            return validation;
        }
        public bool Leer(string archivo, out T datos)
        {
            bool validation = true;
            try
            {
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), archivo);
                XmlTextReader reader = new XmlTextReader(path);
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                datos = (T)serializer.Deserialize(reader);
                reader.Close();
            }
            catch (Exception e)
            {
                datos = default(T);
                validation = false;
                throw new ArchivosException(e);
            }
            return validation;
        }
    }
}
