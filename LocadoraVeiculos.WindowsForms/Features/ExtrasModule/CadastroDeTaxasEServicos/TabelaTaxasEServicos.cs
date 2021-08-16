using LocadoraVeiculo.Dominio.TaxasEServicosModule;
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

namespace LocadoraVeiculos.WindowsForms.Features.Extras.CadastroDeTaxasEServicos
{
    public partial class TabelaTaxasEServicos : UserControl
    {
        public TabelaTaxasEServicos()
        {
            InitializeComponent();
            dataGridViewTaxasEServicos.ConfigurarGridZebrado();
            dataGridViewTaxasEServicos.ConfigurarGridSomenteLeitura();
            dataGridViewTaxasEServicos.Columns.AddRange(ObterColunas());
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
            return dataGridViewTaxasEServicos.SelecionarId<int>();
        }

        public void AtualizarRegistros(List<TaxasEServicos> taxasEServicos)
        {
            dataGridViewTaxasEServicos.Rows.Clear();

            foreach (TaxasEServicos taxaEServico in taxasEServicos)
            {
                dataGridViewTaxasEServicos.Rows.Add(taxaEServico.Id, taxaEServico.Nome, taxaEServico.Valor);

            }
        }

    }
}
