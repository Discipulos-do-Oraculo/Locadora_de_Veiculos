using LocadoraVeiculo.Dominio.DevolucaoModule;
using LocadoraVeiculo.Dominio.LocacaoModule;
using LocadoraVeiculo.Dominio.TaxasEServicosModule;
using LocadoraVeiculo.Dominio.VeiculoModule;
using LocadoraVeiculos.Controlador.DevolucaoModule;
using LocadoraVeiculos.Controlador.LocacaoModule;
using LocadoraVeiculos.Controlador.VeiculoModule;
using LocadoraVeiculos.WindowsForms.Shared;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.Features.DevolucaoModule
{
    public class OperacoesDevolucao : ICadastravel
    {
        private readonly ControladorDevolucao controlador = null;
        private readonly ControladorLocacaoTaxasEServicos controladorTaxasEServicos = null;
        private TabelaDevolucaoControl tabelaDevolucao = null;
        private List<TaxasEServicos> recebeTaxas = new List<TaxasEServicos>();
        private readonly ControladorLocacao controladorLocacao = null;
        public OperacoesDevolucao(ControladorDevolucao ctrl)
        {
            controlador = ctrl;
            controladorLocacao = new ControladorLocacao();
            controladorTaxasEServicos = new ControladorLocacaoTaxasEServicos();
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
            List<Locacao> locacaoAberta = controladorLocacao.SelecionarLocacoesAbertas();

            if (locacaoAberta.Count == 0)
            {
                TelaInicial.Instancia.AtualizarRodape($"Todas as Locações já estão fechadas");
            }
            else
            {
                FecharDevolucao();
            }

        }

        private void FecharDevolucao()
        {
            TelaDevolucaoForm tela = new TelaDevolucaoForm(controlador);

            tela.Text = "Fechar Devolução";


            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.Devolucao);

                ControladorVeiculo controladorVeiculo = new ControladorVeiculo();

                Veiculo veiculo = controladorVeiculo.SelecionarPorId(tela.Devolucao.Locacao.Veiculo.Id);

                veiculo.KmAtual += tela.Devolucao.KmFinal;

                controladorVeiculo.Editar(tela.Devolucao.Locacao.Veiculo.Id, veiculo);


                foreach (var taxasEServicos in tela.Taxas)
                {
                    LocacaoTaxasEServicos locacaoTaxasEServicos = new LocacaoTaxasEServicos(tela.Locacao, taxasEServicos);
                    if (recebeTaxas.Contains(taxasEServicos)) { }
                    else
                    {
                        controladorTaxasEServicos.InserirNovo(locacaoTaxasEServicos);
                    }
                }

                List<Devolucao> devolucoes = controlador.SelecionarTodos();

                tabelaDevolucao.AtualizarRegistros(devolucoes);

                TelaInicial.Instancia.AtualizarRodape($"Devolução: [{tela.Devolucao.Locacao.Condutor}] registrada com sucesso");
            }
        }

        public void PopulandoCheckListLocacoes(Locacao locacao)
        {
            recebeTaxas = controladorTaxasEServicos.SelecionarPorLocacao(locacao.Id);
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
