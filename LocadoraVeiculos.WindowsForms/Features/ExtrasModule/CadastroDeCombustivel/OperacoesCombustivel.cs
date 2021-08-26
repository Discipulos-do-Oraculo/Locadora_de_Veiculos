using LocadoraVeiculo.Dominio.CombustivelModule;
using LocadoraVeiculos.Controlador.GasolinaModule;
using LocadoraVeiculos.WindowsForms.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.Features.Extras.CadastroDeCombustivel
{
    public class OperacoesCombustivel : ICadastravel
    {
        private readonly ControladorCombustivel controlador = null;
        private TabelaCombustivelControl tabelaCombustivel = null;

        public OperacoesCombustivel(ControladorCombustivel ctrl)
        {
            controlador = ctrl;
            tabelaCombustivel = new TabelaCombustivelControl();
        }

        public void AgruparRegistros()
        {
            throw new NotImplementedException();
        }

        public void EditarRegistro()
        {
            int id = tabelaCombustivel.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um grupo para poder editar!", "Edição de Grupo de Veículos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Combustivel combustivelSelecionado = controlador.SelecionarPorId(id);

            TelaCombustivel tela = new TelaCombustivel();

            tela.Text = "Editar Combustível";

            tela.Combustivel = combustivelSelecionado;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, tela.Combustivel);

                List<Combustivel> combustiveis = controlador.SelecionarTodos();

                tabelaCombustivel.AtualizarRegistros(combustiveis);

                TelaInicial.Instancia.AtualizarRodape($"Combustível: [{tela.Combustivel.Nome}] editado com sucesso");
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
            TelaCombustivel tela = new TelaCombustivel();

            tela.Text = "Cadastrar Combustível";

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.Combustivel);

                List<Combustivel> combustiveis = controlador.SelecionarTodos();

                tabelaCombustivel.AtualizarRegistros(combustiveis);

                TelaInicial.Instancia.AtualizarRodape($"Combustível : [{tela.Combustivel.Nome}] inserido com sucesso");
            }
        }

        public UserControl ObterTabela()
        {
            List<Combustivel> combustiveis = controlador.SelecionarTodos();

            tabelaCombustivel.AtualizarRegistros(combustiveis);

            return tabelaCombustivel;
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
