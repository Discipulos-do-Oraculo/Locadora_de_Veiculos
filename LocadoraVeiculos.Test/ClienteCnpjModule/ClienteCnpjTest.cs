using FluentAssertions;
using LocadoraVeiculo.Dominio.ClienteModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LocadoraVeiculos.Test.ClienteCnpjModule
{
    [TestClass]
    [TestCategory("Dominio")]
    public class ClienteCnpjTest
    {
        [TestMethod]
        public void DeveRetornar_ClienteCnpj()
        {
            //arrange
            var cliente = new ClienteCnpj("ndd", "06255692", "32220309", "nddtech@gmail.com", "lages", "rua", "999121315", "sc");

            //action
            var resultado = cliente.Validar();

            //assert
            resultado.Should().Be("ESTA_VALIDO");
        }

        [TestMethod]
        public void DeveValidar_Nome()
        {
            //arrange
            var cliente = new ClienteCnpj("", "06255692", "32220309", "nddtech@gmail.com", "lages", "rua", "999121315", "sc");

            //action
            var resultado = cliente.Validar();

            //assert
            resultado.Should().Be("O campo Nome é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_Cnpj()
        {
            //arrange
            var cliente = new ClienteCnpj("ndd", "", "32220309", "nddtech@gmail.com", "lages", "rua", "999121315", "sc");

            //action
            var resultado = cliente.Validar();

            //assert
            resultado.Should().Be("O campo CNPJ é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_Telefone()
        {
            //arrange
            var cliente = new ClienteCnpj("ndd", "06255692", "", "nddtech@gmail.com", "lages", "rua", "999121315", "sc");

            //action
            var resultado = cliente.Validar();

            //assert
            resultado.Should().Be("O campo Telefone é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_Email()
        {
            //arrange
            var cliente = new ClienteCnpj("ndd", "06255692", "32220309", "", "lages", "rua", "999121315", "sc");

            //action
            var resultado = cliente.Validar();

            //assert
            resultado.Should().Be("O campo Email é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_Cidade()
        {
            //arrange
            var cliente = new ClienteCnpj("ndd", "06255692", "32220309", "nddtech@gmail.com", "", "rua", "999121315", "sc");

            //action
            var resultado = cliente.Validar();

            //assert
            resultado.Should().Be("O campo Cidade é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_Endereco()
        {
            //arrange
            var cliente = new ClienteCnpj("ndd", "06255692", "32220309", "nddtech@gmail.com", "lages", "", "999121315", "sc");

            //action
            var resultado = cliente.Validar();

            //assert
            resultado.Should().Be("O campo Endereço é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_Celular()
        {
            //arrange
            var cliente = new ClienteCnpj("ndd", "06255692", "32220309", "nddtech@gmail.com", "lages", "rua", "", "sc");

            //action
            var resultado = cliente.Validar();

            //assert
            resultado.Should().Be("O campo Celular é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_Estado()
        {
            //arrange
            var cliente = new ClienteCnpj("ndd", "06255692", "32220309", "nddtech@gmail.com", "lages", "rua", "999121315", "");

            //action
            var resultado = cliente.Validar();

            //assert
            resultado.Should().Be("O campo Estado é obrigatório");
        }
    }
}
