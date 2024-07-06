namespace DataStoreDesktop
{
    partial class FormPesquisar
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pnInfoAdicional = new Panel();
            lbInfoAdicional = new Label();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            panel5 = new Panel();
            btnVerPrimeirasLinhas = new Button();
            btnSolicitarAcesso = new Button();
            btn_limpar = new Button();
            btn_pesquisar = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel4 = new Panel();
            comboBox3 = new ComboBox();
            label4 = new Label();
            panel2 = new Panel();
            comboBox2 = new ComboBox();
            label2 = new Label();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            label1 = new Label();
            panel27 = new Panel();
            comboBox5 = new ComboBox();
            label3 = new Label();
            dgvPesquisar = new DataGridView();
            selecao = new DataGridViewCheckBoxColumn();
            Servidor = new DataGridViewTextBoxColumn();
            Database = new DataGridViewTextBoxColumn();
            Schema = new DataGridViewTextBoxColumn();
            Objeto = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Classe = new DataGridViewTextBoxColumn();
            pnInfoAdicional.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel27.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPesquisar).BeginInit();
            SuspendLayout();
            // 
            // pnInfoAdicional
            // 
            pnInfoAdicional.BackColor = Color.White;
            pnInfoAdicional.Controls.Add(lbInfoAdicional);
            pnInfoAdicional.Dock = DockStyle.Fill;
            pnInfoAdicional.Location = new Point(3, 3);
            pnInfoAdicional.Name = "pnInfoAdicional";
            pnInfoAdicional.Size = new Size(394, 111);
            pnInfoAdicional.TabIndex = 34;
            // 
            // lbInfoAdicional
            // 
            lbInfoAdicional.Dock = DockStyle.Fill;
            lbInfoAdicional.ForeColor = Color.Black;
            lbInfoAdicional.Location = new Point(0, 0);
            lbInfoAdicional.Margin = new Padding(10);
            lbInfoAdicional.Name = "lbInfoAdicional";
            lbInfoAdicional.Size = new Size(394, 111);
            lbInfoAdicional.TabIndex = 0;
            lbInfoAdicional.Text = "label1";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 28;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, Cliente });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.Silver;
            dataGridView1.Location = new Point(403, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(23, 24, 29);
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(23, 24, 29);
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.Size = new Size(394, 111);
            dataGridView1.TabIndex = 35;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Cod Carga";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Emrpesa";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.Name = "Cliente";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pnInfoAdicional, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 333);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 117);
            tableLayoutPanel1.TabIndex = 36;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(23, 24, 29);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(tableLayoutPanel2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 80);
            panel3.TabIndex = 38;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(32, 33, 36);
            panel5.Controls.Add(btnVerPrimeirasLinhas);
            panel5.Controls.Add(btnSolicitarAcesso);
            panel5.Controls.Add(btn_limpar);
            panel5.Controls.Add(btn_pesquisar);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 50);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(800, 28);
            panel5.TabIndex = 41;
            // 
            // btnVerPrimeirasLinhas
            // 
            btnVerPrimeirasLinhas.BackColor = Color.FromArgb(32, 33, 36);
            btnVerPrimeirasLinhas.BackgroundImageLayout = ImageLayout.Center;
            btnVerPrimeirasLinhas.Dock = DockStyle.Left;
            btnVerPrimeirasLinhas.FlatAppearance.BorderSize = 0;
            btnVerPrimeirasLinhas.FlatStyle = FlatStyle.Flat;
            btnVerPrimeirasLinhas.ForeColor = Color.White;
            btnVerPrimeirasLinhas.Image = Properties.Resources.visível_19;
            btnVerPrimeirasLinhas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerPrimeirasLinhas.Location = new Point(501, 0);
            btnVerPrimeirasLinhas.Margin = new Padding(0);
            btnVerPrimeirasLinhas.Name = "btnVerPrimeirasLinhas";
            btnVerPrimeirasLinhas.Size = new Size(167, 28);
            btnVerPrimeirasLinhas.TabIndex = 40;
            btnVerPrimeirasLinhas.Text = "          Ver Primeiras Linhas";
            btnVerPrimeirasLinhas.TextAlign = ContentAlignment.MiddleLeft;
            btnVerPrimeirasLinhas.UseVisualStyleBackColor = false;
            btnVerPrimeirasLinhas.Click += btnVerPrimeirasLinhas_Click;
            // 
            // btnSolicitarAcesso
            // 
            btnSolicitarAcesso.BackColor = Color.FromArgb(32, 33, 36);
            btnSolicitarAcesso.BackgroundImageLayout = ImageLayout.Center;
            btnSolicitarAcesso.Dock = DockStyle.Left;
            btnSolicitarAcesso.FlatAppearance.BorderSize = 0;
            btnSolicitarAcesso.FlatStyle = FlatStyle.Flat;
            btnSolicitarAcesso.ForeColor = Color.White;
            btnSolicitarAcesso.Image = Properties.Resources.acesso_16;
            btnSolicitarAcesso.ImageAlign = ContentAlignment.MiddleLeft;
            btnSolicitarAcesso.Location = new Point(334, 0);
            btnSolicitarAcesso.Margin = new Padding(0);
            btnSolicitarAcesso.Name = "btnSolicitarAcesso";
            btnSolicitarAcesso.Size = new Size(167, 28);
            btnSolicitarAcesso.TabIndex = 39;
            btnSolicitarAcesso.Text = "          Solicitar Acesso";
            btnSolicitarAcesso.TextAlign = ContentAlignment.MiddleLeft;
            btnSolicitarAcesso.UseVisualStyleBackColor = false;
            btnSolicitarAcesso.Click += btnSolicitarAcesso_Click;
            // 
            // btn_limpar
            // 
            btn_limpar.BackColor = Color.FromArgb(32, 33, 36);
            btn_limpar.BackgroundImageLayout = ImageLayout.Center;
            btn_limpar.Dock = DockStyle.Left;
            btn_limpar.FlatAppearance.BorderSize = 0;
            btn_limpar.FlatStyle = FlatStyle.Flat;
            btn_limpar.ForeColor = Color.White;
            btn_limpar.Image = Properties.Resources.vassoura_16_new;
            btn_limpar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_limpar.Location = new Point(167, 0);
            btn_limpar.Margin = new Padding(0);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(167, 28);
            btn_limpar.TabIndex = 38;
            btn_limpar.Text = "          Limpar";
            btn_limpar.TextAlign = ContentAlignment.MiddleLeft;
            btn_limpar.UseVisualStyleBackColor = false;
            btn_limpar.Click += btn_limpar_filtros_Click;
            // 
            // btn_pesquisar
            // 
            btn_pesquisar.BackColor = Color.FromArgb(32, 33, 36);
            btn_pesquisar.BackgroundImageLayout = ImageLayout.Center;
            btn_pesquisar.Dock = DockStyle.Left;
            btn_pesquisar.FlatAppearance.BorderSize = 0;
            btn_pesquisar.FlatStyle = FlatStyle.Flat;
            btn_pesquisar.ForeColor = Color.White;
            btn_pesquisar.Image = Properties.Resources.pesquisar_16_new;
            btn_pesquisar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_pesquisar.Location = new Point(0, 0);
            btn_pesquisar.Margin = new Padding(0);
            btn_pesquisar.Name = "btn_pesquisar";
            btn_pesquisar.Size = new Size(167, 28);
            btn_pesquisar.TabIndex = 36;
            btn_pesquisar.Text = "          Pesquisar";
            btn_pesquisar.TextAlign = ContentAlignment.MiddleLeft;
            btn_pesquisar.UseVisualStyleBackColor = false;
            btn_pesquisar.Click += btn_pesquisar_form_pesquisar_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(23, 24, 29);
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(panel4, 0, 0);
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(panel27, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(800, 50);
            tableLayoutPanel2.TabIndex = 40;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(comboBox3);
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(400, 0);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.RightToLeft = RightToLeft.No;
            panel4.Size = new Size(200, 23);
            panel4.TabIndex = 43;
            // 
            // comboBox3
            // 
            comboBox3.Dock = DockStyle.Left;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FlatStyle = FlatStyle.Flat;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "SERVER123", "SERVERXYZ", "SERVERLEGAL" });
            comboBox3.Location = new Point(80, 0);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(118, 23);
            comboBox3.TabIndex = 46;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Left;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(80, 23);
            label4.TabIndex = 45;
            label4.Text = "Servidor";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(600, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.RightToLeft = RightToLeft.No;
            panel2.Size = new Size(200, 23);
            panel2.TabIndex = 42;
            // 
            // comboBox2
            // 
            comboBox2.Dock = DockStyle.Left;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "dbalgumacoisa", "dbmuitobom", "dbtrintaedois" });
            comboBox2.Location = new Point(80, 0);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(118, 23);
            comboBox2.TabIndex = 46;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Left;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 23);
            label2.TabIndex = 45;
            label2.Text = "Database";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(200, 23);
            panel1.TabIndex = 41;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Left;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Pagamentos", "Compras", "Estoque", "Logística" });
            comboBox1.Location = new Point(68, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(132, 23);
            comboBox1.TabIndex = 46;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 23);
            label1.TabIndex = 45;
            label1.Text = "Processo";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel27
            // 
            panel27.BackColor = Color.White;
            panel27.Controls.Add(comboBox5);
            panel27.Controls.Add(label3);
            panel27.Dock = DockStyle.Top;
            panel27.Location = new Point(200, 0);
            panel27.Margin = new Padding(0);
            panel27.Name = "panel27";
            panel27.RightToLeft = RightToLeft.No;
            panel27.Size = new Size(200, 23);
            panel27.TabIndex = 40;
            // 
            // comboBox5
            // 
            comboBox5.Dock = DockStyle.Left;
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.FlatStyle = FlatStyle.Flat;
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Tabela", "View", "Procedure" });
            comboBox5.Location = new Point(79, 0);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(118, 23);
            comboBox5.TabIndex = 46;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Left;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 23);
            label3.TabIndex = 45;
            label3.Text = "Tipo Objeto";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvPesquisar
            // 
            dgvPesquisar.AllowUserToAddRows = false;
            dgvPesquisar.AllowUserToDeleteRows = false;
            dgvPesquisar.AllowUserToResizeColumns = false;
            dgvPesquisar.AllowUserToResizeRows = false;
            dgvPesquisar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPesquisar.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPesquisar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvPesquisar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvPesquisar.ColumnHeadersHeight = 28;
            dgvPesquisar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPesquisar.Columns.AddRange(new DataGridViewColumn[] { selecao, Servidor, Database, Schema, Objeto, Tipo, Classe });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvPesquisar.DefaultCellStyle = dataGridViewCellStyle5;
            dgvPesquisar.Dock = DockStyle.Fill;
            dgvPesquisar.EnableHeadersVisualStyles = false;
            dgvPesquisar.GridColor = Color.Silver;
            dgvPesquisar.Location = new Point(0, 80);
            dgvPesquisar.Margin = new Padding(0);
            dgvPesquisar.Name = "dgvPesquisar";
            dgvPesquisar.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.DarkSlateGray;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvPesquisar.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvPesquisar.RowHeadersVisible = false;
            dgvPesquisar.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPesquisar.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dgvPesquisar.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvPesquisar.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(23, 24, 29);
            dgvPesquisar.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(23, 24, 29);
            dgvPesquisar.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvPesquisar.Size = new Size(800, 253);
            dgvPesquisar.TabIndex = 39;
            dgvPesquisar.CellContentClick += dgvPesquisar_CellContentClick;
            // 
            // selecao
            // 
            selecao.HeaderText = "Seleção";
            selecao.Name = "selecao";
            selecao.Resizable = DataGridViewTriState.True;
            selecao.SortMode = DataGridViewColumnSortMode.Automatic;
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
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            // 
            // Classe
            // 
            Classe.HeaderText = "Classe";
            Classe.Name = "Classe";
            // 
            // FormPesquisar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPesquisar);
            Controls.Add(panel3);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPesquisar";
            Text = "FormPesquisar";
            Load += FormPesquisar_Load;
            pnInfoAdicional.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel27.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPesquisar).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnInfoAdicional;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn Cliente;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private DataGridView dgvPesquisar;
        private DataGridViewCheckBoxColumn selecao;
        private DataGridViewTextBoxColumn Servidor;
        private DataGridViewTextBoxColumn Database;
        private DataGridViewTextBoxColumn Schema;
        private DataGridViewTextBoxColumn Objeto;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Classe;
        private Label lbInfoAdicional;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel27;
        private Panel panel5;
        private Button btnVerPrimeirasLinhas;
        private Button btnSolicitarAcesso;
        private Button btn_limpar;
        private Button btn_pesquisar;
        private Label label3;
        private ComboBox comboBox5;
        private Panel panel4;
        private ComboBox comboBox3;
        private Label label4;
        private Panel panel2;
        private ComboBox comboBox2;
        private Label label2;
        private Panel panel1;
        private ComboBox comboBox1;
        private Label label1;
    }
}