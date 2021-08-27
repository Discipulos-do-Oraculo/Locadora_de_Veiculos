using LocadoraVeiculo.Dominio.CupomModule;
using LocadoraVeiculos.Controlador.CupomModule;
using LocadoraVeiculos.WindowsForms.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.Features.ParceiroModule
{
    public class OperacoesParceiro : ICadastravel
    {
        private readonly ControladorParceiro controlador = null;
        private TabelaParceiroControl tabelaParceiro = null;

        public OperacoesParceiro(ControladorParceiro ctrl)
        {
            controlador = ctrl;
            tabelaParceiro = new TabelaParceiroControl();
        }

        public void AgruparRegistros()
        {
            throw new NotImplementedException();
        }

        public void EditarRegistro()
        {
            int id = tabelaParceiro.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um parceiro para poder editar!", "Edição de Parceiros",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Parceiro parceiroSelecionado = controlador.SelecionarPorId(id);

            TelaParceiroForm tela = new TelaParceiroForm();

            tela.Text = "Editar Parceiro";

            tela.Parceiro = parceiroSelecionado;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, tela.Parceiro);

                List<Parceiro> combustiveis = controlador.SelecionarTodos();

                tabelaParceiro.AtualizarRegistros(combustiveis);

                TelaInicial.Instancia.AtualizarRodape($"Parceiro(a): [{tela.Parceiro.Nome}] editado(a) com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabelaParceiro.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um parceiro para poder excluir!", "Exclusão de Parceiros",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Parceiro parceiroSelecionado = controlador.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o parceiro: [{parceiroSelecionado.Nome}] ?",
                "Exclusão de Parceiros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
               controlador.Excluir(id);

                    List<Parceiro> parceiros = controlador.SelecionarTodos();

                    tabelaParceiro.AtualizarRegistros(parceiros);

                    TelaInicial.Instancia.AtualizarRodape($"Parceiro(a): [{parceiroSelecionado.Nome}] removido(a) com sucesso");
            }
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }

        public void InserirNovoRegistro()
        {
            TelaParceiroForm tela = new TelaParceiroForm();

            tela.Text = "Cadastrar Parceiro";

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.Parceiro);

                List<Parceiro> combustiveis = controlador.SelecionarTodos();

                tabelaParceiro.AtualizarRegistros(combustiveis);

                TelaInicial.Instancia.AtualizarRodape($"Parceiro(a) : [{tela.Parceiro.Nome}] inserido(a) com sucesso");
            }
        }

        public UserControl ObterTabela()
        {
            List<Parceiro> parceiros = controlador.SelecionarTodos();

            tabelaParceiro.AtualizarRegistros(parceiros);

            return tabelaParceiro;
        }

        object ICadastravel.SelecionarRegistro()
        {
            int id = tabelaParceiro.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um parceiro(a)!", "Parcerias",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            Parceiro parceiro = controlador.SelecionarPorId(id);

            return parceiro;
        }
    
    }
}
