using LocadoraVeiculo.Dominio.ClienteModule;
using LocadoraVeiculos.Controlador.ClienteModule;
using LocadoraVeiculos.Controlador.ClienteModule.ClientePfControlador;
using LocadoraVeiculos.WindowsForms.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.ClientePessoaFisica
{
    public class OperacoesClientePF : ICadastravel
    {
        private readonly ControladorClientePF controlador = null;
        private TabelaClientePfControl tabelaClientes = null;

        public OperacoesClientePF(ControladorClientePF ctrl)
        {
            controlador = ctrl;
            tabelaClientes = new TabelaClientePfControl();
        }

        public void AgruparRegistros()
        {
            throw new NotImplementedException();
        }

        public void EditarRegistro()
        {
            int id = tabelaClientes.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione uma pessoa física para poder editar!", "Edição de Pessoa Física",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ClientePF clienteSelecionado = controlador.SelecionarPorId(id);

            TelaClientePfForm tela = new TelaClientePfForm(controlador);

            tela.Text = "Editar Pessoa Física";

            tela.ClientePF = clienteSelecionado;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, tela.ClientePF);

                List<ClientePF> clientes = controlador.SelecionarTodos();

                tabelaClientes.AtualizarRegistros(clientes);

                TelaInicial.Instancia.AtualizarRodape($"Pessoa Física: [{tela.ClientePF.Nome}] editado(a) com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabelaClientes.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione uma pessoa física para poder excluir!", "Exclusão de Pessoa Física",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ClientePF clienteSelecionado = controlador.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir a pessoa física: [{clienteSelecionado.Nome}] ?",
                "Exclusão de Pessoa Física", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (controlador.TemLocacao(id))
                {

                    FechouLocacao(id, clienteSelecionado);
                    
                }
                else
                {
                    controlador.Excluir(id);

                    List<ClientePF> clientes = controlador.SelecionarTodos();

                    tabelaClientes.AtualizarRegistros(clientes);

                    TelaInicial.Instancia.AtualizarRodape($"Pessoa Física: [{clienteSelecionado.Nome}] removido(a) com sucesso");
                }
            }
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }

        public void InserirNovoRegistro()
        {
            TelaClientePfForm tela = new TelaClientePfForm(controlador);

            tela.Text = "Cadastrar Pessoa Física";

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.ClientePF);

                List<ClientePF> clientes = controlador.SelecionarTodos();

                tabelaClientes.AtualizarRegistros(clientes);

                TelaInicial.Instancia.AtualizarRodape($"Pessoa Física: [{tela.ClientePF.Nome}] cadastrado(a) com sucesso");
            }
        }

        public UserControl ObterTabela()
        {
            List<ClientePF> clientes = controlador.SelecionarTodos();

            tabelaClientes.AtualizarRegistros(clientes);

            return tabelaClientes;
        }

        private void FechouLocacao(int id, ClientePF condutorSelecionado)
        {
            if (controlador.VerificaLocacaoFechada(id))
            {
                controlador.Excluir(id);

                List<ClientePF> condutores = controlador.SelecionarTodos();

                tabelaClientes.AtualizarRegistros(condutores);

                TelaInicial.Instancia.AtualizarRodape($"Pessoa Física: [{condutorSelecionado.Nome}] removido(a) com sucesso");
            }
            else
            {
                TelaInicial.Instancia.AtualizarRodape($"Não foi possível realizar a exclusão da Pessoa Física: [{condutorSelecionado.Nome}] pois ele(a) esta presente em uma locação aberta");
            }
        }


        object ICadastravel.SelecionarRegistro()
        {
            int id = tabelaClientes.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione uma pessoa para locar!", "Locação de Veículos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            ClientePF clientePF = controlador.SelecionarPorId(id);

            return clientePF;
        }
    }
}
