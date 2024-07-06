namespace DataStoreDesktop
{
    partial class FormSolicitaAcesso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            cbSelect = new CheckBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            label2 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            btnEnviarSolicitacao = new Button();
            btnCancelarSolicitacao = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            btn_sair = new Button();
            dgvIntesParaAvaliacao = new DataGridView();
            Servidor = new DataGridViewTextBoxColumn();
            Database = new DataGridViewTextBoxColumn();
            Schema = new DataGridViewTextBoxColumn();
            Objeto = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIntesParaAvaliacao).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 24, 29);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 28);
            panel1.Margin = new Padding(0, 3, 0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 67);
            panel1.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(cbSelect, 0, 0);
            tableLayoutPanel1.Controls.Add(checkBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(checkBox2, 2, 0);
            tableLayoutPanel1.Controls.Add(checkBox3, 3, 0);
            tableLayoutPanel1.Location = new Point(0, 26);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(400, 24);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // cbSelect
            // 
            cbSelect.AutoSize = true;
            cbSelect.Checked = true;
            cbSelect.CheckState = CheckState.Checked;
            cbSelect.ForeColor = Color.White;
            cbSelect.Location = new Point(3, 3);
            cbSelect.Name = "cbSelect";
            cbSelect.Size = new Size(64, 18);
            cbSelect.TabIndex = 5;
            cbSelect.Text = "SELECT";
            cbSelect.TextAlign = ContentAlignment.MiddleCenter;
            cbSelect.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(103, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(68, 18);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "UPDATE";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.ForeColor = Color.White;
            checkBox2.Location = new Point(203, 3);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(58, 18);
            checkBox2.TabIndex = 7;
            checkBox2.Text = "ALTER";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.ForeColor = Color.White;
            checkBox3.Location = new Point(303, 3);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(64, 18);
            checkBox3.TabIndex = 8;
            checkBox3.Text = "DELETE";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(32, 33, 36);
            label2.Dock = DockStyle.Top;
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(400, 26);
            label2.TabIndex = 1;
            label2.Text = "Tipo da permissão";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(23, 24, 29);
            panel2.Controls.Add(dgvIntesParaAvaliacao);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 95);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 293);
            panel2.TabIndex = 6;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(32, 33, 36);
            label3.Dock = DockStyle.Top;
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(400, 26);
            label3.TabIndex = 1;
            label3.Text = "Objetos Selecionados";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEnviarSolicitacao
            // 
            btnEnviarSolicitacao.BackColor = Color.White;
            btnEnviarSolicitacao.BackgroundImageLayout = ImageLayout.Center;
            btnEnviarSolicitacao.Dock = DockStyle.Top;
            btnEnviarSolicitacao.FlatAppearance.BorderSize = 0;
            btnEnviarSolicitacao.FlatStyle = FlatStyle.Flat;
            btnEnviarSolicitacao.ForeColor = Color.FromArgb(32, 33, 36);
            btnEnviarSolicitacao.Image = Properties.Resources.confirmar_20;
            btnEnviarSolicitacao.ImageAlign = ContentAlignment.MiddleLeft;
            btnEnviarSolicitacao.Location = new Point(8, 0);
            btnEnviarSolicitacao.Margin = new Padding(0, 0, 8, 0);
            btnEnviarSolicitacao.Name = "btnEnviarSolicitacao";
            btnEnviarSolicitacao.Size = new Size(184, 26);
            btnEnviarSolicitacao.TabIndex = 39;
            btnEnviarSolicitacao.Text = "          Concluir";
            btnEnviarSolicitacao.TextAlign = ContentAlignment.MiddleLeft;
            btnEnviarSolicitacao.UseVisualStyleBackColor = false;
            btnEnviarSolicitacao.Click += btnEnviarSolicitacao_Click;
            // 
            // btnCancelarSolicitacao
            // 
            btnCancelarSolicitacao.BackColor = Color.White;
            btnCancelarSolicitacao.BackgroundImageLayout = ImageLayout.Center;
            btnCancelarSolicitacao.Dock = DockStyle.Top;
            btnCancelarSolicitacao.FlatAppearance.BorderSize = 0;
            btnCancelarSolicitacao.FlatStyle = FlatStyle.Flat;
            btnCancelarSolicitacao.ForeColor = Color.FromArgb(32, 33, 36);
            btnCancelarSolicitacao.Image = Properties.Resources.cancelar_x_20;
            btnCancelarSolicitacao.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelarSolicitacao.Location = new Point(208, 0);
            btnCancelarSolicitacao.Margin = new Padding(8, 0, 0, 0);
            btnCancelarSolicitacao.Name = "btnCancelarSolicitacao";
            btnCancelarSolicitacao.Size = new Size(184, 26);
            btnCancelarSolicitacao.TabIndex = 40;
            btnCancelarSolicitacao.Text = "          Cancelar";
            btnCancelarSolicitacao.TextAlign = ContentAlignment.MiddleLeft;
            btnCancelarSolicitacao.UseVisualStyleBackColor = false;
            btnCancelarSolicitacao.Click += btnCancelarSolicitacao_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnCancelarSolicitacao, 1, 0);
            tableLayoutPanel2.Controls.Add(btnEnviarSolicitacao, 0, 0);
            tableLayoutPanel2.Location = new Point(0, 391);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(8, 0, 8, 0);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(400, 26);
            tableLayoutPanel2.TabIndex = 41;
            // 
            // btn_sair
            // 
            btn_sair.BackColor = Color.White;
            btn_sair.BackgroundImageLayout = ImageLayout.Center;
            btn_sair.FlatAppearance.BorderSize = 0;
            btn_sair.FlatStyle = FlatStyle.Flat;
            btn_sair.ForeColor = Color.FromArgb(23, 24, 29);
            btn_sair.Image = Properties.Resources.x_16;
            btn_sair.Location = new Point(374, -1);
            btn_sair.Margin = new Padding(0);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(26, 28);
            btn_sair.TabIndex = 42;
            btn_sair.TextAlign = ContentAlignment.MiddleLeft;
            btn_sair.UseVisualStyleBackColor = false;
            btn_sair.Click += btn_sair_Click;
            // 
            // dgvIntesParaAvaliacao
            // 
            dgvIntesParaAvaliacao.AllowUserToAddRows = false;
            dgvIntesParaAvaliacao.AllowUserToDeleteRows = false;
            dgvIntesParaAvaliacao.AllowUserToResizeColumns = false;
            dgvIntesParaAvaliacao.AllowUserToResizeRows = false;
            dgvIntesParaAvaliacao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIntesParaAvaliacao.BackgroundColor = Color.Silver;
            dgvIntesParaAvaliacao.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvIntesParaAvaliacao.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle5.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvIntesParaAvaliacao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvIntesParaAvaliacao.ColumnHeadersHeight = 28;
            dgvIntesParaAvaliacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvIntesParaAvaliacao.Columns.AddRange(new DataGridViewColumn[] { Servidor, Database, Schema, Objeto });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvIntesParaAvaliacao.DefaultCellStyle = dataGridViewCellStyle6;
            dgvIntesParaAvaliacao.Dock = DockStyle.Fill;
            dgvIntesParaAvaliacao.EnableHeadersVisualStyles = false;
            dgvIntesParaAvaliacao.GridColor = Color.Silver;
            dgvIntesParaAvaliacao.Location = new Point(0, 26);
            dgvIntesParaAvaliacao.Margin = new Padding(0);
            dgvIntesParaAvaliacao.Name = "dgvIntesParaAvaliacao";
            dgvIntesParaAvaliacao.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.DarkSlateGray;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvIntesParaAvaliacao.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvIntesParaAvaliacao.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dgvIntesParaAvaliacao.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvIntesParaAvaliacao.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvIntesParaAvaliacao.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224);
            dgvIntesParaAvaliacao.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvIntesParaAvaliacao.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dgvIntesParaAvaliacao.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dgvIntesParaAvaliacao.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvIntesParaAvaliacao.Size = new Size(400, 267);
            dgvIntesParaAvaliacao.TabIndex = 40;
            // 
            // Servidor
            // 
            Servidor.HeaderText = "Servidor";
            Servidor.Name = "Servidor";
            // 
            // Database
            // 
            Database.HeaderText = "Database";
            Database.Name = "Database";
            // 
            // Schema
            // 
            Schema.HeaderText = "Schema";
            Schema.Name = "Schema";
            // 
            // Objeto
            // 
            Objeto.HeaderText = "Objeto";
            Objeto.Name = "Objeto";
            // 
            // FormSolicitaAcesso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 420);
            Controls.Add(btn_sair);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSolicitaAcesso";
            Text = "FormSolicitaAcesso";
            Load += FormSolicitaAcesso_Load;
            MouseDown += FormSolicitaAcesso_MouseDown;
            MouseMove += FormSolicitaAcesso_MouseMove;
            MouseUp += FormSolicitaAcesso_MouseUp;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvIntesParaAvaliacao).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Label label3;
        private Button btnEnviarSolicitacao;
        private Button btnCancelarSolicitacao;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btn_sair;
        private CheckBox cbSelect;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private DataGridView dgvIntesParaAvaliacao;
        private DataGridViewTextBoxColumn Servidor;
        private DataGridViewTextBoxColumn Database;
        private DataGridViewTextBoxColumn Schema;
        private DataGridViewTextBoxColumn Objeto;
    }
}