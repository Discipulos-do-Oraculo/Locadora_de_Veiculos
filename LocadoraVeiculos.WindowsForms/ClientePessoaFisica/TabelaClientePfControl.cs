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

namespace LocadoraVeiculos.WindowsForms.ClientePessoaFisica
{
    public partial class TabelaClientePfControl : UserControl
    {
        public TabelaClientePfControl()
        {
            InitializeComponent();
            gridClientePF.ConfigurarGridZebrado();
            gridClientePF.ConfigurarGridSomenteLeitura();
            gridClientePF.Columns.AddRange(ObterColunas());
        }

        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Telefone", HeaderText = "Telefone"},

                new DataGridViewTextBoxColumn { DataPropertyName = "CPF", HeaderText = "CPF"},

                new DataGridViewTextBoxColumn { DataPropertyName = "CNH", HeaderText = "CNH"},
            };

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return gridClientePF.SelecionarId<int>();
        }

        public void AtualizarRegistros(List<ClientePF> clientes)
        {
            gridClientePF.Rows.Clear();

            foreach (ClientePF cliente in clientes)
            {
                gridClientePF.Rows.Add(cliente.Id, cliente.Nome, cliente.Telefone, cliente.Cpf, cliente.Cnh);

            }
        }
    }
}
