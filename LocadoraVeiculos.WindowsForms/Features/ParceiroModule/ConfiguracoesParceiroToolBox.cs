using LocadoraVeiculos.WindowsForms.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.WindowsForms.Features.ParceiroModule
{
    public class ConfiguracoesParceiroToolBox : IConfiguracaoToolBox
    {
        public string ToolTipAdicionar { get { return "Cadastrar Parceiro"; } }

        public string TipoCadastro { get { return "Parceiros"; } }

        public string ToolTipEditar { get { return "Editar Parceiro"; } }

        public string ToolTipExcluir { get { return "Excluir Parceiro"; } }

        public string ToolTipFiltro { get { return "Não disponível"; } }

        public string ToolTipAgrupar { get { return "Não disponível"; } }

        public string ToolTipDesAgrupar { get { return "Não disponível"; } }

    }
}
