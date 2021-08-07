using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculo.Dominio.ClienteModule
{
    public class ClienteCondutor:PessoaBase
    {
        string rg, cpf, cnh;
        DateTime validadeCnh;
        TipoCliente tipoCliente;

        public string Rg { get => rg; set => rg = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Cnh { get => cnh; set => cnh = value; }
        public DateTime ValidadeCnh { get => validadeCnh; set => validadeCnh = value; }
    }
}
