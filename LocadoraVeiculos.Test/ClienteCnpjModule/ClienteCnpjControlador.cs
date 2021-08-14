using FluentAssertions;
using LocadoraVeiculo.Dominio.ClienteModule;
using LocadoraVeiculos.Controlador;
using LocadoraVeiculos.Controlador.ClienteModule.ClienteCnpjControlador;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LocadoraVeiculos.Test.ClienteCnpjModule
{
    [TestClass]
    [TestCategory("Controladores")]
    public class ClienteCnpjControlador
    {
        private ControladorClienteCnpj controlador = null;

        public ClienteCnpjControlador()
        {
            controlador = new ControladorClienteCnpj();
            Db.Update("DELETE FROM [TBCLIENTEPJ]");           
        }

        [TestMethod]
        public void DeveInserir_Cliente()
        {
            //arrange
            var novoCliente = new ClienteCnpj("ndd", "06255692", "32220309", "nddtech@gmail.com", "lages", "rua", "999121315", "sc");

            //action
            controlador.InserirNovo(novoCliente);

            //assert
            var clienteEncontrado = controlador.SelecionarPorId(novoCliente.Id);
            clienteEncontrado.Should().Be(novoCliente);
        }

        [TestMethod]
        public void DeveAtualizar_Cliente()
        {
            //arrange
            var cliente = new ClienteCnpj("ndd", "06255692", "32220309", "nddtech@gmail.com", "lages", "rua", "999121315", "sc");

            controlador.InserirNovo(cliente);

            var novoCliente = new ClienteCnpj("ndd", "123", "32220309", "nddtech@yahoo.com", "lages", "rua", "999121315", "sc");


            //action
            controlador.Editar(cliente.Id, novoCliente);

            //assert
            ClienteCnpj clienteAtualizado = controlador.SelecionarPorId(cliente.Id);
            clienteAtualizado.Should().Be(novoCliente);
        }

        [TestMethod]
        public void DeveExcluir_Cliente()
        {
            //arrange            
            var cliente = new ClienteCnpj("ndd", "06255692", "32220309", "nddtech@gmail.com", "lages", "rua", "999121315", "sc");

            controlador.InserirNovo(cliente);

            //action            
            controlador.Excluir(cliente.Id);

            //assert
            ClienteCnpj clienteEncontrado = controlador.SelecionarPorId(cliente.Id);
            clienteEncontrado.Should().BeNull();
        }

        [TestMethod]
        public void DeveSelecionar_Cliente_PorId()
        {
            //arrange
            var cliente = new ClienteCnpj("ndd", "06255692", "32220309", "nddtech@gmail.com", "lages", "rua", "999121315", "sc");

            controlador.InserirNovo(cliente);

            //action
            ClienteCnpj clienteEncontrado = controlador.SelecionarPorId(cliente.Id);

            //assert
            clienteEncontrado.Should().NotBeNull();
        }

        [TestMethod]
        public void DeveSelecionar_TodosClientes()
        {
            //arrange
            var gv1 = new ClienteCnpj("ndd", "06255692", "32220309", "nddtech@gmail.com", "lages", "rua", "999121315", "sc");
            controlador.InserirNovo(gv1);

            var gv2 = new ClienteCnpj("uniplac", "06255692", "32220309", "nddtech@gmail.com", "lages", "rua", "999121315", "sc");
            controlador.InserirNovo(gv2);

            var gv3 = new ClienteCnpj("google", "06255692", "32220309", "nddtech@gmail.com", "lages", "rua", "999121315", "sc");
            controlador.InserirNovo(gv3);

            //action
            var grupoDeVeiculoss = controlador.SelecionarTodos();

            //assert
            grupoDeVeiculoss.Should().HaveCount(3);
            grupoDeVeiculoss[0].Nome.Should().Be("ndd");
            grupoDeVeiculoss[1].Nome.Should().Be("uniplac");
            grupoDeVeiculoss[2].Nome.Should().Be("google");
        }
    }
}
