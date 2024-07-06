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
            label4 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel5 = new Panel();
            btnVerPrimeirasLinhas = new Button();
            btnSolicitarAcesso = new Button();
            btn_limpar = new Button();
            btn_pesquisar = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            panel22 = new Panel();
            btn_limpar_filtros = new Button();
            btn_pesquisar_form_pesquisar = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel4 = new Panel();
            comboBox4 = new ComboBox();
            panel3 = new Panel();
            comboBox3 = new ComboBox();
            panel28 = new Panel();
            comboBox2 = new ComboBox();
            panel27 = new Panel();
            comboBox1 = new ComboBox();
            comboBox5 = new ComboBox();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel22.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel28.SuspendLayout();
            panel27.SuspendLayout();
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
            panel1.Controls.Add(comboBox5);
            panel1.Controls.Add(panel5);
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
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(32, 33, 36);
            panel5.Controls.Add(btnVerPrimeirasLinhas);
            panel5.Controls.Add(btnSolicitarAcesso);
            panel5.Controls.Add(btn_limpar);
            panel5.Controls.Add(btn_pesquisar);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 76);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(800, 32);
            panel5.TabIndex = 40;
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
            btnVerPrimeirasLinhas.Size = new Size(167, 32);
            btnVerPrimeirasLinhas.TabIndex = 40;
            btnVerPrimeirasLinhas.Text = "          Ver Primeiras Linhas";
            btnVerPrimeirasLinhas.TextAlign = ContentAlignment.MiddleLeft;
            btnVerPrimeirasLinhas.UseVisualStyleBackColor = false;
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
            btnSolicitarAcesso.Size = new Size(167, 32);
            btnSolicitarAcesso.TabIndex = 39;
            btnSolicitarAcesso.Text = "          Solicitar Acesso";
            btnSolicitarAcesso.TextAlign = ContentAlignment.MiddleLeft;
            btnSolicitarAcesso.UseVisualStyleBackColor = false;
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
            btn_limpar.Size = new Size(167, 32);
            btn_limpar.TabIndex = 38;
            btn_limpar.Text = "          Limpar";
            btn_limpar.TextAlign = ContentAlignment.MiddleLeft;
            btn_limpar.UseVisualStyleBackColor = false;
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
            btn_pesquisar.Size = new Size(167, 32);
            btn_pesquisar.TabIndex = 36;
            btn_pesquisar.Text = "          Pesquisar";
            btn_pesquisar.TextAlign = ContentAlignment.MiddleLeft;
            btn_pesquisar.UseVisualStyleBackColor = false;
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(23, 24, 29);
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(panel4, 0, 0);
            tableLayoutPanel2.Controls.Add(panel3, 0, 0);
            tableLayoutPanel2.Controls.Add(panel28, 0, 0);
            tableLayoutPanel2.Controls.Add(panel27, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(800, 50);
            tableLayoutPanel2.TabIndex = 33;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(comboBox4);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(400, 0);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.RightToLeft = RightToLeft.No;
            panel4.Size = new Size(200, 23);
            panel4.TabIndex = 43;
            // 
            // comboBox4
            // 
            comboBox4.Dock = DockStyle.Left;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Tabela", "View", "Procedure" });
            comboBox4.Location = new Point(0, 0);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(150, 23);
            comboBox4.TabIndex = 0;
            comboBox4.Text = "Tipo do objeto";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(comboBox3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(600, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.RightToLeft = RightToLeft.No;
            panel3.Size = new Size(200, 23);
            panel3.TabIndex = 42;
            // 
            // comboBox3
            // 
            comboBox3.Dock = DockStyle.Left;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Faturamento", "Pagamentos" });
            comboBox3.Location = new Point(0, 0);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(200, 23);
            comboBox3.TabIndex = 0;
            comboBox3.Text = "Processo Sistêmico";
            // 
            // panel28
            // 
            panel28.BackColor = Color.White;
            panel28.Controls.Add(comboBox2);
            panel28.Dock = DockStyle.Top;
            panel28.Location = new Point(0, 0);
            panel28.Margin = new Padding(0);
            panel28.Name = "panel28";
            panel28.RightToLeft = RightToLeft.No;
            panel28.Size = new Size(200, 23);
            panel28.TabIndex = 41;
            // 
            // comboBox2
            // 
            comboBox2.Dock = DockStyle.Left;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "SERVERXYZ", "SERVERZZZ", "SERVERABC" });
            comboBox2.Location = new Point(0, 0);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(200, 23);
            comboBox2.TabIndex = 1;
            comboBox2.Text = "Servidor";
            // 
            // panel27
            // 
            panel27.BackColor = Color.White;
            panel27.Controls.Add(comboBox1);
            panel27.Dock = DockStyle.Top;
            panel27.Location = new Point(200, 0);
            panel27.Margin = new Padding(0);
            panel27.Name = "panel27";
            panel27.RightToLeft = RightToLeft.No;
            panel27.Size = new Size(200, 23);
            panel27.TabIndex = 40;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Left;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "dbalgumacoisa", "dbmuitobom", "dbtrintaedois" });
            comboBox1.Location = new Point(0, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 23);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "Banco de dados";
            // 
            // comboBox5
            // 
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.FlatStyle = FlatStyle.Flat;
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "dbalgumacoisa", "dbmuitobom", "dbtrintaedois" });
            comboBox5.Location = new Point(328, 214);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(145, 23);
            comboBox5.TabIndex = 41;
            // 
            // FormCarrinho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCarrinho";
            Text = "FormCarrinho";
            Load += FormCarrinho_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel22.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel28.ResumeLayout(false);
            panel27.ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel4;
        private ComboBox comboBox4;
        private Panel panel3;
        private ComboBox comboBox3;
        private Panel panel28;
        private ComboBox comboBox2;
        private Panel panel27;
        private ComboBox comboBox1;
        private Panel panel5;
        private Button btnVerPrimeirasLinhas;
        private Button btnSolicitarAcesso;
        private Button btn_limpar;
        private Button btn_pesquisar;
        private ComboBox comboBox5;
    }
}