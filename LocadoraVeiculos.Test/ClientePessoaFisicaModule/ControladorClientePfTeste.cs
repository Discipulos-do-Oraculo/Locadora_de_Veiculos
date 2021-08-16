using FluentAssertions;
using LocadoraVeiculo.Dominio.ClienteModule;
using LocadoraVeiculos.Controlador;
using LocadoraVeiculos.Controlador.ClienteModule;
using LocadoraVeiculos.Controlador.ClienteModule.ClientePfControlador;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LocadoraVeiculos.Test.ClientePFModule
{
    [TestClass]
    [TestCategory("Controladores")]
    public class ControladorClientePfTeste
    {
        ControladorClientePF controlador = null;

        public ControladorClientePfTeste()
        {
            controlador = new ControladorClientePF();
            Db.Update("DELETE FROM [TBCLIENTEPF]");
        }

        [TestMethod]
        public void DeveInserir_Cliente()
        {
            //arrange
            var novoCliente = new ClientePF("Rechão", "rua", "rechFelipao@gmail.com", "Lages", "SC", "321654987", "999121315", "1111111", "22222222", "12314", new DateTime(2022, 06, 07));

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
            var cliente = new ClientePF("Rechão", "rua", "rechFelipao@gmail.com", "Lages", "SC", "321654987", "999121315", "1111111", "22222222", "12314", new DateTime(2022, 06, 07));
            controlador.InserirNovo(cliente);

            var novoCliente = new ClientePF("Helena", "rua", "rechFelipao@gmail.com", "Lages", "SC", "321654987", "999121315", "1111111", "22222222", "12314", new DateTime(2022, 06, 07));

            //action
            controlador.Editar(cliente.Id, novoCliente);

            //assert
            ClientePF clienteAtualizado = controlador.SelecionarPorId(cliente.Id);
            clienteAtualizado.Should().Be(novoCliente);
        }

        [TestMethod]
        public void DeveExcluir_Cliente()
        {
            //arrange            
            var cliente = new ClientePF("Rechão", "rua", "rechFelipao@gmail.com", "Lages", "SC", "321654987", "999121315", "1111111", "22222222", "12314", new DateTime(2022, 06, 07));
            controlador.InserirNovo(cliente);

            //action            
            controlador.Excluir(cliente.Id);

            //assert
            ClientePF clienteEncontrado = controlador.SelecionarPorId(cliente.Id);
            clienteEncontrado.Should().BeNull();
        }

        [TestMethod]
        public void DeveSelecionar_Cliente_PorId()
        {
            //arrange
            var cliente = new ClientePF("Rechão", "rua", "rechFelipao@gmail.com", "Lages", "SC", "321654987", "999121315", "1111111", "22222222", "12314", new DateTime(2022, 06, 07));
            controlador.InserirNovo(cliente);

            //action
            ClientePF clienteEncontrado = controlador.SelecionarPorId(cliente.Id);

            //assert
            clienteEncontrado.Should().NotBeNull();
        }

        [TestMethod]
        public void DeveSelecionar_TodosClientes()
        {
            //arrange
            var c1 = new ClientePF("Rechão", "rua", "rechFelipao@gmail.com", "Lages", "SC", "321654987", "999121315", "1111111", "22222222", "12314", new DateTime(2022, 06, 07));
            controlador.InserirNovo(c1);

            var c2 = new ClientePF("Helena", "rua", "rechFelipao@gmail.com", "Lages", "SC", "321654987", "999121315", "1111112", "22222232", "152314", new DateTime(2022, 06, 07));
            controlador.InserirNovo(c2);

            var c3 = new ClientePF("Discípulos", "rua", "rechFelipao@gmail.com", "Lages", "SC", "321654987", "999121315", "11111211", "222422222", "123314", new DateTime(2022, 06, 07));
            controlador.InserirNovo(c3);

            //action
            var clientes = controlador.SelecionarTodos();

            //assert
            clientes.Should().HaveCount(3);
            clientes[0].Nome.Should().Be("Rechão");
            clientes[1].Nome.Should().Be("Helena");
            clientes[2].Nome.Should().Be("Discípulos");
        }


    }
}