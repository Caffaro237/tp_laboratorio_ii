using System;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Metodo Operar
        /// Recibira dos numeros y un operador de tipo char
        /// Llamara a validar operador
        /// Luego a travez de un switch retornara la operacion requerida
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <param name="operador"></param>
        /// <returns> Retornara un double segun la operacion requerida usando las sobrecargas </returns>
        public static double Operar(Operando n1, Operando n2, char operador)
        {
            char operadorValidado = Calculadora.ValidarOperador(operador);

            switch (operadorValidado)
            {
                case '+':
                    return n1 + n2;

                case '-':
                    return n1 - n2;

                case '/':
                    return n1 / n2;

                case '*':
                    return n1 * n2;

                default:
                    return 0;
            }
        }

        /// <summary>
        /// Metodo Validar Operador
        /// Este validara que se trate de un operador
        /// De no ser correcto retornara + por defecto
        /// </summary>
        /// <param name="operador"></param>
        /// <returns> Retornara un char del operador validado </returns>
        public static char ValidarOperador(char operador)
        {
            char validarOperador = '+';

            if (operador == '*' || operador == '/' || operador == '-')
            {

                validarOperador = operador;
            }

            return validarOperador;
        }
    }
}
