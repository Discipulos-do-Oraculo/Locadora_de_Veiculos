using LocadoraVeiculo.Dominio.LocacaoModule;
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

namespace LocadoraVeiculos.WindowsForms.Features.DevolucaoModule
{
    public partial class TelaSelecionarLocacaoForm : Form
    {
        private ICadastravel operacoes;
        private Locacao locacao;

        public TelaSelecionarLocacaoForm(ICadastravel op)
        {
            InitializeComponent();
            operacoes = op;

            ConfigurarPainelRegistros();
        }

        private void ConfigurarPainelRegistros()
        {
            UserControl tabela = operacoes.ObterTabela();

            tabela.Dock = DockStyle.Fill;

            panelCentral.Controls.Clear();

            panelCentral.Controls.Add(tabela);
        }

        public Locacao Locacao { get => locacao; set => locacao = value; }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            locacao = (Locacao)operacoes.SelecionarRegistro();
        }
    }
}
