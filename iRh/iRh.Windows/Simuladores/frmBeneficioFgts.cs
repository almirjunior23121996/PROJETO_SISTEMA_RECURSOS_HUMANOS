using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iRh.Windows.Simuladores
{
    public partial class frmBeneficioFgts : Form
    {
        public frmBeneficioFgts()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var multa = double.Parse (txtValorEmConta.Text) * 40.00 / 100.00;
            var multafinal = 
            lblResultado.Text = 

          
            
        }
    }
}
