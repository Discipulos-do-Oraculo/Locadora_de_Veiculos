using LocadoraVeiculos.WindowsForms.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.WindowsForms.FuncionarioModule
{
    public class ConfiguracaoFuncionarioToolBox : IConfiguracaoToolBox
    {
        public string ToolTipAdicionar { get { return "Cadastrar Funcionário"; }
        }
        public string TipoCadastro { get { return "Cadastro de Funcionários"; } }

        public string ToolTipEditar { get { return "Editar um Funcionário"; } }

        public string ToolTipExcluir { get { return "Excluir um Funcionário"; } }

        public string ToolTipFiltro { get { return " Não disponível"; } }

        public string ToolTipAgrupar { get { return "Não disponível"; } }

        public string ToolTipDesAgrupar { get { return "Não disponível"; } } 
    
    }
}
