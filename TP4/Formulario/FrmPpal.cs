using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Extensiones;

namespace Formulario
{
    public delegate void InformacionDatos(string dato);
    public delegate List<Jugador> DescargaBaseDeDatos();

    public partial class FrmPpal : Form
    {
        #region Atributos 

        private Serializador<Jugador> serializadorXML;
        private List<Agente> agentes;
        private List<Jugador> jugadores;
        private List<Jugador> jugadoresLeidosXML;
        private string pathArchivosForm;
        CancellationTokenSource tokenSource;

        public static event InformacionDatos InformarDatos;
        public static event DescargaBaseDeDatos Descargando;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor sin parametros que seteara las listas
        /// y la ruta para guardar los archivos
        /// </summary>
        public FrmPpal()
        {
            InitializeComponent();
            this.agentes = new List<Agente>();
            this.jugadores = new List<Jugador>();
            this.jugadoresLeidosXML = new List<Jugador>();
            this.serializadorXML = new Serializador<Jugador>(IArchivo<Jugador>.ETipoArchivo.XML); 
            this.pathArchivosForm = Directory.GetCurrentDirectory() + @"\Archivos\JugadoresGuardados";
            
            FrmPpal.Descargando += Jugador.GetListaSQL;

            this.agentes = Agente.CrearListaAgentes();
        }

        #endregion

        #region Eventos

        /// <summary>
        /// Evento load del formulario que seteara los datos de los ComboBox
        /// Mostrara los datos de loa agentes en un rich text box
        /// Tambien mostrara el analisis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPpal_Load(object sender, EventArgs e)
        {
            cmbLocalidad.DataSource = Enum.GetValues(typeof(Localidades));
            cmbRango.DataSource = Enum.GetValues(typeof(Rangos));

            foreach (Agente item in this.agentes)
            {
                this.cmbAgente.Items.Add(item.Nombre);
            }

            this.cmbAgente.SelectedIndex = 0;
        }

        /// <summary>
        /// Evento del cerrado del formulario
        /// Preguntara que se quiere hacer si cerrar o no 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta seguro?",
               "Cerrando",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }

