using LocadoraVeiculos.WindowsForms.Shared;

namespace LocadoraVeiculos.WindowsForms.ClientePessoaFisica
{
    public class ConfiguracaoClientePfToolBox : IConfiguracaoToolBox
    {
        public string ToolTipAdicionar
        {
            get { return "Cadastrar Clientes Físicos"; }
        }
        public string TipoCadastro { get { return "Cadastro de Clientes Físicos"; } }

        public string ToolTipEditar { get { return "Editar um Cliente Físico"; } }

        public string ToolTipExcluir { get { return "Excluir um Cliente Físico"; } }

        public string ToolTipFiltro { get { return "Não disponível"; } }

        public string ToolTipAgrupar { get { return "Não disponível"; } }

        public string ToolTipDesAgrupar { get { return "Não disponível"; } }    
    
    }
}
