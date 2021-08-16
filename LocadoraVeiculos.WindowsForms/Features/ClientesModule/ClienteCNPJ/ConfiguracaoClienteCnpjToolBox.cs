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
        public string ToolTipAdicionar { get { return "Cadastrar Cliente Jurídico"; }}
        public string TipoCadastro { get { return "Cliente Jurídico"; } }

        public string ToolTipEditar { get { return "Editar Cliente Jurídico"; } }

        public string ToolTipExcluir { get { return "Excluir Cliente Jurídico"; } }

        public string ToolTipFiltro { get { return "Não disponível"; } }

        public string ToolTipAgrupar { get { return "Não disponível"; } }

        public string ToolTipDesAgrupar { get { return "Não disponível"; } }
    
    }
}
