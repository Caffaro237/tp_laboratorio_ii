using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Formulario
{
    public partial class FrmMostrarJugadoresAnalisis : Form
    {
        private List<Jugador> jugadores;
        private List<Agente> agentes;

        public FrmMostrarJugadoresAnalisis(List<Jugador> jugadores, List<Agente> agentes)
        {
            InitializeComponent();

            this.jugadores = new List<Jugador>();
            this.agentes = new List<Agente>();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void RefrescarLista()
        {
            StringBuilder sb = new StringBuilder();
            this.lblCount.Text = this.jugadores.Count.ToString();

            foreach (Jugador item in jugadores)
            {
                sb.Append(item.ToString());
            }

            this.rtbJugadores.Text = sb.ToString();
            this.MostrarAnalisis();
        }

        public void MostrarAnalisis()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Agente item in agentes)
            {
                int cantidadElegidos = Jugador.ObtenerCantidadElegido(this.jugadores, item.Nombre);

                int cantidadElegidosUSA = Jugador.ObtenerCantidadElegidoPorLocalidad(this.jugadores, item.Nombre, Localidades.USA.ToString());
                int cantidadElegidosEUROPA = Jugador.ObtenerCantidadElegidoPorLocalidad(this.jugadores, item.Nombre, Localidades.EUROPA.ToString());
                int cantidadElegidosLATAM = Jugador.ObtenerCantidadElegidoPorLocalidad(this.jugadores, item.Nombre, Localidades.LATAM.ToString());

                int cantidadElegidosPLATA = Jugador.ObtenerCantidadElegidoPorRango(this.jugadores, item.Nombre, Rangos.Plata.ToString());
                int cantidadElegidosORO = Jugador.ObtenerCantidadElegidoPorRango(this.jugadores, item.Nombre, Rangos.Oro.ToString());
                int cantidadElegidosDIAMANTE = Jugador.ObtenerCantidadElegidoPorRango(this.jugadores, item.Nombre, Rangos.Diamante.ToString());

                int sumaDeEdades = Jugador.ObtenerSumaDeEdades(this.jugadores, item.Nombre);

                sb.AppendLine($"El agente {item.Nombre} fue elegido {cantidadElegidos} veces");
                sb.AppendLine($"{item.SacarPorcentaje(cantidadElegidosUSA, cantidadElegidos)}% en USA, {item.SacarPorcentaje(cantidadElegidosEUROPA, cantidadElegidos)}% en EUROPA y {item.SacarPorcentaje(cantidadElegidosLATAM, cantidadElegidos)}% en LATAM");
                sb.AppendLine($"{item.SacarPorcentaje(cantidadElegidosPLATA, cantidadElegidos)}% son rango Plata, {item.SacarPorcentaje(cantidadElegidosORO, cantidadElegidos)}% son rango Oro y {item.SacarPorcentaje(cantidadElegidosDIAMANTE, cantidadElegidos)}% son rango Diamante");
                sb.AppendLine($"{item.SacarPromedio(sumaDeEdades, cantidadElegidos)} es el promedio de edad");
                sb.AppendLine("---------------------------------------------------------------");
            }

            this.rtbAnalisis.Text = sb.ToString();
        }
    }
}
