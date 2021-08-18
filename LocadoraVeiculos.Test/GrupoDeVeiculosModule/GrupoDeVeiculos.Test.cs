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
            var grupoDeVeiculos = new GrupoDeVeiculos("SUV", 50,20,30,40,50);

            //action
            var resultado = grupoDeVeiculos.Validar();

            //assert
            resultado.Should().Be("ESTA_VALIDO");
        }

        [TestMethod]
        public void DeveValidar_Nome()
        {
            //arrange
            var grupoDeVeiculos = new GrupoDeVeiculos("", 50, 20, 30, 40, 50);

            //action
            var resultadoValidacao = grupoDeVeiculos.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo nome é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_ValorDiariaPD()
        {
            //arrange
            var grupoDeVeiculos = new GrupoDeVeiculos("SUV", 0 ,20, 30, 40, 50);

            //action
            var resultadoValidacao = grupoDeVeiculos.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo valor diária na aba plano diário é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_ValorKMDiarioPD()
        {
            //arrange
            var grupoDeVeiculos = new GrupoDeVeiculos("SUV", 20, 0, 30, 40, 50);

            //action
            var resultadoValidacao = grupoDeVeiculos.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo valor km na aba plano diário é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_LimiteKMPKC()
        {
            //arrange
            var grupoDeVeiculos = new GrupoDeVeiculos("SUV", 20, 30, 10, 0, 50);

            //action
            var resultadoValidacao = grupoDeVeiculos.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo limite km na aba km controlado é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_ValorKMDiarioPKC()
        {
            //arrange
            var grupoDeVeiculos = new GrupoDeVeiculos("SUV", 20, 30, 5, 40, 0);

            //action
            var resultadoValidacao = grupoDeVeiculos.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo valor km na aba km controlado é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_ValorKMDiarioPL()
        {
            //arrange
            var grupoDeVeiculos = new GrupoDeVeiculos("SUV", 20, 30, 0, 10, 150);

            //action
            var resultadoValidacao = grupoDeVeiculos.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo valor km na aba km livre é obrigatório");
        }

    }
}
