using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class FuncionesRandom
    {
        /// <summary>
        /// Metodo que recibe los valores para hacer un random
        /// Entre los valores asignados
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns> Retornara un numero random </returns>
        public static int HacerRandom(int num1, int num2)
        {
            Random r = new Random();
            int numeroRandom = 0;

            numeroRandom = r.Next(num1, num2);

            return numeroRandom;
        }

        /// <summary>
        /// Se utilizara elegir la Localidad para el jugador, 
        /// al ejecutar el random ingresara por parametro 1, 2 o 3
        /// 
        /// Como default retornara la localidad USA
        /// </summary>
        /// <param name="localidadInt"></param>
        /// <returns> Retornara una Localidad como string </returns>
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

        /// <summary>
        /// Se utilizara elegir el Rango para el jugador, 
        /// al ejecutar el random ingresara por parametro 1, 2 o 3
        /// 
        /// Como default retornara el el Rango PLATA
        /// </summary>
        /// <param name="rangoInt"></param>
        /// <returns> Retornara un Rango como string </returns>
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

        /// <summary>
        /// Se utilizara elegir el agente Elegido por el jugador, 
        /// al ejecutar el random ingresara por parametro 1, 2, 3 o 4
        /// 
        /// Como default retornara el nombre Phoenix
        /// </summary>
        /// <param name="agenteInt"></param>
        /// <returns> Retornara un string con el nombre del Agente </returns>
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
