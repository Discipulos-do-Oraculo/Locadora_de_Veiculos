using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FluentAssertions;
using LocadoraVeiculo.Dominio.GrupoDeVeiculosModule;
using LocadoraVeiculos.Controlador.GrupoDeVeiculosModule;
using LocadoraVeiculos.Controlador;
using LocadoraVeiculos.Controlador.DevolucaoModule;
using LocadoraVeiculo.Dominio.ClienteModule;
using LocadoraVeiculo.Dominio.CombustivelModule;
using LocadoraVeiculo.Dominio.DevolucaoModule;
using LocadoraVeiculo.Dominio.LocacaoModule;
using LocadoraVeiculo.Dominio.VeiculoModule;
using LocadoraVeiculos.Controlador.LocacaoModule;
using LocadoraVeiculos.Controlador.ClienteModule.ClientePfControlador;
using LocadoraVeiculos.Controlador.VeiculoModule;
using LocadoraVeiculos.Controlador.ClienteModule.CondutorControlador;
using LocadoraVeiculos.Controlador.GasolinaModule;

namespace LocadoraVeiculos.Test.DevolucaoModule
{
    [TestClass]
    [TestCategory("Controladores")]
    public class ControladorDevolucaoTeste
    {
        private ControladorDevolucao controlador = null;
        private ControladorLocacao controladorLocacao = null;
        private ControladorClientePF controladorClientePF = null;
        private ControladorVeiculo controladorVeiculo = null;
        private ControladorGrupoDeVeiculos controladorGrupoVeiculo = null;
        private ControladorCondutor controladorCondutor = null;
        private ControladorCombustivel controladorCombustivel = null;


        public ControladorDevolucaoTeste()
        {
            controladorCombustivel = new ControladorCombustivel();
            controladorCondutor = new ControladorCondutor();
            controladorGrupoVeiculo = new ControladorGrupoDeVeiculos();
            controladorVeiculo = new ControladorVeiculo();
            controlador = new ControladorDevolucao();
            controladorLocacao = new ControladorLocacao();
            controladorClientePF = new ControladorClientePF();
            Db.Update("DELETE FROM [TBLOCACAO]");
            Db.Update("DELETE FROM [TBTaxasEServicos]");
            Db.Update("DELETE FROM [TBCombustivel]");
            Db.Update("DELETE FROM[TBVEICULOS]");
            Db.Update("DELETE FROM [TBCONDUTOR]");
            Db.Update("DELETE FROM [TBClientePF]");
        }

        [TestMethod]
        public void DeveInserir_Devolucao()
        {
            //arrange
            var dataValidadeCnh = System.DateTime.Now;
            dataValidadeCnh = dataValidadeCnh.AddYears(2);
            var cliente = new ClientePF("ClietneTeste", "rua santa terezinha", "test@test.com", "Lages", "SC", "22222222", "22222222", "123456", "12345678966", "123456",
                dataValidadeCnh);
            controladorClientePF.InserirNovo(cliente);

            var grupoVeiculo = new GrupoDeVeiculos("vans", 60, 2, 3, 200, 4,3);
            byte[] imagem = { 1, 2, 3 };
            controladorGrupoVeiculo.InserirNovo(grupoVeiculo);

            var veiculo = new Veiculo("classic", "branco", "chevrolet", "ERA1234", "4568979", 12020, 4, 45, 5, 2012, grupoVeiculo, PortaMalaVeiculoEnum.Medio, imagem);
            controladorVeiculo.InserirNovo(veiculo);

            var dataSaida = System.DateTime.Now;
            var dataRetorno = dataSaida.AddDays(5);
            var locacao = new Locacao(cliente, veiculo, "planoTest", dataSaida, dataRetorno, 350, 2000, 12345);
            controladorLocacao.InserirNovo(locacao);

            var tipoCombustivel = new Combustivel("gasolina", 6);
            controladorCombustivel.InserirNovo(tipoCombustivel);

            var devolucao = new Devolucao(locacao, tipoCombustivel, dataRetorno, 117, 254, 54);

            //action
            controlador.InserirNovo(devolucao);

            //assert
            var devolucaoEncontrada = controlador.SelecionarPorId(devolucao.Id);
            devolucaoEncontrada.Should().Be(devolucao);
        }

        //[TestMethod]
        //public void DeveAtualizar_GrupoDeVeiculos()
        //{
        //    arrange
        //    var grupoDeVeiculos = new GrupoDeVeiculos("SUV", 50, 20, 30, 40, 50);
        //    controlador.InserirNovo(grupoDeVeiculos);

        //    var novoGrupoDeVeiculos = new GrupoDeVeiculos("Esportivo", 50, 20, 30, 40, 50);

        //    action
        //    controlador.Editar(grupoDeVeiculos.Id, novoGrupoDeVeiculos);

        //    assert
        //    GrupoDeVeiculos grupoDeVeiculosAtualizado = controlador.SelecionarPorId(grupoDeVeiculos.Id);
        //    grupoDeVeiculosAtualizado.Should().Be(novoGrupoDeVeiculos);
        //}

        //[TestMethod]
        //public void DeveExcluir_GrupoDeVeiculos()
        //{
        //    arrange
        //    var grupoDeVeiculos = new GrupoDeVeiculos("SUV", 50, 20, 30, 40, 50);
        //    controlador.InserirNovo(grupoDeVeiculos);

        //    action
        //    controlador.Excluir(grupoDeVeiculos.Id);

        //    assert
        //    GrupoDeVeiculos grupoDeVeiculosEncontrado = controlador.SelecionarPorId(grupoDeVeiculos.Id);
        //    grupoDeVeiculosEncontrado.Should().BeNull();
        //}

        //[TestMethod]
        //public void DeveSelecionar_GrupoDeVeiculos_PorId()
        //{
        //    arrange
        //    var grupoDeVeiculos = new GrupoDeVeiculos("SUV", 50, 20, 30, 40, 50);
        //    controlador.InserirNovo(grupoDeVeiculos);

        //    action
        //    GrupoDeVeiculos grupoDeVeiculosEncontrado = controlador.SelecionarPorId(grupoDeVeiculos.Id);

        //    assert
        //    grupoDeVeiculosEncontrado.Should().NotBeNull();
        //}

        //[TestMethod]
        //public void DeveSelecionar_TodosGrupoDeVeiculoss()
        //{
        //    arrange
        //    var gv1 = new GrupoDeVeiculos("SUV", 50, 20, 30, 40, 50);
        //    controlador.InserirNovo(gv1);

        //    var gv2 = new GrupoDeVeiculos("Esportivo", 50, 20, 30, 40, 50);
        //    controlador.InserirNovo(gv2);

        //    var gv3 = new GrupoDeVeiculos("Utilitário", 50, 20, 30, 40, 50);
        //    controlador.InserirNovo(gv3);

        //    action
        //    var grupoDeVeiculoss = controlador.SelecionarTodos();

        //    assert
        //    grupoDeVeiculoss.Should().HaveCount(3);
        //    grupoDeVeiculoss[0].Nome.Should().Be("SUV");
        //    grupoDeVeiculoss[1].Nome.Should().Be("Esportivo");
        //    grupoDeVeiculoss[2].Nome.Should().Be("Utilitário");
        //}
    }
}
