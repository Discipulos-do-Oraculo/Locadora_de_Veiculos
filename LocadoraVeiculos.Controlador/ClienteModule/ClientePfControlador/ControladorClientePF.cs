using LocadoraVeiculo.Dominio.ClienteModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Controlador.ClienteModule.ClientePfControlador
{
    public class ControladorClientePF : Controlador<ClientePF>
    {
        #region Queries
        private const string sqlInserirClientePF =
            @"INSERT INTO [TBCONDUTOR]
                (               
                    [NOMECONDUTOR],        
                    [ENDERECO],            
                    [EMAIL],           
                    [CIDADE],     
                    [ESTADO],   
                    [TELEFONE],            
                    [CELULAR],         
                    [RG],          
                    [CPF],   
                    [CNH],          
                    [VALIDADECNH]  
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
                    @RG,
                    @CPF,
                    @CNH,
                    @VALIDADECNH
                )";

        private const string sqlEditarClientePF =
            @" UPDATE [TBCONDUTOR]
                SET 
                    [NOMECONDUTOR] = @NOME,        
                    [ENDERECO] = @ENDERECO,            
                    [EMAIL] = @EMAIL,           
                    [CIDADE]= @CIDADE,     
                    [ESTADO]= @ESTADO,   
                    [TELEFONE]= @TELEFONE,            
                    [CELULAR]= @CELULAR,         
                    [RG]= @RG,          
                    [CPF]= @CPF,   
                    [CNH]= @CNH,          
                    [VALIDADECNH]= @VALIDADECNH
                WHERE [ID] = @ID";

        private const string sqlExcluirClientePF =
            @"DELETE FROM [TBCONDUTOR] 
                WHERE [ID] = @ID";

        private const string sqlSelecionarTodosClientePF =
            @"SELECT 
                    [ID],
                    [NOMECONDUTOR],        
                    [ENDERECO],            
                    [EMAIL],           
                    [CIDADE],     
                    [ESTADO],   
                    [TELEFONE],            
                    [CELULAR],         
                    [RG],          
                    [CPF],   
                    [CNH],          
                    [VALIDADECNH]
            FROM
                    [TBCONDUTOR]

            WHERE  [IDCLIENTECNPJ]  IS NULL";
            

        private const string sqlSelecionarClientePFPorId =
            @"SELECT 
                    [ID],
                    [NOMECONDUTOR],        
                    [ENDERECO],            
                    [EMAIL],           
                    [CIDADE],     
                    [ESTADO],   
                    [TELEFONE],            
                    [CELULAR],         
                    [RG],          
                    [CPF],   
                    [CNH],          
                    [VALIDADECNH]
            FROM
                    [TBCONDUTOR]
            WHERE 
                ID = @ID
            AND [IDCLIENTECNPJ]  IS NULL";


        private const string sqlExisteClientePF =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBCONDUTOR]
            WHERE 
                [ID] = @ID";

        private const string sqlExistePessoaComCpfIgual =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBCONDUTOR]
            WHERE 
                [CPF] = @CPF AND [ID] <> @ID";

        private const string sqlExistePessoaComRgIgual =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBCONDUTOR]
            WHERE 
                [RG] = @RG AND [ID] <> @ID";

        private const string sqlExistePessoaComCnhIgual =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBCONDUTOR]
            WHERE 
                [CNH] = @CNH AND [ID] <> @ID";


        #endregion

        public override string Editar(int id, ClientePF registro)
        {

            string resultadoValidacao = registro.Validar();
            bool existeCpf = VerificaCPF(registro.Cpf,id);
            bool existeRg = VerificaRG(registro.Rg, id);
            bool existeCnh = VerificaCNH(registro.Cnh, id);

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                if (existeCpf) { }
                else if (existeRg) { }
                else if (existeCnh) { }
                else
                {
                    registro.Id = id;
                    Db.Update(sqlEditarClientePF, ObtemParametrosClientePF(registro));
                }
                
            }

            return resultadoValidacao;
        }

        public override bool Excluir(int id)
        {
            try
            {
                Db.Delete(sqlExcluirClientePF, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public override bool Existe(int id)
        {
            return Db.Exists(sqlExisteClientePF, AdicionarParametro("ID", id));
        }

        public override string InserirNovo(ClientePF registro)
        {
            string resultadoValidacao = registro.Validar();
            bool existeCpf = VerificaCPF(registro.Cpf, registro.Id);
            bool existeRg = VerificaRG(registro.Rg, registro.Id);
            bool existeCnh = VerificaCNH(registro.Cnh, registro.Id);

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                if (existeCpf) { }
                else if (existeRg) { }
                else if (existeCnh) { }
                else
                {
                    registro.Id = Db.Insert(sqlInserirClientePF, ObtemParametrosClientePF(registro));
                }

            }

            return resultadoValidacao;
        }

        public override ClientePF SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarClientePFPorId, ConverterEmClientePF, AdicionarParametro("ID", id));
        }

        public override List<ClientePF> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodosClientePF, ConverterEmClientePF);
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

        public bool VerificaCNH(string cnh, int id)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", id);
            parametros.Add("CNH", cnh);

            return Db.Exists(sqlExistePessoaComCnhIgual, parametros);
        }

        private ClientePF ConverterEmClientePF(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string nome = Convert.ToString(reader["NOMECONDUTOR"]);
            string endereco = Convert.ToString(reader["ENDERECO"]);
            string email = Convert.ToString(reader["EMAIL"]);
            string cidade = Convert.ToString(reader["CIDADE"]);
            string estado = Convert.ToString(reader["ESTADO"]);
            string telefone = Convert.ToString(reader["TELEFONE"]);
            string celular = Convert.ToString(reader["CELULAR"]);
            string rg = Convert.ToString(reader["RG"]);
            string cpf = Convert.ToString(reader["CPF"]);
            string cnh = Convert.ToString(reader["CNH"]);
            DateTime validadecnh = Convert.ToDateTime(reader["VALIDADECNH"]);

            ClientePF clienteCondutor = new ClientePF(nome, endereco, email, cidade, estado, telefone, celular, rg, cpf, cnh, validadecnh);

            clienteCondutor.Id = id;

            return clienteCondutor;
        }
        private Dictionary<string, object> ObtemParametrosClientePF(ClientePF cliente)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", cliente.Id);
            parametros.Add("NOME", cliente.Nome);
            parametros.Add("ENDERECO", cliente.Endereco);
            parametros.Add("EMAIL", cliente.Email);
            parametros.Add("CIDADE", cliente.Cidade);
            parametros.Add("ESTADO", cliente.Estado);
            parametros.Add("TELEFONE", cliente.Telefone);
            parametros.Add("CELULAR", cliente.Celular);
            parametros.Add("RG", cliente.Rg);
            parametros.Add("CPF", cliente.Cpf);
            parametros.Add("CNH", cliente.Cnh);
            parametros.Add("VALIDADECNH", cliente.ValidadeCnh);

            return parametros;
        }
    
    }
}
