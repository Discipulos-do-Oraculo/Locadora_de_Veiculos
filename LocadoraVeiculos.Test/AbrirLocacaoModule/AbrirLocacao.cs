using FluentAssertions;
using LocadoraVeiculo.Dominio.ClienteModule;
using LocadoraVeiculo.Dominio.GrupoDeVeiculosModule;
using LocadoraVeiculo.Dominio.LocacaoModule;
using LocadoraVeiculo.Dominio.VeiculoModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Test.AbrirLocacaoModule
{
    [TestClass]
    [TestCategory("Dominio")]
    public class AbrirLocacao
    {
        [TestMethod]
        public void Deve_ValidarVeiculo() {

            
            //Arrange
            ClienteCnpj clienteCnpj = new ClienteCnpj("TORTELI","22222222","123","TORTELI@GMAIL.COM","LAGES","RUA","499999999","SC");
            DateTime data = new DateTime(2021, 12, 06);
            Condutor condutor = new Condutor("JOSE","RUA","JOSE@GMAIL.COM","LAGES","SC","499999999","4999999999","3333330","22222222222222","2222222222222222", data, clienteCnpj);
            Locacao locacao = new Locacao(clienteCnpj, condutor, null,"Diario",new DateTime (2020,12,11), new DateTime(2021, 01, 12),50,50,20);

            //Action
            var resultadovalidacao = locacao.Validar();

            //Assert
            resultadovalidacao.Should().Be("selecione o veículo para locação");
        }

        [TestMethod]
        public void Deve_ValidarPlano()
        {
            DateTime data = new DateTime(2021, 12, 06);
            byte[] imagem = { 1, 2, 3 };
            
            //Arrange
            ClienteCnpj clienteCnpj = new ClienteCnpj("TORTELI", "22222222", "123", "TORTELI@GMAIL.COM", "LAGES", "RUA", "499999999", "SC");
            Condutor condutor = new Condutor("JOSE", "RUA", "JOSE@GMAIL.COM", "LAGES", "SC", "499999999", "4999999999", "3333330", "22222222222222", "2222222222222222", data, clienteCnpj);
            var grupoVeiculos = new GrupoDeVeiculos("Utilitário", 50, 20, 30, 40, 50,20);
            Veiculo veiculo = new Veiculo("weqeqeq", "Verde", "bmw", "PHE-W233", "32EWQEQEQ", 10, 20, 2, 4, 2002, grupoVeiculos, PortaMalaVeiculoEnum.Medio, imagem);
            
            Locacao locacao = new Locacao(clienteCnpj, condutor, veiculo, String.Empty, new DateTime(2020, 12, 11), new DateTime(2021, 01, 12), 50, 50, 20);

            //Action
            var resultadovalidacao = locacao.Validar();

            //Assert
            resultadovalidacao.Should().Be("selecione o plano para locação");
        }

        [TestMethod]
        public void Deve_ValidarKmInicial()
        {
            DateTime data = new DateTime(2021, 12, 06);
            byte[] imagem = { 1, 2, 3 };

            //Arrange
            ClienteCnpj clienteCnpj = new ClienteCnpj("TORTELI", "22222222", "123", "TORTELI@GMAIL.COM", "LAGES", "RUA", "499999999", "SC");
            Condutor condutor = new Condutor("JOSE", "RUA", "JOSE@GMAIL.COM", "LAGES", "SC", "499999999", "4999999999", "3333330", "22222222222222", "2222222222222222", data, clienteCnpj);
            var grupoVeiculos = new GrupoDeVeiculos("Utilitário", 50, 20, 30, 40, 50,20);
            Veiculo veiculo = new Veiculo("weqeqeq", "Verde", "bmw", "PHE-W233", "32EWQEQEQ", 10, 20, 2, 4, 2002, grupoVeiculos, PortaMalaVeiculoEnum.Medio, imagem);

            Locacao locacao = new Locacao(clienteCnpj, condutor, veiculo, "Diário", new DateTime(2020, 12, 11), new DateTime(2021, 01, 12), 50, 50,-1);

            //Action
            var resultadovalidacao = locacao.Validar();

            //Assert
            resultadovalidacao.Should().Be("o campo Km Inicial não pode ser menor que zero");
        }

        [TestMethod]
        public void Deve_ValidarDataSaida()
        {
            DateTime data = new DateTime(2021, 12, 06);
            byte[] imagem = { 1, 2, 3 };

            //Arrange
            ClienteCnpj clienteCnpj = new ClienteCnpj("TORTELI", "22222222", "123", "TORTELI@GMAIL.COM", "LAGES", "RUA", "499999999", "SC");
            Condutor condutor = new Condutor("JOSE", "RUA", "JOSE@GMAIL.COM", "LAGES", "SC", "499999999", "4999999999", "3333330", "22222222222222", "2222222222222222", data, clienteCnpj);
            var grupoVeiculos = new GrupoDeVeiculos("Utilitário", 50, 20, 30, 40, 50,20);
            Veiculo veiculo = new Veiculo("weqeqeq", "Verde", "bmw", "PHE-W233", "32EWQEQEQ", 10, 20, 2, 4, 2002, grupoVeiculos, PortaMalaVeiculoEnum.Medio, imagem);

            Locacao locacao = new Locacao(clienteCnpj, condutor, veiculo, "Diário", DateTime.MinValue, new DateTime(2021, 01, 12), 50, 50, 10);

            //Action
            var resultadovalidacao = locacao.Validar();

            //Assert
            resultadovalidacao.Should().Be("data saida inválida");
        }

        [TestMethod]
        public void Deve_ValidarDataRetorno()
        {
            DateTime data = new DateTime(2021, 12, 06);
            byte[] imagem = { 1, 2, 3 };

            //Arrange
            ClienteCnpj clienteCnpj = new ClienteCnpj("TORTELI", "22222222", "123", "TORTELI@GMAIL.COM", "LAGES", "RUA", "499999999", "SC");
            Condutor condutor = new Condutor("JOSE", "RUA", "JOSE@GMAIL.COM", "LAGES", "SC", "499999999", "4999999999", "3333330", "22222222222222", "2222222222222222", data, clienteCnpj);
            var grupoVeiculos = new GrupoDeVeiculos("Utilitário", 50, 20, 30, 40, 50,20);
            Veiculo veiculo = new Veiculo("weqeqeq", "Verde", "bmw", "PHE-W233", "32EWQEQEQ", 10, 20, 2, 4, 2002, grupoVeiculos, PortaMalaVeiculoEnum.Medio, imagem);

            Locacao locacao = new Locacao(clienteCnpj, condutor, veiculo, "Diário", new DateTime(2020,01,12), DateTime.MinValue, 50, 50, 10);

            //Action
            var resultadovalidacao = locacao.Validar();

            //Assert
            resultadovalidacao.Should().Be("data retorno inválida");
        }

        [TestMethod]
        public void Deve_ValidarDataRetornoMaiorQueDataSaida()
        {
            DateTime data = new DateTime(2021, 12, 06);
            byte[] imagem = { 1, 2, 3 };

            //Arrange
            ClienteCnpj clienteCnpj = new ClienteCnpj("TORTELI", "22222222", "123", "TORTELI@GMAIL.COM", "LAGES", "RUA", "499999999", "SC");
            Condutor condutor = new Condutor("JOSE", "RUA", "JOSE@GMAIL.COM", "LAGES", "SC", "499999999", "4999999999", "3333330", "22222222222222", "2222222222222222", data, clienteCnpj);
            var grupoVeiculos = new GrupoDeVeiculos("Utilitário", 50, 20, 30, 40, 50,20);
            Veiculo veiculo = new Veiculo("weqeqeq", "Verde", "bmw", "PHE-W233", "32EWQEQEQ", 10, 20, 2, 4, 2002, grupoVeiculos, PortaMalaVeiculoEnum.Medio, imagem);

            Locacao locacao = new Locacao(clienteCnpj, condutor, veiculo, "Diário", new DateTime(2020, 01, 12), new DateTime(2019,01,03), 50, 50, 10);

            //Action
            var resultadovalidacao = locacao.Validar();

            //Assert
            resultadovalidacao.Should().Be("data retorno inválida");
        }

        [TestMethod]
        public void Deve_ValidarValorGarantia()
        {
            DateTime data = new DateTime(2021, 12, 06);
            byte[] imagem = { 1, 2, 3 };

            //Arrange
            ClienteCnpj clienteCnpj = new ClienteCnpj("TORTELI", "22222222", "123", "TORTELI@GMAIL.COM", "LAGES", "RUA", "499999999", "SC");
            Condutor condutor = new Condutor("JOSE", "RUA", "JOSE@GMAIL.COM", "LAGES", "SC", "499999999", "4999999999", "3333330", "22222222222222", "2222222222222222", data, clienteCnpj);
            var grupoVeiculos = new GrupoDeVeiculos("Utilitário", 50, 20, 30, 40, 50,20);
            Veiculo veiculo = new Veiculo("weqeqeq", "Verde", "bmw", "PHE-W233", "32EWQEQEQ", 10, 20, 2, 4, 2002, grupoVeiculos, PortaMalaVeiculoEnum.Medio, imagem);

            Locacao locacao = new Locacao(clienteCnpj, condutor, veiculo, "Diário", new DateTime(2020, 01, 12), new DateTime(2022, 01, 03), 50, 0, 10);

            //Action
            var resultadovalidacao = locacao.Validar();

            //Assert
            resultadovalidacao.Should().Be("o campo valor garantia tem que ser maior que zero");
        }

        [TestMethod]
        public void Deve_ValidarValorTotal()
        {
            DateTime data = new DateTime(2021, 12, 06);
            byte[] imagem = { 1, 2, 3 };

            //Arrange
            ClienteCnpj clienteCnpj = new ClienteCnpj("TORTELI", "22222222", "123", "TORTELI@GMAIL.COM", "LAGES", "RUA", "499999999", "SC");
            Condutor condutor = new Condutor("JOSE", "RUA", "JOSE@GMAIL.COM", "LAGES", "SC", "499999999", "4999999999", "3333330", "22222222222222", "2222222222222222", data, clienteCnpj);
            var grupoVeiculos = new GrupoDeVeiculos("Utilitário", 50, 20, 30, 40, 50,3);
            Veiculo veiculo = new Veiculo("weqeqeq", "Verde", "bmw", "PHE-W233", "32EWQEQEQ", 10, 20, 2, 4, 2002, grupoVeiculos, PortaMalaVeiculoEnum.Medio, imagem);

            Locacao locacao = new Locacao(clienteCnpj, condutor, veiculo, "Diário", new DateTime(2020, 01, 12), new DateTime(2022, 01, 03), -1, 12, 10);

            //Action
            var resultadovalidacao = locacao.Validar();

            //Assert
            resultadovalidacao.Should().Be("o campo valor total não pode ser menor ou igual a zero");
        }

        [TestMethod]
        public void Deve_ValidarEstaValido()
        {
            DateTime data = new DateTime(2021, 12, 06);
            byte[] imagem = { 1, 2, 3 };

            //Arrange
            ClienteCnpj clienteCnpj = new ClienteCnpj("TORTELI", "22222222", "123", "TORTELI@GMAIL.COM", "LAGES", "RUA", "499999999", "SC");
            Condutor condutor = new Condutor("JOSE", "RUA", "JOSE@GMAIL.COM", "LAGES", "SC", "499999999", "4999999999", "3333330", "22222222222222", "2222222222222222", data, clienteCnpj);
            var grupoVeiculos = new GrupoDeVeiculos("Utilitário", 50, 20, 30, 40, 50,20);
            Veiculo veiculo = new Veiculo("weqeqeq", "Verde", "bmw", "PHE-W233", "32EWQEQEQ", 10, 20, 2, 4, 2002, grupoVeiculos, PortaMalaVeiculoEnum.Medio, imagem);

            Locacao locacao = new Locacao(clienteCnpj, condutor, veiculo, "Diário", new DateTime(2020, 01, 12), new DateTime(2022, 01, 03), 20, 12, 10);

            //Action
            var resultadovalidacao = locacao.Validar();

            //Assert
            resultadovalidacao.Should().Be("ESTA_VALIDO");
        }
    }
}
