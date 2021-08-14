using LocadoraVeiculo.Dominio.ClienteModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Controlador.ClienteModule.CondutorControlador
{
    public class ControladorCondutor : Controlador<Condutor>
    {

        #region Queries
        private const string sqlInserirCondutor =
            @"INSERT INTO [TBCONDUTOR]
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
                    [VALIDADECNH],     
                    [IDCLIENTECNPJ]
                         
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
                    @VALIDADECNH,
                    @IDCLIENTECNPJ
                )";

        private const string sqlEditarCondutor =
            @" UPDATE [TBCONDUTOR]
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
                    [VALIDADECNH]= @VALIDADECNH,     
                    [IDCLIENTECNPJ] = @IDCLIENTECNPJ
                WHERE [ID] = @ID";

        private const string sqlExcluirCondutor =
            @"DELETE FROM [TBCONDUTOR] 
                WHERE [ID] = @ID";

        private const string sqlSelecionarTodosCondutor =
            @"SELECT 
                    [TBCONDUTOR].ID,
                    [TBCONDUTOR].NOME,        
                    [TBCONDUTOR].ENDERECO,            
                    [TBCONDUTOR].EMAIL,           
                    [TBCONDUTOR].CELULAR,     
                    [TBCONDUTOR].ESTADO,   
                    [TBCONDUTOR].TELEFONE,            
                    [TBCONDUTOR].CELULAR,         
                    [TBCONDUTOR].RG,          
                    [TBCONDUTOR].CPF,   
                    [TBCONDUTOR].CNH,          
                    [TBCONDUTOR].VALIDADECNH,
                    [TBCONDUTOR].IDCLIENTECNPJ,
                    [TBCLIENTEPJ].NOME AS EMPRESA,
                    [TBCLIENTEPJ].CNPJ
            FROM
                    [TBCONDUTOR] INNER JOIN
                    [TBCLIENTEPJ]
            
            ON
                    [TBCONDUTOR].IDCLIENTECNPJ = [TBCLIENTEPJ].ID";

        private const string sqlSelecionarCondutorPorId =
            @"SELECT 
                    [TBCONDUTOR].ID,
                    [TBCONDUTOR].NOME,        
                    [TBCONDUTOR].ENDERECO,            
                    [TBCONDUTOR].EMAIL,           
                    [TBCONDUTOR].CELULAR,     
                    [TBCONDUTOR].ESTADO,   
                    [TBCONDUTOR].TELEFONE,            
                    [TBCONDUTOR].CELULAR,         
                    [TBCONDUTOR].RG,          
                    [TBCONDUTOR].CPF,   
                    [TBCONDUTOR].CNH,          
                    [TBCONDUTOR].VALIDADECNH,
                    [TBCONDUTOR].IDCLIENTECNPJ,
                    [TBCLIENTEPJ].NOME AS EMPRESA,
                    [TBCLIENTEPJ].CNPJ
            FROM
                    [TBCONDUTOR] INNER JOIN
                    [TBCLIENTEPJ]
            
            ON
                    [TBCONDUTOR].IDCLIENTECNPJ = [TBCLIENTEPJ].ID
            WHERE
                    [TBCONDUTOR].ID = @ID";


        private const string sqlExisteCondutorPF =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBCONDUTOR]
            WHERE 
                [ID] = @ID";


        #endregion



        public override string Editar(int id, Condutor registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarCondutor, ObtemParametrosCondutor(registro));
            }

            return resultadoValidacao;
        }

        public override bool Excluir(int id)
        {
            try
            {
                Db.Delete(sqlExcluirCondutor, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public override bool Existe(int id)
        {
            return Db.Exists(sqlExisteCondutorPF, AdicionarParametro("ID", id));
        }

        public override string InserirNovo(Condutor registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = Db.Insert(sqlInserirCondutor, ObtemParametrosCondutor(registro));
            }

            return resultadoValidacao;
        }

        public override Condutor SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarCondutorPorId, ConverterEmClientePF, AdicionarParametro("ID", id));
        }

        public override List<Condutor> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodosCondutor, ConverterEmClientePF);
        }

        private Condutor ConverterEmClientePF(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string nome = Convert.ToString(reader["NOME"]);
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
            int idClienteCnpj = Convert.ToInt32(reader["IDCLIENTECNPJ"]);

            Condutor condutor = new Condutor(nome, endereco, email, cidade, estado, telefone, celular, rg, cpf, cnh, validadecnh, idClienteCnpj);

            condutor.Id = id;

            return condutor;
        }
        private Dictionary<string, object> ObtemParametrosCondutor(Condutor condutor)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", condutor.Id);
            parametros.Add("NOME", condutor.Nome);
            parametros.Add("ENDERECO", condutor.Endereco);
            parametros.Add("EMAIL", condutor.Email);
            parametros.Add("CIDADE", condutor.Cidade);
            parametros.Add("ESTADO", condutor.Estado);
            parametros.Add("TELEFONE", condutor.Telefone);
            parametros.Add("RG", condutor.Rg);
            parametros.Add("CPF", condutor.Cpf);
            parametros.Add("CNH", condutor.Cnh);
            parametros.Add("VALIDADECNH", condutor.ValidadeCnh);
            parametros.Add("IDCLIENTECNPJ", condutor.IdClienteCnpj);

            return parametros;
        }
    
    }
}
