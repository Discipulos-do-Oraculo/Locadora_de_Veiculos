using LocadoraVeiculo.Dominio.DevolucaoModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Controlador.DevolucaoModule
{
    public class ControladorDevolucao : Controlador<Devolucao>
    {
        #region Queries

        private const string sqlInserirDevolucao = @"
                INSERT INTO [TBDEVOLUCAO]
                (
                    [IDLOCACAO],
                    [IDCOMBUSTIVEL],
                    [IDTAXASESERVICOS],
                    [DATARETORNO],
                    [KMFINAL],
                    [LITROSTANQUE]

                )
                VALUES
                (
                    @IDLOCACAO,
                    @IDCOMBUSTIVEL,
                    @IDTAXASESERVICOS,
                    @DATARETORNO,
                    @KMFINAL,
                    @LITROSTANQUE

                )";

        private const string sqlEditarLocacao = @"UPDATE [TBLOCACAO]
                SET 
                    [IDCLIENTEPJ] = @IDCLIENTEPJ,
                    [IDCONDUTOR] = @IDCONDUTOR,
                    [IDVEICULO] = @IDVEICULO,
                    [PLANO] = @PLANO,
                    [VALORTOTAL] = @VALORTOTAL,
                    [VALORCAUCAO] = @VALORCAUCAO,
                    [DATASAIDA] = @DATASAIDA,
                    [DATARETORNO] = @DATARETORNO,
                    [KMINICIAL] = @KMINICIAL,
                    [KMFINAL] = @KMFINAL

                WHERE [ID] = @ID";

        private const string sqlSelecionarLocacoes = @"  SELECT 
                    [TBLOCACAO].ID AS ID,
                    [TBCLIENTEPJ].NOME AS NOMECLIENTE,
                    [TBCLIENTEPJ].ID AS IDCLIENTEPJ,
                    [TBCLIENTEPJ].ENDERECO AS ENDERECOCLIENTE,
                    [TBCLIENTEPJ].EMAIL AS EMAILCLIENTE,
                    [TBCLIENTEPJ].CIDADE AS CIDADECLIENTE,
                    [TBCLIENTEPJ].ESTADO AS ESTADOCLIENTE,
                    [TBCLIENTEPJ].TELEFONE AS TELEFONECLIENTE,
                    [TBCLIENTEPJ].CELULAR AS CELULARCLIENTE,
                    [TBCLIENTEPJ].CNPJ AS CNPJ,


                    TBCONDUTOR.NOMECONDUTOR AS NOMECONDUTOR,
                    [TBLOCACAO].IDCONDUTOR AS IDCONDUTOR,
                    TBCONDUTOR.ENDERECO AS ENDERECOCONDUTOR,
                    TBCONDUTOR.EMAIL AS EMAILCONDUTOR,
                    TBCONDUTOR.CIDADE AS CIDADECONDUTOR,
                    TBCONDUTOR.ESTADO AS ESTADOCONDUTOR,
                    TBCONDUTOR.TELEFONE AS TELEFONECONDUTOR,
                    TBCONDUTOR.CELULAR AS CELULARCONDUTOR,
                    TBCONDUTOR.RG AS RGCONDUTOR,
                    TBCONDUTOR.CPF AS CPFCONDUTOR,
                    TBCONDUTOR.CNH AS CNHCONDUTOR,
                    TBCONDUTOR.VALIDADECNH AS VALIDADECNHCONDUTOR,
                    TBCONDUTOR.IDCLIENTECNPJ AS IDCLIENTECNPJ,

                    [TBVEICULOS].VEICULO AS VEICULO, 
                    [TBVEICULOS].ID AS IDVEICULO,
                    [TBVEICULOS].COR AS CORVEICULO,
                    [TBVEICULOS].KMATUAL AS KMATUALVEICULO,
                    [TBVEICULOS].PORTAMALAS AS PORTAMALASVEICULO,
                    [TBVEICULOS].NUMEROPORTAS AS NUMEROPORTASVEICULO,
                    [TBVEICULOS].ANO AS ANOVEICULO,
                    [TBVEICULOS].CHASSI AS CHASSIVEICULO,
                    [TBVEICULOS].MARCA AS MARCAVEICULO,
                    [TBVEICULOS].LITROSTANQUE AS LITROSTANQUEVEICULO,
                    [TBVEICULOS].PLACA AS PLACAVEICULO,
                    [TBVEICULOS].CAPACIDADE AS CAPACIDADEVEICULO,
                    [TBVEICULOS].GRUPO AS GRUPOVEICULO,
                    [TBVEICULOS].IMAGEM AS IMAGEMVEICULO,

                    [TBGRUPODEVEICULOS].NOME AS NOMEGRUPOVEICULO,
                    [TBGRUPODEVEICULOS].VALORDIARIA AS VALORDIARIA,
                    [TBGRUPODEVEICULOS].VALORKMCONTROLADO AS VALORKMCONTROLADO,
                    [TBGRUPODEVEICULOS].VALORKMDIARIA AS VALORKMDIARIA,
                    [TBGRUPODEVEICULOS].VALORKMLIVRE AS VALORKMLIVRE,
                    [TBGRUPODEVEICULOS].LIMITEKMCONTROLADO AS LIMITEKMCONTROLADO,

 
                    [PLANO],
                    [VALORTOTAL],
                    [VALORCAUCAO],
                    [DATASAIDA],
                    [DATARETORNO],
                    [KMINICIAL]

            FROM
                    [TBLOCACAO]  INNER JOIN [TBVEICULOS]
            ON      [TBLOCACAO].IDVEICULO = [TBVEICULOS].ID
                    
                    INNER JOIN  [TBGRUPODEVEICULOS]
            ON      [TBVEICULOS].GRUPO = [TBGRUPODEVEICULOS].ID
             
                    INNER JOIN  [TBCONDUTOR]
            ON      [TBLOCACAO].IDCONDUTOR = [TBCONDUTOR].ID

                    LEFT JOIN  [TBCLIENTEPJ]
            ON      [TBLOCACAO].IDCLIENTEPJ = [TBCLIENTEPJ].ID";



        private const string sqlSelecionarLocacaoPorId = @" SELECT 
                    [TBLOCACAO].ID AS ID,
                    [TBCLIENTEPJ].NOME AS NOMECLIENTE,
                    [TBCLIENTEPJ].ID AS IDCLIENTEPJ,
                    [TBCLIENTEPJ].ENDERECO AS ENDERECOCLIENTE,
                    [TBCLIENTEPJ].EMAIL AS EMAILCLIENTE,
                    [TBCLIENTEPJ].CIDADE AS CIDADECLIENTE,
                    [TBCLIENTEPJ].ESTADO AS ESTADOCLIENTE,
                    [TBCLIENTEPJ].TELEFONE AS TELEFONECLIENTE,
                    [TBCLIENTEPJ].CELULAR AS CELULARCLIENTE,
                    [TBCLIENTEPJ].CNPJ AS CNPJ,


                    TBCONDUTOR.NOMECONDUTOR AS NOMECONDUTOR,
                    [TBLOCACAO].IDCONDUTOR AS IDCONDUTOR,
                    TBCONDUTOR.ENDERECO AS ENDERECOCONDUTOR,
                    TBCONDUTOR.EMAIL AS EMAILCONDUTOR,
                    TBCONDUTOR.CIDADE AS CIDADECONDUTOR,
                    TBCONDUTOR.ESTADO AS ESTADOCONDUTOR,
                    TBCONDUTOR.TELEFONE AS TELEFONECONDUTOR,
                    TBCONDUTOR.CELULAR AS CELULARCONDUTOR,
                    TBCONDUTOR.RG AS RGCONDUTOR,
                    TBCONDUTOR.CPF AS CPFCONDUTOR,
                    TBCONDUTOR.CNH AS CNHCONDUTOR,
                    TBCONDUTOR.VALIDADECNH AS VALIDADECNHCONDUTOR,
                    TBCONDUTOR.IDCLIENTECNPJ AS IDCLIENTECNPJ,

                    [TBVEICULOS].VEICULO AS VEICULO, 
                    [TBVEICULOS].ID AS IDVEICULO,
                    [TBVEICULOS].COR AS CORVEICULO,
                    [TBVEICULOS].KMATUAL AS KMATUALVEICULO,
                    [TBVEICULOS].PORTAMALAS AS PORTAMALASVEICULO,
                    [TBVEICULOS].NUMEROPORTAS AS NUMEROPORTASVEICULO,
                    [TBVEICULOS].ANO AS ANOVEICULO,
                    [TBVEICULOS].CHASSI AS CHASSIVEICULO,
                    [TBVEICULOS].MARCA AS MARCAVEICULO,
                    [TBVEICULOS].LITROSTANQUE AS LITROSTANQUEVEICULO,
                    [TBVEICULOS].PLACA AS PLACAVEICULO,
                    [TBVEICULOS].CAPACIDADE AS CAPACIDADEVEICULO,
                    [TBVEICULOS].GRUPO AS GRUPOVEICULO,
                    [TBVEICULOS].IMAGEM AS IMAGEMVEICULO,

                    [TBGRUPODEVEICULOS].NOME AS NOMEGRUPOVEICULO,
                    [TBGRUPODEVEICULOS].VALORDIARIA AS VALORDIARIA,
                    [TBGRUPODEVEICULOS].VALORKMCONTROLADO AS VALORKMCONTROLADO,
                    [TBGRUPODEVEICULOS].VALORKMDIARIA AS VALORKMDIARIA,
                    [TBGRUPODEVEICULOS].VALORKMLIVRE AS VALORKMLIVRE,
                    [TBGRUPODEVEICULOS].LIMITEKMCONTROLADO AS LIMITEKMCONTROLADO,

                    [PLANO],
                    [VALORTOTAL],
                    [VALORCAUCAO],
                    [DATASAIDA],
                    [DATARETORNO],
                    [KMINICIAL]

            FROM
                    [TBLOCACAO]  INNER JOIN [TBVEICULOS]
            ON      [TBLOCACAO].IDVEICULO = [TBVEICULOS].ID
                    
                    INNER JOIN  [TBGRUPODEVEICULOS]
            ON      [TBVEICULOS].GRUPO = [TBGRUPODEVEICULOS].ID
             
                    INNER JOIN  [TBCONDUTOR]
            ON      [TBLOCACAO].IDCONDUTOR = [TBCONDUTOR].ID

                    LEFT JOIN  [TBCLIENTEPJ]
            ON      [TBLOCACAO].IDCLIENTEPJ = [TBCLIENTEPJ].ID

             WHERE [TBLOCACAO].Id = @ID;";

        private const string sqlExisteLocacaoComVeiculoIgual =
           @"SELECT 
                COUNT(*) 
            FROM 
                [TBLOCACAO]
            WHERE 
                [IDVEICULO] = @IDVEICULO AND [ID] <> @ID";
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
            throw new NotImplementedException();
        }

        public override Devolucao SelecionarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Devolucao> SelecionarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
