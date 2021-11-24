using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades
{
    public class Controladores : Agente
    {
        #region Atributo

        private bool lanzaHumo;

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor sin parametros necesitado por la serializacion
        /// </summary>
        public Controladores()
        {
        }

        /// <summary>
        /// Constructor que recibe nombre y llama al contructor que recibe nombre, si es radiante y si lanza humo
        /// Por defecto si es radiante y si lanza humo
        /// </summary>
        /// <param name="nombre"></param>
        public Controladores(string nombre) : this(nombre, true, true)
        {
        }

        /// <summary>
        /// Cosntructor que recibe el nombre y si es radiante y si laza humo, 
        /// Llama a la base para setear el nombre y si es radiante
        /// Luego setea si laza humo o no
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="esRadiante"></param>
        /// <param name="lanzaHumos"></param>
        public Controladores(string nombre, bool esRadiante, bool lanzaHumos) : base(nombre, esRadiante)
        {
            this.lanzaHumo = lanzaHumos;
        }

        #endregion

        #region Metodo

        /// <summary>
        /// Override del metodo MostrarAgente() 
        /// Agrega si laza humo o no
        /// </summary>
        /// <returns> Retorna un string con los datos del los agentes controladores </returns>
        public override string MostrarAgente()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarAgente());
            sb.AppendFormat("{0} lanza humo\n", this.lanzaHumo ? "Si" : "No");

            return sb.ToString();
        }

        #endregion
    }
}
