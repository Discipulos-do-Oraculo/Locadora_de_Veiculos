using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculo.Dominio.ClienteModule
{
    public class ClienteCnpj
    {
        string cnpj;
        ClienteCondutor condutor;
        TipoCliente tipoCliente;

        public string Cnpj { get => cnpj; set => cnpj = value; }
    }
}
