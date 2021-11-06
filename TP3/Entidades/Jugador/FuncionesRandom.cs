using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class FuncionesRandom
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
                    return Localidades.USA.ToString();

                case 2:
                    return Localidades.EUROPA.ToString();

                case 3:
                    return Localidades.LATAM.ToString();

                default:
                    return Localidades.USA.ToString();
            }
        }
        public static string SwitchRango(int rangoInt)
        {
            switch (rangoInt)
            {
                case 1:
                    return Rangos.Plata.ToString();

                case 2:
                    return Rangos.Oro.ToString();

                case 3:
                    return Rangos.Diamante.ToString();

                default:
                    return Rangos.Plata.ToString();
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

                default:
                    return "Phoenix";
            }
        }
    }
}
