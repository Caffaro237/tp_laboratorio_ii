using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador
    {
        int edad;
        string localidad;
        string rango;
        string agenteElegido;

        public Jugador(int edad, string localidad, string rango, string agenteElegido)
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
        public string AgenteElegido
        {
            get
            {
                return this.agenteElegido;
            }
        }

        public string MostrarJugador()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("-------------------------------------");
            sb.AppendLine($"Edad: {this.Edad}");
            sb.AppendLine($"Localidad: {this.Localidad}");
            sb.AppendLine($"Rango: {this.Rango}");
            sb.AppendLine("-------------------------------------");
            sb.AppendLine($"Agente Elegido: {this.AgenteElegido}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarJugador();
        }

        public static int HacerRandom(int num1, int num2)
        {
            Random r = new Random();
            int numeroRandom = 0;

            numeroRandom = r.Next(num1, num2);

            return numeroRandom;
        }

        public static string SwitchLocalidad(int localidadInt)
        {
            switch (localidadInt)
            {
                case 1:
                    return "USA";

                case 2:
                    return "EMEA";

                case 3:
                    return "ASIATICOS";

                case 4:
                    return "LATINOS";

                default:
                    return "";
            }
        }
        public static string SwitchRango(int rangoInt)
        {
            switch (rangoInt)
            {
                case 1:
                    return "Hierro";

                case 2:
                    return "Bronce";

                case 3:
                    return "Plata";

                case 4:
                    return "Oro";

                case 5:
                    return "Diamante";

                case 6:
                    return "Inmortal";

                default:
                    return "";
            }
        }

        public static string SwitchAgente(int agenteInt)
        {
            switch (agenteInt)
            {
                case 1:
                    return "Phoenix";

                case 2:
                    return "Jett";

                case 3:
                    return "Brimstone";

                case 4:
                    return "Omen";

                case 5:
                    return "Sage";

                case 6:
                    return "Killjoy";

                case 7:
                    return "Sova";

                case 8:
                    return "Kay/O";

                default:
                    return "";
            }
        }

    }
}
