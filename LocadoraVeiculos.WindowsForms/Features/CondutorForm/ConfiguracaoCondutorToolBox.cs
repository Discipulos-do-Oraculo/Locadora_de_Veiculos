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
        public string ToolTipAdicionar { get { return "Cadastrar Condutores"; }}
        public string TipoCadastro { get { return "Cadastro Condutor"; } }

        public string ToolTipEditar { get { return "Editar um Condutor"; } }

        public string ToolTipExcluir { get { return "Excluir um Condutor"; } }

        public string ToolTipFiltro { get { return "Não disponível"; } }

        public string ToolTipAgrupar { get { return "Não disponível"; } }

        public string ToolTipDesAgrupar { get { return "Não disponível"; } }   
    
    }
}
