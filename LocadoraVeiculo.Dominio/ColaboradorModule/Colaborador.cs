using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculo.Dominio.ColaboradorModule
{
    public class Colaborador:Pessoa
    {

        

        private DateTime dataAdmissao;
        private double salario;
        private Cargo cargo;

        public DateTime DataAdmissao { get => dataAdmissao; set => dataAdmissao = value; }
        public double Salario { get => salario; set => salario = value; }
        public Cargo Cargo { get => cargo; set => cargo = value; }
    }
}
