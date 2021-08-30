using LocadoraVeiculo.Dominio.ClienteModule;
using LocadoraVeiculo.Dominio.CombustivelModule;
using LocadoraVeiculo.Dominio.DevolucaoModule;
using LocadoraVeiculo.Dominio.GrupoDeVeiculosModule;
using LocadoraVeiculo.Dominio.LocacaoModule;
using LocadoraVeiculo.Dominio.VeiculoModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FluentAssertions;
namespace LocadoraVeiculos.Test.DevolucaoModule
{
    [TestClass]
    [TestCategory("Dominio")]
    public class DevolucaoTeste
    {
        [TestMethod]
        public void DeveValidar_valorTotal_e_menorQueZero()
        {
            //arrange
            var dataValidadeCnh = System.DateTime.Now;
            dataValidadeCnh = dataValidadeCnh.AddYears(2);
            var cliente = new ClientePF("ClietneTeste", "rua santa terezinha", "test@test.com", "Lages", "SC", "22222222","22222222","123456","12345678966","123456", 
                dataValidadeCnh) ;

            var grupoVeiculo = new GrupoDeVeiculos("vans", 60, 2, 3, 200, 4,4);
            byte[] imagem = { 1, 2, 3 };
            var veiculo = new Veiculo("classic","branco","chevrolet","ERA1234","4568979",12020,4,45,5,2012, grupoVeiculo,PortaMalaVeiculoEnum.Medio, imagem);

            var dataSaida = System.DateTime.Now;
            var dataRetorno = dataSaida.AddDays(5);
            var locacao = new Locacao(cliente, veiculo,"planoTest", dataSaida, dataRetorno,350,2000,12345,null);

            var tipoCombustivel = new Combustivel("gasolina", 6);

            var devolucao = new Devolucao(locacao, tipoCombustivel,dataRetorno,117,254,-1);

            //action
            var resultadoValidacao = devolucao.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo valor total não pode ser menor que zero");
        }

        [TestMethod]
        public void DeveValidar_LocacaoObrigatoria()
        {
            //arrange
            var dataValidadeCnh = System.DateTime.Now;
            dataValidadeCnh = dataValidadeCnh.AddYears(2);
            var cliente = new ClientePF("ClietneTeste", "rua santa terezinha", "test@test.com", "Lages", "SC", "22222222", "22222222", "123456", "12345678966", "123456",
                dataValidadeCnh);

            var grupoVeiculo = new GrupoDeVeiculos("vans", 60, 2, 3, 200, 4,5);
            byte[] imagem = { 1, 2, 3 };
            var veiculo = new Veiculo("classic", "branco", "chevrolet", "ERA1234", "4568979", 12020, 4, 45, 5, 2012, grupoVeiculo, PortaMalaVeiculoEnum.Medio, imagem);

            var dataSaida = System.DateTime.Now;
            var dataRetorno = dataSaida.AddDays(5);
            Locacao locacao = null;

            var tipoCombustivel = new Combustivel("gasolina", 6);

            var devolucao = new Devolucao(locacao, tipoCombustivel, dataRetorno, 117, 254, 100);

            //action
            var resultadoValidacao = devolucao.Validar();

            //assert
            resultadoValidacao.Should().Be("Selecione uma locação para realizar devolução");
        }

