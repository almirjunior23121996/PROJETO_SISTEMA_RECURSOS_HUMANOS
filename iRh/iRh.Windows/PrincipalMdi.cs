using iRh.Windows.Simuladores;
using System;
using System.Windows.Forms;
using iRh.Windows.Cadastros;

namespace iRh.Windows
{
    public partial class PrincipalMdi : Form
    {
        public PrincipalMdi()
        {
            InitializeComponent();
        }

        private void PrincipalMdi_Load(object sender, EventArgs e)
        {

        }

        private void menuDescontoInss_Click(object sender, EventArgs e)
        {
            var form = new lblSalarioBase();
            form.MdiParent = this;
            form.Show();
        }

        private void menuDescontoIrrf_Click(object sender, EventArgs e)
        {
            var form = new frmDescontoIrrf();
            form.MdiParent = this;
            form.Show();
        }

        private void menuBeneficioAdicionalNoturno_Click(object sender, EventArgs e)
        {
            var form = new BeneficioAdicionalNoturno();
            form.MdiParent = this;
            form.Show();
        }

        private void menuBeneficioFgts_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioFgts();
            form.MdiParent = this;
            form.Show();
        }

        private void menuBeneficioFerias_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioFerias();
            form.MdiParent = this;
            form.Show();
        }

        private void menuBeneficioHoraExtra_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioHoraExtra();
            form.MdiParent = this;
            form.Show();
        }

        private void menuBeneficioPericulosidade_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioPericulosidade();
            form.MdiParent = this;
            form.Show();
        }

        private void menuBeneficioPis_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioPis();
            form.MdiParent = this;
            form.Show();
        }

        private void menuBeneficioSeguroDesemprego_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioSeguroDesemprego();
            form.MdiParent = this;
            form.Show();
        }

        private void menuBeneficioValeTransporte_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioValeTransporte();
            form.MdiParent = this;
            form.Show();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmFuncionario();
            form.MdiParent = this;
            form.Show();
        }
    }
}
