using LocadoraVeiculo.Dominio.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LocadoraVeiculo.Dominio.ClienteModule
{
    public class ClientePF:Pessoa
    {
        private string rg, cpf, cnh;
        private DateTime validadeCnh;

        public ClientePF(string nome, string endereco, string email, string cidade, string estado, string telefone, string celular, string rg, string cpf, string cnh, DateTime validadecnh)
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
            Cnh = cnh;
            validadeCnh = validadecnh;
        }

        public string Rg { get => rg; set => rg = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Cnh { get => cnh; set => cnh = value; }
        public DateTime ValidadeCnh { get => validadeCnh; set => validadeCnh = value; }

        public override bool Equals(object obj)
        {
            return obj is ClientePF condutor &&
                   rg == condutor.rg &&
                   cpf == condutor.cpf &&
                   cnh == condutor.cnh;
        }

        public override int GetHashCode()
        {
            int hashCode = -1114919384;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(rg);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(cpf);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(cnh);
            hashCode = hashCode * -1521134295 + validadeCnh.GetHashCode();
            return hashCode;
        }

        public override string Validar()
        {
            //string resultadoValidacao = String.Empty;

            Regex templateEmail = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
            string resultadoValidacao = "";

            if (String.IsNullOrEmpty(Nome))
                resultadoValidacao = "O campo nome é obrigatório";
            
            if (String.IsNullOrEmpty(Endereco))
                resultadoValidacao = "O campo endereço é obrigatório";
            
            if (String.IsNullOrEmpty(Cidade))
                resultadoValidacao = "O campo cidade é obrigatório";
            
            if (String.IsNullOrEmpty(Estado))
                resultadoValidacao = "O campo estado é obrigatório";
            
            if (String.IsNullOrEmpty(Email))
                resultadoValidacao = "O campo email é obrigatório";

            else if(templateEmail.IsMatch(Email) == false)
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O campo Email está inválido";

            if (String.IsNullOrEmpty(Telefone))
                resultadoValidacao = "O campo Telefone é obrigatório";

            else if (Telefone.Length < 7)
                resultadoValidacao = "O campo Telefone está inválido";

            if (String.IsNullOrEmpty(Celular))
                resultadoValidacao = "O campo Celular é obrigatório";

            else if (Celular.Length < 8)
                resultadoValidacao = "O campo Celular está inválido";

            if (String.IsNullOrEmpty(rg))
                resultadoValidacao = "O campo rg é obrigatório";
            
            if (String.IsNullOrEmpty(cpf))
                resultadoValidacao = "O campo cpf é obrigatório";
            
            if (String.IsNullOrEmpty(cnh))
                resultadoValidacao = "O campo chn é obrigatório";
            
            if (resultadoValidacao == "")
                 resultadoValidacao = "ESTA_VALIDO";
            

            return resultadoValidacao;
        }

        protected string QuebraDeLinha(string resultadoValidacao)
        {
            string quebraDeLinha = "";

            if (string.IsNullOrEmpty(resultadoValidacao) == false)
                quebraDeLinha = Environment.NewLine;

            return quebraDeLinha;
        }
    }
}
