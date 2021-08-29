using LocadoraVeiculo.Dominio.CupomModule;
using LocadoraVeiculos.Controlador.CupomModule;
using LocadoraVeiculos.WindowsForms.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.Features.CupomModule
{
    public class OperacoesCupom : ICadastravel
    {
        private readonly ControladorCupom controlador = null;
        private TabelaCupomControl tabelaCupom = null;

        public OperacoesCupom(ControladorCupom ctrl)
        {
            controlador = ctrl;
            tabelaCupom = new TabelaCupomControl(controlador);
        }

        public void AgruparRegistros()
        {
            FiltroCupomForm telaAgrupamento = new FiltroCupomForm();

            if (telaAgrupamento.ShowDialog() == DialogResult.OK)
                tabelaCupom.AgruparVeiculos(telaAgrupamento.TipoFiltro);
        }

        public void EditarRegistro()
        {
            int id = tabelaCupom.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um cupom para poder editar!", "Edição de Cupons",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Cupom condutorSelecionado = controlador.SelecionarPorId(id);

            TelaCupomForm tela = new TelaCupomForm();

            tela.Cupom = condutorSelecionado;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, tela.Cupom);

                tabelaCupom.AtualizarRegistros();

                TelaInicial.Instancia.AtualizarRodape($"Cupom: [{tela.Cupom.Nome}] editado com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabelaCupom.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um cupom para poder excluir!", "Exclusão de Cupons",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Cupom cupomSelecionado = controlador.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o cupom: [{cupomSelecionado.Nome}] ?",
                "Exclusão de Cupons", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                //if (controlador.TemLocacao(id))
                //{
                //    FechouLocacao(id, cupomSelecionado);
                //}
                //else
                //{
                    controlador.Excluir(id);

                    List<Cupom> condutores = controlador.SelecionarTodos();

                    tabelaCupom.AtualizarRegistros();

                    TelaInicial.Instancia.AtualizarRodape($"Cupom: [{cupomSelecionado.Nome}] removido com sucesso");

                //}
            }
        }


        //private void FechouLocacao(int id, Cupom condutorSelecionado)
        //{
        //    if (controlador.VerificaLocacaoFechada(id))
        //    {
        //        controlador.Excluir(id);

        //        List<Cupom> condutores = controlador.SelecionarTodos();

        //        tabelaCupom.AtualizarRegistros();

        //        TelaInicial.Instancia.AtualizarRodape($"Cupom: [{condutorSelecionado.Nome}] removido com sucesso");
        //    }
        //    else
        //    {
        //        TelaInicial.Instancia.AtualizarRodape($"Não foi possível realizar a exclusão do Cupom: [{condutorSelecionado.Nome}] pois ele esta presente em uma locação aberta");
        //    }
        //}

        public void FiltrarRegistros()
        {
            AgruparRegistros();
        }

        public void InserirNovoRegistro()
        {
            TelaCupomForm tela = new TelaCupomForm();

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.Cupom);

                tabelaCupom.AtualizarRegistros();

                TelaInicial.Instancia.AtualizarRodape($"Cupom : [{tela.Cupom.Nome}] inserido com sucesso");
            }
        }

        public UserControl ObterTabela()
        {

            tabelaCupom.AtualizarRegistros();

            return tabelaCupom;
        }

        public UserControl ObterTabelaFiltradaPorEmpresa(int id)
        {

            tabelaCupom.CarregarRegistrosPorEmpresa(id);

            return tabelaCupom;
        }

        public object SelecionarRegistro()
        {
            int id = tabelaCupom.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um cupom!", "Cupons",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            Cupom condutor = controlador.SelecionarPorId(id);

            return condutor;
        }

    }
}
