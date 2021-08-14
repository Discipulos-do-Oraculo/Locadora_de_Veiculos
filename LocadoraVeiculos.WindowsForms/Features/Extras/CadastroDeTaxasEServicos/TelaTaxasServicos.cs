using LocadoraVeiculo.Dominio.TaxasEServicosModule;
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

namespace LocadoraVeiculos.WindowsForms.Features.Extras
{
    public partial class TelaTaxasServicos : Form
    {
        private TaxasEServicos taxaEServico;
        public TaxasEServicos TaxaEServico
        {
            get { return taxaEServico; }
            set
            {
                taxaEServico = value;

                textBoxId.Text = taxaEServico.Id.ToString();
                textBoxNome.Text = taxaEServico.Nome;
                textBoxValor.Text = taxaEServico.Valor.ToString();
                if(taxaEServico.CalculoDiario == true)
                {
                    radioFixo.Checked = false;
                    radioDiaria.Checked = true;
                }
                else if(taxaEServico.CalculoFixo == true)
                {
                    radioDiaria.Checked = false;
                    radioFixo.Checked = true;
                }
            }
        }


        public TelaTaxasServicos()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            double valor = default;
            bool calculoDiario = false;
            bool calculoFixo = false;
            string nome = textBoxNome.Text;
            if (textBoxValor.Text != "")
            {
                valor = Convert.ToDouble(textBoxValor.Text);
            }
            if (radioDiaria.Checked)
            {
                calculoDiario = true;
            }

            if (radioFixo.Checked)
            {
                calculoFixo = true;
            }

            taxaEServico = new TaxasEServicos(nome, valor, calculoDiario, calculoFixo);

            string resultadoValidacao = taxaEServico.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                TelaInicial.Instancia.AtualizarRodape(primeiroErro);

                DialogResult = DialogResult.None;
            }
        }
    }
}
