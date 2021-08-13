using FluentAssertions;
using LocadoraVeiculo.Dominio.TaxasEServicosModule;
using LocadoraVeiculos.Controlador;
using LocadoraVeiculos.Controlador.TaxasEServicosModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Test.TaxasESErvicosModule
{
    [TestClass]
    [TestCategory("Controladores")]
    public class ControladorTaxasEServicosTest
    {
        private ControladorTaxasEServicos controlador = null;

        public ControladorTaxasEServicosTest()
        {
            controlador = new ControladorTaxasEServicos();
            Db.Update("DELETE FROM [TBTAXASESERVICOS]");
        }


        [TestMethod]
        public void DeveInserir_TaxasEServicos()
        {
            //arrange
            var taxasEServicos = new TaxasEServicos("GPS", 50,true,false);

            //action
            controlador.InserirNovo(taxasEServicos);

            //assert
            var grupoDeVeiculosEncontrado = controlador.SelecionarPorId(taxasEServicos.Id);
            grupoDeVeiculosEncontrado.Should().Be(taxasEServicos);
        }

        [TestMethod]
        public void DeveAtualizar_TaxasEServicos()
        {
            //arrange
            var taxasEServicos = new TaxasEServicos("GPS", 50, true, false);
            controlador.InserirNovo(taxasEServicos);

            var novaTaxaEServico = new TaxasEServicos("Cadeirinha", 50, false, true);

            //action
            controlador.Editar(taxasEServicos.Id, novaTaxaEServico);

            //assert
            TaxasEServicos taxaEServicoAtualizado = controlador.SelecionarPorId(taxasEServicos.Id);
            taxaEServicoAtualizado.Should().Be(novaTaxaEServico);
        }

        [TestMethod]
        public void DeveSelecionar_TaxaEServico_PorId()
        {
            //arrange
            var taxasEServicos = new TaxasEServicos("GPS", 50, true, false);
            controlador.InserirNovo(taxasEServicos);

            //action
            TaxasEServicos taxaEServicoEncontrado = controlador.SelecionarPorId(taxasEServicos.Id);

            //assert
            taxaEServicoEncontrado.Should().NotBeNull();
        }

        [TestMethod]
        public void DeveSelecionar_TodosAsTaxasEServicos()
        {
            //arrange
            var taxasEServicos = new TaxasEServicos("GPS", 50, true, false);
            controlador.InserirNovo(taxasEServicos);

            var segundaTaxasEServicos = new TaxasEServicos("LAVAÇÃO", 50, true, false);
            controlador.InserirNovo(segundaTaxasEServicos);

            var terceiraTaxasEServicos = new TaxasEServicos("CADEIRINHA", 50, true, false);
            controlador.InserirNovo(terceiraTaxasEServicos);

            //action
            var todasTaxasEServicos = controlador.SelecionarTodos();

            //assert
            todasTaxasEServicos.Should().HaveCount(3);
            todasTaxasEServicos[0].Nome.Should().Be("GPS");
            todasTaxasEServicos[1].Nome.Should().Be("LAVAÇÃO");
            todasTaxasEServicos[2].Nome.Should().Be("CADEIRINHA");
        }

    }
}
