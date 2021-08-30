using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.Features.DevolucaoModule
{
    public partial class FiltroLocacaoCupomForm : Form
    {
        public FiltroLocacaoCupomForm()
        {
            InitializeComponent();
        }

        public FiltroLocacaoCupomEnum TipoFiltro
        {
            get
            {
                if (rbdPorCupom.Checked == true)
                    return FiltroLocacaoCupomEnum.AgruparPorCupomUtilizado;

                else if (rdbNaoAgrupar.Checked == true)
                    return FiltroLocacaoCupomEnum.NaoAgrupar;

                return FiltroLocacaoCupomEnum.NaoAgrupar;
            }
        }
    }
}
