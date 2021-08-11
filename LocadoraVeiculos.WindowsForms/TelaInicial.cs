using LocadoraVeiculos.WindowsForms.Features.Veiculos;
using LocadoraVeiculos.Controlador.GrupoDeVeiculosModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LocadoraVeiculos.WindowsForms.Shared;

namespace LocadoraVeiculos.WindowsForms
{
    public partial class TelaInicial : Form
    {

        public static TelaInicial Instancia;
        private OperacoesGrupoDeVeiculos operacoesGrupoDeVeiculos;
        private ICadastravel operacoes;

        public TelaInicial()
        {


            Instancia = this;
            operacoesGrupoDeVeiculos = new OperacoesGrupoDeVeiculos(new ControladorGrupoDeVeiculos());
            InitializeComponent();
            barraTarefas.Enabled = false;
        }

        public void AtualizarRodape(string mensagem)
        {
            statusAtual.Text = mensagem;
        }

        private void ConfigurarPainelRegistros()
        {
            UserControl tabela = operacoes.ObterTabela();

            tabela.Dock = DockStyle.Fill;

            panelCentral.Controls.Clear();

            panelCentral.Controls.Add(tabela);
        }

        private void ConfigurarToolBox(IConfiguracaoToolBox configuracao)
        {
            barraTarefas.Enabled = true;
            menuOpcao.Text = configuracao.TipoCadastro;

            btnAdicionar.ToolTipText = configuracao.ToolTipAdicionar;
            btnEditar.ToolTipText = configuracao.ToolTipEditar;
            btnExcluir.ToolTipText = configuracao.ToolTipExcluir;
            //btnDesagrupar.ToolTipText = configuracao.ToolTipDesAgrupar;
            //btnAgrupar.ToolTipText = configuracao.ToolTipAgrupar;
            btnFiltrar.ToolTipText = configuracao.ToolTipFiltro;
        }

        

        private void menuGrupoVeiculos_Click(object sender, EventArgs e)
        {
            ConfiguracaoGrupoDeVeiculosToolBox configuracao = new ConfiguracaoGrupoDeVeiculosToolBox();

            ConfigurarToolBox(configuracao);

            AtualizarRodape(configuracao.TipoCadastro);

            operacoes = new OperacoesGrupoDeVeiculos(new ControladorGrupoDeVeiculos());

            ConfigurarPainelRegistros();

            btnFiltrar.Enabled = false;
            btnExcluir.Enabled = false;

        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            operacoes.InserirNovoRegistro();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            operacoes.EditarRegistro();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            operacoes.ExcluirRegistro();
        }
    }
}
