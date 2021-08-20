using LocadoraVeiculo.Dominio.VeiculoModule;
using LocadoraVeiculos.Controlador.VeiculoModule;
using LocadoraVeiculos.WindowsForms.Features.Veiculos.CadastroDeVeiculos;
using LocadoraVeiculos.WindowsForms.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.Features.LocacaoModule.Abrir_Locacao
{
    public partial class TelaSelecionaVeiculoForm : Form
    {
        private ICadastravel operacoes;
        private OperacoesVeiculo operacoesVeiculo;
        private Veiculo veiculoSelecionado = null;
        public TelaSelecionaVeiculoForm()
        {
            InitializeComponent();
            
        }

        public TelaSelecionaVeiculoForm(ICadastravel operacoes)
        {
            InitializeComponent();
            this.operacoes = operacoes;
            operacoesVeiculo = new OperacoesVeiculo(new ControladorVeiculo());
        }

        public Veiculo Veiculo { get => veiculoSelecionado; set => veiculoSelecionado = value; }

        public void ConfigurarPainelRegistros()
        {
           

            UserControl tabela = operacoes.ObterTabela();

            tabela.Dock = DockStyle.Fill;

            panelCentral.Controls.Clear();

            panelCentral.Controls.Add(tabela);
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            operacoes.SelecionarRegistro();
            veiculoSelecionado = operacoesVeiculo.VeiculoSelecionado;
        }
    }
}
