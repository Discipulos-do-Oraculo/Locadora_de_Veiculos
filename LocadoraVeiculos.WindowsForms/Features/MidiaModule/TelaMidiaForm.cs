using LocadoraVeiculo.Dominio.CupomModule;
using LocadoraVeiculos.Controlador.CupomModule;
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

namespace LocadoraVeiculos.WindowsForms.Features.MidiaModule
{
    public partial class TelaMidiaForm : Form
    {
        private Midia midia;

        public TelaMidiaForm()
        {
            InitializeComponent();
        }

        public Midia Midia
        {
            get { return midia; }
            set
            {
                midia = value;

                textBoxId.Text = midia.Id.ToString();
                txtNome.Text = midia.Nome;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            midia = new Midia(nome);

            string resultadoValidacao = midia.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                TelaInicial.Instancia.AtualizarRodape(primeiroErro);

                DialogResult = DialogResult.None;
            }
        }
    }
}
