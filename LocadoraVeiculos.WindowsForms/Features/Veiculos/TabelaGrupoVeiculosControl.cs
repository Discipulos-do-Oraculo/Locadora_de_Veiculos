using LocadoraVeiculo.Dominio.GrupoDeVeiculosModule;
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

                new DataGridViewTextBoxColumn { DataPropertyName = "Valor", HeaderText = "Valor"},
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
                dataGridViewGrupoVeiculos.Rows.Add(grupoVeiculo.Id, grupoVeiculo.Nome, grupoVeiculo.Valor);

            }
        }
    }
}
