using LocadoraVeiculo.Dominio.TaxasEServicosModule;
using LocadoraVeiculos.Controlador.TaxasEServicosModule;
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

namespace LocadoraVeiculos.WindowsForms.Features.LocacaoModule.Abrir_Locacao
{
    public partial class TelaTaxasEServicosForm : Form
    {
        ControladorTaxasEServicos controladorTaxas;
        List<TaxasEServicos> taxasSelecionadas = new List<TaxasEServicos>();

        public List<TaxasEServicos> TaxasSelecionadas { get => taxasSelecionadas; set => taxasSelecionadas = value; }

        public TelaTaxasEServicosForm()
        {
            InitializeComponent();
            controladorTaxas = new ControladorTaxasEServicos();
            CarregarChecListBox();
        }
        private void CarregarChecListBox()
        {
            List<TaxasEServicos> taxas = new List<TaxasEServicos>();
            taxas = controladorTaxas.SelecionarTodos();

            foreach (var item in taxas)
            {
                clbTaxas.Items.Add(item, false);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ObtemListaDeTaxas();
        }

        private List<TaxasEServicos> ObtemListaDeTaxas()
        {
            
            List<int> idTaxaSelecionado = new List<int>();

            if (clbTaxas.CheckedItems.Count > 0)
            {
                foreach (TaxasEServicos item in clbTaxas.CheckedItems)
                {
                    idTaxaSelecionado.Add(item.Id);
                }



                foreach (var item in idTaxaSelecionado)
                {

                    TaxasSelecionadas.Add(controladorTaxas.SelecionarPorId(item));
                }
            }
            return TaxasSelecionadas;
        }
    }
}

