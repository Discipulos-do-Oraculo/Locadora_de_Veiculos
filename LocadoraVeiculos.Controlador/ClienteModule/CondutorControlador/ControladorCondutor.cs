﻿using LocadoraVeiculo.Dominio.ClienteModule;
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
                    [VALIDADECNH],     
                    [IDCLIENTECNPJ]
                         
                )
                VALUES
                (
                    @NOMECONDUTOR,
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
                    [NOMECONDUTOR] = @NOMECONDUTOR,        
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
                    [TBCONDUTOR].NOMECONDUTOR,        
                    [TBCONDUTOR].ENDERECO,            
                    [TBCONDUTOR].EMAIL,           
                    [TBCONDUTOR].CELULAR,     
                    [TBCONDUTOR].ESTADO,  
                    [TBCONDUTOR].CIDADE, 
                    [TBCONDUTOR].TELEFONE,            
                    [TBCONDUTOR].CELULAR,         
                    [TBCONDUTOR].RG,          
                    [TBCONDUTOR].CPF,   
                    [TBCONDUTOR].CNH,          
                    [TBCONDUTOR].VALIDADECNH,
                    [TBCONDUTOR].IDCLIENTECNPJ,
                    [TBCLIENTEPJ].NOME
            FROM
                    [TBCONDUTOR] INNER JOIN
                    [TBCLIENTEPJ]
            
            ON
                    [TBCONDUTOR].IDCLIENTECNPJ = [TBCLIENTEPJ].ID";

        private const string sqlSelecionarCondutorPorId =
            @"SELECT 
                    [TBCONDUTOR].ID,
                    [TBCONDUTOR].NOMECONDUTOR,        
                    [TBCONDUTOR].ENDERECO,            
                    [TBCONDUTOR].EMAIL,           
                    [TBCONDUTOR].CELULAR,
                    [TBCONDUTOR].CIDADE, 
                    [TBCONDUTOR].ESTADO,   
                    [TBCONDUTOR].TELEFONE,            
                    [TBCONDUTOR].CELULAR,         
                    [TBCONDUTOR].RG,          
                    [TBCONDUTOR].CPF,   
                    [TBCONDUTOR].CNH,          
                    [TBCONDUTOR].VALIDADECNH,
                    [TBCONDUTOR].IDCLIENTECNPJ,
                    [TBCLIENTEPJ].NOME
       
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



        public override string Editar(int id, Condutor registro)
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
                    registro.Id = id;
                    Db.Update(sqlEditarCondutor, ObtemParametrosCondutor(registro));
                }
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

                    registro.Id = Db.Insert(sqlInserirCondutor, ObtemParametrosCondutor(registro));
                }
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

        private Condutor ConverterEmClientePF(IDataReader reader)
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
            int idClienteCnpj = Convert.ToInt32(reader["IDCLIENTECNPJ"]);

            var nomeEmpresa = Convert.ToString(reader["NOME"]);

            ClienteCnpj empresa = new ClienteCnpj(nomeEmpresa);
            empresa.Id = idClienteCnpj;

            Condutor condutor = new Condutor(nome, endereco, email, cidade, estado, telefone, celular, rg, cpf, cnh, validadecnh, empresa);
            condutor.Id = Convert.ToInt32(reader["ID"]);

            return condutor;
        }
        private Dictionary<string, object> ObtemParametrosCondutor(Condutor condutor)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", condutor.Id);
            parametros.Add("NOMECONDUTOR", condutor.Nome);
            parametros.Add("ENDERECO", condutor.Endereco);
            parametros.Add("EMAIL", condutor.Email);
            parametros.Add("CIDADE", condutor.Cidade);
            parametros.Add("ESTADO", condutor.Estado);
            parametros.Add("CELULAR", condutor.Celular);
            parametros.Add("TELEFONE", condutor.Telefone);
            parametros.Add("RG", condutor.Rg);
            parametros.Add("CPF", condutor.Cpf);
            parametros.Add("CNH", condutor.Cnh);
            parametros.Add("VALIDADECNH", condutor.ValidadeCnh);
            parametros.Add("IDCLIENTECNPJ", condutor.ClienteCnpj.Id);

            return parametros;
        }

    }
}