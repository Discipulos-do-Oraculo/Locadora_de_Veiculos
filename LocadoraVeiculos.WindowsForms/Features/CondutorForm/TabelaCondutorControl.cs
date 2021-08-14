using LocadoraVeiculo.Dominio.ClienteModule;
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

namespace LocadoraVeiculos.WindowsForms.Features.CondutorForm
{
    public partial class TabelaCondutorControl : UserControl
    {
        public TabelaCondutorControl()
        {
            InitializeComponent();
            gridCondutor.ConfigurarGridZebrado();
            gridCondutor.ConfigurarGridSomenteLeitura();
            gridCondutor.Columns.AddRange(ObterColunas());
        }

        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Empresa", HeaderText = "Empresa"},

                new DataGridViewTextBoxColumn { DataPropertyName = "CPF", HeaderText = "CPF"},

                new DataGridViewTextBoxColumn { DataPropertyName = "CNH", HeaderText = "CNH"},
            };

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return gridCondutor.SelecionarId<int>();
        }

        public void AtualizarRegistros(List<Condutor> condutores)
        {
            gridCondutor.Rows.Clear();

            foreach (Condutor condutor in condutores)
            {
                gridCondutor.Rows.Add(condutor.Id, condutor.Nome, condutor.IdClienteCnpj.ToString(), condutor.Cpf, condutor.Cnh);

            }
        }
    }
}
