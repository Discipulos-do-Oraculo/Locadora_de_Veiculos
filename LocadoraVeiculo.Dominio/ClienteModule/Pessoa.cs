using LocadoraVeiculo.Dominio.shared;
using System;

namespace LocadoraVeiculo.Dominio
{
    public class Pessoa : EntidadeBase
    {
        private string nome, cidade, estado, telefone, celular, email, endereco;       
        public string Nome { get => nome; set => nome = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Email { get => email; set => email = value; }
        public string Endereco { get => endereco; set => endereco = value; }

        public override string Validar()
        {
            throw new NotImplementedException();
        }
    }
}
