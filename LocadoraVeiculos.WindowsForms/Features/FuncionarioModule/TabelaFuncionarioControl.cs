﻿using LocadoraVeiculo.Dominio.ClienteModule;
using LocadoraVeiculos.WindowsForms.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.FuncionarioModule
{
    public partial class TabelaFuncionarioControl : UserControl
    {
        public TabelaFuncionarioControl()
        {
            InitializeComponent();
            gridFuncionarios.ConfigurarGridZebrado();
            gridFuncionarios.ConfigurarGridSomenteLeitura();
            gridFuncionarios.Columns.AddRange(ObterColunas());
        }

        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},

                new DataGridViewTextBoxColumn { DataPropertyName = "DataEntrada", HeaderText = "Data de Entrada"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Salario", HeaderText = "Salário"},
            };

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return gridFuncionarios.SelecionarId<int>();
        }

        public void AtualizarRegistros(List<Colaborador> funcionarios)
        {
            gridFuncionarios.Rows.Clear();

            foreach (Colaborador funcionario in funcionarios)
            {
                gridFuncionarios.Rows.Add(funcionario.Id, funcionario.Nome, funcionario.DataEntrada, funcionario.Salario);

            }
        }
    }
}
