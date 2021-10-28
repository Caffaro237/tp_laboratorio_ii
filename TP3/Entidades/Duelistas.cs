using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Duelistas : Agente
    {
        bool lanzaFuego;

        public Duelistas(string nombre) : this(nombre, true, true)
        {
        }

        public Duelistas(string nombre, bool esRadiante) : this(nombre, true, false)
        {
        }

        public Duelistas(string nombre, bool esRadiante, bool lanzaFuego) : base(nombre, esRadiante)
        {
            this.lanzaFuego = lanzaFuego;
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDatos());
            sb.AppendFormat("Lanza Fuego: {1}", this.lanzaFuego ? "Si" : "No");

            return sb.ToString();
        }
    }
}
