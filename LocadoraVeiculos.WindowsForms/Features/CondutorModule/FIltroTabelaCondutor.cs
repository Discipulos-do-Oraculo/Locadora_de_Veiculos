using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.Features.CondutorModule
{
    public partial class FIltroTabelaCondutor : Form
    {
        public FIltroTabelaCondutor()
        {
            InitializeComponent();
        }

        public FiltroCondutorEnum TipoFiltro
        {
            get
            {
                if (rdbAgruparPorGrupo.Checked == true)
                    return FiltroCondutorEnum.AgruparPorGrupo;
                else if (rdbNaoAgrupar.Checked == true)
                {
                    return FiltroCondutorEnum.NaoAgrupar;
                }
                return FiltroCondutorEnum.NaoAgrupar;
            }
        }
    }
}
