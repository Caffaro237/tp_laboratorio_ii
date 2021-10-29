using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class FuncionRandom
    {
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
