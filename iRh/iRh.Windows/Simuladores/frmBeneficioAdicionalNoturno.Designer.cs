namespace iRh.Windows.Simuladores
{
    partial class BeneficioAdicionalNoturno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BeneficioAdicionalNoturno));
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
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(15, 13);
            this.lblSalario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(166, 13);
            this.lblSalario.TabIndex = 0;
            this.lblSalario.Text = "INFORME O SEU SALÁRIO:";
            // 
            // lblHorasNoturnas
            // 
            this.lblHorasNoturnas.AutoSize = true;
            this.lblHorasNoturnas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasNoturnas.Location = new System.Drawing.Point(15, 82);
            this.lblHorasNoturnas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHorasNoturnas.Name = "lblHorasNoturnas";
            this.lblHorasNoturnas.Size = new System.Drawing.Size(380, 13);
            this.lblHorasNoturnas.TabIndex = 1;
            this.lblHorasNoturnas.Text = "INFORME QUANTAS HORAS NOTURNAS VOCÊ FEZ ESSE MÊS:";
            // 
            // txtSalarioTotal
            // 
            this.txtSalarioTotal.Location = new System.Drawing.Point(19, 29);
            this.txtSalarioTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSalarioTotal.Name = "txtSalarioTotal";
            this.txtSalarioTotal.Size = new System.Drawing.Size(69, 20);
            this.txtSalarioTotal.TabIndex = 2;
            // 
            // txtHorasNoturnasFeitasNoMes
            // 
            this.txtHorasNoturnasFeitasNoMes.Location = new System.Drawing.Point(19, 109);
            this.txtHorasNoturnasFeitasNoMes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHorasNoturnasFeitasNoMes.Name = "txtHorasNoturnasFeitasNoMes";
            this.txtHorasNoturnasFeitasNoMes.Size = new System.Drawing.Size(69, 20);
            this.txtHorasNoturnasFeitasNoMes.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(288, 233);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(88, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.Color.Silver;
            this.panelResultado.Controls.Add(this.lblResultado);
            this.panelResultado.Location = new System.Drawing.Point(19, 175);
            this.panelResultado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(357, 52);
            this.panelResultado.TabIndex = 5;
            this.panelResultado.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(44, 22);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(41, 13);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "label3";
            // 
            // BeneficioAdicionalNoturno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 256);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtHorasNoturnasFeitasNoMes);
            this.Controls.Add(this.txtSalarioTotal);
            this.Controls.Add(this.lblHorasNoturnas);
            this.Controls.Add(this.lblSalario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "BeneficioAdicionalNoturno";
            this.Text = " ADICIONAL NOTURNO";
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