using FluentAssertions;
using LocadoraVeiculo.Dominio.ClienteModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LocadoraVeiculos.Test.FuncionarioModule
{
    [TestClass]
    [TestCategory("Dominio")]
    public class FuncionarioTeste
    {
        [TestMethod]
        public void DeveRetornar_FuncionarioValido()
        {
            //arrange
            var funcionario = new Colaborador("zezo vitória", "rua dos gatinhos", "zezoVitoria@gatinhos.com","lages", "sc", "322220309", "999121315", "1231", "0101", "zezin", "123", new DateTime (2021, 08, 13), 4500);

            //action
            var resultado = funcionario.Validar();

            //assert
            resultado.Should().Be("ESTA_VALIDO");
        }

        [TestMethod]
        public void DeveValidar_Nome()
        {
            //arrange
            var cliente = new Colaborador("", "rua dos gatinhos", "zezoVitoria@gatinhos.com", "lages", "sc", "322220309", "999121315", "1231", "0101", "zezin", "123", new DateTime(2021, 08, 13), 4500);

            //action
            var resultado = cliente.Validar();

            //assert
            resultado.Should().Be("O campo nome é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_Cpf()
        {
            //arrange
            var cliente = new  Colaborador("zezo vitória", "rua dos gatinhos", "zezoVitoria@gatinhos.com", "lages", "sc", "322220309", "999121315", "1231", "", "zezin", "123", new DateTime(2021, 08, 13), 4500);

            //action
            var resultado = cliente.Validar();

            //assert
            resultado.Should().Be("O campo CPF é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_Rg()
        {
            //arrange
            var cliente = new Colaborador("zezo vitória", "rua dos gatinhos", "zezoVitoria@gatinhos.com", "lages", "sc", "322220309", "999121315", "", "0101", "zezin", "123", new DateTime(2021, 08, 13), 4500);

            //action
            var resultado = cliente.Validar();

            //assert
            resultado.Should().Be("O campo Rg é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_TelefoneNulo()
        {
            //arrange
            var cliente = new Colaborador("zezo vitória", "rua dos gatinhos", "zezoVitoria@gatinhos.com", "lages", "sc", "", "999121315", "1231", "0101", "zezin", "123", new DateTime(2021, 08, 13), 4500);

            //action
            var resultado = cliente.Validar();

            //assert
            resultado.Should().Be("O campo telefone é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_TelefoneInvalido()
        {
            //arrange
            var cliente = new Colaborador("zezo vitória", "rua dos gatinhos", "zezoVitoria@gatinhos.com", "lages", "sc", "123", "999121315", "1231", "0101", "zezin", "123", new DateTime(2021, 08, 13), 4500);

            //action
            var resultado = cliente.Validar();

            //assert
            resultado.Should().Be("O campo Telefone está inválido");
        }

        [TestMethod]
        public void DeveValidar_EmailNulo()
        {
            //arrange
            var cliente = new Colaborador("zezo vitória", "rua dos gatinhos", "", "lages", "sc", "322220309", "999121315", "1231", "0101", "zezin", "123", new DateTime(2021, 08, 13), 4500);

            //action
            var resultado = cliente.Validar();

            //assert
            resultado.Should().Be("O campo email é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_EmailInvalido()
        {
            //arrange
            var cliente = new Colaborador("zezo vitória", "rua dos gatinhos", "zezo.@gata", "lages", "sc", "322220309", "999121315", "1231", "0101", "zezin", "123", new DateTime(2021, 08, 13), 4500);

            //action
            var resultado = cliente.Validar();

            //assert
            resultado.Should().Be("O campo Email está inválido");
        }

        [TestMethod]
        public void DeveValidar_Cidade()
        {
            //arrange
            var cliente = new Colaborador("zezo vitória", "rua dos gatinhos", "zezoVitoria@gatinhos.com", "", "sc", "322220309", "999121315", "1231", "0101", "zezin", "123", new DateTime(2021, 08, 13), 4500);

            //action
            var resultado = cliente.Validar();

            //assert
            resultado.Should().Be("O campo cidade é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_Endereco()
        {
            //arrange
            var cliente = new Colaborador("zezo vitória", "", "zezoVitoria@gatinhos.com", "lages", "sc", "322220309", "999121315", "1231", "0101", "zezin", "123", new DateTime(2021, 08, 13), 4500);

            //action
            var resultado = cliente.Validar();

            //assert
            resultado.Should().Be("O campo endereço é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_CelularNulo()
        {
            //arrange
            var cliente = new Colaborador("zezo vitória", "rua dos gatinhos", "zezoVitoria@gatinhos.com", "lages", "sc", "322220309", "", "1231", "0101", "zezin", "123", new DateTime(2021, 08, 13), 4500);


            //action
            var resultado = cliente.Validar();

            //assert
            resultado.Should().Be("O campo celular é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_CelularInvalido()
        {
            //arrange
            var cliente = new Colaborador("zezo vitória", "rua dos gatinhos", "zezoVitoria@gatinhos.com", "lages", "sc", "322220309", "123", "1231", "0101", "zezin", "123", new DateTime(2021, 08, 13), 4500);


            //action
            var resultado = cliente.Validar();

            //assert
            resultado.Should().Be("O campo Celular está inválido");
        }

        [TestMethod]
        public void DeveValidar_Estado()
        {
            //arrange
            var cliente = new Colaborador("zezo vitória", "rua dos gatinhos", "zezoVitoria@gatinhos.com", "lages", "", "322220309", "999121315", "1231", "0101", "zezin", "123", new DateTime(2021, 08, 13), 4500);

            //action
            var resultado = cliente.Validar();

            //assert
            resultado.Should().Be("O campo estado é obrigatório");
        }
    }
}
