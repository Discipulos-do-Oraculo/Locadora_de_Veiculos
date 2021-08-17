using FluentAssertions;
using LocadoraVeiculo.Dominio.GrupoDeVeiculosModule;
using LocadoraVeiculo.Dominio.VeiculoModule;
using LocadoraVeiculos.Controlador;
using LocadoraVeiculos.Controlador.GrupoDeVeiculosModule;
using LocadoraVeiculos.Controlador.VeiculoModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Test.VeiculoModule
{
    [TestClass]
    [TestCategory("Controladores")]
    public class VeiculoControlador
    {
        
        ControladorVeiculo controlador = null;
        ControladorGrupoDeVeiculos controladorGrupoDeVeiculos = null;


        public VeiculoControlador()
        {
            controladorGrupoDeVeiculos = new ControladorGrupoDeVeiculos();
            controlador = new ControladorVeiculo();
            Db.Update("DELETE FROM [TBVEICULOS]");
            Db.Update("DELETE FROM [TBGRUPODEVEICULOS]");
        }

        [TestMethod]
        public void DeveInserir_Veiculo()
        {
            var grupoVeiculos = new GrupoDeVeiculos("PCD", 20);
            controladorGrupoDeVeiculos.InserirNovo(grupoVeiculos);

            byte[] imagem = { 1, 2, 3 };

            //arrange
            var veiculo = new Veiculo("Corsa", "Verde", "bmw", "ADB1234", "32EWQEQEQ", 10, 20, 2, 4, 2022, grupoVeiculos, PortaMalaVeiculoEnum.Medio, imagem);

            //action
            controlador.InserirNovo(veiculo);

            //assert
            var veiculoEncontrado = controlador.SelecionarPorId(veiculo.Id);
            veiculoEncontrado.Should().Be(veiculo);
        }

        [TestMethod]
        public void DeveAtualizar_Veiculo()
        {
            var grupoVeiculos = new GrupoDeVeiculos("PCD", 20);
            controladorGrupoDeVeiculos.InserirNovo(grupoVeiculos);

            byte[] imagem = { 1, 2, 3 };

            //arrange
            var veiculo = new Veiculo("Corsa", "Verde", "bmw", "ADB1234", "32EWQEQEQ", 10, 20, 2, 4, 2022, grupoVeiculos, PortaMalaVeiculoEnum.Medio, imagem);
            var segundoVeiculo = new Veiculo("Marea", "Verde", "bmw", "ADB1234", "32EWQEQEQ", 10, 20, 2, 4, 2022, grupoVeiculos, PortaMalaVeiculoEnum.Medio, imagem);

            //action
            controlador.InserirNovo(veiculo);
            controlador.Editar(veiculo.Id, segundoVeiculo);

            //assert
            var veiculoEncontrado = controlador.SelecionarPorId(veiculo.Id);
            veiculoEncontrado.Should().Be(segundoVeiculo);
        }

        [TestMethod]
        public void DeveExcluir_Veiculo()
        {
            var grupoVeiculos = new GrupoDeVeiculos("PCD", 20);
            controladorGrupoDeVeiculos.InserirNovo(grupoVeiculos);

            byte[] imagem = { 1, 2, 3 };

            //arrange
            var veiculo = new Veiculo("Corsa", "Verde", "bmw", "ADB1234", "32EWQEQEQ", 10, 20, 2, 4, 2022, grupoVeiculos, PortaMalaVeiculoEnum.Medio, imagem);

            //action
            controlador.InserirNovo(veiculo);
            controlador.Excluir(veiculo.Id);

            //assert
            var veiculoEncontrado = controlador.SelecionarPorId(veiculo.Id);
            veiculoEncontrado.Should().BeNull();
        }

        [TestMethod]
        public void DeveSelecionar_VeiculoPorId()
        {
            var grupoVeiculos = new GrupoDeVeiculos("PCD", 20);
            controladorGrupoDeVeiculos.InserirNovo(grupoVeiculos);

            byte[] imagem = { 1, 2, 3 };

            //arrange
            var veiculo = new Veiculo("Corsa", "Verde", "bmw", "ADB1234", "32EWQEQEQ", 10, 20, 2, 4, 2022, grupoVeiculos, PortaMalaVeiculoEnum.Medio, imagem);

            //action
            controlador.InserirNovo(veiculo);
            

            //assert
            var veiculoEncontrado = controlador.SelecionarPorId(veiculo.Id);
            veiculoEncontrado.Should().NotBeNull();
        }

        [TestMethod]
        public void DeveSelecionar_TodosOsVeiculos()
        {
            var grupoVeiculos = new GrupoDeVeiculos("PCD", 20);
            controladorGrupoDeVeiculos.InserirNovo(grupoVeiculos);

            byte[] imagem = { 1, 2, 3 };

            //arrange
            var veiculo = new Veiculo("Corsa", "Verde", "bmw", "ADB1234", "32EWQEQEQ", 10, 20, 2, 4, 2022, grupoVeiculos, PortaMalaVeiculoEnum.Medio, imagem);
            var segundoVeiculo = new Veiculo("Pálio", "Verde", "bmw", "ADB1231", "32EWQEQEQ", 10, 20, 2, 4, 2022, grupoVeiculos, PortaMalaVeiculoEnum.Medio, imagem);
            var terceiroVeiculo = new Veiculo("Fusca", "Verde", "bmw", "ADB1232", "32EWQEQEQ", 10, 20, 2, 4, 2022, grupoVeiculos, PortaMalaVeiculoEnum.Medio, imagem);
            //action
            controlador.InserirNovo(veiculo);
            controlador.InserirNovo(segundoVeiculo);
            controlador.InserirNovo(terceiroVeiculo);
            //assert
            var veiculosEncontrados = controlador.SelecionarTodos();
           
            veiculosEncontrados.Should().HaveCount(3);

            veiculosEncontrados[0].NomeVeiculo.Should().Be("Corsa");
            veiculosEncontrados[1].NomeVeiculo.Should().Be("Pálio");
            veiculosEncontrados[2].NomeVeiculo.Should().Be("Fusca");
        }


    }
}
