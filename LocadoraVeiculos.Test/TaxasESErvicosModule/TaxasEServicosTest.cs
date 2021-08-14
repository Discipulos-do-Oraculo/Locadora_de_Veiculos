using FluentAssertions;
using LocadoraVeiculo.Dominio.TaxasEServicosModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Test.TaxasESErvicosModule
{

    [TestClass]
    [TestCategory("Dominio")]
    public class TaxasEServicosTest
    {
        [TestMethod]
        public void DeveValidar_Nome()
        {
            //arrange
            var taxasEServicos = new TaxasEServicos("", 20,true,false);

            //action
            var resultado = taxasEServicos.Validar();

            //assert
            resultado.Should().Be("O campo nome é obrigatório");

        }


        [TestMethod]
        public void DeveRetornar_TaxasEServicosValido()
        {
            //arrange
            var taxasEServicos = new TaxasEServicos("GPS", 20, true, false);

            //action
            var resultado = taxasEServicos.Validar();

            //assert
            resultado.Should().Be("ESTA_VALIDO");

        }

        [TestMethod]
        public void DeveValidar_ValorVazio()
        {


            //arrange
            int valor = default;
            var taxasEServicos = new TaxasEServicos("GPS", valor, true, false);

            //action
            var resultado = taxasEServicos.Validar();

            //assert
            resultado.Should().Be("O campo valor é obrigatório");

        }

        [TestMethod]
        public void DeveValidar_ValorMenorQueZero()
        {
            
            var taxasEServicos = new TaxasEServicos("GPS", -1, true, false);

            //action
            var resultado = taxasEServicos.Validar();

            //assert
            resultado.Should().Be("O campo valor não aceita numeros negativos");

        }

        [TestMethod]
        public void DeveValidar_ValorDoisTiposDeCobrançaChecados()
        {

            var taxasEServicos = new TaxasEServicos("GPS", 5, true, true);

            //action
            var resultado = taxasEServicos.Validar();

            //assert
            resultado.Should().Be("Só é possível selecionar um tipo de cobrança");

        }

        [TestMethod]
        public void DeveValidar_ValorDoisTiposDeCobrançaNaoChecados()
        {

            var taxasEServicos = new TaxasEServicos("GPS", 5, false, false);

            //action
            var resultado = taxasEServicos.Validar();

            //assert
            resultado.Should().Be("Selecione um tipo de cobrança");

        }

    }
}
