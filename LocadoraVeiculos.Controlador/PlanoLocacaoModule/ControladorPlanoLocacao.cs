using LocadoraVeiculo.Dominio.ClienteModule;
using LocadoraVeiculo.Dominio.GrupoDeVeiculosModule;
using LocadoraVeiculo.Dominio.PlanoLocacaoModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Controlador.PlanoLocacaoModule
{
    public class ControladorPlanoLocacao : Controlador<PlanoDeLocacao>
    {
        #region Queries
        private const string sqlInserirPlanoLocacao =
            @"INSERT INTO [TBPLANODELOCACAO]
                (               
                    [TITULO],        
                    [VALOR],            
                    [DESCRICAO]  
                )
                VALUES
                (
                    @TITULO,
                    @VALOR,
                    @DESCRICAO
                )";

        private const string sqlEditarPlanoLocacao =
            @" UPDATE [TBPLANODELOCACAO]
                SET 
                    [TITULO] = @TITULO,        
                    [VALOR] = @VALOR,            
                    [DESCRICAO] = @DESCRICAO          
                   
                WHERE [ID] = @ID";

        private const string sqlExcluirPlanoLocacao =
            @"DELETE FROM [TBPLANODELOCACAO] 
                WHERE [ID] = @ID";

        private const string sqlSelecionarTodosPlanoLocacao =
            @"SELECT 
                    [ID],
                    [TITULO],        
                    [VALOR],            
                    [DESCRICAO]
            FROM
                    [TBPLANODELOCACAO]";

        private const string sqlSelecionarPlanoLocacaoPorId =
            @"SELECT 
                    [ID],
                    [TITULO],        
                    [VALOR],            
                    [DESCRICAO]
            FROM
                    [TBPLANODELOCACAO]
            WHERE 
                ID = @ID";


        private const string sqlExistePlanoLocacao =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBPLANODELOCACAO]
            WHERE 
                [ID] = @ID";


        #endregion

        public override string Editar(int id, PlanoDeLocacao registro)
        {
            string resultadoValidacao = registro.Validar();
            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarPlanoLocacao, ObtemParametrosPlanoDeLocacao(registro));
            }
            return resultadoValidacao;
        }

        public override bool Excluir(int id)
        {
            try
            {
                Db.Delete(sqlExcluirPlanoLocacao, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public override bool Existe(int id)
        {
            return Db.Exists(sqlExistePlanoLocacao, AdicionarParametro("ID", id));
        }

        public override string InserirNovo(PlanoDeLocacao registro)
        {
            string resultadoValidacao = registro.Validar();


            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = Db.Insert(sqlInserirPlanoLocacao, ObtemParametrosPlanoDeLocacao(registro));

            }

            return resultadoValidacao;
        }

        public override PlanoDeLocacao SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarPlanoLocacaoPorId, ConverterEmPlanoLocacao, AdicionarParametro("ID", id));
        }

        public override List<PlanoDeLocacao> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodosPlanoLocacao, ConverterEmPlanoLocacao);
        }

        private PlanoDeLocacao ConverterEmPlanoLocacao(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string titulo = Convert.ToString(reader["TITULO"]);
            double valor = Convert.ToDouble(reader["VALOR"]);
            string descricao = Convert.ToString(reader["DESCRICAO"]);

            PlanoDeLocacao planoDeLocacao = new PlanoDeLocacao(titulo, valor, descricao);

            planoDeLocacao.Id = id;

            return planoDeLocacao;
        }
        private Dictionary<string, object> ObtemParametrosPlanoDeLocacao(PlanoDeLocacao plano)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", plano.Id);
            parametros.Add("TITULO", plano.Titulo);
            parametros.Add("VALOR", plano.Valor);
            parametros.Add("DESCRICAO", plano.Descricao);

            return parametros;
        }
    }
}
