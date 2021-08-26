using FluentAssertions;
using LocadoraVeiculo.Dominio.TaxasEServicosModule;
using LocadoraVeiculos.Controlador;
using LocadoraVeiculos.Controlador.TaxasEServicosModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LocadoraVeiculos.Test.ExtrasModule.TaxasEServicosModule
{
    [TestClass]
    [TestCategory("Controladores")]

    public class TaxasEServicosControladorTestes
    {
        private ControladorTaxasEServicos controlador = null;

        public TaxasEServicosControladorTestes()
        {
            controlador = new ControladorTaxasEServicos();
            Db.Update("DELETE FROM [TBDEVOLUCAO]");
            Db.Update("DELETE FROM [TBLOCACAO]");
            Db.Update("DELETE FROM [TBTAXASESERVICOS]");

        }

        [TestMethod]
        public void DeveInserir_TaxasEServicos()
        {
            //arrange
            var taxas = new TaxasEServicos("cadeirinha", 25, false, true);

            //action
            controlador.InserirNovo(taxas);

            //assert
            var taxasEncontrado = controlador.SelecionarPorId(taxas.Id);
            taxasEncontrado.Should().Be(taxas);
        }

        [TestMethod]
        public void DeveAtualizar_TaxasEServicos()
        {
            //arrange
            var taxas = new TaxasEServicos("cadeirinha", 25, false, true);

            controlador.InserirNovo(taxas);

            var novoTaxasEServicos = new TaxasEServicos("gps", 25, false, true);


            //action
            controlador.Editar(taxas.Id, novoTaxasEServicos);

            //assert
            TaxasEServicos taxasAtualizado = controlador.SelecionarPorId(taxas.Id);
            taxasAtualizado.Should().Be(novoTaxasEServicos);
        }

        [TestMethod]
        public void DeveExcluir_Cliente()
        {
            //arrange            
            var combustivel = new TaxasEServicos("cadeirinha", 25, false, true);

            controlador.InserirNovo(combustivel);

            //action            
            controlador.Excluir(combustivel.Id);

            //assert
            TaxasEServicos clienteEncontrado = controlador.SelecionarPorId(combustivel.Id);
            clienteEncontrado.Should().BeNull();
        }

        [TestMethod]
        public void DeveSelecionar_TaxasEServicos_PorId()
        {
            //arrange
            var taxas = new TaxasEServicos("cadeirinha", 25, false, true);

            controlador.InserirNovo(taxas);

            //action
            TaxasEServicos taxasEncontrado = controlador.SelecionarPorId(taxas.Id);

            //assert
            taxasEncontrado.Should().NotBeNull();
        }

        [TestMethod]
        public void DeveSelecionar_TodosTaxasEServicoss()
        {
            //arrange
            var gv1 = new TaxasEServicos("cadeirinha", 25, false, true);
            controlador.InserirNovo(gv1);

            var gv2 = new TaxasEServicos("GPS", 25, false, true);
            controlador.InserirNovo(gv2);

            var gv3 = new TaxasEServicos("Lavacao", 25, false, true);

            controlador.InserirNovo(gv3);

            //action
            var grupoDeVeiculoss = controlador.SelecionarTodos();

            //assert
            grupoDeVeiculoss.Should().HaveCount(3);
            grupoDeVeiculoss[0].Nome.Should().Be("cadeirinha");
            grupoDeVeiculoss[1].Nome.Should().Be("GPS");
            grupoDeVeiculoss[2].Nome.Should().Be("Lavacao");
        }
    }
}
