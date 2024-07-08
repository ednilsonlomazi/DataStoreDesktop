namespace DataStoreDesktop
{
    partial class FormSolicitacoes
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            tableLayoutPanel3 = new TableLayoutPanel();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            btnVerReferencias = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            dgvPesquisar = new DataGridView();
            selecao = new DataGridViewCheckBoxColumn();
            DataAbertura = new DataGridViewTextBoxColumn();
            Objeto = new DataGridViewTextBoxColumn();
            Permissao = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel23 = new Panel();
            comboBox4 = new ComboBox();
            label9 = new Label();
            panel24 = new Panel();
            comboBox3 = new ComboBox();
            label10 = new Label();
            panel25 = new Panel();
            comboBox1 = new ComboBox();
            label11 = new Label();
            panel26 = new Panel();
            comboBox2 = new ComboBox();
            label12 = new Label();
            dataGridView1 = new DataGridView();
            DataInicio = new DataGridViewTextBoxColumn();
            Avaliador = new DataGridViewTextBoxColumn();
            Veredito = new DataGridViewTextBoxColumn();
            Justificativa = new DataGridViewTextBoxColumn();
            Recurso = new DataGridViewTextBoxColumn();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPesquisar).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel23.SuspendLayout();
            panel24.SuspendLayout();
            panel25.SuspendLayout();
            panel26.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.FromArgb(32, 33, 36);
            tableLayoutPanel3.ColumnCount = 5;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Controls.Add(button1, 0, 0);
            tableLayoutPanel3.Controls.Add(button3, 0, 0);
            tableLayoutPanel3.Controls.Add(button2, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(640, 28);
            tableLayoutPanel3.TabIndex = 48;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(32, 33, 36);
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.cancelar_16;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(256, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(128, 28);
            button1.TabIndex = 42;
            button1.Text = "          Cancelar";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(32, 33, 36);
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.Dock = DockStyle.Fill;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Image = Properties.Resources.soma_16;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(128, 0);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(128, 28);
            button3.TabIndex = 39;
            button3.Text = "          Recurso";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(32, 33, 36);
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Dock = DockStyle.Fill;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.caixa_de_selecao_marcada_16;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 0);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(128, 28);
            button2.TabIndex = 37;
            button2.Text = "          Selecionar";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // btnVerReferencias
            // 
            btnVerReferencias.BackColor = Color.FromArgb(32, 33, 36);
            btnVerReferencias.BackgroundImageLayout = ImageLayout.Center;
            btnVerReferencias.Dock = DockStyle.Fill;
            btnVerReferencias.FlatAppearance.BorderSize = 0;
            btnVerReferencias.FlatStyle = FlatStyle.Flat;
            btnVerReferencias.ForeColor = Color.White;
            btnVerReferencias.Image = Properties.Resources.filtro_16;
            btnVerReferencias.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerReferencias.Location = new Point(640, 0);
            btnVerReferencias.Margin = new Padding(0);
            btnVerReferencias.Name = "btnVerReferencias";
            btnVerReferencias.Size = new Size(160, 28);
            btnVerReferencias.TabIndex = 41;
            btnVerReferencias.Text = "          Filtrar";
            btnVerReferencias.TextAlign = ContentAlignment.MiddleLeft;
            btnVerReferencias.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(dgvPesquisar, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 1, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(btnVerReferencias, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(800, 315);
            tableLayoutPanel2.TabIndex = 52;
            // 
            // dgvPesquisar
            // 
            dgvPesquisar.AllowUserToAddRows = false;
            dgvPesquisar.AllowUserToDeleteRows = false;
            dgvPesquisar.AllowUserToResizeColumns = false;
            dgvPesquisar.AllowUserToResizeRows = false;
            dgvPesquisar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPesquisar.BackgroundColor = Color.Silver;
            dgvPesquisar.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPesquisar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle1.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPesquisar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPesquisar.ColumnHeadersHeight = 28;
            dgvPesquisar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPesquisar.Columns.AddRange(new DataGridViewColumn[] { selecao, DataAbertura, Objeto, Permissao, Status });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPesquisar.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPesquisar.Dock = DockStyle.Fill;
            dgvPesquisar.EnableHeadersVisualStyles = false;
            dgvPesquisar.GridColor = Color.Silver;
            dgvPesquisar.Location = new Point(0, 28);
            dgvPesquisar.Margin = new Padding(0);
            dgvPesquisar.Name = "dgvPesquisar";
            dgvPesquisar.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPesquisar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPesquisar.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dgvPesquisar.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvPesquisar.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPesquisar.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224);
            dgvPesquisar.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvPesquisar.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dgvPesquisar.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dgvPesquisar.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvPesquisar.Size = new Size(640, 287);
            dgvPesquisar.TabIndex = 39;
            // 
            // selecao
            // 
            selecao.HeaderText = "Seleção";
            selecao.Name = "selecao";
            selecao.Resizable = DataGridViewTriState.True;
            selecao.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // DataAbertura
            // 
            DataAbertura.HeaderText = "Data Abertura";
            DataAbertura.Name = "DataAbertura";
            // 
            // Objeto
            // 
            Objeto.HeaderText = "Objeto";
            Objeto.Name = "Objeto";
            // 
            // Permissao
            // 
            Permissao.HeaderText = "Permissão";
            Permissao.Name = "Permissao";
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel23, 0, 3);
            tableLayoutPanel1.Controls.Add(panel24, 0, 2);
            tableLayoutPanel1.Controls.Add(panel25, 0, 1);
            tableLayoutPanel1.Controls.Add(panel26, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(643, 31);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(154, 111);
            tableLayoutPanel1.TabIndex = 40;
            // 
            // panel23
            // 
            panel23.BackColor = Color.White;
            panel23.Controls.Add(comboBox4);
            panel23.Controls.Add(label9);
            panel23.Dock = DockStyle.Fill;
            panel23.Location = new Point(3, 84);
            panel23.Name = "panel23";
            panel23.Size = new Size(148, 24);
            panel23.TabIndex = 43;
            // 
            // comboBox4
            // 
            comboBox4.Dock = DockStyle.Fill;
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FlatStyle = FlatStyle.Flat;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "dbalgumacoisa", "dbmuitobom", "dbtrintaedois" });
            comboBox4.Location = new Point(69, 0);
            comboBox4.Margin = new Padding(0);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(79, 23);
            comboBox4.TabIndex = 48;
            // 
            // label9
            // 
            label9.Dock = DockStyle.Left;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(69, 24);
            label9.TabIndex = 47;
            label9.Text = "Avaliador";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel24
            // 
            panel24.BackColor = Color.White;
            panel24.Controls.Add(comboBox3);
            panel24.Controls.Add(label10);
            panel24.Dock = DockStyle.Fill;
            panel24.Location = new Point(3, 57);
            panel24.Name = "panel24";
            panel24.Size = new Size(148, 21);
            panel24.TabIndex = 1;
            // 
            // comboBox3
            // 
            comboBox3.Dock = DockStyle.Fill;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FlatStyle = FlatStyle.Flat;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "dbalgumacoisa", "dbmuitobom", "dbtrintaedois" });
            comboBox3.Location = new Point(69, 0);
            comboBox3.Margin = new Padding(0);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(79, 23);
            comboBox3.TabIndex = 48;
            // 
            // label10
            // 
            label10.Dock = DockStyle.Left;
            label10.ForeColor = Color.Black;
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(69, 21);
            label10.TabIndex = 47;
            label10.Text = "Abertura";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel25
            // 
            panel25.BackColor = Color.White;
            panel25.Controls.Add(comboBox1);
            panel25.Controls.Add(label11);
            panel25.Dock = DockStyle.Fill;
            panel25.Location = new Point(3, 30);
            panel25.Name = "panel25";
            panel25.Size = new Size(148, 21);
            panel25.TabIndex = 41;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "dbalgumacoisa", "dbmuitobom", "dbtrintaedois" });
            comboBox1.Location = new Point(69, 0);
            comboBox1.Margin = new Padding(0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(79, 23);
            comboBox1.TabIndex = 48;
            // 
            // label11
            // 
            label11.Dock = DockStyle.Left;
            label11.ForeColor = Color.Black;
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Size = new Size(69, 21);
            label11.TabIndex = 47;
            label11.Text = "Veredito";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel26
            // 
            panel26.BackColor = Color.White;
            panel26.Controls.Add(comboBox2);
            panel26.Controls.Add(label12);
            panel26.Dock = DockStyle.Fill;
            panel26.Location = new Point(3, 3);
            panel26.Name = "panel26";
            panel26.Size = new Size(148, 21);
            panel26.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.Dock = DockStyle.Fill;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "dbalgumacoisa", "dbmuitobom", "dbtrintaedois" });
            comboBox2.Location = new Point(69, 0);
            comboBox2.Margin = new Padding(0);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(79, 23);
            comboBox2.TabIndex = 48;
            // 
            // label12
            // 
            label12.Dock = DockStyle.Left;
            label12.Font = new Font("Segoe UI", 9F);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(0, 0);
            label12.Name = "label12";
            label12.Size = new Size(69, 21);
            label12.TabIndex = 47;
            label12.Text = "Status";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Silver;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle5.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeight = 28;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { DataInicio, Avaliador, Veredito, Justificativa, Recurso });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.Silver;
            dataGridView1.Location = new Point(0, 315);
            dataGridView1.Margin = new Padding(0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.DarkSlateGray;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224);
            dataGridView1.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.Size = new Size(800, 135);
            dataGridView1.TabIndex = 53;
            // 
            // DataInicio
            // 
            DataInicio.HeaderText = "Data Inicio";
            DataInicio.Name = "DataInicio";
            // 
            // Avaliador
            // 
            Avaliador.HeaderText = "Avaliador";
            Avaliador.Name = "Avaliador";
            // 
            // Veredito
            // 
            Veredito.HeaderText = "Veredito";
            Veredito.Name = "Veredito";
            // 
            // Justificativa
            // 
            Justificativa.HeaderText = "Justificativa";
            Justificativa.Name = "Justificativa";
            // 
            // Recurso
            // 
            Recurso.HeaderText = "Recurso";
            Recurso.Name = "Recurso";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel4.Size = new Size(800, 450);
            tableLayoutPanel4.TabIndex = 54;
            // 
            // FormSolicitacoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSolicitacoes";
            Text = "FormCarrinho";
            Load += FormCarrinho_Load;
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPesquisar).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel23.ResumeLayout(false);
            panel24.ResumeLayout(false);
            panel25.ResumeLayout(false);
            panel26.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel3;
        private Button button1;
        private Button btnVerReferencias;
        private Button button3;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dgvPesquisar;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel23;
        private ComboBox comboBox4;
        private Label label9;
        private Panel panel24;
        private ComboBox comboBox3;
        private Label label10;
        private Panel panel25;
        private ComboBox comboBox1;
        private Label label11;
        private Panel panel26;
        private ComboBox comboBox2;
        private Label label12;
        private DataGridViewCheckBoxColumn selecao;
        private DataGridViewTextBoxColumn DataAbertura;
        private DataGridViewTextBoxColumn Objeto;
        private DataGridViewTextBoxColumn Permissao;
        private DataGridViewTextBoxColumn Status;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn DataInicio;
        private DataGridViewTextBoxColumn Avaliador;
        private DataGridViewTextBoxColumn Veredito;
        private DataGridViewTextBoxColumn Justificativa;
        private DataGridViewTextBoxColumn Recurso;
        private TableLayoutPanel tableLayoutPanel4;
    }
}