using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculo.Dominio
{
    public class PessoaBase
    {
        int id, numero;
        string nome, logradouro, bairro, cidade, estado, telefone, celular;

        public int Id { get => id; set => id = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Celular { get => celular; set => celular = value; }
    }
}
