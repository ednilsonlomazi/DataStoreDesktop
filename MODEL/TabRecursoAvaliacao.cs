using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class TabRecursoAvaliacao
    {

        public int codigoRecursoAvaliacao { get; set; }
        public int codigoAvaliacao { get; set; }
        public string descricaoRecurso { get; set; }
        public DateTime dtaAberturaRecurso { get; set; }
        public DateTime dtaAnaliseRecurso { get; set; }
        public bool analiseRecurso { get; set; }

        public TabRecursoAvaliacao()
        {
            this.dtaAberturaRecurso = DateTime.Now;
        }
    }
}
