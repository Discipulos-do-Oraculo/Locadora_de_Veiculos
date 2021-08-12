using System;
using LocadoraVeiculo.Dominio.ClienteModule;
using System.Collections.Generic;
using System.Data;

namespace LocadoraVeiculos.Controlador.ClienteModule.ClienteCnpjControlador
{
    public class ControladorClienteCnpj : Controlador<ClienteCnpj>
    {
        #region Queries
        private const string sqlInserirClienteCnpj =
            @"INSERT INTO [TBCLIENTEPJ]
                (               
                    [NOME],        
                    [CNPJ],            
                    [TELEFONE],           
                    [EMAIL],     
                    [CIDADE],   
                    [ENDERECO],
                    [ESTADO]
                         
                )
                VALUES
                (
                    @NOME,
                    @CNPJ,
                    @EMAIL,
                    @CIDADE,
                    @ENDERECO,
                    @ESTADO
                )";

        private const string sqlEditarClienteCnpj =
            @" UPDATE [TBCLIENTEPJ]
                SET 
                    [NOME] = @NOME,        
                    [CNPJ] = @CNPJ,            
                    [TELEFONE] = @TELEFONE,           
                    [EMAIL]= @EMAIL,     
                    [CIDADE]= @NUMEROPORTAS,   
                    [ENDERECO]= @ANO,
                    [CELULAR] = @CELULAR,
                    [ESTADO] = @ESTADO

                WHERE [ID] = @ID";

        private const string sqlExcluirClienteCnpj =
            @"DELETE FROM [TBCLIENTEPJ] 
                WHERE [ID] = @ID";

        private const string sqlSelecionarTodosClienteCnpjs =
            @"SELECT 
                    [TBCLIENTEPJ].ID,
                    [NOME],
                    [CNPJ],
                    [TELEFONE],            
                    [EMAIL],           
                    [CIDADE],     
                    [ENDERECO],   
                    [CELULAR],
                    [ESTADO]

            FROM
                    [TBCLIENTEPJ]  ";

        private const string sqlSelecionarClienteCnpjPorId =
            @"SELECT 
                    [TBCLIENTEPJ].ID,
                    [NOME],
                    [CNPJ], 
                    [TELEFONE],            
                    [EMAIL],           
                    [CIDADE],     
                    [ENDERECO],   
                    [CELULAR],
                    [ESTADO]

            FROM
                    [TBCLIENTEPJ] 
            WHERE 
                [TBCLIENTEPJ].ID = @ID";


        private const string sqlExisteClienteCnpj =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBCLIENTEPJ]
            WHERE 
                [ID] = @ID";


        #endregion

        public override string InserirNovo(ClienteCnpj registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = Db.Insert(sqlInserirClienteCnpj, ObtemParametrosClienteCnpj(registro));
            }

            return resultadoValidacao;
        }

        public override string Editar(int id, ClienteCnpj registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarClienteCnpj, ObtemParametrosClienteCnpj(registro));
            }

            return resultadoValidacao;
        }

        public override bool Excluir(int id)
        {
            try
            {
                Db.Delete(sqlExcluirClienteCnpj, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public override bool Existe(int id)
        {
            return Db.Exists(sqlExisteClienteCnpj, AdicionarParametro("ID", id));
        }

        public override ClienteCnpj SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarClienteCnpjPorId, ConverterEmClienteCnpj, AdicionarParametro("ID", id));
        }

        public override List<ClienteCnpj> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodosClienteCnpjs, ConverterEmClienteCnpj);
        }


        /// <summary>
        /// //https://stackoverflow.com/questions/8503825/what-is-the-correct-sql-type-to-store-a-net-timespan-with-values-240000
        /// </summary>

        private ClienteCnpj ConverterEmClienteCnpj(IDataReader reader)
        {
            var nomeClienteCnpj = Convert.ToString(reader["NOME"]);
            var cnpj = Convert.ToString(reader["CNPJ"]);
            var telefone = Convert.ToString(reader["TELEFONE"]);
            var email = Convert.ToString(reader["EMAIL"]);
            var cidade = Convert.ToString(reader["CIDADE"]);
            var endereco = Convert.ToString(reader["ENDERECO"]);
            var celular = Convert.ToString(reader["CELULAR"]);
            var estado = Convert.ToString(reader["ESTADO"]);
            
            ClienteCnpj cliente = new ClienteCnpj(nomeClienteCnpj, cnpj, telefone, email, cidade, endereco, celular, estado);
            cliente.Id = Convert.ToInt32(reader["ID"]);

            return cliente;
        }

        private Dictionary<string, object> ObtemParametrosClienteCnpj(ClienteCnpj cliente)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", cliente.Id);
            parametros.Add("NOME", cliente.Nome);
            parametros.Add("CNPJ", cliente.Cnpj);
            parametros.Add("TELEFONE", cliente.Telefone);
            parametros.Add("Email", cliente.Email);
            parametros.Add("Cidade", cliente.Cidade);
            parametros.Add("ENDERECO", cliente.Endereco);
            parametros.Add("CELULAR", cliente.Celular);
            parametros.Add("ESTADO", cliente.Estado);

            return parametros;
        }

    }
}
