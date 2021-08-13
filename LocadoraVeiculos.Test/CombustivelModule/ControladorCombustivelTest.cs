using FluentAssertions;
using LocadoraVeiculo.Dominio.CombustivelModule;
using LocadoraVeiculos.Controlador;
using LocadoraVeiculos.Controlador.GasolinaModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Test.CombustivelModule
{
    [TestClass]
    [TestCategory("Controladores")]
    public class ControladorCombustivelTest
    {
        private ControladorCombustivel controlador = null;

        public ControladorCombustivelTest()
        {
            controlador = new ControladorCombustivel();
            Db.Update("DELETE FROM [TBCOMBUSTIVEL]");
        }


        [TestMethod]
        public void DeveInserir_Combustivel()
        {
            //arrange
            var combustivel = new Combustivel("Gasolina", 50);

            //action
            controlador.InserirNovo(combustivel);

            //assert
            var grupoDeVeiculosEncontrado = controlador.SelecionarPorId(combustivel.Id);
            grupoDeVeiculosEncontrado.Should().Be(combustivel);
        }

        [TestMethod]
        public void DeveAtualizar_Combustivel()
        {
            //arrange
            var combustivel = new Combustivel("Gasolina", 50);
            controlador.InserirNovo(combustivel);

            var novoCombustivel = new Combustivel("Alcool", 100);

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
            var combustivel = new Combustivel("Gasolina", 50);
            controlador.InserirNovo(combustivel);

            //action
            Combustivel combustivelEncontrado = controlador.SelecionarPorId(combustivel.Id);

            //assert
            combustivelEncontrado.Should().NotBeNull();
        }

        [TestMethod]
        public void DeveSelecionar_TodosOsCombustiveis()
        {
            //arrange
            var combustivel = new Combustivel("Gasolina", 50);
            controlador.InserirNovo(combustivel);

            var segundoCombustivel = new Combustivel("Alcool", 100);
            controlador.InserirNovo(segundoCombustivel);

            var terceiroCombustivel = new Combustivel("Etanol", 60);
            controlador.InserirNovo(terceiroCombustivel);

            //action
            var combustiveis = controlador.SelecionarTodos();

            //assert
            combustiveis.Should().HaveCount(3);
            combustiveis[0].Nome.Should().Be("Gasolina");
            combustiveis[1].Nome.Should().Be("Alcool");
            combustiveis[2].Nome.Should().Be("Etanol");
        }
    }
}
