using LocadoraVeiculo.Dominio.GrupoDeVeiculosModule;
using LocadoraVeiculo.Dominio.shared;
using System;
using System.Collections.Generic;

namespace LocadoraVeiculo.Dominio.VeiculoModule
{
    public class Veiculo : EntidadeBase
    {
        private string nomeVeiculo, cor, marca, placa, chassi;
        private int kmAtual, numeroPortas, litrosTanque, quantidadeLugares, ano;
        GrupoDeVeiculos grupoDeVeiculos;
        PortaMalaVeiculoEnum portaMala;

        public Veiculo(string nomeVeiculo, string cor, string marca, string placa, string chassi, int kmAtual, int numeroPortas, int litrosTanque, int quantidadeLugares, int ano, GrupoDeVeiculos grupoDeVeiculos, PortaMalaVeiculoEnum portaMala)
        {
            this.NomeVeiculo = nomeVeiculo;
            this.Cor = cor;
            this.Marca = marca;
            this.Placa = placa;
            this.Chassi = chassi;
            this.KmAtual = kmAtual;
            this.NumeroPortas = numeroPortas;
            this.LitrosTanque = litrosTanque;
            this.QuantidadeLugares = quantidadeLugares;
            this.Ano = ano;
            this.GrupoDeVeiculos = grupoDeVeiculos;
            this.PortaMala = portaMala;
        }

        public string NomeVeiculo { get => nomeVeiculo; set => nomeVeiculo = value; }
        public string Cor { get => cor; set => cor = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Chassi { get => chassi; set => chassi = value; }
        public int KmAtual { get => kmAtual; set => kmAtual = value; }
        public int NumeroPortas { get => numeroPortas; set => numeroPortas = value; }
        public int LitrosTanque { get => litrosTanque; set => litrosTanque = value; }
        public int QuantidadeLugares { get => quantidadeLugares; set => quantidadeLugares = value; }
        public int Ano { get => ano; set => ano = value; }
        public GrupoDeVeiculos GrupoDeVeiculos { get => grupoDeVeiculos; set => grupoDeVeiculos = value; }
        public PortaMalaVeiculoEnum PortaMala { get => portaMala; set => portaMala = value; }

        public override bool Equals(object obj)
        {
            return obj is Veiculo veiculo &&
                   nomeVeiculo == veiculo.nomeVeiculo &&
                   cor == veiculo.cor &&
                   marca == veiculo.marca &&
                   placa == veiculo.placa &&
                   chassi == veiculo.chassi &&
                   kmAtual == veiculo.kmAtual &&
                   numeroPortas == veiculo.numeroPortas &&
                   litrosTanque == veiculo.litrosTanque &&
                   quantidadeLugares == veiculo.quantidadeLugares &&
                   ano == veiculo.ano &&
                   EqualityComparer<GrupoDeVeiculos>.Default.Equals(grupoDeVeiculos, veiculo.grupoDeVeiculos) &&
                   portaMala == veiculo.portaMala;
        }

        public override int GetHashCode()
        {
            int hashCode = 1060840058;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nomeVeiculo);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(cor);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(marca);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(placa);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(chassi);
            hashCode = hashCode * -1521134295 + kmAtual.GetHashCode();
            hashCode = hashCode * -1521134295 + numeroPortas.GetHashCode();
            hashCode = hashCode * -1521134295 + litrosTanque.GetHashCode();
            hashCode = hashCode * -1521134295 + quantidadeLugares.GetHashCode();
            hashCode = hashCode * -1521134295 + ano.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<GrupoDeVeiculos>.Default.GetHashCode(grupoDeVeiculos);
            hashCode = hashCode * -1521134295 + portaMala.GetHashCode();
            return hashCode;
        }

        public override string Validar()
        {
            string resultadoValidacao = String.Empty;

            if (String.IsNullOrEmpty(NomeVeiculo))
            {
                resultadoValidacao = "O campo nome é obrigatório";
            }
            if (String.IsNullOrEmpty(Cor))
            {
                resultadoValidacao = "O campo cor é obrigatório";
            }
            if (String.IsNullOrEmpty(Placa))
            {
                resultadoValidacao = "O campo placa é obrigatório";
            }
            if (String.IsNullOrEmpty(Marca))
            {
                resultadoValidacao = "O campo marca é obrigatório";
            }
            if (String.IsNullOrEmpty(Chassi))
            {
                resultadoValidacao = "O campo chassi é obrigatório";
            }
            if (String.IsNullOrEmpty(KmAtual.ToString()))
            {
                resultadoValidacao = "O campo km Atual é obrigatório";
            }
            if (String.IsNullOrEmpty(NumeroPortas.ToString()))
            {
                resultadoValidacao = "O campo numero de Portas é obrigatório";
            }
            if (String.IsNullOrEmpty(LitrosTanque.ToString()))
            {
                resultadoValidacao = "O campo litros Tanque é obrigatório";
            }
            if (String.IsNullOrEmpty(QuantidadeLugares.ToString()))
            {
                resultadoValidacao = "O campo quantidade de Lugares é obrigatório";
            }
            if (String.IsNullOrEmpty(Ano.ToString()))
            {
                resultadoValidacao = "O campo ano é obrigatório";
            }
            if (resultadoValidacao == "")
            {
                resultadoValidacao = "ESTA_VALIDO";
            }
            return resultadoValidacao;
        }
    
    }
}
