using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        #region Atributo 

        private ETipo tipo;

        #endregion

        #region Enumerado 

        /// <summary>
        /// Enumerado del tipo
        /// </summary>
        public enum ETipo
        { 
            CuatroPuertas, CincoPuertas 
        }

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor que llama a la base para inicalizar el vehiculo
        /// Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
            tipo = ETipo.CuatroPuertas;
        }

        /// <summary>
        /// Constructor que recibe el tipo de Sedan
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        /// <param name="tipo"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo) 
            : this(marca, chasis, color)
        {
            this.tipo = tipo;
        }

        #endregion

        #region Propiedad

        /// <summary>
        /// Override de la propiedad Tamaño
        /// Sedan son 'Mediano'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }

        #endregion

        #region Metodo

        /// <summary>
        /// Override del metodo Mostrar
        /// </summary>
        /// <returns> Retornara los datos de la base y agregara el tamaño y el tipo </returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            sb.AppendLine("");
            sb.AppendFormat("TIPO : {0}", this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion
    }
}
