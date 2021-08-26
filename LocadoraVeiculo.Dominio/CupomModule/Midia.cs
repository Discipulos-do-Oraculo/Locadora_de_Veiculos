using LocadoraVeiculo.Dominio.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculo.Dominio.CupomModule
{
    public class Midia : EntidadeBase
    {
        private string nome;

        public Midia(string nome)
        {
            this.nome = nome;
        }

        public string Nome { get => nome; set => nome = value; }

        public override bool Equals(object obj)
        {
            return obj is Midia midia &&
                   Nome == midia.Nome;
        }

        public override int GetHashCode()
        {
            return 109702896 + EqualityComparer<string>.Default.GetHashCode(Nome);
        }

        public override string Validar()
        {
            string resultadoValidacao = String.Empty;

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
