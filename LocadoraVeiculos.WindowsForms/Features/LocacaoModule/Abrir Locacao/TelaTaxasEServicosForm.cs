using LocadoraVeiculo.Dominio.TaxasEServicosModule;
using LocadoraVeiculos.Controlador.TaxasEServicosModule;
using LocadoraVeiculos.WindowsForms.Features.DevolucaoModule;
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
        List<TaxasEServicos> taxasEdicao;
        List<TaxasEServicos> taxas = new List<TaxasEServicos>();
        private TipoTela tipo = default;
   

        public List<TaxasEServicos> TaxasSelecionadas { get => taxasSelecionadas; set => taxasSelecionadas = value; }

        public TelaTaxasEServicosForm(List<TaxasEServicos> taxas,TipoTela tipoTela)
        {
            InitializeComponent();
            controladorTaxas = new ControladorTaxasEServicos();
            taxasEdicao = taxas;
            tipo = tipoTela;
            CarregarChecListBox();
        }
        private void CarregarChecListBox()
        {
          
            if(tipo == TipoTela.Devolucao)
            {
                taxas = controladorTaxas.SelecionarPorCalculoFixo();
            }
            else
            {
                taxas = controladorTaxas.SelecionarTodos();
            }

           
            foreach (var item in taxas)
            {
                if (taxasEdicao != null && taxasEdicao.Contains(item))
                {
                    clbTaxas.Items.Add(item, true);
                }else
                {
                    clbTaxas.Items.Add(item, false);
                }
                    
            }

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ObtemListaDeTaxas();
        }

        private List<TaxasEServicos> ObtemListaDeTaxas()
        {
            List<int> idTaxaSelecionada = new List<int>();

            if (clbTaxas.CheckedItems.Count > 0)
            {

                foreach (TaxasEServicos item in clbTaxas.CheckedItems)
                {
                    idTaxaSelecionada.Add(item.Id);
                }

                foreach (var item in idTaxaSelecionada)
                {
                    TaxasSelecionadas.Add(controladorTaxas.SelecionarPorId(item));
                }
            }
            return TaxasSelecionadas;
        }

        
    }
}

