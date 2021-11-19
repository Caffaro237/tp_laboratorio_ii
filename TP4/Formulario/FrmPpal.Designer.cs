
namespace Formulario
{
    partial class FrmPpal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregarJugador = new System.Windows.Forms.Button();
            this.lblAgente = new System.Windows.Forms.Label();
            this.lblRango = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.cmbAgente = new System.Windows.Forms.ComboBox();
            this.cmbRango = new System.Windows.Forms.ComboBox();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.numUpDownEdad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidadRandon = new System.Windows.Forms.Label();
            this.numUpDownCantidadJugadores = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarJugadoresRandom = new System.Windows.Forms.Button();
            this.lblCantidadJugadores = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnGuardarArchivo = new System.Windows.Forms.Button();
            this.btnMostrarArchivo = new System.Windows.Forms.Button();
            this.btnCargarArchivos = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnBaseDeDatos = new System.Windows.Forms.Button();
            this.menuStripMostrar = new System.Windows.Forms.MenuStrip();
            this.mostrarJugadoresAnalisis = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarAgentes = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBarDescarga = new System.Windows.Forms.ProgressBar();
            this.lblDescarga = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownCantidadJugadores)).BeginInit();
            this.menuStripMostrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarJugador
            // 
            this.btnAgregarJugador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarJugador.Location = new System.Drawing.Point(12, 364);
            this.btnAgregarJugador.Name = "btnAgregarJugador";
            this.btnAgregarJugador.Size = new System.Drawing.Size(262, 71);
            this.btnAgregarJugador.TabIndex = 8;
            this.btnAgregarJugador.Text = "Agregar Jugador";
            this.btnAgregarJugador.UseVisualStyleBackColor = true;
            this.btnAgregarJugador.Click += new System.EventHandler(this.btnAgregarJugador_Click);
            // 
            // lblAgente
            // 
            this.lblAgente.AutoSize = true;
            this.lblAgente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAgente.Location = new System.Drawing.Point(12, 291);
            this.lblAgente.Name = "lblAgente";
            this.lblAgente.Size = new System.Drawing.Size(75, 28);
            this.lblAgente.TabIndex = 6;
            this.lblAgente.Text = "Agente";
            // 
            // lblRango
            // 
            this.lblRango.AutoSize = true;
            this.lblRango.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRango.Location = new System.Drawing.Point(12, 211);
            this.lblRango.Name = "lblRango";
            this.lblRango.Size = new System.Drawing.Size(69, 28);
            this.lblRango.TabIndex = 4;
            this.lblRango.Text = "Rango";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLocalidad.Location = new System.Drawing.Point(12, 131);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(96, 28);
            this.lblLocalidad.TabIndex = 2;
            this.lblLocalidad.Text = "Localidad";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEdad.Location = new System.Drawing.Point(12, 55);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(56, 28);
            this.lblEdad.TabIndex = 0;
            this.lblEdad.Text = "Edad";
            // 
            // cmbAgente
            // 
            this.cmbAgente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAgente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbAgente.FormattingEnabled = true;
            this.cmbAgente.Location = new System.Drawing.Point(12, 322);
            this.cmbAgente.Name = "cmbAgente";
            this.cmbAgente.Size = new System.Drawing.Size(262, 36);
            this.cmbAgente.TabIndex = 7;
            // 
            // cmbRango
            // 
            this.cmbRango.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRango.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbRango.FormattingEnabled = true;
            this.cmbRango.Location = new System.Drawing.Point(12, 242);
            this.cmbRango.Name = "cmbRango";
            this.cmbRango.Size = new System.Drawing.Size(262, 36);
            this.cmbRango.TabIndex = 5;
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocalidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(12, 163);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(262, 36);
            this.cmbLocalidad.TabIndex = 3;
            // 
            // numUpDownEdad
            // 
            this.numUpDownEdad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numUpDownEdad.Location = new System.Drawing.Point(12, 86);
            this.numUpDownEdad.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numUpDownEdad.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numUpDownEdad.Name = "numUpDownEdad";
            this.numUpDownEdad.ReadOnly = true;
            this.numUpDownEdad.Size = new System.Drawing.Size(262, 34);
            this.numUpDownEdad.TabIndex = 1;
            this.numUpDownEdad.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // lblCantidadRandon
            // 
            this.lblCantidadRandon.AutoSize = true;
            this.lblCantidadRandon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadRandon.Location = new System.Drawing.Point(301, 55);
            this.lblCantidadRandon.Name = "lblCantidadRandon";
            this.lblCantidadRandon.Size = new System.Drawing.Size(180, 28);
            this.lblCantidadRandon.TabIndex = 9;
            this.lblCantidadRandon.Text = "Jugadores Random";
            // 
            // numUpDownCantidadJugadores
            // 
            this.numUpDownCantidadJugadores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numUpDownCantidadJugadores.Location = new System.Drawing.Point(301, 86);
            this.numUpDownCantidadJugadores.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownCantidadJugadores.Name = "numUpDownCantidadJugadores";
            this.numUpDownCantidadJugadores.ReadOnly = true;
            this.numUpDownCantidadJugadores.Size = new System.Drawing.Size(262, 34);
            this.numUpDownCantidadJugadores.TabIndex = 10;
            this.numUpDownCantidadJugadores.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAgregarJugadoresRandom
            // 
            this.btnAgregarJugadoresRandom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarJugadoresRandom.Location = new System.Drawing.Point(301, 126);
            this.btnAgregarJugadoresRandom.Name = "btnAgregarJugadoresRandom";
            this.btnAgregarJugadoresRandom.Size = new System.Drawing.Size(262, 71);
            this.btnAgregarJugadoresRandom.TabIndex = 11;
            this.btnAgregarJugadoresRandom.Text = "Agregar Jugadores Random";
            this.btnAgregarJugadoresRandom.UseVisualStyleBackColor = true;
            this.btnAgregarJugadoresRandom.Click += new System.EventHandler(this.btnAgregarJugadoresRandom_Click);
            // 
            // lblCantidadJugadores
            // 
            this.lblCantidadJugadores.AutoSize = true;
            this.lblCantidadJugadores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadJugadores.Location = new System.Drawing.Point(424, 0);
            this.lblCantidadJugadores.Name = "lblCantidadJugadores";
            this.lblCantidadJugadores.Size = new System.Drawing.Size(319, 28);
            this.lblCantidadJugadores.TabIndex = 15;
            this.lblCantidadJugadores.Text = "Cantidad de Jugadores agregados: ";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCount.Location = new System.Drawing.Point(749, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCount.Size = new System.Drawing.Size(23, 28);
            this.lblCount.TabIndex = 16;
            this.lblCount.Text = "0";
            // 
            // btnGuardarArchivo
            // 
            this.btnGuardarArchivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarArchivo.Location = new System.Drawing.Point(631, 86);
            this.btnGuardarArchivo.Name = "btnGuardarArchivo";
            this.btnGuardarArchivo.Size = new System.Drawing.Size(262, 71);
            this.btnGuardarArchivo.TabIndex = 13;
            this.btnGuardarArchivo.Text = "Guardar Archivos";
            this.btnGuardarArchivo.UseVisualStyleBackColor = true;
            this.btnGuardarArchivo.Click += new System.EventHandler(this.btnGuardarArchivo_Click);
            // 
            // btnMostrarArchivo
            // 
            this.btnMostrarArchivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMostrarArchivo.Location = new System.Drawing.Point(631, 163);
            this.btnMostrarArchivo.Name = "btnMostrarArchivo";
            this.btnMostrarArchivo.Size = new System.Drawing.Size(262, 71);
            this.btnMostrarArchivo.TabIndex = 14;
            this.btnMostrarArchivo.Text = "Mostrar Archivos Guardados";
            this.btnMostrarArchivo.UseVisualStyleBackColor = true;
            this.btnMostrarArchivo.Click += new System.EventHandler(this.btnMostrarArchivo_Click);
            // 
            // btnCargarArchivos
            // 
            this.btnCargarArchivos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCargarArchivos.Location = new System.Drawing.Point(301, 203);
            this.btnCargarArchivos.Name = "btnCargarArchivos";
            this.btnCargarArchivos.Size = new System.Drawing.Size(262, 71);
            this.btnCargarArchivos.TabIndex = 12;
            this.btnCargarArchivos.Text = "Cargar desde Archivos";
            this.btnCargarArchivos.UseVisualStyleBackColor = true;
            this.btnCargarArchivos.Click += new System.EventHandler(this.btnCargarArchivos_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.Location = new System.Drawing.Point(631, 466);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(262, 71);
            this.btnCerrar.TabIndex = 22;
            this.btnCerrar.Text = "Cerrar ";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnBaseDeDatos
            // 
            this.btnBaseDeDatos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBaseDeDatos.Location = new System.Drawing.Point(301, 322);
            this.btnBaseDeDatos.Name = "btnBaseDeDatos";
            this.btnBaseDeDatos.Size = new System.Drawing.Size(262, 71);
            this.btnBaseDeDatos.TabIndex = 23;
            this.btnBaseDeDatos.Text = "Cargar desde Base de Datos";
            this.btnBaseDeDatos.UseVisualStyleBackColor = true;
            this.btnBaseDeDatos.Click += new System.EventHandler(this.btnBaseDeDatos_Click);
            // 
            // menuStripMostrar
            // 
            this.menuStripMostrar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMostrar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarJugadoresAnalisis,
            this.mostrarAgentes});
            this.menuStripMostrar.Location = new System.Drawing.Point(0, 0);
            this.menuStripMostrar.Name = "menuStripMostrar";
            this.menuStripMostrar.Size = new System.Drawing.Size(905, 28);
            this.menuStripMostrar.TabIndex = 24;
            this.menuStripMostrar.Text = "menuStrip1";
            // 
            // mostrarJugadoresAnalisis
            // 
            this.mostrarJugadoresAnalisis.Name = "mostrarJugadoresAnalisis";
            this.mostrarJugadoresAnalisis.Size = new System.Drawing.Size(210, 24);
            this.mostrarJugadoresAnalisis.Text = "Mostrar Jugadores y Analisis";
            this.mostrarJugadoresAnalisis.Click += new System.EventHandler(this.mostrarJugadoresAnalisis_Click);
            // 
            // mostrarAgentes
            // 
            this.mostrarAgentes.Name = "mostrarAgentes";
            this.mostrarAgentes.Size = new System.Drawing.Size(132, 24);
            this.mostrarAgentes.Text = "Mostrar Agentes";
            this.mostrarAgentes.Click += new System.EventHandler(this.mostrarAgentes_Click);
            // 
            // progressBarDescarga
            // 
            this.progressBarDescarga.Location = new System.Drawing.Point(301, 444);
            this.progressBarDescarga.Maximum = 5;
            this.progressBarDescarga.Name = "progressBarDescarga";
            this.progressBarDescarga.Size = new System.Drawing.Size(262, 24);
            this.progressBarDescarga.Step = 1;
            this.progressBarDescarga.TabIndex = 25;
            // 
            // lblDescarga
            // 
            this.lblDescarga.AutoSize = true;
            this.lblDescarga.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescarga.Location = new System.Drawing.Point(301, 407);
            this.lblDescarga.Name = "lblDescarga";
            this.lblDescarga.Size = new System.Drawing.Size(189, 28);
            this.lblDescarga.TabIndex = 26;
            this.lblDescarga.Text = "Esperando Descarga";
            // 
            // FrmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 549);
            this.Controls.Add(this.lblDescarga);
            this.Controls.Add(this.progressBarDescarga);
            this.Controls.Add(this.btnBaseDeDatos);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCargarArchivos);
            this.Controls.Add(this.btnMostrarArchivo);
            this.Controls.Add(this.btnGuardarArchivo);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblCantidadJugadores);
            this.Controls.Add(this.lblCantidadRandon);
            this.Controls.Add(this.numUpDownCantidadJugadores);
            this.Controls.Add(this.btnAgregarJugadoresRandom);
            this.Controls.Add(this.lblAgente);
            this.Controls.Add(this.lblRango);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.cmbAgente);
            this.Controls.Add(this.cmbRango);
            this.Controls.Add(this.cmbLocalidad);
            this.Controls.Add(this.numUpDownEdad);
            this.Controls.Add(this.btnAgregarJugador);
            this.Controls.Add(this.menuStripMostrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStripMostrar;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPpal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analisis de Agentes de Valorant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPpal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPpal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownCantidadJugadores)).EndInit();
            this.menuStripMostrar.ResumeLayout(false);
            this.menuStripMostrar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarJugador;
        private System.Windows.Forms.Label lblAgente;
        private System.Windows.Forms.Label lblRango;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.ComboBox cmbAgente;
        private System.Windows.Forms.ComboBox cmbRango;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.NumericUpDown numUpDownEdad;
        private System.Windows.Forms.Label lblCantidadRandon;
        private System.Windows.Forms.NumericUpDown numUpDownCantidadJugadores;
        private System.Windows.Forms.Button btnAgregarJugadoresRandom;
        private System.Windows.Forms.Label lblCantidadJugadores;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnGuardarArchivo;
        private System.Windows.Forms.Button btnMostrarArchivo;
        private System.Windows.Forms.Button btnCargarArchivos;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnBaseDeDatos;
        private System.Windows.Forms.MenuStrip menuStripMostrar;
        public System.Windows.Forms.ToolStripMenuItem mostrarJugadoresAnalisis;
        public System.Windows.Forms.ToolStripMenuItem mostrarAgentes;
        private System.Windows.Forms.ProgressBar progressBarDescarga;
        private System.Windows.Forms.Label lblDescarga;
    }
}

