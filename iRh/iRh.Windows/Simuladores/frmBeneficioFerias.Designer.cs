namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioFerias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficioFerias));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVendaFerias = new System.Windows.Forms.TextBox();
            this.panel1Resultado = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button1Resultado = new System.Windows.Forms.Button();
            this.progressBarCarregar = new System.Windows.Forms.ProgressBar();
            this.panel1Resultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "INFORME O SEU SALÁRIO";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(19, 29);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(69, 20);
            this.txtSalario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(474, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "QUANTOS DIAS VOCÊ VAI VENDER DE FÉRIAS? (LIMITE MÁXIMO DE 10 DIAS):";
            // 
            // txtVendaFerias
            // 
            this.txtVendaFerias.Location = new System.Drawing.Point(19, 84);
            this.txtVendaFerias.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtVendaFerias.Name = "txtVendaFerias";
            this.txtVendaFerias.Size = new System.Drawing.Size(69, 20);
            this.txtVendaFerias.TabIndex = 3;
            // 
            // panel1Resultado
            // 
            this.panel1Resultado.BackColor = System.Drawing.Color.Silver;
            this.panel1Resultado.Controls.Add(this.lblResultado);
            this.panel1Resultado.Location = new System.Drawing.Point(104, 222);
            this.panel1Resultado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1Resultado.Name = "panel1Resultado";
            this.panel1Resultado.Size = new System.Drawing.Size(346, 41);
            this.panel1Resultado.TabIndex = 4;
            this.panel1Resultado.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(76, 16);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(41, 13);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(479, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1Resultado
            // 
            this.button1Resultado.BackColor = System.Drawing.Color.Transparent;
            this.button1Resultado.BackgroundImage = global::iRh.Windows.Properties.Resources.calculator_icon_icons2;
            this.button1Resultado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1Resultado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Resultado.Location = new System.Drawing.Point(223, 263);
            this.button1Resultado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1Resultado.Name = "button1Resultado";
            this.button1Resultado.Size = new System.Drawing.Size(86, 121);
            this.button1Resultado.TabIndex = 5;
            this.button1Resultado.Text = "CALCULAR";
            this.button1Resultado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1Resultado.UseVisualStyleBackColor = false;
            this.button1Resultado.Click += new System.EventHandler(this.button1Resultado_Click);
            // 
            // progressBarCarregar
            // 
            this.progressBarCarregar.Location = new System.Drawing.Point(183, 186);
            this.progressBarCarregar.Name = "progressBarCarregar";
            this.progressBarCarregar.Size = new System.Drawing.Size(168, 23);
            this.progressBarCarregar.TabIndex = 7;
            // 
            // frmBeneficioFerias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.Captura_de_tela_2023_06_17_1411102;
            this.ClientSize = new System.Drawing.Size(563, 383);
            this.Controls.Add(this.progressBarCarregar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button1Resultado);
            this.Controls.Add(this.panel1Resultado);
            this.Controls.Add(this.txtVendaFerias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmBeneficioFerias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULO FÉRIAS";
            this.panel1Resultado.ResumeLayout(false);
            this.panel1Resultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVendaFerias;
        private System.Windows.Forms.Panel panel1Resultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button button1Resultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBarCarregar;
    }
}