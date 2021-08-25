using LocadoraVeiculo.Dominio.DevolucaoModule;
using LocadoraVeiculos.Controlador.DevolucaoModule;
using LocadoraVeiculos.WindowsForms.Shared;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.Features.DevolucaoModule
{
    public class OperacoesDevolucao : ICadastravel
    {
        private readonly ControladorDevolucao controlador = null;
        private TabelaDevolucaoControl tabelaDevolucao = null;

        public OperacoesDevolucao(ControladorDevolucao ctrl)
        {
            controlador = ctrl;
            tabelaDevolucao = new TabelaDevolucaoControl();
        }

        public void AgruparRegistros()
        {
            throw new NotImplementedException();
        }

        public void EditarRegistro()
        {
            throw new NotImplementedException();
        }

        public void ExcluirRegistro()
        {
            throw new NotImplementedException();
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }

        public void InserirNovoRegistro()
        {
            TelaDevolucaoForm tela = new TelaDevolucaoForm(controlador);

            tela.Text = "Fechar Devolução";

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.Devolucao);

                List<Devolucao> devolucoes = controlador.SelecionarTodos();

                tabelaDevolucao.AtualizarRegistros(devolucoes);

                TelaInicial.Instancia.AtualizarRodape($"Devolução: [{tela.Devolucao.Locacao.Condutor}] registrada com sucesso");
            }
        }

        public UserControl ObterTabela()
        {
            List<Devolucao> devolucoes = controlador.SelecionarTodos();

            tabelaDevolucao.AtualizarRegistros(devolucoes);

            return tabelaDevolucao;
        }

        object ICadastravel.SelecionarRegistro()
        {
            int id = tabelaDevolucao.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione uma locação!", "Devolução de Veículos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            Devolucao devolucao = controlador.SelecionarPorId(id);

            return devolucao;
        }
    }
}
