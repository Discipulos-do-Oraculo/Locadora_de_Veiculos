using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculo.Dominio.ClienteModule
{
    public class ClienteCnpj: Pessoa
    {
        private string cnpj;
        private ClienteCondutor condutor;
        private TipoCliente tipoCliente;

        public string Cnpj { get => cnpj; set => cnpj = value; }
        public ClienteCondutor Condutor { get => condutor; set => condutor = value; }
        public TipoCliente TipoCliente { get => tipoCliente; set => tipoCliente = value; }
    }
}
