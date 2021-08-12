using LocadoraVeiculo.Dominio.ClienteModule;
using LocadoraVeiculo.Dominio.GrupoDeVeiculosModule;
using LocadoraVeiculo.Dominio.VeiculoModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Controlador.ClienteModule
{

    public class ControladorClientePF : Controlador<ClientePF>
    {
        #region Queries
        private const string sqlInserirClientePF =
            @"INSERT INTO [TBCLIENTEPF]
                (               
                    [NOME],        
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
            @" UPDATE [TBCLIENTEPF]
                SET 
                    [NOME] = @NOME,        
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
            @"DELETE FROM [TBCLIENTEPF] 
                WHERE [ID] = @ID";

        private const string sqlSelecionarTodosClientePF =
            @"SELECT 
                    [ID],
                    [NOME],        
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
                    [TBCLIENTEPF]";

        private const string sqlSelecionarClientePFPorId =
            @"SELECT 
                    [ID],
                    [NOME],        
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
                    [TBCLIENTEPF]
            WHERE 
                ID = @ID";


        private const string sqlExisteClientePF =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBCLIENTEPF]
            WHERE 
                [ID] = @ID";


        #endregion

        public override string Editar(int id, ClientePF registro)
        {

            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarClientePF, ObtemParametrosClientePF(registro));
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

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                    registro.Id = Db.Insert(sqlInserirClientePF, ObtemParametrosClientePF(registro));
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

        private ClientePF ConverterEmClientePF(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string nome = Convert.ToString(reader["NOME"]);
            string endereco = Convert.ToString(reader["ENDERECO"]);
            string email = Convert.ToString(reader["EMAIL"]);
            string cidade = Convert.ToString(reader["CIDADE"]);
            string estado = Convert.ToString(reader["ESTADO"]);
            string telefone = Convert.ToString(reader["TELEFONE"]);
            string rg = Convert.ToString(reader["RG"]);
            string cpf = Convert.ToString(reader["CPF"]);
            string cnh = Convert.ToString(reader["CNH"]);
            DateTime validadecnh = Convert.ToDateTime(reader["VALIDADECNH"]);

            ClientePF clienteCondutor = new ClientePF(nome,endereco,email,cidade,estado,telefone,rg,cpf,cnh,validadecnh);

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
            parametros.Add("RG", cliente.Rg);
            parametros.Add("CPF", cliente.Cpf);
            parametros.Add("CNH", cliente.Cnh);
            parametros.Add("VALIDADECNH", cliente.ValidadeCnh);

            return parametros;
        }
    }
}
