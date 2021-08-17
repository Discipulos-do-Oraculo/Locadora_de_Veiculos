using FluentAssertions;
using LocadoraVeiculo.Dominio.PlanoLocacaoModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LocadoraVeiculos.Test.LocacaoModule.PlanosDeLocacao
{
    [TestClass]
    public class PlanoDeLocacaoTeste
    {
        [TestMethod]
        [TestCategory("Dominio")]

        public void DeveRetornar_PlanoDeLocacaoValido()
        {
            //arrange
            var plano = new PlanoDeLocacao("Plano Diário", 50, "Paga por dia e por km rodado");

            //action
            var resultado = plano.Validar();

            //assert
            resultado.Should().Be("ESTA_VALIDO");
        }

        [TestMethod]
        public void DeveValidar_Descricao()
        {
            //arrange
            var plano = new PlanoDeLocacao("Plano Diário", 50, "");

            //action
            var resultado = plano.Validar();

            //assert
            resultado.Should().Be("O campo descrição é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_Titulo()
        {
            //arrange
            var grupoDeVeiculos = new PlanoDeLocacao("", 50, "Paga por dia e por km rodado");

            //action
            var resultadoValidacao = grupoDeVeiculos.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo titulo é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_Valor()
        {
            //arrange
            var grupoDeVeiculos = new PlanoDeLocacao("Plano Diário", 0, "Paga por dia e por km rodado");

            //action
            var resultadoValidacao = grupoDeVeiculos.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo valor é obrigatório");
        }
    }
}
