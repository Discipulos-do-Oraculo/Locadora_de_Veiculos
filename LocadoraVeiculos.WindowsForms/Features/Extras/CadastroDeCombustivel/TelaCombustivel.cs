using LocadoraVeiculo.Dominio.CombustivelModule;
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
    public partial class TelaCombustivel : Form
    {
        private Combustivel combustivel;
        public Combustivel Combustivel
        {
            get { return combustivel; }
            set
            {
                combustivel = value;

                textBoxId.Text = combustivel.Id.ToString();
                textBoxNome.Text = combustivel.Nome;
                textBoxValor.Text = combustivel.Valor.ToString();

            }
        }

        public TelaCombustivel()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            double valor = default;
            string nome = textBoxNome.Text;
            if (textBoxValor.Text != "")
            {
                valor = Convert.ToDouble(textBoxValor.Text);
            }


            combustivel = new Combustivel(nome, valor);

            string resultadoValidacao = combustivel.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                TelaInicial.Instancia.AtualizarRodape(primeiroErro);

                DialogResult = DialogResult.None;
            }
        }
    }
}
