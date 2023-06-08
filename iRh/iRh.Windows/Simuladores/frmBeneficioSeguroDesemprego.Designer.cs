namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioSeguroDesemprego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficioSeguroDesemprego));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVezesSolicitados = new System.Windows.Forms.TextBox();
            this.txtMesesTrabalhados = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.buttonResultado = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "INFORME QUANTAS VEZES JÁ SOLICITOU O BENEFICIO?:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = " INFORME MESES DE CARTEIRA ASSINADA NO EMPREGO ATUAL:";
            // 
            // txtVezesSolicitados
            // 
            this.txtVezesSolicitados.Location = new System.Drawing.Point(16, 29);
            this.txtVezesSolicitados.Name = "txtVezesSolicitados";
            this.txtVezesSolicitados.Size = new System.Drawing.Size(45, 20);
            this.txtVezesSolicitados.TabIndex = 2;
            // 
            // txtMesesTrabalhados
            // 
            this.txtMesesTrabalhados.Location = new System.Drawing.Point(16, 78);
            this.txtMesesTrabalhados.Name = "txtMesesTrabalhados";
            this.txtMesesTrabalhados.Size = new System.Drawing.Size(45, 20);
            this.txtMesesTrabalhados.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblResultado);
            this.panel1.Location = new System.Drawing.Point(16, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 93);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(32, 40);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(41, 13);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "label3";
            // 
            // buttonResultado
            // 
            this.buttonResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResultado.Location = new System.Drawing.Point(339, 203);
            this.buttonResultado.Name = "buttonResultado";
            this.buttonResultado.Size = new System.Drawing.Size(75, 23);
            this.buttonResultado.TabIndex = 5;
            this.buttonResultado.Text = "Simular";
            this.buttonResultado.UseVisualStyleBackColor = true;
            this.buttonResultado.Click += new System.EventHandler(this.buttonResultado_Click);
            // 
            // frmBeneficioSeguroDesemprego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 230);
            this.Controls.Add(this.buttonResultado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtMesesTrabalhados);
            this.Controls.Add(this.txtVezesSolicitados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBeneficioSeguroDesemprego";
            this.Text = "frmBeneficioSeguroDesemprego";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVezesSolicitados;
        private System.Windows.Forms.TextBox txtMesesTrabalhados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button buttonResultado;
    }
}