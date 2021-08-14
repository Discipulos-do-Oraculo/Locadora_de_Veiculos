using FluentAssertions;
using LocadoraVeiculo.Dominio.CombustivelModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Test.CombustivelModule
{
    [TestClass]
    [TestCategory("Dominio")]
    public class CombustivelTest
    {
        [TestMethod]
        public void DeveValidar_Nome()
        {
            //arrange
            var combustivel = new Combustivel("", 20);

            //action
            var resultado = combustivel.Validar();

            //assert
            resultado.Should().Be("O campo nome é obrigatório");

        }


        [TestMethod]
        public void DeveRetornar_CombustivelValido()
        {
            //arrange
            var combustivel = new Combustivel("50", 20);

            //action
            var resultado = combustivel.Validar();

            //assert
            resultado.Should().Be("ESTA_VALIDO");

        }

        [TestMethod]
        public void DeveValidar_ValorVazio()
        {
            //arrange
            var combustivel = new Combustivel("Gasolina", default);

            //action
            var resultado = combustivel.Validar();

            //assert
            resultado.Should().Be("O campo valor é obrigatório");

        }

        [TestMethod]
        public void DeveValidar_ValorMenorQueZero()
        {
            //arrange
            var combustivel = new Combustivel("Gasolina", -1);

            //action
            var resultado = combustivel.Validar();

            //assert
            resultado.Should().Be("O campo valor não aceita numeros negativos");

        }

    }
}
