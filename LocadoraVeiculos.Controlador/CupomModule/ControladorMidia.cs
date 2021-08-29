using LocadoraVeiculo.Dominio.CupomModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Controlador.CupomModule
{
    public class ControladorMidia : Controlador<Midia>
    {

        #region Queries
        private const string sqlInserirMidia =
            @"INSERT INTO [TBMIDIA]
                (               
                    [NOME]
                )
                VALUES
                (
                    @NOME
                )";

        private const string sqlEditarMidia =
            @" UPDATE [TBMIDIA]
                SET 
                    [NOME] = @NOME
                WHERE 
                    [ID] = @ID";

        private const string sqlExcluirMidia =
            @"DELETE FROM [TBMIDIA] 
                WHERE 
                    [ID] = @ID";

        private const string sqlSelecionarTodasMidias =
            @"SELECT 
                    [ID], 
                    [NOME]
            FROM
                    [TBMIDIA]";

        private const string sqlSelecionarMidiaPorId =
            @"SELECT 
                    [ID], 
                    [NOME]
            FROM
                    [TBMIDIA] 
            WHERE 
                    [ID] = @ID";

        private const string sqlExisteMidia =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBMIDIA]
            WHERE 
                [ID] = @ID";

        #endregion
        public override string Editar(int id, Midia registro)
        {
            string resultadoValidacao = registro.Validar();
            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarMidia, ObtemParametrosMidia(registro));

            }

            return resultadoValidacao;
        }

        public override bool Excluir(int id)
        {
            try
            {
                Db.Delete(sqlExcluirMidia, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public override bool Existe(int id)
        {
            return Db.Exists(sqlExisteMidia, AdicionarParametro("ID", id));
        }

        public override string InserirNovo(Midia registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = Db.Insert(sqlInserirMidia, ObtemParametrosMidia(registro));
            }

            return resultadoValidacao;
        }

        public override Midia SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarMidiaPorId, ConverterEmMidia, AdicionarParametro("ID", id));
        }

        public override List<Midia> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodasMidias, ConverterEmMidia);
        }
        private Midia ConverterEmMidia(IDataReader reader)
        {

            var nome = Convert.ToString(reader["NOME"]);
            var idMidia = Convert.ToInt32(reader["ID"]);
            
            Midia meioComunicao = new Midia(nome);
            meioComunicao.Id = idMidia;

            return meioComunicao;
        }
        private Dictionary<string, object> ObtemParametrosMidia(Midia midia)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", midia.Id);
            parametros.Add("NOME", midia.Nome);

            return parametros;
        }
    }
}
