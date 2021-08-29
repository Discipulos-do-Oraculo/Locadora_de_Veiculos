using LocadoraVeiculo.Dominio.CupomModule;
using LocadoraVeiculos.Controlador.CupomModule;
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

namespace LocadoraVeiculos.WindowsForms.Features.ParceiroModule
{
    public partial class TelaParceiroForm : Form
    {
        private Parceiro parceiro;
        private readonly ControladorMidia controladorMidia;
        private readonly ControladorParceiro controlador = null;
        private int id;

        public TelaParceiroForm()
        {
            InitializeComponent();
            controladorMidia = new ControladorMidia();
            controlador = new ControladorParceiro();
            CarregarMidias();
        }

        public Parceiro Parceiro
        {
            get { return parceiro; }
            set
            {
                parceiro = value;

                textBoxId.Text = parceiro.Id.ToString();
                txtNome.Text = parceiro.Nome;
                cmbMidia.Text = parceiro.MeioComunicao.Nome.ToString();
            }
        }

        private void CarregarMidias()
        {
            cmbMidia.DataSource = controladorMidia.SelecionarTodos();
            cmbMidia.DisplayMember = "NOME";
            cmbMidia.ValueMember = "NOME";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            Midia midia = (Midia)cmbMidia.SelectedItem;

            parceiro = new Parceiro(nome, midia);

            string resultadoValidacao = parceiro.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                FormatarRodape(resultadoValidacao);
            }
            if (controlador.VerificaNome(nome, id))
            {
                resultadoValidacao = "Este parceiro já está cadastrado";
                FormatarRodape(resultadoValidacao);
            }

        }

        private void FormatarRodape(string resultadoValidacao)
        {
            string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

            TelaInicial.Instancia.AtualizarRodape(primeiroErro);

            DialogResult = DialogResult.None;
        }
    }
}
