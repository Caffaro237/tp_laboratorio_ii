
namespace Formulario
{
    partial class FrmMostrarArchivosGuardados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMostrarArchivosGuardados));
            this.rtcArchivosGuardados = new System.Windows.Forms.RichTextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblCantidadJugadores = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtcArchivosGuardados
            // 
            this.rtcArchivosGuardados.BackColor = System.Drawing.SystemColors.Control;
            this.rtcArchivosGuardados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtcArchivosGuardados.Location = new System.Drawing.Point(14, 79);
            this.rtcArchivosGuardados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtcArchivosGuardados.Name = "rtcArchivosGuardados";
            this.rtcArchivosGuardados.ReadOnly = true;
            this.rtcArchivosGuardados.Size = new System.Drawing.Size(330, 714);
            this.rtcArchivosGuardados.TabIndex = 0;
            this.rtcArchivosGuardados.Text = "";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.Location = new System.Drawing.Point(14, 800);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(330, 71);
            this.btnCerrar.TabIndex = 23;
            this.btnCerrar.Text = "Cerrar ";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCount.Location = new System.Drawing.Point(231, 9);
            this.lblCount.Name = "lblCount";
            this.lblCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCount.Size = new System.Drawing.Size(23, 28);
            this.lblCount.TabIndex = 25;
            this.lblCount.Text = "0";
            // 
            // lblCantidadJugadores
            // 
            this.lblCantidadJugadores.AutoSize = true;
            this.lblCantidadJugadores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadJugadores.Location = new System.Drawing.Point(14, 9);
            this.lblCantidadJugadores.Name = "lblCantidadJugadores";
            this.lblCantidadJugadores.Size = new System.Drawing.Size(211, 28);
            this.lblCantidadJugadores.TabIndex = 24;
            this.lblCantidadJugadores.Text = "Jugadores Guardados: ";
            // 
            // FrmMostrarArchivosGuardados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 883);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblCantidadJugadores);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.rtcArchivosGuardados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMostrarArchivosGuardados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archivos de Jugadores Guardados";
            this.Load += new System.EventHandler(this.FrmMostrarArchivosGuardados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtcArchivosGuardados;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblCantidadJugadores;
    }
}