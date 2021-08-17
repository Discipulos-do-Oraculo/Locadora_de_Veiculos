using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LocadoraVeiculo.Dominio.ClienteModule
{
    public class ClienteCnpj: Pessoa
    {
        private string cnpj;

        private Condutor condutor;
        private string nomeClienteCnpj;

        public override string ToString() => $"{NomeClienteCnpj}";
        public ClienteCnpj(string nomeEmpresa)
        {
            nomeClienteCnpj = nomeEmpresa;
        }

        public ClienteCnpj(string nomeClienteCnpj, string cnpj, string telefone, string email, string cidade, string endereco, string celular, string estado)
        {
            this.nomeClienteCnpj = nomeClienteCnpj;
            this.cnpj = cnpj;
            Telefone = telefone;
            Email = email;
            Cidade = cidade;
            Endereco = endereco;
            Celular = celular;
            Estado = estado;
        }

        public string NomeClienteCnpj { get => nomeClienteCnpj; set => nomeClienteCnpj = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }

        public Condutor Condutor { get => condutor; set => condutor = value; }
        
        public override bool Equals(object obj)
        {
            return obj is ClienteCnpj cnpj &&
                   this.cnpj == cnpj.cnpj &&
                   EqualityComparer<Condutor>.Default.Equals(condutor, cnpj.condutor);
                   
        }

        public override int GetHashCode()
        {
            int hashCode = 1129194018;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(cnpj);
            hashCode = hashCode * -1521134295 + EqualityComparer<Condutor>.Default.GetHashCode(condutor);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nomeClienteCnpj);

            return hashCode;
        }

        public override string Validar()
        {
            Regex templateEmail = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
            string resultadoValidacao = "";

            if (String.IsNullOrEmpty(Cnpj))
                resultadoValidacao = "O campo CNPJ é obrigatório";
            
            if(String.IsNullOrEmpty(Celular))
                resultadoValidacao = "O campo Celular é obrigatório";

            else if (Celular.Length < 8)
                resultadoValidacao = "O campo celular está inválido";

            if (String.IsNullOrEmpty(Telefone))
                resultadoValidacao = "O campo Telefone é obrigatório";

            else if (Telefone.Length < 7)
                resultadoValidacao = "O campo telefone está inválido";

            if (String.IsNullOrEmpty(Cidade))
                resultadoValidacao = "O campo Cidade é obrigatório";

            if (String.IsNullOrEmpty(Celular))
                resultadoValidacao = "O campo Celular é obrigatório";

            if (String.IsNullOrEmpty(Email))
                resultadoValidacao = "O campo Email é obrigatório";

            else if (templateEmail.IsMatch(Email) == false)
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O campo email está inválido";

            if (String.IsNullOrEmpty(Estado))
                resultadoValidacao = "O campo Estado é obrigatório";

            if (String.IsNullOrEmpty(Endereco))
                resultadoValidacao = "O campo Endereço é obrigatório";

            if (String.IsNullOrEmpty(NomeClienteCnpj))
                resultadoValidacao = "O campo Nome é obrigatório";

            if (resultadoValidacao == "")
                resultadoValidacao = "ESTA_VALIDO";

            return resultadoValidacao;
        }

    }
}
