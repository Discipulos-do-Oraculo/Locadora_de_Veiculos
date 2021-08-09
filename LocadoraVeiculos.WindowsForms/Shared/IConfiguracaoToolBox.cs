using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.WindowsForms.Shared
{
    public interface IConfiguracaoToolBox
    {
        string TipoCadastro { get; }
        string ToolTipEditar { get; }
        string ToolTipExcluir { get; }
        string ToolTipFiltro { get; }
        string ToolTipAgrupar { get; }
        string ToolTipDesAgrupar { get; }
    }
}
