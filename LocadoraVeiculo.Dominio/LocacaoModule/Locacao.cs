using LocadoraVeiculo.Dominio.ClienteModule;
using LocadoraVeiculo.Dominio.shared;
using LocadoraVeiculo.Dominio.TaxasEServicosModule;
using LocadoraVeiculo.Dominio.VeiculoModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculo.Dominio.LocacaoModule
{
    public class Locacao : EntidadeBase
    {

    
        private ClienteCnpj empresa;
        private Condutor condutor;
        private Veiculo veiculo;
        private string plano;
        private DateTime dataSaida, dataRetorno;
        private double valorTotal, caucao;
        private int kmInicial;
        private ClienteCnpj pessoaPJ = null;
        private ClientePF pessoaPF = null;


        public Locacao( ClienteCnpj empresa, Condutor condutor, Veiculo veiculo, string plano, DateTime dataSaida, DateTime dataRetorno, double valorTotal, double caucao, int kmInicial)
        {
            
            this.empresa = empresa;
            this.condutor = condutor;
            this.veiculo = veiculo;
            this.plano = plano;
            this.dataSaida = dataSaida;
            this.dataRetorno = dataRetorno;
            this.valorTotal = valorTotal;
            this.caucao = caucao;
            this.kmInicial = kmInicial;
       
        }

        public Locacao( ClientePF pessoaPF, Veiculo veiculo, string plano, DateTime dataSaida, DateTime dataRetorno, double valorFinal, double valorCaucao, int kmInicial)
        {
            this.PessoaPF = pessoaPF;
            this.veiculo = veiculo;
            this.plano = plano;
            this.dataSaida = dataSaida;
            this.dataRetorno = dataRetorno;
            this.valorTotal = valorFinal;
            this.caucao = valorCaucao;
            this.kmInicial = kmInicial;
        }

        public ClienteCnpj Empresa { get => empresa; set => empresa = value; }
        public Condutor Condutor { get => condutor; set => condutor = value; }
        public Veiculo Veiculo { get => veiculo; set => veiculo = value; }
        public string Plano { get => plano; set => plano = value; }
        public DateTime DataSaida { get => dataSaida; set => dataSaida = value; }
        public DateTime DataRetorno { get => dataRetorno; set => dataRetorno = value; }
        public double ValorTotal { get => valorTotal; set => valorTotal = value; }
        public double Caucao { get => caucao; set => caucao = value; }
        public int KmInicial { get => kmInicial; set => kmInicial = value; }
        public ClientePF PessoaPF { get => pessoaPF; set => pessoaPF = value; }

        public override bool Equals(object obj)
        {
            return obj is Locacao locacao &&
                  
                   plano == locacao.plano &&
                   dataSaida == locacao.dataSaida &&
                   dataRetorno == locacao.dataRetorno &&
                   valorTotal == locacao.valorTotal &&
                   caucao == locacao.caucao &&
                   kmInicial == locacao.kmInicial;
        }

        public override int GetHashCode()
        {
            int hashCode = 2070347078;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(plano);
            hashCode = hashCode * -1521134295 + dataSaida.GetHashCode();
            hashCode = hashCode * -1521134295 + dataRetorno.GetHashCode();
            hashCode = hashCode * -1521134295 + valorTotal.GetHashCode();
            hashCode = hashCode * -1521134295 + caucao.GetHashCode();
            hashCode = hashCode * -1521134295 + kmInicial.GetHashCode();
            return hashCode;
        }

        public override string Validar()
        {
            string resultadoValidacao = String.Empty;

            if (valorTotal < 0)
            {
                resultadoValidacao = "o campo valor total não pode ser menor ou igual a zero";
            }

            if (caucao == 0)
            {
                resultadoValidacao = "o campo valor garantia tem que ser maior que zero";
            }

            if(dataRetorno < dataSaida)
            {
                resultadoValidacao = "data de retorno não pode ser menor que a data de saída";
            }


            if (dataRetorno == DateTime.MinValue)
            {
                resultadoValidacao = "data retorno inválida";
            }

            if (dataRetorno < DateTime.Today)
            {
                resultadoValidacao = "data retorno inválida";
            }

            if (dataSaida == DateTime.MinValue)
            {
                resultadoValidacao = "data saida inválida";
            }

            if(condutor != null && condutor.ValidadeCnh < DateTime.Now )
            {
                resultadoValidacao = "CNH vencida";
            }

            if (pessoaPF != null && pessoaPF.ValidadeCnh < DateTime.Now)
            {
                resultadoValidacao = "CNH vencida";
            }

            if (kmInicial < 0)
            {
                resultadoValidacao = "o campo Km Inicial não pode ser menor que zero";
            }

            if(String.IsNullOrEmpty(plano))
            {
                resultadoValidacao = "selecione o plano para locação";
            }

            if (veiculo == null)
            {
                resultadoValidacao = "selecione o veículo para locação";
            }

            if (resultadoValidacao == "")
            {
                resultadoValidacao = "ESTA_VALIDO";
            }

            return resultadoValidacao;
        }
    }
}
