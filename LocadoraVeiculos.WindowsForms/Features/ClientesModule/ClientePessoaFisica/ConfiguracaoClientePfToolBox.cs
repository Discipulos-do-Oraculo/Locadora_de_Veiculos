using LocadoraVeiculos.WindowsForms.Shared;

namespace LocadoraVeiculos.WindowsForms.ClientePessoaFisica
{
    public class ConfiguracaoClientePfToolBox : IConfiguracaoToolBox
    {
        public string ToolTipAdicionar
        {
            get { return "Cadastrar Cliente Físico"; }
        }
        public string TipoCadastro { get { return "Cliente Físico"; } }

        public string ToolTipEditar { get { return "Editar  Cliente Físico"; } }

        public string ToolTipExcluir { get { return "Excluir  Cliente Físico"; } }

        public string ToolTipFiltro { get { return "Não disponível"; } }

        public string ToolTipAgrupar { get { return "Não disponível"; } }

        public string ToolTipDesAgrupar { get { return "Não disponível"; } }    
    
    }
}
