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
            List<Agente> agentes = new List<Agente>();

            Agente due1 = new Duelistas("Phoenix");
            Agente due2 = new Duelistas("Jett", true);

            Agente con1 = new Controladores("Brimstone");
            Agente con2 = new Controladores("Omen", true, true);

            Agente cen1 = new Centinelas("Sage", true);
            Agente cen2 = new Centinelas("Killjoy");

            Agente ini1 = new Iniciadores("Sova");
            Agente ini2 = new Iniciadores("Kay/O");

            agentes.Add(due1);
            agentes.Add(due2);
            agentes.Add(con1);
            agentes.Add(con2);
            agentes.Add(cen1);
            agentes.Add(cen2);
            agentes.Add(ini1);
            agentes.Add(ini2);


            Jugador j1 = new Jugador(21, "LATINO", "Hierro", "Killjoy");
            Jugador j2 = new Jugador(18, "USA", "Plata", "Sova");

            jugadores.Add(j1);
            jugadores.Add(j2);

            for (int i = 0; i < 5; i++)
            {
                Jugador j = new Jugador(Jugador.HacerRandom(15, 31),
                                        Jugador.SwitchLocalidad(Jugador.HacerRandom(1, 5)),
                                        Jugador.SwitchRango(Jugador.HacerRandom(1, 7)),
                                        Jugador.SwitchAgente(Jugador.HacerRandom(1, 9)));
                jugadores.Add(j);
            }

            Console.WriteLine("Lista de Jugadores\n");
            foreach (Jugador item in jugadores)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("Apriete una tecla par continuar...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Lista de Agentes\n");
            foreach (Agente item in agentes)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadKey();
        }
    }
}
