using System;
using System.Threading;
using System.Windows.Forms;
using iRh.Windows.Core;


namespace iRh.Windows.Simuladores
{
    public partial class frmBeneficioFgts : Form
    {
        public frmBeneficioFgts()
        {
            InitializeComponent();
        }
        private void btnCalcularFtgs_Click(object sender, EventArgs e)
        {
            progressBarCarregar.Visible = true;
            progressBarCarregar.Value = 0;
            for (int i = 0; i <= progressBarCarregar.Maximum; i++)
            {
                progressBarCarregar.Value = i;
                Thread.Sleep(1);
            }
            progressBarCarregar.Visible = false;
            if (string.IsNullOrEmpty(txtValorEmConta.Text))
            {
                MessageBox.Show("Informe um valor.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValorEmConta.Focus();
                return;
            }else
            {
                try
                {
                    var salarioValorEmConta = double.Parse(txtValorEmConta.Text);
                    var contribuicaoFgts = Fgts.Calcula(salarioValorEmConta);
                    lblResultado.Text = "O VALOR TOTAL DE MULTA QUE VOÊ IRA RECEBER DO \n SEU EMPREGO ATUAL SERÁ DE: R$" + contribuicaoFgts.ToString("F2");
                    panelResultado.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Preecha todos os campos Corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
