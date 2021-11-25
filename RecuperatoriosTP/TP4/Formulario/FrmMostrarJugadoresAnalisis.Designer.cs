
namespace Formulario
{
    partial class FrmMostrarJugadoresAnalisis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMostrarJugadoresAnalisis));
            this.rtbJugadores = new System.Windows.Forms.RichTextBox();
            this.lblAnalisis = new System.Windows.Forms.Label();
            this.rtbAnalisis = new System.Windows.Forms.RichTextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbJugadores
            // 
            this.rtbJugadores.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtbJugadores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbJugadores.Location = new System.Drawing.Point(12, 40);
            this.rtbJugadores.Name = "rtbJugadores";
            this.rtbJugadores.ReadOnly = true;
            this.rtbJugadores.Size = new System.Drawing.Size(355, 553);
            this.rtbJugadores.TabIndex = 19;
            this.rtbJugadores.Text = "";
            // 
            // lblAnalisis
            // 
            this.lblAnalisis.AutoSize = true;
            this.lblAnalisis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAnalisis.Location = new System.Drawing.Point(373, 9);
            this.lblAnalisis.Name = "lblAnalisis";
            this.lblAnalisis.Size = new System.Drawing.Size(160, 28);
            this.lblAnalisis.TabIndex = 22;
            this.lblAnalisis.Text = "Analisis de Datos";
            // 
            // rtbAnalisis
            // 
            this.rtbAnalisis.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtbAnalisis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbAnalisis.Location = new System.Drawing.Point(373, 40);
            this.rtbAnalisis.Name = "rtbAnalisis";
            this.rtbAnalisis.ReadOnly = true;
            this.rtbAnalisis.Size = new System.Drawing.Size(591, 436);
            this.rtbAnalisis.TabIndex = 23;
            this.rtbAnalisis.Text = "";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(615, 503);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(278, 74);
            this.btnCerrar.TabIndex = 24;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmMostrarJugadoresAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 605);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblAnalisis);
            this.Controls.Add(this.rtbAnalisis);
            this.Controls.Add(this.rtbJugadores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMostrarJugadoresAnalisis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jugadores y Analisis de Datos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMostrarJugadoresAnalisis_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbJugadores;
        private System.Windows.Forms.Label lblAnalisis;
        private System.Windows.Forms.RichTextBox rtbAnalisis;
        private System.Windows.Forms.Button btnCerrar;
    }
}