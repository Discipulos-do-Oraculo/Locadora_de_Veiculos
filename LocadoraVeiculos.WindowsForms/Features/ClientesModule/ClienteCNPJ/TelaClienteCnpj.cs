using LocadoraVeiculo.Dominio.ClienteModule;
using LocadoraVeiculos.Controlador.ClienteModule.ClienteCnpjControlador;
using System;
using System.IO;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.Features.Clientes.ClienteCNPJ
{
    public partial class TelaClienteCnpj : Form
    {
        private ClienteCnpj cliente;

        private ControladorClienteCnpj controlador;

        private int id;
        public ClienteCnpj ClienteCnpj
        {
            get { return cliente; }
            set
            {
                cliente = value;

                textBoxId.Text = cliente.Id.ToString();
                txtNome.Text = cliente.NomeClienteCnpj;
                maskedTextBoxCelular.Text = cliente.Celular;
                txtCidade.Text = cliente.Cidade;
                maskedTextBoxCnpj.Text = cliente.Cnpj;
                txtEmail.Text = cliente.Email;
                txtEndereco.Text = cliente.Endereco;
                txtEstado.Text = cliente.Estado;
                maskedTextBoxTelefone.Text = cliente.Telefone;

            }
        }

        public TelaClienteCnpj(ControladorClienteCnpj ctrl)
        {
            InitializeComponent();
            controlador = ctrl;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != "")
            {
                id = Convert.ToInt32(textBoxId.Text);

            }
            string nome = txtNome.Text;
            maskedTextBoxCelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string celular = maskedTextBoxCelular.Text;
            string cidade = txtCidade.Text;
            maskedTextBoxCnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string cnpj = maskedTextBoxCnpj.Text;
            string email = txtEmail.Text;
            string endereco = txtEndereco.Text;
            string estado = txtEstado.Text;
            maskedTextBoxTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string telefone = maskedTextBoxTelefone.Text;

            cliente = new ClienteCnpj(nome, cnpj, telefone, email, cidade, endereco, celular, estado);

            string resultadoValidacao = cliente.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                TelaInicial.Instancia.AtualizarRodape(primeiroErro);

                DialogResult = DialogResult.None;
            }

            if (controlador.VerificaCNPJ(cliente.Cnpj, id))
            {
                resultadoValidacao = "CNPJ já cadastrado no sistema";

                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                TelaInicial.Instancia.AtualizarRodape(primeiroErro);

                DialogResult = DialogResult.None;
            }
        }

        private void maskedTextBoxCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void maskedTextBoxCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void maskedTextBoxTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }
    }
}
