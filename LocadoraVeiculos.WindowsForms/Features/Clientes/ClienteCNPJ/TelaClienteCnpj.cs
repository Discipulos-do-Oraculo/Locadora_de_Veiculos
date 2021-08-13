using LocadoraVeiculo.Dominio.ClienteModule;
using System;
using System.IO;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.Features.Clientes.ClienteCNPJ
{
    public partial class TelaClienteCnpj : Form
    {
        private ClienteCnpj cliente;
        public ClienteCnpj ClienteCnpj
        {
            get { return cliente; }
            set
            {
                cliente = value;

                textBoxId.Text = cliente.Id.ToString();
                txtNome.Text = cliente.Nome;
                txtCelular.Text = cliente.Celular;
                txtCidade.Text = cliente.Cidade;
                txtCnpj.Text = cliente.Cnpj;
                txtEmail.Text = cliente.Email;
                txtEndereco.Text = cliente.Endereco;
                txtEstado.Text = cliente.Estado;
                txtTelefone.Text = cliente.Telefone;

            }
        }

        public TelaClienteCnpj()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string celular = txtCelular.Text;
            string cidade = txtCidade.Text;
            string cnpj = txtCnpj.Text;
            string email = txtEmail.Text;
            string endereco = txtEndereco.Text;
            string estado = txtEstado.Text;
            string telefone = txtTelefone.Text;

            cliente = new ClienteCnpj(nome, cnpj, telefone, email, cidade, endereco, celular, estado);

            string resultadoValidacao = cliente.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                TelaInicial.Instancia.AtualizarRodape(primeiroErro);

                DialogResult = DialogResult.None;
            }
        }
    }
}
