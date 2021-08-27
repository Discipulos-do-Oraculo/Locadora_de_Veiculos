using LocadoraVeiculo.Dominio.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculo.Dominio.CupomModule
{
    public class Cupom : EntidadeBase
    {
        private string nome;
        private DateTime dataInicio, dataFinal;
        private Parceiro parceiro;
        private double valor, valorMinimo;
        private bool calculoReal, calculoPorcentagem;
        public new int Id { get; set; }

        public override string ToString()
        {
            return Nome.ToString();
        }

        public Cupom(string nome, DateTime dataInicio, DateTime dataFinal, Parceiro parceiro, double valor, double valorMinimo, bool calculoReal, bool calculoPorcentagem)
        {
            this.Nome = nome;
            this.DataInicio = dataInicio;
            this.DataFinal = dataFinal;
            this.Parceiro = parceiro;
            this.Valor = valor;
            this.ValorMinimo = valorMinimo;
            this.CalculoReal = calculoReal;
            this.CalculoPorcentagem = calculoPorcentagem;
        }

        public string Nome { get => nome; set => nome = value; }
        public DateTime DataInicio { get => dataInicio; set => dataInicio = value; }
        public DateTime DataFinal { get => dataFinal; set => dataFinal = value; }
        public Parceiro Parceiro { get => parceiro; set => parceiro = value; }
        public double Valor { get => valor; set => valor = value; }
        public double ValorMinimo { get => valorMinimo; set => valorMinimo = value; }
        public bool CalculoReal { get => calculoReal; set => calculoReal = value; }
        public bool CalculoPorcentagem { get => calculoPorcentagem; set => calculoPorcentagem = value; }

        public override bool Equals(object obj)
        {
            return obj is Cupom cupom &&
                   Nome == cupom.Nome &&
                   DataInicio == cupom.DataInicio &&
                   DataFinal == cupom.DataFinal &&
                   EqualityComparer<Parceiro>.Default.Equals(Parceiro, cupom.Parceiro) &&
                   Valor == cupom.Valor &&
                   ValorMinimo == cupom.ValorMinimo &&
                   CalculoReal == cupom.CalculoReal &&
                   CalculoPorcentagem == cupom.CalculoPorcentagem;
        }

        public override int GetHashCode()
        {
            int hashCode = 1814281897;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + DataInicio.GetHashCode();
            hashCode = hashCode * -1521134295 + DataFinal.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Parceiro>.Default.GetHashCode(Parceiro);
            hashCode = hashCode * -1521134295 + Valor.GetHashCode();
            hashCode = hashCode * -1521134295 + ValorMinimo.GetHashCode();
            hashCode = hashCode * -1521134295 + CalculoReal.GetHashCode();
            hashCode = hashCode * -1521134295 + CalculoPorcentagem.GetHashCode();
            return hashCode;
        }

        public override string Validar()
        {
            string resultadoValidacao = String.Empty;

            
            
            if (Valor == default)
            {
                resultadoValidacao = "O campo valor é obrigatório";
            }
            if (Valor < 0)
            {
                resultadoValidacao = "O campo valor não pode ser negativo";
            }
            if (ValorMinimo == default)
            {
                resultadoValidacao = "O campo valor mínimo é obrigatório";
            }
            if (ValorMinimo < 0)
            {
                resultadoValidacao = "O campo valor mínimo não pode ser negativo";
            }

            if(dataFinal.Date < dataInicio.Date)
            {
                resultadoValidacao = "O campo data final não pode ser menor que o campo data início";
            }

            if (dataFinal.Date == DateTime.MinValue)
            {
                resultadoValidacao = "O campo data final esta inválido";
            }

            if (dataInicio.Date == DateTime.MinValue)
            {
                resultadoValidacao = "O campo data início esta inválido";
            }

            if (Parceiro == null)
            {
                resultadoValidacao = "O campo Parceiro é obrigatório";
            }


            if (String.IsNullOrEmpty(Nome))
            {
                resultadoValidacao = "O campo nome é obrigatório";
            }

            if (resultadoValidacao == "")
                resultadoValidacao = "ESTA_VALIDO";

            return resultadoValidacao;
        }
    }
}
