using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Instanciables;
using Excepciones;
using Archivos;
using Abstractas;

namespace Test
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestDNI()
        {
            int expected = 95744541;
            Alumno a = new Alumno(1, "test", "example", "95744541", Persona.ENacionalidad.Extranjero, Universidad.EClases.Programacion);
            Assert.AreEqual(expected, a.DNI);
        }

        [TestMethod]
        public void TestNull()
        {
            Jornada j = new Jornada(Universidad.EClases.Laboratorio, new Profesor());
            Assert.IsNotNull(j.Alumnos);
        }

        [TestMethod]
        [ExpectedException(typeof(ArchivosException))]
        public void TestArchivoTexto()
        {
            string dato = "";
            Texto t = new Texto();
            t.Leer("tets.txt", out dato);
        }

        [TestMethod]
        [ExpectedException(typeof(ArchivosException))]
        public void TestArchivoXml()
        {
            string dato = "";
            Xml<string> x = new Xml<string>();
            x.Leer("test.xml", out dato);
        }

        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void TestExcepcionDNIPersona()
        {
            new Profesor(1, "test", "example", "abcd", Persona.ENacionalidad.Argentino);
        }


    }
}
