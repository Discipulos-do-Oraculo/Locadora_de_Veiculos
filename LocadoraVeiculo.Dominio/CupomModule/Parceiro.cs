using LocadoraVeiculo.Dominio.GrupoDeVeiculosModule;
using LocadoraVeiculo.Dominio.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculo.Dominio.CupomModule
{
    public class Parceiro : EntidadeBase
    {
        private string nome;
        private Midia meioComunicao;

        public Parceiro(string nome, Midia meioComunicao)
        {
            this.nome = nome;
            this.meioComunicao = meioComunicao;
        }

        public string Nome { get => nome; set => nome = value; }
        public Midia MeioComunicao { get => meioComunicao; set => meioComunicao = value; }


        public Parceiro(string nome, Midia midia)
        {
            this.Nome = nome;
            this.MeioComunicao = midia;

        }

        public override bool Equals(object obj)
        {
            return obj is Parceiro parceiro &&
                   Nome == parceiro.Nome &&
                   EqualityComparer<Midia>.Default.Equals(MeioComunicao, parceiro.MeioComunicao);
        }

        public override int GetHashCode()
        {
            int hashCode = -773144989;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + EqualityComparer<Midia>.Default.GetHashCode(MeioComunicao);
            return hashCode;
        }

        public override string Validar()
        {
            string resultadoValidacao = String.Empty;

            if (String.IsNullOrEmpty(Nome))
            {
                resultadoValidacao = "O campo nome é obrigatório";
            }
            if (MeioComunicao == null)
            {
                resultadoValidacao = "O campo Mídia é obrigatório";
            }
            if (resultadoValidacao == "")
                resultadoValidacao = "ESTA_VALIDO";

            return resultadoValidacao;
        }
    }
}
