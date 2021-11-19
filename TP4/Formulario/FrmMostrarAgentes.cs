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
    public partial class FrmMostrarAgentes : Form
    {
        #region Atributo 

        private List<Agente> agentes;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor que recibe una lista de agentes por parametro
        /// 
        /// </summary>
        /// <param name="agentes"></param>
        public FrmMostrarAgentes(List<Agente> agentes)
        {
            InitializeComponent();

            this.agentes = new List<Agente>();

            this.agentes = agentes;

        }

        #endregion

        #region Eventos

        /// <summary>
        /// Evento Load del formulario de Agentes
        /// 
        /// Este recorrera la lista y los mostrara por el RichTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMostrarAgentes_Load(object sender, EventArgs e)
        {
            foreach (Agente item in this.agentes)
            {
                this.rtbAgentes.Text += item.ToString();
            }
        }

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
    }
}
