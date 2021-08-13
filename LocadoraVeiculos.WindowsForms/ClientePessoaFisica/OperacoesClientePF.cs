using LocadoraVeiculo.Dominio.ClienteModule;
using LocadoraVeiculos.Controlador.ClienteModule;
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
                MessageBox.Show("Selecione um cliente para poder editar!", "Edição de Clientes Físicos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ClientePF clienteSelecionado = controlador.SelecionarPorId(id);

            TelaClientePfForm tela = new TelaClientePfForm(controlador);

            tela.ClientePF = clienteSelecionado;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, tela.ClientePF);

                List<ClientePF> clientes = controlador.SelecionarTodos();

                tabelaClientes.AtualizarRegistros(clientes);

                TelaInicial.Instancia.AtualizarRodape($"Cliente: [{tela.ClientePF.Nome}] editado com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabelaClientes.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um cliente para poder excluir!", "Exclusão de Cliente Físico",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ClientePF clienteSelecionado = controlador.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o cliente: [{clienteSelecionado.Nome}] ?",
                "Exclusão de Cliente Físico", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                controlador.Excluir(id);

                List<ClientePF> clientes = controlador.SelecionarTodos();

                tabelaClientes.AtualizarRegistros(clientes);

                TelaInicial.Instancia.AtualizarRodape($"ClientePF: [{clienteSelecionado.Nome}] removido com sucesso");
            }
        }

        public void InserirNovoRegistro()
        {
            TelaClientePfForm tela = new TelaClientePfForm(controlador);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.ClientePF);

                List<ClientePF> clientes = controlador.SelecionarTodos();

                tabelaClientes.AtualizarRegistros(clientes);

                TelaInicial.Instancia.AtualizarRodape($"Cliente : [{tela.ClientePF.Nome}] inserido com sucesso");
            }
        }

        public UserControl ObterTabela()
        {
            List<ClientePF> clientes = controlador.SelecionarTodos();

            tabelaClientes.AtualizarRegistros(clientes);

            return tabelaClientes;
        }

    }
}
