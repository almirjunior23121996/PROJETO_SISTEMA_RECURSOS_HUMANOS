﻿using System;
using System.Windows.Forms;
using iRh.Windows.Core;


namespace iRh.Windows.Simuladores
{

    public partial class frmBeneficioHoraExtra : Form
    {
        public frmBeneficioHoraExtra()
        {
            InitializeComponent();
        }

        private void button1Resultado_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSalario.Text))
                {
                    MessageBox.Show("Informe um salario.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSalario.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtHorasFeitas.Text))
                {
                    MessageBox.Show("Informe um salario.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtHorasFeitas.Focus();
                    return;
                }

                var salario = double.Parse(txtSalario.Text);
                var horasFeitas = double.Parse(txtHorasFeitas.Text);
                var total = HoraExtra.Calcula(salario, horasFeitas);

                lblResultado.Text = "O VALOR DO ADICIONAL SERÁ DE:R$" + total.ToString("F2");
                panel1Resultado.Visible = true;
            }
            catch
            {

            }
        }
    }
}