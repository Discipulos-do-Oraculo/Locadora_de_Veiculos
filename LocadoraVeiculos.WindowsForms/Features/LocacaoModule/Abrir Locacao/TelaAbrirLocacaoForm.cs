using LocadoraVeiculo.Dominio.ClienteModule;
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
using System.Drawing;
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
        public List<TaxasEServicos> Taxas { get => taxas; set => taxas = value; }

        public Locacao Locacao
        {
            get { return locacao; }
            set
            {
                locacao = value;
                if(locacao.Empresa != null)
                {
                    pessoaPJ = locacao.Empresa;
                    lblPessoa.Text = locacao.Empresa.Nome;
                }
                if(locacao.Condutor != null)
                {
                    condutor = locacao.Condutor;
                    lblPessoa.Text = locacao.Condutor.Nome;
                    lblCondutor.Text = locacao.Condutor.Nome;
                }
                veiculo = locacao.Veiculo;
                id = Convert.ToInt32(locacao.Id);
                textBoxId.Text = locacao.Id.ToString();
                lblVeiculo.Text = locacao.Veiculo.NomeVeiculo;
                cmbPlanos.SelectedItem = locacao.Plano;
                txtKmInicial.Text = locacao.KmInicial.ToString();
                dateTimePickerSaida.Value = locacao.DataSaida;
                dateTimePickerRetorno.Value = locacao.DataRetorno;
                dateTimePickerRetorno.Enabled = false;
                txtValorTotal.Text = locacao.ValorTotal.ToString();
                txtCaucao.Text = locacao.Caucao.ToString();

                btnSelecionarCondutor.Enabled = false;
                btnSelecionarPessoa.Enabled = false;
                btnSelecionarVeiculo.Enabled = false;
                cmbPlanos.Enabled = false;
                txtCaucao.Enabled = false;
                txtCaucao.BackColor = Color.FromArgb(67,68,69);

            }
        }


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
            {
                labelVeiculo.Text = veiculo.NomeVeiculo;
                txtKmInicial.Text = veiculo.KmAtual.ToString();
                CalcularValorFinal();
            }
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

            if (cmbPlanos.SelectedItem != null && veiculo != null && cmbPlanos.SelectedItem.ToString() == "Km Controlado")
            {
                valorPlano = 0 * CalculoDatas();
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
            TimeSpan resultado;

            if (dataRetorno > dataSaida)
            {
                resultado = dataRetorno.Date - dataSaida.Date;
            }
            else
            {
                resultado = dataSaida.Date - dataRetorno.Date;
            }

            int calculoDias = resultado.Days;

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
                locacao = new Locacao(pessoaPF,veiculo, plano, dataSaida, dataRetorno, valorFinal, valorCaucao, kmInicial);
                locacao.Validar();
            }
            if (locacao.Veiculo != null && controladorLocacao.VerificaVeiculoLocado(locacao.Veiculo.Id, id))
            {
                resultadoValidacao = "Veiculo ja locado";
                FormatarRodape(resultadoValidacao);

            }
            if (locacao.Caucao == default)
            {
                resultadoValidacao = "O valor de garantia é obrigatório";
            }
            if (cmbPlanos.SelectedItem == null)
            {
                resultadoValidacao = "selecione um plano para locação";
            }
            if (locacao.Veiculo == null)
            {
                resultadoValidacao = "selecione um veículo para locação";
                FormatarRodape(resultadoValidacao);
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

        }

        private void FormatarRodape(string resultadoValidacao)
        {
            string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

            TelaInicial.Instancia.AtualizarRodape(primeiroErro);

            DialogResult = DialogResult.None;
        }

        private void txtCaucao_Leave(object sender, EventArgs e)
        {
            if (txtCaucao.Text != "")
                txtCaucao.Text = String.Format("{0:#,##0.00##}", double.Parse(txtCaucao.Text));
        }

        private void txtValorTotal_TextChanged(object sender, EventArgs e)
        {
            if (txtValorTotal.Text != "")
                txtValorTotal.Text = String.Format("{0:#,##0.00##}", double.Parse(txtValorTotal.Text));
        }

        private void txtCaucao_TextChanged(object sender, EventArgs e)
        {
            if (txtCaucao.Text != "")
                txtCaucao.Text = String.Format("{0:#,##0.00##}", double.Parse(txtCaucao.Text));
        }

    }
}
