using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Agente> agentes = new List<Agente>();

            //Simplificacion con un metodo estatico en la clase agente que me devuelve la lista con los agentes
            //Puedo reutilizar codigo de esa manera

            /*
            Agente due1 = new Duelistas("Phoenix");
            Agente due2 = new Duelistas("Jett", true, false);

            Agente con1 = new Controladores("Brimstone", false, true);
            Agente con2 = new Controladores("Omen");

            agentes.Add(due1);
            agentes.Add(due2);
            agentes.Add(con1);
            agentes.Add(con2);
            */

            agentes = Agente.CrearListaAgentes();

            Console.WriteLine($"Lista de Agentes, cantidad {agentes.Count}\n");
            foreach (Agente item in agentes)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("\nApriete una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            List<Jugador> jugadores = new List<Jugador>();

            for (int i = 0; i < 10; i++)
            {
                string nombreRandom = FuncionesRandom.SwitchAgente(FuncionesRandom.HacerRandom(1, 5));

                foreach (var item in agentes)
                {
                    if (item.Nombre == nombreRandom)
                    {
                        Jugador j = new Jugador(FuncionesRandom.HacerRandom(15, 31),
                                                FuncionesRandom.SwitchLocalidad(FuncionesRandom.HacerRandom(1, 4)),
                                                FuncionesRandom.SwitchRango(FuncionesRandom.HacerRandom(1, 4)),
                                                item);
                        jugadores.Add(j);
                    }
                }
            }

            Console.WriteLine($"Lista de Jugadores, cantidad {jugadores.Count}\n");
            foreach (Jugador item in jugadores)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("\nApriete una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            foreach (Jugador item in jugadores)
            {
                item.AgenteElegido.CE++;
                item.AgenteElegido.SumaEdades += item.Edad;

                if(item.Localidad == Localidades.USA.ToString())
                {
                    item.AgenteElegido.CEU++;
                }
                else if (item.Localidad == Localidades.EUROPA.ToString())
                {
                    item.AgenteElegido.CEE++;
                }
                else if (item.Localidad == Localidades.LATAM.ToString())
                {
                    item.AgenteElegido.CEL++;
                }

                if(item.Rango == Rangos.Plata.ToString())
                {
                    item.AgenteElegido.CP++;
                }
                else if (item.Rango == Rangos.Oro.ToString())
                {
                    item.AgenteElegido.CO++;
                }
                else if (item.Rango == Rangos.Diamante.ToString())
                {
                    item.AgenteElegido.CD++;
                }
            }

            foreach (Agente item in agentes)
            {
                Console.WriteLine($"El agente {item.Nombre} fue elegido {item.CE} veces");
                Console.WriteLine($"{item.SacarPorcentaje(item.CEU, item.CE)}% en USA, {item.SacarPorcentaje(item.CEE, item.CE)}% en EUROPA y {item.SacarPorcentaje(item.CEL, item.CE)}% en LATAM");
                Console.WriteLine($"{item.SacarPorcentaje(item.CP, item.CE)}% son rango Plata, {item.SacarPorcentaje(item.CO, item.CE)}% son rango Oro y {item.SacarPorcentaje(item.CD, item.CE)}% son rango Diamante");
                Console.WriteLine($"{item.SacarPromedio(item.SumaEdades, item.CE)} es el promedio de edad");
                Console.WriteLine("---------------------------------------------------------------");
            }

            Console.WriteLine("\nApriete una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            ArchivoTexto at = new ArchivoTexto();
            StringBuilder sb = new StringBuilder();

            foreach (Jugador item in jugadores)
            {
                sb.AppendLine(item.CargarDatos());
            }

            at.Guardar("Lista de Jugadores.txt", sb.ToString());

            Console.WriteLine(at.Leer("Lista de Jugadores.txt"));

            Console.WriteLine("\nApriete una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            //Creacion de un agente y un jugador para probar la serializacion y deserializacion
            Agente con1 = new Controladores("Brimstone", false, true);
            Jugador j1 = new Jugador(30, Localidades.EUROPA.ToString(), Rangos.Diamante.ToString(), con1);

            Serializador<Jugador> serializadorXML = new Serializador<Jugador>(IArchivo<Jugador>.ETipoArchivo.XML);
            //Serializador<Jugador> serializadorJSON = new Serializador<Jugador>(IArchivo<Jugador>.ETipoArchivo.JSON);

            try
            {
                //Prueba de Serializacion y Deserializacion en XML con un Jugador
                /*
                serializadorXML.Guardar("Jugador.xml", j1);

                Jugador j2 = serializadorXML.Leer("Jugador.xml");

                Console.WriteLine(j2.ToString());
                */

                //Prueba de Serializacion y Deserializacion en XML con una lista de jugadores

                string path = @"..\..\..\..\Jugadores";

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                else
                {
                    Directory.Delete(path, true);
                    Directory.CreateDirectory(path);
                }

                int i = 1;
                foreach (Jugador item in jugadores)
                {
                    serializadorXML.Guardar($"{path}\\Jugador{i}.xml", item);
                    i++;
                }

                List<Jugador> jugadoresLeidosXML = new List<Jugador>();

                jugadoresLeidosXML = Jugador.LeerArchivos(path, serializadorXML);

                foreach (Jugador item in jugadoresLeidosXML)
                {
                    Console.WriteLine(item.ToString());
                }


                //Serializacion y Deserializacion en JSON (NO DESERIALIZA CORRECTAMENTE)

                //serializadorJSON.Guardar("Jugador.json", j1);
                //Jugador j2 = serializadorJSON.Leer("Jugador.json");
                //Console.WriteLine(j2.ToString());

                Console.WriteLine("Listo");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }

            Console.WriteLine("\nApriete una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
