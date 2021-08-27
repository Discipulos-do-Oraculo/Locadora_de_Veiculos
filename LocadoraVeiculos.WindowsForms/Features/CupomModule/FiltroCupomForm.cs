using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.Features.CupomModule
{
    public partial class FiltroCupomForm : Form
    {
        public FiltroCupomForm()
        {
            InitializeComponent();
        }

        public FiltroCupomEnum TipoFiltro
        {
            get
            {
                if (rbdPorParceiro.Checked == true)
                    return FiltroCupomEnum.AgruparPorParceiro;

                else if (rdbNaoAgrupar.Checked == true)
                    return FiltroCupomEnum.NaoAgrupar;
                
                return FiltroCupomEnum.NaoAgrupar;
            }
        }
    }
}
