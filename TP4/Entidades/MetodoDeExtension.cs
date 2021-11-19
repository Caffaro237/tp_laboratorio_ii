using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Extensiones
{
    public static class MetodoDeExtension
    {
        /// <summary>
        /// Metodo de extension que retornara la cantidad de jugadores que hay en la lista como un string
        /// </summary>
        /// <param name="jugadores"></param>
        /// <returns> Retornara un string con la cantidad de jugadores </returns>
        public static string CantidadDeJugadores(this List<Jugador> jugadores)
        {
            return jugadores.Count().ToString();
        }
    }
}
