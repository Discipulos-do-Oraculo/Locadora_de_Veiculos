
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

        private const string sqlInserirGruposDeVeiculos = @"INSERT INTO TBGrupoDeVeiculos 
        (
         [NOME],
         [VALOR])
        
         VALUES
        
        (@NOME,
         @VALOR
        )";


        private const string sqlEditarGrupoDeVeiculo =
            @"UPDATE TBGrupoDeVeiculos
                    SET
                        [NOME] = @NOME,
		                [VALOR] = @VALOR
                    WHERE 
                        ID = @ID";


        private const string sqlExcluirGrupoDeVeiculos = @"DELETE FROM TBGrupoDeVeiculos WHERE ID = @ID ";

        private const string sqlSelecionarTodosOsGruposDeVeiculos = @"SELECT * FROM TBGrupoDeVeiculos ";

        private const string sqlSelecionarTodosOsGruposDeVeiculosPorId = @" SELECT * FROM TBGrupoDeVeiculos WHERE ID = @ID";

        private const string sqlExisteContato =

            @"SELECT 
                COUNT(*) 
            FROM 
                [TBGrupoDeVeiculos]
            WHERE 
                [ID] = @ID";

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
            parametros.Add("VALOR", grupoDeVeiculos.Valor);

            return parametros;
        }



        private GrupoDeVeiculos ConverterEmGrupoVeiculo(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string nome = Convert.ToString(reader["NOME"]);
            double valor  = Convert.ToDouble(reader["VALOR"]);


            GrupoDeVeiculos grupoDeVeiculos = new GrupoDeVeiculos(nome,valor);

            grupoDeVeiculos.Id = id;

            return grupoDeVeiculos;
        }
    }
}
