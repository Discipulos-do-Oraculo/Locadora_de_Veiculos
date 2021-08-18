using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LocadoraVeiculo.Dominio.ClienteModule
{
    public class Colaborador:Pessoa
    {
        private string login, senha, rg, cpf;
        DateTime dataEntrada;
        private double salario;

        public Colaborador(string nome, string endereco, string email, string cidade, string estado, string telefone, string celular, string rg, string cpf, string login, string senha, DateTime dataEntrada, double salario)
        {
            Nome = nome;
            Endereco = endereco;
            Email = email;
            Cidade = cidade;
            Estado = estado;
            Telefone = telefone;
            Celular = celular;
            Rg = rg;
            Cpf = cpf;
            Login = login;
            Senha = senha;
            DataEntrada = dataEntrada;
            Salario = salario;
        }

        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Cpf { get => cpf; set => cpf = value; }
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
            Regex templateEmail = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
            string resultadoValidacao = "";


            if (String.IsNullOrEmpty(Senha))
                resultadoValidacao = "O campo senha é obrigatório";

            if (String.IsNullOrEmpty (Login))
                resultadoValidacao = "O campo login é obrigatório";

            if (Salario == default)
                resultadoValidacao = "O campo salário é obrigatório";

            if (DataEntrada == DateTime.MinValue)
                resultadoValidacao = "O campo Data de Entrada é inválido";

            if (DataEntrada == DateTime.MaxValue)
                resultadoValidacao = "O campo Data de Entrada é inválido";

            
            if (String.IsNullOrEmpty(Endereco))
                resultadoValidacao = "O campo endereço é obrigatório";
            
            if (String.IsNullOrEmpty(Cidade))
                resultadoValidacao = "O campo cidade é obrigatório";
            
            if (String.IsNullOrEmpty(Estado))
                resultadoValidacao = "O campo estado é obrigatório";
            
            if (String.IsNullOrEmpty(Email))
                resultadoValidacao = "O campo email é obrigatório";

            else if (templateEmail.IsMatch(Email) == false)
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O campo Email está inválido";

            if (String.IsNullOrEmpty(Celular))
                resultadoValidacao = "O campo celular é obrigatório";

            else if (Celular.Length < 8)
                resultadoValidacao = "O campo Celular está inválido";

            if (String.IsNullOrEmpty(Telefone))
                resultadoValidacao = "O campo telefone é obrigatório";

            else if (Telefone.Length < 7)
                resultadoValidacao = "O campo Telefone está inválido";


            if (String.IsNullOrEmpty(Cpf))
                resultadoValidacao = "O campo CPF é obrigatório";


            if (String.IsNullOrEmpty(Rg))
                resultadoValidacao = "O campo Rg é obrigatório";

            if (String.IsNullOrEmpty(Nome))
                resultadoValidacao = "O campo nome é obrigatório";


            if (resultadoValidacao == "")
                resultadoValidacao = "ESTA_VALIDO";
            
            return resultadoValidacao;
        }
    }
}