        [TestMethod]
        public void DeveValidar_KmFinalObrigatorio()
        {
            //arrange
            var dataValidadeCnh = System.DateTime.Now;
            dataValidadeCnh = dataValidadeCnh.AddYears(2);
            var cliente = new ClientePF("ClietneTeste", "rua santa terezinha", "test@test.com", "Lages", "SC", "22222222", "22222222", "123456", "12345678966", "123456",
                dataValidadeCnh);

            var grupoVeiculo = new GrupoDeVeiculos("vans", 60, 2, 3, 200,4, 4);
            byte[] imagem = { 1, 2, 3 };
            var veiculo = new Veiculo("classic", "branco", "chevrolet", "ERA1234", "4568979", 12020, 4, 45, 5, 2012, grupoVeiculo, PortaMalaVeiculoEnum.Medio, imagem);

            var dataSaida = System.DateTime.Now;
            var dataRetorno = dataSaida.AddDays(5);
            Locacao locacao = null;

            var tipoCombustivel = new Combustivel("gasolina", 6);

            var devolucao = new Devolucao(locacao, tipoCombustivel, dataRetorno, default, 254, 100);

            //action
            var resultadoValidacao = devolucao.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo Km Final é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_KmFinalMenorQueZero()
        {
            //arrange
            var dataValidadeCnh = System.DateTime.Now;
            dataValidadeCnh = dataValidadeCnh.AddYears(2);
            var cliente = new ClientePF("ClietneTeste", "rua santa terezinha", "test@test.com", "Lages", "SC", "22222222", "22222222", "123456", "12345678966", "123456",
                dataValidadeCnh);

            var grupoVeiculo = new GrupoDeVeiculos("vans", 60, 2, 3, 200, 4,4);
            byte[] imagem = { 1, 2, 3 };
            var veiculo = new Veiculo("classic", "branco", "chevrolet", "ERA1234", "4568979", 12020, 4, 45, 5, 2012, grupoVeiculo, PortaMalaVeiculoEnum.Medio, imagem);

            var dataSaida = System.DateTime.Now;
            var dataRetorno = dataSaida.AddDays(5);
            Locacao locacao = null;

            var tipoCombustivel = new Combustivel("gasolina", 6);

            var devolucao = new Devolucao(locacao, tipoCombustivel, dataRetorno, -2, 254, 100);

            //action
            var resultadoValidacao = devolucao.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo Km Final não pode ser negativo");
        }

        [TestMethod]
        public void DeveValidar_LitrosCombustivelObrigatorio()
        {
            //arrange
            var dataValidadeCnh = System.DateTime.Now;
            dataValidadeCnh = dataValidadeCnh.AddYears(2);
            var cliente = new ClientePF("ClietneTeste", "rua santa terezinha", "test@test.com", "Lages", "SC", "22222222", "22222222", "123456", "12345678966", "123456",
                dataValidadeCnh);

            var grupoVeiculo = new GrupoDeVeiculos("vans", 60, 2, 3, 200, 4,4);
            byte[] imagem = { 1, 2, 3 };
            var veiculo = new Veiculo("classic", "branco", "chevrolet", "ERA1234", "4568979", 12020, 4, 45, 5, 2012, grupoVeiculo, PortaMalaVeiculoEnum.Medio, imagem);

            var dataSaida = System.DateTime.Now;
            var dataRetorno = dataSaida.AddDays(5);
            Locacao locacao = null;

            var tipoCombustivel = new Combustivel("gasolina", 6);

            var devolucao = new Devolucao(locacao, tipoCombustivel, dataRetorno, 254, default, 100);

            //action
            var resultadoValidacao = devolucao.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo Litros Gastos é obrigatório");
        }
        [TestMethod]
        public void DeveValidar_LitrosGastos_e_menorQueZero()
        {
            //arrange
            var dataValidadeCnh = System.DateTime.Now;
            dataValidadeCnh = dataValidadeCnh.AddYears(2);
            var cliente = new ClientePF("ClietneTeste", "rua santa terezinha", "test@test.com", "Lages", "SC", "22222222", "22222222", "123456", "12345678966", "123456",
                dataValidadeCnh);

            var grupoVeiculo = new GrupoDeVeiculos("vans", 60, 2, 3, 200, 4,2);
            byte[] imagem = { 1, 2, 3 };
            var veiculo = new Veiculo("classic", "branco", "chevrolet", "ERA1234", "4568979", 12020, 4, 45, 5, 2012, grupoVeiculo, PortaMalaVeiculoEnum.Medio, imagem);

            var dataSaida = System.DateTime.Now;
            var dataRetorno = dataSaida.AddDays(5);
            var locacao = new Locacao(cliente, veiculo, "planoTest", dataSaida, dataRetorno, 350, 2000, 12345,null);

            var tipoCombustivel = new Combustivel("gasolina", 6);

            var devolucao = new Devolucao(locacao, tipoCombustivel, dataRetorno, 117, -2, 256);

            //action
            var resultadoValidacao = devolucao.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo Litros Gastos não pode ser menor que zero");
        }
    }
}
