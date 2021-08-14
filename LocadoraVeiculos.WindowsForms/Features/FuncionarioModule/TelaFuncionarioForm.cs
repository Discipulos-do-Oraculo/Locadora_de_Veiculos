using LocadoraVeiculo.Dominio.ClienteModule;
using LocadoraVeiculos.Controlador.ClienteModule.CondutorControlador;
using System;
using System.IO;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.FuncionarioModule
{
    public partial class TelaFuncionarioForm : Form
    {
        private Colaborador colaborador;
        private ControladorColaborador controlador;

        public TelaFuncionarioForm(ControladorColaborador ctlr)
        {
            controlador = ctlr;
            InitializeComponent();
        }

        public Colaborador Colaborador
        {
            get { return colaborador; }
            set
            {
                colaborador = value;

                textBoxId.Text = colaborador.Id.ToString();
                txtCelular.Text = colaborador.Celular;
                txtCidade.Text = colaborador.Cidade;
                txtCpf.Text = colaborador.Cpf;
                txtEmail.Text = colaborador.Email;
                txtEndereco.Text = colaborador.Endereco;
                txtEstado.Text = colaborador.Estado;
                txtNome.Text = colaborador.Nome;
                txtRg.Text = colaborador.Rg;
                txtTelefone.Text = colaborador.Telefone;
                dateDataEntrada.Value = colaborador.DataEntrada;
                txtLogin.Text = colaborador.Login;
                txtSenha.Text = colaborador.Senha;
                txtSalario.Text = colaborador.Salario.ToString();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string celular = txtCelular.Text;
            string cidade = txtCidade.Text;
            string cpf = txtCpf.Text;
            string email = txtEmail.Text;
            string endereco = txtEndereco.Text;
            string estado = txtEstado.Text;
            string nome = txtNome.Text;
            string rg = txtRg.Text;
            string telefone = txtTelefone.Text;
            string login = txtLogin.Text;
            string senha = txtSenha.Text;
            double salario = Convert.ToDouble(txtSalario.Text);
            DateTime dataEntrada = dateDataEntrada.Value;

            colaborador = new Colaborador(nome, endereco, email, cidade, estado, telefone, celular, rg, cpf, login, senha, dataEntrada, salario);

            string resultadoValidacao = colaborador.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                TelaInicial.Instancia.AtualizarRodape(primeiroErro);

                DialogResult = DialogResult.None;
            }
        }
    }
}
