using FluentAssertions;
using LocadoraVeiculo.Dominio.ClienteModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LocadoraVeiculos.Test.ClientePFModule
{
    [TestClass]
    [TestCategory("Dominio")]
    public class ClientePfTeste
    {
        [TestMethod]
        public void DeveValidar_Email()
        {
            //arrange
            var cliente = new ClientePF("Rechão", "rua", "rech.felipao@gmail", "Lages", "SC", "321654987", "999121315", "1111111", "22222222", "12314", new DateTime(2022, 06, 07));
            
            //action
            var resultadoValidacao = cliente.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo Email está inválido");
        }

        [TestMethod]
        public void DeveValidar_TelefoneNulo()
        {
            //arrange
            var cliente = new ClientePF("Rechão", "rua", "rechFelipao@gmail.com", "Lages", "SC", "", "999121315", "1111111", "22222222", "12314", new DateTime(2022, 06, 07));

            //action
            var resultadoValidacao = cliente.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo Telefone é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_Telefone()
        {
            //arrange
            var cliente = new ClientePF("Rechão", "rua", "rechFelipao@gmail.com", "Lages", "SC", "3216", "999121315", "1111111", "22222222", "12314", new DateTime(2022, 06, 07));

            //action
            var resultadoValidacao = cliente.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo Telefone está inválido");
        }

        [TestMethod]
        public void DeveValidar_Nome()
        {
            //arrange
            var cliente = new ClientePF("", "rua", "rechFelipao@gmail.com", "Lages", "SC", "321654987", "999121315", "1111111", "22222222", "12314", new DateTime(2022, 06, 07));

            //action
            var resultadoValidacao = cliente.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo nome é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_Endereco()
        {
            //arrange
            var cliente = new ClientePF("Rechão", "", "rechFelipao@gmail.com", "Lages", "SC", "321654987", "999121315", "1111111", "22222222", "12314", new DateTime(2022, 06, 07));

            //action
            var resultadoValidacao = cliente.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo endereço é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_Cidade()
        {
            //arrange
            var cliente = new ClientePF("Rechão", "rua", "rechFelipao@gmail.com", "", "SC", "321654987", "999121315", "1111111", "22222222", "12314", new DateTime(2022, 06, 07));

            //action
            var resultadoValidacao = cliente.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo cidade é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_Estado()
        {
            //arrange
            var cliente = new ClientePF("Rechão", "rua", "rechFelipao@gmail.com", "Lages", "", "321654987", "999121315", "1111111", "22222222", "12314", new DateTime(2022, 06, 07));

            //action
            var resultadoValidacao = cliente.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo estado é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_CelularNulo()
        {
            //arrange
            var cliente = new ClientePF("Rechão", "rua", "rechFelipao@gmail.com", "Lages", "SC", "321654987", "", "1111111", "22222222", "12314", new DateTime(2022, 06, 07));

            //action
            var resultadoValidacao = cliente.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo Celular é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_Celular()
        {
            //arrange
            var cliente = new ClientePF("Rechão", "rua", "rechFelipao@gmail.com", "Lages", "SC", "321654987", "99912", "1111111", "22222222", "12314", new DateTime(2022, 06, 07));

            //action
            var resultadoValidacao = cliente.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo Celular está inválido");
        }
    }
}
