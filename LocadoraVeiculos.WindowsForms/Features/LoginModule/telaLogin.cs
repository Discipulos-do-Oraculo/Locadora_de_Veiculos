using LocadoraVeiculo.Dominio.ClienteModule;
using LocadoraVeiculos.Controlador.ClienteModule.CondutorControlador;
using LocadoraVeiculos.WindowsForms.FuncionarioModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.Features.LoginModule
{
    public partial class telaLogin : Form
    {
        private readonly ControladorColaborador controlador;
        private Colaborador funcionario = null;
        private OperacoesFuncionario operacoes = null;

        public telaLogin()
        {
            InitializeComponent();          
            controlador = new ControladorColaborador();
            operacoes = new OperacoesFuncionario(controlador);
            PrimeiraUtilizacao();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(controlador.SelecionarTodos().Count != 0)
            {
                if (EhValido() && controlador.VerificaLogin(txtLogin.Text, txtSenha.Text))
                {
                    funcionario = controlador.SelecionarPorLogin(txtLogin.Text);
                    TelaInicial principal = new TelaInicial(funcionario);
                    this.Hide();
                    principal.ShowDialog();
                }
                else
                {
                    lblStatus.Text = "Login ou Senha inválidos";
                }
            }
            else
            {
                operacoes.InserirNovoRegistro();
                btnEntrar.Text = "Entrar";
                lblStatus.Text = "";
            }
            

        }

        private void PrimeiraUtilizacao()
        {
            List<Colaborador> colaboradores = controlador.SelecionarTodos();

            if (colaboradores.Count == 0)
            {
                lblStatus.Text = "Primeira utilização";
                btnEntrar.Text = "Cadastrar Usuário";
            }
            else
            {
                btnEntrar.Text = "Entrar";
                lblStatus.Text = "";
            }
        }

        private bool EhValido()
        {
            if (txtLogin.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Insira com um login valido.");
                return false;
            }
            else if (txtSenha.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Insira a senha correta!.");
                return false;
            }
            return true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
