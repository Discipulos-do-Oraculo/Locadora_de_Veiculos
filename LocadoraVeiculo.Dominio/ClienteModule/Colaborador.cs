using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculo.Dominio.ClienteModule
{
    public class Colaborador:Pessoa
    {
        private string login, senha;
        DateTime dataEntrada;
        private double salario;

        public Colaborador(string nome, string endereco, string email, string cidade, string estado, string telefone, string login, string senha, DateTime dataEntrada, double salario)
        {
            Nome = nome;
            Endereco = endereco;
            Email = email;
            Cidade = cidade;
            Estado = estado;
            Telefone = telefone;
            this.login = login;
            this.senha = senha;
            this.dataEntrada = dataEntrada;
            this.salario = salario;
        }

        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }
        public DateTime DataEntrada { get => dataEntrada; set => dataEntrada = value; }
        public double Salario { get => salario; set => salario = value; }

        public override bool Equals(object obj)
        {
            return obj is Colaborador colaborador &&
                   login == colaborador.login &&
                   senha == colaborador.senha &&
                   dataEntrada == colaborador.dataEntrada &&
                   salario == colaborador.salario;
        }

        public override int GetHashCode()
        {
            int hashCode = 1243754664;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(login);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(senha);
            hashCode = hashCode * -1521134295 + dataEntrada.GetHashCode();
            hashCode = hashCode * -1521134295 + salario.GetHashCode();
            return hashCode;
        }
        public override string Validar()
        {
            string resultadoValidacao = String.Empty;

            if (String.IsNullOrEmpty(Nome))
            {
                resultadoValidacao = "O campo nome é obrigatório";
            }
            if (String.IsNullOrEmpty(Endereco))
            {
                resultadoValidacao = "O campo endereço é obrigatório";
            }
            if (String.IsNullOrEmpty(Cidade))
            {
                resultadoValidacao = "O campo cidade é obrigatório";
            }
            if (String.IsNullOrEmpty(Estado))
            {
                resultadoValidacao = "O campo estado é obrigatório";
            }
            if (String.IsNullOrEmpty(Email))
            {
                resultadoValidacao = "O campo email é obrigatório";
            }
            if (String.IsNullOrEmpty(Telefone))
            {
                resultadoValidacao = "O campo telefone é obrigatório";
            }
            if (String.IsNullOrEmpty(Celular))
            {
                resultadoValidacao = "O campo celular é obrigatório";
            }

            if (resultadoValidacao == "")
            {
                resultadoValidacao = "ESTA_VALIDO";
            }

            return resultadoValidacao;
        }
    }
}
