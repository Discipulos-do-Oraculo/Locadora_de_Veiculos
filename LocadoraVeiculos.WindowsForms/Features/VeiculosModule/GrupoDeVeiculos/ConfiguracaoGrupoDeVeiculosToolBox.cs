using LocadoraVeiculos.WindowsForms.Shared;

namespace LocadoraVeiculos.WindowsForms.Features.Veiculos
{
    public class ConfiguracaoGrupoDeVeiculosToolBox : IConfiguracaoToolBox
    {
        public string ToolTipAdicionar
        {
            get { return "Cadastro Grupo de Veiculos"; }
        }
        public string TipoCadastro { get { return "Cadastro Grupo de Veiculos"; } }

        public string ToolTipEditar { get { return "Editar um Grupo de Veiculos"; } }

        public string ToolTipExcluir { get { return "Não disponível"; } }

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
