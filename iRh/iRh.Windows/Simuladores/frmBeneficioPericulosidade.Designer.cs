namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioPericulosidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficioPericulosidade));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtHorasPericulo0sidade2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.labelResultado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.panelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "INFORME O SEU SALÁRIO:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(19, 39);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(69, 20);
            this.txtSalario.TabIndex = 1;
            // 
            // txtHorasPericulo0sidade2
            // 
            this.txtHorasPericulo0sidade2.Location = new System.Drawing.Point(19, 99);
            this.txtHorasPericulo0sidade2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHorasPericulo0sidade2.Name = "txtHorasPericulo0sidade2";
            this.txtHorasPericulo0sidade2.Size = new System.Drawing.Size(69, 20);
            this.txtHorasPericulo0sidade2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(15, 83);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(375, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "INFORME QUANTAS HORAS VOCÊ FEZ EM PERICULOSIDADE:";
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.Color.Silver;
            this.panelResultado.Controls.Add(this.labelResultado);
            this.panelResultado.Location = new System.Drawing.Point(115, 196);
            this.panelResultado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(363, 56);
            this.panelResultado.TabIndex = 8;
            this.panelResultado.Visible = false;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(35, 21);
            this.labelResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(82, 13);
            this.labelResultado.TabIndex = 0;
            this.labelResultado.Text = "RESULTADO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(509, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.BackColor = System.Drawing.Color.Transparent;
            this.buttonCalcular.BackgroundImage = global::iRh.Windows.Properties.Resources.calculator_icon_icons5;
            this.buttonCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCalcular.Location = new System.Drawing.Point(237, 258);
            this.buttonCalcular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(95, 118);
            this.buttonCalcular.TabIndex = 5;
            this.buttonCalcular.Text = "CALCULAR";
            this.buttonCalcular.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCalcular.UseVisualStyleBackColor = false;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // frmBeneficioPericulosidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.Captura_de_tela_2023_06_17_1411106;
            this.ClientSize = new System.Drawing.Size(597, 375);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtHorasPericulo0sidade2);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmBeneficioPericulosidade";
            this.Text = "ADICIONAL PERICULOSIDADE ";
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.TextBox txtHorasPericulo0sidade2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Button button1;
    }
}