using iRh.Windows.Core;
using System;
using System.Windows.Forms;

namespace iRh.Windows.Simuladores
{
    public partial class lblSalarioBase : Form
    {
        public lblSalarioBase()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalarioBase.Text))
            {
                MessageBox.Show("Informe seu salário base", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtSalarioBase.Focus();
                return;
            }
            try
            {
                var salario = double.Parse(txtSalarioBase.Text);
                var descontonss = Inss.Calcula(salario);
                lblResultado.Text = descontonss.ToString("C");
            }
            catch (Exception)
            {
                MessageBox.Show("Informe um valor de salário válido, ex.3500", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            }
        
        }
            
    }
}
