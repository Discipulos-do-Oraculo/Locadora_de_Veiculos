using LocadoraVeiculo.Dominio.ClienteModule;
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
    public partial class TelaSelecionarPessoaForm : Form
    {
        private ICadastravel operacoesPF, operacoesPJ;
        private ClienteCnpj pessoaPJ = null;
        private ClientePF pessoaPF = null;

        public ClienteCnpj PessoaPJ { get => pessoaPJ; set => pessoaPJ = value; }
        public ClientePF PessoaPF { get => pessoaPF; set => pessoaPF = value; }

        public TelaSelecionarPessoaForm(ICadastravel operacoesPF, ICadastravel operacoesPJ)
        {
            InitializeComponent();
            this.operacoesPF = operacoesPF;
            this.operacoesPJ = operacoesPJ;
            rdbPessoaFisica.Checked = true;
        }

        private void rdbPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            ConfigurarPainelRegistros();
        }

        private void rdbPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            ConfigurarPainelRegistros();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (rdbPessoaFisica.Checked)
            {
                pessoaPF = (ClientePF)operacoesPF.SelecionarRegistro();

            }else if (rdbPessoaJuridica.Checked){

                pessoaPJ = (ClienteCnpj)operacoesPJ.SelecionarRegistro();
            }
        }

        public void ConfigurarPainelRegistros()
        {

            if (rdbPessoaJuridica.Checked)
            {
                UserControl tabela = operacoesPJ.ObterTabela();

                tabela.Dock = DockStyle.Fill;

                panelCentral.Controls.Clear();

                panelCentral.Controls.Add(tabela);

            }else if (rdbPessoaFisica.Checked)
            {
                UserControl tabela = operacoesPF.ObterTabela();

                tabela.Dock = DockStyle.Fill;

                panelCentral.Controls.Clear();

                panelCentral.Controls.Add(tabela);

            }
        }
    }
}
