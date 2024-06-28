using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStoreDesktop
{
    public partial class FormPesquisar : Form
    {
        public FormPesquisar()
        {
            InitializeComponent();

        }

        private void FormPesquisar_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btn_limpar_filtros_Click(object sender, EventArgs e)
        {
            this.txtboxServidor.Clear();
            this.txtboxDatabase.Clear();
            this.txtboxSchema.Clear();
            this.txtboxName.Clear();
            this.txtboxTipo.Clear();
            this.txtboxClasse.Clear();

        }

        private void btn_pesquisar_form_pesquisar_Click(object sender, EventArgs e)
        {

            this.dgvPesquisar.Rows.Add(false, "Local", "AdventureWorks1999", "product1", "tab_produtos", "tabela", "Produtos");
            this.dgvPesquisar.Rows.Add(false, "Local", "AdventureWorks1999", "product2", "tab_produtos", "tabela", "Produtos");
            this.dgvPesquisar.Rows.Add(false, "Local", "AdventureWorks1999", "product3", "tab_produtos", "tabela", "Produtos");

        }

        private void dgvPesquisar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            Int32 selectedCellCount = dgvPesquisar.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                var indice = dgvPesquisar.SelectedCells[0].RowIndex;
                this.lbInfoAdicional.Text = dgvPesquisar.Rows[dgvPesquisar.SelectedCells[0].RowIndex].Cells[4].Value.ToString();  
            }





        }
    }
}
