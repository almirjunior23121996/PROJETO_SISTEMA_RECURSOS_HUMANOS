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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficioValeTransporte));
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblValorPassagem = new System.Windows.Forms.Label();
            this.lblPassagens = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtValorPassagem = new System.Windows.Forms.TextBox();
            this.txtPassagens = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResultado2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.progressBarCarregar = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.BackColor = System.Drawing.Color.Transparent;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(14, 9);
            this.lblSalario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(166, 13);
            this.lblSalario.TabIndex = 0;
            this.lblSalario.Text = "INFORME O SEU SALÁRIO:";
            // 
            // lblValorPassagem
            // 
            this.lblValorPassagem.AutoSize = true;
            this.lblValorPassagem.BackColor = System.Drawing.Color.Transparent;
            this.lblValorPassagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPassagem.Location = new System.Drawing.Point(14, 63);
            this.lblValorPassagem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorPassagem.Name = "lblValorPassagem";
            this.lblValorPassagem.Size = new System.Drawing.Size(254, 13);
            this.lblValorPassagem.TabIndex = 1;
            this.lblValorPassagem.Text = "INFORME QUAL O VALOR DA PASSAGEM:";
            // 
            // lblPassagens
            // 
            this.lblPassagens.AutoSize = true;
            this.lblPassagens.BackColor = System.Drawing.Color.Transparent;
            this.lblPassagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassagens.Location = new System.Drawing.Point(10, 117);
            this.lblPassagens.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassagens.Name = "lblPassagens";
            this.lblPassagens.Size = new System.Drawing.Size(348, 13);
            this.lblPassagens.TabIndex = 2;
            this.lblPassagens.Text = "INFORME A QUANTIDADE DE PASSAGEM GASTA NO DIA:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(14, 25);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(76, 20);
            this.txtSalario.TabIndex = 3;
            // 
            // txtValorPassagem
            // 
            this.txtValorPassagem.Location = new System.Drawing.Point(14, 79);
            this.txtValorPassagem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtValorPassagem.Name = "txtValorPassagem";
            this.txtValorPassagem.Size = new System.Drawing.Size(76, 20);
            this.txtValorPassagem.TabIndex = 4;
            // 
            // txtPassagens
            // 
            this.txtPassagens.Location = new System.Drawing.Point(14, 133);
            this.txtPassagens.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPassagens.Name = "txtPassagens";
            this.txtPassagens.Size = new System.Drawing.Size(76, 20);
            this.txtPassagens.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lblResultado2);
            this.panel1.Controls.Add(this.lblResultado);
            this.panel1.Location = new System.Drawing.Point(168, 207);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 67);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            // 
            // lblResultado2
            // 
            this.lblResultado2.AutoSize = true;
            this.lblResultado2.Location = new System.Drawing.Point(34, 40);
            this.lblResultado2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado2.Name = "lblResultado2";
            this.lblResultado2.Size = new System.Drawing.Size(41, 13);
            this.lblResultado2.TabIndex = 1;
            this.lblResultado2.Text = "label1";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(34, 13);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(41, 13);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "label4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(528, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcular.BackgroundImage = global::iRh.Windows.Properties.Resources.calculator_icon_icons8;
            this.btnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Location = new System.Drawing.Point(270, 269);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(88, 113);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // progressBarCarregar
            // 
            this.progressBarCarregar.Location = new System.Drawing.Point(196, 178);
            this.progressBarCarregar.Name = "progressBarCarregar";
            this.progressBarCarregar.Size = new System.Drawing.Size(219, 23);
            this.progressBarCarregar.TabIndex = 9;
            this.progressBarCarregar.Visible = false;
            // 
            // frmBeneficioValeTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.Captura_de_tela_2023_06_17_1411109;
            this.ClientSize = new System.Drawing.Size(612, 383);
            this.Controls.Add(this.progressBarCarregar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtPassagens);
            this.Controls.Add(this.txtValorPassagem);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblPassagens);
            this.Controls.Add(this.lblValorPassagem);
            this.Controls.Add(this.lblSalario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmBeneficioValeTransporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BENEFICIO VALE  TRANSPORTE";
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
        private System.Windows.Forms.Label lblResultado2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBarCarregar;
    }
}