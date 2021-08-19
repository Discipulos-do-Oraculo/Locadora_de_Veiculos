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

        private TaxasEServicos servicos;
        private ClienteCnpj empresa;
        private Condutor condutor;
        private Veiculo veiculo;
        private string plano;
        private DateTime dataSaida, dataRetorno;
        private double valorTotal, caucao;
        private int kmInicial, kmFinal;

        public Locacao( ClienteCnpj empresa, TaxasEServicos servicos, Condutor condutor, Veiculo veiculo, string plano, DateTime dataSaida, DateTime dataRetorno, double valorTotal, double caucao, int kmInicial, int kmFinal)
        {
            
            this.empresa = empresa;
            this.Servicos = servicos;
            this.condutor = condutor;
            this.veiculo = veiculo;
            this.plano = plano;
            this.dataSaida = dataSaida;
            this.dataRetorno = dataRetorno;
            this.valorTotal = valorTotal;
            this.caucao = caucao;
            this.kmInicial = kmInicial;
            this.kmFinal = kmFinal;
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
        public int KmFinal { get => kmFinal; set => kmFinal = value; }
        public TaxasEServicos Servicos { get => servicos; set => servicos = value; }

        public override bool Equals(object obj)
        {
            return obj is Locacao locacao &&
                   EqualityComparer<ClienteCnpj>.Default.Equals(empresa, locacao.empresa) &&
                   EqualityComparer<Condutor>.Default.Equals(condutor, locacao.condutor) &&
                   EqualityComparer<Veiculo>.Default.Equals(veiculo, locacao.veiculo) &&
                   EqualityComparer<TaxasEServicos>.Default.Equals(servicos, locacao.servicos) &&
                   plano == locacao.plano &&
                   dataSaida == locacao.dataSaida &&
                   dataRetorno == locacao.dataRetorno &&
                   valorTotal == locacao.valorTotal &&
                   caucao == locacao.caucao &&
                   kmInicial == locacao.kmInicial &&
                   kmFinal == locacao.kmFinal;
        }

        public override int GetHashCode()
        {
            int hashCode = 2070347078;

            hashCode = hashCode * -1521134295 + EqualityComparer<ClienteCnpj>.Default.GetHashCode(empresa);
            hashCode = hashCode * -1521134295 + EqualityComparer<Condutor>.Default.GetHashCode(condutor);
            hashCode = hashCode * -1521134295 + EqualityComparer<Veiculo>.Default.GetHashCode(veiculo);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(plano);
            hashCode = hashCode * -1521134295 + dataSaida.GetHashCode();
            hashCode = hashCode * -1521134295 + dataRetorno.GetHashCode();
            hashCode = hashCode * -1521134295 + valorTotal.GetHashCode();
            hashCode = hashCode * -1521134295 + caucao.GetHashCode();
            hashCode = hashCode * -1521134295 + kmInicial.GetHashCode();
            hashCode = hashCode * -1521134295 + kmFinal.GetHashCode();
            return hashCode;
        }

        public override string Validar()
        {
            throw new NotImplementedException();
        }
    }
}
