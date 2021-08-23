using LocadoraVeiculo.Dominio.ClienteModule;
using LocadoraVeiculos.Controlador.ClienteModule.CondutorControlador;
using LocadoraVeiculos.WindowsForms.Features.CondutorModule;
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
        private TabelaCondutorControl tabelaCondutor = null;

        public OperacaoCondutor(ControladorCondutor ctrl)
        {
            controlador = ctrl;
            tabelaCondutor = new TabelaCondutorControl(controlador);
        }

        public void AgruparRegistros()
        {
            FIltroTabelaCondutor telaAgrupamento = new FIltroTabelaCondutor();

            if (telaAgrupamento.ShowDialog() == DialogResult.OK)
            {

                tabelaCondutor.AgruparVeiculos(telaAgrupamento.TipoFiltro);

            }
        }

        public void EditarRegistro()
        {
            int id = tabelaCondutor.ObtemIdSelecionado();

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

                tabelaCondutor.AtualizarRegistros();

                TelaInicial.Instancia.AtualizarRodape($"Condutor: [{tela.Condutor.Nome}] editado com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabelaCondutor.ObtemIdSelecionado();

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

                tabelaCondutor.AtualizarRegistros();

                TelaInicial.Instancia.AtualizarRodape($"Condutor: [{condutorSelecionado.Nome}] removido com sucesso");
            }
        }

        public void FiltrarRegistros()
        {
            AgruparRegistros();
        }

        public void InserirNovoRegistro()
        {
            TelaCondutorForm tela = new TelaCondutorForm(controlador);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.Condutor);

                tabelaCondutor.AtualizarRegistros();

                TelaInicial.Instancia.AtualizarRodape($"Condutor : [{tela.Condutor.Nome}] inserido com sucesso");
            }
        }

        public UserControl ObterTabela()
        {

            tabelaCondutor.AtualizarRegistros();

            return tabelaCondutor;
        }

        public UserControl ObterTabelaFiltradaPorEmpresa(int id)
        {

            tabelaCondutor.CarregarRegistrosPorEmpresa(id);

            return tabelaCondutor;
        }

        public object SelecionarRegistro()
        {
            int id = tabelaCondutor.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um condutor para locar!", "Locação de Veículos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            Condutor condutor = controlador.SelecionarPorId(id);

            return condutor;
        }
    }
}
