using LocadoraVeiculo.Dominio.ClienteModule;
using LocadoraVeiculos.Controlador.ClienteModule.ClienteCnpjControlador;
using LocadoraVeiculos.WindowsForms.Shared;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.Features.Clientes.ClienteCNPJ
{
    public class OperacoesClienteCnpj : ICadastravel
    {
        private readonly ControladorClienteCnpj controlador = null;
        private TabelaClienteCnpjControl tabelaClienteCnpj = null;

        public OperacoesClienteCnpj(ControladorClienteCnpj ctrl)
        {
            controlador = ctrl;
            tabelaClienteCnpj = new TabelaClienteCnpjControl();
        }

        public void AgruparRegistros()
        {
            throw new NotImplementedException();
        }

        public void EditarRegistro()
        {
            int id = tabelaClienteCnpj.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione uma pessoa jurídica para poder editar!", "Edição de Pessoa Jurídica",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ClienteCnpj clienteSelecionado = controlador.SelecionarPorId(id);

            TelaClienteCnpj tela = new TelaClienteCnpj(controlador);

            tela.Text = "Editar Pessoa Jurídica";

            tela.ClienteCnpj = clienteSelecionado;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, tela.ClienteCnpj);

                List<ClienteCnpj> clientes = controlador.SelecionarTodos();

                tabelaClienteCnpj.AtualizarRegistros(clientes);

                TelaInicial.Instancia.AtualizarRodape($"Pessoa Jurídica: [{tela.ClienteCnpj.Nome}] editado(a) com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabelaClienteCnpj.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione uma pessoa jurídica para poder excluir!", "Exclusão de Pessoa Jurídica",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ClienteCnpj clienteSelecionado = controlador.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir a pessoa jurídica: [{clienteSelecionado.Nome}] ?",
                "Exclusão de Pessoa Jurídica", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                controlador.Excluir(id);

                List<ClienteCnpj> clientes = controlador.SelecionarTodos();

                tabelaClienteCnpj.AtualizarRegistros(clientes);

                TelaInicial.Instancia.AtualizarRodape($"Pessoa Jurídica: [{clienteSelecionado.Nome}] removido(a) com sucesso");
            }
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }

        public void InserirNovoRegistro()
        {
            TelaClienteCnpj tela = new TelaClienteCnpj(controlador);

            tela.Text = "Cadastrar Pessoa Jurídica";

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.ClienteCnpj);

                List<ClienteCnpj> clientes = controlador.SelecionarTodos();

                tabelaClienteCnpj.AtualizarRegistros(clientes);

                TelaInicial.Instancia.AtualizarRodape($"Pessoa Jurídica: [{tela.ClienteCnpj.Nome}] cadastrado(a) com sucesso");
            }
        }

        public UserControl ObterTabela()
        {
            List<ClienteCnpj> clientes = controlador.SelecionarTodos();

            tabelaClienteCnpj.AtualizarRegistros(clientes);

            return tabelaClienteCnpj;
        }

        UserControl ICadastravel.ObterTabela()
        {
            List<ClienteCnpj> veiculos = controlador.SelecionarTodos();

            tabelaClienteCnpj.AtualizarRegistros(veiculos);

            return tabelaClienteCnpj;
        }
    }
}
