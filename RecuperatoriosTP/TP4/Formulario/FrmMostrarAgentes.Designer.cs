﻿
namespace Formulario
{
    partial class FrmMostrarAgentes
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
            this.label1 = new System.Windows.Forms.Label();
            this.rtbAgentes = new System.Windows.Forms.RichTextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "Agentes";
            // 
            // rtbAgentes
            // 
            this.rtbAgentes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtbAgentes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbAgentes.Location = new System.Drawing.Point(12, 40);
            this.rtbAgentes.Name = "rtbAgentes";
            this.rtbAgentes.ReadOnly = true;
            this.rtbAgentes.Size = new System.Drawing.Size(597, 350);
            this.rtbAgentes.TabIndex = 21;
            this.rtbAgentes.Text = "";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(158, 396);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(316, 55);
            this.btnCerrar.TabIndex = 22;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmMostrarAgentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 463);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbAgentes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMostrarAgentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMostrarAgentes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMostrarAgentes_FormClosing);
            this.Load += new System.EventHandler(this.FrmMostrarAgentes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbAgentes;
        private System.Windows.Forms.Button btnCerrar;
    }
}