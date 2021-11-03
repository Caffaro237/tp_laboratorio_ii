using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class ExtensionInvalidaExcepcion : Exception
    {
        public ExtensionInvalidaExcepcion(string message)
            : base(message)
        {
        }
    }
}
