
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
            this.rtcArchivosGuardados = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtcArchivosGuardados
            // 
            this.rtcArchivosGuardados.BackColor = System.Drawing.SystemColors.Control;
            this.rtcArchivosGuardados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtcArchivosGuardados.Location = new System.Drawing.Point(12, 12);
            this.rtcArchivosGuardados.Name = "rtcArchivosGuardados";
            this.rtcArchivosGuardados.ReadOnly = true;
            this.rtcArchivosGuardados.Size = new System.Drawing.Size(289, 646);
            this.rtcArchivosGuardados.TabIndex = 0;
            this.rtcArchivosGuardados.Text = "";
            // 
            // FrmMostrarArchivosGuardados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 670);
            this.Controls.Add(this.rtcArchivosGuardados);
            this.Name = "FrmMostrarArchivosGuardados";
            this.Text = "Archivos de Jugadores Guardados";
            this.Load += new System.EventHandler(this.FrmMostrarArchivosGuardados_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtcArchivosGuardados;
    }
}