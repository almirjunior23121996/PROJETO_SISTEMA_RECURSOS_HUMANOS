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
            this.panelResultado = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCalcularFtgs = new System.Windows.Forms.Button();
            this.progressBarCarregar = new System.Windows.Forms.ProgressBar();
            this.panelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValorEmConta
            // 
            this.lblValorEmConta.AutoSize = true;
            this.lblValorEmConta.BackColor = System.Drawing.Color.Transparent;
            this.lblValorEmConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorEmConta.Location = new System.Drawing.Point(15, 13);
            this.lblValorEmConta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorEmConta.Name = "lblValorEmConta";
            this.lblValorEmConta.Size = new System.Drawing.Size(324, 13);
            this.lblValorEmConta.TabIndex = 0;
            this.lblValorEmConta.Text = "INFORME O VALOR TOTAL EM CONTA DO SEU FGTS:";
            // 
            // txtValorEmConta
            // 
            this.txtValorEmConta.Location = new System.Drawing.Point(19, 29);
            this.txtValorEmConta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtValorEmConta.Name = "txtValorEmConta";
            this.txtValorEmConta.Size = new System.Drawing.Size(64, 20);
            this.txtValorEmConta.TabIndex = 1;
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.Color.Silver;
            this.panelResultado.Controls.Add(this.lblResultado);
            this.panelResultado.Location = new System.Drawing.Point(118, 217);
            this.panelResultado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(371, 48);
            this.panelResultado.TabIndex = 3;
            this.panelResultado.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(4, 12);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(41, 13);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCalcularFtgs
            // 
            this.btnCalcularFtgs.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcularFtgs.BackgroundImage = global::iRh.Windows.Properties.Resources.calculator_icon_icons3;
            this.btnCalcularFtgs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCalcularFtgs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcularFtgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularFtgs.Location = new System.Drawing.Point(253, 271);
            this.btnCalcularFtgs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCalcularFtgs.Name = "btnCalcularFtgs";
            this.btnCalcularFtgs.Size = new System.Drawing.Size(86, 111);
            this.btnCalcularFtgs.TabIndex = 2;
            this.btnCalcularFtgs.Text = "CALCULAR";
            this.btnCalcularFtgs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCalcularFtgs.UseVisualStyleBackColor = false;
            this.btnCalcularFtgs.Click += new System.EventHandler(this.btnCalcularFtgs_Click);
            // 
            // progressBarCarregar
            // 
            this.progressBarCarregar.Location = new System.Drawing.Point(204, 174);
            this.progressBarCarregar.Name = "progressBarCarregar";
            this.progressBarCarregar.Size = new System.Drawing.Size(177, 23);
            this.progressBarCarregar.TabIndex = 5;
            this.progressBarCarregar.Visible = false;
            // 
            // frmBeneficioFgts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.Captura_de_tela_2023_06_17_1411103;
            this.ClientSize = new System.Drawing.Size(581, 386);
            this.Controls.Add(this.progressBarCarregar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.btnCalcularFtgs);
            this.Controls.Add(this.txtValorEmConta);
            this.Controls.Add(this.lblValorEmConta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmBeneficioFgts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MULTA FGTS";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBarCarregar;
    }
}