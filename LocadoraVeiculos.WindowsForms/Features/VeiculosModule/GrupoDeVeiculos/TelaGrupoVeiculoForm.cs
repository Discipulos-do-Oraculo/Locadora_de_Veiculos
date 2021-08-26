using LocadoraVeiculo.Dominio.GrupoDeVeiculosModule;
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

namespace LocadoraVeiculos.WindowsForms.Features.Veiculos
{
    public partial class TelaGrupoVeiculoForm : Form
    {
        private GrupoDeVeiculos grupoDeVeiculos;
        public GrupoDeVeiculos GrupoDeVeiculos
        {
            get { return grupoDeVeiculos; }
            set
            {
                grupoDeVeiculos = value;

                textBoxId.Text = grupoDeVeiculos.Id.ToString();
                textBoxNome.Text = grupoDeVeiculos.Nome;
                textBoxValorDiaria.Text = grupoDeVeiculos.ValorDiaria.ToString();
                textBoxValorKmDiario.Text = grupoDeVeiculos.ValorKmDiaria.ToString();
                textBoxLimiteKmControlado.Text = grupoDeVeiculos.LimiteKmControlado.ToString();
                textBoxValorKmControlado.Text = grupoDeVeiculos.ValorKmControlado.ToString();
                textBoxValorDiariaLivre.Text = grupoDeVeiculos.ValorKmLivre.ToString();
                textBoxValorDiariaKmControlado.Text = grupoDeVeiculos.ValorDiariaKmControlado.ToString();
                FormatandoCampoValor();

            }
        }

        public TelaGrupoVeiculoForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            double valorDiaria = default;
            double valorKmDiario = default;
            double valorLimiteKmControlado = default;
            double valorKmControlado = default;
            double valorKmLivre = default;
            double valorDiariaKmControlado = default;
            string nome = textBoxNome.Text;
            if (textBoxValorDiaria.Text != "")
                valorDiaria = Convert.ToDouble(textBoxValorDiaria.Text);
            if(textBoxValorDiariaLivre.Text != "")
                valorKmDiario = Convert.ToDouble(textBoxValorKmDiario.Text);
            if (textBoxValorKmControlado.Text != "")
                valorKmControlado = Convert.ToDouble(textBoxValorKmControlado.Text);
            if (textBoxLimiteKmControlado.Text != "")
                valorLimiteKmControlado = Convert.ToDouble(textBoxLimiteKmControlado.Text);
            if (textBoxValorDiariaLivre.Text != "")
                valorKmLivre = Convert.ToDouble(textBoxValorDiariaLivre.Text);
            if (textBoxValorDiariaKmControlado.Text != "")
                valorDiariaKmControlado = Convert.ToDouble(textBoxValorDiariaKmControlado.Text);
            grupoDeVeiculos = new GrupoDeVeiculos(nome, valorDiaria, valorKmDiario, valorKmLivre, valorLimiteKmControlado, valorKmControlado, valorDiariaKmControlado);

            string resultadoValidacao = grupoDeVeiculos.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                TelaInicial.Instancia.AtualizarRodape(primeiroErro);

                DialogResult = DialogResult.None;
            }
        }

        private void textBoxValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void ApenasNumeros(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void FormatandoCampoValor()
        {
           

            if (textBoxValorDiaria.Text != "")
                textBoxValorDiaria.Text = String.Format("{0:#,##0.00##}", double.Parse(textBoxValorDiaria.Text));

            if (textBoxValorDiariaKmControlado.Text != "")
                textBoxValorDiariaKmControlado.Text = String.Format("{0:#,##0.00##}", double.Parse(textBoxValorDiariaKmControlado.Text));

            if (textBoxValorKmControlado.Text != "")
                textBoxValorKmControlado.Text = String.Format("{0:#,##0.00##}", double.Parse(textBoxValorKmControlado.Text));

            if (textBoxValorDiariaLivre.Text != "")
                textBoxValorDiariaLivre.Text = String.Format("{0:#,##0.00##}", double.Parse(textBoxValorKmDiario.Text));

            if (textBoxValorKmLivre.Text != "")
                textBoxValorKmLivre.Text = String.Format("{0:#,##0.00##}", double.Parse(textBoxValorKmLivre.Text));

        }

        private void textBoxValorDiaria_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasNumeros(e);
        }

        private void textBoxValorKmDiario_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasNumeros(e);
        }

        private void textBoxLimiteKmControlado_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasNumeros(e);
        }

        private void textBoxValorKmControlado_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasNumeros(e);
        }

        private void textBoxValorKmLivre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasNumeros(e);
        }

        private void textBoxValorDiaria_Leave(object sender, EventArgs e)
        {
            FormatandoCampoValor();
        }

        private void textBoxValorKmDiario_Leave(object sender, EventArgs e)
        {
            FormatandoCampoValor();
        }

        private void textBoxValorKmControlado_Leave(object sender, EventArgs e)
        {
            FormatandoCampoValor();
        }

        private void textBoxValorKmLivre_Leave(object sender, EventArgs e)
        {
            FormatandoCampoValor();
        }

        private void textBoxValorDiariaLivre_Leave(object sender, EventArgs e)
        {
            FormatandoCampoValor();
        }

        private void TelaGrupoVeiculoForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasNumeros(e);
        }

        private void textBoxValorDiariaKmControlado_Leave(object sender, EventArgs e)
        {
            FormatandoCampoValor();
        }

        private void textBoxValorDiariaKmControlado_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasNumeros(e);
        }
    }
}
