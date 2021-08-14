using LocadoraVeiculo.Dominio.TaxasEServicosModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Controlador.TaxasEServicosModule
{
    public class ControladorTaxasEServicos : Controlador<TaxasEServicos>
    {
        #region Querries

        private const string sqlInserirTaxasEServicos = @"INSERT INTO TBTAXASESERVICOS
        (
         [NOME],
         [VALOR],
         [CALCULODIARIO],
         [CALCULOFIXO]   )
        
         VALUES
        
        (@NOME,
         @VALOR,
         @CALCULODIARIO,
         @CALCULOFIXO
        )";

        private const string sqlEditarTaxasEServicos =
            @"UPDATE TBTAXASESERVICOS
                    SET
                        [NOME] = @NOME,
		                [VALOR] = @VALOR,
                        [CALCULODIARIO] = @CALCULODIARIO,
                        [CALCULOFIXO] = @CALCULOFIXO
                    WHERE 
                        ID = @ID";

        private const string sqlSelecionarTodasTaxasEServicos = @"SELECT * FROM TBTAXASESERVICOS ";

        private const string sqlSelecionarTaxasEServicosPorId = @" SELECT * FROM TBTAXASESERVICOS WHERE ID = @ID";

        private const string sqlExisteTaxasEServicos =

           @"SELECT 
                COUNT(*) 
            FROM 
                [TBTAXASESERVICOS]
            WHERE 
                [ID] = @ID";

        #endregion

        public override string InserirNovo(TaxasEServicos registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = Db.Insert(sqlInserirTaxasEServicos, ObtemParametrosTaxasEServicos(registro));
            }

            return resultadoValidacao;
        }

        public override string Editar(int id, TaxasEServicos registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarTaxasEServicos, ObtemParametrosTaxasEServicos(registro));
            }

            return resultadoValidacao;
        }

        public override bool Existe(int id)
        {
            return Db.Exists(sqlExisteTaxasEServicos, AdicionarParametro("ID", id));
        }

        public override bool Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public override List<TaxasEServicos> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodasTaxasEServicos, ConverterEmTaxasEServicos);
        }

        public override TaxasEServicos SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarTaxasEServicosPorId, ConverterEmTaxasEServicos, AdicionarParametro("ID", id));
        }


        private Dictionary<string, object> ObtemParametrosTaxasEServicos(TaxasEServicos taxasEServicos)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", taxasEServicos.Id);
            parametros.Add("NOME", taxasEServicos.Nome);
            parametros.Add("VALOR", taxasEServicos.Valor);
            parametros.Add("CALCULODIARIO", taxasEServicos.CalculoDiario);
            parametros.Add("CALCULOFIXO", taxasEServicos.CalculoFixo);

            return parametros;
        }

        private TaxasEServicos ConverterEmTaxasEServicos(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string nome = Convert.ToString(reader["NOME"]);
            double valor = Convert.ToDouble(reader["VALOR"]);
            bool calculoDiario = Convert.ToBoolean(reader["CALCULODIARIO"]);
            bool calculoFixo = Convert.ToBoolean(reader["CALCULOFIXO"]);


            TaxasEServicos taxasEServicos = new TaxasEServicos(nome, valor,calculoDiario,calculoFixo);

            taxasEServicos.Id = id;

            return taxasEServicos;
        }
    }
}



