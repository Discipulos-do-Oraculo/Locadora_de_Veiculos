using LocadoraVeiculo.Dominio.LocacaoModule;
using LocadoraVeiculos.Controlador.LocacaoModule;
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


        public OperacoesAbrirLocacao(ControladorLocacao ctrl,ControladorLocacaoTaxasEServicos controladorLocacaoTaxasEServicos)
        {
            controlador = ctrl;
            controladorTaxasEServicos = controladorLocacaoTaxasEServicos;
            tabelaAbrirLocacao = new TabelaAbrirLocacaoControl();
        }

        public void AgruparRegistros()
        {
            throw new NotImplementedException();
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

            Locacao locacaoSelecionada = controlador.SelecionarPorId(id);

            TelaAbrirLocacaoForm tela = new TelaAbrirLocacaoForm();

            tela.Text = "Editar Locação";

            tela.Locacao = locacaoSelecionada;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, tela.Locacao);

                List<Locacao> locacoesAbertas = controlador.SelecionarTodos();

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
            throw new NotImplementedException();
        }

        public void InserirNovoRegistro()
        {
            TelaAbrirLocacaoForm tela = new TelaAbrirLocacaoForm();

            tela.Text = "Abrir Locação";

            if (tela.ShowDialog() == DialogResult.OK)
            {

                controlador.InserirNovo(tela.Locacao);


                foreach (var taxasEServicos in tela.Taxas)
                {
                    LocacaoTaxasEServicos locacaoTaxasEServicos = new LocacaoTaxasEServicos(tela.Locacao, taxasEServicos);
                    controladorTaxasEServicos.InserirNovo(locacaoTaxasEServicos);
                }



                List<Locacao> locacoesAbertas = controlador.SelecionarTodos();

                tabelaAbrirLocacao.AtualizarRegistros(locacoesAbertas);

                TelaInicial.Instancia.AtualizarRodape($"Locação : [{tela.Locacao.Id}] cadastrada com sucesso");
            }
        }

        private void PopulandoTabelaLocacaoTaxasEServicos(TelaAbrirLocacaoForm tela,Locacao locacao)
        {
            
        }

        public UserControl ObterTabela()
        {
            List<Locacao> locacaoAberta = controlador.SelecionarTodos();

            tabelaAbrirLocacao.AtualizarRegistros(locacaoAberta);

            return tabelaAbrirLocacao;
        }


        object ICadastravel.SelecionarRegistro()
        {
            throw new NotImplementedException();
        }
    }
}
