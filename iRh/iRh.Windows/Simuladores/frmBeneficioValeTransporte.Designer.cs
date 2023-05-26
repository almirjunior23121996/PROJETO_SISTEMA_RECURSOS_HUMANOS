namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioValeTransporte
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
            this.lblValorPassagem = new System.Windows.Forms.Label();
            this.lblPassagens = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtValorPassagem = new System.Windows.Forms.TextBox();
            this.txtPassagens = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(12, 9);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(141, 13);
            this.lblSalario.TabIndex = 0;
            this.lblSalario.Text = "INFORME O SEU SALÁRIO";
            // 
            // lblValorPassagem
            // 
            this.lblValorPassagem.AutoSize = true;
            this.lblValorPassagem.Location = new System.Drawing.Point(12, 80);
            this.lblValorPassagem.Name = "lblValorPassagem";
            this.lblValorPassagem.Size = new System.Drawing.Size(166, 13);
            this.lblValorPassagem.TabIndex = 1;
            this.lblValorPassagem.Text = "QUAL O VALOR DA PASSAGEM";
            // 
            // lblPassagens
            // 
            this.lblPassagens.AutoSize = true;
            this.lblPassagens.Location = new System.Drawing.Point(15, 164);
            this.lblPassagens.Name = "lblPassagens";
            this.lblPassagens.Size = new System.Drawing.Size(237, 13);
            this.lblPassagens.TabIndex = 2;
            this.lblPassagens.Text = "QUANTIDADE DE PASSAGEM GASTA NO DIA";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(15, 25);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 3;
            // 
            // txtValorPassagem
            // 
            this.txtValorPassagem.Location = new System.Drawing.Point(15, 119);
            this.txtValorPassagem.Name = "txtValorPassagem";
            this.txtValorPassagem.Size = new System.Drawing.Size(100, 20);
            this.txtValorPassagem.TabIndex = 4;
          
            // 
            // txtPassagens
            // 
            this.txtPassagens.Location = new System.Drawing.Point(18, 198);
            this.txtPassagens.Name = "txtPassagens";
            this.txtPassagens.Size = new System.Drawing.Size(100, 20);
            this.txtPassagens.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(125, 236);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
   
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblResultado);
            this.panel1.Location = new System.Drawing.Point(18, 299);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 7;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(75, 43);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(35, 13);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "label4";
            // 
            // frmBeneficioValeTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtPassagens);
            this.Controls.Add(this.txtValorPassagem);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblPassagens);
            this.Controls.Add(this.lblValorPassagem);
            this.Controls.Add(this.lblSalario);
            this.Name = "frmBeneficioValeTransporte";
            this.Text = "frmBeneficioValeTransporte";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblValorPassagem;
        private System.Windows.Forms.Label lblPassagens;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtValorPassagem;
        private System.Windows.Forms.TextBox txtPassagens;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblResultado;
    }
}