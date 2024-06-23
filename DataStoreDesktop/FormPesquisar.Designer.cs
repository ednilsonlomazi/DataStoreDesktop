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
            tableLayoutPanel2 = new TableLayoutPanel();
            btn_pesquisar = new Button();
            panel29 = new Panel();
            btn_limpar_filtros = new Button();
            panel28 = new Panel();
            txtboxTipo = new TextBox();
            label16 = new Label();
            panel27 = new Panel();
            txtboxClasse = new TextBox();
            label14 = new Label();
            panel26 = new Panel();
            txtboxServidor = new TextBox();
            label15 = new Label();
            panel23 = new Panel();
            txtboxDatabase = new TextBox();
            label10 = new Label();
            panel24 = new Panel();
            txtboxSchema = new TextBox();
            label12 = new Label();
            panel25 = new Panel();
            txtboxName = new TextBox();
            label11 = new Label();
            dgvPesquisar = new DataGridView();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            selecao = new DataGridViewCheckBoxColumn();
            Servidor = new DataGridViewTextBoxColumn();
            Database = new DataGridViewTextBoxColumn();
            Schema = new DataGridViewTextBoxColumn();
            Objeto = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Classe = new DataGridViewTextBoxColumn();
            tableLayoutPanel2.SuspendLayout();
            panel29.SuspendLayout();
            panel28.SuspendLayout();
            panel27.SuspendLayout();
            panel26.SuspendLayout();
            panel23.SuspendLayout();
            panel24.SuspendLayout();
            panel25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPesquisar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(23, 24, 29);
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(btn_pesquisar, 3, 1);
            tableLayoutPanel2.Controls.Add(panel29, 2, 1);
            tableLayoutPanel2.Controls.Add(panel28, 0, 1);
            tableLayoutPanel2.Controls.Add(panel27, 0, 1);
            tableLayoutPanel2.Controls.Add(panel26, 0, 0);
            tableLayoutPanel2.Controls.Add(panel23, 1, 0);
            tableLayoutPanel2.Controls.Add(panel24, 2, 0);
            tableLayoutPanel2.Controls.Add(panel25, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(0, 15, 0, 0);
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(800, 105);
            tableLayoutPanel2.TabIndex = 32;
            // 
            // btn_pesquisar
            // 
            btn_pesquisar.BackColor = Color.FromArgb(23, 24, 29);
            btn_pesquisar.BackgroundImageLayout = ImageLayout.Center;
            btn_pesquisar.Dock = DockStyle.Top;
            btn_pesquisar.FlatAppearance.BorderSize = 0;
            btn_pesquisar.FlatStyle = FlatStyle.Flat;
            btn_pesquisar.ForeColor = Color.White;
            btn_pesquisar.Image = Properties.Resources.pesquisar_fill_16;
            btn_pesquisar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_pesquisar.Location = new Point(600, 60);
            btn_pesquisar.Margin = new Padding(0);
            btn_pesquisar.Name = "btn_pesquisar";
            btn_pesquisar.Size = new Size(200, 24);
            btn_pesquisar.TabIndex = 34;
            btn_pesquisar.Text = "          Pesquisar";
            btn_pesquisar.TextAlign = ContentAlignment.MiddleLeft;
            btn_pesquisar.UseVisualStyleBackColor = false;
            btn_pesquisar.Click += btn_pesquisar_form_pesquisar_Click;
            // 
            // panel29
            // 
            panel29.BackColor = Color.FromArgb(23, 24, 29);
            panel29.Controls.Add(btn_limpar_filtros);
            panel29.Location = new Point(403, 63);
            panel29.Name = "panel29";
            panel29.Size = new Size(194, 24);
            panel29.TabIndex = 32;
            // 
            // btn_limpar_filtros
            // 
            btn_limpar_filtros.BackColor = Color.FromArgb(23, 24, 29);
            btn_limpar_filtros.BackgroundImageLayout = ImageLayout.Center;
            btn_limpar_filtros.Dock = DockStyle.Top;
            btn_limpar_filtros.FlatAppearance.BorderSize = 0;
            btn_limpar_filtros.FlatStyle = FlatStyle.Flat;
            btn_limpar_filtros.ForeColor = Color.White;
            btn_limpar_filtros.Image = Properties.Resources.vassoura_16;
            btn_limpar_filtros.ImageAlign = ContentAlignment.MiddleLeft;
            btn_limpar_filtros.Location = new Point(0, 0);
            btn_limpar_filtros.Margin = new Padding(0);
            btn_limpar_filtros.Name = "btn_limpar_filtros";
            btn_limpar_filtros.Size = new Size(194, 24);
            btn_limpar_filtros.TabIndex = 17;
            btn_limpar_filtros.Text = "          Limpar";
            btn_limpar_filtros.TextAlign = ContentAlignment.MiddleLeft;
            btn_limpar_filtros.UseVisualStyleBackColor = false;
            btn_limpar_filtros.Click += btn_limpar_filtros_Click;
            // 
            // panel28
            // 
            panel28.BackColor = Color.FromArgb(23, 24, 29);
            panel28.Controls.Add(txtboxTipo);
            panel28.Controls.Add(label16);
            panel28.Dock = DockStyle.Top;
            panel28.Location = new Point(0, 60);
            panel28.Margin = new Padding(0);
            panel28.Name = "panel28";
            panel28.RightToLeft = RightToLeft.No;
            panel28.Size = new Size(200, 23);
            panel28.TabIndex = 41;
            // 
            // txtboxTipo
            // 
            txtboxTipo.BackColor = Color.FromArgb(23, 24, 29);
            txtboxTipo.BorderStyle = BorderStyle.None;
            txtboxTipo.Dock = DockStyle.Left;
            txtboxTipo.ForeColor = Color.White;
            txtboxTipo.Location = new Point(51, 0);
            txtboxTipo.Margin = new Padding(0);
            txtboxTipo.Name = "txtboxTipo";
            txtboxTipo.Size = new Size(167, 16);
            txtboxTipo.TabIndex = 1;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Dock = DockStyle.Left;
            label16.ForeColor = Color.White;
            label16.Location = new Point(0, 0);
            label16.Name = "label16";
            label16.Size = new Size(51, 15);
            label16.TabIndex = 0;
            label16.Text = "       Tipo";
            // 
            // panel27
            // 
            panel27.BackColor = Color.FromArgb(23, 24, 29);
            panel27.Controls.Add(txtboxClasse);
            panel27.Controls.Add(label14);
            panel27.Dock = DockStyle.Top;
            panel27.Location = new Point(200, 60);
            panel27.Margin = new Padding(0);
            panel27.Name = "panel27";
            panel27.RightToLeft = RightToLeft.No;
            panel27.Size = new Size(200, 23);
            panel27.TabIndex = 40;
            // 
            // txtboxClasse
            // 
            txtboxClasse.BackColor = Color.FromArgb(23, 24, 29);
            txtboxClasse.BorderStyle = BorderStyle.None;
            txtboxClasse.Dock = DockStyle.Left;
            txtboxClasse.ForeColor = Color.White;
            txtboxClasse.Location = new Point(55, 0);
            txtboxClasse.Margin = new Padding(0);
            txtboxClasse.Name = "txtboxClasse";
            txtboxClasse.Size = new Size(150, 16);
            txtboxClasse.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Dock = DockStyle.Left;
            label14.ForeColor = Color.White;
            label14.Location = new Point(0, 0);
            label14.Name = "label14";
            label14.Size = new Size(55, 15);
            label14.TabIndex = 0;
            label14.Text = "     Classe";
            // 
            // panel26
            // 
            panel26.BackColor = Color.FromArgb(23, 24, 29);
            panel26.Controls.Add(txtboxServidor);
            panel26.Controls.Add(label15);
            panel26.Dock = DockStyle.Top;
            panel26.Location = new Point(0, 15);
            panel26.Margin = new Padding(0);
            panel26.Name = "panel26";
            panel26.RightToLeft = RightToLeft.No;
            panel26.Size = new Size(200, 23);
            panel26.TabIndex = 36;
            // 
            // txtboxServidor
            // 
            txtboxServidor.BackColor = Color.FromArgb(23, 24, 29);
            txtboxServidor.BorderStyle = BorderStyle.None;
            txtboxServidor.Dock = DockStyle.Left;
            txtboxServidor.ForeColor = Color.White;
            txtboxServidor.Location = new Point(50, 0);
            txtboxServidor.Margin = new Padding(0);
            txtboxServidor.Name = "txtboxServidor";
            txtboxServidor.Size = new Size(150, 16);
            txtboxServidor.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Dock = DockStyle.Left;
            label15.ForeColor = Color.White;
            label15.Location = new Point(0, 0);
            label15.Name = "label15";
            label15.Size = new Size(50, 15);
            label15.TabIndex = 0;
            label15.Text = "Servidor";
            // 
            // panel23
            // 
            panel23.BackColor = Color.FromArgb(23, 24, 29);
            panel23.Controls.Add(txtboxDatabase);
            panel23.Controls.Add(label10);
            panel23.Dock = DockStyle.Top;
            panel23.Location = new Point(200, 15);
            panel23.Margin = new Padding(0);
            panel23.Name = "panel23";
            panel23.RightToLeft = RightToLeft.No;
            panel23.Size = new Size(200, 23);
            panel23.TabIndex = 37;
            // 
            // txtboxDatabase
            // 
            txtboxDatabase.BackColor = Color.FromArgb(23, 24, 29);
            txtboxDatabase.BorderStyle = BorderStyle.None;
            txtboxDatabase.Dock = DockStyle.Left;
            txtboxDatabase.ForeColor = Color.White;
            txtboxDatabase.Location = new Point(55, 0);
            txtboxDatabase.Margin = new Padding(0);
            txtboxDatabase.Name = "txtboxDatabase";
            txtboxDatabase.Size = new Size(150, 16);
            txtboxDatabase.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Left;
            label10.ForeColor = Color.White;
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 0;
            label10.Text = "Database";
            // 
            // panel24
            // 
            panel24.BackColor = Color.FromArgb(23, 24, 29);
            panel24.Controls.Add(txtboxSchema);
            panel24.Controls.Add(label12);
            panel24.Dock = DockStyle.Top;
            panel24.Location = new Point(400, 15);
            panel24.Margin = new Padding(0);
            panel24.Name = "panel24";
            panel24.RightToLeft = RightToLeft.No;
            panel24.Size = new Size(200, 23);
            panel24.TabIndex = 38;
            // 
            // txtboxSchema
            // 
            txtboxSchema.BackColor = Color.FromArgb(23, 24, 29);
            txtboxSchema.BorderStyle = BorderStyle.None;
            txtboxSchema.Dock = DockStyle.Left;
            txtboxSchema.ForeColor = Color.White;
            txtboxSchema.Location = new Point(49, 0);
            txtboxSchema.Margin = new Padding(0);
            txtboxSchema.Name = "txtboxSchema";
            txtboxSchema.Size = new Size(150, 16);
            txtboxSchema.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Left;
            label12.ForeColor = Color.White;
            label12.Location = new Point(0, 0);
            label12.Name = "label12";
            label12.Size = new Size(49, 15);
            label12.TabIndex = 0;
            label12.Text = "Schema";
            // 
            // panel25
            // 
            panel25.BackColor = Color.FromArgb(23, 24, 29);
            panel25.Controls.Add(txtboxName);
            panel25.Controls.Add(label11);
            panel25.Dock = DockStyle.Top;
            panel25.Location = new Point(600, 15);
            panel25.Margin = new Padding(0);
            panel25.Name = "panel25";
            panel25.RightToLeft = RightToLeft.No;
            panel25.Size = new Size(200, 23);
            panel25.TabIndex = 39;
            // 
            // txtboxName
            // 
            txtboxName.BackColor = Color.FromArgb(23, 24, 29);
            txtboxName.BorderStyle = BorderStyle.None;
            txtboxName.Dock = DockStyle.Left;
            txtboxName.ForeColor = Color.White;
            txtboxName.Location = new Point(40, 0);
            txtboxName.Margin = new Padding(0);
            txtboxName.Name = "txtboxName";
            txtboxName.Size = new Size(150, 16);
            txtboxName.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Left;
            label11.ForeColor = Color.White;
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Size = new Size(40, 15);
            label11.TabIndex = 0;
            label11.Text = "Nome";
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPesquisar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPesquisar.ColumnHeadersHeight = 28;
            dgvPesquisar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPesquisar.Columns.AddRange(new DataGridViewColumn[] { selecao, Servidor, Database, Schema, Objeto, Tipo, Classe });
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
            dgvPesquisar.Location = new Point(0, 105);
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
            dgvPesquisar.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPesquisar.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dgvPesquisar.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvPesquisar.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(23, 24, 29);
            dgvPesquisar.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(23, 24, 29);
            dgvPesquisar.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvPesquisar.Size = new Size(800, 345);
            dgvPesquisar.TabIndex = 33;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(394, 111);
            panel1.TabIndex = 34;
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeight = 28;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, Cliente });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.Silver;
            dataGridView1.Location = new Point(403, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.DarkSlateGray;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 333);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 117);
            tableLayoutPanel1.TabIndex = 36;
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
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dgvPesquisar);
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPesquisar";
            Text = "FormPesquisar";
            Load += FormPesquisar_Load;
            tableLayoutPanel2.ResumeLayout(false);
            panel29.ResumeLayout(false);
            panel28.ResumeLayout(false);
            panel28.PerformLayout();
            panel27.ResumeLayout(false);
            panel27.PerformLayout();
            panel26.ResumeLayout(false);
            panel26.PerformLayout();
            panel23.ResumeLayout(false);
            panel23.PerformLayout();
            panel24.ResumeLayout(false);
            panel24.PerformLayout();
            panel25.ResumeLayout(false);
            panel25.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPesquisar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel29;
        private Button btn_limpar_filtros;
        private Panel panel28;
        private TextBox txtboxTipo;
        private Label label16;
        private Panel panel27;
        private TextBox txtboxClasse;
        private Label label14;
        private Panel panel26;
        private TextBox txtboxServidor;
        private Label label15;
        private Panel panel23;
        private TextBox txtboxDatabase;
        private Label label10;
        private Panel panel24;
        private TextBox txtboxSchema;
        private Label label12;
        private Panel panel25;
        private TextBox txtboxName;
        private Label label11;
        private DataGridView dgvPesquisar;
        private Button btn_pesquisar;
        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn Cliente;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridViewCheckBoxColumn selecao;
        private DataGridViewTextBoxColumn Servidor;
        private DataGridViewTextBoxColumn Database;
        private DataGridViewTextBoxColumn Schema;
        private DataGridViewTextBoxColumn Objeto;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Classe;
    }
}