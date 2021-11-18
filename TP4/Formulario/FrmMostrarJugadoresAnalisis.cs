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
        CancellationTokenSource tokenSource;

        public FrmMostrarJugadoresAnalisis()
        {
            InitializeComponent();

            this.tokenSource = new CancellationTokenSource();
            CancellationToken token = this.tokenSource.Token;

            FrmPpal.InformarDatos += this.MostrarJugadoresEvent;
            FrmPpal.InformarDatos += this.MostrarAnalisisEvent;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarJugadoresEvent(string datos)
        {
            if (this.rtbJugadores.InvokeRequired)
            {
                InformacionDatos del = new InformacionDatos(this.MostrarJugadoresEvent);
                object[] args = new object[] { datos };
                //Invoco al hilo principal 
                this.rtbJugadores.Invoke(del, args);
            }
            else
            {
                this.rtbJugadores.Text = datos;
            }
        }

        private void MostrarAnalisisEvent(string datos)
        {
            if (this.rtbAnalisis.InvokeRequired)
            {
                InformacionDatos del = new InformacionDatos(this.MostrarAnalisisEvent);
                object[] args = new object[] { datos };
                //Invoco al hilo principal 
                this.rtbAnalisis.Invoke(del, args);
            }
            else
            {
                this.rtbAnalisis.Text = datos;
            }
        }
    }
}
