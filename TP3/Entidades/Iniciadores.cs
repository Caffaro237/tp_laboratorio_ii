using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Iniciadores : Agente
    {
        bool revelaZonas;

        public Iniciadores(string nombre) : this(nombre, false, true)
        {
        }

        public Iniciadores(string nombre, bool esRadiante, bool revelaZonas) : base(nombre, esRadiante)
        {
        }
    }
}
