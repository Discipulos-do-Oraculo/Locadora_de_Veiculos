using LocadoraVeiculo.Dominio.ClienteModule;
using LocadoraVeiculos.WindowsForms.Shared;
using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.Features.Clientes.ClienteCNPJ
{
    public partial class TabelaClienteCnpjControl : UserControl
    {
        public TabelaClienteCnpjControl()
        {
            InitializeComponent();
            gridClienteCnpj.ConfigurarGridZebrado();
            gridClienteCnpj.ConfigurarGridSomenteLeitura();
            gridClienteCnpj.Columns.AddRange(ObterColunas());
        }

        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Cnpj", HeaderText = "Cnpj"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Telefone", HeaderText = "Telefone"},
            };

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return gridClienteCnpj.SelecionarId<int>();
        }

        public void AtualizarRegistros(List<ClienteCnpj> clientes)
        {
            gridClienteCnpj.Rows.Clear();

            foreach (ClienteCnpj cliente in clientes)
            {
                gridClienteCnpj.Rows.Add(cliente.Id, cliente.Nome, cliente.Cnpj, cliente.Telefone);

            }
        }
    }
}
