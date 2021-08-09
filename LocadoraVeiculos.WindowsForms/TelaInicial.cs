using LocadoraVeiculos.WindowsForms.Features.Veiculos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void menuGrupoVeiculos_Click(object sender, EventArgs e)
        {
            barraMenuOpcao.Text = "Opção Selecionada : Grupo de Veiculos";
            panelCentral.Controls.Add(new GrupoDeVeiculos());
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }
    }
}
