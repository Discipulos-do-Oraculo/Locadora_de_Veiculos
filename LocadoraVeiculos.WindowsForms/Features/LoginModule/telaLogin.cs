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
        public telaLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            if (EhValido())
            {
                using (SqlConnection conectar = new SqlConnection(@"D:\Academia\RechACar\LocadoraVeiculos.WindowsForms\Features\LoginModule\DBLogin.mdf"))
                {
                    string query = "SELECT * FROM TBLogin WHERE login = ' " + txtLogin.Text.Trim() +
                     "' AND Password = '" + txtSenha.Text.Trim() + " ' ";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conectar);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    if (tabela.Rows.Count == 1)
                    {
                        TelaInicial principal = new TelaInicial();
                        this.Hide();
                        principal.Show();
                    }

                }

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
            return false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
