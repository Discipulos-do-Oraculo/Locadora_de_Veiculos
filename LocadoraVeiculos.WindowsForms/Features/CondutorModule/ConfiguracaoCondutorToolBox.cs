using LocadoraVeiculos.WindowsForms.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.WindowsForms.Features.CondutorForm
{
    public class ConfiguracaoCondutorToolBox : IConfiguracaoToolBox
    {
        public string ToolTipAdicionar { get { return "Cadastrar Condutor"; }}
        public string TipoCadastro { get { return "Condutor"; } }

        public string ToolTipEditar { get { return "Editar Condutor"; } }

        public string ToolTipExcluir { get { return "Excluir Condutor"; } }

        public string ToolTipFiltro { get { return "Filtrar Condutor"; } }

        public string ToolTipAgrupar { get { return "Não disponível"; } }

        public string ToolTipDesAgrupar { get { return "Não disponível"; } }   
    
    }
}
