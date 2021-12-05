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

        /// <summary>
        /// Constructor por defecto sin parametros que inicializa el numero en 0
        /// </summary>
        public Operando() : this(0)
        {
        }

        /// <summary>
        /// Constructor que recibe un numero double
        /// Este llamara al constructor que recibe un string 
        /// y le pasara el double convertido
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero) : this(numero.ToString())
        {
        }

        /// <summary>
        /// Constructor que recibe un numero como string
        /// Este llamara al constructor si parametros que inicializara el numero en 0
        /// </summary>
        /// <param name="srtNumero"></param>
        public Operando(string srtNumero)
        {
            this.Numero = srtNumero;
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Propiedad Numero que recibira un string lo validara y seteara
        /// </summary>
        public string Numero
        {
            set
            {
                this.numero = this.ValidarOperando(value);
            }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Metodo que validara el numero como string y lo convertira a double
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns> Retornara el numero como double validado </returns>
        private double ValidarOperando(string strNumero)
        {
            double numero;

            if(double.TryParse(strNumero, out numero))
            {
                return numero;
            }

            return 0;
        }

        /// <summary>
        /// Metodo BinarioDecimal
        /// Primero verificara que se trate de un numero binario y luego
        /// a traves del metodo ToUInt64 convertira el binario a decimal
        /// </summary>
        /// <param name="binario"></param>
        /// <returns> Retornara un string con el binario convertido o valor invalido </returns>
        public string BinarioDecimal(string binario)
        {
            if (this.EsBinario(binario))
            {
                return Convert.ToUInt64(binario, 2).ToString();
            }

            return "Valor invalido";
        }

        /// <summary>
        /// Metodo DecimalBinario que recibe un double como parametro
        /// Este metodo convertira el parametro double a numero natural
        /// Si es igual a 0 retornara 0
        /// si no lo es iterara mientras que el numero natural sea mayor a 0
        /// una vez terminado retornara el string con el binario creado
        /// </summary>
        /// <param name="numero"></param>
        /// <returns> Retornara un string con el binario </returns>
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

        /// <summary>
        /// Metodo DecimalBinariorecibe un string como parametro
        /// Este metodo sirve para saber si se trata de un numero valido para convertirlo
        /// Una vez validado llamara DecimalBinario que recibe un double.
        /// Si no es un numero valido retornara Valor invalido
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns> Retornara Valor invalido o el decimal convertido a binario </returns>
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

        /// <summary>
        /// Metodo EsBinario
        /// Este validara que se trate de un numero binario
        /// y retornara true o false
        /// </summary>
        /// <param name="binario"></param>
        /// <returns> Retornara true si se pudo validar que es un numero binario, de lo contrario retornara false </returns>
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

        /// <summary>
        /// Sobrecarga del operador +
        /// Sumara los numeros
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns> Retornara la suma de los numeros </returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador -
        /// Restara los numeros
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns> Retornara la resta de los numeros </returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador /
        /// Dividira los numeros
        /// Si n2 (El divisor) es igual a 0 
        /// retornara el valor minimo de double
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns> Retornara la division de los numeros </returns>
        public static double operator /(Operando n1, Operando n2)
        {
            if(n2.numero == 0)
            {
                return double.MinValue;
            }

            return n1.numero / n2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador *
        /// Multiplicara los numeros
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns> Retornara la multiplicacion de los numeros </returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        #endregion

    }
}
