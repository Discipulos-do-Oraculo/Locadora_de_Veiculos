using LocadoraVeiculo.Dominio.VeiculoModule;
using LocadoraVeiculos.WindowsForms.Shared;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.Features.Veiculos.CadastroDeVeiculos
{
    public partial class TabelaVeiculoControl : UserControl
    {
        public TabelaVeiculoControl()
        {
            InitializeComponent();
            gridVeiculos.ConfigurarGridZebrado();
            gridVeiculos.ConfigurarGridSomenteLeitura();
            gridVeiculos.Columns.AddRange(ObterColunas());
        }

        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Veículo", HeaderText = "Veiculo"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Placa", HeaderText = "Placa"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Grupo", HeaderText = "Grupo"},
            };

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return gridVeiculos.SelecionarId<int>();
        }

        
        public void AtualizarRegistros(List<Veiculo> veiculos)
        {
            gridVeiculos.Rows.Clear();

            foreach (Veiculo veiculo in veiculos)
            {
                gridVeiculos.Rows.Add(veiculo.Id, veiculo.NomeVeiculo, veiculo.Placa, veiculo.GrupoDeVeiculos.Nome);

            }
        }
    }
}
