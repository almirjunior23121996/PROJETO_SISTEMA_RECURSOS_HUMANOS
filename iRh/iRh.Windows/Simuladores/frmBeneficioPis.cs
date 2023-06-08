using System;
using System.Windows.Forms;
using iRh.Windows.Core;
namespace iRh.Windows.Simuladores
{
    public partial class frmBeneficioPis : Form
    {
        public frmBeneficioPis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSalario.Text))
                {
                    MessageBox.Show("Informe vezes solicitadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSalario.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtAnosDeCarteiraAssinada.Text))
                {
                    MessageBox.Show("Informe vezes Trabalhados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAnosDeCarteiraAssinada.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtMesesTrabalhando.Text))
                {
                    MessageBox.Show("Informe vezes Trabalhados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMesesTrabalhando.Focus();
                    return;
                }
                double Salario = double.Parse(txtSalario.Text);
                double MesesTrabalhando = double.Parse(txtMesesTrabalhando.Text);
                double AnosDeCarteiraAssinada = double.Parse(txtAnosDeCarteiraAssinada.Text);

                const double SalarioMinimo = 1230.00;
                double MediaSalario = (Salario * MesesTrabalhando) / MesesTrabalhando;
                double ValorReceber;
                if (AnosDeCarteiraAssinada < 5)
                {
                    lbl4Resultado.Text = "INFELIZ MENTE NÃO TEM DIREITO A RECEBER O AUXILIO!";
                    lbl5Resultado.Text = "SOMENTE PESSOAS COM NO MINIMO 5 ANOS DE CARTEIRA ASSINADA!";
                    panel1.Visible = true;
                }
                if (MediaSalario > SalarioMinimo) 
                {
                    lbl4Resultado.Text = "INFELIZ MENTE NÃO TEM DIREITO A RECEBER O AUXILIO!";
                    lbl5Resultado.Text = "SUA FAIXA SALARIAL ULTRAPASSOU O LIMITE PERMITIDO!";
                    panel1.Visible = true;
                }
                else 
                {
                    ValorReceber = (SalarioMinimo / MesesTrabalhando) * MesesTrabalhando;
                    lbl4Resultado.Text = "VOCÊ TEM DIREITO DE RECEBER!";
                    lbl5Resultado.Text = "O VALOR DE:" + ValorReceber.ToString("C");
                    panel1.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Campo obrigatorio","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
