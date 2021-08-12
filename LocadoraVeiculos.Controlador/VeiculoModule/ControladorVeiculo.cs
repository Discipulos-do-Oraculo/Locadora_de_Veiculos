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
                    [IDGRUPOVEICULO] 
                         
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
                    @IDGRUPOVEICULO
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
                    [IDGRUPOVEICULO] = @IDGRUPOVEICULO

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
                    [TBGRUPODEVEICULOS].ID,
                    [TBGRUPODEVEICULOS].NOME,
                    [TBGRUPODEVEICULOS].VALOR

            FROM
                    [TBVEICULOS] INNER JOIN 
                    [TBGRUPODEVEICULOS] 
            ON
                
                [TBVEICULOS].IDGRUPOVEICULO = [TBGRUPODEVEICULOS].ID ";

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
                    [TBGRUPODEVEICULOS].ID,
                    [TBGRUPODEVEICULOS].NOME,
                    [TBGRUPODEVEICULOS].VALOR

            FROM
                    [TBVEICULOS] INNER JOIN 
                    [TBGRUPODEVEICULOS] 
            ON
                
                [TBVEICULOS].IDGRUPOVEICULO = [TBGRUPODEVEICULOS].ID 
            WHERE 
                [TBVEICULOS].ID = @ID";

       
        private const string sqlExisteVeiculo =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBVEICULOS]
            WHERE 
                [ID] = @ID";


        #endregion

        public override string InserirNovo(Veiculo registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = Db.Insert(sqlInserirVeiculo, ObtemParametrosVeiculo(registro));
            }

            return resultadoValidacao;
        }

        public override string Editar(int id, Veiculo registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarVeiculo, ObtemParametrosVeiculo(registro));
            }

            return resultadoValidacao;
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

        /// <summary>
        /// //https://stackoverflow.com/questions/8503825/what-is-the-correct-sql-type-to-store-a-net-timespan-with-values-240000
        /// </summary>
  
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
           // var id_grupoDeVeiculos = Convert.ToInt32(reader["IDGRUPOVEICULO"]);

            var nomeGrupoVeiculo = Convert.ToString(reader["NOME"]);
            var valorGrupoVeiculo = Convert.ToDouble(reader["VALOR"]);

            GrupoDeVeiculos grupoDeVeiculo = new GrupoDeVeiculos(nomeGrupoVeiculo, valorGrupoVeiculo);
           // grupoDeVeiculo.Id = id_grupoDeVeiculos;
            
            Veiculo veiculo = new Veiculo(nomeVeiculo, cor, marca, placa, chassi, kmAtual, numeroPortas, litrosTanque, capacidade, ano, grupoDeVeiculo, (PortaMalaVeiculoEnum)portaMalas);
            veiculo.Id = Convert.ToInt32(reader["ID"]);

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
            parametros.Add("IDGRUPOVEICULO", veiculo.GrupoDeVeiculos.Id);

            return parametros;
        }


    }
}
