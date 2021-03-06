using LocadoraVeiculo.Dominio.VeiculoModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.Shared
{
    public interface ICadastravel
    {
        void InserirNovoRegistro();

        void EditarRegistro();

        object SelecionarRegistro();
      
        void ExcluirRegistro();

        UserControl ObterTabela();

        void AgruparRegistros();
        void FiltrarRegistros();
    }
}
