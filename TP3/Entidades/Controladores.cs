using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Controladores : Agente
    {
        bool lanzaHumos;

        public Controladores(string nombre) : this(nombre, false, true)
        {
        }

        public Controladores(string nombre, bool esRadiante, bool tieneHumos) : base(nombre, esRadiante)
        {
            this.lanzaHumos = tieneHumos;
        }

        protected override string MostrarAgente()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarAgente());
            sb.AppendFormat("Lanza humos: {0}", this.lanzaHumos ? "Si" : "No");

            return sb.ToString();
        }
    }
}
