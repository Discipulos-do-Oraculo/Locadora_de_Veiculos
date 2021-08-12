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
        public string ToolTipAdicionar { get { return "Cadastrar Cliente CNPJ"; }}
        public string TipoCadastro { get { return "Cadastro Cliente CNPJ"; } }

        public string ToolTipEditar { get { return "Editar um Cliente CNPJ"; } }

        public string ToolTipExcluir { get { return "Excluir um Cliente CNPJ"; } }

        public string ToolTipFiltro { get { return "Não disponível"; } }

        public string ToolTipAgrupar { get { return "Não disponível"; } }

        public string ToolTipDesAgrupar { get { return "Não disponível"; } }
    
    }
}
