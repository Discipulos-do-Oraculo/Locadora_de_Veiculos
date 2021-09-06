using LocadoraVeiculos.WindowsForms.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.WindowsForms.Features.CupomModule
{
    public class ConfiguracoesCupomUtilizadosToolBox : IConfiguracaoToolBox
    {
        public string ToolTipAdicionar { get { return "Não disponível"; } }
        public string TipoCadastro { get { return "Cupons Mais Utilizados"; } }

        public string ToolTipEditar { get { return "Não disponível"; } }

        public string ToolTipExcluir { get { return "Não disponível"; } }

        public string ToolTipFiltro { get { return "Não disponível"; } }

        public string ToolTipAgrupar { get { return "Não disponível"; } }

        public string ToolTipDesAgrupar { get { return "Não disponível"; } }

    }
}
