namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioHoraExtra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficioHoraExtra));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtHorasFeitas = new System.Windows.Forms.TextBox();
            this.panel1Resultado = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.button1Resultado = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1Resultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "INFORME O SEU SALÁRIO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "INFORME QUANTAS HORAS EXTRAS VOCÊ FEZ ESSE MÊS:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(19, 30);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(72, 20);
            this.txtSalario.TabIndex = 2;
            // 
            // txtHorasFeitas
            // 
            this.txtHorasFeitas.Location = new System.Drawing.Point(22, 79);
            this.txtHorasFeitas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHorasFeitas.Name = "txtHorasFeitas";
            this.txtHorasFeitas.Size = new System.Drawing.Size(69, 20);
            this.txtHorasFeitas.TabIndex = 3;
            // 
            // panel1Resultado
            // 
            this.panel1Resultado.BackColor = System.Drawing.Color.Silver;
            this.panel1Resultado.Controls.Add(this.lblResultado);
            this.panel1Resultado.Location = new System.Drawing.Point(13, 162);
            this.panel1Resultado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1Resultado.Name = "panel1Resultado";
            this.panel1Resultado.Size = new System.Drawing.Size(398, 37);
            this.panel1Resultado.TabIndex = 4;
            this.panel1Resultado.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(72, 15);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(41, 13);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "label3";
            // 
            // button1Resultado
            // 
            this.button1Resultado.Location = new System.Drawing.Point(323, 205);
            this.button1Resultado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1Resultado.Name = "button1Resultado";
            this.button1Resultado.Size = new System.Drawing.Size(88, 23);
            this.button1Resultado.TabIndex = 5;
            this.button1Resultado.Text = "CALCULAR";
            this.button1Resultado.UseVisualStyleBackColor = true;
            this.button1Resultado.Click += new System.EventHandler(this.button1Resultado_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::iRh.Windows.Properties.Resources.Captura_de_tela_2023_06_08_1757153;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(411, 228);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmBeneficioHoraExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 230);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button1Resultado);
            this.Controls.Add(this.panel1Resultado);
            this.Controls.Add(this.txtHorasFeitas);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmBeneficioHoraExtra";
            this.Text = "ADICIONAL DE HORA EXTRA";
            this.panel1Resultado.ResumeLayout(false);
            this.panel1Resultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtHorasFeitas;
        private System.Windows.Forms.Panel panel1Resultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button button1Resultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}