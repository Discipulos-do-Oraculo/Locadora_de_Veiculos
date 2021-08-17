using LocadoraVeiculo.Dominio.PlanoLocacaoModule;
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

namespace LocadoraVeiculos.WindowsForms.Features.LocacaoModule.PlanosDeLocacao
{
    public partial class TabelaPlanosDeLocacaoControl : UserControl
    {
        public TabelaPlanosDeLocacaoControl()
        {
            InitializeComponent();
            gridPlanoDeLocacao.ConfigurarGridZebrado();
            gridPlanoDeLocacao.ConfigurarGridSomenteLeitura();
            gridPlanoDeLocacao.Columns.AddRange(ObterColunas());
        }

        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Titulo", HeaderText = "Título"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Valor", HeaderText = "Valor"},
            };

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return gridPlanoDeLocacao.SelecionarId<int>();
        }

        public void AtualizarRegistros(List<PlanoDeLocacao> planos)
        {
            gridPlanoDeLocacao.Rows.Clear();

            foreach (PlanoDeLocacao plano in planos)
            {
                gridPlanoDeLocacao.Rows.Add(plano.Id, plano.Titulo, plano.Valor);

            }
        }
    }
}
