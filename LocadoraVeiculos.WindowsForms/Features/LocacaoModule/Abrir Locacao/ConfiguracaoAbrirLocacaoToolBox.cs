using LocadoraVeiculos.WindowsForms.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.WindowsForms.Features.LocacaoModule.Abrir_Locacao
{
    public class ConfiguracaoAbrirLocacaoToolBox : IConfiguracaoToolBox
    {
        public string ToolTipAdicionar { get { return "Abrir Locação"; } }

        public string TipoCadastro { get { return "Abrir Locação"; } }

        public string ToolTipEditar { get { return "Editar Locação"; } }

        public string ToolTipExcluir { get { return "Não disponível"; } }

        public string ToolTipFiltro { get { return "Filtar Locações"; } }

        public string ToolTipAgrupar { get { return "Não disponível"; } }

        public string ToolTipDesAgrupar { get { return "Não disponível"; } }
    }
}
