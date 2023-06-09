﻿using iRh.Windows.Core;
using System;
using System.Windows.Forms;

namespace iRh.Windows.Simuladores
{
    public partial class lblSalarioBase : Form
    {
        public lblSalarioBase()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalarioBase.Text))
            {
                MessageBox.Show("Informe seu salário base.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtSalarioBase.Focus();
                return;
            }
            try
            {
                var salario = double.Parse(txtSalarioBase.Text);
                var descontonss = Inss.Calcula(salario);
                lblResultado.Text = "O VALOR DO SEU DESCONTO FOI DE : R$" + descontonss.ToString("F2");
                panelResultado.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Preencha todos os campos necessarios;", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
