using System;

namespace Entidades
{
    public static class Calculadora
    {
        public static double Operar(Operando n1, Operando n2, char operador)
        {
            char operadorValidado = Calculadora.ValidarOperador(operador);

            switch (operador)
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
