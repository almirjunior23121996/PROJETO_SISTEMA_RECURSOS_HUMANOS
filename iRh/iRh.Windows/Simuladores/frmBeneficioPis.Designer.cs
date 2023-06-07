namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioPis
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
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnosDeCarteiraAssinada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMesesTrabalhando = new System.Windows.Forms.TextBox();
            this.buttonResultado = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl4Resultado = new System.Windows.Forms.Label();
            this.lbl5Resultado = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
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
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(16, 29);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(56, 20);
            this.txtSalario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ANOS DE CARTEIRA ASSINADA";
            // 
            // txtAnosDeCarteiraAssinada
            // 
            this.txtAnosDeCarteiraAssinada.Location = new System.Drawing.Point(19, 87);
            this.txtAnosDeCarteiraAssinada.Name = "txtAnosDeCarteiraAssinada";
            this.txtAnosDeCarteiraAssinada.Size = new System.Drawing.Size(53, 20);
            this.txtAnosDeCarteiraAssinada.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "MESES TRABALHADOS DE CARTEIRA ASSINADA";
            // 
            // txtMesesTrabalhando
            // 
            this.txtMesesTrabalhando.Location = new System.Drawing.Point(22, 142);
            this.txtMesesTrabalhando.Name = "txtMesesTrabalhando";
            this.txtMesesTrabalhando.Size = new System.Drawing.Size(50, 20);
            this.txtMesesTrabalhando.TabIndex = 5;
            // 
            // buttonResultado
            // 
            this.buttonResultado.Location = new System.Drawing.Point(298, 245);
            this.buttonResultado.Name = "buttonResultado";
            this.buttonResultado.Size = new System.Drawing.Size(75, 23);
            this.buttonResultado.TabIndex = 6;
            this.buttonResultado.Text = "CALCULAR";
            this.buttonResultado.UseVisualStyleBackColor = true;
            this.buttonResultado.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl5Resultado);
            this.panel1.Controls.Add(this.lbl4Resultado);
            this.panel1.Location = new System.Drawing.Point(16, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 100);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            // 
            // lbl4Resultado
            // 
            this.lbl4Resultado.AutoSize = true;
            this.lbl4Resultado.Location = new System.Drawing.Point(21, 31);
            this.lbl4Resultado.Name = "lbl4Resultado";
            this.lbl4Resultado.Size = new System.Drawing.Size(35, 13);
            this.lbl4Resultado.TabIndex = 0;
            this.lbl4Resultado.Text = "label4";
            // 
            // lbl5Resultado
            // 
            this.lbl5Resultado.AutoSize = true;
            this.lbl5Resultado.Location = new System.Drawing.Point(21, 61);
            this.lbl5Resultado.Name = "lbl5Resultado";
            this.lbl5Resultado.Size = new System.Drawing.Size(35, 13);
            this.lbl5Resultado.TabIndex = 1;
            this.lbl5Resultado.Text = "label5";
            // 
            // frmBeneficioPis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 270);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonResultado);
            this.Controls.Add(this.txtMesesTrabalhando);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAnosDeCarteiraAssinada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label1);
            this.Name = "frmBeneficioPis";
            this.Text = "frmBeneficioPis";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnosDeCarteiraAssinada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMesesTrabalhando;
        private System.Windows.Forms.Button buttonResultado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl4Resultado;
        private System.Windows.Forms.Label lbl5Resultado;
    }
}