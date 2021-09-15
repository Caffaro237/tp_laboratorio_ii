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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        #region Constructor

        public FormCalculadora()
        {
            InitializeComponent();
        }

        #endregion

        #region Metodos

        private void Limpiar()
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.cmbOperador.Text = "";
            this.lblResultado.Text = "0";
        }
        private static double Operar(string strNumero1, string strNumero2, string operador)
        {
            Operando numero1 = new Operando(strNumero1);
            Operando numero2 = new Operando(strNumero2);

            return Calculadora.Operar(numero1, numero2, operador);
        }

        #endregion

        #region Eventos

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta seguro?",
               "Cerrando Calculadora",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        #endregion

        #region Botones

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double respuesta = 0;

            if(!(this.txtNumero1.Text == string.Empty || this.cmbOperador.Text == string.Empty || this.txtNumero2.Text == string.Empty))
            {
                respuesta = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);

                this.lblResultado.Text = respuesta.ToString();
                this.lstOperaciones.Items.Add(this.txtNumero1.Text + " " + this.cmbOperador.Text + " " + this.txtNumero2.Text + " = " + respuesta.ToString());
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ctnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando numero1 = new Operando();
            string numeroAnterior;

            numeroAnterior = this.lblResultado.Text;

            this.lblResultado.Text = numero1.DecimalBinario(this.lblResultado.Text);
            this.lstOperaciones.Items.Add("Decimal a binario " + numeroAnterior + " = " + this.lblResultado.Text);
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando numero1 = new Operando();
            string numeroAnterior;

            numeroAnterior = lblResultado.Text;

            this.lblResultado.Text = numero1.BinarioDecimal(this.lblResultado.Text);
            this.lstOperaciones.Items.Add("Binario a decimal " + numeroAnterior + " = " + this.lblResultado.Text);
        }

        #endregion
    }
}
