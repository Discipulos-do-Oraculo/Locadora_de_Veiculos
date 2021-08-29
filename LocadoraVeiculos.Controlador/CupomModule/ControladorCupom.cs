using LocadoraVeiculo.Dominio.ClienteModule;
using LocadoraVeiculo.Dominio.CupomModule;
using LocadoraVeiculo.Dominio.GrupoDeVeiculosModule;
using LocadoraVeiculo.Dominio.VeiculoModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Controlador.CupomModule
{
    public class ControladorCupom : Controlador<Cupom>
    {
        #region Queries
        private const string sqlInserirCupom =
            @"INSERT INTO [TBCUPOM]
                (               
                    [NOME],        
                    [DATAINICIO],            
                    [DATAFIM],           
                    [IDPARCEIRO],     
                    [VALOR],   
                    [VALORMINIMO],            
                    [CALCULOREAL],         
                    [CALCULOPORCENTAGEM]
                )
                VALUES
                (
                    @NOME,
                    @DATAINICIO,
                    @DATAFIM,
                    @IDPARCEIRO,
                    @VALOR,
                    @VALORMINIMO,
                    @CALCULOREAL,
                    @CALCULOPORCENTAGEM
                )";

        private const string sqlEditarCupom =
            @" UPDATE [TBCUPOM]
                SET 
                    [NOME] = @NOME,        
                    [DATAINICIO] = @DATAINICIO,            
                    [DATAFIM] = @DATAFIM,           
                    [IDPARCEIRO]= @IDPARCEIRO,     
                    [VALOR]= @VALOR,   
                    [VALORMINIMO]= @VALORMINIMO,            
                    [CALCULOPORCENTAGEM]= @CALCULOPORCENTAGEM
                WHERE [ID] = @ID";

        private const string sqlExcluirCupom =
            @"DELETE FROM [TBCUPOM] 
                WHERE [ID] = @ID";

        private const string sqlSelecionarTodosCupom =
            @"SELECT 
                    [TBCUPOM].ID, 
                    [TBCUPOM].NOME AS NOMECUPOM,        
                    [TBCUPOM].DATAINICIO,            
                    [TBCUPOM].DATAFIM,           
                    [TBCUPOM].IDPARCEIRO,     
                    [TBCUPOM].VALOR,   
                    [TBCUPOM].VALORMINIMO,            
                    [TBCUPOM].CALCULOPORCENTAGEM,         
                    [TBCUPOM].CALCULOREAL,

                    [TBPARCEIROS].NOME AS NOMEPARCEIRO,
                    [TBPARCEIROS].IDMIDIA,

                    [TBMIDIA].NOME AS NOMEMIDIA
            FROM
                    [TBCUPOM]  INNER JOIN
                    [TBPARCEIROS] 
            ON
                    [TBCUPOM].IDPARCEIRO = [TBPARCEIROS].ID
                    INNER JOIN [TBMIDIA] 
            ON
                    [TBPARCEIROS].IDMIDIA = [TBMIDIA].ID";

        private const string sqlSelecionarCupomPorId =
            @"SELECT  
                    [TBCUPOM].ID, 
                    [TBCUPOM].NOME AS NOMECUPOM,        
                    [TBCUPOM].DATAINICIO,            
                    [TBCUPOM].DATAFIM,           
                    [TBCUPOM].IDPARCEIRO,     
                    [TBCUPOM].VALOR,   
                    [TBCUPOM].VALORMINIMO,            
                    [TBCUPOM].CALCULOPORCENTAGEM,         
                    [TBCUPOM].CALCULOREAL,

                    [TBPARCEIROS].NOME AS NOMEPARCEIRO,
                    [TBPARCEIROS].IDMIDIA,

                    [TBMIDIA].NOME AS NOMEMIDIA
            FROM
                    [TBCUPOM]  INNER JOIN
                    [TBPARCEIROS] 
            ON
                    [TBCUPOM].IDPARCEIRO = [TBPARCEIROS].ID
                    INNER JOIN [TBMIDIA] 
            ON
                    [TBPARCEIROS].IDMIDIA = [TBMIDIA].ID
            WHERE 
                    [TBCUPOM].ID = @ID";

        private const string selecionarCupomPorParceiro =
                    @" SELECT
                    [TBCUPOM].ID,
                    [TBCUPOM].NOME,        
                    [TBCUPOM].IDPARCEIRO,            
                    [TBCUPOM].CALCULOPORCENTAGEM,           
                    [TBCUPOM].CALCULOREAL,
                    [TBCUPOM].DATAFIM, 
                    [TBCUPOM].DATAINICIO,   
                    [TBCUPOM].VALOR,            
                    [TBCUPOM].VALORMINIMO,       
                    
                    [TBPARCEIROS].ID AS IDPARCEIRO,
                    [TBPARCEIROS].NOME AS NOMEPARCEIRO,
                    [TBPARCEIROS].IDMIDIA 
                    
            FROM
                    [TBCUPOM] INNER JOIN
                    [TBPARCEIROS]
            
            ON
                    [TBCUPOM].IDPARCEIRO = [TBPARCEIROS].ID";

        private const string sqlExisteCupom =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBCUPOM]
            WHERE 
                [ID] = @ID";

        private const string sqlTemLocacao =
            @"SELECT COUNT(*) FROM TBCUPOM INNER JOIN 
              TBLOCACAO ON TBCUPOM.ID = TBLOCACAO.TBCUPOM 
              WHERE TBCUPOM.ID = @ID  ;";

        #endregion


        public override string Editar(int id, Cupom registro)
        {
            string resultadoValidacao = registro.Validar();
            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarCupom, ObtemParametrosCupom(registro));

            }

            return resultadoValidacao;
        }

        public override bool Excluir(int id)
        {
            try
            {
                Db.Delete(sqlExcluirCupom, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public override bool Existe(int id)
        {
            return Db.Exists(sqlExisteCupom, AdicionarParametro("ID", id));
        }

        public override string InserirNovo(Cupom registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = Db.Insert(sqlInserirCupom, ObtemParametrosCupom(registro));
            }

            return resultadoValidacao;
        }

        public override Cupom SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarCupomPorId, ConverterEmCupom, AdicionarParametro("ID", id));
        }

        public override List<Cupom> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodosCupom, ConverterEmCupom);
        }

        public List<Cupom> SelecionarPorParceiro(int id)
        {
            return Db.GetAll(selecionarCupomPorParceiro, ConverterEmCupom, AdicionarParametro("IDPARCEIRO", id));
        }

        private Cupom ConverterEmCupom(IDataReader reader)
        {
                    
            var nomeCupom = Convert.ToString(reader["NOMECUPOM"]);
            var dataInicio = Convert.ToDateTime(reader["DATAINICIO"]);
            var dataFinal = Convert.ToDateTime(reader["DATAFIM"]);
            var valor = Convert.ToDouble(reader["VALOR"]);
            var valorMinimo = Convert.ToDouble(reader["VALORMINIMO"]);
            var calculoReal = Convert.ToBoolean(reader["CALCULOREAL"]);
            var calculoPorcentagem = Convert.ToBoolean(reader["CALCULOPORCENTAGEM"]);
            var idCupom = Convert.ToInt32(reader["ID"]);
            var idParceiro = Convert.ToInt32(reader["IDPARCEIRO"]);


            var nomeMidia = Convert.ToString(reader["NOMEMIDIA"]);
            Midia meioComunicao = new Midia(nomeMidia);

            var nomeParceiro = Convert.ToString(reader["NOMEPARCEIRO"]);
            var idMidia = Convert.ToInt32(reader["IDMIDIA"]);
            meioComunicao.Id = idMidia;

            Parceiro parceiro = new Parceiro(nomeParceiro,meioComunicao);
            parceiro.Id = idParceiro;

            Cupom cupom = new Cupom(nomeCupom,dataInicio,dataFinal,parceiro,valor,valorMinimo,calculoReal,calculoPorcentagem);
            cupom.Id = idCupom;

            return cupom;
        }
        private Dictionary<string, object> ObtemParametrosCupom(Cupom cupom)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", cupom.Id);
            parametros.Add("NOME", cupom.Nome);
            parametros.Add("DATAINICIO", cupom.DataInicio);
            parametros.Add("DATAFIM", cupom.DataFinal);
            parametros.Add("IDPARCEIRO", cupom.Parceiro.Id);
            parametros.Add("VALOR", cupom.Valor);
            parametros.Add("VALORMINIMO", cupom.ValorMinimo);
            parametros.Add("CALCULOREAL", cupom.CalculoReal);
            parametros.Add("CALCULOPORCENTAGEM", cupom.CalculoPorcentagem);

            return parametros;
        }
    }
}
