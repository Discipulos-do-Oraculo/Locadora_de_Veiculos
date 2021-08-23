using LocadoraVeiculo.Dominio.LocacaoModule;
using LocadoraVeiculo.Dominio.TaxasEServicosModule;
using System;
using System.Collections.Generic;
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

        private Dictionary<string, object> ObtemParametrosLocacaoTaxasServicos(LocacaoTaxasEServicos locacaoTaxasServicos)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", locacaoTaxasServicos.Id);
            parametros.Add("IDLOCACAO", locacaoTaxasServicos.Locacao.Id);
            parametros.Add("IDTAXASERVICO", locacaoTaxasServicos.TaxasEServicos.Id);

            return parametros;
        }
    }
}