            tokenSource.Cancel();
        }

        /// <summary>
        /// Evento del boton Agregar Jugador
        /// Este tomara los datos de los ComboBox y numericUpDown
        /// Llamara al metodo que agregara un jugador a la lista
        /// Al finalizar llamara al metodo que refrescara la lista de jugadores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            foreach (Agente item in this.agentes)
            {
                if (this.cmbAgente.SelectedItem.ToString() == item.Nombre)
                {
                    Jugador jugador = new Jugador((int)this.numUpDownEdad.Value, 
                        this.cmbLocalidad.SelectedItem.ToString(), 
                        this.cmbRango.SelectedItem.ToString(), 
                        item);

                    this.AgregarJugador(jugador);

                    break;
                }
            }
        }

        /// <summary>
        /// Evento del boton Agregar Jugadores Random
        /// Este tomara el numero que se le pase por el numericUpDown para saber cuantos jugadores agregar
        /// Este llamara a las Funciones Random obtendiendo los datos
        /// Luego llama al metodo que agregara un jugador a la lista
        /// 
        /// Al finalizar llamara al metodo que refrescara la lista de jugadores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        this.AgregarJugador(j);
                    }
                }
            }

        }

        /// <summary>
        /// Evento del boton Guardar Archivo
        /// Verificara si existe el directorio, si no existe lo crea y si existe lo borara y creara uno nuevo por si tiene datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Evento del boton Mostrar Archivo
        /// Este creara una nueva instancia el cual creara otro formulario
        /// este mostrara los archivos guardados previamente, 
        /// si no se guardo nada se mostrara un mensaje que no hay archivos en la ruta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Evento del boton Cargar desde Archivo
        /// 
        /// Este leera una ruta especifica la cual contiene jugadores guardados en archivos XML
        /// Este metodo leera los archivos y los agregara a la lista de jugadores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargarArchivos_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Directory.GetCurrentDirectory() + @"\Archivos\CargarJugadores";

                if (!Directory.Exists(path))
                {
                    throw new ArchivosExcepcion("No se encontro la ruta del archivo");
                }

                this.jugadoresLeidosXML = Jugador.LeerArchivos(path, serializadorXML);

                foreach (Jugador item in this.jugadoresLeidosXML)
                {
                    this.AgregarJugador(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            btnCargarArchivos.Enabled = false;
        }

        /// <summary>
        /// Evento del boton Cerrar
        /// Este boton cerrara el programa sin previo aviso
        /// Guardando los archivos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            btnGuardarArchivo_Click(sender, e);
            tokenSource.Cancel();
            this.Dispose();
        }

        /// <summary>
        /// Evento del boton Base De Datos
        /// En este evento se conectara con la base de datos y traera los jugadores que contenga
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBaseDeDatos_Click(object sender, EventArgs e)
        {
            try
            {
                this.tokenSource = new CancellationTokenSource();
                CancellationToken token = this.tokenSource.Token;

                this.jugadores.Clear();
                this.lblDescarga.Text = "Descargando...";
                this.btnBaseDeDatos.Enabled = false;

                Task tarea = Task.Run(() =>
                {
                    this.Descargar(token);
                });


                /*foreach (Jugador item in Jugador.GetListaSQL())
                {
                    this.jugadores.Add(item);
                    this.EjecutarEvento();
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Descargar(CancellationToken cancellationToken)
        {
            List<Jugador> jugadoresSQL = new List<Jugador>();

            while (true)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    return;
                }

                if (!(FrmPpal.Descargando is null))
                {
                    jugadoresSQL = FrmPpal.Descargando.Invoke();

                    foreach(Jugador item in jugadoresSQL)
                    {
                        this.jugadores.Add(item);
                    }
                }

                //Pauso el hilo por 5 segundos para simular una descarga pesada desde la base de datos
                for (int i = 0; i <= 6; i++)
                {
                    this.IncremetarProgressBarEvent(i);
                    Thread.Sleep(1000);
                    if(i == 6)
                    {
                        return;
                    }
                }
            }
        }

        public delegate void IncrementarProgressBar(int steps);

        public void IncremetarProgressBarEvent(int steps)
        {
            if(this.progressBarDescarga.InvokeRequired)
            {
                IncrementarProgressBar del = new IncrementarProgressBar(this.IncremetarProgressBarEvent);
                object[] args = new object[] { steps };
                //Invoco al hilo principal 
                this.progressBarDescarga.Invoke(del, args);
            }
            else if(steps == 6)
            {
                this.progressBarDescarga.Value = 0;
                this.lblDescarga.Text = "Descargado";
                this.btnBaseDeDatos.Enabled = true;
                this.EjecutarEvento();
            }
            else
            {
                this.progressBarDescarga.Value = steps;
            }
        }

        private void mostrarJugadoresAnalisis_Click(object sender, EventArgs e)
        {
            FrmMostrarJugadoresAnalisis frmMostrarJugadoresAnalisis = new FrmMostrarJugadoresAnalisis();

            frmMostrarJugadoresAnalisis.Show();

            this.EjecutarEvento();
        }

        private void mostrarAgentes_Click(object sender, EventArgs e)
        {
            FrmMostrarAgentes frmMostrarAgentes = new FrmMostrarAgentes(this.agentes);

            frmMostrarAgentes.Show();

        }

        #endregion

        #region Metodos

        /// <summary>
        /// Metodo que refrescara la lista de jugadores
        /// Por ahora no es recomendable porque si hay 3000 jugadores
        /// el formulario no responde hasta que termine el proceso
        /// 
        /// Solucionable con hilos
        /// </summary>
        public string RefrescarListaJugadores()
        {
            StringBuilder sb = new StringBuilder();

            this.lblCount.Text = this.jugadores.CantidadDeJugadores();

            foreach (Jugador item in this.jugadores)
            {
                sb.Append(item.ToString());
            }

            return sb.ToString();
        }

        /// <summary>
        /// Este metodo recorera la lista de agentes y obtendra los datos de cada uno
        /// Llamara a SacarPorcentaje y SacarPromedio
        /// </summary>
        public string MostrarAnalisis()
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

            return sb.ToString();
        }

        public void AgregarJugador(Jugador jugador)
        {
            this.jugadores.Add(jugador);

            Jugador.InsertJugador(jugador.Edad, jugador.Localidad, jugador.Rango, jugador.AgenteElegido.Nombre);

            this.EjecutarEvento();
        }

        public void EjecutarEvento()
        {
            if (!(FrmPpal.InformarDatos is null))
            {
                foreach (Delegate item in FrmPpal.InformarDatos.GetInvocationList())
                {
                    if (item.Method.Name == "MostrarJugadoresEvent")
                    {
                        ((InformacionDatos)item).Invoke(this.RefrescarListaJugadores());
                    }
                    else if (item.Method.Name == "MostrarAnalisisEvent")
                    {
                        ((InformacionDatos)item).Invoke(this.MostrarAnalisis());
                    }
                }
            }
        }

        #endregion

    }
}
