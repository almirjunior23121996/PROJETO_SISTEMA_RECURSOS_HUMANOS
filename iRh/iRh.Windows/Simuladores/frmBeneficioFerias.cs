using System;
using System.Threading;
using System.Windows.Forms;
using iRh.Windows.Core;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace iRh.Windows.Simuladores
{
    public partial class frmBeneficioFerias : Form
    {
        public frmBeneficioFerias()
        {
            InitializeComponent();
        }

        private void button1Resultado_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Informe seu salario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSalario.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtVendaFerias.Text))
                {
                    MessageBox.Show("Informe quantos dias quer vender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtVendaFerias.Focus();
                    return;
                }
                double salario = double.Parse(txtSalario.Text);
                double vendaFerias = double.Parse(txtVendaFerias.Text);
                double valorDoDia = salario / 30; 
                
                if (vendaFerias > 10) 
                {
                    lblResultado.Text = "O NÚMERO MÁXIMO DE DIAS QUE PODEM SER VENDIDOS É 10 \n" + "TENTE NOVAMENTE!";
                    return;
                }

               var valorFeriasBruto = (vendaFerias * valorDoDia) + (salario / 3) + (vendaFerias * valorDoDia) / 3;
                
                var valorFeriasComSalario = valorFeriasBruto + salario;
                var descontoInss = Inss.Calcula(valorFeriasComSalario);
                var salarioComDescontoInss = valorFeriasComSalario - descontoInss;
                var descontoIrrf = Irrf.Calcula(salarioComDescontoInss);
                salario = (valorFeriasComSalario - descontoInss) - descontoIrrf;

                lblResultado.Text = "VOCÊ RECEBERÁ " + salario.ToString("F2") + " DE FÉRIAS";
                panel1Resultado.Visible = true;




            }
            catch(Exception)
            {
                MessageBox.Show("Preencha todos os campos Corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
