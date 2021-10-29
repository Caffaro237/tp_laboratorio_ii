using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador
    {
        private int edad;
        private string localidad;
        private string rango;
        private Agente agenteElegido;

        public Jugador(int edad, string localidad, string rango, Agente agenteElegido)
        {
            this.edad = edad;
            this.localidad = localidad;
            this.rango = rango;
            this.agenteElegido = agenteElegido;
        }

        public int Edad
        {
            get
            {
                return this.edad;
            }
        }

        public string Localidad
        {
            get
            {
                return this.localidad;
            }
        }

        public string Rango
        {
            get
            {
                return this.rango;
            }
        }

        public Agente AgenteElegido
        {
            get
            {
                return this.agenteElegido;
            }
        }

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

    }

}
