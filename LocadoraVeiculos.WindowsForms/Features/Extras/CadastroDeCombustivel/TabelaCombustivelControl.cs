using LocadoraVeiculo.Dominio.CombustivelModule;
using LocadoraVeiculos.WindowsForms.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.Features.Extras.CadastroDeCombustivel
{
    public partial class TabelaCombustivelControl : UserControl
    {
        public TabelaCombustivelControl()
        {
            InitializeComponent();
            dataGridViewCombustivelControl.ConfigurarGridZebrado();
            dataGridViewCombustivelControl.ConfigurarGridSomenteLeitura();
            dataGridViewCombustivelControl.Columns.AddRange(ObterColunas());
        }

        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Valor", HeaderText = "Valor"},
            };

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return dataGridViewCombustivelControl.SelecionarId<int>();
        }

        public void AtualizarRegistros(List<Combustivel> combustiveis)
        {
            dataGridViewCombustivelControl.Rows.Clear();

            foreach (Combustivel combustivel in combustiveis)
            {
                dataGridViewCombustivelControl.Rows.Add(combustivel.Id, combustivel.Nome, combustivel.Valor);

            }
        }
    }
}
