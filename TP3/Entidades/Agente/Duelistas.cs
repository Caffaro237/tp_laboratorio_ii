using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades
{
    public class Duelistas : Agente
    {
        #region Atributo

        private bool lanzaFuego;

        #endregion

        #region Constructores 

        /// <summary>
        /// Constructor sin parametros necesitado por la serializacion
        /// </summary>
        public Duelistas()
        {
        }

        /// <summary>
        /// Constructor que recibe nombre y llama al contructor que recibe nombre, si es radiante y si lanza fuego
        /// Por defecto si es radiante y si lanza fuego
        /// </summary>
        /// <param name="nombre"></param>
        public Duelistas(string nombre) : this(nombre, true, true)
        {
        }

        /// <summary>
        /// Cosntructor que recibe el nombre y si es radiante y si laza fuego, 
        /// Llama a la base para setear el nombre y si es radiante
        /// Luego setea si laza fuego o no
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="esRadiante"></param>
        /// <param name="lanzaFuego"></param>
        public Duelistas(string nombre, bool esRadiante, bool lanzaFuego) : base(nombre, esRadiante)
        {
            this.lanzaFuego = lanzaFuego;
        }

        #endregion

        #region Metodo

        /// <summary>
        /// Override del metodo MostrarAgente() 
        /// Agrega si laza fuego o no
        /// </summary>
        /// <returns> Retorna un string con los datos del los agentes duelistas </returns>
        public override string MostrarAgente()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarAgente());
            sb.AppendFormat("{0} lanza fuego\n", this.lanzaFuego ? "Si" : "No");

            return sb.ToString();
        }

        #endregion
    }
}
