using System;
using System.Windows.Forms;

namespace iRh.Windows.Simuladores
{
    public partial class frmBeneficioValeTransporte : Form
    {
        public frmBeneficioValeTransporte()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSalario.Text))
                {
                    MessageBox.Show("Informe vezes solicitadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSalario.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtValorPassagem.Text))
                {
                    MessageBox.Show("Informe vezes Trabalhados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtValorPassagem.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtPassagens.Text))
                {
                    MessageBox.Show("Informe vezes Trabalhados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassagens.Focus();
                    return;
                }
                double salario = double.Parse(txtSalario.Text);
                double ValorDaPassagens = double.Parse(txtValorPassagem.Text);
                double Passagens = double.Parse(txtPassagens.Text);
                double DescontoValeTransporte = salario * 0.06;
                double GastoValeTransport = (ValorDaPassagens * Passagens) * 20;

                if (DescontoValeTransporte > GastoValeTransport)
                {
                    lblResultado.Text = "O VALOR DO DESCONTO SERÁ DE : R$" + DescontoValeTransporte;
                    lblResultado2.Text = "NÃO VALE A PENA VOCÊ UTILIZAR O BENEFICIO";
                    panel1.Visible = true;
                }
                if (GastoValeTransport > DescontoValeTransporte)
                {
                    lblResultado.Text = "O VALOR DO DESCONTO SERÁ DE : R$" + DescontoValeTransporte; 
                    lblResultado2.Text = "VALE A PENA UTILIZAR O BENEFÍCIO";
                    panel1.Visible = true;
                }


            }
            catch 
            {
                MessageBox.Show("Campo Obrigatorio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}
