using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculo.Dominio.ColaboradorModule
{
    public class Colaborador:PessoaBase
    {
        DateTime dataAdmissao;
        double salario;
        Cargo cargo;

        public DateTime DataAdmissao { get => dataAdmissao; set => dataAdmissao = value; }
        public double Salario { get => salario; set => salario = value; }
    }
}
