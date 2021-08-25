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
using System.IO;
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
        private List<TaxasEServicos> novasTaxas;
        private double valorPonteiro = 1;
        private double valorAPagar = default;
        private double valorTotal = default;
        private double litrosGastos = default;


        public List<TaxasEServicos> Taxas { get => taxas; set => taxas = value; }

        public Locacao Locacao { get => locacao; set => locacao = value; }

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
            Locacao = telaLocacao.Locacao;

            if (Locacao != null)
            {
                ControladorLocacaoTaxasEServicos controlador = new ControladorLocacaoTaxasEServicos();
                Taxas = controlador.SelecionarPorLocacao(locacao.Id);

                lblLocacao.Text = Locacao.Condutor.ToString();
                txtValorTotal.Text = Locacao.ValorTotal.ToString();
                CalculaValorTotal();
            }
        }

        private void btnSelecionarTaxas_Click(object sender, EventArgs e)
        {
            TelaTaxasEServicosForm telaTaxa = new TelaTaxasEServicosForm(Taxas);
            telaTaxa.ShowDialog();
            novasTaxas = telaTaxa.TaxasSelecionadas;

            foreach (var item in novasTaxas)
            {
                if (taxas.Contains(item)) { }
                else { taxas.Add(item); }
            }

            if (novasTaxas != null)
            {
                btnSelecionarTaxas.Text = "Clique para Editar";
                CalculaValorTotal();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            int kmFinal = default;
            double valorTotal = default;
            Combustivel combustivel = (Combustivel)cmbCombustivel.SelectedItem;
            if(txtKmFinal.Text != "")
            {
                kmFinal = Convert.ToInt32(txtKmFinal.Text);
            }
            if(txtValorTotal.Text != "")
            {
                valorTotal = Convert.ToDouble(txtValorTotal.Text);
            }    
            
  
            DateTime dataRetoro = dateTimePickerRetorno.Value;

            devolucao = new Devolucao(locacao, combustivel, dataRetoro, kmFinal,litrosGastos,valorTotal);

            string resultadoValidacao = devolucao.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                TelaInicial.Instancia.AtualizarRodape(primeiroErro);

                DialogResult = DialogResult.None;
            }
        }

        private bool TemMulta()
        {
            if (Locacao.DataRetorno < DateTime.Today)
                return true;

            return false;
        }

        private double CalcularValoTaxas()
        {
            double valorTaxas = default;

            if (Taxas != null)
            {
                foreach (var taxa in Taxas)
                {

                    if (taxa.CalculoFixo)
                    {
                        valorTaxas += taxa.Valor;
                    }
                }
            }

            return valorTaxas;
        }


        private void CalculaValorTotal()
        {
            double valorGasolina = CalculaValorGasolina();
            double valorPlano = CalculaKm();
            double valorTaxas = CalcularValoTaxas();

            if (TemMulta())
                valorTotal = (valorGasolina + Locacao.ValorTotal + valorPlano) + (valorGasolina + Locacao.ValorTotal + valorPlano + valorTaxas) * 0.1;

            else
                valorTotal = (valorGasolina + Locacao.ValorTotal + valorPlano + +valorTaxas);

            txtValorTotal.Text = valorTotal.ToString();
        }

        private double CalculaValorGasolina()
        {
            int quantidadeLitros = Locacao.Veiculo.LitrosTanque;

            ObtemValorPonteiro();

            Combustivel combustivel = (Combustivel)cmbCombustivel.SelectedItem;

            valorAPagar = (quantidadeLitros - (quantidadeLitros * valorPonteiro)) * combustivel.Valor;

             litrosGastos = (quantidadeLitros - (quantidadeLitros * valorPonteiro));

            return valorAPagar;
        }

        private double CalculaKm()
        {
            double quantidadeKm = default;

            if (txtKmFinal.Text != "")
            {
                int kmFinal = Convert.ToInt32(txtKmFinal.Text);

                if (Locacao.Plano == "Diário")
                    quantidadeKm = kmFinal - Locacao.Veiculo.KmAtual;

                if (Locacao.Plano == "Km Controlado" && Locacao.Veiculo.GrupoDeVeiculos.LimiteKmControlado < kmFinal)
                    quantidadeKm = ((kmFinal - Locacao.Veiculo.KmAtual) * Locacao.Veiculo.GrupoDeVeiculos.ValorKmControlado);
            }

            return quantidadeKm;
        }

        private double ObtemValorPonteiro()
        {
            if (cmbLitros.SelectedItem != null)
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
            if (Locacao != null)
                CalculaValorTotal();
        }

        private void txtKmFinal_TextChanged(object sender, EventArgs e)
        {
            if (Locacao != null)
                CalculaValorTotal();
        }
    }
}
