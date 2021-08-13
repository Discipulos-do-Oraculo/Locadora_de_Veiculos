using LocadoraVeiculo.Dominio.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculo.Dominio.TaxasEServicosModule
{
    public class TaxasEServicos : EntidadeBase
    {

        private string nome;
        private double valor;
        private bool calculoDiario;
        private bool calculoFixo;

        public TaxasEServicos(string nome, double valor, bool calculoDiario, bool calculoFixo)
        {
            this.Nome = nome;
            this.Valor = valor;
            this.CalculoDiario = calculoDiario;
            this.CalculoFixo = calculoFixo;
        }

        public string Nome { get => nome; set => nome = value; }
        public double Valor { get => valor; set => valor = value; }
        public bool CalculoDiario { get => calculoDiario; set => calculoDiario = value; }
        public bool CalculoFixo { get => calculoFixo; set => calculoFixo = value; }



        public override bool Equals(object obj)
        {
            return obj is TaxasEServicos taxasEServicos &&
                   nome == taxasEServicos.nome &&
                   valor == taxasEServicos.valor &&
                   calculoDiario == taxasEServicos.calculoDiario &&
                   calculoFixo == taxasEServicos.calculoFixo;

        }

        public override int GetHashCode()
        {
            int hashCode = 1409341681;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nome);
            hashCode = hashCode * -1521134295 + valor.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(calculoDiario);
            hashCode = hashCode * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(calculoFixo);
            return hashCode;
        }

        public override string Validar()
        {
            string resultadoValidacao = String.Empty;

            if (String.IsNullOrEmpty(nome))
            {
                resultadoValidacao = "O campo nome é obrigatório";
            }

            if (valor == default)
            {
                resultadoValidacao = "O campo valor é obrigatório";
            }

            if (valor < 0)
            {
                resultadoValidacao = "O campo valor não aceita numeros negativos";
            }

            if (calculoDiario == true && calculoFixo == true)
            {
                resultadoValidacao = "Só é possível selecionar um tipo de cobrança";
            }

            if (calculoDiario == false && calculoFixo == false)
            {
                resultadoValidacao = "Selecione um tipo de cobrança";
            }

            if (resultadoValidacao == "")
            {
                resultadoValidacao = "ESTA_VALIDO";
            }

            return resultadoValidacao;
        }
    }
}
