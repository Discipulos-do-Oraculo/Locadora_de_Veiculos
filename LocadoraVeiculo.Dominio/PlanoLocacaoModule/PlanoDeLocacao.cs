using LocadoraVeiculo.Dominio.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculo.Dominio.PlanoLocacaoModule
{
    public class PlanoDeLocacao : EntidadeBase
    {
        private string titulo, descricao;
        private double valor;

        public PlanoDeLocacao(string titulo, double valor, string descricao)
        {
            this.titulo = titulo;
            this.valor = valor;
            this.descricao = descricao;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double Valor { get => valor; set => valor = value; }

        public override bool Equals(object obj)
        {
            return obj is PlanoDeLocacao locacao &&
                   titulo == locacao.titulo &&
                   descricao == locacao.descricao &&
                   valor == locacao.valor;
        }

        public override int GetHashCode()
        {
            int hashCode = 1734827715;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(titulo);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(descricao);
            hashCode = hashCode * -1521134295 + valor.GetHashCode();
            return hashCode;
        }

        public override string Validar()
        {
            string resultadoValidacao = String.Empty;

            if (String.IsNullOrEmpty(titulo))
            {
                resultadoValidacao = "O campo titulo é obrigatório";
            }

            if (Double.IsNaN(valor))
            {
                resultadoValidacao = "O campo valor só aceita números";
            }

            if (valor == 0)
            {
                resultadoValidacao = "O campo valor é obrigatório";
            }
            if (String.IsNullOrEmpty(descricao))
            {
                resultadoValidacao = "O campo descrição é obrigatório";
            }

            if (resultadoValidacao == "")
            {
                resultadoValidacao = "ESTA_VALIDO";
            }

            return resultadoValidacao;
        }
    }
}
