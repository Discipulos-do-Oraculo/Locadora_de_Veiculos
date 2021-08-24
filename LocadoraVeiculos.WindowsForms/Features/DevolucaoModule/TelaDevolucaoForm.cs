using LocadoraVeiculo.Dominio.DevolucaoModule;
using LocadoraVeiculos.Controlador.DevolucaoModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.Features.DevolucaoModule
{
    public partial class TelaDevolucaoForm : Form
    {
        private Devolucao devolucao;
        private ControladorDevolucao controlador;

        public TelaDevolucaoForm()
        {
            InitializeComponent();
        }

        public Devolucao Devolucao
        {
            get { return devolucao; }
            set
            {
                devolucao = value;

                textBoxId.Text = devolucao.Id.ToString();
                cmbCombustivel.Text = devolucao.TipoCombustivel.Nome;
                txtKmFinal.Text = devolucao.KmFinal.ToString();
                txtLitrosGastos.Text = devolucao.LitrosGastos.ToString();
                lblLocacao.Text = devolucao.Locacao.Condutor.ToString();
                dateTimePickerRetorno.Value = devolucao.DataRetorno;
                dateTimePickerRetorno.Enabled = false;
                txtValorTotal.Text = devolucao.ValorTotal.ToString();
            }
        }

        private void txtKmFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }
    }
}
