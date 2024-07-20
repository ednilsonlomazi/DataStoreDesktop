using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormSobre : Form
    {
        public FormSobre()
        {
            InitializeComponent();
        }

        private void FormSolicitacoesRealizadas_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void dgvPesquisar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
