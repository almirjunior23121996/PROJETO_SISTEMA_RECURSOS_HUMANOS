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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblValorEmConta
            // 
            this.lblValorEmConta.AutoSize = true;
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
            // btnCalcularFtgs
            // 
            this.btnCalcularFtgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularFtgs.Location = new System.Drawing.Point(261, 201);
            this.btnCalcularFtgs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCalcularFtgs.Name = "btnCalcularFtgs";
            this.btnCalcularFtgs.Size = new System.Drawing.Size(115, 23);
            this.btnCalcularFtgs.TabIndex = 2;
            this.btnCalcularFtgs.Text = "CALCULAR FGTS";
            this.btnCalcularFtgs.UseVisualStyleBackColor = true;
            this.btnCalcularFtgs.Click += new System.EventHandler(this.btnCalcularFtgs_Click);
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.Color.Silver;
            this.panelResultado.Controls.Add(this.lblResultado);
            this.panelResultado.Location = new System.Drawing.Point(5, 151);
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
            this.button1.Location = new System.Drawing.Point(179, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::iRh.Windows.Properties.Resources.Captura_de_tela_2023_06_08_1757152;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 224);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmBeneficioFgts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 225);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.btnCalcularFtgs);
            this.Controls.Add(this.txtValorEmConta);
            this.Controls.Add(this.lblValorEmConta);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmBeneficioFgts";
            this.Text = "MULTA FGTS";
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}