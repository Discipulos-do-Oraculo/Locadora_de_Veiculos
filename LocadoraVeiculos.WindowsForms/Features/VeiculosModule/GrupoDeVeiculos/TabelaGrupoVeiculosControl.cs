using LocadoraVeiculo.Dominio.GrupoDeVeiculosModule;
using LocadoraVeiculos.WindowsForms.Shared;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.Features.Veiculos
{
    public partial class TabelaGrupoVeiculosControl : UserControl
    {
        public TabelaGrupoVeiculosControl()
        {

            InitializeComponent();
            dataGridViewGrupoVeiculos.ConfigurarGridZebrado();
            dataGridViewGrupoVeiculos.ConfigurarGridSomenteLeitura();
            dataGridViewGrupoVeiculos.Columns.AddRange(ObterColunas());
        }

        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},

                new DataGridViewTextBoxColumn { DataPropertyName = "ValorDiaria", HeaderText = "PD Valor Diário"},

                new DataGridViewTextBoxColumn { DataPropertyName = "ValorKmDiaria", HeaderText = "PD Valor KM"},

                new DataGridViewTextBoxColumn { DataPropertyName = "ValorKmControlado", HeaderText = "PKC Valor KM"},

                new DataGridViewTextBoxColumn { DataPropertyName = "ValorKmLivre", HeaderText = "PL Valor KM"},
            };

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return dataGridViewGrupoVeiculos.SelecionarId<int>();
        }

        public void AtualizarRegistros(List<GrupoDeVeiculos> grupoVeiculos)
        {
            dataGridViewGrupoVeiculos.Rows.Clear();

            foreach (GrupoDeVeiculos grupoVeiculo in grupoVeiculos)
            {
                dataGridViewGrupoVeiculos.Rows.Add(grupoVeiculo.Id, grupoVeiculo.Nome, grupoVeiculo.ValorDiaria,grupoVeiculo.ValorKmDiaria
               ,grupoVeiculo.ValorKmControlado,grupoVeiculo.ValorKmLivre);

            }
        }
    }
}
