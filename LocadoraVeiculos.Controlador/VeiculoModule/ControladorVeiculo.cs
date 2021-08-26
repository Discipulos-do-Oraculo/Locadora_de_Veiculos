using LocadoraVeiculo.Dominio.GrupoDeVeiculosModule;
using LocadoraVeiculo.Dominio.VeiculoModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Controlador.VeiculoModule
{
    public class ControladorVeiculo : Controlador<Veiculo>
    {
        #region Queries
        private const string sqlInserirVeiculo =
            @"INSERT INTO [TBVEICULOS]
                (               
                    [VEICULO],        
                    [COR],            
                    [KMATUAL],           
                    [PORTAMALAS],     
                    [NUMEROPORTAS],   
                    [ANO],            
                    [CHASSI],         
                    [MARCA],          
                    [LITROSTANQUE],   
                    [PLACA],          
                    [CAPACIDADE],     
                    [GRUPO],
                    [IMAGEM]
                         
                )
                VALUES
                (
                    @VEICULO,
                    @COR,
                    @KMATUAL,
                    @PORTAMALAS,
                    @NUMEROPORTAS,
                    @ANO,
                    @CHASSI,
                    @MARCA,
                    @LITROSTANQUE,
                    @PLACA,
                    @CAPACIDADE,
                    @GRUPO,
                    @IMAGEM
                )";

        private const string sqlEditarVeiculo =
            @" UPDATE [TBVEICULOS]
                SET 
                    [VEICULO] = @VEICULO,        
                    [COR] = @COR,            
                    [KMATUAL] = @KMATUAL,           
                    [PORTAMALAS]= @PORTAMALAS,     
                    [NUMEROPORTAS]= @NUMEROPORTAS,   
                    [ANO]= @ANO,            
                    [CHASSI]= @CHASSI,         
                    [MARCA]= @MARCA,          
                    [LITROSTANQUE]= @LITROSTANQUE,   
                    [PLACA]= @PLACA,          
                    [CAPACIDADE]= @CAPACIDADE,     
                    [GRUPO] = @GRUPO,
                    [IMAGEM] = @IMAGEM

                WHERE [ID] = @ID";

        private const string sqlExcluirVeiculo =
            @"DELETE FROM [TBVEICULOS] 
                WHERE [ID] = @ID";

        private const string sqlSelecionarTodosVeiculos =
            @"SELECT 
                    [TBVEICULOS].ID,
                    [VEICULO],        
                    [COR],            
                    [KMATUAL],           
                    [PORTAMALAS],     
                    [NUMEROPORTAS],   
                    [ANO],            
                    [CHASSI],         
                    [MARCA],          
                    [LITROSTANQUE],   
                    [PLACA],          
                    [CAPACIDADE],
                    [IMAGEM],
                    [GRUPO],
                    [TBGRUPODEVEICULOS].NOME,
                    [TBGRUPODEVEICULOS].VALORDIARIA,
                    [TBGRUPODEVEICULOS].VALORKMDIARIA,
                    [TBGRUPODEVEICULOS].VALORKMLIVRE,
                    [TBGRUPODEVEICULOS].LIMITEKMCONTROLADO,
                    [TBGRUPODEVEICULOS].VALORKMCONTROLADO,
                    [TBGRUPODEVEICULOS].VALORDIARIAKMCONTROLADO

            FROM
                    [TBVEICULOS] INNER JOIN 
                    [TBGRUPODEVEICULOS] 
            ON
                
                [TBVEICULOS].GRUPO = [TBGRUPODEVEICULOS].ID ";

        private const string sqlSelecionarVeiculoPorId =
            @"SELECT 
                    [TBVEICULOS].ID,
                    [VEICULO],        
                    [COR],            
                    [KMATUAL],           
                    [PORTAMALAS],     
                    [NUMEROPORTAS],   
                    [ANO],            
                    [CHASSI],         
                    [MARCA],          
                    [LITROSTANQUE],   
                    [PLACA],          
                    [CAPACIDADE],
                    [IMAGEM],
                    [GRUPO],
                    [TBGRUPODEVEICULOS].NOME,
                    [TBGRUPODEVEICULOS].VALORDIARIA,
                    [TBGRUPODEVEICULOS].VALORKMDIARIA,
                    [TBGRUPODEVEICULOS].VALORKMLIVRE,
                    [TBGRUPODEVEICULOS].LIMITEKMCONTROLADO,
                    [TBGRUPODEVEICULOS].VALORKMCONTROLADO,
                    [TBGRUPODEVEICULOS].VALORDIARIAKMCONTROLADO

            FROM
                    [TBVEICULOS] INNER JOIN 
                    [TBGRUPODEVEICULOS] 
            ON
                
                [TBVEICULOS].GRUPO = [TBGRUPODEVEICULOS].ID 
            WHERE 
                [TBVEICULOS].ID = @ID";

       
        private const string sqlExisteVeiculoComEssaPlaca =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBVEICULOS]
            WHERE 
                [PLACA] = @PLACA AND [ID] <> @ID";

        private const string sqlExisteVeiculo =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBVEICULOS]
            WHERE 
                [ID] = @ID";

        private const string sqlDevolucaoRegistrada =
            @"SELECT COUNT(*) FROM TBVEICULOS INNER JOIN 
              TBLOCACAO ON TBVEICULOS.ID = TBLOCACAO.IDVEICULO 
              INNER JOIN TBDevolucao ON TBLocacao.Id = TBDevolucao.IdLocacao
              WHERE TBVEICULOS.ID = @ID  ;";

        private const string sqlTemLocacao =
            @"SELECT COUNT(*) FROM TBVEICULOS INNER JOIN 
              TBLOCACAO ON TBVEICULOS.ID = TBLOCACAO.IDVEICULO 
              WHERE TBVEICULOS.ID = @ID  ;";

        #endregion

        public override string InserirNovo(Veiculo registro)
        {
            string resultadoValidacao = registro.Validar();

            bool existePlaca = VerificaPlaca(registro.Placa,registro.Id);

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                if (existePlaca) { }
                else
                {
                    registro.Id = Db.Insert(sqlInserirVeiculo, ObtemParametrosVeiculo(registro));
                }
            }

            return resultadoValidacao;
        }

        

        public override string Editar(int id, Veiculo registro)
        {
            string resultadoValidacao = registro.Validar();

            bool existePlaca = VerificaPlaca(registro.Placa, id);

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                if (existePlaca) { }
                else
                {
                    registro.Id = id;
                    Db.Update(sqlEditarVeiculo, ObtemParametrosVeiculo(registro));
                }
            }

            return resultadoValidacao;
        }

        public bool VerificaLocacaoFechada(int id)
        {

            return Db.Exists(sqlDevolucaoRegistrada, AdicionarParametro("ID", id));

        }

        public bool TemLocacao(int id)
        {

            return Db.Exists(sqlTemLocacao, AdicionarParametro("ID", id));

        }


        public override bool Excluir(int id)
        {
            try
            {
                Db.Delete(sqlExcluirVeiculo, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public override bool Existe(int id)
        {
            return Db.Exists(sqlExisteVeiculo, AdicionarParametro("ID", id));
        }

        public override Veiculo SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarVeiculoPorId, ConverterEmVeiculo, AdicionarParametro("ID", id));
        }

        public override List<Veiculo> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodosVeiculos, ConverterEmVeiculo);
        }

        public bool VerificaPlaca(string placa,int id)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", id);
            parametros.Add("PLACA", placa);

            return Db.Exists(sqlExisteVeiculoComEssaPlaca, parametros);
        }
        private Veiculo ConverterEmVeiculo(IDataReader reader)
        {
            var nomeVeiculo = Convert.ToString(reader["VEICULO"]);
            var cor = Convert.ToString(reader["COR"]);
            var kmAtual = Convert.ToInt32(reader["KMATUAL"]);
            var portaMalas = Convert.ToInt32(reader["PORTAMALAS"]);
            var numeroPortas = Convert.ToInt32(reader["NUMEROPORTAS"]);
            var ano = Convert.ToInt32(reader["ANO"]);
            var chassi = Convert.ToString(reader["CHASSI"]);
            var marca = Convert.ToString(reader["MARCA"]);
            var litrosTanque = Convert.ToInt32(reader["LITROSTANQUE"]);
            var placa = Convert.ToString(reader["PLACA"]);
            var capacidade = Convert.ToInt32(reader["CAPACIDADE"]);
            var imagem = (byte[])(reader["IMAGEM"]);
            var id_grupoDeVeiculos = Convert.ToInt32(reader["GRUPO"]);
            var idVeiculo = Convert.ToInt32(reader["ID"]);



            string nome = Convert.ToString(reader["NOME"]);
            double valorDiaria = Convert.ToDouble(reader["VALORDIARIA"]);
            double valorKmDiaria = Convert.ToDouble(reader["VALORKMDIARIA"]);
            double valorKmLivre = Convert.ToDouble(reader["VALORKMLIVRE"]);
            double limiteKmControlado = Convert.ToDouble(reader["LIMITEKMCONTROLADO"]);
            double valorKmControlado = Convert.ToDouble(reader["VALORKMCONTROLADO"]);
            double valorDiariaKmControlado = Convert.ToDouble(reader["VALORDIARIAKMCONTROLADO"]);


            GrupoDeVeiculos grupoDeVeiculo = new GrupoDeVeiculos(nome, valorDiaria,valorKmDiaria,valorKmLivre,limiteKmControlado,valorKmControlado, valorDiariaKmControlado);

            grupoDeVeiculo.Id = id_grupoDeVeiculos;
            
            Veiculo veiculo = new Veiculo(nomeVeiculo, cor, marca, placa, chassi, kmAtual, numeroPortas, litrosTanque, capacidade, ano, grupoDeVeiculo, (PortaMalaVeiculoEnum)portaMalas,imagem);
            veiculo.Id = idVeiculo;

            return veiculo;
        }

        private Dictionary<string, object> ObtemParametrosVeiculo(Veiculo veiculo)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", veiculo.Id);
            parametros.Add("VEICULO", veiculo.NomeVeiculo);
            parametros.Add("COR", veiculo.Cor);
            parametros.Add("KMATUAL", veiculo.KmAtual);
            parametros.Add("PORTAMALAS", veiculo.PortaMala);
            parametros.Add("NUMEROPORTAS", veiculo.NumeroPortas);
            parametros.Add("ANO", veiculo.Ano);
            parametros.Add("CHASSI", veiculo.Chassi);
            parametros.Add("MARCA", veiculo.Marca);
            parametros.Add("LITROSTANQUE", veiculo.LitrosTanque);
            parametros.Add("PLACA", veiculo.Placa);
            parametros.Add("CAPACIDADE", veiculo.QuantidadeLugares);
            parametros.Add("GRUPO", veiculo.GrupoDeVeiculos.Id);
            parametros.Add("IMAGEM", veiculo.Imagem);

            return parametros;
        }


    }
}
