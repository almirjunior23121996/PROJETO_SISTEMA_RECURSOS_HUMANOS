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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficioHoraExtra));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtHorasFeitas = new System.Windows.Forms.TextBox();
            this.panel1Resultado = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button1Resultado = new System.Windows.Forms.Button();
            this.progressBarCarregar = new System.Windows.Forms.ProgressBar();
            this.panel1Resultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "INFORME O SEU SALÁRIO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "INFORME QUANTAS HORAS EXTRAS VOCÊ FEZ ESSE MÊS:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(19, 30);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(72, 20);
            this.txtSalario.TabIndex = 2;
            // 
            // txtHorasFeitas
            // 
            this.txtHorasFeitas.Location = new System.Drawing.Point(22, 79);
            this.txtHorasFeitas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHorasFeitas.Name = "txtHorasFeitas";
            this.txtHorasFeitas.Size = new System.Drawing.Size(69, 20);
            this.txtHorasFeitas.TabIndex = 3;
            // 
            // panel1Resultado
            // 
            this.panel1Resultado.BackColor = System.Drawing.Color.Silver;
            this.panel1Resultado.Controls.Add(this.lblResultado);
            this.panel1Resultado.Location = new System.Drawing.Point(125, 228);
            this.panel1Resultado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1Resultado.Name = "panel1Resultado";
            this.panel1Resultado.Size = new System.Drawing.Size(398, 37);
            this.panel1Resultado.TabIndex = 4;
            this.panel1Resultado.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(72, 15);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(41, 13);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "label3";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(484, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1Resultado
            // 
            this.button1Resultado.BackColor = System.Drawing.Color.Transparent;
            this.button1Resultado.BackgroundImage = global::iRh.Windows.Properties.Resources.calculator_icon_icons4;
            this.button1Resultado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1Resultado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1Resultado.Location = new System.Drawing.Point(256, 271);
            this.button1Resultado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1Resultado.Name = "button1Resultado";
            this.button1Resultado.Size = new System.Drawing.Size(88, 115);
            this.button1Resultado.TabIndex = 5;
            this.button1Resultado.Text = "CALCULAR";
            this.button1Resultado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1Resultado.UseVisualStyleBackColor = false;
            this.button1Resultado.Click += new System.EventHandler(this.button1Resultado_Click);
            // 
            // progressBarCarregar
            // 
            this.progressBarCarregar.Location = new System.Drawing.Point(200, 199);
            this.progressBarCarregar.Name = "progressBarCarregar";
            this.progressBarCarregar.Size = new System.Drawing.Size(187, 23);
            this.progressBarCarregar.TabIndex = 7;
            this.progressBarCarregar.Visible = false;
            // 
            // frmBeneficioHoraExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.Captura_de_tela_2023_06_17_1411105;
            this.ClientSize = new System.Drawing.Size(571, 387);
            this.Controls.Add(this.progressBarCarregar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button1Resultado);
            this.Controls.Add(this.panel1Resultado);
            this.Controls.Add(this.txtHorasFeitas);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmBeneficioHoraExtra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADICIONAL DE HORA EXTRA";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBarCarregar;
    }
}