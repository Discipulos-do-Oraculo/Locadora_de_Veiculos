using LocadoraVeiculo.Dominio.ClienteModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Controlador.ClienteModule.CondutorControlador
{
    public class ControladorColaborador : Controlador<Colaborador>
    {

        #region Queries
        private const string sqlInserirColaborador =
            @"INSERT INTO [TBFUNCIONARIO]
                (               
                    [NOME],        
                    [ENDERECO],            
                    [EMAIL],           
                    [CIDADE],     
                    [ESTADO],   
                    [TELEFONE],            
                    [CELULAR],         
                    [LOGIN],          
                    [SENHA],   
                    [DATADEENTRADA],          
                    [SALARIO],
                    [CPF],
                    [RG]
                         
                )
                VALUES
                (
                    @NOME,
                    @ENDERECO,
                    @EMAIL,
                    @CIDADE,
                    @ESTADO,
                    @TELEFONE,
                    @CELULAR,
                    @LOGIN,
                    @SENHA,
                    @DATADEENTRADA,
                    @SALARIO,
                    @CPF,
                    @RG
                )";

        private const string sqlEditarColaborador =
            @" UPDATE [TBFUNCIONARIO]
                SET 
                    [NOME] = @NOME,        
                    [ENDERECO] = @ENDERECO,            
                    [EMAIL] = @EMAIL,           
                    [CIDADE]= @CIDADE,     
                    [ESTADO]= @ESTADO,   
                    [TELEFONE]= @TELEFONE,            
                    [CELULAR]= @CELULAR,         
                    [LOGIN]= @LOGIN,          
                    [SENHA]= @SENHA,   
                    [DATADEENTRADA]= @DATADEENTRADA,          
                    [SALARIO]= @SALARIO,
                    [CPF] = @CPF,
                    [RG] = @RG
                WHERE [ID] = @ID";

        private const string sqlExcluirColaborador =
            @"DELETE FROM [TBFUNCIONARIO] 
                WHERE [ID] = @ID";

        private const string sqlSelecionarTodosColaborador =
            @"SELECT 
                    [ID],
                    [NOME],        
                    [ENDERECO],            
                    [EMAIL],           
                    [CIDADE],     
                    [ESTADO],   
                    [TELEFONE],            
                    [CELULAR],         
                    [LOGIN],          
                    [SENHA],   
                    [DATADEENTRADA],          
                    [SALARIO],
                    [CPF],
                    [RG]
            FROM
                    [TBFUNCIONARIO]";

        private const string sqlSelecionarColaboradorPorId =
            @"SELECT 
                    [ID],
                    [NOME],        
                    [ENDERECO],            
                    [EMAIL],           
                    [CIDADE],     
                    [ESTADO],   
                    [TELEFONE],            
                    [CELULAR],         
                    [LOGIN],          
                    [SENHA],   
                    [DATADEENTRADA],          
                    [SALARIO],
                    [CPF],
                    [RG]
            FROM
                    [TBFUNCIONARIO]
            WHERE 
                ID = @ID";


        private const string sqlExisteColaborador =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBFUNCIONARIO]
            WHERE 
                [ID] = @ID";

        private const string sqlExistePessoaComCpfIgual =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBFUNCIONARIO]
            WHERE 
                [CPF] = @CPF AND [ID] <> @ID";

        private const string sqlExistePessoaComRgIgual =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBFUNCIONARIO]
            WHERE 
                [RG] = @RG AND [ID] <> @ID";

        #endregion




        public override string Editar(int id, Colaborador registro)
        {
            string resultadoValidacao = registro.Validar();
            bool existeCpf = VerificaCPF(registro.Cpf, id);
            bool existeRg = VerificaRG(registro.Rg, id);

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                if (existeCpf) { }
                else if (existeRg) { }
                else
                {
                    registro.Id = id;
                    Db.Update(sqlEditarColaborador, ObtemParametrosColaborador(registro));
                }
            }

            return resultadoValidacao;
        }

        public override bool Excluir(int id)
        {
            try
            {
                Db.Delete(sqlExcluirColaborador, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public override bool Existe(int id)
        {
            return Db.Exists(sqlExisteColaborador, AdicionarParametro("ID", id));
        }

        public override string InserirNovo(Colaborador registro)
        {
            string resultadoValidacao = registro.Validar();
            bool existeCpf = VerificaCPF(registro.Cpf, registro.Id);
            bool existeRg = VerificaRG(registro.Rg, registro.Id);
        
            if (resultadoValidacao == "ESTA_VALIDO")
            {
                if (existeCpf) { }
                else if (existeRg) { }
                else
                {
                    registro.Id = Db.Insert(sqlInserirColaborador, ObtemParametrosColaborador(registro));
                }

                   
            }

            return resultadoValidacao;
        }

        public override Colaborador SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarColaboradorPorId, ConverterEmColaborador, AdicionarParametro("ID", id));
        }

        public override List<Colaborador> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodosColaborador, ConverterEmColaborador);
        }

        public bool VerificaCPF(string cpf, int id)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", id);
            parametros.Add("CPF", cpf);

            return Db.Exists(sqlExistePessoaComCpfIgual, parametros);
        }

        public bool VerificaRG(string rg, int id)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", id);
            parametros.Add("RG", rg);

            return Db.Exists(sqlExistePessoaComRgIgual, parametros);
        }

      
        private Colaborador ConverterEmColaborador(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string nome = Convert.ToString(reader["NOME"]);
            string endereco = Convert.ToString(reader["ENDERECO"]);
            string email = Convert.ToString(reader["EMAIL"]);
            string cidade = Convert.ToString(reader["CIDADE"]);
            string estado = Convert.ToString(reader["ESTADO"]);
            string telefone = Convert.ToString(reader["TELEFONE"]);
            string celular = Convert.ToString(reader["CELULAR"]);
            string login = Convert.ToString(reader["LOGIN"]);
            string senha = Convert.ToString(reader["SENHA"]);
            DateTime dataEntrada = Convert.ToDateTime(reader["DATADEENTRADA"]);
            double salario = Convert.ToDouble(reader["SALARIO"]);
            string cpf = Convert.ToString(reader["CPF"]);
            string rg = Convert.ToString(reader["RG"]);



            Colaborador colaborador = new Colaborador(nome, endereco, email, cidade, estado, telefone, celular, rg, cpf, login, senha, dataEntrada, salario);

            colaborador.Id = id;

            return colaborador;
        }
        private Dictionary<string, object> ObtemParametrosColaborador(Colaborador colaborador)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", colaborador.Id);
            parametros.Add("NOME", colaborador.Nome);
            parametros.Add("ENDERECO", colaborador.Endereco);
            parametros.Add("EMAIL", colaborador.Email);
            parametros.Add("CIDADE", colaborador.Cidade);
            parametros.Add("ESTADO", colaborador.Estado);
            parametros.Add("TELEFONE", colaborador.Telefone);
            parametros.Add("CELULAR", colaborador.Celular);
            parametros.Add("LOGIN", colaborador.Login);
            parametros.Add("SENHA", colaborador.Senha);
            parametros.Add("DATADEENTRADA", colaborador.DataEntrada);
            parametros.Add("SALARIO", colaborador.Salario);
            parametros.Add("CPF", colaborador.Cpf);
            parametros.Add("RG", colaborador.Rg);

            return parametros;
        }
    }
}
