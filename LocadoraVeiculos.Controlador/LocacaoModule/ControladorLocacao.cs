using LocadoraVeiculo.Dominio.ClienteModule;
using LocadoraVeiculo.Dominio.CupomModule;
using LocadoraVeiculo.Dominio.GrupoDeVeiculosModule;
using LocadoraVeiculo.Dominio.LocacaoModule;
using LocadoraVeiculo.Dominio.TaxasEServicosModule;
using LocadoraVeiculo.Dominio.VeiculoModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Controlador.LocacaoModule
{
    public class ControladorLocacao : Controlador<Locacao>
    {
        #region Queries

        private const string sqlInserirLocacao = @"INSERT INTO [TBLOCACAO]
                (
                    [IDCLIENTEPJ],
                    [IDCONDUTOR],
                    [IDVEICULO],
                    [PLANO],
                    [VALORTOTAL],
                    [VALORCAUCAO],
                    [DATASAIDA],
                    [DATARETORNO],
                    [KMINICIAL],
                    [IDCUPOM]

                )
                VALUES
                (
                    @IDCLIENTEPJ,
                    @IDCONDUTOR,
                    @IDVEICULO,
                    @PLANO,
                    @VALORTOTAL,
                    @VALORCAUCAO,
                    @DATASAIDA,
                    @DATARETORNO,
                    @KMINICIAL,
                    @IDCUPOM

                )";

        private const string sqlEditarLocacao = @"UPDATE [TBLOCACAO]
                SET 
                    [PLANO] = @PLANO,
                    [VALORTOTAL] = @VALORTOTAL,
                    [VALORCAUCAO] = @VALORCAUCAO
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
                    [TBGRUPODEVEICULOS].VALORDIARIAKMCONTROLADO AS VALORDIARIAKMCONTROLADO,

                    [TBCUPOM].ID AS IDCUPOM,
                    [TBCUPOM].NOME AS NOMECUPOM,
                    [TBCUPOM].CALCULOPORCENTAGEM,
                    [TBCUPOM].CALCULOREAL,
                    [TBCUPOM].DATAFIM,
                    [TBCUPOM].DATAINICIO,
                    [TBCUPOM].IDPARCEIRO,
                    [TBCUPOM].VALOR,
                    [TBCUPOM].VALORMINIMO,
                    
                    [TBPARCEIROS].NOME AS NOMEPARCEIRO,
                    [TBPARCEIROS].IDMIDIA,
                    [TBPARCEIROS].ID AS IDPARCEIRO,

 
                    [PLANO],
                    [TBLOCACAO].VALORTOTAL,
                    [VALORCAUCAO],
                    [DATASAIDA],
                    [TBLOCACAO].DATARETORNO,
                    [KMINICIAL]

            FROM
                    [TBLOCACAO]  INNER JOIN [TBVEICULOS]
            ON      [TBLOCACAO].IDVEICULO = [TBVEICULOS].ID
                    
                    INNER JOIN  [TBGRUPODEVEICULOS]
            ON      [TBVEICULOS].GRUPO = [TBGRUPODEVEICULOS].ID
             
                    INNER JOIN  [TBCONDUTOR]
            ON      [TBLOCACAO].IDCONDUTOR = [TBCONDUTOR].ID

                    LEFT JOIN  [TBCUPOM]
            ON      [TBLOCACAO].IDCUPOM = [TBCUPOM].ID

                    INNER JOIN  [TBPARCEIROS]
            ON      [TBCUPOM].IDPARCEIRO = [TBPARCEIROS].ID

                    LEFT JOIN  [TBCLIENTEPJ]
            ON      [TBLOCACAO].IDCLIENTEPJ = [TBCLIENTEPJ].ID

            ";


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
                    [TBGRUPODEVEICULOS].VALORDIARIAKMCONTROLADO AS VALORDIARIAKMCONTROLADO,

                    [TBCUPOM].ID AS IDCUPOM,
                    [TBCUPOM].NOME AS NOMECUPOM,
                    [TBCUPOM].CALCULOPORCENTAGEM,
                    [TBCUPOM].CALCULOREAL,
                    [TBCUPOM].DATAFIM,
                    [TBCUPOM].DATAINICIO,
                    [TBCUPOM].IDPARCEIRO,
                    [TBCUPOM].VALOR,
                    [TBCUPOM].VALORMINIMO,
                    
                    [TBPARCEIROS].NOME AS NOMEPARCEIRO,
                    [TBPARCEIROS].IDMIDIA,
                    [TBPARCEIROS].ID AS IDPARCEIRO,

 
                    [PLANO],
                    [TBLOCACAO].VALORTOTAL,
                    [VALORCAUCAO],
                    [DATASAIDA],
                    [TBLOCACAO].DATARETORNO,
                    [KMINICIAL]

            FROM
                    [TBLOCACAO]  INNER JOIN [TBVEICULOS]
            ON      [TBLOCACAO].IDVEICULO = [TBVEICULOS].ID
                    
                    INNER JOIN  [TBGRUPODEVEICULOS]
            ON      [TBVEICULOS].GRUPO = [TBGRUPODEVEICULOS].ID
             
                    INNER JOIN  [TBCONDUTOR]
            ON      [TBLOCACAO].IDCONDUTOR = [TBCONDUTOR].ID

                    LEFT JOIN  [TBCUPOM]
            ON      [TBLOCACAO].IDCUPOM = [TBCUPOM].ID

                    INNER JOIN  [TBPARCEIROS]
            ON      [TBCUPOM].IDPARCEIRO = [TBPARCEIROS].ID

                    LEFT JOIN  [TBCLIENTEPJ]
            ON      [TBLOCACAO].IDCLIENTEPJ = [TBCLIENTEPJ].ID

             WHERE [TBLOCACAO].Id = @ID;";

        private const string sqlSelecionarLocacoesAbertas = @" SELECT 
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
                    [TBGRUPODEVEICULOS].VALORDIARIAKMCONTROLADO AS VALORDIARIAKMCONTROLADO,

                    [TBCUPOM].ID AS IDCUPOM,
                    [TBCUPOM].NOME AS NOMECUPOM,
                    [TBCUPOM].CALCULOPORCENTAGEM,
                    [TBCUPOM].CALCULOREAL,
                    [TBCUPOM].DATAFIM,
                    [TBCUPOM].DATAINICIO,
                    [TBCUPOM].IDPARCEIRO,
                    [TBCUPOM].VALOR,
                    [TBCUPOM].VALORMINIMO,
                    
                    [TBPARCEIROS].NOME AS NOMEPARCEIRO,
                    [TBPARCEIROS].IDMIDIA,
                    [TBPARCEIROS].ID AS IDPARCEIRO,

 
                    [PLANO],
                    [TBLOCACAO].VALORTOTAL,
                    [VALORCAUCAO],
                    [DATASAIDA],
                    [TBLOCACAO].DATARETORNO,
                    [KMINICIAL]

            FROM
                    [TBLOCACAO]  INNER JOIN [TBVEICULOS]
            ON      [TBLOCACAO].IDVEICULO = [TBVEICULOS].ID
                    
                    INNER JOIN  [TBGRUPODEVEICULOS]
            ON      [TBVEICULOS].GRUPO = [TBGRUPODEVEICULOS].ID
             
                    INNER JOIN  [TBCONDUTOR]
            ON      [TBLOCACAO].IDCONDUTOR = [TBCONDUTOR].ID

                    LEFT JOIN  [TBCUPOM]
            ON      [TBLOCACAO].IDCUPOM = [TBCUPOM].ID

                    INNER JOIN  [TBPARCEIROS]
            ON      [TBCUPOM].IDPARCEIRO = [TBPARCEIROS].ID

                    LEFT JOIN  [TBCLIENTEPJ]
            ON      [TBLOCACAO].IDCLIENTEPJ = [TBCLIENTEPJ].ID

            LEFT JOIN  TBDEVOLUCAO ON TBDEVOLUCAO.IDLOCACAO  = TBLOCACAO.ID 

            WHERE TBDEVOLUCAO.IDLOCACAO IS NULL";

        private const string selecionarLocacoesPendentes = @"  SELECT 
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
                    [TBGRUPODEVEICULOS].VALORDIARIAKMCONTROLADO AS VALORDIARIAKMCONTROLADO,

                    [TBCUPOM].ID AS IDCUPOM,
                    [TBCUPOM].NOME AS NOMECUPOM,
                    [TBCUPOM].CALCULOPORCENTAGEM,
                    [TBCUPOM].CALCULOREAL,
                    [TBCUPOM].DATAFIM,
                    [TBCUPOM].DATAINICIO,
                    [TBCUPOM].IDPARCEIRO,
                    [TBCUPOM].VALOR,
                    [TBCUPOM].VALORMINIMO,
                    
                    [TBPARCEIROS].NOME AS NOMEPARCEIRO,
                    [TBPARCEIROS].IDMIDIA,
                    [TBPARCEIROS].ID AS IDPARCEIRO,

 
                    [PLANO],
                    [TBLOCACAO].VALORTOTAL,
                    [VALORCAUCAO],
                    [DATASAIDA],
                    [TBLOCACAO].DATARETORNO,
                    [KMINICIAL]

            FROM
                    [TBLOCACAO]  INNER JOIN [TBVEICULOS]
            ON      [TBLOCACAO].IDVEICULO = [TBVEICULOS].ID
                    
                    INNER JOIN  [TBGRUPODEVEICULOS]
            ON      [TBVEICULOS].GRUPO = [TBGRUPODEVEICULOS].ID
             
                    INNER JOIN  [TBCONDUTOR]
            ON      [TBLOCACAO].IDCONDUTOR = [TBCONDUTOR].ID

                    LEFT JOIN  [TBCUPOM]
            ON      [TBLOCACAO].IDCUPOM = [TBCUPOM].ID

                    INNER JOIN  [TBPARCEIROS]
            ON      [TBCUPOM].IDPARCEIRO = [TBPARCEIROS].ID

                    LEFT JOIN  [TBCLIENTEPJ]
            ON      [TBLOCACAO].IDCLIENTEPJ = [TBCLIENTEPJ].ID

            LEFT JOIN  TBDEVOLUCAO ON TBDEVOLUCAO.IDLOCACAO  = TBLOCACAO.ID 

            WHERE TBDEVOLUCAO.IDLOCACAO IS NULL AND [TBLOCACAO].DATARETORNO < GETDATE()";

        private const string sqlExisteLocacaoComVeiculoIgual =
           @"SELECT 
                COUNT(*) 
            FROM 
                [TBLOCACAO] LEFT JOIN [TBDEVOLUCAO] ON [TBLOCACAO].ID = [TBDEVOLUCAO].IDLOCACAO
            WHERE 
                IDVEICULO = @IDVEICULO AND [TBLOCACAO].ID <> @ID AND [TBDEVOLUCAO].IDLOCACAO IS NULL  
 ;";
        #endregion

        public override string Editar(int id, Locacao registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarLocacao, ObtemParametrosLocacao(registro));
            }

            return resultadoValidacao;
        }

        public override bool Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Existe(int id)
        {
            throw new NotImplementedException();
        }

        public override string InserirNovo(Locacao registro)
        {
            string resultadoValidacao = registro.Validar();
            bool existeVeiculoLocado = VerificaVeiculoLocado(registro.Veiculo.Id,registro.Id);
            if (resultadoValidacao == "ESTA_VALIDO")
            {
                if (existeVeiculoLocado) { }
                else
                {
                    registro.Id = Db.Insert(sqlInserirLocacao, ObtemParametrosLocacao(registro));
                }
            }

            return resultadoValidacao;
        }

        public override Locacao SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarLocacaoPorId, ConverterEmLocacao, AdicionarParametro("ID", id));
        }

        public override List<Locacao> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarLocacoes, ConverterEmLocacao);
        }

        public  List<Locacao> SelecionarLocacoesAbertas()
        {
            return Db.GetAll(sqlSelecionarLocacoesAbertas, ConverterEmLocacao);
        }

        public  List<Locacao> SelecionarTodosPendentes()
        {
            return Db.GetAll(selecionarLocacoesPendentes, ConverterEmLocacao);
        }

        private Locacao ConverterEmLocacao(IDataReader reader)
        {
            var nomeCliente = Convert.ToString(reader["NOMECLIENTE"]);
            var telefoneCliente = Convert.ToString(reader["TELEFONECLIENTE"]);
            var emailCliente = Convert.ToString(reader["EMAILCLIENTE"]);
            var cidadeCliente = Convert.ToString(reader["CIDADECLIENTE"]);
            var enderecoCliente = Convert.ToString(reader["ENDERECOCLIENTE"]);
            var celularCliente = Convert.ToString(reader["CELULARCLIENTE"]);
            var estadoCliente = Convert.ToString(reader["ESTADOCLIENTE"]);
            var cnpj = Convert.ToString(reader["CNPJ"]);

            var nomeCondutor = Convert.ToString(reader["NOMECONDUTOR"]);
            var telefoneCondutor = Convert.ToString(reader["TELEFONECONDUTOR"]);
            var emailCondutor = Convert.ToString(reader["EMAILCONDUTOR"]);
            var cidadeCondutor = Convert.ToString(reader["CIDADECONDUTOR"]);
            var enderecoCondutor = Convert.ToString(reader["ENDERECOCONDUTOR"]);
            var celularCondutor = Convert.ToString(reader["CELULARCONDUTOR"]);
            var estadoCondutor = Convert.ToString(reader["ESTADOCONDUTOR"]);
            var cpfCondutor = Convert.ToString(reader["CPFCONDUTOR"]);
            var rgCondutor = Convert.ToString(reader["RGCONDUTOR"]);
            var cnhCondutor = Convert.ToString(reader["CNHCONDUTOR"]);
            var validadeCnhCondutor = Convert.ToDateTime(reader["VALIDADECNHCONDUTOR"]);

            var nomeVeiculo = Convert.ToString(reader["VEICULO"]);
            var corVeiculo = Convert.ToString(reader["CORVEICULO"]);
            var kmAtual = Convert.ToInt32(reader["KMATUALVEICULO"]);
            var portaMalas = Convert.ToInt32((reader["PORTAMALASVEICULO"]));
            var numeroPortas = Convert.ToInt32(reader["NUMEROPORTASVEICULO"]);
            var ano = Convert.ToInt32(reader["ANOVEICULO"]);
            var chassi = Convert.ToString(reader["CHASSIVEICULO"]);
            var marca = Convert.ToString(reader["MARCAVEICULO"]);
            var litrosTanque = Convert.ToInt32(reader["LITROSTANQUEVEICULO"]);
            var placa = Convert.ToString(reader["PLACAVEICULO"]);
            var capacidade = Convert.ToInt32(reader["CAPACIDADEVEICULO"]);
            var imagem = (byte[])(reader["IMAGEMVEICULO"]);

            var nomeGrupoVeiculo = Convert.ToString(reader["NOMEGRUPOVEICULO"]);
            var valorDiaria = Convert.ToDouble(reader["VALORDIARIA"]);
            var valorKmDiaria = Convert.ToDouble(reader["VALORKMDIARIA"]);
            var valorKmLivre = Convert.ToDouble(reader["VALORKMLIVRE"]);
            var valorKmControlado = Convert.ToDouble(reader["VALORKMCONTROLADO"]);
            var limiteKmControlado = Convert.ToDouble(reader["LIMITEKMCONTROLADO"]);
            var valorDiariaKmControlado = Convert.ToDouble(reader["VALORDIARIAKMCONTROLADO"]);

            var nomeCupom = Convert.ToString(reader["NOMECUPOM"]);
            var dataInicio = Convert.ToDateTime(reader["DATAINICIO"]);
            var dataFim = Convert.ToDateTime(reader["DATAFIM"]);
            var idParceiro = Convert.ToInt32(reader["IDPARCEIRO"]);
            var valorMinimo = Convert.ToDouble(reader["VAMORMINIMO"]);
            var valor = Convert.ToDouble(reader["VALOR"]);
            var calculoReal = Convert.ToBoolean(reader["CALCULOREAL"]);
            var calculoPorcentagem = Convert.ToBoolean(reader["CALCULOPORCENTAGEM"]);

            var nomeParceiro = Convert.ToString(reader["NOMEPARCEIRO"]);
            var idMidia = Convert.ToInt32(reader["IDMIDIA"]);

            var nomeMidia = Convert.ToString(reader["NOMEMIDIA"]);

            var dataSaida = Convert.ToDateTime(reader["DATASAIDA"]);
            var dataRetorno = Convert.ToDateTime(reader["DATARETORNO"]);
            var valorTotal = Convert.ToDouble(reader["VALORTOTAL"]);
            var plano = Convert.ToString(reader["PLANO"]);
            var valorCaucao = Convert.ToDouble(reader["VALORCAUCAO"]);
            var kmInicial = Convert.ToInt32(reader["KMINICIAL"]);

            Midia midia = new Midia(nomeMidia);

            Parceiro parceiro = new Parceiro(nomeParceiro, midia);

            Cupom cupom = new Cupom(nomeCupom, dataInicio, dataFim, parceiro, valor, valorMinimo, calculoReal, calculoPorcentagem);

            ClienteCnpj empresa = null;
            if (reader["IDCLIENTEPJ"] != DBNull.Value)
            {
                empresa = new ClienteCnpj(nomeCliente, enderecoCliente, emailCliente, cidadeCliente,
                estadoCliente, telefoneCliente, celularCliente, cnpj);
                empresa.Id = Convert.ToInt32(reader["IDCLIENTEPJ"]);
            }


            Condutor condutor = new Condutor(nomeCondutor, enderecoCondutor, emailCondutor, cidadeCondutor,
                estadoCondutor, telefoneCondutor, celularCondutor, rgCondutor, cpfCondutor, cnhCondutor, validadeCnhCondutor, empresa);

            GrupoDeVeiculos grupoDeVeiculos = new GrupoDeVeiculos(nomeGrupoVeiculo, valorDiaria,valorKmDiaria,valorKmLivre,limiteKmControlado,valorKmControlado, valorDiariaKmControlado);

            Veiculo veiculo = new Veiculo(nomeVeiculo, corVeiculo, marca, placa, chassi, kmAtual,
                numeroPortas, litrosTanque, capacidade, ano, grupoDeVeiculos, (PortaMalaVeiculoEnum)portaMalas, imagem);
            veiculo.Id = Convert.ToInt32(reader["IDVEICULO"]);

            Locacao locacao = new Locacao(empresa,condutor, veiculo, plano,dataSaida, dataRetorno, valorTotal, valorCaucao, kmInicial, cupom);
            locacao.Id = Convert.ToInt32(reader["ID"]);

            return locacao;
        }

        public bool VerificaVeiculoLocado(int idVeiculo, int id)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", id);
            parametros.Add("IDVEICULO", idVeiculo);
       

            return Db.Exists(sqlExisteLocacaoComVeiculoIgual, parametros);
        }


        private Dictionary<string, object> ObtemParametrosLocacao(Locacao locacao)
        {
            var parametros = new Dictionary<string, object>();

          
            parametros.Add("ID", locacao.Id);
            if(locacao.Condutor != null)
            {
                parametros.Add("IDCONDUTOR", locacao.Condutor.Id);
            }
            else if(locacao.PessoaPF != null)
            {
                parametros.Add("IDCONDUTOR", locacao.PessoaPF.Id);
            }
            parametros.Add("IDVEICULO", locacao.Veiculo.Id);
            if (locacao.Empresa != null)
            {
                parametros.Add("IDCLIENTEPJ", locacao.Empresa.Id);
            }
            else
            {
                parametros.Add("IDCLIENTEPJ", null);
            }
            parametros.Add("PLANO", locacao.Plano);
            parametros.Add("VALORTOTAL", locacao.ValorTotal);
            parametros.Add("VALORCAUCAO", locacao.Caucao);
            parametros.Add("DATASAIDA", locacao.DataSaida);
            parametros.Add("DATARETORNO", locacao.DataRetorno);
            parametros.Add("KMINICIAL", locacao.KmInicial);

            return parametros;
        }
    }
}
