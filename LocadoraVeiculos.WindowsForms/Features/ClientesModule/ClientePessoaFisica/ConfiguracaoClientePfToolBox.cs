using LocadoraVeiculos.WindowsForms.Shared;

namespace LocadoraVeiculos.WindowsForms.ClientePessoaFisica
{
    public class ConfiguracaoClientePfToolBox : IConfiguracaoToolBox
    {
        public string ToolTipAdicionar
        {
            get { return "Cadastrar Pessoa Física"; }
        }
        public string TipoCadastro { get { return "Pessoa Física"; } }

        public string ToolTipEditar { get { return "Editar Pessoa Física"; } }

        public string ToolTipExcluir { get { return "Excluir  Pessoa Física"; } }

        public string ToolTipFiltro { get { return "Não disponível"; } }

        public string ToolTipAgrupar { get { return "Não disponível"; } }

        public string ToolTipDesAgrupar { get { return "Não disponível"; } }    
    
    }
}
