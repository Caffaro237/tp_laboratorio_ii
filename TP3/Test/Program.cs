using System;
using System.Collections.Generic;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Jugador> jugadores = new List<Jugador>();

            Jugador j1 = new Jugador(21, "LATINO", "Hierro");
            Jugador j2 = new Jugador(18, "USA", "Plata");

            jugadores.Add(j1);
            jugadores.Add(j2);

            for (int i = 0; i < 5; i++)
            {
                Jugador j = new Jugador(Jugador.HacerRandom(15, 31),
                                        Jugador.SwitchLocalidad(Jugador.HacerRandom(1, 5)),
                                        Jugador.SwitchRango(Jugador.HacerRandom(1, 7)));
                jugadores.Add(j);
            }

            foreach (Jugador item in jugadores)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadKey();
        }
    }
}
