﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class GuardarString
    {
        /// <summary>
        /// escribir datos en un archivo de texto
        /// </summary>
        /// <param name="texto">texto a escribir</param>
        /// <param name="archivo">archivo donde se escribira el texto</param>
        /// <returns></returns>
        public static bool Guardar(this string texto, string archivo)
        {
            bool validation = true;
            string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), archivo);
            bool append = File.Exists(ruta);
            StreamWriter writer = new StreamWriter(ruta, append);
            try
            {
                writer.WriteLine(texto);
            }
            catch (Exception e)
            {
                validation = false;
                throw new Exception("Error al escribir el archivo", e);
                
            }
            finally
            {
                writer.Close();
            }
            return validation;
        }
    }
}