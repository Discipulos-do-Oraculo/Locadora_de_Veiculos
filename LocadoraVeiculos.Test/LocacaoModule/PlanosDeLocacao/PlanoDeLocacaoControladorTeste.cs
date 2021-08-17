using FluentAssertions;
using LocadoraVeiculo.Dominio.PlanoLocacaoModule;
using LocadoraVeiculos.Controlador;
using LocadoraVeiculos.Controlador.PlanoLocacaoModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LocadoraVeiculos.Test.LocacaoModule.PlanosDeLocacao
{
    [TestClass]
    [TestCategory("Controladores")]

    public class PlanoDeLocacaoControladorTeste
    {
        private ControladorPlanoLocacao controlador = null;

        public PlanoDeLocacaoControladorTeste()
        {
            controlador = new ControladorPlanoLocacao();
            Db.Update("DELETE FROM [TBPLANODELOCACAO]");
        }

        [TestMethod]
        public void DeveInserir_PlanoDeLocacao()
        {
            //arrange
            var novoPlanoDeLocacao = new PlanoDeLocacao("Plano Diário", 50, "Paga por dia e por km rodado");

            //action
            controlador.InserirNovo(novoPlanoDeLocacao);

            //assert
            var planoDeLocacaoEncontrado = controlador.SelecionarPorId(novoPlanoDeLocacao.Id);
            planoDeLocacaoEncontrado.Should().Be(novoPlanoDeLocacao);
        }

        [TestMethod]
        public void DeveAtualizar_PlanoDeLocacao()
        {
            //arrange
            var planoDeLocacao = new PlanoDeLocacao("Plano Diário", 50, "Paga por dia e por km rodado");
            controlador.InserirNovo(planoDeLocacao);

            var novoPlanoDeLocacao = new PlanoDeLocacao("Km Controlado", 50, "Paga por dia e por km rodado");

            //action
            controlador.Editar(planoDeLocacao.Id, novoPlanoDeLocacao);

            //assert
            PlanoDeLocacao planoDeLocacaoAtualizado = controlador.SelecionarPorId(planoDeLocacao.Id);
            planoDeLocacaoAtualizado.Should().Be(novoPlanoDeLocacao);
        }

        [TestMethod]
        public void DeveExcluir_PlanoDeLocacao()
        {
            //arrange            
            var planoDeLocacao = new PlanoDeLocacao("Plano Diário", 50, "Paga por dia e por km rodado");
            controlador.InserirNovo(planoDeLocacao);

            //action            
            controlador.Excluir(planoDeLocacao.Id);

            //assert
            PlanoDeLocacao planoDeLocacaoEncontrado = controlador.SelecionarPorId(planoDeLocacao.Id);
            planoDeLocacaoEncontrado.Should().BeNull();
        }

        [TestMethod]
        public void DeveSelecionar_PlanoDeLocacao_PorId()
        {
            //arrange
            var planoDeLocacao = new PlanoDeLocacao("Plano Diário", 50, "Paga por dia e por km rodado");
            controlador.InserirNovo(planoDeLocacao);

            //action
            PlanoDeLocacao planoDeLocacaoEncontrado = controlador.SelecionarPorId(planoDeLocacao.Id);

            //assert
            planoDeLocacaoEncontrado.Should().NotBeNull();
        }

        [TestMethod]
        public void DeveSelecionar_TodosPlanoDeLocacaos()
        {
            //arrange
            var gv1 = new PlanoDeLocacao("Plano Diário", 50, "Paga por dia e por km rodado");
            controlador.InserirNovo(gv1);

            var gv2 = new PlanoDeLocacao("Km Controlado", 50, "Quantidade de km para rodar por dia");
            controlador.InserirNovo(gv2);

            var gv3 = new PlanoDeLocacao("Km Livre", 50, "Paga somente a diária");
            controlador.InserirNovo(gv3);

            //action
            var planoDeLocacaos = controlador.SelecionarTodos();

            //assert
            planoDeLocacaos.Should().HaveCount(3);
            planoDeLocacaos[0].Titulo.Should().Be("Plano Diário");
            planoDeLocacaos[1].Titulo.Should().Be("Km Controlado");
            planoDeLocacaos[2].Titulo.Should().Be("Km Livre");
        }
    }
}
