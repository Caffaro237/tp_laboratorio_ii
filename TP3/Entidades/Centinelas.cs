using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Centinelas : Agente
    {
        public Centinelas(string nombre) : this(nombre, false)
        {
        }

        public Centinelas(string nombre, bool esRadiante) : base(nombre, esRadiante)
        {
        }
    }
}
