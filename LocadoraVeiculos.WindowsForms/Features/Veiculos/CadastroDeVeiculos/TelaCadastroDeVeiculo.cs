﻿using LocadoraVeiculo.Dominio.GrupoDeVeiculosModule;
using LocadoraVeiculo.Dominio.VeiculoModule;
using LocadoraVeiculos.Controlador.GrupoDeVeiculosModule;
using LocadoraVeiculos.Controlador.VeiculoModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.Features.Veiculos
{
    public partial class TelaCadastroDeVeiculo : Form
    {
        private Veiculo veiculo;
        private ControladorVeiculo controlador;
        private ControladorGrupoDeVeiculos controladorGrupoDeVeiculos;

        public Veiculo Veiculo
        {
            get { return veiculo; }
            set
            {
                veiculo = value;

                textBoxId.Text = veiculo.Id.ToString();
                txtVeiculo.Text = veiculo.NomeVeiculo;
                txtMarca.Text = veiculo.Marca;
                txtCor.Text = veiculo.Cor;
                txtCapacidade.Text = veiculo.QuantidadeLugares.ToString();
                txtChassi.Text = veiculo.Chassi;
                txtKm.Text = veiculo.KmAtual.ToString();
                txtLitros.Text = veiculo.LitrosTanque.ToString();
                txtPlaca.Text = veiculo.Placa;
                txtPortas.Text = veiculo.NumeroPortas.ToString();
                txtAno.Text = veiculo.Ano.ToString();
                cmbPortaMalas.SelectedIndex = (int)veiculo.PortaMala;
                cmbVeiculos.SelectedItem = veiculo.GrupoDeVeiculos.Nome.ToString();
            }
        }

        public TelaCadastroDeVeiculo(ControladorVeiculo ctlrVeiculo)
        {
            controlador = ctlrVeiculo;
            controladorGrupoDeVeiculos = new ControladorGrupoDeVeiculos();
            InitializeComponent();
            CarregarTamanhosPortaMalas();
            CarregarGruposDeVeiculos();
        }

        private void CarregarTamanhosPortaMalas()
        {
            cmbPortaMalas.DataSource = Enum.GetValues(typeof(PortaMalaVeiculoEnum));
        }

        private void CarregarGruposDeVeiculos()
        {
            cmbVeiculos.DataSource = controladorGrupoDeVeiculos.SelecionarTodos();
            cmbVeiculos.DisplayMember = "NOME";
            cmbVeiculos.ValueMember = "NOME";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nomeVeiculo = txtVeiculo.Text;
            int ano = Convert.ToInt32(txtAno.Text);
            int capacidade = Convert.ToInt32(txtCapacidade.Text);
            string chassi = txtChassi.Text;
            string cor = txtCor.Text;
            int kmAtual = Convert.ToInt32(txtKm.Text);
            int litros = Convert.ToInt32(txtLitros.Text);
            string marca = txtMarca.Text;
            string placa = txtPlaca.Text;
            int porta = Convert.ToInt32(txtPortas.Text);

            int portaMalas = default;
            GrupoDeVeiculos grupoDeVeiculos = (GrupoDeVeiculos)cmbVeiculos.SelectedItem;

            portaMalas = ObtemTamanhoPortaMalas(portaMalas);

            veiculo = new Veiculo(nomeVeiculo, cor, marca, placa, chassi, kmAtual, porta, litros,
                 capacidade, ano, grupoDeVeiculos, (PortaMalaVeiculoEnum)portaMalas);

            string resultadoValidacao = veiculo.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                TelaInicial.Instancia.AtualizarRodape(primeiroErro);

                DialogResult = DialogResult.None;
            }
        }

        private int ObtemTamanhoPortaMalas(int portaMalas)
        {
            switch (cmbPortaMalas.SelectedItem)
            {
                case PortaMalaVeiculoEnum.Pequeno: portaMalas = 0; break;

                case PortaMalaVeiculoEnum.Medio: portaMalas = 1; break;

                case PortaMalaVeiculoEnum.Grande: portaMalas = 2; break;
            }

            return portaMalas;
        }
    }
}