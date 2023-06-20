using iRh.Windows.Core;
using System;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            {
                progressBar1.Visible = true;
                progressBar1.Value = 0;
                for (int i = 0; i <= progressBar1.Maximum; i++)
                {
                    progressBar1.Value = i;
                    Thread.Sleep(1);
                }
                progressBar1.Visible = false;
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
                    double horasPericulosidade = double.Parse(txtHorasPericulosidade.Text);
                    horasExtras = HoraExtra.Calcula(salario, horasExtras);
                    var valorAdicionalNoturno = AdicionalNoturno.Calcula(salario, horasNoturnas);
                    horasPericulosidade = Periculosidade.Calcula(salario, horasPericulosidade);
                    if (radioButtonSim.Checked)
                    {
                        descontoValeTransporte = ValeTransporte.Calcula(salario);
                    }
                    var descontoInss = Inss.Calcula(salario);
                    var calculoIrrf = salario + horasExtras + valorAdicionalNoturno;
                    var inpostoIrrf = Irrf.Calcula(calculoIrrf);
                    var descontoFgts = Fgts.Calcula(salario);
                    var adicionais = horasExtras + valorAdicionalNoturno + horasPericulosidade;
                    var descontos = descontoInss + descontoFgts + inpostoIrrf + descontoValeTransporte;
                    var valorLiquido = salario + adicionais;

                    lblResultado.Text = "-DETALHAMENTO-" + "\n" + "\n" +

                    "SALÁRIO BASE: R$ R$" + salario.ToString("F2") + "\n" + "\n" +

                    "HORAS EXTRAS: + R$" + horasExtras.ToString("F2") + "\n" + "\n" +

                    "ADICIONAL NOTURNO: + R$" + valorAdicionalNoturno.ToString("F2") + "\n" + "\n" +

                    "ADICIONAL PERICULOSIDADE : + R$" + horasPericulosidade.ToString("F2") + "\n" + "\n" +

                    "VALE-TRANSPORTE: - R$ " + descontoValeTransporte.ToString("F2") + "\n" + "\n" +

                    "DESCONTO INSS : - R$" + descontoInss.ToString("F2") + "\n" + "\n" +

                    "DESCONTO IRRF: - R$" + inpostoIrrf.ToString("F2") + "\n" + "\n" +

                    "DESCONTO FGTS: - R$" + descontoFgts.ToString("F2") + "\n" + "\n" + "\n" + "\n" +
                    "-----------------------------------------------------------------------" +"\n"+

                                                   "-RESULTADO-" + "\n" + "\n" +

                    "TOTAL ADICIONAIS : + R$" + adicionais.ToString("F2") + "\n" + "\n" +

                    "TOTAL DESCONTOS : - R$" + descontos.ToString("F2") + "\n" + "\n" + "\n" +
                    "-----------------------------------------------------------------------" + "\n" +
                    "SALÁRIO LIQUIDO: R$" + valorLiquido.ToString("F2");

                    panelResultado.Visible = true;

                }
                catch (Exception)
                {
                    MessageBox.Show("Preencha todos os campos Corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}
