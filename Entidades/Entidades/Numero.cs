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
            int modulo = 0;
            int resultado = 0;
            string binario = "";
            string auxBinario = "";
            StringBuilder aux = new StringBuilder("");

            if (num > 1)
            {
                resultado = (int)num;

                while (resultado / 2 != 1)
                {
                    modulo = resultado % 2;
                    aux.Append(modulo.ToString());

                    resultado = resultado / 2;
                }

                modulo = resultado % 2;
                resultado = resultado / 2;

                aux.Append(modulo.ToString());
                aux.Append(resultado.ToString());
                auxBinario = aux.ToString();

                for (int i = auxBinario.Length - 1; i >= 0; i--)
                {
                    binario += auxBinario[i];
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
            string binario = "Valor invalido";
            string nuevoBinario = "";
            double num;
            int resto;
            int i;

            if (double.TryParse(str, out num))
            {
                num = Math.Truncate(Math.Abs(num));
                binario = DecimalBinario(num);

                if (binario.Length >= 5)
                {
                    resto = binario.Length % 4;
                    for (i = 0; i < resto; i++)
                    {
                        nuevoBinario += binario[i];
                    }

                    nuevoBinario += ' ';
                    for (int j = 0; i < binario.Length; i++, j++)
                    {
                        nuevoBinario += binario[i];
                        if (j == 3)
                        {
                            if (i != binario.Length - 1)
                            {
                                nuevoBinario += ' ';
                            }

                            j = -1;
                        }
                    }
                    binario = nuevoBinario;
                }
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
            double acumulador = 0;
            string decima = "Valor invalido";
            string binario;
            int i;

            if (num != "")
            {
                binario = num.Replace(" ", "");

                for (i = 0; i < binario.Length; i++)
                {
                    if (binario[i] != '1' && binario[i] != '0')
                    {
                        break;
                    }
                }

                if (i == binario.Length)
                {
                    for (int j = binario.Length - 1, exp = 0; j >= 0; j--, exp++)
                    {
                        if (binario[j] == '1')
                        {
                            acumulador += Math.Pow(2, exp);
                        }
                    }

                    decima = acumulador.ToString();
                }
            }

            return decima;
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
