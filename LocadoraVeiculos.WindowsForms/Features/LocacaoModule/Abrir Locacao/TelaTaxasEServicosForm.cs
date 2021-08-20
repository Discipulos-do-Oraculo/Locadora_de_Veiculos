using LocadoraVeiculos.WindowsForms.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.Features.LocacaoModule.Abrir_Locacao
{
    public partial class TelaTaxasEServicosForm : Form
    {
        
        public TelaTaxasEServicosForm()
        {
            InitializeComponent();
        }
        public void ConfigurarPainelRegistros(ICadastravel operacoes)
        {
            UserControl tabela = operacoes.ObterTabela();

            tabela.Dock = DockStyle.Fill;

            panelCentral.Controls.Clear();

            panelCentral.Controls.Add(tabela);
        }
        public List<int> ObterItensSelecionados()
        {
            List<int> result = new List<int>();

            return result;
        }
    }
}
