using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Formulario
{
    public partial class FrmPpal : Form
    {
        #region Atributos 

        private Serializador<Jugador> serializadorXML;
        private List<Agente> agentes;
        private List<Jugador> jugadores;
        private List<Jugador> jugadoresLeidosXML;
        private string pathArchivosForm;

        #endregion

        #region Propiedades

        public List<Agente> Agentes
        {
            get
            {
                return this.agentes;
            }
        }

        public List<Jugador> Jugadores
        {
            get
            {
                return this.jugadores;
            }
        }

        #endregion

        #region Constructor

        public FrmPpal()
        {
            InitializeComponent();
            this.agentes = new List<Agente>();
            this.jugadores = new List<Jugador>();
            this.jugadoresLeidosXML = new List<Jugador>();
            this.serializadorXML = new Serializador<Jugador>(IArchivo<Jugador>.ETipoArchivo.XML); 
            this.pathArchivosForm = @"..\..\..\..\JugadoresForm";

            this.agentes = Agente.CrearListaAgentes();
        }

        #endregion

        #region Eventos

        private void FrmPpal_Load(object sender, EventArgs e)
        {
            cmbLocalidad.DataSource = Enum.GetValues(typeof(Localidades));
            cmbRango.DataSource = Enum.GetValues(typeof(Rangos));

            foreach (Agente item in this.Agentes)
            {
                this.cmbAgente.Items.Add(item.Nombre);
                this.rtbAgentes.Text += item.ToString();
            }

            this.cmbAgente.SelectedIndex = 0;

            this.MostrarAnalisis();
        }

        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            foreach (Agente item in this.Agentes)
            {
                if (this.cmbAgente.SelectedItem.ToString() == item.Nombre)
                {
                    Jugador jugador = new Jugador((int)this.numUpDownEdad.Value, this.cmbLocalidad.SelectedItem.ToString(), this.cmbRango.SelectedItem.ToString(), item);

                    this.CargarJugadoresLista(jugador);

                    break;
                }
            }

            this.RefrescarLista();
        }

        private void btnAgregarJugadoresRandom_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < (int)this.numUpDownCantidadJugadores.Value; i++)
            {
                string nombreRandom = FuncionesRandom.SwitchAgente(FuncionesRandom.HacerRandom(1, 5));

                foreach (Agente item in agentes)
                {
                    if (item.Nombre == nombreRandom)
                    {
                        Jugador j = new Jugador(FuncionesRandom.HacerRandom(15, 31),
                                                FuncionesRandom.SwitchLocalidad(FuncionesRandom.HacerRandom(1, 4)),
                                                FuncionesRandom.SwitchRango(FuncionesRandom.HacerRandom(1, 4)),
                                                item);
                        this.CargarJugadoresLista(j);
                    }
                }
            }

            this.RefrescarLista();
        }

        private void btnGuardarArchivo_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(pathArchivosForm))
            {
                Directory.CreateDirectory(pathArchivosForm);
            }
            else
            {
                Directory.Delete(pathArchivosForm, true);
                Directory.CreateDirectory(pathArchivosForm);
            }

            try
            {
                int i = 1;
                foreach (Jugador item in jugadores)
                {
                    string archivo = $"{pathArchivosForm}\\Jugador{i}.xml";

                    serializadorXML.Guardar(archivo, item);
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMostrarArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(pathArchivosForm))
                {
                    throw new ArchivosExcepcion("La ruta de la carpeta no se encontro o no existe");
                }
                FrmMostrarArchivosGuardados frmSecundario = new FrmMostrarArchivosGuardados(Jugador.LeerArchivos(pathArchivosForm, serializadorXML));

                frmSecundario.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCargarArchivos_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"..\..\..\CargarJugadores";

                if (!Directory.Exists(path))
                {
                    throw new ArchivosExcepcion("No se encontro la ruta del archivo");
                }

                this.jugadoresLeidosXML = Jugador.LeerArchivos(path, serializadorXML);

                foreach (Jugador item in this.jugadoresLeidosXML)
                {
                    this.CargarJugadoresLista(item);
                }

                this.RefrescarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        #endregion

        #region Metodos

        public void RefrescarLista()
        {
            this.rtbJugadores.Clear();
            this.lblCount.Text = this.jugadores.Count.ToString();

            foreach (Jugador item in jugadores)
            {
                this.rtbJugadores.Text += item.ToString();
            }

            this.MostrarAnalisis();
        }

        public void MostrarAnalisis()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Agente item in agentes)
            {
                sb.AppendLine($"El agente {item.Nombre} fue elegido {item.CE} veces");
                sb.AppendLine($"{item.SacarPorcentaje(item.CEU, item.CE)}% en USA, {item.SacarPorcentaje(item.CEE, item.CE)}% en EUROPA y {item.SacarPorcentaje(item.CEL, item.CE)}% en LATAM");
                sb.AppendLine($"{item.SacarPorcentaje(item.CP, item.CE)}% son rango Plata, {item.SacarPorcentaje(item.CO, item.CE)}% son rango Oro y {item.SacarPorcentaje(item.CD, item.CE)}% son rango Diamante");
                sb.AppendLine($"{item.SacarPromedio(item.SumaEdades, item.CE)} es el promedio de edad");
                sb.AppendLine("---------------------------------------------------------------");
            }

            this.rtbAnalisis.Text = sb.ToString();
        }

        public void CargarDatosAnalisis(Jugador j)
        {
            /*
            j.AgenteElegido.CE = 0;
            j.AgenteElegido.SumaEdades = 0;

            j.AgenteElegido.CEU = 0;
            j.AgenteElegido.CEE = 0;
            j.AgenteElegido.CEL = 0;

            j.AgenteElegido.CP = 0;
            j.AgenteElegido.CO = 0;
            j.AgenteElegido.CD = 0;
            */

            j.AgenteElegido.CE++;
            j.AgenteElegido.SumaEdades += j.Edad;
            

            if (j.Localidad == Localidades.USA.ToString())
            {
                j.AgenteElegido.CEU++;
            }
            else if (j.Localidad == Localidades.EUROPA.ToString())
            {
                j.AgenteElegido.CEE++;
            }
            else if (j.Localidad == Localidades.LATAM.ToString())
            {
                j.AgenteElegido.CEL++;
            }

            if (j.Rango == Rangos.Plata.ToString())
            {
                j.AgenteElegido.CP++;
            }
            else if (j.Rango == Rangos.Oro.ToString())
            {
                j.AgenteElegido.CO++;
            }
            else if (j.Rango == Rangos.Diamante.ToString())
            {
                j.AgenteElegido.CD++;
            }
        }

        public List<Jugador> CargarJugadoresLista(Jugador jugador)
        {
            this.jugadores.Add(jugador);

            this.CargarDatosAnalisis(jugador);

            return this.jugadores;
        }

        #endregion

    }
}
