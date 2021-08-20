using LocadoraVeiculo.Dominio.LocacaoModule;
using LocadoraVeiculo.Dominio.TaxasEServicosModule;
using LocadoraVeiculos.Controlador.TaxasEServicosModule;
using LocadoraVeiculos.WindowsForms.Features.Extras.CadastroDeTaxasEServicos;
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
    public partial class TabelaTaxasEServicosControl : UserControl
    {
        ControladorTaxasEServicos controladorTaxas;
        
        public TabelaTaxasEServicosControl()
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
                clbTaxas.Items.Add(item,false);
            }
        }
    }
}
