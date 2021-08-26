using FluentAssertions;
using LocadoraVeiculo.Dominio.CombustivelModule;
using LocadoraVeiculos.Controlador;
using LocadoraVeiculos.Controlador.GasolinaModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LocadoraVeiculos.Test.ExtrasModule.CombustivelModule
{
    [TestClass]
    [TestCategory("Controladores")]

    public class CombustivelControladorTestes
    {
       
        private ControladorCombustivel controlador = null;

        public CombustivelControladorTestes()
        {
            controlador = new ControladorCombustivel();
            Db.Update("DELETE FROM [TBDEVOLUCAO]");
            Db.Update("DELETE FROM [TBLOCACAO]");
            Db.Update("DELETE FROM [TBCOMBUSTIVEL]");
            
        }

        [TestMethod]
        public void DeveInserir_Combustivel()
        {
            //arrange
            var combustivel = new Combustivel("Gasolina", 5);

            //action
            controlador.InserirNovo(combustivel);

            //assert
            var combustivelEncontrado = controlador.SelecionarPorId(combustivel.Id);
            combustivelEncontrado.Should().Be(combustivel);
        }

        [TestMethod]
        public void DeveAtualizar_Combustivel()
        {
            //arrange
            var combustivel = new Combustivel("Gasolina", 5);

            controlador.InserirNovo(combustivel);

            var novoCombustivel = new Combustivel("Etanol", 5);


            //action
            controlador.Editar(combustivel.Id, novoCombustivel);

            //assert
            Combustivel combustivelAtualizado = controlador.SelecionarPorId(combustivel.Id);
            combustivelAtualizado.Should().Be(novoCombustivel);
        }

        [TestMethod]
        public void DeveSelecionar_Combustivel_PorId()
        {
            //arrange
            var combustivel = new Combustivel("Gasolina", 5);

            controlador.InserirNovo(combustivel);

            //action
            Combustivel combustivelEncontrado = controlador.SelecionarPorId(combustivel.Id);

            //assert
            combustivelEncontrado.Should().NotBeNull();
        }

        [TestMethod]
        public void DeveSelecionar_TodosCombustivels()
        {
            //arrange
            var gv1 = new Combustivel("Gasolina", 5);
            controlador.InserirNovo(gv1);

            var gv2 = new Combustivel("Etanol", 5);
            controlador.InserirNovo(gv2);

            var gv3 = new Combustivel("Diesel", 5);

            controlador.InserirNovo(gv3);

            //action
            var grupoDeVeiculoss = controlador.SelecionarTodos();

            //assert
            grupoDeVeiculoss.Should().HaveCount(3);
            grupoDeVeiculoss[0].Nome.Should().Be("Gasolina");
            grupoDeVeiculoss[1].Nome.Should().Be("Etanol");
            grupoDeVeiculoss[2].Nome.Should().Be("Diesel");
        }
    }
}
