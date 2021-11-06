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
        private bool lanzaHumo;

        public Controladores()
        {
        }

        
        public Controladores(string nombre) : this(nombre, true, true)
        {
        }

        public Controladores(string nombre, bool esRadiante, bool lanzaHumos) : base(nombre, esRadiante)
        {
            this.lanzaHumo = lanzaHumos;
        }

        public override string MostrarAgente()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarAgente());
            sb.AppendFormat("{0} lanza humo\n", this.lanzaHumo ? "Si" : "No");

            return sb.ToString();
        }
    }
}
