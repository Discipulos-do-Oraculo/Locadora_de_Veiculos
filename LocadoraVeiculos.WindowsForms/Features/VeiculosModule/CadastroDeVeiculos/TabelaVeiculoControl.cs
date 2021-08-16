using LocadoraVeiculo.Dominio.VeiculoModule;
using LocadoraVeiculos.Controlador.VeiculoModule;
using LocadoraVeiculos.WindowsForms.Features.VeiculosModule.CadastroDeVeiculos;
using LocadoraVeiculos.WindowsForms.Shared;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.Features.Veiculos.CadastroDeVeiculos
{
    public partial class TabelaVeiculoControl : UserControl
    {

        Subro.Controls.DataGridViewGrouper dataGridViewGrouper = new Subro.Controls.DataGridViewGrouper();
        private ControladorVeiculo controlador = null;
        private FiltroVeiculoEnum tipoFiltro;


        public TabelaVeiculoControl()
        {
            InitializeComponent();
            controlador = new ControladorVeiculo();
            gridVeiculos.ConfigurarGridZebrado();
            gridVeiculos.ConfigurarGridSomenteLeitura();
            gridVeiculos.Columns.AddRange(ObterColunas());
            tipoFiltro = FiltroVeiculoEnum.NaoAgrupar;
        }

        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "NomeVeiculo", HeaderText = "Veiculo"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Placa", HeaderText = "Placa"},

                new DataGridViewTextBoxColumn { DataPropertyName = "GrupoDeVeiculos", HeaderText = "Grupo"},
            };

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return gridVeiculos.SelecionarId<int>();
        }

        
        public void AtualizarRegistros()
        {
            DesagruparVeiculos();

            
            var veiculos = controlador.SelecionarTodos();
            CarregarTabela(veiculos);

            AgruparVeiculos();
        }

        private void CarregarTabela(List<Veiculo> veiculos)
        {

            gridVeiculos.DataSource = veiculos;
            dataGridViewGrouper = new Subro.Controls.DataGridViewGrouper(gridVeiculos);

        }

        public void DesagruparVeiculos()
        {
            if (dataGridViewGrouper == null)
                return;

            var campos = new string[] { "GrupoDeVeiculos" };
            dataGridViewGrouper.RemoveGrouping();
            gridVeiculos.RowHeadersVisible = true;

            foreach (var campo in campos)
            {
                foreach (DataGridViewColumn item in gridVeiculos.Columns)
                {
                    if (item.DataPropertyName == campo)
                        item.Visible = true;
                }
            }
        }

        public void AgruparVeiculos(FiltroVeiculoEnum tipoFiltro)
        {
            this.tipoFiltro = tipoFiltro;

            AgruparVeiculos();
        }

        private void AgruparVeiculos()
        {
            switch (tipoFiltro)
            {
                case FiltroVeiculoEnum.AgruparPorGrupo:
                    AgruparContatosPor("GrupoDeVeiculos");
                    break;
                case FiltroVeiculoEnum.NaoAgrupar:
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

            foreach (DataGridViewColumn item in gridVeiculos.Columns)
            {
                if (item.DataPropertyName == campo)
                    item.Visible = false;

                gridVeiculos.RowHeadersVisible = false;
                gridVeiculos.ClearSelection();

            }
        }
    }
}
