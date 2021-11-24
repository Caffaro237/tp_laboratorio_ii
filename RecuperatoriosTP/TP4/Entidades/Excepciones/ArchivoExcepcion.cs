using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ArchivosExcepcion : Exception
    {
        /// <summary>
        /// Recibe un mensaje como parametro y llama a la base
        /// </summary>
        /// <param name="message"></param>
        public ArchivosExcepcion(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Recibe una excepcion como parametro y llama al constructor que recibe un mensaje
        /// </summary>
        /// <param name="innerException"></param>
        public ArchivosExcepcion(Exception innerException)
            : this("Se produjo un error en la lectura/escritura del archivo: " + innerException.Message)
        {
        }
    }
}
