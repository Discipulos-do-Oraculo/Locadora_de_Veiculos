using LocadoraVeiculo.Dominio.CupomModule;
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

namespace LocadoraVeiculos.WindowsForms.Features.ParceiroModule
{
    public partial class TabelaParceiroControl : UserControl
    {
        public TabelaParceiroControl()
        {
            InitializeComponent();
            gridParceiro.ConfigurarGridZebrado();
            gridParceiro.ConfigurarGridSomenteLeitura();
            gridParceiro.Columns.AddRange(ObterColunas());
        }

        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},

                new DataGridViewTextBoxColumn { DataPropertyName = "MeioComunicao", HeaderText = "Meio de Comunição"},
            };

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return gridParceiro.SelecionarId<int>();
        }

        public void AtualizarRegistros(List<Parceiro> parceiros)
        {
            gridParceiro.Rows.Clear();

            foreach (Parceiro parceiro in parceiros)
            {
                gridParceiro.Rows.Add(parceiro.Id, parceiro.Nome, parceiro.MeioComunicao);

            }
        }
    }
}
