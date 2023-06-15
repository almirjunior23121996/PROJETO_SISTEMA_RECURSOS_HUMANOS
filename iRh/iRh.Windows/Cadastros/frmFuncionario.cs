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
            var estadosAz = listaEstados.OrderBy(x => x.Sigla).ToList();

            cmbEstados.Items.Clear();
            cmbEstados.DataSource = listaEstados;
            cmbEstados.DisplayMember = "Descricao";
            cmbEstados.ValueMember = "Id";
        }
        private void carrgarDocumentos()
        {
            var documento = new Documento();
            var listaDocumento = documento.obterTodosDocumentos();
            var documentosAz = listaDocumento.OrderBy(x => x.Id).ToList();
            cmbDocumento.DisplayMember = "Descricao";
            cmbDocumento.ValueMember = "Id";

        }

        private void btnPesquisar_Click(object sender, System.EventArgs e)
        {
            var cepDigitado = txtCep.Text;
            if (cepDigitado.Length <9)
            {
                MessageBox.Show("Digite um CEP valido");
                txtCep.Focus();
                return;
            }
            var endereco = new Endereco();
         
            var enderecoCompleto = endereco.ObterPorCep(cepDigitado);
            if (enderecoCompleto.Erro == true)
            {
                MessageBox.Show("O CEP informado não existe");
                txtCep.Focus();
                return;
            }
            if(endereco.Localidade != "")
            {
                txtCidade.Enabled = false;
            }
            if(endereco.Uf != "") 
            {
                cmbEstados.Enabled = false;
            }


            txtLogradouro.Text = enderecoCompleto.Logradouro;
            txtBairro.Text = enderecoCompleto.Bairro;
            txtCidade.Text = enderecoCompleto.Localidade;
            txtDdd.Text = enderecoCompleto.Ddd;
            cmbEstados.SelectedValue = enderecoCompleto.Uf;
       
        }

   
    }
}
