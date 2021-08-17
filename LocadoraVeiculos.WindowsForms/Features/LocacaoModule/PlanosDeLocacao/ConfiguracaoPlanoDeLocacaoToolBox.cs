using LocadoraVeiculos.WindowsForms.Shared;

namespace LocadoraVeiculos.WindowsForms.Features.LocacaoModule.PlanosDeLocacao
{
    public class ConfiguracaoPlanoDeLocacaoToolBox : IConfiguracaoToolBox
    {
        public string ToolTipAdicionar { get { return "Cadastrar Planos de Locação"; } }

        public string TipoCadastro { get { return "Planos de Locação"; } }

        public string ToolTipEditar { get { return "Editar um Plano de Locação"; } }

        public string ToolTipExcluir { get { return "Excluirv um Plano de Locação"; } }

        public string ToolTipFiltro { get { return "Não disponível"; } }

        public string ToolTipAgrupar { get { return "Não disponível"; } }

        public string ToolTipDesAgrupar { get { return "Não disponível"; } }
    
    }
}
