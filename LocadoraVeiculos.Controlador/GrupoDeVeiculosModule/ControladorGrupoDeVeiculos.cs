
using LocadoraVeiculo.Dominio.GrupoDeVeiculosModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Controlador.GrupoDeVeiculosModule
{
    public class ControladorGrupoDeVeiculos : Controlador<GrupoDeVeiculos>
    {
        #region

        private const string sqlInserirGruposDeVeiculos =
            @"INSERT INTO 
                        [TBGRUPODEVEICULOS] 
            (
                        [NOME],
                        [VALORDIARIA],
                        [VALORKMDIARIA],
                        [VALORKMLIVRE],
                        [LIMITEKMCONTROLADO],
                        [VALORKMCONTROLADO],
                        [VALORDIARIAKMCONTROLADO]
            )
        
            VALUES
            (
                         @NOME,
                         @VALORDIARIA,
                         @VALORKMDIARIA,
                         @VALORKMLIVRE,
                         @LIMITEKMCONTROLADO,
                         @VALORKMCONTROLADO,
                         @VALORDIARIAKMCONTROLADO
            )";


        private const string sqlEditarGrupoDeVeiculo =
            @"UPDATE [TBGRUPODEVEICULOS]
                    SET
                        [NOME] = @NOME,
		                [VALORDIARIA] = @VALORDIARIA,
                        [VALORKMDIARIA] = @VALORKMDIARIA,
                        [VALORKMLIVRE] = @VALORKMLIVRE,
                        [LIMITEKMCONTROLADO] = @LIMITEKMCONTROLADO,
                        [VALORKMCONTROLADO] = @VALORKMCONTROLADO,
                        [VALORDIARIAKMCONTROLADO] = @VALORDIARIAKMCONTROLADO
                    WHERE 
                        ID = @ID";


        private const string sqlExcluirGrupoDeVeiculos = @"DELETE FROM [TBGRUPODEVEICULOS] WHERE ID = @ID ";

        private const string sqlSelecionarTodosOsGruposDeVeiculos = @"SELECT * FROM [TBGRUPODEVEICULOS] ";

        private const string sqlSelecionarTodosOsGruposDeVeiculosPorId = @" SELECT * FROM [TBGRUPODEVEICULOS] WHERE ID = @ID";

        private const string sqlExisteContato =

            @"SELECT 
                COUNT(*) 
            FROM 
                [TBGRUPODEVEICULOS]
            WHERE 
                [ID] = @ID";

        private const string sqlPossoExcluirGrupo =

           @"SELECT COUNT(*) FROM TBGRUPODEVEICULOS INNER JOIN 
            TBVEICULOS 
            ON TBGRUPODEVEICULOS.ID = TBVEICULOS.GRUPO 
            WHERE TBGRUPODEVEICULOS.ID = @ID;";

        #endregion


        public override string Editar(int id, GrupoDeVeiculos registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarGrupoDeVeiculo, ObtemParametrosGrupoDeVeiculos(registro));
            }

            return resultadoValidacao;
        }

        public bool PossoDeletar(int id)
        {

            return Db.Exists(sqlPossoExcluirGrupo, AdicionarParametro("ID", id));

        }


        public override bool Excluir(int id)
        {
            try
            {
                Db.Delete(sqlExcluirGrupoDeVeiculos, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public override bool Existe(int id)
        {
            return Db.Exists(sqlExisteContato, AdicionarParametro("ID", id));
        }

        public override string InserirNovo(GrupoDeVeiculos registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = Db.Insert(sqlInserirGruposDeVeiculos, ObtemParametrosGrupoDeVeiculos(registro));
            }

            return resultadoValidacao;
        }

        public override GrupoDeVeiculos SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarTodosOsGruposDeVeiculosPorId, ConverterEmGrupoVeiculo, AdicionarParametro("ID", id));
        }

        public override List<GrupoDeVeiculos> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodosOsGruposDeVeiculos, ConverterEmGrupoVeiculo);
        }


        private Dictionary<string, object> ObtemParametrosGrupoDeVeiculos(GrupoDeVeiculos grupoDeVeiculos)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", grupoDeVeiculos.Id);
            parametros.Add("NOME", grupoDeVeiculos.Nome);
            parametros.Add("VALORDIARIA", grupoDeVeiculos.ValorDiaria);
            parametros.Add("VALORKMDIARIA", grupoDeVeiculos.ValorKmDiaria);
            parametros.Add("VALORKMLIVRE", grupoDeVeiculos.ValorKmLivre);
            parametros.Add("LIMITEKMCONTROLADO", grupoDeVeiculos.LimiteKmControlado);
            parametros.Add("VALORKMCONTROLADO", grupoDeVeiculos.ValorKmControlado);
            parametros.Add("VALORDIARIAKMCONTROLADO", grupoDeVeiculos.ValorDiariaKmControlado);
            return parametros;
        }



        private GrupoDeVeiculos ConverterEmGrupoVeiculo(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string nome = Convert.ToString(reader["NOME"]);
            double valorDiaria  = Convert.ToDouble(reader["VALORDIARIA"]);
            double valorKmDiaria = Convert.ToDouble(reader["VALORKMDIARIA"]);
            double valorKmLivre = Convert.ToDouble(reader["VALORKMLIVRE"]);
            double limiteKmControlado = Convert.ToDouble(reader["LIMITEKMCONTROLADO"]);
            double valorKmControlado = Convert.ToDouble(reader["VALORKMCONTROLADO"]);
            double valorDiariaKmControlado = Convert.ToDouble(reader["VALORDIARIAKMCONTROLADO"]);


            GrupoDeVeiculos grupoDeVeiculos = new GrupoDeVeiculos(nome,valorDiaria,valorKmDiaria,valorKmLivre,limiteKmControlado,valorKmControlado, valorDiariaKmControlado);

            grupoDeVeiculos.Id = id;

            return grupoDeVeiculos;
        }
    }
}
