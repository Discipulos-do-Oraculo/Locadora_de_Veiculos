using LocadoraVeiculo.Dominio.CupomModule;
using LocadoraVeiculo.Dominio.LocacaoModule;
using LocadoraVeiculo.Dominio.TaxasEServicosModule;
using LocadoraVeiculos.Controlador.LocacaoModule;
using LocadoraVeiculos.WindowsForms.Features.DevolucaoModule;
using LocadoraVeiculos.WindowsForms.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.Features.LocacaoModule.Abrir_Locacao
{
    public class OperacoesAbrirLocacao : ICadastravel
    {
        private readonly ControladorLocacao controlador = null;
        private readonly ControladorLocacaoTaxasEServicos controladorTaxasEServicos = null;
        private TabelaAbrirLocacaoControl tabelaAbrirLocacao = null;
        private Locacao locacaoSelecionada = null;
        public OperacoesAbrirLocacao(ControladorLocacao ctrl, ControladorLocacaoTaxasEServicos controladorLocacaoTaxasEServicos)
        {
            controlador = ctrl;
            controladorTaxasEServicos = controladorLocacaoTaxasEServicos;
            tabelaAbrirLocacao = new TabelaAbrirLocacaoControl();
        }

        public void AgruparRegistros()
        {
            FiltroLocacaoCupomForm telaAgrupamento = new FiltroLocacaoCupomForm();

            if (telaAgrupamento.ShowDialog() == DialogResult.OK)
            {

                tabelaAbrirLocacao.AgruparLocacoes(telaAgrupamento.TipoFiltro);

            }
        }

        public void EditarRegistro()
        {
            int id = tabelaAbrirLocacao.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione uma locação aberta para poder editar!", "Edição de Locação Aberta",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            locacaoSelecionada = controlador.SelecionarPorId(id);


            TelaAbrirLocacaoForm tela = new TelaAbrirLocacaoForm();

            tela.Text = "Editar Locação";

            List<TaxasEServicos> carregandoLista = controladorTaxasEServicos.SelecionarPorLocacao(id);
            tela.Taxas = carregandoLista;

            tela.Locacao = locacaoSelecionada;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, tela.Locacao);

                if (tela.Taxas != null)
                {
                    List<TaxasEServicos> recebeTaxas = new List<TaxasEServicos>();
                    recebeTaxas = controladorTaxasEServicos.SelecionarPorLocacao(tela.Locacao.Id);



                    foreach (var taxasEServicos in recebeTaxas)
                    {
                        if (tela.Taxas.Contains(taxasEServicos))
                        {
                            taxasEServicos.Valor = 0;
                        }
                        else
                        {
                            controladorTaxasEServicos.ExcluirPorIdLocacaoEIdTaxa(tela.Locacao.Id, taxasEServicos.Id);
                        }
                    }


                    foreach (var taxasEServicos in tela.Taxas)
                    {
                        LocacaoTaxasEServicos locacaoTaxasEServicos = new LocacaoTaxasEServicos(tela.Locacao, taxasEServicos);
                        if (recebeTaxas.Contains(taxasEServicos)) { }
                        else
                        {
                            controladorTaxasEServicos.InserirNovo(locacaoTaxasEServicos);
                        }

                    }
                }

                List<Locacao> locacoesAbertas = controlador.SelecionarLocacoesAbertas();

                tabelaAbrirLocacao.AtualizarRegistros(locacoesAbertas);

                TelaInicial.Instancia.AtualizarRodape($"Locação: [{tela.Locacao.Id}] editada com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            throw new NotImplementedException();
        }

        public void FiltrarRegistros()
        {
            AgruparRegistros();
        }

        public void InserirNovoRegistro()
        {
            TelaAbrirLocacaoForm tela = new TelaAbrirLocacaoForm();

            tela.Text = "Abrir Locação";

            if (tela.ShowDialog() == DialogResult.OK)
            {

                controlador.InserirNovo(tela.Locacao);

                if (tela.Taxas != null)
                {
                    foreach (var taxasEServicos in tela.Taxas)
                    {
                        LocacaoTaxasEServicos locacaoTaxasEServicos = new LocacaoTaxasEServicos(tela.Locacao, taxasEServicos);
                        controladorTaxasEServicos.InserirNovo(locacaoTaxasEServicos);
                    }
                }

                List<Locacao> locacoesAbertas = controlador.SelecionarLocacoesAbertas();

                tabelaAbrirLocacao.AtualizarRegistros(locacoesAbertas);

                TelaInicial.Instancia.AtualizarRodape($"Locação : [{tela.Locacao.Id}] cadastrada com sucesso");
            }
        }

       

        public UserControl ObterTabela()
        {
            List<Locacao> locacaoAberta = controlador.SelecionarLocacoesAbertas();

            tabelaAbrirLocacao.AtualizarRegistros(locacaoAberta);

            return tabelaAbrirLocacao;
        }

        public UserControl ObterTabelaLocacoesPendentes()
        {
            List<Locacao> locacaoAberta = controlador.SelecionarTodosPendentes();

            tabelaAbrirLocacao.AtualizarRegistros(locacaoAberta);

            return tabelaAbrirLocacao;
        }


        object ICadastravel.SelecionarRegistro()
        {
            int id = tabelaAbrirLocacao.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um condutor para locar!", "Locação de Veículos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            Locacao condutor = controlador.SelecionarPorId(id);

            return condutor;
        }
    }
}
