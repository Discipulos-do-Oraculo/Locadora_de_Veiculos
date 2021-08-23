using LocadoraVeiculo.Dominio.ClienteModule;
using LocadoraVeiculos.Controlador.ClienteModule.CondutorControlador;
using LocadoraVeiculos.WindowsForms.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.FuncionarioModule
{
    public class OperacoesFuncionario : ICadastravel
    {
        private readonly ControladorColaborador controlador = null;
        private TabelaFuncionarioControl tabelaClientes = null;

        public OperacoesFuncionario(ControladorColaborador ctrl)
        {
            controlador = ctrl;
            tabelaClientes = new TabelaFuncionarioControl();
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
                MessageBox.Show("Selecione um funcionário para poder editar!", "Edição de Funcionários",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Colaborador colaboradorSelecionado = controlador.SelecionarPorId(id);

            TelaFuncionarioForm tela = new TelaFuncionarioForm(controlador);

            tela.Colaborador = colaboradorSelecionado;
            tela.Text = "Editar Funcionário";

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, tela.Colaborador);

                List<Colaborador> colaboradores = controlador.SelecionarTodos();

                tabelaClientes.AtualizarRegistros(colaboradores);

                TelaInicial.Instancia.AtualizarRodape($"Funcionário: [{tela.Colaborador.Nome}] editado com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabelaClientes.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um funcionário para poder excluir!", "Exclusão de Funcionários",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Colaborador colaboradorSelecionado = controlador.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o funcionário: [{colaboradorSelecionado.Nome}] ?",
                "Exclusão de Funcionários", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                controlador.Excluir(id);

                List<Colaborador> colaboradores = controlador.SelecionarTodos();

                tabelaClientes.AtualizarRegistros(colaboradores);

                TelaInicial.Instancia.AtualizarRodape($"Funcionário: [{colaboradorSelecionado.Nome}] removido com sucesso");
            }
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }

        public void InserirNovoRegistro()
        {
            TelaFuncionarioForm tela = new TelaFuncionarioForm(controlador);

            tela.Text = "Cadastrar Funcionário";

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.Colaborador);

                List<Colaborador> colaboradors = controlador.SelecionarTodos();

                tabelaClientes.AtualizarRegistros(colaboradors);

                TelaInicial.Instancia.AtualizarRodape($"Funcionário : [{tela.Colaborador.Nome}] inserido com sucesso");
            }
        }

        public UserControl ObterTabela()
        {
            List<Colaborador> colaboradores = controlador.SelecionarTodos();

            tabelaClientes.AtualizarRegistros(colaboradores);

            return tabelaClientes;
        }

        public void SelecionarRegistro()
        {
            throw new NotImplementedException();
        }

        object ICadastravel.SelecionarRegistro()
        {
            throw new NotImplementedException();
        }
    }
}
