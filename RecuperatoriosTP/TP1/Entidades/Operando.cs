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
            this.numero = 0;
        }

        public Operando(double numero)
        {
            this.numero = numero;
        }

        public Operando(string srtNumero)
        {
            this.Numero = srtNumero;
        }

        #endregion

        #region Propiedades

        public string Numero
        {
            set
            {
                this.numero = this.ValidarOperando(value);
            }
        }

        #endregion

        #region Metodos

        private double ValidarOperando(string strNumero)
        {
            double numero;

            if(double.TryParse(strNumero, out numero))
            {
                return numero;
            }

            return 0;
        }

        public string BinarioDecimal(string binario)
        {
            if (this.EsBinario(binario))
            {
                return Convert.ToUInt64(binario, 2).ToString();
            }

            return "Valor invalido";
        }

        public string DecimalBinario(double numero)
        {
            string retornoBinario = "";
            UInt64 numeroNatural;

            numeroNatural = (UInt64)Math.Abs(numero);

            if (numeroNatural == 0)
            {
                retornoBinario = "0";
            }

            while (numeroNatural > 0)
            {
                if (numeroNatural % 2 == 0)
                {
                    retornoBinario = "0" + retornoBinario;
                }
                else
                {
                    retornoBinario = "1" + retornoBinario;
                }

                numeroNatural = numeroNatural / 2;
            }

            return retornoBinario;
        }

        public string DecimalBinario(string strNumero)
        {
            string retorno = "Valor invalido";

            if (double.TryParse(strNumero, out this.numero))
            {
                if (this.numero > 0)
                {
                    retorno = this.DecimalBinario(this.numero);
                }
            }

            return retorno;
        }

        private bool EsBinario(string binario)
        {
            if (binario.Length == 0)
            {
                return false;
            }

            foreach (char item in binario)
            {
                if (item != '0' && item != '1')
                {
                    return false;
                }
            }

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
