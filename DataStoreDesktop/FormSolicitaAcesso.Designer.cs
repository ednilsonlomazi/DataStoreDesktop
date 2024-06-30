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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            panel2 = new Panel();
            dgvIntesParaAvaliacao = new DataGridView();
            Servidor = new DataGridViewTextBoxColumn();
            Database = new DataGridViewTextBoxColumn();
            Schema = new DataGridViewTextBoxColumn();
            Objeto = new DataGridViewTextBoxColumn();
            label3 = new Label();
            btnEnviarSolicitacao = new Button();
            btnCancelarSolicitacao = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            btn_sair = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIntesParaAvaliacao).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Dock = DockStyle.Top;
            radioButton1.ForeColor = Color.White;
            radioButton1.Location = new Point(3, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(90, 19);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "SELECT";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Dock = DockStyle.Top;
            radioButton2.ForeColor = Color.White;
            radioButton2.Location = new Point(99, 3);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(90, 19);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "UPDATE";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Dock = DockStyle.Top;
            radioButton3.ForeColor = Color.White;
            radioButton3.Location = new Point(195, 3);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(90, 19);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "DELETE";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Dock = DockStyle.Top;
            radioButton4.ForeColor = Color.White;
            radioButton4.Location = new Point(291, 3);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(90, 19);
            radioButton4.TabIndex = 4;
            radioButton4.TabStop = true;
            radioButton4.Text = "ALTER";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 24, 29);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 28);
            panel1.Margin = new Padding(0, 28, 0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(8, 30, 8, 30);
            panel1.Size = new Size(400, 126);
            panel1.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(radioButton4, 3, 0);
            tableLayoutPanel1.Controls.Add(radioButton1, 0, 0);
            tableLayoutPanel1.Controls.Add(radioButton3, 2, 0);
            tableLayoutPanel1.Controls.Add(radioButton2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(8, 68);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(384, 28);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.ForeColor = Color.White;
            label2.Location = new Point(8, 30);
            label2.Name = "label2";
            label2.Padding = new Padding(10);
            label2.Size = new Size(384, 38);
            label2.TabIndex = 1;
            label2.Text = "Tipo da permissão";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(23, 24, 29);
            panel2.Controls.Add(dgvIntesParaAvaliacao);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 154);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(8, 30, 8, 0);
            panel2.Size = new Size(400, 289);
            panel2.TabIndex = 6;
            // 
            // dgvIntesParaAvaliacao
            // 
            dgvIntesParaAvaliacao.AllowUserToAddRows = false;
            dgvIntesParaAvaliacao.AllowUserToDeleteRows = false;
            dgvIntesParaAvaliacao.AllowUserToResizeColumns = false;
            dgvIntesParaAvaliacao.AllowUserToResizeRows = false;
            dgvIntesParaAvaliacao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIntesParaAvaliacao.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvIntesParaAvaliacao.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvIntesParaAvaliacao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvIntesParaAvaliacao.ColumnHeadersHeight = 28;
            dgvIntesParaAvaliacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvIntesParaAvaliacao.Columns.AddRange(new DataGridViewColumn[] { Servidor, Database, Schema, Objeto });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvIntesParaAvaliacao.DefaultCellStyle = dataGridViewCellStyle2;
            dgvIntesParaAvaliacao.EnableHeadersVisualStyles = false;
            dgvIntesParaAvaliacao.GridColor = Color.Silver;
            dgvIntesParaAvaliacao.Location = new Point(0, 65);
            dgvIntesParaAvaliacao.Margin = new Padding(0);
            dgvIntesParaAvaliacao.Name = "dgvIntesParaAvaliacao";
            dgvIntesParaAvaliacao.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvIntesParaAvaliacao.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvIntesParaAvaliacao.RowHeadersVisible = false;
            dgvIntesParaAvaliacao.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvIntesParaAvaliacao.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dgvIntesParaAvaliacao.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvIntesParaAvaliacao.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(23, 24, 29);
            dgvIntesParaAvaliacao.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(23, 24, 29);
            dgvIntesParaAvaliacao.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvIntesParaAvaliacao.Size = new Size(400, 227);
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
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.ForeColor = Color.White;
            label3.Location = new Point(8, 30);
            label3.Name = "label3";
            label3.Padding = new Padding(10);
            label3.Size = new Size(384, 38);
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
            btnEnviarSolicitacao.Size = new Size(184, 32);
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
            btnCancelarSolicitacao.Size = new Size(184, 32);
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
            tableLayoutPanel2.Location = new Point(0, 446);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(8, 0, 8, 0);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(400, 42);
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
            // FormSolicitaAcesso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 500);
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
            ((System.ComponentModel.ISupportInitialize)dgvIntesParaAvaliacao).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Panel panel1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Label label3;
        private DataGridView dgvIntesParaAvaliacao;
        private DataGridViewTextBoxColumn Servidor;
        private DataGridViewTextBoxColumn Database;
        private DataGridViewTextBoxColumn Schema;
        private DataGridViewTextBoxColumn Objeto;
        private Button btnEnviarSolicitacao;
        private Button btnCancelarSolicitacao;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btn_sair;
    }
}