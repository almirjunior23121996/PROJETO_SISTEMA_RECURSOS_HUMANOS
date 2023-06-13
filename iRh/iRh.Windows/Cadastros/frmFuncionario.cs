using iRh.Windows.Core;
using System.Windows.Forms;
using System.Linq;

namespace iRh.Windows.Cadastros
{
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }
        private void CarrgarEstados() 
        {
            var estado = new Estados();
            var listaEstados = estado.ObterTodosEstados();

            cmbEstados.Items.Clear();
            cmbEstados.DataSource = listaEstados;
            cmbEstados.DisplayMember = "Sigla";
            cmbEstados.ValueMember = "Id";
         
            


        }
    }
}
