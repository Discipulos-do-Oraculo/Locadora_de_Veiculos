using LocadoraVeiculos.WindowsForms.Shared;

namespace LocadoraVeiculos.WindowsForms.Features.Veiculos.CadastroDeVeiculos
{
    public class ConfiguracaoVeiculosToolBox : IConfiguracaoToolBox
    {
        public string ToolTipAdicionar
        {
            get { return "Cadastrar Veículo"; }
        }
        public string TipoCadastro { get { return "Veículos"; } }

        public string ToolTipEditar { get { return "Editar Veículo"; } }

        public string ToolTipExcluir { get { return "Excluir Veículo"; } }

        public string ToolTipFiltro { get { return "Filtrar Veículos"; } }

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
