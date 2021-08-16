using LocadoraVeiculo.Dominio.GrupoDeVeiculosModule;
using LocadoraVeiculos.Controlador.GrupoDeVeiculosModule;
using LocadoraVeiculos.WindowsForms.Shared;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.Features.Veiculos
{
    public class OperacoesGrupoDeVeiculos : ICadastravel
    {
        private readonly ControladorGrupoDeVeiculos controlador = null;
        private TabelaGrupoVeiculosControl tabelaGrupoVeiculos = null;

        public OperacoesGrupoDeVeiculos(ControladorGrupoDeVeiculos ctrl)
        {
            controlador = ctrl;
            tabelaGrupoVeiculos = new TabelaGrupoVeiculosControl();
        }

        public void AgruparRegistros()
        {
            
        }

        public void EditarRegistro()
        {
            int id = tabelaGrupoVeiculos.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um grupo para poder editar!", "Edição de Grupo de Veículos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            GrupoDeVeiculos grupoSelecionado = controlador.SelecionarPorId(id);

            TelaGrupoVeiculoForm tela = new TelaGrupoVeiculoForm();

            tela.Text = "Editar Grupo de Veículos";

            tela.GrupoDeVeiculos = grupoSelecionado;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, tela.GrupoDeVeiculos);

                List<GrupoDeVeiculos> gruposDeVeiculos = controlador.SelecionarTodos();

                tabelaGrupoVeiculos.AtualizarRegistros(gruposDeVeiculos);

                TelaInicial.Instancia.AtualizarRodape($"Grupo de Veículos: [{tela.GrupoDeVeiculos.Nome}] editado com sucesso");
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
            TelaGrupoVeiculoForm tela = new TelaGrupoVeiculoForm();

            tela.Text = "Cadastrar Grupo de Veículos";

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.GrupoDeVeiculos);

                List<GrupoDeVeiculos> tarefas = controlador.SelecionarTodos();

                tabelaGrupoVeiculos.AtualizarRegistros(tarefas);

                TelaInicial.Instancia.AtualizarRodape($"Grupo de Veiculo : [{tela.GrupoDeVeiculos.Nome}] inserido com sucesso");
            }
        }

        public UserControl ObterTabela()
        {
            List<GrupoDeVeiculos> grupoDeVeiculos = controlador.SelecionarTodos();

            tabelaGrupoVeiculos.AtualizarRegistros(grupoDeVeiculos);

            return tabelaGrupoVeiculos;
        }
    }
}
