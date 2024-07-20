using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class TabPermissao
    {

        public int codigoPermissao { set; get; }
        public string? descricaoPermissao { set; get; }
        public string? classePermissao { set; get; }

        public List<TabItemDocumento> tabItemDocumento { get; set; } = [];

    }
}
