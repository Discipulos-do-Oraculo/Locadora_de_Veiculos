using LocadoraVeiculo.Dominio.ClienteModule;
using LocadoraVeiculos.WindowsForms.Features.CondutorForm;
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
    public partial class TelaSelecionarCondutor : Form
    {
        private OperacaoCondutor operacoes;
        private int idEmpresa;
        private  Condutor condutor;
        public Condutor Condutor { get => condutor; set => condutor = value; }
        public TelaSelecionarCondutor(OperacaoCondutor operacoes,int empresaSelecionada)
        {
            InitializeComponent();
            this.operacoes = operacoes;
            idEmpresa = empresaSelecionada;

            ConfigurarPainelRegistros();
        }

        

        public void ConfigurarPainelRegistros()
        {

            UserControl tabela = operacoes.ObterTabelaFiltradaPorEmpresa(idEmpresa);

            tabela.Dock = DockStyle.Fill;

            panelCentral.Controls.Clear();

            panelCentral.Controls.Add(tabela);

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            condutor = (Condutor)operacoes.SelecionarRegistro();
        }
    }
}
