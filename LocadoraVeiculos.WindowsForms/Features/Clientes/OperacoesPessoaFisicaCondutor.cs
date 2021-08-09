using LocadoraVeiculos.WindowsForms.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.Features.Clientes
{
    public class OperacoesPessoaFisicaCondutor : ICadastravel
    {
        //private readonly ControladorClienteCondutor controlador = null;
        private readonly TabelaClienteCondutorControl tabelaClienteCondutor = null;

        public OperacoesPessoaFisicaCondutor()
        {
            tabelaClienteCondutor = new TabelaClienteCondutorControl();
        }
        public void AgruparRegistros()
        {
            throw new NotImplementedException();
        }

        public void DesagruparRegistros()
        {
            throw new NotImplementedException();
        }

        public void EditarRegistro()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public UserControl ObterTabela()
        {
            throw new NotImplementedException();
        }
    }
}
