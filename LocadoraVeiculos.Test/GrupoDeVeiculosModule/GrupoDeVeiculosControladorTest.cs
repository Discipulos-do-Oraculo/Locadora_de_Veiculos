using FluentAssertions;
using LocadoraVeiculo.Dominio.GrupoDeVeiculosModule;
using LocadoraVeiculos.Controlador;
using LocadoraVeiculos.Controlador.GrupoDeVeiculosModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LocadoraVeiculos.Test
{
    [TestClass]
    [TestCategory("Controladores")]
    public class GrupoDeVeiculosControladorTest
    {
        private ControladorGrupoDeVeiculos controlador = null;

        public GrupoDeVeiculosControladorTest()
        {
            controlador = new ControladorGrupoDeVeiculos();
            Db.Update("DELETE FROM [TBGRUPODEVEICULOS]");
            //update
        }

        [TestMethod]
        public void DeveInserir_GrupoDeVeiculos()
        {
            //arrange
            var novoGrupoDeVeiculos = new GrupoDeVeiculos("SUV", 50);

            //action
            controlador.InserirNovo(novoGrupoDeVeiculos);

            //assert
            var grupoDeVeiculosEncontrado = controlador.SelecionarPorId(novoGrupoDeVeiculos.Id);
            grupoDeVeiculosEncontrado.Should().Be(novoGrupoDeVeiculos);
        }

        [TestMethod]
        public void DeveAtualizar_GrupoDeVeiculos()
        {
            //arrange
            var grupoDeVeiculos = new GrupoDeVeiculos("SUV", 55);
            controlador.InserirNovo(grupoDeVeiculos);

            var novoGrupoDeVeiculos = new GrupoDeVeiculos("Esportivo", 100);

            //action
            controlador.Editar(grupoDeVeiculos.Id, novoGrupoDeVeiculos);

            //assert
            GrupoDeVeiculos grupoDeVeiculosAtualizado = controlador.SelecionarPorId(grupoDeVeiculos.Id);
            grupoDeVeiculosAtualizado.Should().Be(novoGrupoDeVeiculos);
        }

        [TestMethod]
        public void DeveExcluir_GrupoDeVeiculos()
        {
            //arrange            
            var grupoDeVeiculos = new GrupoDeVeiculos("SUV", 57);
            controlador.InserirNovo(grupoDeVeiculos);

            //action            
            controlador.Excluir(grupoDeVeiculos.Id);

            //assert
            GrupoDeVeiculos grupoDeVeiculosEncontrado = controlador.SelecionarPorId(grupoDeVeiculos.Id);
            grupoDeVeiculosEncontrado.Should().BeNull();
        }

        [TestMethod]
        public void DeveSelecionar_GrupoDeVeiculos_PorId()
        {
            //arrange
            var grupoDeVeiculos = new GrupoDeVeiculos("SUV", 57);
            controlador.InserirNovo(grupoDeVeiculos);

            //action
            GrupoDeVeiculos grupoDeVeiculosEncontrado = controlador.SelecionarPorId(grupoDeVeiculos.Id);

            //assert
            grupoDeVeiculosEncontrado.Should().NotBeNull();
        }

        [TestMethod]
        public void DeveSelecionar_TodosGrupoDeVeiculoss()
        {
            //arrange
            var gv1 = new GrupoDeVeiculos("SUV", 57);
            controlador.InserirNovo(gv1);

            var gv2 = new GrupoDeVeiculos("Esportivo", 70);
            controlador.InserirNovo(gv2);

            var gv3 = new GrupoDeVeiculos("Utilitário", 57);
            controlador.InserirNovo(gv3);

            //action
            var grupoDeVeiculoss = controlador.SelecionarTodos();

            //assert
            grupoDeVeiculoss.Should().HaveCount(3);
            grupoDeVeiculoss[0].Nome.Should().Be("SUV");
            grupoDeVeiculoss[1].Nome.Should().Be("Esportivo");
            grupoDeVeiculoss[2].Nome.Should().Be("Utilitário");
        }

        
    }
}
