using LocadoraVeiculo.Dominio.PlanoLocacaoModule;
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

namespace LocadoraVeiculos.WindowsForms.Features.LocacaoModule.PlanosDeLocacao
{
    public partial class TelaPlanosDeLocacaoForm : Form
    {
        private PlanoDeLocacao planoDeLocacao;

        public PlanoDeLocacao PlanoDeLocacao
        {
            get { return planoDeLocacao; }
            set
            {
                planoDeLocacao = value;

                textBoxId.Text = planoDeLocacao.Id.ToString();
                txtTitulo.Text = planoDeLocacao.Titulo;
                textBoxValor.Text = planoDeLocacao.Valor.ToString();
                txtDescricao.Text = planoDeLocacao.Descricao;
                FormatandoCampoValor();
            }
        }

        public TelaPlanosDeLocacaoForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            double valor = default;
            string titulo = txtTitulo.Text;
            string descricao = txtDescricao.Text;

            if (textBoxValor.Text != "")
                valor = Convert.ToDouble(textBoxValor.Text);
            


            planoDeLocacao = new PlanoDeLocacao(titulo, valor, descricao);

            string resultadoValidacao = planoDeLocacao.Validar();

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

        private void textBoxValor_Leave(object sender, EventArgs e)
        {
            FormatandoCampoValor();
        }

        private void FormatandoCampoValor()
        {
            if (textBoxValor.Text != "")
                textBoxValor.Text = String.Format("{0:#,##0.00##}", double.Parse(textBoxValor.Text));
        }

        private void textBoxValor_Leave_1(object sender, EventArgs e)
        {
            FormatandoCampoValor();
        }
    }
}
