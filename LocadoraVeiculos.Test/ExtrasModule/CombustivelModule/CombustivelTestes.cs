using FluentAssertions;
using LocadoraVeiculo.Dominio.CombustivelModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LocadoraVeiculos.Test.ExtrasModule.CombustivelModule
{
    [TestClass]
    [TestCategory("Domínio")]

    public class CombustivelTestes
    {
        [TestMethod]
        public void DeveRetornar_CombustivelValido()
        {
            //arrange
            Combustivel combustivel = new Combustivel("Gasolina", 5);

            //action
            var resultado = combustivel.Validar();

            //assert
            resultado.Should().Be("ESTA_VALIDO");
        }

        [TestMethod]
        public void DeveValidar_Nome()
        {
            //arrange
            Combustivel combustivel = new Combustivel("", 5);

            //action
            var resultado = combustivel.Validar();

            //assert
            resultado.Should().Be("O campo nome é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_ValorNulo()
        {
            //arrange
            Combustivel combustivel = new Combustivel("Gasolina", default);

            //action
            var resultado = combustivel.Validar();

            //assert
            resultado.Should().Be("O campo valor é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_ValorInvalido()
        {
            //arrange
            Combustivel combustivel = new Combustivel("Gasolina", -5);

            //action
            var resultado = combustivel.Validar();

            //assert
            resultado.Should().Be("O campo valor não aceita numeros negativos");
        }

    }
}
