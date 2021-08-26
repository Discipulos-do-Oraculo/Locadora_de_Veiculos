using LocadoraVeiculo.Dominio.CupomModule;
using LocadoraVeiculos.WindowsForms.Shared;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.Features.MidiaModule
{
    public partial class TabelaMidiaControl : UserControl
    {
        public TabelaMidiaControl()
        {
            InitializeComponent();
            gridMidia.ConfigurarGridZebrado();
            gridMidia.ConfigurarGridSomenteLeitura();
            gridMidia.Columns.AddRange(ObterColunas());
        }
        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},
            };

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return gridMidia.SelecionarId<int>();
        }

        public void AtualizarRegistros(List<Midia> midias)
        {
            gridMidia.Rows.Clear();

            foreach (Midia midia in midias)
            {
                gridMidia.Rows.Add(midia.Id, midia.Nome);

            }
        }
    }
}
