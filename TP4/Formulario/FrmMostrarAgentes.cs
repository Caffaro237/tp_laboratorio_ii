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
        private List<Agente> agentes;

        public FrmMostrarAgentes(List<Agente> agentes)
        {
            InitializeComponent();

            this.agentes = agentes;

            foreach (Agente item in this.agentes)
            {
                this.rtbAgentes.Text += item.ToString();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMostrarAgentes_Load(object sender, EventArgs e)
        {
            this.agentes = new List<Agente>();
        }
    }
}
