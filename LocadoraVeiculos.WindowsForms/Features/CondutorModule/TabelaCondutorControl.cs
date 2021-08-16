using LocadoraVeiculo.Dominio.ClienteModule;
using LocadoraVeiculos.Controlador.ClienteModule.CondutorControlador;
using LocadoraVeiculos.WindowsForms.Features.CondutorModule;
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
        Subro.Controls.DataGridViewGrouper dataGridViewGrouper = new Subro.Controls.DataGridViewGrouper();
        private ControladorCondutor controlador = null;
        private FiltroCondutorEnum  tipoFiltro;
        public TabelaCondutorControl(ControladorCondutor ctrl)
        {
            InitializeComponent();
            controlador = ctrl;
            gridCondutor.ConfigurarGridZebrado();
            gridCondutor.ConfigurarGridSomenteLeitura();
            gridCondutor.Columns.AddRange(ObterColunas());
            tipoFiltro = FiltroCondutorEnum.NaoAgrupar;
        }

        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},

                new DataGridViewTextBoxColumn { DataPropertyName = "ClienteCnpj", HeaderText = "Empresa"},

                new DataGridViewTextBoxColumn { DataPropertyName = "CPF", HeaderText = "CPF"},

                new DataGridViewTextBoxColumn { DataPropertyName = "CNH", HeaderText = "CNH"},
            };

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return gridCondutor.SelecionarId<int>();
        }

        public void AtualizarRegistros()
        {
            DesagruparVeiculos();


            var condutores = controlador.SelecionarTodos();
            CarregarTabela(condutores);

            AgruparVeiculos();
        }

        private void CarregarTabela(List<Condutor> veiculos)
        {

            gridCondutor.DataSource = veiculos;
            dataGridViewGrouper = new Subro.Controls.DataGridViewGrouper(gridCondutor);

        }

        public void DesagruparVeiculos()
        {
            if (dataGridViewGrouper == null)
                return;

            var campos = new string[] { "ClienteCnpj" };
            dataGridViewGrouper.RemoveGrouping();
            gridCondutor.RowHeadersVisible = true;

            foreach (var campo in campos)
            {
                foreach (DataGridViewColumn item in gridCondutor.Columns)
                {
                    if (item.DataPropertyName == campo)
                        item.Visible = true;
                }
            }
        }

        public void AgruparVeiculos(FiltroCondutorEnum tipoFiltro)
        {
            this.tipoFiltro = tipoFiltro;

            AgruparVeiculos();
        }

        private void AgruparVeiculos()
        {
            switch (tipoFiltro)
            {
                case FiltroCondutorEnum.AgruparPorGrupo:
                    AgruparContatosPor("ClienteCnpj");
                    break;
                case FiltroCondutorEnum.NaoAgrupar:
                    DesagruparVeiculos();
                    break;
                default:
                    break;
            }
        }

        private void AgruparContatosPor(string campo)
        {
            if (dataGridViewGrouper == null)
                return;

            dataGridViewGrouper.RemoveGrouping();
            dataGridViewGrouper.SetGroupOn(campo);
            dataGridViewGrouper.Options.ShowGroupName = false;
            dataGridViewGrouper.Options.GroupSortOrder = SortOrder.None;

            foreach (DataGridViewColumn item in gridCondutor.Columns)
            {
                if (item.DataPropertyName == campo)
                    item.Visible = false;

                gridCondutor.RowHeadersVisible = false;
                gridCondutor.ClearSelection();

            }
        }
    }
}

