using LocadoraVeiculo.Dominio.CupomModule;
using LocadoraVeiculos.WindowsForms.Features.CupomModule;
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
    public partial class TelaSelecionarCupom : Form
    {
        private ICadastravel operacoes;
        private Cupom cupom;

        public Cupom Cupom { get => cupom; set => cupom = value; }

        public TelaSelecionarCupom(ICadastravel operacoes)
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
            cupom = (Cupom)operacoes.SelecionarRegistro();
        }
    }
}
