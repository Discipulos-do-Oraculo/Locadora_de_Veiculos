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
        private double valor;

        public override string ToString() => $"{Nome}";
        public GrupoDeVeiculos(string nome, double valor)
        {
            this.nome = nome;
            this.valor = valor;
        }


        public string Nome { get => nome; set => nome = value; }
        public double Valor { get => valor; set => valor = value; }

        public override bool Equals(object obj)
        {
            return obj is GrupoDeVeiculos veiculos &&
                   nome == veiculos.nome &&
                   valor == veiculos.valor;
        }

        public override int GetHashCode()
        {
            int hashCode = 1409341681;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nome);
            hashCode = hashCode * -1521134295 + valor.GetHashCode();
            return hashCode;
        }

        public override string Validar()
        {
            string resultadoValidacao = String.Empty;

            if (String.IsNullOrEmpty(nome))
            {
                resultadoValidacao = "O campo nome é obrigatório";
            }

            if (Double.IsNaN(valor))
            {
                resultadoValidacao = "O campo valor só aceita números";
            }

            if (valor == 0)
            {
                resultadoValidacao = "O campo valor é obrigatório";
            }

            if (resultadoValidacao == "")
            {
                resultadoValidacao = "ESTA_VALIDO";
            }

            return resultadoValidacao;
        }
    }
}
