using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Serializador<T> : IArchivo<T> where T : class
    {
        #region Atributo 

        private IArchivo<T>.ETipoArchivo tipo;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor que recibe el tipo de archivo que se va a leer
        /// Siendo XML o JSON
        /// </summary>
        /// <param name="tipo"></param>
        public Serializador(IArchivo<T>.ETipoArchivo tipo)
        {
            this.tipo = tipo;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Implementacion de la interfaz para guardar un archivo XML o JSON
        /// Recibira una ruta y un dato
        /// Vrificando si la extension del archivo es la correcta serializa o no el dato
        /// </summary>
        /// <param name="path"></param>
        /// <param name="dato"></param>
        public void Guardar(string path, T dato)
        {
            try
            {
                if(this.tipo == IArchivo<T>.ETipoArchivo.XML)
                {
                    if(Path.GetExtension(path) == ".xml")
                    {
                        using(XmlTextWriter xmlTextWriter = new XmlTextWriter(path, Encoding.UTF8))
                        {
                            xmlTextWriter.Formatting = Formatting.Indented;
                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                            xmlSerializer.Serialize(xmlTextWriter, dato);
                        }
                    }
                    else
                    {
                        throw new ExtensionInvalidaExcepcion("Extension invalida para XML");
                    }
                }
                else
                {
                    if (this.tipo == IArchivo<T>.ETipoArchivo.JSON)
                    {
                        if (Path.GetExtension(path) == ".json")
                        {
                            ArchivoTexto archivoTexto = new ArchivoTexto();
                            archivoTexto.Guardar(path, JsonSerializer.Serialize(dato, typeof(T)));
                        }
                        else
                        {
                            throw new ExtensionInvalidaExcepcion("Extension invalida para JSON");
                        }
                    }
                }
            }
            catch(Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Implementacion de la interfaz para leer un archivo XML o JSON
        /// Se le pasa por parametro la ruta del archivo
        /// Vrificando si la extension del archivo es la correcta deserializa o no el archivo
        /// </summary>
        /// <param name="path"></param>
        /// <returns> Retornara los datos obtenidos por la deserializacion </returns>
        public T Leer(string path)
        {
            try
            {
                if (this.tipo == IArchivo<T>.ETipoArchivo.XML)
                {
                    if (Path.GetExtension(path) == ".xml")
                    {
                        using (XmlTextReader xmlTextReader = new XmlTextReader(path))
                        {
                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                            return (T)xmlSerializer.Deserialize(xmlTextReader);
                        }
                    }
                    else
                    {
                        throw new ExtensionInvalidaExcepcion("Extension invalida para XML");
                    }
                }
                else
                {
                    if (Path.GetExtension(path) == ".json")
                    {
                        ArchivoTexto archivoTexto = new ArchivoTexto();
                        return JsonSerializer.Deserialize<T>(archivoTexto.Leer(path));
                    }
                    else
                    {
                        throw new ExtensionInvalidaExcepcion("Extension invalida para JSON");
                    }
                
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

    }
}
