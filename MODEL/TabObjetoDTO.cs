using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class TabObjetoDTO
    {
        public string serverName { get; set; }
        public string? DatabaseName { get; set; }
        public string? desc_schema { get; set; }
        public string? ObjectName { get; set; }
        public string? descricaoTipoObjeto { get; set; }
        public string? classeObjeto { get; set; }
    }
}
