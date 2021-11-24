using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class ExtensionInvalidaExcepcion : Exception
    {
        /// <summary>
        /// Recibe un mensaje como parametro y llama a la base
        /// </summary>
        /// <param name="message"></param>
        public ExtensionInvalidaExcepcion(string message)
            : base(message)
        {
        }
    }
}
