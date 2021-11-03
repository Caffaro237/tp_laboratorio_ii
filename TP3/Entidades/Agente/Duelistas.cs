using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Duelistas : Agente
    {
        private bool lanzaFuego;

        public bool LanzaFuego
        {
            get 
            { 
                return this.lanzaFuego; 
            }
            set 
            {
                this.lanzaFuego = value; 
            }
        }


        public Duelistas(string nombre) : this(nombre, true, true)
        {
        }

        public Duelistas(string nombre, bool esRadiante, bool lanzaFuego) : base(nombre, esRadiante)
        {
            this.lanzaFuego = lanzaFuego;
        }

        public override string MostrarAgente()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarAgente());
            sb.AppendFormat("{0} lanza fuego", this.lanzaFuego ? "Si" : "No");

            return sb.ToString();
        }
    }
}
