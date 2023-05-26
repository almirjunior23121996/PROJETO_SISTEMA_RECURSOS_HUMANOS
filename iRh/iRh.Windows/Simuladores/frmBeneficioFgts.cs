using System;
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
            if(string.IsNullOrEmpty(txtValorEmConta.Text))
            {
                MessageBox.Show("Informe um salario.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValorEmConta.Focus();
                return;
            }else
            {
                try
                {
                    var salarioValorEmConta = double.Parse(txtValorEmConta.Text);
                    var contribuicaoFgts = Fgts.Calcula(salarioValorEmConta);
                    lblResultado.Text = contribuicaoFgts.ToString();
                    panelResultado.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Informe um salario válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                    
                }
            }
        }
    }
}
