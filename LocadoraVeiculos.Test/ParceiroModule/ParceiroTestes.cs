using FluentAssertions;
using LocadoraVeiculo.Dominio.CupomModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LocadoraVeiculos.Test.ParceiroModule
{
    [TestClass]
    [TestCategory("Domínio")]

    public class ParceiroTestes
    {
        [TestMethod]
        public void DeveRetornar_ParceiroValido()
        {
            //arrange
            Midia midia = new Midia("Internet");
            var parceiro = new Parceiro("Desconto do Deko", midia);

            //action
            var resultado = parceiro.Validar();

            //assert
            resultado.Should().Be("ESTA_VALIDO");
        }

        [TestMethod]
        public void DeveValidar_Nome()
        {
            //arrange
            Midia midia = new Midia("Internet");
            var parceiro = new Parceiro("", midia);

            //action
            var resultado = parceiro.Validar();

            //assert
            resultado.Should().Be("O campo nome é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_Midia()
        {
            //arrange
            var parceiro = new Parceiro("Desconto do Deko", null);

            //action
            var resultado = parceiro.Validar();

            //assert
            resultado.Should().Be("O campo Mídia é obrigatório");
        }
    }
}
