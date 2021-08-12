using LocadoraVeiculo.Dominio.ClienteModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.Features.Clientes.ClienteCNPJ
{
    public partial class TelaClienteCnpj : Form
    {
        private ClienteCnpj cliente;
        public ClienteCnpj ClienteCnpj
        {
            get { return cliente; }
            set
            {
                cliente = value;

                textBoxId.Text = cliente.Id.ToString();
                txtNome.Text = cliente.Nome;
                txtCelular.Text = cliente.Celular;
                txtCidade.Text = cliente.Cidade;

            }
        }
        public TelaClienteCnpj()
        {
            InitializeComponent();
        }
    }
}
