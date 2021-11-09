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
        /// Unico contructor sin parametros
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        /// <summary>
        /// Evento load del formulario
        /// Al iniciar limpia todos los campos del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Evento closing
        /// Al detectar que el formulario se esta cerrando preguntara si se quiere cerrar o no
        /// Esto cancelara o seguira con el cerrado del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de querer salir?",
               "Cerrando Calculadora",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Evento del boton Operar
        /// Al ser precionado este llamara a la funcion Operar la cual 
        /// recibira los datos necesarios para ejecutar la operacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double respuesta = 0;

            respuesta = FormCalculadora.Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);

            this.lblResultado.Text = respuesta.ToString();
            this.lstOperaciones.Items.Add(this.txtNumero1.Text + " " + this.cmbOperador.Text + " " + this.txtNumero2.Text + " = " + respuesta.ToString());
        }

        /// <summary>
        /// Evento del boton limpiar
        /// Llamara a la funcion limpiar que borrara todos los datos de los campos del fomulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Evento del boton Cerrar
        /// Preguntara si se quiere cerrar o no el formulaio
        /// Esto cancelara o seguira con el cerrado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento del boton Convertir A Binario
        /// Este evento llamara a la funcion DecimalBinario para realizar la operacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando numero1 = new Operando();
            string numeroAnterior;

            numeroAnterior = this.lblResultado.Text;

            this.lblResultado.Text = numero1.DecimalBinario(this.lblResultado.Text);
            this.lstOperaciones.Items.Add("Decimal " + numeroAnterior + " a binario " + this.lblResultado.Text);
        }

        /// <summary>
        /// Evento del boton Convertir A Decimal
        /// Este evento llamara a la funcion BinarioDecimal para realizar la operacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando numero1 = new Operando();
            string numeroAnterior;

            numeroAnterior = this.lblResultado.Text;

            this.lblResultado.Text = numero1.BinarioDecimal(this.lblResultado.Text);
            this.lstOperaciones.Items.Add("Binario " + numeroAnterior + " a decimal " + this.lblResultado.Text);
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Metodo limpiar
        /// Borrara los datos de los campos del fomulario
        /// Poniendolos en blanco
        /// </summary>
        public void Limpiar()
        {
            this.txtNumero1.Text = string.Empty;
            this.txtNumero2.Text = string.Empty;

            this.cmbOperador.Text = string.Empty;

            this.lblResultado.Text = string.Empty;
        }

        /// <summary>
        /// Metodo Operar
        /// Este metodo instanciara dos numeros y convertira el string a char
        /// Llamara a la funcion Operar de la clase Calculadora y retornara el resultado
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns> Retorna un double que va a ser obtenido desde la funcion Operar de la clase Calculadora </returns>
        public static double Operar(string numero1, string numero2, string operador)
        {
            Operando n1 = new Operando(numero1);
            Operando n2 = new Operando(numero2);
            char operadorChar;

            char.TryParse(operador, out operadorChar);

            return Calculadora.Operar(n1, n2, operadorChar);
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
        private void txtNumero1_KeyPress_1(object sender, KeyPressEventArgs e)
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
                        //MessageBox.Show("Solo se puede ingresar un solo punto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        //MessageBox.Show("Solo se puede ingresar un solo menos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                //MessageBox.Show("Ingresar solo numeros o numeros decimales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Verifica que no se ingresen letras para que el programa no de error
        /// Tambien se verifico que solo se pueda ingresar un solo . para los numeros con decimal
        /// Y que solo se ingrese un - en caso de querer poner un numero negativo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumero2_KeyPress_1(object sender, KeyPressEventArgs e)
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
                        //MessageBox.Show("Solo se puede ingresar un solo punto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        //MessageBox.Show("Solo se puede ingresar un solo menos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                //MessageBox.Show("Ingresar solo numeros o numeros decimales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

    }
}
