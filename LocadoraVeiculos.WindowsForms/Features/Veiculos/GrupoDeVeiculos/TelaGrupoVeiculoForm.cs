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
                textBoxValor.Text = grupoDeVeiculos.Valor.ToString();

            }
        }

        public TelaGrupoVeiculoForm()
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
            

            grupoDeVeiculos = new GrupoDeVeiculos(nome, valor);

            string resultadoValidacao = grupoDeVeiculos.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                TelaInicial.Instancia.AtualizarRodape(primeiroErro);

                DialogResult = DialogResult.None;
            }
        }
    }
}
