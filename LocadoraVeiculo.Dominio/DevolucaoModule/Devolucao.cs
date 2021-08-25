using LocadoraVeiculo.Dominio.CombustivelModule;
using LocadoraVeiculo.Dominio.LocacaoModule;
using LocadoraVeiculo.Dominio.shared;
using LocadoraVeiculo.Dominio.TaxasEServicosModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculo.Dominio.DevolucaoModule
{
    public class Devolucao : EntidadeBase
    {
        private Locacao locacao;
        private Combustivel tipoCombustivel;
        private DateTime dataRetorno;
        private int kmFinal;
        private double litrosGastos;
        private double valorTotal;

        public Devolucao(Locacao locacao, Combustivel tipoCombustivel, DateTime dataRetorno, int kmFinal, double litrosGastos, double valorTotal)
        {
            Locacao = locacao;
            TipoCombustivel = tipoCombustivel;
            DataRetorno = dataRetorno;
            KmFinal = kmFinal;
            LitrosGastos = litrosGastos;
            ValorTotal = valorTotal;
        }

        public Locacao Locacao { get => locacao; set => locacao = value; }
        public Combustivel TipoCombustivel { get => tipoCombustivel; set => tipoCombustivel = value; }
        public DateTime DataRetorno { get => dataRetorno; set => dataRetorno = value; }
        public int KmFinal { get => kmFinal; set => kmFinal = value; }
        public double LitrosGastos { get => litrosGastos; set => litrosGastos = value; }
        public double ValorTotal { get => valorTotal; set => valorTotal = value; }

        public override bool Equals(object obj)
        {
            return obj is Devolucao devolucao;
        }

        public override int GetHashCode()
        {
            int hashCode = -676388500;
    
            
            return hashCode;
        }

        public override string Validar()
        {
            string resultadoValidacao = String.Empty;

            if (valorTotal < 0)
                resultadoValidacao = "O campo valor total não pode ser menor que zero";

            if (locacao == null)
                resultadoValidacao = "Selecione uma locação para realizar devolução";

            if (tipoCombustivel == null)
                resultadoValidacao = "Selecione um combustível para realizar devolução";

            if(kmFinal == default)
                resultadoValidacao = "O campo Km Final é obrigatório";

            else if(kmFinal < 0)
                resultadoValidacao = "O campo Km Final não pode ser negativo";

            if (litrosGastos == default)
                resultadoValidacao = "O campo Litros Gastos é obrigatório";
            if (litrosGastos <0)
                resultadoValidacao = "O campo Litros Gastos não pode ser menor que zero";

            if (resultadoValidacao == "")
                resultadoValidacao = "ESTA_VALIDO";

            return resultadoValidacao;
        }
    }
}
