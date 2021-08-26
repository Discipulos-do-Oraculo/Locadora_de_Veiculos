using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocadoraVeiculo.Dominio.CupomModule;
using FluentAssertions;

namespace LocadoraVeiculos.Test.CupomModule
{

    [TestClass]
    [TestCategory("Dominio")]
    public class CupomTeste
    {

        [TestMethod]
        public void Deve_ValidarNome()
        {
            //arrange
            DateTime dataInicio = new DateTime(2020, 12, 20);
            DateTime dataFinal = new DateTime(2021, 12, 20);
            
            Midia midia = new Midia("INTERNET");
            Parceiro parceiro = new Parceiro("LOCUTOR BAND", midia);

            LocadoraVeiculo.Dominio.CupomModule.Cupom cupom = 
            new LocadoraVeiculo.Dominio.CupomModule.Cupom("",dataInicio,dataFinal, parceiro, 50,10,true,false);

            //action
            var resultado = cupom.Validar();

            //assert
            resultado.Should().Be("O campo nome é obrigatório");
        }


        [TestMethod]
        public void Deve_ValidarParceiro()
        {
            //arrange
            DateTime dataInicio = new DateTime(2020, 12, 20);
            DateTime dataFinal = new DateTime(2021, 12, 20);

            Midia midia = new Midia("INTERNET");

            LocadoraVeiculo.Dominio.CupomModule.Cupom cupom =
            new LocadoraVeiculo.Dominio.CupomModule.Cupom("TESTE", dataInicio, dataFinal, null, 50, 10, true, false);

            //action
            var resultado = cupom.Validar();

            //assert
            resultado.Should().Be("O campo Parceiro é obrigatório");
        }

        [TestMethod]
        public void Deve_ValidarDataInicio()
        {
            //arrange
            DateTime dataFinal = new DateTime(2021, 12, 20);

            Midia midia = new Midia("INTERNET");
            Parceiro parceiro = new Parceiro("LOCUTOR BAND", midia);

            LocadoraVeiculo.Dominio.CupomModule.Cupom cupom =
            new LocadoraVeiculo.Dominio.CupomModule.Cupom("TESTE", DateTime.MinValue, dataFinal, parceiro, 50, 10, true, false);

            //action
            var resultado = cupom.Validar();

            //assert
            resultado.Should().Be("O campo data início esta inválido");
        }

        [TestMethod]
        public void Deve_ValidarDataFinal()
        {
            //arrange
            DateTime dataInicio = new DateTime(2020, 12, 20);

            Midia midia = new Midia("INTERNET");
            Parceiro parceiro = new Parceiro("LOCUTOR BAND", midia);

            LocadoraVeiculo.Dominio.CupomModule.Cupom cupom =
            new LocadoraVeiculo.Dominio.CupomModule.Cupom("TESTE", dataInicio, DateTime.MinValue, parceiro, 50, 10, true, false);

            //action
            var resultado = cupom.Validar();

            //assert
            resultado.Should().Be("O campo data final esta inválido");
        }

        [TestMethod]
        public void Deve_ValidarDataFinalMaiorQueInicio()
        {
            //arrange
            DateTime dataInicio = new DateTime(2020, 12, 20);
            DateTime dataFinal = new DateTime(2019, 12, 20);

            Midia midia = new Midia("INTERNET");
            Parceiro parceiro = new Parceiro("LOCUTOR BAND", midia);

            LocadoraVeiculo.Dominio.CupomModule.Cupom cupom =
            new LocadoraVeiculo.Dominio.CupomModule.Cupom("TESTE", dataInicio, dataFinal, parceiro, 50, 10, true, false);

            //action
            var resultado = cupom.Validar();

            //assert
            resultado.Should().Be("O campo data final não pode ser menor que o campo data início");
        }

        [TestMethod]
        public void Deve_ValidarValorMinimoNegativo()
        {
            //arrange
            DateTime dataInicio = new DateTime(2020, 12, 20);
            DateTime dataFinal = new DateTime(2021, 12, 20);

            Midia midia = new Midia("INTERNET");
            Parceiro parceiro = new Parceiro("LOCUTOR BAND", midia);

            LocadoraVeiculo.Dominio.CupomModule.Cupom cupom =
            new LocadoraVeiculo.Dominio.CupomModule.Cupom("TESTE", dataInicio, dataFinal, parceiro, 50, -10, true, false);

            //action
            var resultado = cupom.Validar();

            //assert
            resultado.Should().Be("O campo valor mínimo não pode ser negativo");
        }

        [TestMethod]
        public void Deve_ValidarValorMinimo()
        {
            //arrange
            DateTime dataInicio = new DateTime(2020, 12, 20);
            DateTime dataFinal = new DateTime(2021, 12, 20);

            Midia midia = new Midia("INTERNET");
            Parceiro parceiro = new Parceiro("LOCUTOR BAND", midia);

            LocadoraVeiculo.Dominio.CupomModule.Cupom cupom =
            new LocadoraVeiculo.Dominio.CupomModule.Cupom("TESTE", dataInicio, dataFinal, parceiro, 20, default, true, false);

            //action
            var resultado = cupom.Validar();

            //assert
            resultado.Should().Be("O campo valor mínimo é obrigatório");
        }

        [TestMethod]
        public void Deve_ValidarValorNegativo()
        {
            //arrange
            DateTime dataInicio = new DateTime(2020, 12, 20);
            DateTime dataFinal = new DateTime(2021, 12, 20);

            Midia midia = new Midia("INTERNET");
            Parceiro parceiro = new Parceiro("LOCUTOR BAND", midia);

            LocadoraVeiculo.Dominio.CupomModule.Cupom cupom =
            new LocadoraVeiculo.Dominio.CupomModule.Cupom("TESTE", dataInicio, dataFinal, parceiro, -50, 10, true, false);

            //action
            var resultado = cupom.Validar();

            //assert
            resultado.Should().Be("O campo valor não pode ser negativo");
        }

        [TestMethod]
        public void Deve_ValidarValor()
        {
            //arrange
            DateTime dataInicio = new DateTime(2020, 12, 20);
            DateTime dataFinal = new DateTime(2021, 12, 20);

            Midia midia = new Midia("INTERNET");
            Parceiro parceiro = new Parceiro("LOCUTOR BAND", midia);

            LocadoraVeiculo.Dominio.CupomModule.Cupom cupom =
            new LocadoraVeiculo.Dominio.CupomModule.Cupom("TESTE", dataInicio, dataFinal, parceiro, default, 20, true, false);

            //action
            var resultado = cupom.Validar();

            //assert
            resultado.Should().Be("O campo valor é obrigatório");
        }



    }
}
