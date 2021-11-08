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
    public partial class FrmMostrarArchivosGuardados : Form
    {
        #region Atributo

        private List<Jugador> jugadores;

        #endregion

        #region Constructor 

        /// <summary>
        /// Constructor que recibe la lista de jugadores para setearla y luego mostrarla
        /// </summary>
        /// <param name="jugadores"></param>
        public FrmMostrarArchivosGuardados(List<Jugador> jugadores)
        {
            InitializeComponent();

            this.jugadores = new List<Jugador>();

            this.jugadores = jugadores;
        }

        #endregion

        #region Eventos

        /// <summary>
        /// Evento load del formulario que mostrara los archivos guardados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMostrarArchivosGuardados_Load(object sender, EventArgs e)
        {
            foreach (Jugador item in this.jugadores)
            {
                this.lblCount.Text = this.jugadores.Count.ToString();
                this.rtcArchivosGuardados.Text += item.ToString();
            }
        }

        /// <summary>
        /// Evento del boton Cerrar
        /// Cerrara el formulario para volver al anterior y seguir con el programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        #endregion

    }
}
