using LocadoraVeiculos.WindowsForms.Features.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms
{
    public partial class TelaPrincipalForm : Form
    {
        public TelaPrincipalForm()
        {
            InitializeComponent();
        }

        private void pessoaFísicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaClienteCondutorForm form = new TelaClienteCondutorForm();
            form.ShowDialog();
        }
    }
}
