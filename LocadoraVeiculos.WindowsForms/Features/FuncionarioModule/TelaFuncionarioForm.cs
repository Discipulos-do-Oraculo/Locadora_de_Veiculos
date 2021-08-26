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
        private int id;
        public TelaFuncionarioForm(ControladorColaborador ctlr)
        {
            controlador = ctlr;
            InitializeComponent();
            FormatandoCampoValor();
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
                maskedTextBoxCpf.Text = colaborador.Cpf;
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
            SalvarFuncionario();
        }

        private void SalvarFuncionario()
        {
            if (textBoxId.Text != "")
            {
                id = Convert.ToInt32(textBoxId.Text);

            }
            double salario = default;
            txtCelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string celular = txtCelular.Text;
            string cidade = txtCidade.Text;
            maskedTextBoxCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string cpf = maskedTextBoxCpf.Text;
            string email = txtEmail.Text;
            string endereco = txtEndereco.Text;
            string estado = txtEstado.Text;
            string nome = txtNome.Text;
            string rg = txtRg.Text;
            txtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string telefone = txtTelefone.Text;
            string login = txtLogin.Text;
            string senha = txtSenha.Text;
            if (txtSalario.Text != "")
            {
                salario = Convert.ToDouble(txtSalario.Text);
            }

            DateTime dataEntrada = dateDataEntrada.Value;

            colaborador = new Colaborador(nome, endereco, email, cidade, estado, telefone, celular, rg, cpf, login, senha, dataEntrada, salario);

            string resultadoValidacao = colaborador.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                FormatarRodape(resultadoValidacao);
            }

            if (controlador.VerificaCPF(colaborador.Cpf, id))
            {
                resultadoValidacao = "CPF já cadastrado no sistema";
                FormatarRodape(resultadoValidacao);
            }

            if (controlador.VerificaRG(colaborador.Rg, id))
            {
                resultadoValidacao = "RG já cadastrado no sistema";
                FormatarRodape(resultadoValidacao);
            }
        }

        private void FormatarRodape(string resultadoValidacao)
        {
            string primeiroErro = new StringReader(resultadoValidacao).ReadLine();
            if(TelaInicial.Instancia != null)
                TelaInicial.Instancia.AtualizarRodape(primeiroErro);

            DialogResult = DialogResult.None;
        }

        private void FormatandoCampoValor()
        {
            if (txtSalario.Text != "")
                txtSalario.Text = String.Format("{0:#,##0.00##}", double.Parse(txtSalario.Text));
        }

        private void txtRg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void maskedTextBoxCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void txtSalario_Leave(object sender, EventArgs e)
        {
            FormatandoCampoValor();
        }

        private void txtEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void txtCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }
    }
}
