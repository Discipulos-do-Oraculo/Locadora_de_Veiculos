﻿using LocadoraVeiculo.Dominio.ClienteModule;
using LocadoraVeiculo.Dominio.LocacaoModule;
using LocadoraVeiculo.Dominio.TaxasEServicosModule;
using LocadoraVeiculo.Dominio.VeiculoModule;
using LocadoraVeiculos.Controlador.ClienteModule.ClienteCnpjControlador;
using LocadoraVeiculos.Controlador.ClienteModule.ClientePfControlador;
using LocadoraVeiculos.Controlador.ClienteModule.CondutorControlador;
using LocadoraVeiculos.Controlador.LocacaoModule;
using LocadoraVeiculos.Controlador.TaxasEServicosModule;
using LocadoraVeiculos.Controlador.VeiculoModule;
using LocadoraVeiculos.WindowsForms.ClientePessoaFisica;
using LocadoraVeiculos.WindowsForms.Features.Clientes.ClienteCNPJ;
using LocadoraVeiculos.WindowsForms.Features.CondutorForm;
using LocadoraVeiculos.WindowsForms.Features.Extras.CadastroDeTaxasEServicos;
using LocadoraVeiculos.WindowsForms.Features.Veiculos.CadastroDeVeiculos;
using LocadoraVeiculos.WindowsForms.Shared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.Features.LocacaoModule.Abrir_Locacao
{
    public partial class TelaAbrirLocacaoForm : Form
    {

        private ControladorCondutor controladorConcdutor;
        private ICadastravel operacoes;
        private Veiculo veiculo = null;
        private ClienteCnpj pessoaPJ = null;
        private ClientePF pessoaPF = null;
        private Condutor condutor = null;
        private double valorPlano;
        private double valorFinal;
        private List<TaxasEServicos> taxas;
        private ControladorLocacao controladorLocacao;
        private Locacao locacao = null;
        private int id;
        public Locacao Locacao { get => locacao; set => locacao = value; }
        public List<TaxasEServicos> Taxas { get => taxas; set => taxas = value; }

        public TelaAbrirLocacaoForm()
        {
            controladorLocacao = new ControladorLocacao();
            controladorConcdutor = new ControladorCondutor();
            InitializeComponent();

        }

        private void btnSelecionarTaxas_Click(object sender, EventArgs e)
        {
            TelaTaxasEServicosForm telaTaxa = new TelaTaxasEServicosForm(Taxas);
            telaTaxa.ShowDialog();
            Taxas = telaTaxa.TaxasSelecionadas;
            if (Taxas != null)
            {
                btnSelecionarTaxas.Text = "Clique para Editar";
                CalcularValorFinal();
            }
        }

        private void btnSelecionarVeiculo_Click(object sender, EventArgs e)
        {

            operacoes = new OperacoesVeiculo(new ControladorVeiculo());

            TelaSelecionaVeiculoForm telaVeiculo = new TelaSelecionaVeiculoForm(operacoes);
            telaVeiculo.ShowDialog();
            veiculo = telaVeiculo.Veiculo;

            if (veiculo != null)
                labelVeiculo.Text = veiculo.NomeVeiculo;
            txtKmInicial.Text = veiculo.KmAtual.ToString();
            CalcularValorFinal();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ICadastravel operacoesPF = new OperacoesClientePF(new ControladorClientePF());
            ICadastravel operacoesPJ = new OperacoesClienteCnpj(new ControladorClienteCnpj());

            TelaSelecionarPessoaForm telaPessoa = new TelaSelecionarPessoaForm(operacoesPF, operacoesPJ);
            telaPessoa.ShowDialog();

            pessoaPF = telaPessoa.PessoaPF;
            pessoaPJ = telaPessoa.PessoaPJ;

            if (pessoaPF != null)
            {
                lblPessoa.Text = pessoaPF.Nome;
                lblCondutor.Text = pessoaPF.Nome;
                btnSelecionarCondutor.Enabled = false;

            }
            else if (pessoaPJ != null)
            {
                lblPessoa.Text = pessoaPJ.Nome;
                lblCondutor.Text = String.Empty;
                btnSelecionarCondutor.Enabled = true;

            }

        }

        private void btnCondutor_Click(object sender, EventArgs e)
        {

            OperacaoCondutor operacaoCondutor = new OperacaoCondutor(controladorConcdutor);
            int empresaSelecioanda = pessoaPJ.Id;

            TelaSelecionarCondutor telaCondutor = new TelaSelecionarCondutor(operacaoCondutor, empresaSelecioanda);
            telaCondutor.ShowDialog();

            condutor = telaCondutor.Condutor;

            if (condutor != null)
            {
                lblCondutor.Text = condutor.Nome;
            }

        }

        private void cmbPlanos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularValorFinal();
        }

        private double CalcularValorPlano()
        {
            if (cmbPlanos.SelectedItem != null && veiculo != null && cmbPlanos.SelectedItem.ToString() == "Diário")
            {
                valorPlano = veiculo.GrupoDeVeiculos.ValorDiaria * CalculoDatas();
            }

            if (cmbPlanos.SelectedItem != null && veiculo != null && cmbPlanos.SelectedItem.ToString() == "Km Livre")
            {
                valorPlano = veiculo.GrupoDeVeiculos.ValorKmLivre * CalculoDatas();

            }

            return valorPlano;
        }

        private double CalcularValorTaxas()
        {
            double valorTaxas = default;

            if (Taxas != null)
            {
                foreach (var taxa in Taxas)
                {
                    if (taxa.CalculoDiario)
                    {
                        int dias = CalculoDatas();
                        valorTaxas += taxa.Valor * dias;

                    }
                    else if (taxa.CalculoFixo)
                    {
                        valorTaxas += taxa.Valor;

                    }
                }
            }

            return valorTaxas;
        }

        private void CalcularValorFinal()
        {

            double taxasEServicos = CalcularValorTaxas();
            double plano = CalcularValorPlano();


            valorFinal = plano + taxasEServicos;

            txtValorTotal.Text = valorFinal.ToString();
        }

        private int CalculoDatas()
        {
            DateTime dataSaida = dateTimePickerSaida.Value;
            DateTime dataRetorno = dateTimePickerRetorno.Value;
            int calculoDias = default;

            if (dataRetorno.Day > dataSaida.Day)
            {
                calculoDias = dataRetorno.Day - dataSaida.Day;
            }
            else
            {
                calculoDias = dataSaida.Day - dataRetorno.Day;
            }

            return calculoDias;
        }

        private void dateTimePickerRetorno_ValueChanged(object sender, EventArgs e)
        {
            CalcularValorFinal();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            DateTime dataSaida = dateTimePickerSaida.Value;
            DateTime dataRetorno = dateTimePickerRetorno.Value;
            double valorCaucao = default;
            int kmInicial = default;
            string plano = String.Empty;
            string resultadoValidacao = "ESTA_VALIDO";

            if (txtCaucao.Text != "")
            {
                valorCaucao = Convert.ToDouble(txtCaucao.Text);
            }
            if (txtKmInicial.Text != "")
            {
                kmInicial = Convert.ToInt32(txtKmInicial.Text);
            }
            if (cmbPlanos.SelectedItem != null)
            {
                plano = cmbPlanos.SelectedItem.ToString();
            }
            if (pessoaPJ != null)
            {
                locacao = new Locacao(pessoaPJ, condutor, veiculo, plano, dataSaida, dataRetorno, valorFinal, valorCaucao, kmInicial);
                locacao.Validar();
            }
            if (pessoaPJ == null)
            {
                locacao = new Locacao(pessoaPF, veiculo, plano, dataSaida, dataRetorno, valorFinal, valorCaucao, kmInicial);
                locacao.Validar();
            }

            if (lblCondutor.Text == "")
            {
                resultadoValidacao = "selecione o condutor para locação";
            }

            if (lblPessoa.Text == "")
            {
                resultadoValidacao = "selecione a pessoa para locação";
            }

            if (locacao != null && resultadoValidacao != "ESTA_VALIDO")
            {
                FormatarRodape(resultadoValidacao);

            }

            if (locacao != null && controladorLocacao.VerificaVeiculoLocado(locacao.Veiculo.Id, id))
            {
                resultadoValidacao = "Veiculo ja locado";
                FormatarRodape(resultadoValidacao);

            }

        }

        private void FormatarRodape(string resultadoValidacao)
        {
            string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

            TelaInicial.Instancia.AtualizarRodape(primeiroErro);

            DialogResult = DialogResult.None;
        }

        private void TelaAbrirLocacaoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
