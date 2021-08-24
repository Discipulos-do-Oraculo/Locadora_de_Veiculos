using LocadoraVeiculo.Dominio.DevolucaoModule;
using LocadoraVeiculos.Controlador.DevolucaoModule;
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

namespace LocadoraVeiculos.WindowsForms.Features.DevolucaoModule
{
    public partial class TabelaDevolucaoControl : UserControl
    {

        public TabelaDevolucaoControl()
        {            
            InitializeComponent();
            gridDevolucao.ConfigurarGridZebrado();
            gridDevolucao.ConfigurarGridSomenteLeitura();
            gridDevolucao.Columns.AddRange(ObterColunas());
        }
        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Locacao", HeaderText = "Condutor"},

                new DataGridViewTextBoxColumn { DataPropertyName = "DataRetorno", HeaderText = "Data Retorno"},

                new DataGridViewTextBoxColumn { DataPropertyName = "KmFinal", HeaderText = "Km Final"},

                new DataGridViewTextBoxColumn { DataPropertyName = "LitrosGastos", HeaderText = "Litros Gastos"},

                new DataGridViewTextBoxColumn { DataPropertyName = "ValorTotal", HeaderText = "Valor Total"},
            };

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return gridDevolucao.SelecionarId<int>();
        }

        public void AtualizarRegistros(List<Devolucao> devolucoes)
        {
            gridDevolucao.Rows.Clear();

            foreach (Devolucao devolucao in devolucoes)
            {
                gridDevolucao.Rows.Add(devolucao.Id, devolucao.Locacao.Condutor, devolucao.DataRetorno, devolucao.KmFinal, devolucao.LitrosGastos, devolucao.ValorTotal);

            }
        }
    }
}
