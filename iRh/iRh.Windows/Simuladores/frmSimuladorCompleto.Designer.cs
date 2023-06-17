namespace iRh.Windows.Simuladores
{
    partial class frmSimuladorCompleto
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
            this.txtSalarioBruto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHorasExtras = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHorasNoturnas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHorasPericulosidade = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValeTransporte = new System.Windows.Forms.TextBox();
            this.panelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "INFORME SEU SALÁRIO BRUTO:";
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.Location = new System.Drawing.Point(16, 29);
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioBruto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "QUANTAS HORAS EXTRAS FEZ ESSE MÊS :";
            // 
            // txtHorasExtras
            // 
            this.txtHorasExtras.Location = new System.Drawing.Point(16, 112);
            this.txtHorasExtras.Name = "txtHorasExtras";
            this.txtHorasExtras.Size = new System.Drawing.Size(100, 20);
            this.txtHorasExtras.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "QUANTAS HORAS NOTURNAS FEZ ESSE MÊS:";
            // 
            // txtHorasNoturnas
            // 
            this.txtHorasNoturnas.Location = new System.Drawing.Point(19, 188);
            this.txtHorasNoturnas.Name = "txtHorasNoturnas";
            this.txtHorasNoturnas.Size = new System.Drawing.Size(100, 20);
            this.txtHorasNoturnas.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(331, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "QUANTAS HORAS VOCÊ FEZ EM PERICULOSIDADE ESSE MÊS:";
            // 
            // txtHorasPericulosidade
            // 
            this.txtHorasPericulosidade.Location = new System.Drawing.Point(19, 264);
            this.txtHorasPericulosidade.Name = "txtHorasPericulosidade";
            this.txtHorasPericulosidade.Size = new System.Drawing.Size(100, 20);
            this.txtHorasPericulosidade.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(713, 415);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // panelResultado
            // 
            this.panelResultado.Controls.Add(this.lblResultado);
            this.panelResultado.Location = new System.Drawing.Point(279, 306);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(200, 100);
            this.panelResultado.TabIndex = 9;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(82, 46);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(73, 13);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.Text = "RESULTADO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "VOCÊ RECEBE VALE-TRANSPORTE?";
            // 
            // txtValeTransporte
            // 
            this.txtValeTransporte.Location = new System.Drawing.Point(19, 335);
            this.txtValeTransporte.Name = "txtValeTransporte";
            this.txtValeTransporte.Size = new System.Drawing.Size(100, 20);
            this.txtValeTransporte.TabIndex = 11;
            // 
            // frmSimuladorCompleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtValeTransporte);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtHorasPericulosidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHorasNoturnas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHorasExtras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSalarioBruto);
            this.Controls.Add(this.label1);
            this.Name = "frmSimuladorCompleto";
            this.Text = "frmSimuladorCompleto";
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalarioBruto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHorasExtras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHorasNoturnas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHorasPericulosidade;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValeTransporte;
    }
}