using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iRh.Windows.Core;

namespace iRh.Windows.Simuladores
{
    public partial class frmContraCheck : Form
    {
        public frmContraCheck()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSalario.Text))
                {
                    MessageBox.Show("Informe seu salario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSalario.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtHorasExtras.Text))
                {
                    MessageBox.Show("Informe quntas horas extras foram feitas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtHorasExtras.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtHorasNoturnas.Text))
                {
                    MessageBox.Show("Informe quantas horas nuturnas foram feitas. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtHorasNoturnas.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtHorasPericulosidade.Text))
                {
                    MessageBox.Show("Informe quantas horas em periculosidade foram feitas. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtHorasPericulosidade.Focus();
                    return;
                }
                var descontoValeTransporte = 0.0;
                double salario = double.Parse(txtSalario.Text);
                double horasExtras = double.Parse(txtHorasExtras.Text);
                double horasNoturnas = double.Parse(txtHorasNoturnas.Text);
                double horasPericulosidade= double.Parse(txtHorasPericulosidade.Text);
                horasExtras = HoraExtra.Calcula(salario, horasExtras);
                var valorAdicionalNoturno = AdicionalNoturno.Calcula(salario, horasExtras);
                horasPericulosidade = Periculosidade.Calcula(salario, horasPericulosidade);
                if (radioButtonSim.Checked) 
                {
                    descontoValeTransporte = ValeTransporte.Calcula(salario);
                }

                var descontoInss = Inss.Calcula( salario);
                var calculoIrrf = salario + horasExtras + valorAdicionalNoturno;
                var inpostoIrrf = Irrf.Calcula(calculoIrrf);
                var descontoFgts = Fgts.Calcula(salario);
                var adicionais = horasExtras + valorAdicionalNoturno + horasPericulosidade;
                var descontos = descontoInss + descontoFgts + inpostoIrrf + descontoValeTransporte;

                label6.Text = "SALÁRIO BASE: R$ R$" + salario.ToString("F2");
                panel1.Show();

                label7.Text = "HORAS EXTRAS: + R$" + horasExtras.ToString("F2");
                panel2.Show();

                label8.Text = "ADICIONAL NOTURNO: + R$" + valorAdicionalNoturno.ToString("F2");
                panel3.Show();

                label9.Text = "ADICIONAL PERICULOSIDADE : + R$" + horasPericulosidade.ToString("F2");
                panel4.Show();

                label10.Text = "VALE-TRANSPORTE: R$ -" + descontoValeTransporte.ToString("F2");
                panel5.Show();

                label11.Text = "DESCONTO INSS : - R$" + descontoInss.ToString("F2");
                panel6.Show();

                label12.Text = "DESCONTO IRRF: - R$" + inpostoIrrf.ToString("F2");
                panel7.Show();

                label13.Text = "DESCONTO FGTS: - R$" + descontoFgts.ToString("F2");
                panel8.Show();

                label14.Text = "TOTAL ADICIONAIS + : R$" + adicionais.ToString("F2");
                panel9.Show();

                label15.Text = "TOTAL ADICIONAIS + : R$" + adicionais.ToString("F2");
                panel10.Show();


            }
            catch (Exception)
            {

               
            }
        }

    }
}
