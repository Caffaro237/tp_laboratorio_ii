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

        public Serializador(IArchivo<T>.ETipoArchivo tipo)
        {
            this.tipo = tipo;
        }

        #endregion

        #region Metodos

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
            catch (Exception ex)
            {
                throw;
            }
        }

        #endregion

    }
}
