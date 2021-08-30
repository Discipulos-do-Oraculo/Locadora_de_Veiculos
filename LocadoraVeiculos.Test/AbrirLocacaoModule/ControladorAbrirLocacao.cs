using FluentAssertions;
using LocadoraVeiculo.Dominio.ClienteModule;
using LocadoraVeiculo.Dominio.GrupoDeVeiculosModule;
using LocadoraVeiculo.Dominio.LocacaoModule;
using LocadoraVeiculo.Dominio.VeiculoModule;
using LocadoraVeiculos.Controlador;
using LocadoraVeiculos.Controlador.ClienteModule.ClienteCnpjControlador;
using LocadoraVeiculos.Controlador.ClienteModule.ClientePfControlador;
using LocadoraVeiculos.Controlador.ClienteModule.CondutorControlador;
using LocadoraVeiculos.Controlador.GrupoDeVeiculosModule;
using LocadoraVeiculos.Controlador.LocacaoModule;
using LocadoraVeiculos.Controlador.VeiculoModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Test.AbrirLocacaoModule
{
    [TestClass]
    [TestCategory("Controladores")]

    
    public class ControladorAbrirLocacao
    {
        private ControladorLocacao controladorLocacao = null;
        private ControladorCondutor controladorCondutor = null;
        private ControladorGrupoDeVeiculos controladorGrupoVeiculo = null;
        private ControladorVeiculo controladorVeiuclo = null;
        private ControladorClienteCnpj controladorClienteCnpj = null;
        private ControladorClientePF controladorClientePF = null;
        public ControladorAbrirLocacao()
        {
            controladorGrupoVeiculo = new ControladorGrupoDeVeiculos();
            controladorVeiuclo = new ControladorVeiculo();
            controladorClienteCnpj = new ControladorClienteCnpj();
            controladorClientePF = new ControladorClientePF();
            controladorCondutor = new ControladorCondutor();
            controladorLocacao = new ControladorLocacao();

            Db.Update("DELETE FROM [TBLOCACAO]");
            Db.Update("DELETE FROM [TBVEICULOS]");
            Db.Update("DELETE FROM [TBGRUPODEVEICULOS]");
            Db.Update("DELETE FROM [TBCONDUTOR]");
            Db.Update("DELETE FROM [TBCLIENTEPJ]");
            Db.Update("DELETE FROM [TBLOCACAO_TBTAXASESERVICOS]");
            
            
        }

        [TestMethod]
        public void Deve_AbrirLocacaoParaEmpresa()
        {
            DateTime data = new DateTime(2021, 12, 06);
            byte[] imagem = { 1, 2, 3 };

            //Arrange
            ClienteCnpj clienteCnpj = new ClienteCnpj("TORTELI", "22222222", "123456789", "TORTELI@GMAIL.COM", "LAGES", "RUA", "499999999", "SC");
            Condutor condutor = new Condutor("JOSE", "RUA", "JOSE@GMAIL.COM", "LAGES", "SC", "49999999", "499999977", "33333307", "2222222", "222222222", data, clienteCnpj);
            var grupoVeiculos = new GrupoDeVeiculos("Utilitário", 50, 20, 30, 40, 50,20);
            Veiculo veiculo = new Veiculo("weqeqeq", "Verde", "bmw", "ABD1234", "32EWQEQEQ", 10, 20, 2, 4, 2002, grupoVeiculos, PortaMalaVeiculoEnum.Medio, imagem);
            Locacao locacao = new Locacao(clienteCnpj, condutor, veiculo, "Diário", new DateTime(2020, 01, 12), new DateTime(2022, 01, 03), 20, 12, 10,null);

            //Action
            controladorGrupoVeiculo.InserirNovo(grupoVeiculos);
            controladorVeiuclo.InserirNovo(veiculo);
            controladorClienteCnpj.InserirNovo(clienteCnpj);
            controladorCondutor.InserirNovo(condutor);
            controladorCondutor.InserirNovo(condutor);
            controladorLocacao.InserirNovo(locacao);

            //Assert
            var locacaoEncontrada = controladorLocacao.SelecionarPorId(locacao.Id);
            locacaoEncontrada.Should().Be(locacao);

        }

        [TestMethod]
        public void Deve_AbrirLocacaoParaPessoFisica()
        {
            DateTime data = new DateTime(2021, 12, 06);
            byte[] imagem = { 1, 2, 3 };

            //Arrange
            ClientePF cliente = new ClientePF("Marcelo", "rua abc", "marcelo-nunes@live.com", "Lages", "SC", "123456789", "123456789", "9999999", "8989859", "500000", new DateTime(2022, 08, 21));
            var grupoVeiculos = new GrupoDeVeiculos("Utilitário", 50, 20, 30, 40, 50,20);
            Veiculo veiculo = new Veiculo("weqeqeq", "Verde", "bmw", "ABD1234", "32EWQEQEQ", 10, 20, 2, 4, 2002, grupoVeiculos, PortaMalaVeiculoEnum.Medio, imagem);
            Locacao locacao = new Locacao(cliente, veiculo, "Diário", new DateTime(2020, 01, 12), new DateTime(2022, 01, 03), 20, 12, 10,null);

            //Action
            controladorGrupoVeiculo.InserirNovo(grupoVeiculos);
            controladorVeiuclo.InserirNovo(veiculo);
            controladorClientePF.InserirNovo(cliente);
            controladorLocacao.InserirNovo(locacao);

            //Assert
            var locacaoEncontrada = controladorLocacao.SelecionarPorId(locacao.Id);
            locacaoEncontrada.Should().Be(locacao);

        }

        [TestMethod]
        public void Deve_SelecionarLocacaoPorId()
        {
        
            DateTime data = new DateTime(2021, 12, 06);
            byte[] imagem = { 1, 2, 3 };

            //Arrange
            ClienteCnpj clienteCnpj = new ClienteCnpj("TORTELI", "22222222", "123456789", "TORTELI@GMAIL.COM", "LAGES", "RUA", "499999999", "SC");
            Condutor condutor = new Condutor("JOSE", "RUA", "JOSE@GMAIL.COM", "LAGES", "SC", "49999999", "499999977", "33333307", "2222222", "222222222", data, clienteCnpj);
            var grupoVeiculos = new GrupoDeVeiculos("Utilitário", 50, 20, 30, 40, 50,20);
            Veiculo veiculo = new Veiculo("fusca", "Verde", "bmw", "ABD1234", "32EWQEQEQ", 10, 20, 2, 4, 2002, grupoVeiculos, PortaMalaVeiculoEnum.Medio, imagem);
            Locacao locacao = new Locacao(clienteCnpj, condutor, veiculo, "Diário", new DateTime(2020, 01, 12), new DateTime(2022, 01, 03), 20, 12, 10,null);


            controladorGrupoVeiculo.InserirNovo(grupoVeiculos);
            controladorVeiuclo.InserirNovo(veiculo);
            controladorClienteCnpj.InserirNovo(clienteCnpj);
            controladorCondutor.InserirNovo(condutor);
            controladorLocacao.InserirNovo(locacao);

            //Action
            var locacaoEncontrada = controladorLocacao.SelecionarPorId(locacao.Id);

            //Assert
            locacaoEncontrada.Should().NotBeNull();

        }

        [TestMethod]
        public void Deve_SelecionarTodasAsLocacoes()
        {

            DateTime data = new DateTime(2021, 12, 06);
            byte[] imagem = { 1, 2, 3 };

            //Arrange
            ClienteCnpj clienteCnpj = new ClienteCnpj("TORTELI", "22222222", "123456789", "TORTELI@GMAIL.COM", "LAGES", "RUA", "499999999", "SC");
            Condutor condutor = new Condutor("JOSE", "RUA", "JOSE@GMAIL.COM", "LAGES", "SC", "49999999", "499999977", "33333307", "2222222", "222222222", data, clienteCnpj);
            var grupoVeiculos = new GrupoDeVeiculos("Utilitário", 50, 20, 30, 40, 50,20);
            Veiculo veiculo = new Veiculo("fusca", "Verde", "bmw", "ABD1234", "32EWQEQEQ", 10, 20, 2, 4, 2002, grupoVeiculos, PortaMalaVeiculoEnum.Medio, imagem);
            Locacao locacao = new Locacao(clienteCnpj, condutor, veiculo, "Diário", new DateTime(2020, 01, 12), new DateTime(2022, 01, 03), 20, 12, 10,null);


            controladorGrupoVeiculo.InserirNovo(grupoVeiculos);
            controladorVeiuclo.InserirNovo(veiculo);
            controladorClienteCnpj.InserirNovo(clienteCnpj);
            controladorCondutor.InserirNovo(condutor);
            controladorLocacao.InserirNovo(locacao);

            ClientePF cliente = new ClientePF("Marcelo", "rua abc", "marcelo-nunes@live.com", "Lages", "SC", "123456789", "123456789", "9999999", "8989859", "500000", new DateTime(2022, 08, 21));
            Veiculo veiculos = new Veiculo("palio", "Verde", "bmw", "ABC1234", "38EWQEQEQ", 10, 20, 2, 4, 2002, grupoVeiculos, PortaMalaVeiculoEnum.Medio, imagem);
            Locacao locacoes = new Locacao(cliente, veiculos, "Diário", new DateTime(2020, 01, 12), new DateTime(2022, 01, 03), 20, 12, 10,null);


            controladorVeiuclo.InserirNovo(veiculos);
            controladorClientePF.InserirNovo(cliente);
            controladorLocacao.InserirNovo(locacoes);


            //action
            var locacoesEncontradas = controladorLocacao.SelecionarTodos();


            //assert
            locacoesEncontradas.Should().HaveCount(2);
            locacoesEncontradas[0].Veiculo.NomeVeiculo.Should().Be("fusca");
            locacoesEncontradas[1].Veiculo.NomeVeiculo.Should().Be("palio");

        }
        

    }
}
