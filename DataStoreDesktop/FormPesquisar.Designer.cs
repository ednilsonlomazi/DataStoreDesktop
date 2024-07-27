using DAL;
namespace GUI
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            Procedure = new DataGridViewTextBoxColumn();
            View = new DataGridViewTextBoxColumn();
            Trigger = new DataGridViewTextBoxColumn();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnPesquisar = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnSelecionar = new Button();
            btnSolicitarAcesso = new Button();
            btnVerPrimeirasLinhas = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel17 = new Panel();
            textBoxObjeto = new TextBox();
            label6 = new Label();
            panel18 = new Panel();
            comboBoxSchema = new ComboBox();
            label8 = new Label();
            panel23 = new Panel();
            comboBoxDatabase = new ComboBox();
            label9 = new Label();
            panel24 = new Panel();
            comboBoxServidor = new ComboBox();
            label10 = new Label();
            panel25 = new Panel();
            comboBoxTipoObjeto = new ComboBox();
            label11 = new Label();
            panel26 = new Panel();
            comboBoxProcesso = new ComboBox();
            label12 = new Label();
            dgvPesquisar = new DataGridView();
            selecao = new DataGridViewCheckBoxColumn();
            Servidor = new DataGridViewTextBoxColumn();
            Database = new DataGridViewTextBoxColumn();
            Schema = new DataGridViewTextBoxColumn();
            Objeto = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Processo = new DataGridViewTextBoxColumn();
            tableLayoutPanel4 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel17.SuspendLayout();
            panel18.SuspendLayout();
            panel23.SuspendLayout();
            panel24.SuspendLayout();
            panel25.SuspendLayout();
            panel26.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPesquisar).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle1.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 28;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, Procedure, View, Trigger });
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
            dataGridView1.Location = new Point(0, 315);
            dataGridView1.Margin = new Padding(0);
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
            dataGridViewCellStyle4.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224);
            dataGridView1.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.Size = new Size(800, 135);
            dataGridView1.TabIndex = 52;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Objeto";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Procedure
            // 
            Procedure.HeaderText = "Procedure";
            Procedure.Name = "Procedure";
            // 
            // View
            // 
            View.HeaderText = "View";
            View.Name = "View";
            // 
            // Trigger
            // 
            Trigger.HeaderText = "Trigger";
            Trigger.Name = "Trigger";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(btnPesquisar, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 1, 1);
            tableLayoutPanel2.Controls.Add(dgvPesquisar, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(800, 315);
            tableLayoutPanel2.TabIndex = 53;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.FromArgb(32, 33, 36);
            btnPesquisar.BackgroundImageLayout = ImageLayout.Center;
            btnPesquisar.Dock = DockStyle.Fill;
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Image = Properties.Resources.pesquisar_16_new;
            btnPesquisar.ImageAlign = ContentAlignment.MiddleLeft;
            btnPesquisar.Location = new Point(640, 0);
            btnPesquisar.Margin = new Padding(0);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(160, 28);
            btnPesquisar.TabIndex = 41;
            btnPesquisar.Text = "          Pesquisar";
            btnPesquisar.TextAlign = ContentAlignment.MiddleLeft;
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btn_pesquisar_form_pesquisar_Click;
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
            tableLayoutPanel3.Controls.Add(btnSelecionar, 0, 0);
            tableLayoutPanel3.Controls.Add(btnSolicitarAcesso, 2, 0);
            tableLayoutPanel3.Controls.Add(btnVerPrimeirasLinhas, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(640, 28);
            tableLayoutPanel3.TabIndex = 47;
            // 
            // btnSelecionar
            // 
            btnSelecionar.BackColor = Color.FromArgb(32, 33, 36);
            btnSelecionar.BackgroundImageLayout = ImageLayout.Center;
            btnSelecionar.Dock = DockStyle.Fill;
            btnSelecionar.FlatAppearance.BorderSize = 0;
            btnSelecionar.FlatStyle = FlatStyle.Flat;
            btnSelecionar.ForeColor = Color.White;
            btnSelecionar.Image = Properties.Resources.caixa_de_selecao_marcada_16;
            btnSelecionar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSelecionar.Location = new Point(0, 0);
            btnSelecionar.Margin = new Padding(0);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(128, 28);
            btnSelecionar.TabIndex = 39;
            btnSelecionar.Text = "          Selecionar";
            btnSelecionar.TextAlign = ContentAlignment.MiddleLeft;
            btnSelecionar.UseVisualStyleBackColor = false;
            // 
            // btnSolicitarAcesso
            // 
            btnSolicitarAcesso.BackColor = Color.FromArgb(32, 33, 36);
            btnSolicitarAcesso.BackgroundImageLayout = ImageLayout.Center;
            btnSolicitarAcesso.Dock = DockStyle.Fill;
            btnSolicitarAcesso.FlatAppearance.BorderSize = 0;
            btnSolicitarAcesso.FlatStyle = FlatStyle.Flat;
            btnSolicitarAcesso.ForeColor = Color.White;
            btnSolicitarAcesso.Image = Properties.Resources.acesso_16;
            btnSolicitarAcesso.ImageAlign = ContentAlignment.MiddleLeft;
            btnSolicitarAcesso.Location = new Point(256, 0);
            btnSolicitarAcesso.Margin = new Padding(0);
            btnSolicitarAcesso.Name = "btnSolicitarAcesso";
            btnSolicitarAcesso.Size = new Size(128, 28);
            btnSolicitarAcesso.TabIndex = 40;
            btnSolicitarAcesso.Text = "          Solicitar Acesso";
            btnSolicitarAcesso.TextAlign = ContentAlignment.MiddleLeft;
            btnSolicitarAcesso.UseVisualStyleBackColor = false;
            btnSolicitarAcesso.Click += btnSolicitarAcesso_Click;
            // 
            // btnVerPrimeirasLinhas
            // 
            btnVerPrimeirasLinhas.BackColor = Color.FromArgb(32, 33, 36);
            btnVerPrimeirasLinhas.BackgroundImageLayout = ImageLayout.Center;
            btnVerPrimeirasLinhas.Dock = DockStyle.Fill;
            btnVerPrimeirasLinhas.FlatAppearance.BorderSize = 0;
            btnVerPrimeirasLinhas.FlatStyle = FlatStyle.Flat;
            btnVerPrimeirasLinhas.ForeColor = Color.White;
            btnVerPrimeirasLinhas.Image = Properties.Resources.olho_16_branco;
            btnVerPrimeirasLinhas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerPrimeirasLinhas.Location = new Point(128, 0);
            btnVerPrimeirasLinhas.Margin = new Padding(0);
            btnVerPrimeirasLinhas.Name = "btnVerPrimeirasLinhas";
            btnVerPrimeirasLinhas.Size = new Size(128, 28);
            btnVerPrimeirasLinhas.TabIndex = 37;
            btnVerPrimeirasLinhas.Text = "          Primeiras Linhas";
            btnVerPrimeirasLinhas.TextAlign = ContentAlignment.MiddleLeft;
            btnVerPrimeirasLinhas.UseVisualStyleBackColor = false;
            btnVerPrimeirasLinhas.Click += btnVerPrimeirasLinhas_Click;
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
            tableLayoutPanel1.Location = new Point(643, 31);
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
            panel17.Controls.Add(textBoxObjeto);
            panel17.Controls.Add(label6);
            panel17.Dock = DockStyle.Fill;
            panel17.Location = new Point(3, 133);
            panel17.Name = "panel17";
            panel17.Size = new Size(148, 17);
            panel17.TabIndex = 45;
            // 
            // textBoxObjeto
            // 
            textBoxObjeto.Dock = DockStyle.Fill;
            textBoxObjeto.Location = new Point(69, 0);
            textBoxObjeto.Name = "textBoxObjeto";
            textBoxObjeto.Size = new Size(79, 23);
            textBoxObjeto.TabIndex = 48;
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
            panel18.Controls.Add(comboBoxSchema);
            panel18.Controls.Add(label8);
            panel18.Dock = DockStyle.Fill;
            panel18.Location = new Point(3, 107);
            panel18.Name = "panel18";
            panel18.Size = new Size(148, 20);
            panel18.TabIndex = 44;
            // 
            // comboBoxSchema
            // 
            comboBoxSchema.Dock = DockStyle.Fill;
            comboBoxSchema.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSchema.FlatStyle = FlatStyle.Flat;
            comboBoxSchema.FormattingEnabled = true;
            comboBoxSchema.Items.AddRange(new object[] { "dbalgumacoisa", "dbmuitobom", "dbtrintaedois" });
            comboBoxSchema.Location = new Point(69, 0);
            comboBoxSchema.Margin = new Padding(0);
            comboBoxSchema.Name = "comboBoxSchema";
            comboBoxSchema.Size = new Size(79, 23);
            comboBoxSchema.TabIndex = 48;
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
            panel23.Controls.Add(comboBoxDatabase);
            panel23.Controls.Add(label9);
            panel23.Dock = DockStyle.Fill;
            panel23.Location = new Point(3, 81);
            panel23.Name = "panel23";
            panel23.Size = new Size(148, 20);
            panel23.TabIndex = 43;
            // 
            // comboBoxDatabase
            // 
            comboBoxDatabase.Dock = DockStyle.Fill;
            comboBoxDatabase.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDatabase.FlatStyle = FlatStyle.Flat;
            comboBoxDatabase.FormattingEnabled = true;
            comboBoxDatabase.Items.AddRange(new object[] { "dbalgumacoisa", "dbmuitobom", "dbtrintaedois" });
            comboBoxDatabase.Location = new Point(69, 0);
            comboBoxDatabase.Margin = new Padding(0);
            comboBoxDatabase.Name = "comboBoxDatabase";
            comboBoxDatabase.Size = new Size(79, 23);
            comboBoxDatabase.TabIndex = 48;
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
            panel24.Controls.Add(comboBoxServidor);
            panel24.Controls.Add(label10);
            panel24.Dock = DockStyle.Fill;
            panel24.Location = new Point(3, 55);
            panel24.Name = "panel24";
            panel24.Size = new Size(148, 20);
            panel24.TabIndex = 1;
            // 
            // comboBoxServidor
            // 
            comboBoxServidor.Dock = DockStyle.Fill;
            comboBoxServidor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxServidor.FlatStyle = FlatStyle.Flat;
            comboBoxServidor.FormattingEnabled = true;
            comboBoxServidor.Items.AddRange(new object[] { "dbalgumacoisa", "dbmuitobom", "dbtrintaedois" });
            comboBoxServidor.Location = new Point(69, 0);
            comboBoxServidor.Margin = new Padding(0);
            comboBoxServidor.Name = "comboBoxServidor";
            comboBoxServidor.Size = new Size(79, 23);
            comboBoxServidor.TabIndex = 48;
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
            panel25.Controls.Add(comboBoxTipoObjeto);
            panel25.Controls.Add(label11);
            panel25.Dock = DockStyle.Fill;
            panel25.Location = new Point(3, 29);
            panel25.Name = "panel25";
            panel25.Size = new Size(148, 20);
            panel25.TabIndex = 41;
            // 
            // comboBoxTipoObjeto
            // 
            comboBoxTipoObjeto.Dock = DockStyle.Fill;
            comboBoxTipoObjeto.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipoObjeto.FlatStyle = FlatStyle.Flat;
            comboBoxTipoObjeto.FormattingEnabled = true;
            comboBoxTipoObjeto.Items.AddRange(new object[] { "dbalgumacoisa", "dbmuitobom", "dbtrintaedois" });
            comboBoxTipoObjeto.Location = new Point(69, 0);
            comboBoxTipoObjeto.Margin = new Padding(0);
            comboBoxTipoObjeto.Name = "comboBoxTipoObjeto";
            comboBoxTipoObjeto.Size = new Size(79, 23);
            comboBoxTipoObjeto.TabIndex = 48;
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
            panel26.Controls.Add(comboBoxProcesso);
            panel26.Controls.Add(label12);
            panel26.Dock = DockStyle.Fill;
            panel26.Location = new Point(3, 3);
            panel26.Name = "panel26";
            panel26.Size = new Size(148, 20);
            panel26.TabIndex = 0;
            // 
            // comboBoxProcesso
            // 
            comboBoxProcesso.Dock = DockStyle.Fill;
            comboBoxProcesso.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProcesso.FlatStyle = FlatStyle.Flat;
            comboBoxProcesso.FormattingEnabled = true;
            comboBoxProcesso.Items.AddRange(new object[] { "dbalgumacoisa", "dbmuitobom", "dbtrintaedois" });
            comboBoxProcesso.Location = new Point(69, 0);
            comboBoxProcesso.Margin = new Padding(0);
            comboBoxProcesso.Name = "comboBoxProcesso";
            comboBoxProcesso.Size = new Size(79, 23);
            comboBoxProcesso.TabIndex = 48;
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
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle5.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvPesquisar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvPesquisar.ColumnHeadersHeight = 28;
            dgvPesquisar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPesquisar.Columns.AddRange(new DataGridViewColumn[] { selecao, Servidor, Database, Schema, Objeto, Tipo, Processo });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvPesquisar.DefaultCellStyle = dataGridViewCellStyle6;
            dgvPesquisar.Dock = DockStyle.Fill;
            dgvPesquisar.EnableHeadersVisualStyles = false;
            dgvPesquisar.GridColor = Color.Silver;
            dgvPesquisar.Location = new Point(0, 28);
            dgvPesquisar.Margin = new Padding(0);
            dgvPesquisar.Name = "dgvPesquisar";
            dgvPesquisar.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.DarkSlateGray;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvPesquisar.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvPesquisar.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dgvPesquisar.RowsDefaultCellStyle = dataGridViewCellStyle8;
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
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel4.Controls.Add(dataGridView1, 0, 1);
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
            // FormPesquisar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPesquisar";
            Text = "FormPesquisar";
            Load += FormPesquisar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            panel18.ResumeLayout(false);
            panel23.ResumeLayout(false);
            panel24.ResumeLayout(false);
            panel25.ResumeLayout(false);
            panel26.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPesquisar).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnPesquisar;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnSolicitarAcesso;
        private Button btnSelecionar;
        private Button btnVerPrimeirasLinhas;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel17;
        private TextBox textBoxObjeto;
        private Label label6;
        private Panel panel18;
        private ComboBox comboBoxSchema;
        private Label label8;
        private Panel panel23;
        private ComboBox comboBoxDatabase;
        private Label label9;
        private Panel panel24;
        private ComboBox comboBoxServidor;
        private Label label10;
        private Panel panel25;
        private ComboBox comboBoxTipoObjeto;
        private Label label11;
        private Panel panel26;
        private ComboBox comboBoxProcesso;
        private Label label12;
        private DataGridView dgvPesquisar;
        private DataGridViewCheckBoxColumn selecao;
        private DataGridViewTextBoxColumn Servidor;
        private DataGridViewTextBoxColumn Database;
        private DataGridViewTextBoxColumn Schema;
        private DataGridViewTextBoxColumn Objeto;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Processo;
        private TableLayoutPanel tableLayoutPanel4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn Procedure;
        private DataGridViewTextBoxColumn View;
        private DataGridViewTextBoxColumn Trigger;
    }
}