
using LocadoraVeiculo.Dominio.ClienteModule;
using LocadoraVeiculos.Controlador.ClienteModule;
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

namespace LocadoraVeiculos.WindowsForms.CondutorModule
{
    public partial class TelaCondutorForm : Form
    {
        private Condutor condutor;
        private ControladorCondutor controlador;

        public TelaCondutorForm(ControladorCondutor ctlr)
        {
            controlador = ctlr;
            InitializeComponent();
        }

        public Condutor Condutor
        {
            get { return condutor; }
            set
            {
                condutor = value;

                textBoxId.Text = condutor.Id.ToString();
                txtEmpresa.Text = condutor.IdClienteCnpj.ToString();
                txtCelular.Text = condutor.Celular;
                txtCidade.Text = condutor.Cidade;
                txtCnh.Text = condutor.Cnh;
                txtCpf.Text = condutor.Cpf;
                txtEmail.Text = condutor.Email;
                txtEndereco.Text = condutor.Endereco;
                txtEstado.Text = condutor.Estado;
                txtNome.Text = condutor.Nome;
                txtRg.Text = condutor.Rg;
                txtTelefone.Text = condutor.Telefone;
                dateDataVencimento.Value = condutor.ValidadeCnh;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
        //    string celular = txtCelular.Text;
        //    string cidade = txtCidade.Text;
        //    string cnh = txtCnh.Text;
        //    string cpf = txtCpf.Text;
        //    string email = txtEmail.Text;
        //    string endereco = txtEndereco.Text;
        //    string estado = txtEstado.Text;
        //    string nome = txtNome.Text;
        //    string rg = txtRg.Text;
        //    string telefone = txtTelefone.Text;
        //    DateTime vencimentoCnh = dateDataVencimento.Value;
            
        //    condutor = new Condutor(nome, endereco, email, cidade,
        //        estado, telefone, celular, rg, cpf, cnh, vencimentoCnh);

        //    string resultadoValidacao = condutor.Validar();

        //    if (resultadoValidacao != "ESTA_VALIDO")
        //    {
        //        string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

        //        TelaInicial.Instancia.AtualizarRodape(primeiroErro);

        //        DialogResult = DialogResult.None;
            }
        }
    }
}
