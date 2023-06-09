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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficioPis));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnosDeCarteiraAssinada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMesesTrabalhando = new System.Windows.Forms.TextBox();
            this.buttonResultado = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl5Resultado = new System.Windows.Forms.Label();
            this.lbl4Resultado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "INFORME O SEU SALÁRIO:";
            // 
            // txtSalario
            // 
            this.txtSalario.BackColor = System.Drawing.SystemColors.Window;
            this.txtSalario.Location = new System.Drawing.Point(19, 29);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(65, 20);
            this.txtSalario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "QUANTOS ANOS VOCÊ TEM DE CARTEIRA ASSINADA?";
            // 
            // txtAnosDeCarteiraAssinada
            // 
            this.txtAnosDeCarteiraAssinada.Location = new System.Drawing.Point(22, 87);
            this.txtAnosDeCarteiraAssinada.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAnosDeCarteiraAssinada.Name = "txtAnosDeCarteiraAssinada";
            this.txtAnosDeCarteiraAssinada.Size = new System.Drawing.Size(61, 20);
            this.txtAnosDeCarteiraAssinada.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(546, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "QUANTOS MESES VOCÊ ESTÁ TRABALHANDO DE CARTEIRA ASSINADA NO ANO ATUAL ? ";
            // 
            // txtMesesTrabalhando
            // 
            this.txtMesesTrabalhando.Location = new System.Drawing.Point(26, 142);
            this.txtMesesTrabalhando.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMesesTrabalhando.Name = "txtMesesTrabalhando";
            this.txtMesesTrabalhando.Size = new System.Drawing.Size(58, 20);
            this.txtMesesTrabalhando.TabIndex = 5;
            // 
            // buttonResultado
            // 
            this.buttonResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResultado.Location = new System.Drawing.Point(462, 251);
            this.buttonResultado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonResultado.Name = "buttonResultado";
            this.buttonResultado.Size = new System.Drawing.Size(88, 23);
            this.buttonResultado.TabIndex = 6;
            this.buttonResultado.Text = "CALCULAR PIS";
            this.buttonResultado.UseVisualStyleBackColor = true;
            this.buttonResultado.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lbl5Resultado);
            this.panel1.Controls.Add(this.lbl4Resultado);
            this.panel1.Location = new System.Drawing.Point(22, 194);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 50);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            // 
            // lbl5Resultado
            // 
            this.lbl5Resultado.AutoSize = true;
            this.lbl5Resultado.Location = new System.Drawing.Point(24, 29);
            this.lbl5Resultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl5Resultado.Name = "lbl5Resultado";
            this.lbl5Resultado.Size = new System.Drawing.Size(41, 13);
            this.lbl5Resultado.TabIndex = 1;
            this.lbl5Resultado.Text = "label5";
            // 
            // lbl4Resultado
            // 
            this.lbl4Resultado.AutoSize = true;
            this.lbl4Resultado.Location = new System.Drawing.Point(24, 16);
            this.lbl4Resultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl4Resultado.Name = "lbl4Resultado";
            this.lbl4Resultado.Size = new System.Drawing.Size(41, 13);
            this.lbl4Resultado.TabIndex = 0;
            this.lbl4Resultado.Text = "label4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmBeneficioPis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 277);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonResultado);
            this.Controls.Add(this.txtMesesTrabalhando);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAnosDeCarteiraAssinada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmBeneficioPis";
            this.Text = " PIS";
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
        private System.Windows.Forms.Button button1;
    }
}