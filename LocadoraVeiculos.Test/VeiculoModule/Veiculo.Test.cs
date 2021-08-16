using FluentAssertions;
using LocadoraVeiculo.Dominio.GrupoDeVeiculosModule;
using LocadoraVeiculo.Dominio.VeiculoModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Test.VeiculoModule
{

    [TestClass]
    [TestCategory("Dominio")]
    public class VeiculoTest
    {
        [TestMethod]
        public void DeveValidar_Nome()
        {

            var grupoVeiculos = new GrupoDeVeiculos("Utilitário", 20);
            byte[] imagem = { 1, 2, 3 };

            //arrange
            var veiculos = new Veiculo("", "Verde", "bmw", "PHE-W233", "32EWQEQEQ", 10, 20, 2, 4, 2002, grupoVeiculos, PortaMalaVeiculoEnum.Medio, imagem);

            //action
            var resultadoValidacao = veiculos.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo nome é obrigatório");

        }


        [TestMethod]
        public void DeveValidar_EstaValido()
        {

            var grupoVeiculos = new GrupoDeVeiculos("Utilitário",20);
            byte [] imagem = {1,2,3};

            //arrange
            var veiculos = new Veiculo("222", "Verde", "bmw", "ABD1234", "32EWQEQEQ", 10, 20, 2, 4, 2011, grupoVeiculos, PortaMalaVeiculoEnum.Medio, imagem);

            //action
            var resultadoValidacao = veiculos.Validar();

            //assert
            resultadoValidacao.Should().Be("ESTA_VALIDO");

        }


        [TestMethod]
        public void DeveValidar_Imagem()
        {

            var grupoVeiculos = new GrupoDeVeiculos("Utilitário", 20);
            byte[] imagem = null;

            //arrange
            var veiculos = new Veiculo("222", "Verde", "bmw", "ABD1234", "32EWQEQEQ", 10, 20, 2, 4, 2011, grupoVeiculos, PortaMalaVeiculoEnum.Medio, imagem);

            //action
            var resultadoValidacao = veiculos.Validar();

            //assert
            resultadoValidacao.Should().Be("A imagem é obrigatória");

        }

        [TestMethod]
        public void DeveValidar_Cor()
        {

            var grupoVeiculos = new GrupoDeVeiculos("Utilitário", 20);
            byte[] imagem = { 1, 2, 3 };

            //arrange
            var veiculos = new Veiculo("Corsa", "", "bmw", "PHE-W233", "32EWQEQEQ", 10, 20, 2, 4, 2002, grupoVeiculos, PortaMalaVeiculoEnum.Medio, imagem);

            //action
            var resultadoValidacao = veiculos.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo cor é obrigatório");

        }
        [TestMethod]
        public void DeveValidar_Marca()
        {

            var grupoVeiculos = new GrupoDeVeiculos("Utilitário", 20);
            byte[] imagem = { 1, 2, 3 };

            //arrange
            var veiculos = new Veiculo("Corsa", "Verde", "", "PHE-W233", "32EWQEQEQ", 10, 20, 2, 4, 2002, grupoVeiculos, PortaMalaVeiculoEnum.Medio, imagem);

            //action
            var resultadoValidacao = veiculos.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo marca é obrigatório");

        }

        [TestMethod]
        public void DeveValidar_Placa()
        {

            var grupoVeiculos = new GrupoDeVeiculos("Utilitário", 20);
            byte[] imagem = { 1, 2, 3 };

            //arrange
            var veiculos = new Veiculo("Corsa", "Verde", "bmw", "", "32EWQEQEQ", 10, 20, 2, 4, 2002, grupoVeiculos, PortaMalaVeiculoEnum.Medio, imagem);

            //action
            var resultadoValidacao = veiculos.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo placa é obrigatório");

        }

        [TestMethod]
        public void DeveValidar_Chassi()
        {

            var grupoVeiculos = new GrupoDeVeiculos("Utilitário", 20);
            byte[] imagem = { 1, 2, 3 };

            //arrange
            var veiculos = new Veiculo("Corsa", "Verde", "bmw", "PHE-W23", "", 10, 20, 2, 4, 2002, grupoVeiculos, PortaMalaVeiculoEnum.Medio, imagem);

            //action
            var resultadoValidacao = veiculos.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo chassi é obrigatório");

        }

        [TestMethod]
        public void DeveValidar_KmAtual()
        {

            var grupoVeiculos = new GrupoDeVeiculos("Utilitário", 20);
            byte[] imagem = { 1, 2, 3 };
            int kmIncial = default;

            //arrange
            var veiculos = new Veiculo("Corsa", "Verde", "bmw", "PHE-W23", "32EWQEQEQ", kmIncial, 20, 2, 4, 2002, grupoVeiculos, PortaMalaVeiculoEnum.Medio, imagem);

            //action
            var resultadoValidacao = veiculos.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo km Atual é obrigatório");

        }

        [TestMethod]
        public void DeveValidar_NumeroPortas()
        {

            var grupoVeiculos = new GrupoDeVeiculos("Utilitário", 20);
            byte[] imagem = { 1, 2, 3 };
            int numeroPortas = default;

            //arrange
            var veiculos = new Veiculo("Corsa", "Verde", "bmw", "PHE-W23", "32EWQEQEQ", 2, numeroPortas, 2, 4, 2002, grupoVeiculos, PortaMalaVeiculoEnum.Medio, imagem);

            //action
            var resultadoValidacao = veiculos.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo numero de Portas é obrigatório");

        }

        [TestMethod]
        public void DeveValidar_LitrosTanque()
        {

            var grupoVeiculos = new GrupoDeVeiculos("Utilitário", 20);
            byte[] imagem = { 1, 2, 3 };
            int litrosTanque = default;

            //arrange
            var veiculos = new Veiculo("Corsa", "Verde", "bmw", "PHE-W23", "32EWQEQEQ", 2, 3, litrosTanque, 4, 2002, grupoVeiculos, PortaMalaVeiculoEnum.Medio, imagem);

            //action
            var resultadoValidacao = veiculos.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo litros Tanque é obrigatório");

        }

        [TestMethod]
        public void DeveValidar_QuantidadeLugares()
        {

            var grupoVeiculos = new GrupoDeVeiculos("Utilitário", 20);
            byte[] imagem = { 1, 2, 3 };
            int quantidadeLugares = default;

            //arrange
            var veiculos = new Veiculo("Corsa", "Verde", "bmw", "PHE-W23", "32EWQEQEQ", 2, 3, 4, quantidadeLugares, 2002, grupoVeiculos, PortaMalaVeiculoEnum.Medio, imagem);

            //action
            var resultadoValidacao = veiculos.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo quantidade de Lugares é obrigatório");

        }

        [TestMethod]
        public void DeveValidar_Ano()
        {

            var grupoVeiculos = new GrupoDeVeiculos("Utilitário", 20);
            byte[] imagem = { 1, 2, 3 };
            int ano = default;

            //arrange
            var veiculos = new Veiculo("Corsa", "Verde", "bmw", "PHE-W23", "32EWQEQEQ", 2, 3, 4, 7, ano, grupoVeiculos,PortaMalaVeiculoEnum.Medio, imagem);

            //action
            var resultadoValidacao = veiculos.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo ano é obrigatório");

        }
        [TestMethod]
        public void DeveValidar_AnoInvalido()
        {

            var grupoVeiculos = new GrupoDeVeiculos("Utilitário", 20);
            byte[] imagem = { 1, 2, 3 };
            int ano = 20222;

            //arrange
            var veiculos = new Veiculo("Corsa", "Verde", "bmw", "PHE-W23", "32EWQEQEQ", 2, 3, 4, 7, ano, grupoVeiculos, PortaMalaVeiculoEnum.Medio, imagem);

            //action
            var resultadoValidacao = veiculos.Validar();

            //assert
            resultadoValidacao.Should().Be("o campo ano está inválido");

        }

    }
}
