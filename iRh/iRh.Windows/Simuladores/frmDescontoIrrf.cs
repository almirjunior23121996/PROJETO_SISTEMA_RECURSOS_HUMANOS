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
                MessageBox.Show("Informe um salario.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
                return;
            }
            else
            {
                try
                {
                    var SalarioaReceber = double.Parse(txtSalario.Text);
                    var TotalIrrf = Irrf.Calcula(SalarioaReceber);
                    lblResultado.Text = TotalIrrf.ToString();
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
