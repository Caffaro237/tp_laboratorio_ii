using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        #region Atributos

        private double numero;

        #endregion

        #region Constructores

        public Operando()
        {

        }

        public Operando(double numero)
        {

        }

        public Operando(string srtNumero)
        {

        }

        #endregion

        #region Propiedades

        /*public string Numero
        {
            set
            {
                this.numero = value;
            }
        }*/

        #endregion

        #region Metodos

        public double ValidarOperando(string strNumero)
        {
            return 0;
        }

        public string BinarioDecimal(string binario)
        {
            return "";
        }

        public string DecimalBinario(double numero)
        {
            return "";
        }

        public string DecimalBinario(string strNumero)
        {
            return "";
        }

        private bool EsBinario(string binario)
        {
            return true;
        }

        #endregion

        #region Sobrecarga de operadores

        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }
        public static double operator /(Operando n1, Operando n2)
        {
            if(n2.numero == 0)
            {
                return double.MinValue;
            }

            return n1.numero / n2.numero;
        }
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        #endregion

    }
}
