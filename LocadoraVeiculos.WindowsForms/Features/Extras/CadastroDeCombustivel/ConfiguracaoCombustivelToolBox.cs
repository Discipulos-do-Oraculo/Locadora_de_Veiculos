using LocadoraVeiculos.WindowsForms.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.WindowsForms.Features.Extras.CadastroDeCombustivel
{
    public class ConfiguracaoCombustivelToolBox : IConfiguracaoToolBox
    {
        public string ToolTipAdicionar {get { return "Cadastro Combustível"; } }

        public string TipoCadastro { get { return "Cadastro de Combustível"; } }

        public string ToolTipEditar { get { return "Editar Combustível"; } }

        public string ToolTipExcluir { get { return "Não disponível"; } }

        public string ToolTipFiltro { get { return "Não disponível"; } }

        public string ToolTipAgrupar { get { return "Não disponível"; } }

        public string ToolTipDesAgrupar { get { return "Não disponível"; } }
    }
}
