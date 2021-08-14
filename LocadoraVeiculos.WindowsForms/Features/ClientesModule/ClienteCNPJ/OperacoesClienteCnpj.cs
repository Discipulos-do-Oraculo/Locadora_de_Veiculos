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
                MessageBox.Show("Selecione um cliente para poder editar!", "Edição de Cliente Jurídico",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ClienteCnpj clienteSelecionado = controlador.SelecionarPorId(id);

            TelaClienteCnpj tela = new TelaClienteCnpj();

            tela.ClienteCnpj = clienteSelecionado;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, tela.ClienteCnpj);

                List<ClienteCnpj> clientes = controlador.SelecionarTodos();

                tabelaClienteCnpj.AtualizarRegistros(clientes);

                TelaInicial.Instancia.AtualizarRodape($"Cliente: [{tela.ClienteCnpj.Nome}] editado com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabelaClienteCnpj.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um cliente para poder excluir!", "Exclusão de Cliente Jurídico",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ClienteCnpj clienteSelecionado = controlador.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o cliente: [{clienteSelecionado.Nome}] ?",
                "Exclusão de Cliente Jurídico", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                controlador.Excluir(id);

                List<ClienteCnpj> clientes = controlador.SelecionarTodos();

                tabelaClienteCnpj.AtualizarRegistros(clientes);

                TelaInicial.Instancia.AtualizarRodape($"Cliente: [{clienteSelecionado.Nome}] removido com sucesso");
            }
        }

        public void InserirNovoRegistro()
        {
            TelaClienteCnpj tela = new TelaClienteCnpj();

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.ClienteCnpj);

                List<ClienteCnpj> clientes = controlador.SelecionarTodos();

                tabelaClienteCnpj.AtualizarRegistros(clientes);

                TelaInicial.Instancia.AtualizarRodape($"Cliente : [{tela.ClienteCnpj.Nome}] inserido com sucesso");
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
