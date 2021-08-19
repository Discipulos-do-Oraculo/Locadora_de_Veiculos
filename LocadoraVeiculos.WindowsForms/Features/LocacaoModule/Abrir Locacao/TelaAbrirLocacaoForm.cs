using LocadoraVeiculo.Dominio.ClienteModule;
using LocadoraVeiculo.Dominio.LocacaoModule;
using LocadoraVeiculo.Dominio.VeiculoModule;
using LocadoraVeiculos.Controlador.ClienteModule.ClienteCnpjControlador;
using LocadoraVeiculos.Controlador.ClienteModule.ClientePfControlador;
using LocadoraVeiculos.Controlador.ClienteModule.CondutorControlador;
using LocadoraVeiculos.Controlador.VeiculoModule;
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
    public partial class TelaAbrirLocacaoForm : Form
    {


        private Locacao locacao = null;
        private ControladorVeiculo controladorVeiculo;
        private ControladorCondutor controladorConcdutor;
        private ControladorClienteCnpj controladorClienteCnpj;
        private ControladorClientePF controladorClientePF;

        public TelaAbrirLocacaoForm()
        {
            controladorClienteCnpj = new ControladorClienteCnpj();
            controladorVeiculo = new ControladorVeiculo();
            controladorConcdutor = new ControladorCondutor();
            controladorClientePF = new ControladorClientePF();
            InitializeComponent();
            CarregarVeiculos();
        }

        public Locacao Locacao { get => locacao; set => locacao = value; }

        private void CarregarVeiculos()
        {
            cmbVeiculos.DisplayMember = "NOMEVEICULO";
            cmbVeiculos.ValueMember = "NOMEVEICULO";

            cmbVeiculos.DataSource = controladorVeiculo.SelecionarTodos();

            Veiculo veiculo = (Veiculo)cmbVeiculos.SelectedItem;

            txtKmInicial.Text = Convert.ToString(veiculo.KmAtual);

        }

        private void CarregarClientesJuridicos()
        {

            List<ClienteCnpj> clientesPJ = new List<ClienteCnpj>();
            clientesPJ = controladorClienteCnpj.SelecionarTodos();

            foreach (var item in clientesPJ)
            {

                cmbPessoa.Items.Add(item);
            }
        }

        private void CarregarClientesFisicos()
        {

            List<ClientePF> clientesPF = new List<ClientePF>();
            clientesPF = controladorClientePF.SelecionarTodos();

            foreach (var item in clientesPF)
            {
                
                cmbPessoa.Items.Add(item);
            }
          
        }

        private void CarregarCondutores()
        
        {
            if (radioButtonPessoaJuridica.Checked)
            {
                List<Condutor> condutores = new List<Condutor>();
                var objeto = cmbPessoa.SelectedItem;
                var clienteCNPJ = (ClienteCnpj)objeto;
                condutores = controladorConcdutor.SelecionarPorEmpresa(clienteCNPJ.Id);

                foreach (var item in condutores)
                {

                    cmbCondutor.Items.Add(item.ToString());
                }
            }

            if (radioButtonPessoaFisica.Checked)
            {
                
                var objeto = cmbPessoa.SelectedItem;
                var clientePF = (ClientePF)objeto;
                clientePF = controladorClientePF.SelecionarPorId(clientePF.Id);

                cmbCondutor.Items.Add(clientePF.ToString());

                cmbCondutor.Text = cmbPessoa.Text;
                
            }

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        

        private void cmbPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (radioButtonPessoaFisica.Checked)
            {

                CarregarCondutores();
            }
            else if(radioButtonPessoaJuridica.Checked)
            {
                CarregarCondutores();      
            }
            
        }

        private void radioButtonPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            cmbPessoa.Items.Clear();
            cmbCondutor.Items.Clear();
            CarregarClientesJuridicos();
        }

        private void radioButtonPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            cmbPessoa.Items.Clear();
            cmbCondutor.Items.Clear();
            CarregarClientesFisicos();
        }
    }
}
