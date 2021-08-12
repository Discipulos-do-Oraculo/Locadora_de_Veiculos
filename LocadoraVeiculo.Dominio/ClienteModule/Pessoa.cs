using LocadoraVeiculo.Dominio.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculo.Dominio
{
    public class Pessoa : EntidadeBase
    {
        
        private string nome, endereco, email, cidade, estado, telefone, celular;

        
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Celular { get => celular; set => celular = value; }

        public override string Validar()
        {
            throw new NotImplementedException();
        }
    }
}
