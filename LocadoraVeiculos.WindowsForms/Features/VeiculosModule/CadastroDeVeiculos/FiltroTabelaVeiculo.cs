using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.Features.VeiculosModule.CadastroDeVeiculos
{
    public partial class FiltroTabelaVeiculo : Form
    {

        public FiltroTabelaVeiculo()
        {
            InitializeComponent();
            
        }

        public FiltroVeiculoEnum TipoFiltro
        {
            get
            {
                if (rdbAgruparPorGrupo.Checked ==true)
                    return FiltroVeiculoEnum.AgruparPorGrupo;
                else if (rdbNaoAgrupar.Checked == true)
                {
                    return FiltroVeiculoEnum.NaoAgrupar;
                }
                return FiltroVeiculoEnum.NaoAgrupar;
            }
        }

        private void FiltroTabelaVeiculo_Load(object sender, EventArgs e)
        {
            rdbAgruparPorGrupo.Checked = false;
            rdbNaoAgrupar.Checked = false;
        }
    }
}
