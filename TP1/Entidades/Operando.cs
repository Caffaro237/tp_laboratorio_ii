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

        #region Propiedades

        public string SetNumero
        {
            set
            {
                this.numero = this.ValidarOperando(value);
            }
        }

        #endregion

        #region Constructores

        public Operando()
        {
            numero = 0;
        }

        public Operando(double numero)
        {
            this.numero = numero;
        }

        public Operando(string strNumero)
        {
            this.SetNumero = strNumero;
        }

        #endregion

        #region Conversiones

        /// <summary>
        /// El metodo se inicializa en "Valor invalido"
        /// Llama al metodo EsBinario si este retorna true ingresa al if 
        /// y convierte el numero binario a decimal
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>Si todo sale bien retorna el numero binario convertido a decimal, sino retornara "Valor invalido"</returns>
        public string BinarioDecimal(string binario)
        {
            string resultado = "Valor invalido";

            if (this.EsBinario(binario))
            {
                resultado = Convert.ToUInt64(binario, 2).ToString();
            }

            return resultado;
        }

        /// <summary>
        /// Lo que realiza este metodo es iterar por todo el numero cambiando
        /// uno por uno a 0 o a 1 respectivamente
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Si todo sale bien retorna el numero convertido a binario, sino retornara "0"</returns>
        public string DecimalBinario(double numero)
        {
            string retornoBinario = "";
            UInt64 numeroNatural;

            numeroNatural = (UInt64)Math.Abs(numero);

            if(numeroNatural == 0)
            {
                retornoBinario = "0";
            }

            while(numeroNatural > 0)
            {
                if(numeroNatural % 2 == 0)
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
        /// El metodo se inicializa en "Valor invalido"
        /// Intenta parsear de string a double, una vez dentro del if llama al metodo
        /// sobrecargado con un double como parametro
        /// y convierte el numero decimal a binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Si todo sale bien retorna el numero decimal convertido a binario, sino retornara "Valor invalido"</returns>
        public string DecimalBinario(string numero)
        {
            string retorno = "Valor invalido";

            if (double.TryParse(numero, out this.numero))
            {
                if (this.numero > 0)
                {
                    retorno = this.DecimalBinario(this.numero);
                }
            }

            return retorno;
        }

        /// <summary>
        /// Este metodo verifica caracter por caracter si se trata
        /// de ceros y unos, si son distintos detendra el proceso
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>Restornara true o false dependiendo si fue verificado correctamente o no</returns>
        private bool EsBinario(string binario)
        {
            bool binarioVerificado = true;

            if (binario.Length == 0)
            {
                binarioVerificado = false;
            }

            foreach (char item in binario)
            {
                if (item != '0' && item != '1')
                {
                    binarioVerificado = false;
                    break;
                }
            }

            return binarioVerificado;
        }

        #endregion

        #region Sobrecarga de Operadores

        /// <summary>
        /// Sobrecarga del operador +
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <returns>Retorna la suma de los numeros</returns>
        public static double operator +(Operando numero1, Operando numero2)
        {
            return numero1.numero + numero2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador -
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <returns>Retorna la resta de los numeros</returns>
        public static double operator -(Operando numero1, Operando numero2)
        {
            return numero1.numero - numero2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador *
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <returns>Retorna la multiplicacion de los numeros</returns>
        public static double operator *(Operando numero1, Operando numero2)
        {
            return numero1.numero * numero2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador /
        /// Validando anteriormente que el divisor no sea igual a 0
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <returns>Retorna la division de los numeros, si es distindo de 0. Sino retorna el valor minimo de double</returns>
        public static double operator /(Operando numero1, Operando numero2)
        {
            double resutadoDivision = double.MinValue;

            if (numero2.numero != 0)
            {
                resutadoDivision = numero1.numero / numero2.numero;
            }

            return resutadoDivision;
        }

        #endregion

        #region Validacion

        /// <summary>
        /// Metodo de validacion del numero 
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>Si se pudo hacer la validacion retorna el numero parseado a double, sino retornara 0</returns>
        private double ValidarOperando(string strNumero)
        {
            double numeroValidado;
            bool intentoParse = false;

            intentoParse = double.TryParse(strNumero, out numeroValidado);

            if (intentoParse)
            {
                return numeroValidado;
            }

            return 0;
        }

        #endregion

    }
}
