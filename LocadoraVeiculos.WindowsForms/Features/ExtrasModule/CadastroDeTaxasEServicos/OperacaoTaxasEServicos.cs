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
                MessageBox.Show("Selecione um grupo para poder editar!", "Edição de Grupo de Veículos",
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

                TelaInicial.Instancia.AtualizarRodape($"[{tela.TaxaEServico.Nome}] editado com sucesso");
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
            TelaTaxasServicos tela = new TelaTaxasServicos();

            tela.Text = "Cadastrar Taxas e Serviços";

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.TaxaEServico);

                List<TaxasEServicos> taxasServicos = controlador.SelecionarTodos();

                tabelaTaxasEServicos.AtualizarRegistros(taxasServicos);

                TelaInicial.Instancia.AtualizarRodape($"[{tela.TaxaEServico.Nome}] inserido com sucesso");
            }
        }

        public UserControl ObterTabela()
        {
            List<TaxasEServicos> taxasEServicos = controlador.SelecionarTodos();

            tabelaTaxasEServicos.AtualizarRegistros(taxasEServicos);

            return tabelaTaxasEServicos;
        }
    }
}
