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

        public Duelistas()
        {
        }

        
        public Duelistas(string nombre) : this(nombre, true, true)
        {
        }

        public Duelistas(string nombre, bool esRadiante, bool lanzaFuego) : base(nombre, esRadiante)
        {
            this.lanzaFuego = lanzaFuego;
        }

        #endregion

        #region Metodo

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
