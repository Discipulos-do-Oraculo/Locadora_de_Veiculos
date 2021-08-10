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


        public GrupoDeVeiculos(string nome, double valor)
        {
            this.nome = nome;
            this.valor = valor;
        }


        public string Nome { get => nome; set => nome = value; }
        public double Valor { get => valor; set => valor = value; }

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
                resultadoValidacao = "O campo valor precisa de um número maior que 0 e não pode ser nulo";
            }

            if (resultadoValidacao == "")
            {
                resultadoValidacao = "ESTA_VALIDO";
            }

            return resultadoValidacao;
        }
    }
}
