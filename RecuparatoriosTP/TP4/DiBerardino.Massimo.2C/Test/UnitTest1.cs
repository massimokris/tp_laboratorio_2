using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(TrackingIdRepetidoException))]
        public void DosPaquetesIguales()
        {
            Correo cr = new Correo();
            Paquete p1 = new Paquete("utn", "12345678");
            Paquete p2 = new Paquete("utn2", "12345678");
            cr += p1;
            cr += p2;
            cr.FinEntregas();
        }

        [TestMethod]
        public void InstanciarLista()
        {
            Correo cr = new Correo();
            Assert.IsNotNull(cr.Paquetes);
        }
    }
}
