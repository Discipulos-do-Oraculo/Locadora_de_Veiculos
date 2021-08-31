using LocadoraVeiculo.Dominio.CupomModule;
using LocadoraVeiculos.Controlador.CupomModule;
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

namespace LocadoraVeiculos.WindowsForms.Features.CupomModule
{
    public partial class TabelaCupomControl : UserControl
    {
        Subro.Controls.DataGridViewGrouper dataGridViewGrouper = new Subro.Controls.DataGridViewGrouper();
        private ControladorCupom controlador = null;
        private FiltroCupomEnum tipoFiltro;

        public TabelaCupomControl(ControladorCupom ctlr)
        {
            InitializeComponent();
            controlador = ctlr;
            gridCupom.ConfigurarGridZebrado();
            gridCupom.ConfigurarGridSomenteLeitura();
            gridCupom.Columns.AddRange(ObterColunas());
            tipoFiltro = FiltroCupomEnum.NaoAgrupar;
        }
        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Parceiro", HeaderText = "Parceiro"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Valor", HeaderText = "Valor do Cupom"},

                new DataGridViewTextBoxColumn { DataPropertyName = "ValorMinimo", HeaderText = "Mínimo para Aplicação"},
            };

            return colunas;
        }

        public DataGridViewColumn[] ObterColunasCupom()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Vezes", HeaderText = "Vezes utilizadas"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Cupom"},
            };

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return gridCupom.SelecionarId<int>();
        }

        public void AtualizarRegistros()
        {
            DesagruparCupons();


            var condutores = controlador.SelecionarTodos();
            CarregarTabela(condutores);

            AgruparVeiculos();
        }

        
            public void AtualizarRegistros(List<Cupom> cupons)
            {
                gridCupom.Rows.Clear();
                gridCupom.Columns.Clear();
                gridCupom.Columns.AddRange(ObterColunasCupom());

            foreach (Cupom cupom in cupons)
                {
                gridCupom.Rows.Add(cupom.Vezes, cupom.Nome);

                }
            }

        public void CarregarRegistrosPorEmpresa(int id)
        {
            var condutores = controlador.SelecionarPorParceiro(id);
            CarregarTabela(condutores);

        }

        private void CarregarTabela(List<Cupom> cupons)
        {

            gridCupom.DataSource = cupons;
            dataGridViewGrouper = new Subro.Controls.DataGridViewGrouper(gridCupom);

        }

        public void DesagruparCupons()
        {
            if (dataGridViewGrouper == null)
                return;

            var campos = new string[] { "Parceiro" };
            dataGridViewGrouper.RemoveGrouping();
            gridCupom.RowHeadersVisible = true;

            foreach (var campo in campos)
            {
                foreach (DataGridViewColumn item in gridCupom.Columns)
                {
                    if (item.DataPropertyName == campo)
                        item.Visible = true;
                }
            }
        }

        public void AgruparVeiculos(FiltroCupomEnum tipoFiltro)
        {
            this.tipoFiltro = tipoFiltro;

            AgruparVeiculos();
        }

        private void AgruparVeiculos()
        {
            switch (tipoFiltro)
            {
                case FiltroCupomEnum.AgruparPorParceiro:
                    AgruparContatosPor("Parceiro");
                    break;
                case FiltroCupomEnum.NaoAgrupar:
                    DesagruparCupons();
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

            foreach (DataGridViewColumn item in gridCupom.Columns)
            {
                if (item.DataPropertyName == campo)
                    item.Visible = false;

                gridCupom.RowHeadersVisible = false;
                gridCupom.ClearSelection();

            }
        }
    }
}
