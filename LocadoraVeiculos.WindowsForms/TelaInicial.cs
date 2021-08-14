using LocadoraVeiculos.WindowsForms.Features.Veiculos;
using LocadoraVeiculos.Controlador.GrupoDeVeiculosModule;
using System;
using System.Windows.Forms;
using LocadoraVeiculos.WindowsForms.Shared;
using LocadoraVeiculos.WindowsForms.Features.Veiculos.CadastroDeVeiculos;
using LocadoraVeiculos.Controlador.VeiculoModule;

using LocadoraVeiculos.WindowsForms.ClientePessoaFisica;
using LocadoraVeiculos.Controlador.ClienteModule;

using LocadoraVeiculos.WindowsForms.Features.ClienteCNPJ;
using LocadoraVeiculos.WindowsForms.Features.Clientes.ClienteCNPJ;
using LocadoraVeiculos.Controlador.ClienteModule.ClienteCnpjControlador;
using LocadoraVeiculos.Controlador.ClienteModule.ClientePfControlador;
using LocadoraVeiculos.WindowsForms.FuncionarioModule;
using LocadoraVeiculos.Controlador.ClienteModule.CondutorControlador;
using LocadoraVeiculos.WindowsForms.Features.CondutorForm;

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

        private void menuVeiculos_Click(object sender, EventArgs e)
        {
            ConfiguracaoVeiculosToolBox configuracao = new ConfiguracaoVeiculosToolBox();

            ConfigurarToolBox(configuracao);

            AtualizarRodape(configuracao.TipoCadastro);

            operacoes = new OperacoesVeiculo(new ControladorVeiculo());

            ConfigurarPainelRegistros();

            btnFiltrar.Enabled = false;
        }


        private void menuPessoaFisica_Click(object sender, EventArgs e)
        {
            ConfiguracaoClientePfToolBox configuracao = new ConfiguracaoClientePfToolBox();
            
            ConfigurarToolBox(configuracao);

            AtualizarRodape(configuracao.TipoCadastro);


            operacoes = new OperacoesClientePF(new ControladorClientePF());

            ConfigurarPainelRegistros();

            btnFiltrar.Enabled = false;
        }
        private void menuPessoaJuridica_Click(object sender, EventArgs e)
        {
            ConfiguracaoClienteCnpjToolBox configuracao = new ConfiguracaoClienteCnpjToolBox();

            ConfigurarToolBox(configuracao);

            AtualizarRodape(configuracao.TipoCadastro);

            operacoes = new OperacoesClienteCnpj(new ControladorClienteCnpj());

            ConfigurarPainelRegistros();

            btnFiltrar.Enabled = false;
        }

        private void menuFuncionario_Click(object sender, EventArgs e)
        {
            ConfiguracaoFuncionarioToolBox configuracao = new ConfiguracaoFuncionarioToolBox();

            ConfigurarToolBox(configuracao);

            AtualizarRodape(configuracao.TipoCadastro);

            operacoes = new OperacoesFuncionario(new ControladorColaborador());

            ConfigurarPainelRegistros();

            btnFiltrar.Enabled = false;
        }

        private void condutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfiguracaoCondutorToolBox configuracao = new ConfiguracaoCondutorToolBox();

            ConfigurarToolBox(configuracao);

            AtualizarRodape(configuracao.TipoCadastro);

            operacoes = new OperacaoCondutor(new ControladorCondutor());

            ConfigurarPainelRegistros();

            btnFiltrar.Enabled = false;
        }
    }
}
