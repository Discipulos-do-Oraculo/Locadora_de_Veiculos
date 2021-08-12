using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LocadoraVeiculo.Dominio.GrupoDeVeiculosModule;
using FluentAssertions;

namespace LocadoraVeiculos.Test
{
    [TestClass]
    [TestCategory("Dominio")]
    public class GrupoDeVeiculosTest
    {
        [TestMethod]
        public void DeveRetornar_GrupoDeVeiculosValido()
        {
            //arrange
            var grupoDeVeiculos = new GrupoDeVeiculos("SUV", 50);

            //action
            var resultado = grupoDeVeiculos.Validar();

            //assert
            resultado.Should().Be("ESTA_VALIDO");
        }

        [TestMethod]
        public void DeveValidar_Nome()
        {
            //arrange
            var grupoDeVeiculos = new GrupoDeVeiculos("", 50);

            //action
            var resultadoValidacao = grupoDeVeiculos.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo nome é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_ValorMaiorQueZero()
        {
            //arrange
            var grupoDeVeiculos = new GrupoDeVeiculos("SUV", 0);

            //action
            var resultadoValidacao = grupoDeVeiculos.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo valor precisa de um número maior que 0 e não pode ser nulo");
        }

    }
}
