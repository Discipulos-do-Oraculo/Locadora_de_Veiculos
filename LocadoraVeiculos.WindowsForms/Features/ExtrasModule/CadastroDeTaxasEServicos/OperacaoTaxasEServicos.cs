using LocadoraVeiculo.Dominio.GrupoDeVeiculosModule;
using LocadoraVeiculo.Dominio.TaxasEServicosModule;
using LocadoraVeiculos.Controlador.TaxasEServicosModule;
using LocadoraVeiculos.WindowsForms.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.Features.Extras.CadastroDeTaxasEServicos
{
    public class OperacaoTaxasEServicos : ICadastravel
    {
        private readonly ControladorTaxasEServicos controlador = null;
        private TabelaTaxasEServicos tabelaTaxasEServicos = null;

        public OperacaoTaxasEServicos(ControladorTaxasEServicos ctrl)
        {
            controlador = ctrl;
            tabelaTaxasEServicos = new TabelaTaxasEServicos();
        }


        public void AgruparRegistros()
        {
            throw new NotImplementedException();
        }

        public void EditarRegistro()
        {
            int id = tabelaTaxasEServicos.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione uma taxa ou serviço para poder editar!", "Edição de Taxas e Serviços",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TaxasEServicos taxaEServicoSelecionado = controlador.SelecionarPorId(id);

            TelaTaxasServicos tela = new TelaTaxasServicos();

            tela.Text = "Editar Taxas e Serviços";

            tela.TaxaEServico = taxaEServicoSelecionado;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, tela.TaxaEServico);

                List<TaxasEServicos> taxasEServicos = controlador.SelecionarTodos();

                tabelaTaxasEServicos.AtualizarRegistros(taxasEServicos);

                TelaInicial.Instancia.AtualizarRodape($"Taxa/Serviço[{tela.TaxaEServico.Nome}] editado(a) com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabelaTaxasEServicos.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione uma taxa ou serviço para excluir!", "Exclusão de Taxas e Serviços",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TaxasEServicos taxaSelecionado = controlador.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir a Taxa/Serviço: [{taxaSelecionado.Nome}] ?",
                "Exclusão de Taxas ou Serviços", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                controlador.Excluir(id);

                List<TaxasEServicos> colaboradores = controlador.SelecionarTodos();

                tabelaTaxasEServicos.AtualizarRegistros(colaboradores);

                TelaInicial.Instancia.AtualizarRodape($"Taxa/Serviço: [{taxaSelecionado.Nome}] removido(a) com sucesso");
            }
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }

        public void InserirNovoRegistro()
        {
            TelaTaxasServicos tela = new TelaTaxasServicos();

            tela.Text = "Cadastrar Taxas e Serviços";

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.TaxaEServico);

                List<TaxasEServicos> taxasServicos = controlador.SelecionarTodos();

                tabelaTaxasEServicos.AtualizarRegistros(taxasServicos);

                TelaInicial.Instancia.AtualizarRodape($"Taxa/Serviço: [{tela.TaxaEServico.Nome}] cadastrado(a) com sucesso");
            }
        }

        public UserControl ObterTabela()
        {
            List<TaxasEServicos> taxasEServicos = controlador.SelecionarTodos();

            tabelaTaxasEServicos.AtualizarRegistros(taxasEServicos);

            return tabelaTaxasEServicos;
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
