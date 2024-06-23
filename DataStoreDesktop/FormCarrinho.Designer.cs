namespace DataStoreDesktop
{
    partial class FormCarrinho
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            label4 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            panel22 = new Panel();
            btn_limpar_filtros = new Button();
            btn_pesquisar_form_pesquisar = new Button();
            btn_pesquisar = new Button();
            button1 = new Button();
            dgvPesquisar = new DataGridView();
            selecao = new DataGridViewCheckBoxColumn();
            Servidor = new DataGridViewTextBoxColumn();
            Database = new DataGridViewTextBoxColumn();
            Schema = new DataGridViewTextBoxColumn();
            Objeto = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Classe = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPesquisar).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(23, 24, 29);
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 0);
            label4.Margin = new Padding(0);
            label4.MinimumSize = new Size(259, 0);
            label4.Name = "label4";
            label4.Size = new Size(800, 17);
            label4.TabIndex = 0;
            label4.Text = "Qualtidade Solicitada";
            label4.TextAlign = ContentAlignment.BottomCenter;
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(23, 24, 29);
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 17);
            label2.Margin = new Padding(0);
            label2.MinimumSize = new Size(259, 0);
            label2.Name = "label2";
            label2.Size = new Size(800, 17);
            label2.TabIndex = 24;
            label2.Text = "23";
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(dgvPesquisar);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btn_pesquisar);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 25;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(23, 24, 29);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 76);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 0);
            flowLayoutPanel1.TabIndex = 26;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(23, 24, 29);
            panel2.Controls.Add(panel22);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 42);
            panel2.TabIndex = 25;
            // 
            // panel22
            // 
            panel22.BackColor = Color.FromArgb(23, 24, 29);
            panel22.Controls.Add(btn_limpar_filtros);
            panel22.Controls.Add(btn_pesquisar_form_pesquisar);
            panel22.Dock = DockStyle.Left;
            panel22.Location = new Point(0, 0);
            panel22.Name = "panel22";
            panel22.Size = new Size(336, 42);
            panel22.TabIndex = 26;
            // 
            // btn_limpar_filtros
            // 
            btn_limpar_filtros.BackColor = Color.FromArgb(23, 24, 29);
            btn_limpar_filtros.BackgroundImageLayout = ImageLayout.Center;
            btn_limpar_filtros.Dock = DockStyle.Left;
            btn_limpar_filtros.FlatAppearance.BorderSize = 0;
            btn_limpar_filtros.FlatStyle = FlatStyle.Flat;
            btn_limpar_filtros.ForeColor = Color.White;
            btn_limpar_filtros.Image = Properties.Resources.vassoura_16;
            btn_limpar_filtros.ImageAlign = ContentAlignment.MiddleLeft;
            btn_limpar_filtros.Location = new Point(0, 0);
            btn_limpar_filtros.Margin = new Padding(0);
            btn_limpar_filtros.Name = "btn_limpar_filtros";
            btn_limpar_filtros.Size = new Size(164, 42);
            btn_limpar_filtros.TabIndex = 17;
            btn_limpar_filtros.Text = "          Cancelar solicitação";
            btn_limpar_filtros.TextAlign = ContentAlignment.MiddleLeft;
            btn_limpar_filtros.UseVisualStyleBackColor = false;
            // 
            // btn_pesquisar_form_pesquisar
            // 
            btn_pesquisar_form_pesquisar.BackColor = Color.FromArgb(23, 24, 29);
            btn_pesquisar_form_pesquisar.BackgroundImageLayout = ImageLayout.Center;
            btn_pesquisar_form_pesquisar.Dock = DockStyle.Right;
            btn_pesquisar_form_pesquisar.FlatAppearance.BorderSize = 0;
            btn_pesquisar_form_pesquisar.FlatStyle = FlatStyle.Flat;
            btn_pesquisar_form_pesquisar.ForeColor = Color.White;
            btn_pesquisar_form_pesquisar.Image = Properties.Resources.enviar_16_azul;
            btn_pesquisar_form_pesquisar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_pesquisar_form_pesquisar.Location = new Point(172, 0);
            btn_pesquisar_form_pesquisar.Margin = new Padding(0);
            btn_pesquisar_form_pesquisar.Name = "btn_pesquisar_form_pesquisar";
            btn_pesquisar_form_pesquisar.Size = new Size(164, 42);
            btn_pesquisar_form_pesquisar.TabIndex = 19;
            btn_pesquisar_form_pesquisar.Text = "          Enviar solicitação";
            btn_pesquisar_form_pesquisar.TextAlign = ContentAlignment.MiddleLeft;
            btn_pesquisar_form_pesquisar.UseVisualStyleBackColor = false;
            // 
            // btn_pesquisar
            // 
            btn_pesquisar.BackColor = Color.FromArgb(23, 24, 29);
            btn_pesquisar.BackgroundImageLayout = ImageLayout.Center;
            btn_pesquisar.Dock = DockStyle.Left;
            btn_pesquisar.FlatAppearance.BorderSize = 0;
            btn_pesquisar.FlatStyle = FlatStyle.Flat;
            btn_pesquisar.ForeColor = Color.White;
            btn_pesquisar.Image = Properties.Resources.pesquisar_fill_16;
            btn_pesquisar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_pesquisar.Location = new Point(0, 76);
            btn_pesquisar.Margin = new Padding(0);
            btn_pesquisar.Name = "btn_pesquisar";
            btn_pesquisar.Size = new Size(167, 374);
            btn_pesquisar.TabIndex = 35;
            btn_pesquisar.Text = "          Pesquisar";
            btn_pesquisar.TextAlign = ContentAlignment.MiddleLeft;
            btn_pesquisar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(23, 24, 29);
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Dock = DockStyle.Left;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.vassoura_16;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(167, 76);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(167, 374);
            button1.TabIndex = 36;
            button1.Text = "          Opções";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
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
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvPesquisar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvPesquisar.ColumnHeadersHeight = 28;
            dgvPesquisar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPesquisar.Columns.AddRange(new DataGridViewColumn[] { selecao, Servidor, Database, Schema, Objeto, Tipo, Classe });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvPesquisar.DefaultCellStyle = dataGridViewCellStyle8;
            dgvPesquisar.EnableHeadersVisualStyles = false;
            dgvPesquisar.GridColor = Color.Silver;
            dgvPesquisar.Location = new Point(0, 110);
            dgvPesquisar.Name = "dgvPesquisar";
            dgvPesquisar.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = Color.DarkSlateGray;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvPesquisar.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvPesquisar.RowHeadersVisible = false;
            dgvPesquisar.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPesquisar.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dgvPesquisar.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvPesquisar.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(23, 24, 29);
            dgvPesquisar.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(23, 24, 29);
            dgvPesquisar.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvPesquisar.Size = new Size(800, 231);
            dgvPesquisar.TabIndex = 37;
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
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(23, 24, 29);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button4);
            panel3.Location = new Point(113, 209);
            panel3.Name = "panel3";
            panel3.Size = new Size(574, 32);
            panel3.TabIndex = 38;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(23, 24, 29);
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Dock = DockStyle.Left;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.vassoura_16;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(334, 0);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(167, 32);
            button2.TabIndex = 38;
            button2.Text = "          Limpar";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(23, 24, 29);
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.Dock = DockStyle.Left;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Image = Properties.Resources.vassoura_16;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(167, 0);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(167, 32);
            button3.TabIndex = 37;
            button3.Text = "          Opções";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(23, 24, 29);
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.Dock = DockStyle.Left;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Image = Properties.Resources.pesquisar_fill_16;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 0);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(167, 32);
            button4.TabIndex = 36;
            button4.Text = "          Pesquisar";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // FormCarrinho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCarrinho";
            Text = "FormCarrinho";
            Load += FormCarrinho_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel22.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPesquisar).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel22;
        private Button btn_limpar_filtros;
        private Button btn_pesquisar_form_pesquisar;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button btn_pesquisar;
        private DataGridView dgvPesquisar;
        private DataGridViewCheckBoxColumn selecao;
        private DataGridViewTextBoxColumn Servidor;
        private DataGridViewTextBoxColumn Database;
        private DataGridViewTextBoxColumn Schema;
        private DataGridViewTextBoxColumn Objeto;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Classe;
        private Panel panel3;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}