using LocadoraVeiculo.Dominio.ClienteModule;
using LocadoraVeiculos.Controlador.ClienteModule.ClienteCnpjControlador;
using LocadoraVeiculos.Controlador.ClienteModule.CondutorControlador;
using LocadoraVeiculos.WindowsForms.Features.Clientes.ClienteCNPJ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.Features.CondutorForm
{
    public partial class TelaCondutorForm : Form
    {
        private Condutor condutor;
        private ControladorCondutor controlador;
        private ControladorClienteCnpj controladorEmpresa;
        private int id;

        public TelaCondutorForm(ControladorCondutor ctlr)
        {
            controlador = ctlr;
            controladorEmpresa = new ControladorClienteCnpj();
            InitializeComponent();
            CarregarEmpresas();
        }

        public Condutor Condutor
        {
            get { return condutor; }
            set
            {
                condutor = value;

                textBoxId.Text = condutor.Id.ToString();
                maskedTextBoxCelular.Text = condutor.Celular;
                maskedTextBoxTelefone.Text = condutor.Telefone;
                txtCidade.Text = condutor.Cidade;
                txtCnh.Text = condutor.Cnh;
                maskedTextBoxCpf.Text = condutor.Cpf;
                txtEmail.Text = condutor.Email;
                txtEndereco.Text = condutor.Endereco;
                txtEstado.Text = condutor.Estado;
                txtNome.Text = condutor.Nome;
                txtRg.Text = condutor.Rg;
                maskedTextBoxCpf.Text = condutor.Telefone;
                dateDataVencimento.Value = condutor.ValidadeCnh;
                comboBoxEmpresa.Text = condutor.ClienteCnpj.NomeClienteCnpj.ToString();
            }
        }

        private void CarregarEmpresas()
        {
            comboBoxEmpresa.DataSource = controladorEmpresa.SelecionarTodos();
            comboBoxEmpresa.DisplayMember = "nomeClienteCnpj";
            comboBoxEmpresa.ValueMember = "nomeClienteCnpj";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != "")
            {
                id = Convert.ToInt32(textBoxId.Text);

            }
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
            string telefone = maskedTextBoxCpf.Text;
            ClienteCnpj empresa = (ClienteCnpj)comboBoxEmpresa.SelectedItem;
            DateTime vencimentoCnh = dateDataVencimento.Value;

            condutor = new Condutor(nome, endereco, email, cidade, estado, telefone, celular, rg, cpf, cnh, vencimentoCnh, empresa);

            string resultadoValidacao = condutor.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                FormatarRodape(resultadoValidacao);
            }

            if (controlador.VerificaCPF(condutor.Cpf, id))
            {
                resultadoValidacao = "CPF já cadastrado no sistema";
                FormatarRodape(resultadoValidacao);
            }

            if (controlador.VerificaRG(condutor.Rg, id))
            {
                resultadoValidacao = "RG já cadastrado no sistema";
                FormatarRodape(resultadoValidacao);
            }
            if (controlador.VerificaCNH(condutor.Cnh, id))
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

        private void maskedTextBoxCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void txtRg_KeyPress(object sender, KeyPressEventArgs e)
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

        private void maskedTextBoxCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }
    }
}
