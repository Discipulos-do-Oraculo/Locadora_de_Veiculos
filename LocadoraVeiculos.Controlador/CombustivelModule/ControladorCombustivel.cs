using LocadoraVeiculo.Dominio.CombustivelModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Controlador.GasolinaModule
{
    public class ControladorCombustivel : Controlador<Combustivel>
    {
        #region Querries

        private const string sqlInserirCombustivel = @"INSERT INTO TBCombustivel
        (
         [NOME],
         [VALOR])
        
         VALUES
        
        (@NOME,
         @VALOR
        )";

        private const string sqlEditarCombustivel =
            @"UPDATE TBCombustivel
                    SET
                        [NOME] = @NOME,
		                [VALOR] = @VALOR
                    WHERE 
                        ID = @ID";

        private const string sqlSelecionarTodosOsCombustiveis = @"SELECT * FROM TBCombustivel ";

        private const string sqlSelecionarCombustivelPorId = @" SELECT * FROM TBCombustivel WHERE ID = @ID";

        private const string sqlExisteCombustivel =

           @"SELECT 
                COUNT(*) 
            FROM 
                [TBCombustivel]
            WHERE 
                [ID] = @ID";


        #endregion

        public override string Editar(int id, Combustivel registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarCombustivel, ObtemParametrosCombustivel(registro));
            }

            return resultadoValidacao;
        }


        public override bool Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Existe(int id)
        {
            return Db.Exists(sqlExisteCombustivel, AdicionarParametro("ID", id));
        }

        public override string InserirNovo(Combustivel registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = Db.Insert(sqlInserirCombustivel, ObtemParametrosCombustivel(registro));
            }

            return resultadoValidacao;
        }

        public override Combustivel SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarCombustivelPorId, ConverterEmCombustivel, AdicionarParametro("ID", id));
        }

        public override List<Combustivel> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodosOsCombustiveis, ConverterEmCombustivel);
        }

        private Dictionary<string, object> ObtemParametrosCombustivel(Combustivel combustivel)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", combustivel.Id);
            parametros.Add("NOME", combustivel.Nome);
            parametros.Add("VALOR", combustivel.Valor);

            return parametros;
        }



        private Combustivel ConverterEmCombustivel(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string nome = Convert.ToString(reader["NOME"]);
            double valor = Convert.ToDouble(reader["VALOR"]);


            Combustivel combustivel = new Combustivel(nome, valor);

            combustivel.Id = id;

            return combustivel;
        }
    }
}

