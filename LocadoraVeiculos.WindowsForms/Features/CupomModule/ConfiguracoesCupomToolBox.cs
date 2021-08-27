using LocadoraVeiculos.WindowsForms.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.WindowsForms.Features.CupomModule
{
    public class ConfiguracoesCupomToolBox : IConfiguracaoToolBox
    {
        public string ToolTipAdicionar { get { return "Cadastrar Cupom"; } }
        public string TipoCadastro { get { return "Cupom"; } }

        public string ToolTipEditar { get { return "Editar Cupom"; } }

        public string ToolTipExcluir { get { return "Excluir Cupom"; } }

        public string ToolTipFiltro { get { return "Filtrar Cupom"; } }

        public string ToolTipAgrupar { get { return "Não disponível"; } }

        public string ToolTipDesAgrupar { get { return "Não disponível"; } }
    
    }
}
