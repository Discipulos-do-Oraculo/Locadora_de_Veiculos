using LocadoraVeiculo.Dominio.LocacaoModule;
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

namespace LocadoraVeiculos.WindowsForms.Features.LocacaoModule.Abrir_Locacao
{
    public partial class TabelaAbrirLocacaoControl : UserControl
    {
        public TabelaAbrirLocacaoControl()
        {
            InitializeComponent();
            dataGridViewLocaoesAbertas.ConfigurarGridZebrado();
            dataGridViewLocaoesAbertas.ConfigurarGridSomenteLeitura();
            dataGridViewLocaoesAbertas.Columns.AddRange(ObterColunas());
        }

        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Condutor", HeaderText = "Condutor"},

                new DataGridViewTextBoxColumn { DataPropertyName = "ValorTotal", HeaderText = "Valor Total"},

                new DataGridViewTextBoxColumn { DataPropertyName = "DataSaida", HeaderText = "Data Saida"},

                new DataGridViewTextBoxColumn { DataPropertyName = "DataRetorno", HeaderText = "Data Retorno"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Cupom", HeaderText = "Cupom"},
            };

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return dataGridViewLocaoesAbertas.SelecionarId<int>();
        }

        public void AtualizarRegistros(List<Locacao> locacoes)
        {
            dataGridViewLocaoesAbertas.Rows.Clear();

            foreach (Locacao locacao in locacoes)
            {
                dataGridViewLocaoesAbertas.Rows.Add(locacao.Id, locacao.Condutor.Nome, locacao.ValorTotal, locacao.DataSaida, locacao.DataRetorno, locacao.Cupom); ; 

            }
        }
    }
}
