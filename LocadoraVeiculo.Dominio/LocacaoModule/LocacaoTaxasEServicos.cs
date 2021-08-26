using LocadoraVeiculo.Dominio.shared;
using LocadoraVeiculo.Dominio.TaxasEServicosModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculo.Dominio.LocacaoModule
{
    public class LocacaoTaxasEServicos : EntidadeBase
    {
        private Locacao locacao;
        private TaxasEServicos taxasEServicos;

        public LocacaoTaxasEServicos(Locacao locacao, TaxasEServicos taxasEServicos)
        {
            this.Locacao = locacao;
            this.TaxasEServicos = taxasEServicos;
        }

        public Locacao Locacao { get => locacao; set => locacao = value; }
        public  TaxasEServicos TaxasEServicos { get => taxasEServicos; set => taxasEServicos = value; }

        public override bool Equals(object obj)
        {
            return obj is LocacaoTaxasEServicos servicos &&
                   EqualityComparer<Locacao>.Default.Equals(locacao, servicos.locacao) &&
                   EqualityComparer<TaxasEServicos>.Default.Equals(taxasEServicos, servicos.taxasEServicos);
        }

        public override int GetHashCode()
        {
            int hashCode = -1950110080;
            hashCode = hashCode * -1521134295 + EqualityComparer<Locacao>.Default.GetHashCode(locacao);
            hashCode = hashCode * -1521134295 + EqualityComparer<TaxasEServicos>.Default.GetHashCode(taxasEServicos);
            return hashCode;
        }

        public override string Validar()
        {
            return "ESTA_VALIDO";
        }
    }
}
