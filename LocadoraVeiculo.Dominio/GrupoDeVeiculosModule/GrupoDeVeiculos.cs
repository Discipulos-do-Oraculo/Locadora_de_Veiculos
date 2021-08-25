using LocadoraVeiculo.Dominio.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculo.Dominio.GrupoDeVeiculosModule
{
    public class GrupoDeVeiculos : EntidadeBase
    {
        private string nome;
        private double valorDiaria, valorKmDiaria,valorKmLivre,limiteKmControlado,valorKmControlado;

        public GrupoDeVeiculos(string nome, double valorDiaria, double valorKmDiaria, double valorKmLivre, double limiteKmControlado, double valorKmControlado)
        {
            this.Nome = nome;
            this.ValorDiaria = valorDiaria;
            this.ValorKmDiaria = valorKmDiaria;
            this.ValorKmLivre = valorKmLivre;
            this.LimiteKmControlado = limiteKmControlado;
            this.ValorKmControlado = valorKmControlado;
        }

        public string Nome { get => nome; set => nome = value; }
        public double ValorDiaria { get => valorDiaria; set => valorDiaria = value; }
        public double ValorKmDiaria { get => valorKmDiaria; set => valorKmDiaria = value; }
        public double ValorKmLivre { get => valorKmLivre; set => valorKmLivre = value; }
        public double LimiteKmControlado { get => limiteKmControlado; set => limiteKmControlado = value; }
        public double ValorKmControlado { get => valorKmControlado; set => valorKmControlado = value; }

        public override bool Equals(object obj)
        {
            return obj is GrupoDeVeiculos veiculos &&
                   nome == veiculos.nome &&
                   valorDiaria == veiculos.valorDiaria &&
                   valorKmDiaria == veiculos.valorKmDiaria &&
                   valorKmLivre == veiculos.valorKmLivre &&
                   limiteKmControlado == veiculos.limiteKmControlado &&
                   valorKmControlado == veiculos.valorKmControlado;
        }

        public override int GetHashCode()
        {
            int hashCode = 790948857;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nome);
            hashCode = hashCode * -1521134295 + valorDiaria.GetHashCode();
            hashCode = hashCode * -1521134295 + valorKmDiaria.GetHashCode();
            hashCode = hashCode * -1521134295 + valorKmLivre.GetHashCode();
            hashCode = hashCode * -1521134295 + limiteKmControlado.GetHashCode();
            hashCode = hashCode * -1521134295 + valorKmControlado.GetHashCode();
            return hashCode;
        }

        public override string ToString() => $"{Nome}";
        

        public override string Validar()
        {
            string resultadoValidacao = String.Empty;

            if(ValorKmLivre == default)
            {
                resultadoValidacao = "O campo valor km na aba km livre é obrigatório";
            }
            if (ValorKmControlado == default)
            {
                resultadoValidacao = "O campo valor km na aba km controlado é obrigatório";
            }

            if (LimiteKmControlado == default)
            {
                resultadoValidacao = "O campo limite km na aba km controlado é obrigatório";
            }


            if(ValorKmDiaria == default)
            {
                resultadoValidacao = "O campo valor km na aba plano diário é obrigatório";
            }

            if (ValorDiaria == default)
            {
                resultadoValidacao = "O campo valor diária na aba plano diário é obrigatório";
            }

            if (String.IsNullOrEmpty(Nome))
            {
                resultadoValidacao = "O campo nome é obrigatório";
            }

            if (resultadoValidacao == "")
            {
                resultadoValidacao = "ESTA_VALIDO";
            }

            return resultadoValidacao;
        }
    }
}
