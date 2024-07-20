using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MODEL
{
    public class TabDocumento
    {
        public int codigoDocumento { get; set; }
        public string idCliente { get; set; }
        public string? idAvaliador { get; set; }
        public int codigoStatusDocumento { get; set; }
        public TabStatusDocumento tabStatusDocumento { get; set; }
        public IdentityUser cliente { get; set; }
        public IdentityUser? avaliador { get; set; }
        public DateTime dataSolicitacao { get; set; }
        public DateTime dataFinalizacaoAvaliacao { get; set; }
        public List<TabItemDocumento> tabItemDocumento { get; set; } // foreigh key to item de documento

        public TabDocumento()
        {

            this.dataSolicitacao = DateTime.Now;
            this.tabItemDocumento = new List<TabItemDocumento>();


        }


    }
}
