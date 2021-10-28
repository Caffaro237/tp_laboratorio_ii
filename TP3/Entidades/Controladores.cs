using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Controladores : Agente
    {
        bool tieneHumos;

        public Controladores(string nombre) : this(nombre, false, true)
        {
        }

        public Controladores(string nombre, bool esRadiante, bool tieneHumos) : base(nombre, esRadiante)
        {
            this.tieneHumos = tieneHumos;
        }
    }
}
