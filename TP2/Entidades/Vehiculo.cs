using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo
    /// Por eso la clase es abstracta
    /// </summary>
    public abstract class Vehiculo
    {
        #region Atributos 

        private EMarca marca;
        private string chasis;
        private ConsoleColor color;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor con parametros que inicializa chasis, marca y color
        /// </summary>
        /// <param name="chasis"></param>
        /// <param name="marca"></param>
        /// <param name="color"></param>
        public Vehiculo(string chasis, EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }

        #endregion

        #region Enumerados

        /// <summary>
        /// Enumerado de las marcas
        /// </summary>
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }

        /// <summary>
        /// Enumerado del tamaño
        /// </summary>
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }

        #endregion

        #region Propiedad

        /// <summary>
        /// Propiedad de solo lectura
        /// Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio 
        { 
            get;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns> Retornara un string con todos los datos </returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }

        /// <summary>
        /// Conversor explicito de Vehiculo a string
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CHASIS: {0}\r\n", p.chasis);
            sb.AppendFormat("MARCA : {0}\r\n", p.marca.ToString());
            sb.AppendFormat("COLOR : {0}\r\n", p.color.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion

        #region Sobrecarga de operadores

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns> Retornara true si es igual o false si es distinto </returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns> Retornara el contrario del == </returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        #endregion

    }
}
