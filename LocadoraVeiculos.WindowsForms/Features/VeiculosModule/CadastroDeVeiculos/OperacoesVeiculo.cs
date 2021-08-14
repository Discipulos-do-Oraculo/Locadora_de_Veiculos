using LocadoraVeiculo.Dominio.VeiculoModule;
using LocadoraVeiculos.Controlador.GrupoDeVeiculosModule;
using LocadoraVeiculos.Controlador.VeiculoModule;
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

        public OperacoesVeiculo(ControladorVeiculo ctrl)
        {
            controlador = ctrl;
            tabelaVeiculos = new TabelaVeiculoControl();
        }

        public void AgruparRegistros()
        {
            throw new NotImplementedException();
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

            tela.Veiculo = veiculoSelecionado;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, tela.Veiculo);

                List<Veiculo> veiculos = controlador.SelecionarTodos();

                tabelaVeiculos.AtualizarRegistros(veiculos);

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
                 controlador.Excluir(id);

                 List<Veiculo> veiculos = controlador.SelecionarTodos();

                tabelaVeiculos.AtualizarRegistros(veiculos);

                TelaInicial.Instancia.AtualizarRodape($"Veiculo: [{veiculoSelecionado.NomeVeiculo}] removido com sucesso");
            }
        }

        public void InserirNovoRegistro()
        {
            TelaCadastroDeVeiculo tela = new TelaCadastroDeVeiculo(controlador);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.Veiculo);

                List<Veiculo> veiculos = controlador.SelecionarTodos();

                tabelaVeiculos.AtualizarRegistros(veiculos);

                TelaInicial.Instancia.AtualizarRodape($"Veículo : [{tela.Veiculo.NomeVeiculo}] inserido com sucesso");
            }
        }

        public UserControl ObterTabela()
        {
            List<Veiculo> veiculos = controlador.SelecionarTodos();

            tabelaVeiculos.AtualizarRegistros(veiculos);

            return tabelaVeiculos;
        }
    }
}
