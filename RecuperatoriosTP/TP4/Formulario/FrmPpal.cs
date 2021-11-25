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
    #region Delegados

    public delegate void InformacionDatos(string dato);
    public delegate List<Jugador> DescargaBaseDeDatos();

    #endregion

    public partial class FrmPpal : Form
    {
        #region Atributos 

        private Serializador<Jugador> serializadorXML;
        private List<Agente> agentes;
        private List<Jugador> jugadores;
        private List<Jugador> jugadoresLeidosXML;
        private string pathArchivosForm;
        CancellationTokenSource tokenSource;
        FrmMostrarJugadoresAnalisis frmMostrarJugadoresAnalisis;
        FrmMostrarAgentes frmMostrarAgentes;

        public static event InformacionDatos InformarDatos;
        public static event DescargaBaseDeDatos Descargando;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor sin parametros que seteara las listas,
        /// la ruta para guardar los archivos,
        /// el tokenSource para el cancelado del hilo secundario
        /// y sumara un manejador al evento para descargar archivos
        /// </summary>
        public FrmPpal()
        {
            InitializeComponent();

            this.agentes = new List<Agente>();
            this.jugadores = new List<Jugador>();
            this.jugadoresLeidosXML = new List<Jugador>();
            this.serializadorXML = new Serializador<Jugador>(IArchivo<Jugador>.ETipoArchivo.XML); 
            this.pathArchivosForm = Directory.GetCurrentDirectory() + @"\Archivos\JugadoresGuardados";
            this.tokenSource = new CancellationTokenSource();

            this.agentes = Agente.CrearListaAgentes();

            this.frmMostrarJugadoresAnalisis = new FrmMostrarJugadoresAnalisis();
            this.frmMostrarAgentes = new FrmMostrarAgentes(this.agentes);

            FrmPpal.Descargando += Jugador.GetListaSQL;
        }

        #endregion

        #region Eventos

        /// <summary>
        /// Evento load del formulario que seteara los datos de los ComboBox
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
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            try
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
            catch(TimeOutExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Tiempo de espera excedido");
            }
            
        }

        /// <summary>
        /// Evento del boton Agregar Jugadores Random
        /// Este tomara el numero que se le pase por el numericUpDown para saber cuantos jugadores agregar
        /// Este llamara a las Funciones Random obtendiendo los datos
        /// Luego llama al metodo que agregara un jugador a la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarJugadoresRandom_Click(object sender, EventArgs e)
        {
            try
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
            catch (TimeOutExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Tiempo de espera excedido");
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
        /// Ese form mostrara los archivos guardados previamente, 
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
        /// llamando a la funcion AgregarJugador
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
        /// Tambien cancelara cualquier hilo secundario que se este ejecutando en ese momento
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
        /// Bloqueando el boton para que no se apriete mas de una vez
        /// 
        /// Este metodo lo modifique para que obtenga los datos desde un hilo secundario
        /// ya que si la base de datos posee una gran cantidad de elementos va a quedarse trabado el programa
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBaseDeDatos_Click(object sender, EventArgs e)
        {
            try
            {
                CancellationToken token = this.tokenSource.Token;

                this.jugadores.Clear();
                this.lblDescarga.Text = "Descargando...";
                this.btnBaseDeDatos.Enabled = false;

                Task tarea = Task.Run(() =>
                {
                    this.Descargar(token);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Evento del boton Mostrar Jugadores Y Analisis del menu strip
        /// Este lo que hara es instanciar un nuevo formulario y mostrarlo
        /// Invocara a los eventos
        /// Los cual expondran la cantidad, los jugadores y el analisis de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mostrarJugadoresAnalisis_Click(object sender, EventArgs e)
        {
            this.frmMostrarJugadoresAnalisis.Show();

            this.EjecutarEvento();
        }

        /// <summary>
        /// Evento del boton Mostrar Agentes del menu strip
        /// Este lo que hara es instanciar un nuevo formulario y mostrarlo
        /// Pasandole por parametros del constructor la lista con los agentes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mostrarAgentes_Click(object sender, EventArgs e)
        {
            this.frmMostrarAgentes.Show();
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Este metodo creara un StringBuilder con todos los jugadores de la lista
        /// Tambien llamara al metodo de extension que retornara la cantidad de jugadores que hay
        /// 
        /// Metodo modificado para poder usar eventos y delegados
        /// 
        /// </summary>
        /// <returns> Retornara un string con los datos de los jugadores </returns>
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
        /// 
        /// Metodo modificado para poder usar eventos y delegados
        /// 
        /// </summary>
        /// <returns> Retornara un string con todos los datos del analisis </returns>
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

        /// <summary>
        /// Metodo que recibe un jugador y lo agrega a la lista de jugadores
        /// Tambien los agrega a la lista de la base de datos
        /// Y ejecuta los eventos para mostrarlos por pantalla
        /// </summary>
        /// <param name="jugador"></param>
        public void AgregarJugador(Jugador jugador)
        {
            this.jugadores.Add(jugador);

            Jugador.InsertJugador(jugador.Edad, jugador.Localidad, jugador.Rango, jugador.AgenteElegido.Nombre);

            this.EjecutarEvento();
        }

        /// <summary>
        /// Este ejecutara los eventos 
        /// Antes recorrera la lista de los manejadores asociados
        /// Y segun el nombre es la accion que se ejecuta
        /// 
        /// Para mostrar los jugadores se llamara al metodo RefrescarListaJugadores
        /// 
        /// Y para mostrar el analisis de datos llamara al metodo MostrarAnalisis
        /// 
        /// </summary>
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
        
        /// <summary>
        /// Metodo descargar el cual recibira un atributo para cancelar el hilo secundario
        /// Este invocara el evento Descargando para comenzar la descarga de los datos
        /// 
        /// UNA DESCARGA PESADA FUE SIMULADO HACIENDO UN SLEEP DE 5 SEGUNDOS
        /// 
        /// Este terminara una vez pasados los 5 segundos o cuando el programa se cierre
        /// </summary>
        /// <param name="cancellationToken"></param>
        public void Descargar(CancellationToken cancellationToken)
        {
            List<Jugador> jugadoresSQL = new List<Jugador>();

            try
            {
                while (true)
                {
                    if (cancellationToken.IsCancellationRequested)
                    {
                        return;
                    }

                    if (!(FrmPpal.Descargando is null))
                    {
                        jugadoresSQL = FrmPpal.Descargando.Invoke();

                        foreach (Jugador item in jugadoresSQL)
                        {
                            this.jugadores.Add(item);
                        }
                    }

                    //Pauso el hilo por 5 segundos para simular una descarga pesada desde la base de datos
                    for (int i = 0; i <= 6; i++)
                    {
                        this.IncremetarProgressBarEvent(i);
                        Thread.Sleep(1000);
                        if (i == 6)
                        {
                            return;
                        }
                    }
                }
            }
            catch (TimeOutExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Tiempo de espera excedido");
                this.IncremetarProgressBarEvent(-1);
            }
        }

        /// <summary>
        /// Delegado creado para el metodo incrementar la barra de progreso
        /// </summary>
        /// <param name="steps"></param>
        public delegate void IncrementarProgressBar(int steps);

        /// <summary>
        /// Este metodo incrementara la barra de progreso para mostrar que al apretar el boton
        /// se esta ejecutando algo
        /// 
        /// Al finalizar el metodo
        /// Pondra la barra en 0
        /// Cambiara el mensaje a Descargado
        /// Devolvera el boton a como estaba activado
        /// E invocara a los eventos asi se muestra la cantidad
        /// </summary>
        /// <param name="steps"></param>
        public void IncremetarProgressBarEvent(int steps)
        {
            if (this.progressBarDescarga.InvokeRequired)
            {
                IncrementarProgressBar del = new IncrementarProgressBar(this.IncremetarProgressBarEvent);
                object[] args = new object[] { steps };
                //Invoco al hilo principal 
                this.progressBarDescarga.Invoke(del, args);
            }
            else if (steps == 6)
            {
                this.progressBarDescarga.Value = 0;
                this.lblDescarga.Text = "Descargado";
                this.btnBaseDeDatos.Enabled = true;
                this.EjecutarEvento();
            }
            else if(steps == -1)
            {
                this.progressBarDescarga.Value = 0;
                this.lblDescarga.Text = "Falla en la descarga";
                this.btnBaseDeDatos.Enabled = true;
            }
            else
            {
                this.progressBarDescarga.Value = steps;
            }
        }

        #endregion

    }
}
