using LocadoraVeiculo.Dominio.LocacaoModule;
using LocadoraVeiculo.Dominio.TaxasEServicosModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Controlador.LocacaoModule
{
    public class ControladorLocacaoTaxasEServicos : Controlador<LocacaoTaxasEServicos>
    {

        #region Queries

        private const string sqlInserirTaxaServico =
            @"INSERT INTO TBLOCACAO_TBTAXASESERVICOS
              (
               
               [TBLOCACAO_TBTAXASESERVICOS].IDTAXASERVICO,
               [TBLOCACAO_TBTAXASESERVICOS].IDLOCACAO
            )
               VALUES

              (@IDTAXASERVICO,
               @IDLOCACAO) ";

        private const string sqlSelecionarTaxasEServicosPorLocacao =
            @"SELECT 

            [TBTAXASESERVICOS].ID AS IDTAXASERVICO,
            [TBTAXASESERVICOS].NOME,
            [TBTAXASESERVICOS].VALOR,
            [TBTAXASESERVICOS].CALCULODIARIO,
            [TBTAXASESERVICOS].CALCULOFIXO

            FROM TBLOCACAO_TBTAXASESERVICOS 

            INNER JOIN [TBTAXASESERVICOS] ON 
            [TBLOCACAO_TBTAXASESERVICOS].IDTAXASERVICO = [TBTAXASESERVICOS].ID
            
            WHERE 
           [TBLOCACAO_TBTAXASESERVICOS].IDLOCACAO = @IDLOCACAO ";

        #endregion

        public override string Editar(int id, LocacaoTaxasEServicos registro)
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

        public override string InserirNovo(LocacaoTaxasEServicos registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = Db.Insert(sqlInserirTaxaServico, ObtemParametrosLocacaoTaxasServicos(registro));
            }

            return resultadoValidacao;
        }

        public override LocacaoTaxasEServicos SelecionarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public override List<LocacaoTaxasEServicos> SelecionarTodos()
        {
            throw new NotImplementedException();
        }

        public List <TaxasEServicos> SelecionarPorLocacao(int id)
        {
            return Db.GetAll(sqlSelecionarTaxasEServicosPorLocacao, ConverterEmLocacaoTaxasServicos, AdicionarParametro("IDLOCACAO", id));
        }

        private Dictionary<string, object> ObtemParametrosLocacaoTaxasServicos(LocacaoTaxasEServicos locacaoTaxasServicos)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", locacaoTaxasServicos.Id);
            parametros.Add("IDLOCACAO", locacaoTaxasServicos.Locacao.Id);
            parametros.Add("IDTAXASERVICO", locacaoTaxasServicos.TaxasEServicos.Id);

            return parametros;
        }

        private TaxasEServicos ConverterEmLocacaoTaxasServicos(IDataReader reader)
        {
            TaxasEServicos taxasEServicos = null;
            if(reader["IDTAXASERVICO"] != DBNull.Value)
            {
                var idTaxaServico = Convert.ToInt32(reader["IDTAXASERVICO"]);
                var nome = Convert.ToString(reader["NOME"]);
                var valor = Convert.ToDouble(reader["VALOR"]);
                var calculoDiario = Convert.ToBoolean(reader["CALCULODIARIO"]);
                var calculoFixo = Convert.ToBoolean(reader["CALCULOFIXO"]);
                taxasEServicos = new TaxasEServicos(nome, valor, calculoDiario, calculoFixo);
                taxasEServicos.Id = Convert.ToInt32(reader["IDTAXASERVICO"]);
            }

            return taxasEServicos;
        }
    }
}
