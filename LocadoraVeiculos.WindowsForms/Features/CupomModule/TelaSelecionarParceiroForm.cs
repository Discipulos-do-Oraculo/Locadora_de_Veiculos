using LocadoraVeiculo.Dominio.CupomModule;
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

namespace LocadoraVeiculos.WindowsForms.Features.CupomModule
{
    public partial class TelaSelecionarParceiroForm : Form
    {
        private ICadastravel operacoes;
        private Parceiro parceiroSelecionado = null;

        public Parceiro Parceiro { get => parceiroSelecionado; set => parceiroSelecionado = value; }

        public TelaSelecionarParceiroForm(ICadastravel operacoes)
        {
            InitializeComponent(); 
            this.operacoes = operacoes;

            ConfigurarPainelRegistros();
        }


        public void ConfigurarPainelRegistros()
        {

            UserControl tabela = operacoes.ObterTabela();

            tabela.Dock = DockStyle.Fill;

            panelCentral.Controls.Clear();

            panelCentral.Controls.Add(tabela);

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            parceiroSelecionado = (Parceiro)operacoes.SelecionarRegistro();
        }
    }
}
