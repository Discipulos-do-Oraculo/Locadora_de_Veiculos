using LocadoraVeiculos.WindowsForms.Shared;

namespace LocadoraVeiculos.WindowsForms.Features.Veiculos.CadastroDeVeiculos
{
    public class ConfiguracaoVeiculosToolBox : IConfiguracaoToolBox
    {
        public string ToolTipAdicionar
        {
            get { return "Cadastrode Veículos"; }
        }
        public string TipoCadastro { get { return "Cadastro de Veículos"; } }

        public string ToolTipEditar { get { return "Editar um Veículo"; } }

        public string ToolTipExcluir { get { return "Editar um Veículo"; } }

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
