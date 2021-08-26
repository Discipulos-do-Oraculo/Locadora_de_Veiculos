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
                    [DATAFINAL],           
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
                    @DATAFINAL,
                    @IDPARCEIRO,
                    @VALOR,
                    @VALORMINIMO,
                    @CALCULOPORCENTAGEM
                )";

        private const string sqlEditarCupom =
            @" UPDATE [TBCUPOM]
                SET 
                    [NOME] = @NOME,        
                    [DATAINICIO] = @DATAINICIO,            
                    [DATAFINAL] = @DATAFINAL,           
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
                    [TBC.ID], 
                    [TBC.NOME] AS NOMECUPOM,        
                    [TBC.DATAINICIO],            
                    [TBC.DATAFINAL],           
                    [TBC.IDPARCEIRO],     
                    [TBC.VALOR],   
                    [TBC.VALORMINIMO],            
                    [TBC.CALCULOREAL],         
                    [TBC.CALCULOPORCENTAGEM],

                    [TBP.NOME] AS NOMEPARCEIRO,
                    [TBP.IDMIDIA],

                    [TBM.NOME] AS NOMEMIDIA
            FROM
                    [TBCUPOM] as TBC INNER JOIN
                    [TBPARCEIRO] as TBP
            ON
                    [TBC.IDPARCEIRO] = [TBP.ID]
                    INNER JOIN [TBMIDIA] AS TBM
            ON
                    [TBP.IDMIDIA] = [TBM.ID]";

        private const string sqlSelecionarCupomPorId =
            @"SELECT 
                    [TBC.ID], 
                    [TBC.NOME] AS NOMECUPOM,        
                    [TBC.DATAINICIO],            
                    [TBC.DATAFINAL],           
                    [TBC.IDPARCEIRO],     
                    [TBC.VALOR],   
                    [TBC.VALORMINIMO],            
                    [TBC.CALCULOREAL],         
                    [TBC.CALCULOPORCENTAGEM],

                    [TBP.NOME] AS NOMEPARCEIRO,
                    [TBP.IDMIDIA],

                    [TBM.NOME] AS NOMEMIDIA
            FROM
                    [TBCUPOM] as TBC INNER JOIN
                    [TBPARCEIRO] as TBP
            ON
                    [TBC.IDPARCEIRO] = [TBP.ID]
                    INNER JOIN [TBMIDIA] AS TBM
            ON
                    [TBP.IDMIDIA] = [TBM.ID]
            WHERE 
                    [TBC.ID] = @ID";


        private const string sqlExisteCupom =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBCUPOM]
            WHERE 
                [ID] = @ID";

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
        private Cupom ConverterEmCupom(IDataReader reader)
        {
                    
            var nomeCupom = Convert.ToString(reader["NOMECUPOM"]);
            var dataInicio = Convert.ToDateTime(reader["DATAINICIO"]);
            var dataFinal = Convert.ToDateTime(reader["DATAFINAL"]);
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
            parametros.Add("DATAFINAL", cupom.DataFinal);
            parametros.Add("IDPARCEIRO", cupom.Parceiro.Id);
            parametros.Add("VALOR", cupom.Valor);
            parametros.Add("VALORMINIMO", cupom.ValorMinimo);
            parametros.Add("CALCULOREAL", cupom.CalculoReal);
            parametros.Add("CALCULOPORCENTAGEM", cupom.CalculoPorcentagem);

            return parametros;
        }
    }
}
