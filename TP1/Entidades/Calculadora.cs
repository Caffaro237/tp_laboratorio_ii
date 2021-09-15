using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        #region Metodo Operar

        /// <summary>
        /// Recibe numero1 y numero2 y segun el operador seleccionado
        /// es con el que se va a operar en la calculadora 
        /// </summary>
        /// <param name = "numero1"></param>
        /// <param name = "numero2"></param>
        /// <param name = "operador"></param>
        /// <returns>Retornara el resultado en base al operador que se selecciono</returns>
        public static double Operar(Operando numero1, Operando numero2, string operador)
        {
            double resultado = 0;
            char operadorChar = ' ';
            bool operadorVerificado = false;

            operadorVerificado = char.TryParse(operador, out operadorChar);

            if(operadorVerificado)
            {
                operador = Calculadora.ValidarOperador(operadorChar);

                switch(operador)
                {
                    case "+":
                        resultado = numero1 + numero2;
                        break;

                    case "-":
                        resultado = numero1 - numero2;
                        break;

                    case "*":
                        resultado = numero1 * numero2;
                        break;

                    case "/":
                        resultado = numero1 / numero2;
                        break;
                }
            }

            return resultado;
        }

        #endregion

        #region Validacion

        /// <summary>
        /// Este metodo lo que realiza es validar si el operador seleccionado es
        /// suma, resta, multiplicacion o division.
        /// Devuelve el parametro como tipo string
        /// </summary>
        /// <param name="operador"></param>
        /// <returns> Retornara el operador validado y convertido a String </returns>
        private static string ValidarOperador(char operador)
        {
            string validarOperador = "+";

            if(operador == '*' || operador == '/' || operador == '-')
            {
                validarOperador = operador.ToString();
            }

            return validarOperador;
        }
    }

    #endregion
}
