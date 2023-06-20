using System;
using System.Threading;
using System.Windows.Forms;
namespace iRh.Windows.Simuladores
{
    public partial class frmBeneficioSeguroDesemprego : Form
    {
        public frmBeneficioSeguroDesemprego()
        {
            InitializeComponent();
        }
        private void buttonResultado_Click(object sender, EventArgs e)
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
                if (string.IsNullOrEmpty(txtVezesSolicitados.Text))
                {
                    MessageBox.Show("Informe vezes solicitadas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtVezesSolicitados.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtMesesTrabalhados.Text))
                {
                    MessageBox.Show("Informe Meses Trabalhados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMesesTrabalhados.Focus();
                    return;
                }
                var vezesSoliticitados = int.Parse(txtVezesSolicitados.Text);
                var MesesTrabalhados = int.Parse(txtMesesTrabalhados.Text);
                if (vezesSoliticitados == 0)
                {
                    if (MesesTrabalhados < 12)
                    {
                        lblResultado.Text = "NÃO ESTA APTO A RECEBER O BENEFICIO";
                        panel1.Visible = true;
                    }
                    if (MesesTrabalhados > 11 && MesesTrabalhados < 24) 
                    {
                        lblResultado.Text = "ESTÁ APTO A RECEBER (4)PARCELAS";
                        panel1.Visible = true;
                    }
                    if (MesesTrabalhados > 24)
                    {
                        lblResultado.Text = "ESTA APTO A RECEBER (5)PARCELAS";
                        panel1.Visible = true;
                    }
                }
                if (vezesSoliticitados == 1)
                {
                    if (MesesTrabalhados < 9)
                    {
                        lblResultado.Text = "VOCÊ NÃO ESTÁ APTO A RECEBER O BENEFICIO";
                        panel1.Visible = true;
                    }
                    if(MesesTrabalhados > 8 && MesesTrabalhados < 12)
                    {
                        lblResultado.Text = "ESTÁ APTO A RECEBER (3) PARCELAS";
                        panel1.Visible = true;
                    }
                    if(MesesTrabalhados > 11 && MesesTrabalhados < 24)
                    {
                        lblResultado.Text = "ESTÁ APTO A RECEBER (3) PARCELAS";
                        panel1.Visible = true;
                    }
                    if(MesesTrabalhados > 23)
                    {
                        lblResultado.Text = "ESTÁ APTO A RECEBER (5) PARCELAS";
                        panel1.Visible = true;
                    }
                }
                if(vezesSoliticitados >= 2)
                {
                    if(MesesTrabalhados < 6)
                    {
                        lblResultado.Text = "NÃO ESTÁ APTO A RECEBER O BENEFÍCIO";
                        panel1.Visible = true;
                    }
                    if(MesesTrabalhados < 12 && MesesTrabalhados >5)
                    {
                        lblResultado.Text = "ESTÁ APTO A RECEBER 3 PARCELAS";
                        panel1.Visible = true;
                    }
                    if(MesesTrabalhados > 11 && MesesTrabalhados < 24)
                    {
                        lblResultado.Text = "ESTÁ APTO A RECEBER 4 PARCELAS";
                        panel1.Visible = true;
                    }
                    if(MesesTrabalhados > 23)
                    {
                        lblResultado.Text = "ESTÁ APTO A RECEBER 5 PARCELAS";
                        panel1.Visible = true;
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Preencha todos os Corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
