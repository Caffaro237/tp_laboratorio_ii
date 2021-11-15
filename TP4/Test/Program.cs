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

            //Agregado de los agentes y muestro la lista
            agentes = Agente.CrearListaAgentes();

            Console.WriteLine($"Lista de Agentes, cantidad {agentes.Count}\n");
            foreach (Agente item in agentes)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("\nApriete una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            //Agregado de los jugadores eligiendo valores random y muestro la lista

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

            /*
             * Se hace la carga y muestra de los datos a analizar
             * 
             * Cantidad de veces elegido
             * Sumatoria de todas las edades
             * Cantidad de cada localidad elegida
             * Cantidad de Cada rango que sea
            */
            StringBuilder sbAnalisis = new StringBuilder();

            foreach (Agente item in agentes)
            {
                int cantidadElegidos = Jugador.ObtenerCantidadElegido(jugadores, item.Nombre);

                int cantidadElegidosUSA = Jugador.ObtenerCantidadElegidoPorLocalidad(jugadores, item.Nombre, Localidades.USA.ToString());
                int cantidadElegidosEUROPA = Jugador.ObtenerCantidadElegidoPorLocalidad(jugadores, item.Nombre, Localidades.EUROPA.ToString());
                int cantidadElegidosLATAM = Jugador.ObtenerCantidadElegidoPorLocalidad(jugadores, item.Nombre, Localidades.LATAM.ToString());

                int cantidadElegidosPLATA = Jugador.ObtenerCantidadElegidoPorRango(jugadores, item.Nombre, Rangos.Plata.ToString());
                int cantidadElegidosORO = Jugador.ObtenerCantidadElegidoPorRango(jugadores, item.Nombre, Rangos.Oro.ToString());
                int cantidadElegidosDIAMANTE = Jugador.ObtenerCantidadElegidoPorRango(jugadores, item.Nombre, Rangos.Diamante.ToString());

                int sumaDeEdades = Jugador.ObtenerSumaDeEdades(jugadores, item.Nombre);

                sbAnalisis.AppendLine($"El agente {item.Nombre} fue elegido {cantidadElegidos} veces");
                sbAnalisis.AppendLine($"{item.SacarPorcentaje(cantidadElegidosUSA, cantidadElegidos)}% en USA, {item.SacarPorcentaje(cantidadElegidosEUROPA, cantidadElegidos)}% en EUROPA y {item.SacarPorcentaje(cantidadElegidosLATAM, cantidadElegidos)}% en LATAM");
                sbAnalisis.AppendLine($"{item.SacarPorcentaje(cantidadElegidosPLATA, cantidadElegidos)}% son rango Plata, {item.SacarPorcentaje(cantidadElegidosORO, cantidadElegidos)}% son rango Oro y {item.SacarPorcentaje(cantidadElegidosDIAMANTE, cantidadElegidos)}% son rango Diamante");
                sbAnalisis.AppendLine($"{item.SacarPromedio(sumaDeEdades, cantidadElegidos)} es el promedio de edad");
                sbAnalisis.AppendLine("---------------------------------------------------------------");
            }

            Console.WriteLine(sbAnalisis.ToString());

            Console.WriteLine("\nApriete una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            //Instancia de creacion y lectura de archivos

            ArchivoTexto at = new ArchivoTexto();
            StringBuilder sbArchivoTexto = new StringBuilder();

            foreach (Jugador item in jugadores)
            {
                sbArchivoTexto.AppendLine(item.CargarDatos());
            }

            //Creo un archivo de texto con la lista completa de los jugadores al momento
            at.Guardar("Lista de Jugadores.txt", sbArchivoTexto.ToString());

            //Leo la lista creada y la muestro
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
                
                serializadorXML.Guardar("Jugador.xml", j1);

                Jugador j2 = serializadorXML.Leer("Jugador.xml");

                Console.WriteLine(j2.ToString());

                Console.WriteLine("\nApriete una tecla para continuar...");
                Console.ReadKey();
                Console.Clear();


                //Prueba de Serializacion y Deserializacion en XML con una lista de jugadores

                string path = Directory.GetCurrentDirectory() + @"\Archivos\JugadoresGuardados";

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

                //Console.WriteLine("Listo");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\nApriete una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
