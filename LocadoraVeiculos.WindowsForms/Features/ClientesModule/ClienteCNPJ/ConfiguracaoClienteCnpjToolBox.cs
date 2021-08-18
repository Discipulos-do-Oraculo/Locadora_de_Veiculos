using LocadoraVeiculos.WindowsForms.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.WindowsForms.Features.ClienteCNPJ
{
    public class ConfiguracaoClienteCnpjToolBox : IConfiguracaoToolBox
    {
        public string ToolTipAdicionar { get { return "Cadastrar Pessoa Jurídica"; }}
        public string TipoCadastro { get { return "Pessoa Jurídica"; } }

        public string ToolTipEditar { get { return "Editar Pessoa Jurídica"; } }

        public string ToolTipExcluir { get { return "Excluir Pessoa Jurídica"; } }

        public string ToolTipFiltro { get { return "Não disponível"; } }

        public string ToolTipAgrupar { get { return "Não disponível"; } }

        public string ToolTipDesAgrupar { get { return "Não disponível"; } }
    
    }
}
