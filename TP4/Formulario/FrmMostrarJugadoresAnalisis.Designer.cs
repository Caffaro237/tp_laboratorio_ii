
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
            this.lblCount = new System.Windows.Forms.Label();
            this.lblCantidadJugadores = new System.Windows.Forms.Label();
            this.rtbJugadores = new System.Windows.Forms.RichTextBox();
            this.lblAnalisis = new System.Windows.Forms.Label();
            this.rtbAnalisis = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCount.Location = new System.Drawing.Point(240, 9);
            this.lblCount.Name = "lblCount";
            this.lblCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCount.Size = new System.Drawing.Size(23, 28);
            this.lblCount.TabIndex = 18;
            this.lblCount.Text = "0";
            // 
            // lblCantidadJugadores
            // 
            this.lblCantidadJugadores.AutoSize = true;
            this.lblCantidadJugadores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadJugadores.Location = new System.Drawing.Point(12, 9);
            this.lblCantidadJugadores.Name = "lblCantidadJugadores";
            this.lblCantidadJugadores.Size = new System.Drawing.Size(221, 28);
            this.lblCantidadJugadores.TabIndex = 17;
            this.lblCantidadJugadores.Text = "Cantidad de Jugadores: ";
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
            // FrmMostrarJugadoresAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 605);
            this.Controls.Add(this.lblAnalisis);
            this.Controls.Add(this.rtbAnalisis);
            this.Controls.Add(this.rtbJugadores);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblCantidadJugadores);
            this.Name = "FrmMostrarJugadoresAnalisis";
            this.Text = "FrmMostrarJugadoresAnalisis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblCantidadJugadores;
        private System.Windows.Forms.RichTextBox rtbJugadores;
        private System.Windows.Forms.Label lblAnalisis;
        private System.Windows.Forms.RichTextBox rtbAnalisis;
    }
}