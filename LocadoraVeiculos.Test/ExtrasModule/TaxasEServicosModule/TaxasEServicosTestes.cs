using FluentAssertions;
using LocadoraVeiculo.Dominio.TaxasEServicosModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LocadoraVeiculos.Test.ExtrasModule.TaxasEServicosModule
{
    [TestClass]
    [TestCategory("Domínio")]

    public class TaxasEServicosTestes
    {
        [TestMethod]
        public void DeveRetornar_TaxasValidas()
        {
            //arrange
            TaxasEServicos taxas = new TaxasEServicos("cadeirinha", 25, false, true);

            //action
            var resultado = taxas.Validar();

            //assert
            resultado.Should().Be("ESTA_VALIDO");
        }

        [TestMethod]
        public void DeveValidar_Nome()
        {
            //arrange
            TaxasEServicos taxas = new TaxasEServicos("", 25, false, true);

            //action
            var resultado = taxas.Validar();

            //assert
            resultado.Should().Be("O campo nome é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_Valor()
        {
            //arrange
            TaxasEServicos taxas = new TaxasEServicos("cadeirinha", default, false, true);

            //action
            var resultado = taxas.Validar();

            //assert
            resultado.Should().Be("O campo valor é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_ValorNegativo()
        {
            //arrange
            TaxasEServicos taxas = new TaxasEServicos("cadeirinha", -5, false, true);

            //action
            var resultado = taxas.Validar();

            //assert
            resultado.Should().Be("O campo valor não aceita numeros negativos");
        }

        [TestMethod]
        public void DeveValidar_DoisTipoDeCobranca()
        {
            //arrange
            TaxasEServicos taxas = new TaxasEServicos("cadeirinha", 25, true, true);

            //action
            var resultado = taxas.Validar();

            //assert
            resultado.Should().Be("Só é possível selecionar um tipo de cobrança");
        }

        [TestMethod]
        public void DeveValidar_NenhumTipoDeCobranca()
        {
            //arrange
            TaxasEServicos taxas = new TaxasEServicos("cadeirinha", 25, false, false);

            //action
            var resultado = taxas.Validar();

            //assert
            resultado.Should().Be("Selecione um tipo de cobrança");
        }

    }
}
