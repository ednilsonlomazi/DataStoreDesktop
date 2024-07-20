using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class TabClasseObjeto
    {

        public int IdClasse { get; set; }
        public string DescricaoClasse { get; set; }
        public DateTime dtaCriacao { get; set; }
        public int indAtivo { get; set; }
        public List<TabObjeto> tabObjeto { get; set; }

        public TabClasseObjeto()
        {
            this.tabObjeto = new List<TabObjeto>();
            this.dtaCriacao = DateTime.Now;
            this.indAtivo = 1;
        }
    }
}
