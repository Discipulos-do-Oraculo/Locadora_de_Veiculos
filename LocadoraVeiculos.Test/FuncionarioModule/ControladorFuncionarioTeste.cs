using FluentAssertions;
using LocadoraVeiculo.Dominio.ClienteModule;
using LocadoraVeiculos.Controlador;
using LocadoraVeiculos.Controlador.ClienteModule.CondutorControlador;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LocadoraVeiculos.Test.FuncionarioModule
{
    [TestClass]
    [TestCategory("Controladores")]
    public class ControladorFuncionarioTeste
    {
        private ControladorColaborador controlador = null;

        public ControladorFuncionarioTeste()
        {
            controlador = new ControladorColaborador();
            Db.Update("DELETE FROM [TBCOLABORADOR]");
        }

        [TestMethod]
        public void DeveInserir_Funcionario()
        {
            //arrange
            var novoFuncionario = new Colaborador("zezo vitória", "rua dos gatinhos", "zezoVitoria@gatinhos.com", "lages", "sc", "322220309", "999121315", "1231", "0101", "zezin", "123", new DateTime(2021, 08, 13), 4500);

            //action
            controlador.InserirNovo(novoFuncionario);

            //assert
            var funcionarioEncontrado = controlador.SelecionarPorId(novoFuncionario.Id);
            funcionarioEncontrado.Should().Be(novoFuncionario);
        }

        [TestMethod]
        public void DeveAtualizar_Funcionario()
        {
            //arrange
            var funcionario = new  Colaborador("zezo vitória", "rua dos gatinhos", "zezoVitoria@gatinhos.com", "lages", "sc", "322220309", "999121315", "1231", "0101", "zezin", "123", new DateTime(2021, 08, 13), 4500);

            controlador.InserirNovo(funcionario);

            var novoFuncionario = new Colaborador("lito", "rua dos gatinhos", "zezoVitoria@gatinhos.com", "lages", "sc", "322220309", "999121315", "1231", "0101", "zezin", "123", new DateTime(2021, 08, 13), 4500);


            //action
            controlador.Editar(funcionario.Id, novoFuncionario);

            //assert
            Colaborador funcionarioAtualizado = controlador.SelecionarPorId(funcionario.Id);
            funcionarioAtualizado.Should().Be(novoFuncionario);
        }

        [TestMethod]
        public void DeveExcluir_Funcionario()
        {
            //arrange            
            var funcionario = new Colaborador("lito", "rua dos gatinhos", "zezoVitoria@gatinhos.com", "lages", "sc", "322220309", "999121315", "1231", "0101", "zezin", "123", new DateTime(2021, 08, 13), 4500);

            controlador.InserirNovo(funcionario);

            //action            
            controlador.Excluir(funcionario.Id);

            //assert
            Colaborador funcionarioEncontrado = controlador.SelecionarPorId(funcionario.Id);
            funcionarioEncontrado.Should().BeNull();
        }

        [TestMethod]
        public void DeveSelecionar_Funcionario_PorId()
        {
            //arrange
            var funcionario = new Colaborador("lito", "rua dos gatinhos", "zezoVitoria@gatinhos.com", "lages", "sc", "322220309", "999121315", "1231", "0101", "zezin", "123", new DateTime(2021, 08, 13), 4500);

            controlador.InserirNovo(funcionario);

            //action
            Colaborador funcionarioEncontrado = controlador.SelecionarPorId(funcionario.Id);

            //assert
            funcionarioEncontrado.Should().NotBeNull();
        }

        [TestMethod]
        public void DeveSelecionar_TodosFuncionarios()
        {
            //arrange
            var gv1 = new Colaborador("lito", "rua dos gatinhos", "zezoVitoria@gatinhos.com", "lages", "sc", "322220309", "999121315", "1231", "0101", "zezin", "123", new DateTime(2021, 08, 13), 4500);
            controlador.InserirNovo(gv1);

            var gv2 = new Colaborador("zezo vitória", "rua dos gatinhos", "zezoVitoria@gatinhos.com", "lages", "sc", "322220309", "999121315", "1231", "0101", "zezin", "123", new DateTime(2021, 08, 13), 4500);
            controlador.InserirNovo(gv2);

            var gv3 = new Colaborador("Charles Visit", "rua dos gatinhos", "zezoVitoria@gatinhos.com", "lages", "sc", "322220309", "999121315", "1231", "0101", "zezin", "123", new DateTime(2021, 08, 13), 4500);
            controlador.InserirNovo(gv3);

            //action
            var grupoDeVeiculoss = controlador.SelecionarTodos();

            //assert
            grupoDeVeiculoss.Should().HaveCount(3);
            grupoDeVeiculoss[0].Nome.Should().Be("lito");
            grupoDeVeiculoss[1].Nome.Should().Be("zezo vitória");
            grupoDeVeiculoss[2].Nome.Should().Be("Charles Visit");
        }
    }
}
