using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

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

        public Jugador()
        {
        }

        
        public Jugador(int edad, string localidad, string rango, Agente agenteElegido)
        {
            this.edad = edad;
            this.localidad = localidad;
            this.rango = rango;
            this.agenteElegido = agenteElegido;
        }

        #endregion

        #region Propiedades

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

        public virtual string MostrarJugador()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("---------------------");
            sb.AppendLine($"Edad: {this.Edad}");
            sb.AppendLine($"Localidad: {this.Localidad}");
            sb.AppendLine($"Rango: {this.Rango}");
            sb.AppendLine($"Agente elegido: {this.AgenteElegido.Nombre}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarJugador();
        }

        public string CargarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.Edad}");
            sb.AppendLine($"{this.Localidad}");
            sb.AppendLine($"{this.Rango}");
            sb.AppendLine($"{this.AgenteElegido.Nombre}");

            return sb.ToString();
        }

        public static List<Jugador> LeerArchivos(string path, Serializador<Jugador> serializadorXML)
        {
            DirectoryInfo directorioElegido = new DirectoryInfo(path);
            FileInfo[] files = directorioElegido.GetFiles();
            List<Jugador> jugadores = new List<Jugador>();

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

        #endregion

    }
}
