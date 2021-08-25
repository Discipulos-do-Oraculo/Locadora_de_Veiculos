using LocadoraVeiculo.Dominio.CombustivelModule;
using LocadoraVeiculo.Dominio.DevolucaoModule;
using LocadoraVeiculo.Dominio.LocacaoModule;
using LocadoraVeiculo.Dominio.TaxasEServicosModule;
using LocadoraVeiculo.Dominio.VeiculoModule;
using LocadoraVeiculos.Controlador.DevolucaoModule;
using LocadoraVeiculos.Controlador.GasolinaModule;
using LocadoraVeiculos.Controlador.LocacaoModule;
using LocadoraVeiculos.Controlador.VeiculoModule;
using LocadoraVeiculos.WindowsForms.Features.LocacaoModule.Abrir_Locacao;
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
    public partial class TelaDevolucaoForm : Form
    {
        private Devolucao devolucao;
        private ControladorDevolucao controlador;
        private ControladorCombustivel controladorCombustivel;
        private ICadastravel operacoes;
        private Locacao locacao;
        private List<TaxasEServicos> taxas;
        private double valorPonteiro = 1;
        private double valorAPagar = default;
        private double valorTotal = default;

        public List<TaxasEServicos> Taxas { get => taxas; set => taxas = value; }

        public TelaDevolucaoForm(ControladorDevolucao ctlr)
        {
            InitializeComponent();
            controlador = ctlr;
            controladorCombustivel = new ControladorCombustivel();
            CarregarCombustiveis();
        }

        public Devolucao Devolucao
        {
            get { return devolucao; }
            set
            {
                devolucao = value;

                textBoxId.Text = devolucao.Id.ToString();
                cmbCombustivel.Text = devolucao.TipoCombustivel.Nome;
                txtKmFinal.Text = devolucao.KmFinal.ToString();
                cmbCombustivel.Text = devolucao.LitrosGastos.ToString();
                lblLocacao.Text = devolucao.Locacao.Condutor.ToString();
                dateTimePickerRetorno.Value = devolucao.DataRetorno;
                dateTimePickerRetorno.Enabled = false;
                txtValorTotal.Text = devolucao.ValorTotal.ToString();
            }
        }

        private void CarregarCombustiveis()
        {
            cmbCombustivel.DataSource = controladorCombustivel.SelecionarTodos();
            cmbCombustivel.DisplayMember = "NOME";
            cmbCombustivel.ValueMember = "NOME";
        }


        private void btnSelecionarLocacao_Click(object sender, EventArgs e)
        {
            operacoes = new OperacoesAbrirLocacao(new ControladorLocacao(), new ControladorLocacaoTaxasEServicos());

            TelaSelecionarLocacaoForm telaLocacao = new TelaSelecionarLocacaoForm(operacoes);
            telaLocacao.ShowDialog();
            locacao = telaLocacao.Locacao;

            if (locacao != null)
            {
                lblLocacao.Text = locacao.Condutor.ToString();
                txtValorTotal.Text = locacao.ValorTotal.ToString();
                CalculaValorTotal();
            }
        }

        private void btnSelecionarTaxas_Click(object sender, EventArgs e)
        {
            TelaTaxasEServicosForm telaTaxa = new TelaTaxasEServicosForm(Taxas);
            telaTaxa.ShowDialog();
            Taxas = telaTaxa.TaxasSelecionadas;
            if (Taxas != null)
            {
                btnSelecionarTaxas.Text = "Clique para Editar";
                CalculaValorTotal();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

        }

        private bool TemMulta()
        {
            if (locacao.DataRetorno < DateTime.Today)
                return true;

            return false;
        }

        private void CalculaValorTotal()
        {
            double valorGasolina = CalculaValorGasolina();
            double valorPlano = CalculaKm();

            if (TemMulta())
                valorTotal = (valorGasolina + locacao.ValorTotal + valorPlano) + (valorGasolina + locacao.ValorTotal + valorPlano) * 0.1; // + taxas 

            else
                valorTotal = (valorGasolina + locacao.ValorTotal + valorPlano);

            txtValorTotal.Text = valorTotal.ToString();
        }

        private double CalculaValorGasolina()
        {
            int quantidadeLitros = locacao.Veiculo.LitrosTanque;

            ObtemValorPonteiro();

            Combustivel combustivel = (Combustivel)cmbCombustivel.SelectedItem;

            valorAPagar = (quantidadeLitros - (quantidadeLitros * valorPonteiro)) * combustivel.Valor;

            return valorAPagar;
        }

        private double CalculaKm()
        {
            double quantidadeKm = default;

            if (txtKmFinal.Text != "")
            {                
                int kmFinal = Convert.ToInt32(txtKmFinal.Text);

                if (locacao.Plano == "Diário")
                    quantidadeKm = kmFinal - locacao.Veiculo.KmAtual;

                if (locacao.Plano == "Km Controlado" && locacao.Veiculo.GrupoDeVeiculos.LimiteKmControlado < kmFinal)
                    quantidadeKm = ((kmFinal - locacao.Veiculo.KmAtual) * locacao.Veiculo.GrupoDeVeiculos.ValorKmControlado);
            }
           
            return quantidadeKm;
        }

        private double ObtemValorPonteiro()
        {  
            if(cmbLitros.SelectedItem != null)
            {
                if (cmbLitros.Text == "1/8")
                    valorPonteiro = 0.12;

                else if (cmbLitros.Text == "2/8")
                    valorPonteiro = 0.25;

                else if (cmbLitros.Text == "3/8")
                    valorPonteiro = 0.37;

                else if (cmbLitros.Text == "4/8")
                    valorPonteiro = 0.5;

                else if (cmbLitros.Text == "5/8")
                    valorPonteiro = 0.65;

                else if (cmbLitros.Text == "6/8")
                    valorPonteiro = 0.75;

                else if (cmbLitros.Text == "7/8")
                    valorPonteiro = 0.87;

                else if (cmbLitros.Text == "8/8")
                    valorPonteiro = 1;
            }

            return valorPonteiro;
        }

        private void txtKmFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void cmbLitros_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculaValorTotal();
        }

        private void cmbCombustivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(locacao != null)
                CalculaValorTotal();
        }

        private void txtKmFinal_TextChanged(object sender, EventArgs e)
        {
            if (locacao != null)
                CalculaValorTotal();
        }
    }
}
