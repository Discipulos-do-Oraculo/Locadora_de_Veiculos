using LocadoraVeiculo.Dominio.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculo.Dominio.CombustivelModule
{
    public class Combustivel : EntidadeBase
    {

        private string nome;
        private double valor;

        public Combustivel(string nome, double valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }

        public string Nome { get => nome; set => nome = value; }
        public double Valor { get => valor; set => valor = value; }


        public override bool Equals(object obj)
        {
            return obj is Combustivel combustivel &&
                   nome == combustivel.nome &&
                   valor == combustivel.valor;
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

            if(valor == default)
            {
                resultadoValidacao = "O campo valor é obrigatório";
            }
            if (valor < 0 )
            {
                resultadoValidacao = "O campo valor não aceita numeros negativos";
            }

            if(resultadoValidacao == "")
            {
                resultadoValidacao = "ESTA_VALIDO";
            }
            //comentario de teste

            return resultadoValidacao;
        }
    }
}
