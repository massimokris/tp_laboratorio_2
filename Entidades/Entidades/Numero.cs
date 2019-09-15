using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {

        private double numero;

        public string SetNumero
        { 
            set
            {
                numero = ValidarNumero(value);
            }
        }

        #region Constructores
        /// <summary>
        /// Constructor vacio inicializa el Número en 0
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Constructor que valida que sea un número
        /// </summary>
        /// <param name="num">Double valor a asignar al número</param>
        public Numero(double num)
        {
            SetNumero = num.ToString();
        }

        /// <summary>
        /// Constructor que valida que sea número
        /// </summary>
        /// <param name="str">string valor a asignar al número</param>
        public Numero(string str)
        {
            SetNumero = str;
        }
        #endregion
        
        /// <summary>
        /// Valida que el string ingresado sea parceable a un double
        /// </summary>
        /// <param name="num">string a convertir en double</param>
        /// <returns>string pasado a double</returns>
        public double ValidarNumero(string num)
        {
            double respuesta = 0;
            if (double.TryParse(num, out respuesta)) { }

            return respuesta;
        }

        #region Conversores
        /// <summary>
        /// Recive un numero decimal y lo convierte en binario en caso de no poder retorna "Valor Inválido"
        /// </summary>
        /// <param name="num">numero tipo double a convertir a binario</param>
        /// <returns>numero convertido en binario o respuesta de error</returns>
        public static string DecimalBinario(double num)
        {
            double resto = 0;
            double resultado = 0;
            string binario = "";
            string nuevoBinario = "";
            StringBuilder aux = new StringBuilder("");

            if (num != 1)
            {
                resultado = num;

                while (resultado / 2 > 1)
                {
                    resto = resultado % 2;
                    aux.Append(resto.ToString());
                    resultado = resultado / 2;
                }

                resto = resultado % 2;
                resultado = resultado / 2;

                aux.Append(resto.ToString());
                aux.Append(resultado.ToString());
                nuevoBinario = aux.ToString();

                for (int i = nuevoBinario.Length - 1; i >= 0; i--)
                {
                    binario += nuevoBinario[i];
                }
            }
            else
            {
                binario = num.ToString();
            }

            return binario;
        }

        /// <summary>
        /// Recive un string como numero decimal y lo convierte a binario en caso de no poder retorna "Valor Inválido"
        /// </summary>
        /// <param name="str">string decimal a convertir en binario</param>
        /// <returns>string convertido en binario o respuesta de error</returns>
        public static string DecimalBinario(string str)
        {
            double num;
            string binario = "Valor Inválido";

            if (double.TryParse(str, out num))
            {
                binario = DecimalBinario(num);
            }

            return binario;

        }

        /// <summary>
        /// Recive un string numerico binario y retorna un string numerico decimal en caso de no error retorna "Valor Inválido"
        /// </summary>
        /// <param name="num">string a convertir en decimal</param>
        /// <returns>string numerico decimal o mensaje de error</returns>
        public static string BinarioDecimal(string num)
        {

            string response = "0";

            char[] array = num.ToCharArray();

            Array.Reverse(array);

            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] == '1')
                {

                    response += (int)Math.Pow(2, i);
                }
            }

            if(response == "0" && num != "0")
            {
                response = "Valor Inválido";
            }

            return response;
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Suma de dos objetos tipo Numero
        /// </summary>
        /// <param name="num1">Objeto 1</param>
        /// <param name="num2">Objeto 2</param>
        /// <returns>double con el resultado de la suma</returns>
        public static double operator +(Numero num1, Numero num2)
        {
            return num1.numero + num2.numero;
        }

        /// <summary>
        /// Resta de dos objetos tipo Numero
        /// </summary>
        /// <param name="num1">objeto 1</param>
        /// <param name="num2">objeto 2 a restar</param>
        /// <returns>double con el resultado de la resta</returns>
        public static double operator -(Numero num1, Numero num2)
        {
            return num1.numero - num2.numero;
        }

        /// <summary>
        /// Multiplicacion de dos objetos tipo numero
        /// </summary>
        /// <param name="num1">Objeto 1</param>
        /// <param name="num2">Objeto 2</param>
        /// <returns>double con el resultado de la multiplicación</returns>
        public static double operator *(Numero num1, Numero num2)
        {
            return num1.numero * num2.numero;
        }

        /// <summary>
        /// División de dos objetos tipo Número
        /// </summary>
        /// <param name="num1">objeto 1</param>
        /// <param name="num2">objeto 2 a dividir</param>
        /// <returns>double con el resultado de la división, en caso de división por 0 retorna "double.MinValue"</returns>
        public static double operator /(Numero num1, Numero num2)
        {
            double resultado = double.MinValue;

            if(num2.numero != 0)
            {
                resultado = num1.numero / num2.numero;
            }

            return resultado;
        }
        #endregion
    }
}
