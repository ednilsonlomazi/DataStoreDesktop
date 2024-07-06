namespace DataStoreDesktop
{
    partial class FormSolicitacoesRealizadas
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
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel7 = new Panel();
            comboBox6 = new ComboBox();
            label6 = new Label();
            panel6 = new Panel();
            textBox1 = new TextBox();
            label5 = new Label();
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
            lbInfoAdicional = new Label();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            tableLayoutPanel3 = new TableLayoutPanel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            tableLayoutPanel2.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel27.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPesquisar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(panel7, 0, 1);
            tableLayoutPanel2.Controls.Add(panel6, 0, 1);
            tableLayoutPanel2.Controls.Add(panel4, 0, 0);
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(panel27, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(800, 50);
            tableLayoutPanel2.TabIndex = 45;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(comboBox6);
            panel7.Controls.Add(label6);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 25);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.RightToLeft = RightToLeft.No;
            panel7.Size = new Size(200, 23);
            panel7.TabIndex = 45;
            // 
            // comboBox6
            // 
            comboBox6.Dock = DockStyle.Left;
            comboBox6.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox6.FlatStyle = FlatStyle.Flat;
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "Pagamentos", "Compras", "Estoque", "Logística" });
            comboBox6.Location = new Point(68, 0);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(99, 23);
            comboBox6.TabIndex = 46;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Left;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(68, 23);
            label6.TabIndex = 45;
            label6.Text = "Schema";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(textBox1);
            panel6.Controls.Add(label5);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(200, 25);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.RightToLeft = RightToLeft.No;
            panel6.Size = new Size(200, 23);
            panel6.TabIndex = 44;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(68, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(130, 23);
            textBox1.TabIndex = 46;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Left;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(68, 23);
            label5.TabIndex = 45;
            label5.Text = "Objeto";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(comboBox3);
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(600, 0);
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
            label4.Text = "Database";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
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
            comboBox2.Location = new Point(114, 0);
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
            label2.Size = new Size(114, 23);
            label2.TabIndex = 45;
            label2.Text = "Processo sistêmico";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(200, 0);
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
            comboBox1.Location = new Point(91, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(99, 23);
            comboBox1.TabIndex = 46;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 23);
            label1.TabIndex = 45;
            label1.Text = "Tipo de objeto";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel27
            // 
            panel27.BackColor = Color.White;
            panel27.Controls.Add(comboBox5);
            panel27.Controls.Add(label3);
            panel27.Dock = DockStyle.Top;
            panel27.Location = new Point(400, 0);
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
            label3.Text = "Servidor";
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
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = Color.White;
            dataGridViewCellStyle19.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle19.ForeColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle19.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            dgvPesquisar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dgvPesquisar.ColumnHeadersHeight = 28;
            dgvPesquisar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPesquisar.Columns.AddRange(new DataGridViewColumn[] { selecao, Servidor, Database, Schema, Objeto, Tipo, Classe });
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = Color.White;
            dataGridViewCellStyle20.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle20.ForeColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle20.SelectionBackColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle20.SelectionForeColor = Color.White;
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.False;
            dgvPesquisar.DefaultCellStyle = dataGridViewCellStyle20;
            dgvPesquisar.Dock = DockStyle.Fill;
            dgvPesquisar.EnableHeadersVisualStyles = false;
            dgvPesquisar.GridColor = Color.Silver;
            dgvPesquisar.Location = new Point(0, 0);
            dgvPesquisar.Margin = new Padding(0);
            dgvPesquisar.Name = "dgvPesquisar";
            dgvPesquisar.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle21.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle21.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = Color.DarkSlateGray;
            dataGridViewCellStyle21.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = DataGridViewTriState.True;
            dgvPesquisar.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            dgvPesquisar.RowHeadersVisible = false;
            dgvPesquisar.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPesquisar.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dgvPesquisar.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvPesquisar.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(23, 24, 29);
            dgvPesquisar.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(23, 24, 29);
            dgvPesquisar.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvPesquisar.Size = new Size(800, 450);
            dgvPesquisar.TabIndex = 44;
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
            // lbInfoAdicional
            // 
            lbInfoAdicional.Dock = DockStyle.Fill;
            lbInfoAdicional.ForeColor = Color.Black;
            lbInfoAdicional.Location = new Point(0, 0);
            lbInfoAdicional.Margin = new Padding(10);
            lbInfoAdicional.Name = "lbInfoAdicional";
            lbInfoAdicional.Size = new Size(800, 450);
            lbInfoAdicional.TabIndex = 42;
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
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = Color.White;
            dataGridViewCellStyle22.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle22.ForeColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle22.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            dataGridView1.ColumnHeadersHeight = 28;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, Cliente });
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = Color.White;
            dataGridViewCellStyle23.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle23.ForeColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle23.SelectionBackColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle23.SelectionForeColor = Color.White;
            dataGridViewCellStyle23.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle23;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.Silver;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle24.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle24.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = Color.DarkSlateGray;
            dataGridViewCellStyle24.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(23, 24, 29);
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(23, 24, 29);
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.Size = new Size(800, 450);
            dataGridView1.TabIndex = 43;
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
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 5;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Controls.Add(button1, 0, 0);
            tableLayoutPanel3.Controls.Add(button5, 0, 0);
            tableLayoutPanel3.Controls.Add(button4, 0, 0);
            tableLayoutPanel3.Controls.Add(button3, 0, 0);
            tableLayoutPanel3.Controls.Add(button2, 0, 0);
            tableLayoutPanel3.Location = new Point(0, 175);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(781, 100);
            tableLayoutPanel3.TabIndex = 46;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(32, 33, 36);
            button5.BackgroundImageLayout = ImageLayout.Center;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Image = Properties.Resources.visível_19;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(624, 0);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(40, 100);
            button5.TabIndex = 41;
            button5.Text = "          Ver Referências";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(32, 33, 36);
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.Dock = DockStyle.Fill;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Image = Properties.Resources.acesso_16;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(312, 0);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(156, 100);
            button4.TabIndex = 40;
            button4.Text = "          Solicitar Acesso";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(32, 33, 36);
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.Dock = DockStyle.Fill;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Image = Properties.Resources.vassoura_16_new;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 0);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(156, 100);
            button3.TabIndex = 39;
            button3.Text = "          Limpar";
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
            button2.Image = Properties.Resources.pesquisar_16_new;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(156, 0);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(156, 100);
            button2.TabIndex = 37;
            button2.Text = "          Pesquisar";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(32, 33, 36);
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.visível_19;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(468, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(156, 100);
            button1.TabIndex = 42;
            button1.Text = "          Primeiras Linhas";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // FormSolicitacoesRealizadas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(dgvPesquisar);
            Controls.Add(lbInfoAdicional);
            Controls.Add(dataGridView1);
            Name = "FormSolicitacoesRealizadas";
            Text = "FormSolicitacoesRealizadas";
            Load += FormSolicitacoesRealizadas_Load;
            tableLayoutPanel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel27.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPesquisar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel7;
        private ComboBox comboBox6;
        private Label label6;
        private Panel panel6;
        private TextBox textBox1;
        private Label label5;
        private Panel panel4;
        private ComboBox comboBox3;
        private Label label4;
        private Panel panel2;
        private ComboBox comboBox2;
        private Label label2;
        private Panel panel1;
        private ComboBox comboBox1;
        private Label label1;
        private Panel panel27;
        private ComboBox comboBox5;
        private Label label3;
        private DataGridView dgvPesquisar;
        private DataGridViewCheckBoxColumn selecao;
        private DataGridViewTextBoxColumn Servidor;
        private DataGridViewTextBoxColumn Database;
        private DataGridViewTextBoxColumn Schema;
        private DataGridViewTextBoxColumn Objeto;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Classe;
        private Label lbInfoAdicional;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn Cliente;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}