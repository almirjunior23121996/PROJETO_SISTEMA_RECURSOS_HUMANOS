﻿namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioHoraExtra
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtHorasFeitas = new System.Windows.Forms.TextBox();
            this.panel1Resultado = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.button1Resultado = new System.Windows.Forms.Button();
            this.panel1Resultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "INFORME O SEU SALÁRIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "INFORME QUANTAS HORAS EXTRAS VOCÊ FEZ ESSE MÊS";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(16, 30);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 2;
            // 
            // txtHorasFeitas
            // 
            this.txtHorasFeitas.Location = new System.Drawing.Point(19, 79);
            this.txtHorasFeitas.Name = "txtHorasFeitas";
            this.txtHorasFeitas.Size = new System.Drawing.Size(100, 20);
            this.txtHorasFeitas.TabIndex = 3;
            // 
            // panel1Resultado
            // 
            this.panel1Resultado.Controls.Add(this.lblResultado);
            this.panel1Resultado.Location = new System.Drawing.Point(19, 121);
            this.panel1Resultado.Name = "panel1Resultado";
            this.panel1Resultado.Size = new System.Drawing.Size(200, 107);
            this.panel1Resultado.TabIndex = 4;
            this.panel1Resultado.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(61, 43);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(35, 13);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "label3";
            // 
            // button1Resultado
            // 
            this.button1Resultado.Location = new System.Drawing.Point(251, 205);
            this.button1Resultado.Name = "button1Resultado";
            this.button1Resultado.Size = new System.Drawing.Size(75, 23);
            this.button1Resultado.TabIndex = 5;
            this.button1Resultado.Text = "CALCULAR";
            this.button1Resultado.UseVisualStyleBackColor = true;
            // 
            // frmBeneficioHoraExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 245);
            this.Controls.Add(this.button1Resultado);
            this.Controls.Add(this.panel1Resultado);
            this.Controls.Add(this.txtHorasFeitas);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBeneficioHoraExtra";
            this.Text = "frmBeneficioHoraExtra";
            this.panel1Resultado.ResumeLayout(false);
            this.panel1Resultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtHorasFeitas;
        private System.Windows.Forms.Panel panel1Resultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button button1Resultado;
    }
}