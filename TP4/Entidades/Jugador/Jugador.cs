using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Data.SqlClient;

namespace Entidades
{
    public class Jugador
    {
        #region Atributos

        private int edad;
        private string localidad;
        private string rango;
        private Agente agenteElegido;

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor sin parametros requerido por la serializacion
        /// </summary>
        public Jugador()
        {
        }

        /// <summary>
        /// Constructor que recibe el nombre, localidad, rango y agente elegido
        /// </summary>
        /// <param name="edad"></param>
        /// <param name="localidad"></param>
        /// <param name="rango"></param>
        /// <param name="agenteElegido"></param>
        public Jugador(int edad, string localidad, string rango, Agente agenteElegido)
        {
            this.edad = edad;
            this.localidad = localidad;
            this.rango = rango;
            this.agenteElegido = agenteElegido;
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Propiedad de lectura de la edad del jugador
        /// Deberia ser de solo lectura pero para serializarla 
        /// necesitaba ser de escritura tambien
        /// </summary>
        public int Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                this.edad = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura de la Localidad del jugador
        /// Deberia ser de solo lectura pero para serializarla 
        /// necesitaba ser de escritura tambien
        /// </summary>
        public string Localidad
        {
            get
            {
                return this.localidad;
            }
            set
            {
                this.localidad = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura del Rango del jugador
        /// Deberia ser de solo lectura pero para serializarla 
        /// necesitaba ser de escritura tambien
        /// </summary>
        public string Rango
        {
            get
            {
                return this.rango;
            }
            set
            {
                this.rango = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura del agente elegido por jugador
        /// Deberia ser de solo lectura pero para serializarla 
        /// necesitaba ser de escritura tambien
        /// </summary>
        public Agente AgenteElegido
        {
            get
            {
                return this.agenteElegido;
            }
            set
            {
                this.agenteElegido = value;
            }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Metodo que mostrara los datos del jugador
        /// </summary>
        /// <returns> Retornara un string con los datos </returns>
        private string MostrarJugador()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("---------------------");
            sb.AppendLine($"Edad: {this.Edad}");
            sb.AppendLine($"Localidad: {this.Localidad}");
            sb.AppendLine($"Rango: {this.Rango}");
            sb.AppendLine($"Agente elegido: {this.AgenteElegido.Nombre}");

            return sb.ToString();
        }

        /// <summary>
        /// Sobreescritura del metodo ToString()
        /// Que expondra al metodo MostrarJugador()
        /// </summary>
        /// <returns> Retornara un string con los datos </returns>
        public override string ToString()
        {
            return this.MostrarJugador();
        }

        /// <summary>
        /// Este metodo se utiliza para cargar los datos a un archivo
        /// sin tener ninguna otra escritura encima, solo los datos del jugador
        /// </summary>
        /// <returns> Retorna un string solamente con los datos </returns>
        public string CargarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.Edad}");
            sb.AppendLine($"{this.Localidad}");
            sb.AppendLine($"{this.Rango}");
            sb.AppendLine($"{this.AgenteElegido.Nombre}");

            return sb.ToString();
        }

        /// <summary>
        /// Metodo para leer los archivos de una ruta en especifico
        /// Este leera los archivos y agregara los jugadores a una lista
        /// </summary>
        /// <param name="path"></param>
        /// <param name="serializadorXML"></param>
        /// <returns> Retornara una lista con los jugadores leidos de los archivos </returns>
        public static List<Jugador> LeerArchivos(string path, Serializador<Jugador> serializadorXML)
        {
            DirectoryInfo directorioElegido = new DirectoryInfo(path);
            FileInfo[] files = directorioElegido.GetFiles();
            List<Jugador> jugadores = new List<Jugador>();

            if(files.Length == 0)
            {
                throw new ArchivosExcepcion("No hay archivos en esta ruta");
            }

            foreach (FileInfo archivoItem in files)
            {
                try
                {
                    Jugador j = serializadorXML.Leer(archivoItem.FullName);
                    jugadores.Add(j);
                }
                catch (Exception)
                {
                    throw;
                }
            }


            return jugadores;
        }

        /// <summary>
        /// Funcion para obtener la cantidad de jugadores que eligieron a determinado agente
        /// Pasandole por parametro la lista de jugadores y el agente elegido
        /// </summary>
        /// <param name="jugadores"></param>
        /// <param name="nombreAgente"></param>
        /// <returns> Retornara el valor de la cantidad de jugadores que eligieron a determinado agente </returns>
        public static int ObtenerCantidadElegido(List<Jugador> jugadores, string nombreAgente)
        {
            int contador = 0;

            foreach (Jugador item in jugadores)
            {
                if (item.AgenteElegido.Nombre == nombreAgente)
                {
                    contador++;
                }
            }

            return contador;
        }

        /// <summary>
        /// Funcion para obtener la cantidad de jugadores por agente y por localidad
        /// Pasandole por parametro la lista de jugadores, el agente elegido y la localidad
        /// </summary>
        /// <param name="jugadores"></param>
        /// <param name="nombreAgente"></param>
        /// <param name="localidad"></param>
        /// <returns> Retornara el valor de la cantidad de jugadores que eligieron a determinado agente y sean de determinada Localidad </returns>
        public static int ObtenerCantidadElegidoPorLocalidad(List<Jugador> jugadores, string nombreAgente, string localidad)
        {
            int contador = 0;

            foreach (Jugador item in jugadores)
            {
                if (item.AgenteElegido.Nombre == nombreAgente && item.Localidad == localidad)
                {
                    contador++;
                }
            }

            return contador;
        }

        /// <summary>
        /// Funcion para obtener la cantidad de jugadores por agente y por rango
        /// Pasandole por parametro la lista de jugadores, el agente elegido y la rango
        /// </summary>
        /// <param name="jugadores"></param>
        /// <param name="nombreAgente"></param>
        /// <param name="rango"></param>
        /// <returns> Retornara el valor de la cantidad de jugadores que eligieron a determinado agente y sean de determinada Rango </returns>
        public static int ObtenerCantidadElegidoPorRango(List<Jugador> jugadores, string nombreAgente, string rango)
        {
            int contador = 0;

            foreach (Jugador item in jugadores)
            {
                if (item.AgenteElegido.Nombre == nombreAgente && item.Rango == rango)
                {
                    contador++;
                }
            }

            return contador;
        }

        /// <summary>
        /// Funcion para obtener la sumatoria de edades de los jugadores por agente
        /// Pasandole por parametro la lista de jugadores, el agente elegido
        /// </summary>
        /// <param name="jugadores"></param>
        /// <param name="nombreAgente"></param>
        /// <returns> Retornara el valor de la sumatoria de edades de los jugadores que eligieron a determinado agente </returns>
        public static int ObtenerSumaDeEdades(List<Jugador> jugadores, string nombreAgente)
        {
            int contador = 0;

            foreach (Jugador item in jugadores)
            {
                if (item.AgenteElegido.Nombre == nombreAgente)
                {
                    contador += item.Edad;
                }
            }

            return contador;
        }

        #endregion

    }
}
