using iRh.Windows.Core;
using System;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;

namespace iRh.Windows.Simuladores
{
    public partial class frmBeneficioPericulosidade : Form
    {
        public frmBeneficioPericulosidade()
        {
            InitializeComponent();
        }
        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            progressBarCarregar.Visible = true;
            progressBarCarregar.Value = 0;
            for (int i = 0; i <= progressBarCarregar.Maximum; i++)
            {
                progressBarCarregar.Value = i;
                Thread.Sleep(1);
            }
            progressBarCarregar.Visible = false;

            try 
            {
                if (string.IsNullOrEmpty(txtSalario.Text))
                {
                    MessageBox.Show("Informe um salario.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSalario.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtHorasPericulo0sidade2.Text))
                {
                    MessageBox.Show("Informe a Quantidade de Horas Feitas.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtHorasPericulo0sidade2.Focus();
                    return;
                }
                double salario = double.Parse(txtSalario.Text);
                double horasPericulosidade2 = double.Parse(txtHorasPericulo0sidade2.Text);
                var adicionalPericulosidade2 = Periculosidade.Calcula(salario, horasPericulosidade2);
                labelResultado.Text = "O VALOR DO SEU ADICIONAL SERÁ DE :R$" + adicionalPericulosidade2.ToString("F2");
                panelResultado.Visible = true;
                

            }
            catch(Exception)
            {
                MessageBox.Show("Preencha todos os campos Corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
