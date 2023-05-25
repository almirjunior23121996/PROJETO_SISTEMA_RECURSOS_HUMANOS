namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioFgts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficioFgts));
            this.lblValorEmConta = new System.Windows.Forms.Label();
            this.txtValorEmConta = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValorEmConta
            // 
            this.lblValorEmConta.AutoSize = true;
            this.lblValorEmConta.Location = new System.Drawing.Point(13, 13);
            this.lblValorEmConta.Name = "lblValorEmConta";
            this.lblValorEmConta.Size = new System.Drawing.Size(253, 13);
            this.lblValorEmConta.TabIndex = 0;
            this.lblValorEmConta.Text = "INFORME O VALOR TOTAL EM CONTA DO FGTS";
            // 
            // txtValorEmConta
            // 
            this.txtValorEmConta.Location = new System.Drawing.Point(16, 50);
            this.txtValorEmConta.Name = "txtValorEmConta";
            this.txtValorEmConta.Size = new System.Drawing.Size(100, 20);
            this.txtValorEmConta.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(16, 119);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.lblResultado);
            this.panel1.Location = new System.Drawing.Point(16, 177);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 3;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(64, 42);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(35, 13);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "label1";
            // 
            // frmBeneficioFgts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValorEmConta);
            this.Controls.Add(this.lblValorEmConta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBeneficioFgts";
            this.Text = "frmBeneficioFgts";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorEmConta;
        private System.Windows.Forms.TextBox txtValorEmConta;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblResultado;
    }
}