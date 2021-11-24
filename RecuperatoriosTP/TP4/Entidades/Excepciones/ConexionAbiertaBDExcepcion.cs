using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ConexionAbiertaBDExcepcion : Exception
    {
        /// <summary>
     /// Recibe un mensaje como parametro y llama a la base
     /// </summary>
     /// <param name="message"></param>
        public ConexionAbiertaBDExcepcion(string message)
            : base(message)
        {
        }
    }
}
