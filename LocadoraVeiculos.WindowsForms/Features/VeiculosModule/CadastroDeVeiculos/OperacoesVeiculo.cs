using LocadoraVeiculo.Dominio.VeiculoModule;
using LocadoraVeiculos.Controlador.GrupoDeVeiculosModule;
using LocadoraVeiculos.Controlador.VeiculoModule;
using LocadoraVeiculos.WindowsForms.Features.VeiculosModule.CadastroDeVeiculos;
using LocadoraVeiculos.WindowsForms.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.Features.Veiculos.CadastroDeVeiculos
{
    public class OperacoesVeiculo : ICadastravel
    {
        private readonly ControladorVeiculo controlador = null;
        private readonly ControladorGrupoDeVeiculos controladorGrupoDeVeiculos;
        private TabelaVeiculoControl tabelaVeiculos = null;
        Veiculo veiculoSelecionado = null;

        public Veiculo VeiculoSelecionado { get => veiculoSelecionado; set => veiculoSelecionado = value; }

        public OperacoesVeiculo(ControladorVeiculo ctrl)
        {
            controlador = ctrl;
            tabelaVeiculos = new TabelaVeiculoControl();
        }

        public void AgruparRegistros()
        {
            FiltroTabelaVeiculo telaAgrupamento = new FiltroTabelaVeiculo();

            if (telaAgrupamento.ShowDialog() == DialogResult.OK)
            {

                tabelaVeiculos.AgruparVeiculos(telaAgrupamento.TipoFiltro);

            }
        }

        public void FiltrarRegistros()
        {
            AgruparRegistros();
        }

        public void EditarRegistro()
        {
            int id = tabelaVeiculos.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um veículo para poder editar!", "Edição de Veículos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Veiculo veiculoSelecionado = controlador.SelecionarPorId(id);

            TelaCadastroDeVeiculo tela = new TelaCadastroDeVeiculo(controlador);

            tela.Text = "Editar Veículo";

            tela.Veiculo = veiculoSelecionado;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, tela.Veiculo);

                tabelaVeiculos.AtualizarRegistros();

                TelaInicial.Instancia.AtualizarRodape($"Veículo: [{tela.Veiculo.NomeVeiculo}] editado com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabelaVeiculos.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um veículo para poder excluir!", "Exclusão de Veículos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Veiculo veiculoSelecionado = controlador.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o veículo: [{veiculoSelecionado.NomeVeiculo}] ?",
                "Exclusão de Veículos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                if (controlador.TemLocacao(id))
                {
                    FechouLocacao(id, veiculoSelecionado);
                }
                else
                {
                    controlador.Excluir(id);

                    List<Veiculo> veiculos = controlador.SelecionarTodos();

                    tabelaVeiculos.AtualizarRegistros();

                    TelaInicial.Instancia.AtualizarRodape($"Veiculo: [{veiculoSelecionado.NomeVeiculo}] removido com sucesso");

                }
            }
        }

        private void FechouLocacao(int id, Veiculo veiculoSelecionado)
        {
            if (controlador.VerificaLocacaoFechada(id))
            {
                controlador.Excluir(id);

                List<Veiculo> veiculos = controlador.SelecionarTodos();

                tabelaVeiculos.AtualizarRegistros();

                TelaInicial.Instancia.AtualizarRodape($"Veiculo: [{veiculoSelecionado.NomeVeiculo}] removido com sucesso");
            }
            else
            {
                TelaInicial.Instancia.AtualizarRodape($"Não foi possível realizar a exclusão do Veiculo: [{veiculoSelecionado.NomeVeiculo}] pois ele esta presente em uma locação aberta");
            }
        }

        public void InserirNovoRegistro()
        {
            TelaCadastroDeVeiculo tela = new TelaCadastroDeVeiculo(controlador);

            tela.Text = "Cadastrar Veículo";

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.Veiculo);

                tabelaVeiculos.AtualizarRegistros();

                TelaInicial.Instancia.AtualizarRodape($"Veículo : [{tela.Veiculo.NomeVeiculo}] inserido com sucesso");
            }
        }

        public UserControl ObterTabela()
        {
            List<Veiculo> veiculos = controlador.SelecionarTodos();

            tabelaVeiculos.AtualizarRegistros();

            return tabelaVeiculos;
        }



        object ICadastravel.SelecionarRegistro()
        {
            int id = tabelaVeiculos.ObtemIdSelecionado();


            if (id == 0)
            {
                MessageBox.Show("Selecione um veículo para locar!", "Locação de Veículos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            veiculoSelecionado = controlador.SelecionarPorId(id);

            return veiculoSelecionado;
        }
    }
}
