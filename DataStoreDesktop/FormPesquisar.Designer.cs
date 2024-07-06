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
            tableLayoutPanel3 = new TableLayoutPanel();
            button1 = new Button();
            btnVerReferencias = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel16 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            dgvPesquisar = new DataGridView();
            selecao = new DataGridViewCheckBoxColumn();
            Servidor = new DataGridViewTextBoxColumn();
            Database = new DataGridViewTextBoxColumn();
            Schema = new DataGridViewTextBoxColumn();
            Objeto = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Processo = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel17 = new Panel();
            textBox2 = new TextBox();
            label6 = new Label();
            panel18 = new Panel();
            comboBox5 = new ComboBox();
            label8 = new Label();
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
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPesquisar).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel17.SuspendLayout();
            panel18.SuspendLayout();
            panel23.SuspendLayout();
            panel24.SuspendLayout();
            panel25.SuspendLayout();
            panel26.SuspendLayout();
            SuspendLayout();
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
            tableLayoutPanel3.Controls.Add(btnVerReferencias, 0, 0);
            tableLayoutPanel3.Controls.Add(button4, 0, 0);
            tableLayoutPanel3.Controls.Add(button3, 0, 0);
            tableLayoutPanel3.Controls.Add(button2, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(800, 28);
            tableLayoutPanel3.TabIndex = 47;
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
            button1.Location = new Point(480, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(160, 28);
            button1.TabIndex = 42;
            button1.Text = "          Primeiras Linhas";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnVerPrimeirasLinhas_Click;
            // 
            // btnVerReferencias
            // 
            btnVerReferencias.BackColor = Color.FromArgb(32, 33, 36);
            btnVerReferencias.BackgroundImageLayout = ImageLayout.Center;
            btnVerReferencias.Dock = DockStyle.Fill;
            btnVerReferencias.FlatAppearance.BorderSize = 0;
            btnVerReferencias.FlatStyle = FlatStyle.Flat;
            btnVerReferencias.ForeColor = Color.White;
            btnVerReferencias.Image = Properties.Resources.seta_para_a_frente_18;
            btnVerReferencias.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerReferencias.Location = new Point(640, 0);
            btnVerReferencias.Margin = new Padding(0);
            btnVerReferencias.Name = "btnVerReferencias";
            btnVerReferencias.Size = new Size(160, 28);
            btnVerReferencias.TabIndex = 41;
            btnVerReferencias.Text = "          Ver Referências";
            btnVerReferencias.TextAlign = ContentAlignment.MiddleLeft;
            btnVerReferencias.UseVisualStyleBackColor = false;
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
            button4.Location = new Point(320, 0);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(160, 28);
            button4.TabIndex = 40;
            button4.Text = "          Solicitar Acesso";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += btnSolicitarAcesso_Click;
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
            button3.Size = new Size(160, 28);
            button3.TabIndex = 39;
            button3.Text = "          Limpar";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += btn_limpar_filtros_Click;
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
            button2.Location = new Point(160, 0);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(160, 28);
            button2.TabIndex = 37;
            button2.Text = "          Pesquisar";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += btn_pesquisar_form_pesquisar_Click;
            // 
            // panel16
            // 
            panel16.BackColor = Color.White;
            panel16.Dock = DockStyle.Bottom;
            panel16.Location = new Point(0, 394);
            panel16.Name = "panel16";
            panel16.Size = new Size(800, 56);
            panel16.TabIndex = 52;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(dgvPesquisar, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 28);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(800, 422);
            tableLayoutPanel2.TabIndex = 51;
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
            dgvPesquisar.Columns.AddRange(new DataGridViewColumn[] { selecao, Servidor, Database, Schema, Objeto, Tipo, Processo });
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
            dgvPesquisar.Location = new Point(0, 0);
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
            dgvPesquisar.Size = new Size(640, 402);
            dgvPesquisar.TabIndex = 39;
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
            // Processo
            // 
            Processo.HeaderText = "Processo";
            Processo.Name = "Processo";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel17, 0, 5);
            tableLayoutPanel1.Controls.Add(panel18, 0, 4);
            tableLayoutPanel1.Controls.Add(panel23, 0, 3);
            tableLayoutPanel1.Controls.Add(panel24, 0, 2);
            tableLayoutPanel1.Controls.Add(panel25, 0, 1);
            tableLayoutPanel1.Controls.Add(panel26, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(643, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(154, 153);
            tableLayoutPanel1.TabIndex = 40;
            // 
            // panel17
            // 
            panel17.BackColor = Color.White;
            panel17.Controls.Add(textBox2);
            panel17.Controls.Add(label6);
            panel17.Dock = DockStyle.Fill;
            panel17.Location = new Point(3, 133);
            panel17.Name = "panel17";
            panel17.Size = new Size(148, 17);
            panel17.TabIndex = 45;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(69, 0);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(79, 23);
            textBox2.TabIndex = 48;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Left;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(69, 17);
            label6.TabIndex = 47;
            label6.Text = "Objeto";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel18
            // 
            panel18.BackColor = Color.White;
            panel18.Controls.Add(comboBox5);
            panel18.Controls.Add(label8);
            panel18.Dock = DockStyle.Fill;
            panel18.Location = new Point(3, 107);
            panel18.Name = "panel18";
            panel18.Size = new Size(148, 20);
            panel18.TabIndex = 44;
            // 
            // comboBox5
            // 
            comboBox5.Dock = DockStyle.Fill;
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.FlatStyle = FlatStyle.Flat;
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "dbalgumacoisa", "dbmuitobom", "dbtrintaedois" });
            comboBox5.Location = new Point(69, 0);
            comboBox5.Margin = new Padding(0);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(79, 23);
            comboBox5.TabIndex = 48;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Left;
            label8.ForeColor = Color.Black;
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 47;
            label8.Text = "Schema";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel23
            // 
            panel23.BackColor = Color.White;
            panel23.Controls.Add(comboBox4);
            panel23.Controls.Add(label9);
            panel23.Dock = DockStyle.Fill;
            panel23.Location = new Point(3, 81);
            panel23.Name = "panel23";
            panel23.Size = new Size(148, 20);
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
            label9.Size = new Size(69, 20);
            label9.TabIndex = 47;
            label9.Text = "Database";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel24
            // 
            panel24.BackColor = Color.White;
            panel24.Controls.Add(comboBox3);
            panel24.Controls.Add(label10);
            panel24.Dock = DockStyle.Fill;
            panel24.Location = new Point(3, 55);
            panel24.Name = "panel24";
            panel24.Size = new Size(148, 20);
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
            label10.Size = new Size(69, 20);
            label10.TabIndex = 47;
            label10.Text = "Servidor";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel25
            // 
            panel25.BackColor = Color.White;
            panel25.Controls.Add(comboBox1);
            panel25.Controls.Add(label11);
            panel25.Dock = DockStyle.Fill;
            panel25.Location = new Point(3, 29);
            panel25.Name = "panel25";
            panel25.Size = new Size(148, 20);
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
            label11.Size = new Size(69, 20);
            label11.TabIndex = 47;
            label11.Text = "Tipo";
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
            panel26.Size = new Size(148, 20);
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
            label12.Size = new Size(69, 20);
            label12.TabIndex = 47;
            label12.Text = "Processo";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FormPesquisar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(panel16);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPesquisar";
            Text = "FormPesquisar";
            Load += FormPesquisar_Load;
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPesquisar).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            panel18.ResumeLayout(false);
            panel23.ResumeLayout(false);
            panel24.ResumeLayout(false);
            panel25.ResumeLayout(false);
            panel26.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel3;
        private Button button1;
        private Button btnVerReferencias;
        private Button button4;
        private Button button3;
        private Button button2;
        private Panel panel16;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dgvPesquisar;
        private DataGridViewCheckBoxColumn selecao;
        private DataGridViewTextBoxColumn Servidor;
        private DataGridViewTextBoxColumn Database;
        private DataGridViewTextBoxColumn Schema;
        private DataGridViewTextBoxColumn Objeto;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Processo;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel17;
        private TextBox textBox2;
        private Label label6;
        private Panel panel18;
        private ComboBox comboBox5;
        private Label label8;
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
    }
}