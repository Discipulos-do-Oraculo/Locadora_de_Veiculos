using LocadoraVeiculo.Dominio.ClienteModule;
using LocadoraVeiculos.Controlador.ClienteModule;
using LocadoraVeiculos.Controlador.ClienteModule.ClientePfControlador;
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
                maskedTextBoxCelular.Text = cliente.Celular;
                txtCidade.Text = cliente.Cidade;
                txtCnh.Text = cliente.Cnh;
                maskedTextBoxCpf.Text = cliente.Cpf;
                txtEmail.Text = cliente.Email;
                txtEndereco.Text = cliente.Endereco;
                txtEstado.Text = cliente.Estado;
                txtNome.Text = cliente.Nome;
                txtRg.Text = cliente.Rg;
                maskedTextBoxTelefone.Text = cliente.Telefone;
                dateDataVencimento.Value = cliente.ValidadeCnh;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            maskedTextBoxCelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string celular = maskedTextBoxCelular.Text;          
            string cidade = txtCidade.Text;
            string cnh = txtCnh.Text;
            maskedTextBoxCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string cpf = maskedTextBoxCpf.Text;
            string email = txtEmail.Text;
            string endereco = txtEndereco.Text;
            string estado = txtEstado.Text;
            string nome = txtNome.Text;
            string rg = txtRg.Text;
            maskedTextBoxTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string telefone = maskedTextBoxTelefone.Text;
            DateTime vencimentoCnh = dateDataVencimento.Value;

            cliente = new ClientePF(nome, endereco, email, cidade, estado, telefone, celular, rg, cpf, cnh, vencimentoCnh);

            string resultadoValidacao = cliente.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                FormatarRodape(resultadoValidacao);
            }

            if (controlador.VerificaCPF(cliente.Cpf, cliente.Id))
            {
                resultadoValidacao = "CPF já cadastrado no sistema";
                FormatarRodape(resultadoValidacao);
            }

            if (controlador.VerificaRG(cliente.Rg, cliente.Id))
            {
                resultadoValidacao = "RG já cadastrado no sistema";
                FormatarRodape(resultadoValidacao);
            }
            if (controlador.VerificaCNH(cliente.Cnh, cliente.Id))
            {
                resultadoValidacao = "CNH já cadastrada no sistema";
                FormatarRodape(resultadoValidacao);
            }
        }

        private void FormatarRodape(string resultadoValidacao)
        {
            string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

            TelaInicial.Instancia.AtualizarRodape(primeiroErro);

            DialogResult = DialogResult.None;
        }

        private void txtRg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void maskedTextBoxCpf_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }
    }
}
