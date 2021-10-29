using System;
using System.Collections.Generic;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Agente> agentes = new List<Agente>();

            Agente due1 = new Duelistas("Phoenix");
            Agente due2 = new Duelistas("Jett", true, false);

            Agente con2 = new Controladores("Omen");
            Agente con1 = new Controladores("Brimstone", false, true);

            agentes.Add(due1);
            agentes.Add(due2);
            agentes.Add(con1);
            agentes.Add(con2);

            Console.WriteLine("Lista de Agentes\n");
            foreach (Agente item in agentes)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("\nApriete una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            List<Jugador> jugadores = new List<Jugador>();

            Console.WriteLine("Lista de Jugadores\n");

            Jugador j1 = new Jugador(30, Localidades.EUROPA.ToString(), Rangos.Diamante.ToString(), due1);
            Jugador j2 = new Jugador(16, Localidades.LATAM.ToString(), Rangos.Plata.ToString(), due1);
            Jugador j3 = new Jugador(15, Localidades.USA.ToString(), Rangos.Diamante.ToString(), con2);
            Jugador j4 = new Jugador(20, Localidades.USA.ToString(), Rangos.Diamante.ToString(), due2);

            jugadores.Add(j1);
            jugadores.Add(j2);
            jugadores.Add(j3);
            jugadores.Add(j4);

            foreach (Jugador item in jugadores)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("\nApriete una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            foreach (Jugador item in jugadores)
            {
                if(item.Localidad == "USA")
                {

                }
            }
        }
    }
}
