namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioAdicionalNoturno
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
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblHorasNoturnas = new System.Windows.Forms.Label();
            this.txtSalarioTotal = new System.Windows.Forms.TextBox();
            this.txtHorasNoturnasFeitasNoMes = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(13, 13);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(141, 13);
            this.lblSalario.TabIndex = 0;
            this.lblSalario.Text = "INFORME O SEU SALÁRIO";
            // 
            // lblHorasNoturnas
            // 
            this.lblHorasNoturnas.AutoSize = true;
            this.lblHorasNoturnas.Location = new System.Drawing.Point(16, 116);
            this.lblHorasNoturnas.Name = "lblHorasNoturnas";
            this.lblHorasNoturnas.Size = new System.Drawing.Size(328, 13);
            this.lblHorasNoturnas.TabIndex = 1;
            this.lblHorasNoturnas.Text = "INFORME QUANTAS HORAS NOTURNAS VOCÊ FEZ ESSE MÊS";
            // 
            // txtSalarioTotal
            // 
            this.txtSalarioTotal.Location = new System.Drawing.Point(16, 43);
            this.txtSalarioTotal.Name = "txtSalarioTotal";
            this.txtSalarioTotal.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioTotal.TabIndex = 2;
            // 
            // txtHorasNoturnasFeitasNoMes
            // 
            this.txtHorasNoturnasFeitasNoMes.Location = new System.Drawing.Point(16, 169);
            this.txtHorasNoturnasFeitasNoMes.Name = "txtHorasNoturnasFeitasNoMes";
            this.txtHorasNoturnasFeitasNoMes.Size = new System.Drawing.Size(100, 20);
            this.txtHorasNoturnasFeitasNoMes.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(144, 226);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // panelResultado
            // 
            this.panelResultado.Controls.Add(this.lblResultado);
            this.panelResultado.Location = new System.Drawing.Point(19, 272);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(200, 100);
            this.panelResultado.TabIndex = 5;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(61, 44);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(35, 13);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "label3";
            // 
            // frmBeneficioAdicionalNoturno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtHorasNoturnasFeitasNoMes);
            this.Controls.Add(this.txtSalarioTotal);
            this.Controls.Add(this.lblHorasNoturnas);
            this.Controls.Add(this.lblSalario);
            this.Name = "frmBeneficioAdicionalNoturno";
            this.Text = "frmBeneficioAdicionalNoturno";
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblHorasNoturnas;
        private System.Windows.Forms.TextBox txtSalarioTotal;
        private System.Windows.Forms.TextBox txtHorasNoturnasFeitasNoMes;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label lblResultado;
    }
}