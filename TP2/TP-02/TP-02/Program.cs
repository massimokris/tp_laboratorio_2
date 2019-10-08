using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_2018;

namespace TP_02_2018
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configuración de la pantalla
            Console.SetWindowPosition(0, 0);
            Console.SetWindowSize(Console.LargestWindowWidth / 2, Console.LargestWindowHeight - 2);

            // Nombre del alumno
            Console.Title = "Massimo Di Berardino - 2C";

            Changuito changoDeCompras = new Changuito(6);

            Dulce c1 = new Dulce("ASD012", Producto.EMarca.Sancor, ConsoleColor.Black);
            Dulce c2 = new Dulce("ASD913", Producto.EMarca.Ilolay, ConsoleColor.Red);
            Leche m1 = new Leche("HJK789", Producto.EMarca.Pepsico, ConsoleColor.White);
            Leche m2 = new Leche("IOP852", Producto.EMarca.Serenisima, ConsoleColor.Blue, Leche.ETipo.Descremada);
            Snacks a1 = new Snacks("QWE968", Producto.EMarca.Campagnola, ConsoleColor.Gray);
            Snacks a2 = new Snacks("TYU426", Producto.EMarca.Arcor, ConsoleColor.DarkBlue);
            Snacks a3 = new Snacks("IOP852", Producto.EMarca.Sancor, ConsoleColor.Green);
            Snacks a4 = new Snacks("TRE321", Producto.EMarca.Sancor, ConsoleColor.Green);

            // Agrego 8 ítems (los últimos 2 no deberían poder agregarse ni el m1 repetido) y muestro
            changoDeCompras += c1;
            changoDeCompras += c2;
            changoDeCompras += m1;
            changoDeCompras += m1;
            changoDeCompras += m2;
            changoDeCompras += a1;
            changoDeCompras += a2;
            changoDeCompras += a3;
            changoDeCompras += a4;

            Console.WriteLine(changoDeCompras.ToString());
            Console.WriteLine("<-----------PRESIONE UNA TECLA PARA CONTINUAR----------->");
            Console.ReadKey();
            Console.Clear();

            // Quito un item y muestro
            changoDeCompras -= c1;

            Console.WriteLine(changoDeCompras.ToString());
            Console.WriteLine("<-----------PRESIONE UNA TECLA PARA CONTINUAR----------->");
            Console.ReadKey();
            Console.Clear();

            // Muestro solo Dulces
            Console.WriteLine(Changuito.Mostrar(changoDeCompras, Changuito.ETipo.Dulce));
            Console.WriteLine("<-----------PRESIONE UNA TECLA PARA CONTINUAR----------->");
            Console.ReadKey();
            Console.Clear();

            // Muestro solo Leches
            Console.WriteLine(Changuito.Mostrar(changoDeCompras, Changuito.ETipo.Leche));
            Console.WriteLine("<-----------PRESIONE UNA TECLA PARA CONTINUAR----------->");
            Console.ReadKey();
            Console.Clear();

            // Muestro solo Snacks
            Console.WriteLine(Changuito.Mostrar(changoDeCompras, Changuito.ETipo.Snacks));
            Console.WriteLine("<-------------PRESIONE UNA TECLA PARA SALIR------------->");
            Console.ReadKey();
        }
    }
}
