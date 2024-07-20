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
    public partial class FormSolicitaAcesso : Form
    {
        internal DataGridView dgGridViewSelected;
        public FormSolicitaAcesso()
        {
            InitializeComponent();
        }

        private void FormSolicitaAcesso_Load(object sender, EventArgs e)
        {

        }

        public void AtualizaDataGridViewItensParaAvaliar(List<DataGridViewRow> lista)
        {
            foreach (DataGridViewRow row in lista)
            {
                dgvIntesParaAvaliacao.Rows.Add(
                        row.Cells[1].Value.ToString(),
                        row.Cells[2].Value.ToString(),
                        row.Cells[3].Value.ToString(),
                        row.Cells[4].Value.ToString()

                    );
            }

        }

        private void btnCancelarSolicitacao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviarSolicitacao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sucesso! Aguarde até que um avaliador analise seu pedido", "Solicitação envidada", MessageBoxButtons.OK);
            this.Close();

        }

        // Codigo necessario para mover o form sem a necessidade de ter borderstyle
        // ------------------------------------------------------------------------//
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;


        private void FormSolicitaAcesso_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void FormSolicitaAcesso_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void FormSolicitaAcesso_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        //------------------------------------------------------------------------------//

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
