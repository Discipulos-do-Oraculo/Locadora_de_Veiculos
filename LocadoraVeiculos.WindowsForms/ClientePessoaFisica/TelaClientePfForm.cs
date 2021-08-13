using LocadoraVeiculo.Dominio.ClienteModule;
using LocadoraVeiculos.Controlador.ClienteModule;
using System;
using System.IO;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.ClientePessoaFisica
{
    public partial class TelaClientePfForm : Form
    {
        private ClientePF cliente;
        private ControladorClientePF controlador;
        public TelaClientePfForm(ControladorClientePF ctlr)
        {
            controlador = ctlr;
            InitializeComponent();
        }

        public ClientePF ClientePF
        {
            get { return cliente; }
            set
            {
                cliente = value;

                textBoxId.Text = cliente.Id.ToString();
                txtCelular.Text = cliente.Celular;
                txtCidade.Text = cliente.Cidade;
                txtCnh.Text = cliente.Cnh;
                txtCpf.Text = cliente.Cpf;
                txtEmail.Text = cliente.Email;
                txtEndereco.Text = cliente.Endereco;
                txtEstado.Text = cliente.Estado;
                txtNome.Text = cliente.Nome;
                txtRg.Text = cliente.Rg;
                txtTelefone.Text = cliente.Telefone;
                dateDataVencimento.Value = cliente.ValidadeCnh;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string celular = txtCelular.Text;          
            string cidade = txtCidade.Text;
            string cnh = txtCnh.Text;
            string cpf = txtCpf.Text;
            string email = txtEmail.Text;
            string endereco = txtEndereco.Text;
            string estado = txtEstado.Text;
            string nome = txtNome.Text;
            string rg = txtRg.Text;
            string telefone = txtTelefone.Text;
            DateTime vencimentoCnh = dateDataVencimento.Value;

            cliente = new ClientePF(nome, endereco, email, cidade, estado, telefone, celular, rg, cpf, cnh, vencimentoCnh);

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
