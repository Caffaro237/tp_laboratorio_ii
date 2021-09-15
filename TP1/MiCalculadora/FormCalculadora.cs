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

        /// <summary>
        /// Constructor per defecto del formulario
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Metodo que limpia todas las casillas del formulario
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.cmbOperador.Text = "";
            this.lblResultado.Text = "0";
        }

        /// <summary>
        /// Metodo operar que recibe los parametros necesarios para realizar la operacion
        /// </summary>
        /// <param name="strNumero1"></param>
        /// <param name="strNumero2"></param>
        /// <param name="operador"></param>
        /// <returns> Retorna un valor double obtenido de la llamada a Calculadora.Operar </returns>
        private static double Operar(string strNumero1, string strNumero2, string operador)
        {
            Operando numero1 = new Operando(strNumero1);
            Operando numero2 = new Operando(strNumero2);

            return Calculadora.Operar(numero1, numero2, operador);
        }

        #endregion

        #region Eventos

        /// <summary>
        /// Evento load del formulario que inicializa todos los valores limpios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Evento de cerrado del formulario
        /// Genera un cuadro de texto preguntando si desea salir o no
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Boton que realiza la operacion
        /// Preguntando antes si las casillas estan vacias o no
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Boton que limpia todos los valores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Boton que cierra sin preguntar la calculadora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// Boton que convierte de decimal a binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ctnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando numero1 = new Operando();
            string numeroAnterior;

            numeroAnterior = this.lblResultado.Text;

            this.lblResultado.Text = numero1.DecimalBinario(this.lblResultado.Text);
            this.lstOperaciones.Items.Add("Decimal a binario " + numeroAnterior + " = " + this.lblResultado.Text);
        }

        /// <summary>
        /// Boton que convierte de binario a decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando numero1 = new Operando();
            string numeroAnterior;

            numeroAnterior = lblResultado.Text;

            this.lblResultado.Text = numero1.BinarioDecimal(this.lblResultado.Text);
            this.lstOperaciones.Items.Add("Binario a decimal " + numeroAnterior + " = " + this.lblResultado.Text);
        }

        #endregion

        #region TextBox error letras

        /// <summary>
        /// Verifica que no se ingresen letras para que el programa no de error
        /// Tambien se verifico que solo se pueda ingresar un solo . para los numeros con decimal
        /// Y que solo se ingrese un - en caso de querer poner un numero negativo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().Equals("."))
            {
                foreach (char item in this.txtNumero1.Text)
                {
                    if (item == '.')
                    {
                        e.Handled = true;
                        MessageBox.Show("Solo se puede ingresar un solo punto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    else
                    {
                        e.Handled = false;
                    }
                }
            }
            else if (e.KeyChar.ToString().Equals("-"))
            {
                foreach (char item in this.txtNumero1.Text)
                {
                    if (item == '-')
                    {
                        e.Handled = true;
                        MessageBox.Show("Solo se puede ingresar un solo menos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    else
                    {
                        e.Handled = false;
                    }
                }
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Ingresar solo numeros o numeros decimales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Verifica que no se ingresen letras para que el programa no de error
        /// Tambien se verifico que solo se pueda ingresar un solo . para los numeros con decimal
        /// Y que solo se ingrese un - en caso de querer poner un numero negativo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().Equals("."))
            {
                foreach (char item in this.txtNumero2.Text)
                {
                    if (item == '.')
                    {
                        e.Handled = true;
                        MessageBox.Show("Solo se puede ingresar un solo punto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    else
                    {
                        e.Handled = false;
                    }
                }
            }
            else if (e.KeyChar.ToString().Equals("-"))
            {
                foreach (char item in this.txtNumero2.Text)
                {
                    if (item == '-')
                    {
                        e.Handled = true;
                        MessageBox.Show("Solo se puede ingresar un solo menos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    else
                    {
                        e.Handled = false;
                    }
                }
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Ingresar solo numeros o numeros decimales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

    }
}
