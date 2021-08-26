using FluentAssertions;
using LocadoraVeiculo.Dominio.CupomModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LocadoraVeiculos.Test.MidiaModule
{
    [TestClass]
    [TestCategory("Domínio")]

    public class MidiaTestes
    {
        [TestMethod]
        public void DeveRetornar_MidiaValida()
        {
            //arrange
            Midia midia = new Midia("Internet");

            //action
            var resultado = midia.Validar();

            //assert
            resultado.Should().Be("ESTA_VALIDO");
        }

        [TestMethod]
        public void DeveValidar_Nome()
        {
            //arrange
            Midia midia = new Midia("");

            //action
            var resultado = midia.Validar();

            //assert
            resultado.Should().Be("O campo nome é obrigatório");
        }
    }
}
