using LocadoraVeiculo.Dominio.PlanoLocacaoModule;
using LocadoraVeiculos.Controlador.PlanoLocacaoModule;
using LocadoraVeiculos.WindowsForms.Features.Extras;
using LocadoraVeiculos.WindowsForms.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.Features.LocacaoModule.PlanosDeLocacao
{
    public class OperacoesPlanoDeLocacao : ICadastravel
    {
        private readonly ControladorPlanoLocacao controlador = null;
        private TabelaPlanosDeLocacaoControl tabelaPlanosLocacao = null;

        public OperacoesPlanoDeLocacao(ControladorPlanoLocacao ctrl)
        {
            controlador = ctrl;
            tabelaPlanosLocacao = new TabelaPlanosDeLocacaoControl();
        }

        public void AgruparRegistros()
        {
            throw new NotImplementedException();
        }

        public void EditarRegistro()
        {
            int id = tabelaPlanosLocacao.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um plano para poder editar!", "Edição de Planos de Locação",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            PlanoDeLocacao planoSelecionado = controlador.SelecionarPorId(id);

            TelaPlanosDeLocacaoForm tela = new TelaPlanosDeLocacaoForm();

            tela.Text = "Editar Combustível";

            tela.PlanoDeLocacao = planoSelecionado;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, tela.PlanoDeLocacao);

                List<PlanoDeLocacao> planos = controlador.SelecionarTodos();

                tabelaPlanosLocacao.AtualizarRegistros(planos);

                TelaInicial.Instancia.AtualizarRodape($"Plano de Locação: [{tela.PlanoDeLocacao.Titulo}] editado com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabelaPlanosLocacao.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um plano para poder excluir!", "Exclusão de Planos de Locação",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            PlanoDeLocacao planoSelecionado = controlador.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o plano: [{planoSelecionado.Titulo}] ?",
                "Exclusão de Planos de Locação", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                controlador.Excluir(id);

                List<PlanoDeLocacao> colaboradores = controlador.SelecionarTodos();

                tabelaPlanosLocacao.AtualizarRegistros(colaboradores);

                TelaInicial.Instancia.AtualizarRodape($"Plano de Locação: [{planoSelecionado.Titulo}] removido com sucesso");
            }
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }

        public void InserirNovoRegistro()
        {
            TelaPlanosDeLocacaoForm tela = new TelaPlanosDeLocacaoForm();

            tela.Text = "Cadastrar Plano de Locação";

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.PlanoDeLocacao);

                List<PlanoDeLocacao> combustiveis = controlador.SelecionarTodos();

                tabelaPlanosLocacao.AtualizarRegistros(combustiveis);

                TelaInicial.Instancia.AtualizarRodape($"Plano de Locação : [{tela.PlanoDeLocacao.Titulo}] inserido com sucesso");
            }
        }

        public UserControl ObterTabela()
        {
            List<PlanoDeLocacao> planos = controlador.SelecionarTodos();

            tabelaPlanosLocacao.AtualizarRegistros(planos);

            return tabelaPlanosLocacao;
        }
    
    }
}
