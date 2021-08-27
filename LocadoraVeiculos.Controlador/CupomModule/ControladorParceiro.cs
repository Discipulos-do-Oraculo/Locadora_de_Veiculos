using LocadoraVeiculo.Dominio.CupomModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Controlador.CupomModule
{
    public class ControladorParceiro : Controlador<Parceiro>
    {
        #region Queries
        private const string sqlInserirParceiro =
            @"INSERT INTO [TBPARCEIROS]
                (               
                    [NOME],        
                    [IDMIDIA]
                )
                VALUES
                (
                    @NOME,
                    @IDMIDIA
                )";

        private const string sqlEditarParceiro =
            @" UPDATE [TBPARCEIROS]
                SET 
                    [NOME] = @NOME,        
                    [IDMIDIA] = @IDMIDIA
                WHERE 
                    [ID] = @ID";

        private const string sqlExcluirParceiro =
            @"DELETE FROM [TBPARCEIROS] 
                WHERE 
                    [ID] = @ID";

        private const string sqlSelecionarTodosParceiro =
            @"SELECT 
                    [TBPARCEIROS].[ID], 
                    [TBPARCEIROS].[NOME],   
                    [TBPARCEIROS].[IDMIDIA],

                    [TBMIDIA].NOME AS NOMEMIDIA
            FROM
                    [TBPARCEIROS] 
                    INNER JOIN [TBMIDIA]
            ON
                    [TBPARCEIROS].[IDMIDIA] = [TBMIDIA].ID";

        private const string sqlSelecionarParceiroPorId =
            @"
                SELECT 
                    [TBPARCEIROS].[ID], 
                    [TBPARCEIROS].[NOME],   
                    [TBPARCEIROS].[IDMIDIA],

                    [TBMIDIA].NOME AS NOMEMIDIA
            FROM
                    [TBPARCEIROS] 
                    INNER JOIN [TBMIDIA] 
            ON
                    [TBPARCEIROS].[IDMIDIA] = [TBMIDIA].ID
          
            WHERE 
                    [TBPARCEIROS].[ID] = @ID";

        private const string sqlExisteParceiro =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBPARCEIROS]
            WHERE 
                [ID] = @ID";

        private const string sqlExisteParceiroComMesmoNome =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBPARCEIROS]
            WHERE 
                [NOME] = @NOME AND [ID] <> @ID";

        #endregion
        public override string Editar(int id, Parceiro registro)
        {
            bool verificaNome = VerificaNome(registro.Nome, registro.Id);
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                if (verificaNome)
                    resultadoValidacao = "Este parceiro já está cadastrado";

                else
                {
                    registro.Id = id;
                    Db.Update(sqlEditarParceiro, ObtemParametrosParceiro(registro));
                }

            }

            return resultadoValidacao;
        }

        public override bool Excluir(int id)
        {
            try
            {
                Db.Delete(sqlExcluirParceiro, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public override bool Existe(int id)
        {
            return Db.Exists(sqlExisteParceiro, AdicionarParametro("ID", id));
        }

        public override string InserirNovo(Parceiro registro)
        {
            bool verificaNome = VerificaNome(registro.Nome, registro.Id);
            
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                if (verificaNome)
                    resultadoValidacao = "Este parceiro já está cadastrado";

                else
                    registro.Id = Db.Insert(sqlInserirParceiro, ObtemParametrosParceiro(registro));
            }

            return resultadoValidacao;
        }

        public override Parceiro SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarParceiroPorId, ConverterEmParceiro, AdicionarParametro("ID", id));
        }

        public override List<Parceiro> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodosParceiro, ConverterEmParceiro);
        }

        public bool VerificaNome(string nome, int id)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", id);
            parametros.Add("NOME", nome);

            return Db.Exists(sqlExisteParceiroComMesmoNome, parametros);
        }

        private Parceiro ConverterEmParceiro(IDataReader reader)
        {

            var nomeParceiro = Convert.ToString(reader["NOME"]);
            var idMidia = Convert.ToInt32(reader["IDMIDIA"]);
            var idParceiro = Convert.ToInt32(reader["ID"]);
            var nomeMidia = Convert.ToString(reader["NOMEMIDIA"]);
            Midia meioComunicao = new Midia(nomeMidia);
            meioComunicao.Id = idMidia;

            Parceiro parceiro = new Parceiro(nomeParceiro, meioComunicao);
            parceiro.Id = idParceiro;

            return parceiro;
        }
        private Dictionary<string, object> ObtemParametrosParceiro(Parceiro parceiro)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", parceiro.Id);
            parametros.Add("NOME", parceiro.Nome);
            parametros.Add("IDMIDIA", parceiro.MeioComunicao.Id);

            return parametros;
        }
    }
}
