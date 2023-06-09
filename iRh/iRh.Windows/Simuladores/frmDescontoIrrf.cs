using System;
using System.Windows.Forms;
using iRh.Windows.Core;
namespace iRh.Windows.Simuladores
{
    public partial class frmDescontoIrrf : Form
    {
        public frmDescontoIrrf()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("Informe um salario.", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtSalario.Focus();
                return;
            }
            else
            {
                try
                {
                    var SalarioaReceber = double.Parse(txtSalario.Text);
                    var TotalIrrf = Irrf.Calcula(SalarioaReceber);
                    lblResultado.Text = "O VALOR DO SEU DESCONTO FOI DE: R$" + TotalIrrf.ToString("F2");
                    panelResultado.Visible = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Informe um salario válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
