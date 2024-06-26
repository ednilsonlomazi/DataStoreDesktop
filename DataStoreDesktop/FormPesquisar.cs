﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

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
                var objeto = dgvPesquisar.Rows[dgvPesquisar.SelectedCells[0].RowIndex].Cells[4].Value.ToString();
                var schema = dgvPesquisar.Rows[dgvPesquisar.SelectedCells[0].RowIndex].Cells[3].Value.ToString();
                var banco = dgvPesquisar.Rows[dgvPesquisar.SelectedCells[0].RowIndex].Cells[2].Value.ToString();
                var servidor = dgvPesquisar.Rows[dgvPesquisar.SelectedCells[0].RowIndex].Cells[1].Value.ToString();
                this.lbInfoAdicional.Text = objeto + "\n" + schema + "\n" + banco + "\n" + servidor;
            }





        }

        private void btnSolicitarAcesso_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            List< DataGridViewRow > listadgv = new List< DataGridViewRow >();
            foreach (DataGridViewRow row in dgvPesquisar.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    listadgv.Add(
                        dgvPesquisar.Rows[row.Index]

                    );
                    // usse codigo sera usado futuramente quando estiver se
                    // comunicando com a WebApi via JSON
                    lista.Add(JsonSerializer.Serialize(new
                    {

                        index = row.Cells[0].RowIndex,
                        servidor = dgvPesquisar.Rows[row.Index].Cells[1].Value.ToString(),
                        banco = dgvPesquisar.Rows[row.Index].Cells[2].Value.ToString(),
                        schema = dgvPesquisar.Rows[row.Index].Cells[3].Value.ToString(),
                        objeto = dgvPesquisar.Rows[row.Index].Cells[4].Value.ToString()

                    }));


                }
            }
            if (lista.Count > 0)
            {
                FormSolicitaAcesso formSolicitaAcesso = new FormSolicitaAcesso();
                formSolicitaAcesso.AtualizaDataGridViewItensParaAvaliar(listadgv);
                formSolicitaAcesso.Show();
                
            }
            else
            {
                MessageBox.Show("Selecione ao menos um item para solicitar permissão", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnVerPrimeirasLinhas_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            foreach (DataGridViewRow row in dgvPesquisar.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {

                    // usse codigo sera usado futuramente quando estiver se
                    // comunicando com a WebApi via JSON
                    lista.Add(JsonSerializer.Serialize(new
                    {

                        index = row.Cells[0].RowIndex,
                        servidor = dgvPesquisar.Rows[row.Index].Cells[1].Value.ToString(),
                        banco = dgvPesquisar.Rows[row.Index].Cells[2].Value.ToString(),
                        schema = dgvPesquisar.Rows[row.Index].Cells[3].Value.ToString(),
                        objeto = dgvPesquisar.Rows[row.Index].Cells[4].Value.ToString()

                    }));


                }
            }
            if (lista.Count > 0)
            {
                MessageBox.Show("Legal, mas ainda estamos desenvolvendo isso.");
            }
            else
            {
                MessageBox.Show("Selecione ao menos um item para ver as primeiras linhas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        //private void btn_opcoes_Click(object sender, EventArgs e)
        //{
        //    List<string> lista = new List<string>();
        //    foreach (DataGridViewRow row in dgvPesquisar.Rows)
        //    {
        //        if (Convert.ToBoolean(row.Cells[0].Value))
        //        {


        //            lista.Add(JsonSerializer.Serialize(new{

        //                    index = row.Cells[0].RowIndex,
        //                    servidor = dgvPesquisar.Rows[row.Index].Cells[1].Value.ToString(),
        //                    banco = dgvPesquisar.Rows[row.Index].Cells[2].Value.ToString(),
        //                    schema = dgvPesquisar.Rows[row.Index].Cells[3].Value.ToString(),
        //                    objeto = dgvPesquisar.Rows[row.Index].Cells[4].Value.ToString()

        //            }));


        //        }
        //    }
        //    if (lista.Count > 0) 
        //    {
        //        foreach (string x in lista)
        //        {

        //        }
        //    }
        //}
    }
}
