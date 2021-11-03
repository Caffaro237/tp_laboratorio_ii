using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ArchivoTexto : IArchivo<string>
    {
        /// <summary>
        /// Implementacion de la interfaz para guardar un archivo de texto
        /// </summary>
        /// <param name="path"></param>
        /// <param name="datos"></param>
        /// <returns> Retorna true si se pudo guardar o false si no se pudo </returns>
        public void Guardar(string path, string datos)
        {
            Encoding codificacion = Encoding.UTF8;

            try
            {
                using (StreamWriter streamWriter = new StreamWriter(path, false, codificacion))
                {
                    streamWriter.WriteLine(datos);
                }
            }
            catch (Exception e)
            {
                throw new ArchivosExcepcion(e);
            }
        }

        /// <summary>
        /// Lee un archivo de texto en una ruta determinada y lo devuelve como un string
        /// </summary>
        /// <param name="path"></param>
        /// <param name="datos"></param>
        /// <returns> Retorna true si se pudo guardar o false si no se pudo </returns>
        public string Leer(string path)
        {
            Encoding codificacion = Encoding.UTF8;
            string returnAux = string.Empty;

            try
            {
                using (StreamReader streamReader = new StreamReader(path, codificacion))
                {
                    while(!streamReader.EndOfStream)
                    {
                        returnAux += $"{streamReader.ReadLine()}\n";
                    }
                }
            }
            catch (Exception e)
            {
                throw new ArchivosExcepcion(e);
            }

            return returnAux;
        }
    }
}
