using LocadoraVeiculo.Dominio.DevolucaoModule;
using LocadoraVeiculos.Controlador.GasolinaModule;
using LocadoraVeiculos.Controlador.LocacaoModule;
using LocadoraVeiculos.Controlador.TaxasEServicosModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Controlador.DevolucaoModule
{
    public class ControladorDevolucao : Controlador<Devolucao>
    {
        private readonly ControladorLocacao controladorLocacao = new ControladorLocacao();
        private readonly ControladorCombustivel controladorCombustivel = new ControladorCombustivel();

        #region Queries

        private const string sqlInserirDevolucao = @"
                INSERT INTO [TBDEVOLUCAO]
                (
                    [IDLOCACAO],
                    [IDCOMBUSTIVEL],
                    [DATARETORNO],
                    [KMFINAL],
                    [LITROSTANQUE],
                    [VALORTOTAL]

                )
                VALUES
                (
                    @IDLOCACAO,
                    @IDCOMBUSTIVEL,
                    @DATARETORNO,
                    @KMFINAL,
                    @LITROSTANQUE,
                    @VALORTOTAL

                )";

        private const string sqlEditarDevolucao = @"SELECT
                    ID,
                    [IDLOCACAO] = @IDLOCACAO,
                    [IDCOMBUSTIVEL] = @IDCOMBUSTIVEL,
                    [DATARETORNO] = @DATARETORNO,
                    [KMFINAL] = @KMFINAL,
                    [LITROSTANQUE] = @LITROSTANQUE,
                    [VALORTOTAL] = @VALORTOTAL

                FROM [TBDEVOLUCAO]
                WHERE ID = @ID";



        private const string sqlSelecionarDevolucaoPorId = @" SELECT 
                    ID,                    
                    [IDLOCACAO],
                    [IDCOMBUSTIVEL],
                    [DATARETORNO],
                    [KMFINAL],
                    [LITROSTANQUE],
                    [VALORTOTAL]

             FROM [TBDEVOLUCAO]  

             WHERE [TBDEVOLUCAO].ID = @ID;";

        private const string sqlSelecionarTodasDevolucoes = @" SELECT * FROM [TBDEVOLUCAO]";
        #endregion

        public override string Editar(int id, Devolucao registro)
        {
            throw new NotImplementedException();
        }

        public override bool Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Existe(int id)
        {
            throw new NotImplementedException();
        }

        public override string InserirNovo(Devolucao registro)
        {
            string resultadoValidacao = registro.Validar();
            if (resultadoValidacao == "ESTA_VALIDO")
                 registro.Id = Db.Insert(sqlInserirDevolucao, ObtemParametrosDevolucao(registro));
               
            return resultadoValidacao;
        }

        private Dictionary<string, object> ObtemParametrosDevolucao(Devolucao devolucao)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("IDLOCACAO", devolucao.Locacao);
            parametros.Add("IDCOMBUSTIVEL", devolucao.TipoCombustivel);
            parametros.Add("KMFINAL", devolucao.KmFinal);
            parametros.Add("DATARETORNO", devolucao.DataRetorno);
            parametros.Add("LITROSTANQUE", devolucao.LitrosGastos);
            parametros.Add("VALORTOTAL", devolucao.ValorTotal);

            return parametros;
        }

        public override Devolucao SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarDevolucaoPorId, ConverterEmDevolucao, AdicionarParametro("ID", id));
        }

        private Devolucao ConverterEmDevolucao(IDataReader reader)
        {
            var idLocacao = Convert.ToInt32(reader["IDLOCACAO"]);
            var idCombustivel = Convert.ToInt32(reader["IDCOMBUSTIVEL"]);
            var dataRetorno = Convert.ToDateTime(reader["DATARETORNO"]);
            var kmFinal = Convert.ToInt32(reader["KMFINAL"]);
            var litrosTanque = Convert.ToDouble(reader["LITROSTANQUE"]);
            var valorTotal = Convert.ToDouble(reader["VALORTOTAL"]);

            var locacao = controladorLocacao.SelecionarPorId(idLocacao);
            var tipoCombustivel = controladorCombustivel.SelecionarPorId(idCombustivel);

            Devolucao devolucao = new Devolucao(locacao, tipoCombustivel, dataRetorno, kmFinal, litrosTanque, valorTotal);
            devolucao.Id = Convert.ToInt32(reader["ID"]);

            return devolucao;
        }

        public override List<Devolucao> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodasDevolucoes, ConverterEmDevolucao);
        }
    }
}
