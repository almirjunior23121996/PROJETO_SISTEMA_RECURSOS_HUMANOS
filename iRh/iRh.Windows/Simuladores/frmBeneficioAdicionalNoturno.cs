using System;
using System.Windows.Forms;
using iRh.Windows.Core;            //sexto passo 
namespace iRh.Windows.Simuladores
{
    public partial class BeneficioAdicionalNoturno : Form
    {
        public BeneficioAdicionalNoturno()
        {
            InitializeComponent();
        }
       
        private void btnCalcular_Click(object sender, EventArgs e) //1 passo
        {
            if (string.IsNullOrEmpty(txtSalarioTotal.Text))
            {
                MessageBox.Show("Informe um salario.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalarioTotal.Focus();
                return;
            }
            else
            {
                try
                {
                    var salarioValorEmConta = double.Parse(txtSalarioTotal.Text);//segundo passo
                    var HorasNoturnasFeitas = double.Parse(txtHorasNoturnasFeitasNoMes.Text);
                    var valorDoadicionalNoturno = AdicionalNoturno.Calcula(salarioValorEmConta, HorasNoturnasFeitas); //setimo passo
                    lblResultado.Text = "O VALOR DO ADICIONAL SERÁ DE: R$" + valorDoadicionalNoturno.ToString("F2");
                    panelResultado.Visible = true;

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
