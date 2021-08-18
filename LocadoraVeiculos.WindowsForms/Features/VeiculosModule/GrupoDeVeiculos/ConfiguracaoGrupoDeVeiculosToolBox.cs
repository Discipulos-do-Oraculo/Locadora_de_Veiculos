using LocadoraVeiculos.WindowsForms.Shared;

namespace LocadoraVeiculos.WindowsForms.Features.Veiculos
{
    public class ConfiguracaoGrupoDeVeiculosToolBox : IConfiguracaoToolBox
    {
        public string ToolTipAdicionar
        {
            get { return "Cadastrar Grupo de Veiculos"; }
        }
        public string TipoCadastro { get { return "Grupo de Veículos"; } }

        public string ToolTipEditar { get { return "Editar Grupo de Veiculos"; } }

        public string ToolTipExcluir { get { return "Excluir Grupo de Veículos"; } }

        public string ToolTipFiltro { get { return "Não disponível"; } }

        public string ToolTipAgrupar { get { return "Não disponível"; } }

        public string ToolTipDesAgrupar
        {
            get
            {
                return "Não disponível";
            }
        }
    }
}
