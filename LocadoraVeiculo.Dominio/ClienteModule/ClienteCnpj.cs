using System;
using System.Collections.Generic;

namespace LocadoraVeiculo.Dominio.ClienteModule
{
    public class ClienteCnpj: Pessoa
    {
        private string cnpj;
        private ClienteCondutor condutor;
        private string nomeClienteCnpj;

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

        public string Nome { get => nomeClienteCnpj; set => nomeClienteCnpj = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public ClienteCondutor Condutor { get => condutor; set => condutor = value; }
        
        public override bool Equals(object obj)
        {
            return obj is ClienteCnpj cnpj &&
                   this.cnpj == cnpj.cnpj &&
                   EqualityComparer<ClienteCondutor>.Default.Equals(condutor, cnpj.condutor);
                   
        }

        public override int GetHashCode()
        {
            int hashCode = 1129194018;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(cnpj);
            hashCode = hashCode * -1521134295 + EqualityComparer<ClienteCondutor>.Default.GetHashCode(condutor);
           
            return hashCode;
        }

        public override string Validar()
        {
            string resultadoValidacao = String.Empty;

            if (String.IsNullOrEmpty(Cnpj))
                resultadoValidacao = "O campo CNPJ é obrigatório";
            
            if(String.IsNullOrEmpty(Celular))
                resultadoValidacao = "O campo Celular é obrigatório";

            if (String.IsNullOrEmpty(Telefone))
                resultadoValidacao = "O campo Telefone é obrigatório";

            if (String.IsNullOrEmpty(Cidade))
                resultadoValidacao = "O campo Cidade é obrigatório";

            if (String.IsNullOrEmpty(Celular))
                resultadoValidacao = "O campo Celular é obrigatório";

            if (String.IsNullOrEmpty(Email))
                resultadoValidacao = "O campo Email é obrigatório";

            if (String.IsNullOrEmpty(Estado))
                resultadoValidacao = "O campo Estado é obrigatório";

            if (String.IsNullOrEmpty(Endereco))
                resultadoValidacao = "O campo Endereço é obrigatório";

            if (String.IsNullOrEmpty(Nome))
                resultadoValidacao = "O campo Nome é obrigatório";

            if (resultadoValidacao == "")
                resultadoValidacao = "ESTA_VALIDO";

            return resultadoValidacao;
        }
    }
}
