using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TimeOutExcepcion : Exception
    {
        /// <summary>
        /// Recibe un mensaje como parametro y llama a la base
        /// </summary>
        /// <param name="message"></param>
        public TimeOutExcepcion(string message) : base(message)
        {
        }
    }
}
