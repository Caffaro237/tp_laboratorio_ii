
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
            this.rtbJugadores = new System.Windows.Forms.RichTextBox();
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
            this.rtbAgentes = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbAnalisis = new System.Windows.Forms.RichTextBox();
            this.lblAnalisis = new System.Windows.Forms.Label();
            this.btnGuardarArchivo = new System.Windows.Forms.Button();
            this.btnMostrarArchivo = new System.Windows.Forms.Button();
            this.btnCargarArchivos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownCantidadJugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarJugador
            // 
            this.btnAgregarJugador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarJugador.Location = new System.Drawing.Point(10, 246);
            this.btnAgregarJugador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarJugador.Name = "btnAgregarJugador";
            this.btnAgregarJugador.Size = new System.Drawing.Size(230, 53);
            this.btnAgregarJugador.TabIndex = 0;
            this.btnAgregarJugador.Text = "Agregar Jugador";
            this.btnAgregarJugador.UseVisualStyleBackColor = true;
            this.btnAgregarJugador.Click += new System.EventHandler(this.btnAgregarJugador_Click);
            // 
            // rtbJugadores
            // 
            this.rtbJugadores.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtbJugadores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbJugadores.Location = new System.Drawing.Point(267, 30);
            this.rtbJugadores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbJugadores.Name = "rtbJugadores";
            this.rtbJugadores.ReadOnly = true;
            this.rtbJugadores.Size = new System.Drawing.Size(311, 626);
            this.rtbJugadores.TabIndex = 1;
            this.rtbJugadores.Text = "";
            // 
            // lblAgente
            // 
            this.lblAgente.AutoSize = true;
            this.lblAgente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAgente.Location = new System.Drawing.Point(10, 184);
            this.lblAgente.Name = "lblAgente";
            this.lblAgente.Size = new System.Drawing.Size(59, 21);
            this.lblAgente.TabIndex = 18;
            this.lblAgente.Text = "Agente";
            // 
            // lblRango
            // 
            this.lblRango.AutoSize = true;
            this.lblRango.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRango.Location = new System.Drawing.Point(10, 124);
            this.lblRango.Name = "lblRango";
            this.lblRango.Size = new System.Drawing.Size(55, 21);
            this.lblRango.TabIndex = 17;
            this.lblRango.Text = "Rango";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLocalidad.Location = new System.Drawing.Point(10, 64);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(76, 21);
            this.lblLocalidad.TabIndex = 16;
            this.lblLocalidad.Text = "Localidad";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEdad.Location = new System.Drawing.Point(10, 7);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(44, 21);
            this.lblEdad.TabIndex = 15;
            this.lblEdad.Text = "Edad";
            // 
            // cmbAgente
            // 
            this.cmbAgente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAgente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbAgente.FormattingEnabled = true;
            this.cmbAgente.Location = new System.Drawing.Point(10, 207);
            this.cmbAgente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAgente.Name = "cmbAgente";
            this.cmbAgente.Size = new System.Drawing.Size(230, 29);
            this.cmbAgente.TabIndex = 14;
            // 
            // cmbRango
            // 
            this.cmbRango.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRango.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbRango.FormattingEnabled = true;
            this.cmbRango.Location = new System.Drawing.Point(10, 147);
            this.cmbRango.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRango.Name = "cmbRango";
            this.cmbRango.Size = new System.Drawing.Size(230, 29);
            this.cmbRango.TabIndex = 13;
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocalidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(10, 88);
            this.cmbLocalidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(230, 29);
            this.cmbLocalidad.TabIndex = 12;
            // 
            // numUpDownEdad
            // 
            this.numUpDownEdad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numUpDownEdad.Location = new System.Drawing.Point(10, 30);
            this.numUpDownEdad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.numUpDownEdad.Size = new System.Drawing.Size(230, 29);
            this.numUpDownEdad.TabIndex = 11;
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
            this.lblCantidadRandon.Location = new System.Drawing.Point(10, 327);
            this.lblCantidadRandon.Name = "lblCantidadRandon";
            this.lblCantidadRandon.Size = new System.Drawing.Size(135, 21);
            this.lblCantidadRandon.TabIndex = 21;
            this.lblCantidadRandon.Text = "Cantidad Random";
            // 
            // numUpDownCantidadJugadores
            // 
            this.numUpDownCantidadJugadores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numUpDownCantidadJugadores.Location = new System.Drawing.Point(10, 350);
            this.numUpDownCantidadJugadores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numUpDownCantidadJugadores.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownCantidadJugadores.Name = "numUpDownCantidadJugadores";
            this.numUpDownCantidadJugadores.ReadOnly = true;
            this.numUpDownCantidadJugadores.Size = new System.Drawing.Size(230, 29);
            this.numUpDownCantidadJugadores.TabIndex = 20;
            this.numUpDownCantidadJugadores.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAgregarJugadoresRandom
            // 
            this.btnAgregarJugadoresRandom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarJugadoresRandom.Location = new System.Drawing.Point(10, 387);
            this.btnAgregarJugadoresRandom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarJugadoresRandom.Name = "btnAgregarJugadoresRandom";
            this.btnAgregarJugadoresRandom.Size = new System.Drawing.Size(230, 53);
            this.btnAgregarJugadoresRandom.TabIndex = 19;
            this.btnAgregarJugadoresRandom.Text = "Agregar Jugadores Random";
            this.btnAgregarJugadoresRandom.UseVisualStyleBackColor = true;
            this.btnAgregarJugadoresRandom.Click += new System.EventHandler(this.btnAgregarJugadoresRandom_Click);
            // 
            // lblCantidadJugadores
            // 
            this.lblCantidadJugadores.AutoSize = true;
            this.lblCantidadJugadores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadJugadores.Location = new System.Drawing.Point(267, 7);
            this.lblCantidadJugadores.Name = "lblCantidadJugadores";
            this.lblCantidadJugadores.Size = new System.Drawing.Size(175, 21);
            this.lblCantidadJugadores.TabIndex = 22;
            this.lblCantidadJugadores.Text = "Cantidad de Jugadores: ";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCount.Location = new System.Drawing.Point(466, 7);
            this.lblCount.Name = "lblCount";
            this.lblCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCount.Size = new System.Drawing.Size(19, 21);
            this.lblCount.TabIndex = 23;
            this.lblCount.Text = "0";
            // 
            // rtbAgentes
            // 
            this.rtbAgentes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtbAgentes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbAgentes.Location = new System.Drawing.Point(583, 30);
            this.rtbAgentes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbAgentes.Name = "rtbAgentes";
            this.rtbAgentes.ReadOnly = true;
            this.rtbAgentes.Size = new System.Drawing.Size(518, 260);
            this.rtbAgentes.TabIndex = 24;
            this.rtbAgentes.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(583, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Agentes";
            // 
            // rtbAnalisis
            // 
            this.rtbAnalisis.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtbAnalisis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbAnalisis.Location = new System.Drawing.Point(583, 327);
            this.rtbAnalisis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbAnalisis.Name = "rtbAnalisis";
            this.rtbAnalisis.ReadOnly = true;
            this.rtbAnalisis.Size = new System.Drawing.Size(518, 328);
            this.rtbAnalisis.TabIndex = 26;
            this.rtbAnalisis.Text = "";
            // 
            // lblAnalisis
            // 
            this.lblAnalisis.AutoSize = true;
            this.lblAnalisis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAnalisis.Location = new System.Drawing.Point(583, 304);
            this.lblAnalisis.Name = "lblAnalisis";
            this.lblAnalisis.Size = new System.Drawing.Size(128, 21);
            this.lblAnalisis.TabIndex = 27;
            this.lblAnalisis.Text = "Analisis de Datos";
            // 
            // btnGuardarArchivo
            // 
            this.btnGuardarArchivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarArchivo.Location = new System.Drawing.Point(10, 543);
            this.btnGuardarArchivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarArchivo.Name = "btnGuardarArchivo";
            this.btnGuardarArchivo.Size = new System.Drawing.Size(230, 53);
            this.btnGuardarArchivo.TabIndex = 28;
            this.btnGuardarArchivo.Text = "Guardar Archivos";
            this.btnGuardarArchivo.UseVisualStyleBackColor = true;
            this.btnGuardarArchivo.Click += new System.EventHandler(this.btnGuardarArchivo_Click);
            // 
            // btnMostrarArchivo
            // 
            this.btnMostrarArchivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMostrarArchivo.Location = new System.Drawing.Point(10, 600);
            this.btnMostrarArchivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMostrarArchivo.Name = "btnMostrarArchivo";
            this.btnMostrarArchivo.Size = new System.Drawing.Size(230, 53);
            this.btnMostrarArchivo.TabIndex = 29;
            this.btnMostrarArchivo.Text = "Mostrar Archivos Guardados";
            this.btnMostrarArchivo.UseVisualStyleBackColor = true;
            this.btnMostrarArchivo.Click += new System.EventHandler(this.btnMostrarArchivo_Click);
            // 
            // btnCargarArchivos
            // 
            this.btnCargarArchivos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCargarArchivos.Location = new System.Drawing.Point(10, 456);
            this.btnCargarArchivos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargarArchivos.Name = "btnCargarArchivos";
            this.btnCargarArchivos.Size = new System.Drawing.Size(230, 53);
            this.btnCargarArchivos.TabIndex = 30;
            this.btnCargarArchivos.Text = "Cargar desde Archivos";
            this.btnCargarArchivos.UseVisualStyleBackColor = true;
            this.btnCargarArchivos.Click += new System.EventHandler(this.btnCargarArchivos_Click);
            // 
            // FrmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 664);
            this.Controls.Add(this.btnCargarArchivos);
            this.Controls.Add(this.btnMostrarArchivo);
            this.Controls.Add(this.btnGuardarArchivo);
            this.Controls.Add(this.lblAnalisis);
            this.Controls.Add(this.rtbAnalisis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbAgentes);
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
            this.Controls.Add(this.rtbJugadores);
            this.Controls.Add(this.btnAgregarJugador);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmPpal";
            this.Text = "Analisis de Agentes de Valorant";
            this.Load += new System.EventHandler(this.FrmPpal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownCantidadJugadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarJugador;
        private System.Windows.Forms.RichTextBox rtbJugadores;
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
        private System.Windows.Forms.RichTextBox rtbAgentes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbAnalisis;
        private System.Windows.Forms.Label lblAnalisis;
        private System.Windows.Forms.Button btnGuardarArchivo;
        private System.Windows.Forms.Button btnMostrarArchivo;
        private System.Windows.Forms.Button btnCargarArchivos;
    }
}

