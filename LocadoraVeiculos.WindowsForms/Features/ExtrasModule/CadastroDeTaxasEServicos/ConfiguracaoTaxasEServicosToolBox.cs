using LocadoraVeiculos.WindowsForms.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.WindowsForms.Features.Extras.CadastroDeTaxasEServicos
{
    public class ConfiguracaoTaxasEServicosToolBox : IConfiguracaoToolBox
    {
        public string ToolTipAdicionar { get { return "Cadastrar Taxas e Serviços"; } }

        public string TipoCadastro { get { return "Taxas e Serviços"; } }

        public string ToolTipEditar { get { return "Editar Taxas e Serviços"; } }

        public string ToolTipExcluir { get { return "Não disponível"; } }

        public string ToolTipFiltro { get { return "Não disponível"; } }

        public string ToolTipAgrupar { get { return "Não disponível"; } }

        public string ToolTipDesAgrupar { get { return "Não disponível"; } }
    }
}
