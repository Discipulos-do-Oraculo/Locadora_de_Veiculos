using LocadoraVeiculo.Dominio.CupomModule;
using LocadoraVeiculos.Controlador.CupomModule;
using LocadoraVeiculos.WindowsForms.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.Features.MidiaModule
{
    public class OperacoesMidia : ICadastravel
    {
        private readonly ControladorMidia controlador = null;
        private TabelaMidiaControl tabelaMidia = null;

        public OperacoesMidia(ControladorMidia ctrl)
        {
            controlador = ctrl;
            tabelaMidia = new TabelaMidiaControl();
        }

        public void AgruparRegistros()
        {
            throw new NotImplementedException();
        }

        public void EditarRegistro()
        {
            int id = tabelaMidia.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um tipo de mídia para poder editar!", "Edição de Mídias",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Midia combustivelSelecionado = controlador.SelecionarPorId(id);

            TelaMidiaForm tela = new TelaMidiaForm();

            tela.Text = "Editar Mídia";

            tela.Midia = combustivelSelecionado;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, tela.Midia);

                List<Midia> combustiveis = controlador.SelecionarTodos();

                tabelaMidia.AtualizarRegistros(combustiveis);

                TelaInicial.Instancia.AtualizarRodape($"Mídia: [{tela.Midia.Nome}] editada com sucesso");
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
            TelaMidiaForm tela = new TelaMidiaForm();

            tela.Text = "Cadastrar Mídia";

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.Midia);

                List<Midia> combustiveis = controlador.SelecionarTodos();

                tabelaMidia.AtualizarRegistros(combustiveis);

                TelaInicial.Instancia.AtualizarRodape($"Mídia : [{tela.Midia.Nome}] inserida com sucesso");
            }
        }

        public UserControl ObterTabela()
        {
            List<Midia> combustiveis = controlador.SelecionarTodos();

            tabelaMidia.AtualizarRegistros(combustiveis);

            return tabelaMidia;
        }
        object ICadastravel.SelecionarRegistro()
        {
            int id = tabelaMidia.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um tipo de Mídia!", "Mídias",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            Midia midia = controlador.SelecionarPorId(id);

            return midia;
        }
    }
}
