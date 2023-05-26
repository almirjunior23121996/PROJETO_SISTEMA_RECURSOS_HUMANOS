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
            this.btnCalcularFtgs = new System.Windows.Forms.Button();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panelResultado.SuspendLayout();
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
            // btnCalcularFtgs
            // 
            this.btnCalcularFtgs.Location = new System.Drawing.Point(17, 95);
            this.btnCalcularFtgs.Name = "btnCalcularFtgs";
            this.btnCalcularFtgs.Size = new System.Drawing.Size(99, 23);
            this.btnCalcularFtgs.TabIndex = 2;
            this.btnCalcularFtgs.Text = "CALCULAR FGTS";
            this.btnCalcularFtgs.UseVisualStyleBackColor = true;
            this.btnCalcularFtgs.Click += new System.EventHandler(this.btnCalcularFtgs_Click);
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelResultado.Controls.Add(this.lblResultado);
            this.panelResultado.Location = new System.Drawing.Point(17, 124);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(200, 100);
            this.panelResultado.TabIndex = 3;
            this.panelResultado.Visible = false;
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
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.btnCalcularFtgs);
            this.Controls.Add(this.txtValorEmConta);
            this.Controls.Add(this.lblValorEmConta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBeneficioFgts";
            this.Text = "frmBeneficioFgts";
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorEmConta;
        private System.Windows.Forms.TextBox txtValorEmConta;
        private System.Windows.Forms.Button btnCalcularFtgs;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label lblResultado;
    }
}