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
        public DateTime dataSolicitacao { get; set; }
        public DateTime dataFinalizacaoAvaliacao { get; set; }
       

        public TabDocumento()
        {

            this.dataSolicitacao = DateTime.Now;
       


        }


    }
}
