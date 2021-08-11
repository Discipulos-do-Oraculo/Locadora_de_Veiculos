using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.WindowsForms.Shared
{
    public class ConfigurarBotoes
    {

        public ConfigurarBotoes()
        {
            Adicionar = true;
            Editar = true;
            Excluir = true;
        }

        public bool Adicionar { get; internal set; }
        public bool Editar { get; internal set; }
        public bool Excluir { get; internal set; }
        public bool Filtrar { get; internal set; }
        public bool Agrupar { get; internal set; }
    }
}
