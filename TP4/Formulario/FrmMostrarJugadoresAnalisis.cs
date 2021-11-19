using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Formulario
{
    public partial class FrmMostrarJugadoresAnalisis : Form
    {
        #region Atributo 

        CancellationTokenSource tokenSource;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor por defecto
        /// 
        /// Este inicializara tokenSourse
        /// Y asignara los manejadores al evento
        /// </summary>
        public FrmMostrarJugadoresAnalisis()
        {
            InitializeComponent();

            this.tokenSource = new CancellationTokenSource();
            CancellationToken token = this.tokenSource.Token;

            FrmPpal.InformarDatos += this.MostrarJugadoresEvent;
            FrmPpal.InformarDatos += this.MostrarAnalisisEvent;

        }

        #endregion

        #region Eventos

        /// <summary>
        /// Evento del boton Cerrar
        /// 
        /// Cerrara el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Manejadores del evento

        /// <summary>
        /// Este manejador es el encargado pasar la informacion
        /// de los jugadores de un formulario a otro
        /// </summary>
        /// <param name="datos"></param>
        private void MostrarJugadoresEvent(string datos)
        {
            if (this.rtbJugadores.InvokeRequired)
            {
                InformacionDatos del = new InformacionDatos(this.MostrarJugadoresEvent);
                object[] args = new object[] { datos };
                this.rtbJugadores.Invoke(del, args);
            }
            else
            {
                this.rtbJugadores.Text = datos;
            }
        }

        /// <summary>
        /// Este manejador es el encargado pasar la informacion
        /// del analisis de datos de un formulario a otro
        /// </summary>
        /// <param name="datos"></param>
        private void MostrarAnalisisEvent(string datos)
        {
            if (this.rtbAnalisis.InvokeRequired)
            {
                InformacionDatos del = new InformacionDatos(this.MostrarAnalisisEvent);
                object[] args = new object[] { datos };
                this.rtbAnalisis.Invoke(del, args);
            }
            else
            {
                this.rtbAnalisis.Text = datos;
            }
        }

        #endregion

    }
}
