﻿using LocadoraVeiculos.Controlador.ClienteModule.ClienteCnpjControlador;
using LocadoraVeiculos.WindowsForms.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.Features.Clientes.ClienteCNPJ
{
    public class OperacoesClienteCnpj : ICadastravel
    {
        private readonly ControladorClienteCnpj controlador = null;

        //public OperacoesGrupoDeVeiculos(ControladorGrupoDeVeiculos ctrl)
        //{
        //    controlador = ctrl;
        //    tabelaGrupoVeiculos = new TabelaGrupoVeiculosControl();
        //}

        //public void AgruparRegistros()
        //{
        //    throw new NotImplementedException();
        //}

        //public void EditarRegistro()
        //{
        //    int id = tabelaGrupoVeiculos.ObtemIdSelecionado();

        //    if (id == 0)
        //    {
        //        MessageBox.Show("Selecione um grupo para poder editar!", "Edição de Grupo de Veículos",
        //            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        return;
        //    }

        //    GrupoDeVeiculos grupoSelecionado = controlador.SelecionarPorId(id);

        //    TelaGrupoVeiculoForm tela = new TelaGrupoVeiculoForm();

        //    tela.GrupoDeVeiculos = grupoSelecionado;

        //    if (tela.ShowDialog() == DialogResult.OK)
        //    {
        //        controlador.Editar(id, tela.GrupoDeVeiculos);

        //        List<GrupoDeVeiculos> gruposDeVeiculos = controlador.SelecionarTodos();

        //        tabelaGrupoVeiculos.AtualizarRegistros(gruposDeVeiculos);

        //        TelaInicial.Instancia.AtualizarRodape($"Grupo de Veículos: [{tela.GrupoDeVeiculos.Nome}] editado com sucesso");
        //    }
        //}

        //public void ExcluirRegistro()
        //{
        //    throw new NotImplementedException();
        //}

        //public void InserirNovoRegistro()
        //{
        //    TelaGrupoVeiculoForm tela = new TelaGrupoVeiculoForm();

        //    if (tela.ShowDialog() == DialogResult.OK)
        //    {
        //        controlador.InserirNovo(tela.GrupoDeVeiculos);

        //        List<GrupoDeVeiculos> tarefas = controlador.SelecionarTodos();

        //        tabelaGrupoVeiculos.AtualizarRegistros(tarefas);

        //        TelaInicial.Instancia.AtualizarRodape($"Grupo de Veiculo : [{tela.GrupoDeVeiculos.Nome}] inserido com sucesso");
        //    }
        //}

        //public UserControl ObterTabela()
        //{
        //    List<GrupoDeVeiculos> grupoDeVeiculos = controlador.SelecionarTodos();

        //    tabelaGrupoVeiculos.AtualizarRegistros(grupoDeVeiculos);

        //    return tabelaGrupoVeiculos;
        //}

        //UserControl ICadastravel.ObterTabela()
        //{
        //    throw new NotImplementedException();
        //}
    }
}