using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculo.Dominio.ClienteModule
{
    public class Condutor: Pessoa
    {
        private string rg, cpf, cnh;
        private DateTime validadeCnh;

        
        public Condutor(int id, string nome, string endereco, string email, string cidade, string estado, string telefone, string rg, string cpf, string cnh, DateTime validadecnh)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
            Email = email;
            Cidade = cidade;
            Estado = estado;
            Telefone = telefone;
            this.Rg = rg;
            this.Cpf = cpf;
            this.Cnh = cnh;
            ValidadeCnh = validadecnh;
        }

        public string Rg { get => rg; set => rg = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Cnh { get => cnh; set => cnh = value; }
        public DateTime ValidadeCnh { get => validadeCnh; set => validadeCnh = value; }

        public override bool Equals(object obj)
        {
            return obj is Condutor condutor &&
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
            if (String.IsNullOrEmpty(Rg))
            {
                resultadoValidacao = "O campo rg é obrigatório";
            }
            if (String.IsNullOrEmpty(Cpf))
            {
                resultadoValidacao = "O campo cpf é obrigatório";
            }
            if (String.IsNullOrEmpty(Cnh))
            {
                resultadoValidacao = "O campo chn é obrigatório";
            }

            if (resultadoValidacao == "")
            {
                resultadoValidacao = "ESTA_VALIDO";
            }

            return resultadoValidacao;
        }
    }
}
