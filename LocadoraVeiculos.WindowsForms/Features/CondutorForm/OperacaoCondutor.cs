using LocadoraVeiculo.Dominio.ClienteModule;
using LocadoraVeiculos.Controlador.ClienteModule.CondutorControlador;
using LocadoraVeiculos.WindowsForms.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.Features.CondutorForm
{
    public class OperacaoCondutor : ICadastravel
    {
        private readonly ControladorCondutor controlador = null;
        private TabelaCondutorControl tabelaClientes = null;

        public OperacaoCondutor(ControladorCondutor ctrl)
        {
            controlador = ctrl;
            tabelaClientes = new TabelaCondutorControl();
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
                MessageBox.Show("Selecione um condutor para poder editar!", "Edição de Condutores",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Condutor condutorSelecionado = controlador.SelecionarPorId(id);

            TelaCondutorForm tela = new TelaCondutorForm(controlador);

            tela.Condutor = condutorSelecionado;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, tela.Condutor);

                List<Condutor> condutores = controlador.SelecionarTodos();

                tabelaClientes.AtualizarRegistros(condutores);

                TelaInicial.Instancia.AtualizarRodape($"Condutor: [{tela.Condutor.Nome}] editado com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabelaClientes.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um condutor para poder excluir!", "Exclusão de Condutores",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Condutor condutorSelecionado = controlador.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o condutor: [{condutorSelecionado.Nome}] ?",
                "Exclusão de Condutores", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                controlador.Excluir(id);

                List<Condutor> condutores = controlador.SelecionarTodos();

                tabelaClientes.AtualizarRegistros(condutores);

                TelaInicial.Instancia.AtualizarRodape($"Condutor: [{condutorSelecionado.Nome}] removido com sucesso");
            }
        }

        public void InserirNovoRegistro()
        {
            TelaCondutorForm tela = new TelaCondutorForm(controlador);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.Condutor);

                List<Condutor> condutores = controlador.SelecionarTodos();

                tabelaClientes.AtualizarRegistros(condutores);

                TelaInicial.Instancia.AtualizarRodape($"Condutor : [{tela.Condutor.Nome}] inserido com sucesso");
            }
        }

        public UserControl ObterTabela()
        {
            List<Condutor> condutores = controlador.SelecionarTodos();

            tabelaClientes.AtualizarRegistros(condutores);

            return tabelaClientes;
        }
   
    }
}
