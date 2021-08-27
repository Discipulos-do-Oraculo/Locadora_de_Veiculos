using LocadoraVeiculo.Dominio.CupomModule;
using LocadoraVeiculos.Controlador.CupomModule;
using LocadoraVeiculos.WindowsForms.Features.CupomModule;
using LocadoraVeiculos.WindowsForms.Features.ParceiroModule;
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

namespace LocadoraVeiculos.WindowsForms
{
    public partial class TelaCupomForm : Form
    {
        private Cupom cupom = null;
        private Parceiro parceiro = null;
        private ICadastravel operacoes;

        public TelaCupomForm()
        {
            InitializeComponent();
        }
        public Cupom Cupom
        {
            get { return cupom; }
            set
            {
                cupom = value;
                if (cupom.Parceiro != null)
                {
                    parceiro = cupom.Parceiro;
                    lblParceiro.Text = cupom.Parceiro.Nome;
                }

                textBoxId.Text = cupom.Id.ToString();
                txtNome.Text = cupom.Nome;
                dtpInicio.Value = cupom.DataInicio;
                dtpFinal.Value = cupom.DataFinal;
                txtValor.Text = cupom.Valor.ToString();
                txtValorMinimo.Text = cupom.ValorMinimo.ToString();
                if (cupom.CalculoPorcentagem)
                {
                    rdbCalculoPorcentagem.Checked = true;
                    rdbCalculoReal.Checked = false;
                }
                    
                else if (cupom.CalculoReal)
                {
                    rdbCalculoReal.Checked = true;
                    rdbCalculoPorcentagem.Checked = false;
                }
                    
            }
        }

        private void rdbCalculoPorcentagem_Click(object sender, EventArgs e)
        {
            rdbCalculoReal.Checked = false;
            rdbCalculoPorcentagem.Checked = true;
        }

        private void rdbCalculoReal_Click(object sender, EventArgs e)
        {
            rdbCalculoPorcentagem.Checked = false;
            rdbCalculoReal.Checked = true;
        }

        private void txtValorMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string resultadoValidacao = "ESTA_VALIDO";
            DateTime dataInicio = dtpInicio.Value;
            DateTime dataFinal = dtpFinal.Value;
            string nome = txtNome.Text;
            double valor = Convert.ToDouble(txtValor.Text);
            double valorMinimo = Convert.ToDouble(txtValorMinimo.Text);
            bool calculoPorcentagem = default, calculoReal = default;

            if (rdbCalculoPorcentagem.Checked)
            {
                calculoPorcentagem = true;
                calculoReal = false;
            }

            else
            {
                calculoReal = true;
                calculoPorcentagem = false;
            }              

            if (lblParceiro.Text == "")
                resultadoValidacao = "selecione um parceiro para cadastrar cupom";
            
            if(parceiro != null)
            {
                cupom = new Cupom(nome, dataInicio, dataFinal, parceiro, valor, valorMinimo, calculoReal, calculoPorcentagem);
                resultadoValidacao = parceiro.Validar();
            }
            if (cupom != null && resultadoValidacao != "ESTA_VALIDO")
                FormatarRodape(resultadoValidacao);

        }

        private void FormatarRodape(string resultadoValidacao)
        {
            string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

            TelaInicial.Instancia.AtualizarRodape(primeiroErro);

            DialogResult = DialogResult.None;
        }

        private void btnSelecionarParceiro_Click(object sender, EventArgs e)
        {
            operacoes = new OperacoesParceiro(new ControladorParceiro());

            TelaSelecionarParceiroForm telaParceiro = new TelaSelecionarParceiroForm(operacoes);
            telaParceiro.ShowDialog();
            parceiro = telaParceiro.Parceiro;

            if (parceiro != null)
                lblParceiro.Text = parceiro.Nome;
            
        }
    }
}