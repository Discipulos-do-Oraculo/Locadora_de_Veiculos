using LocadoraVeiculo.Dominio.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculo.Dominio.ClienteModule
{
    public class TipoCliente : EntidadeBase
    {
       
        string nome;
        
        public string Nome { get => nome; set => nome = value; }

        public override string Validar()
        {
            throw new NotImplementedException();
        }
    }
}
