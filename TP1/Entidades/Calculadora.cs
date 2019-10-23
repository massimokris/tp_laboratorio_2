using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        /// <summary>
        ///  Validar un operador aritmetico entre (+, -, /, *), en caso de error retorna "+"
        /// </summary>
        /// <param name="operador">Operador a validar</param>
        /// <returns>el mismo operador ingresado, en caso de error retorna "+"</returns>
        private static string ValidarOperador(string operador)
        {
            string respuesta = "+";

            if (operador == "+"
                || operador == "/"
                || operador == "*"
                || operador == "-")
            {
                respuesta = operador;
            }

            return respuesta;
        }

        /// <summary>
        /// Operacion entre dos objetos tipo Número
        /// </summary>
        /// <param name="num1">objeto 1</param>
        /// <param name="num2">objeto 2</param>
        /// <param name="operador">operacion a realizar</param>
        /// <returns>resultado de la operación, en caso de un operador invalido retorna "num1+num2"</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double resultado = 0;

            switch (ValidarOperador(operador))
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
            }

            return resultado;
        }
    }
}
