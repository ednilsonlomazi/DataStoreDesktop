namespace DataStoreDesktop
{
    partial class FormMeusObjetos
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel22 = new Panel();
            btn_limpar_filtros = new Button();
            btn_pesquisar_form_pesquisar = new Button();
            panel19 = new Panel();
            panel20 = new Panel();
            label7 = new Label();
            txtboxClasse = new TextBox();
            panel21 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            label3 = new Label();
            txtboxDatabase = new TextBox();
            panel9 = new Panel();
            panel13 = new Panel();
            panel14 = new Panel();
            label5 = new Label();
            txtboxName = new TextBox();
            panel15 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            txtboxTipo = new TextBox();
            panel1 = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
            label4 = new Label();
            txtboxSchema = new TextBox();
            panel12 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            label2 = new Label();
            txtboxServidor = new TextBox();
            panel6 = new Panel();
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
            tableLayoutPanel3 = new TableLayoutPanel();
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
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel22.SuspendLayout();
            panel19.SuspendLayout();
            panel20.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPesquisar).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            panel17.SuspendLayout();
            panel18.SuspendLayout();
            panel23.SuspendLayout();
            panel24.SuspendLayout();
            panel25.SuspendLayout();
            panel26.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(23, 24, 29);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel1);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 103);
            flowLayoutPanel1.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(panel22, 0, 2);
            tableLayoutPanel1.Controls.Add(panel19, 2, 1);
            tableLayoutPanel1.Controls.Add(panel7, 0, 1);
            tableLayoutPanel1.Controls.Add(panel13, 1, 1);
            tableLayoutPanel1.Controls.Add(panel3, 2, 0);
            tableLayoutPanel1.Controls.Add(panel10, 1, 0);
            tableLayoutPanel1.Controls.Add(panel4, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(797, 90);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // panel22
            // 
            panel22.BackColor = Color.FromArgb(23, 24, 29);
            panel22.Controls.Add(btn_limpar_filtros);
            panel22.Controls.Add(btn_pesquisar_form_pesquisar);
            panel22.Dock = DockStyle.Fill;
            panel22.Location = new Point(3, 63);
            panel22.Name = "panel22";
            panel22.Size = new Size(259, 24);
            panel22.TabIndex = 20;
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
            btn_limpar_filtros.Size = new Size(100, 24);
            btn_limpar_filtros.TabIndex = 17;
            btn_limpar_filtros.Text = "          Limpar";
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
            btn_pesquisar_form_pesquisar.Image = Properties.Resources.pesquisar_fill_16;
            btn_pesquisar_form_pesquisar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_pesquisar_form_pesquisar.Location = new Point(159, 0);
            btn_pesquisar_form_pesquisar.Margin = new Padding(0);
            btn_pesquisar_form_pesquisar.Name = "btn_pesquisar_form_pesquisar";
            btn_pesquisar_form_pesquisar.Size = new Size(100, 24);
            btn_pesquisar_form_pesquisar.TabIndex = 19;
            btn_pesquisar_form_pesquisar.Text = "          Pesquisar";
            btn_pesquisar_form_pesquisar.TextAlign = ContentAlignment.MiddleLeft;
            btn_pesquisar_form_pesquisar.UseVisualStyleBackColor = false;
            // 
            // panel19
            // 
            panel19.BackColor = Color.FromArgb(23, 24, 29);
            panel19.Controls.Add(panel20);
            panel19.Controls.Add(panel21);
            panel19.Location = new Point(533, 33);
            panel19.Name = "panel19";
            panel19.Size = new Size(261, 24);
            panel19.TabIndex = 18;
            // 
            // panel20
            // 
            panel20.BackColor = Color.FromArgb(23, 24, 29);
            panel20.Controls.Add(label7);
            panel20.Controls.Add(txtboxClasse);
            panel20.Dock = DockStyle.Top;
            panel20.Location = new Point(0, 0);
            panel20.Margin = new Padding(0);
            panel20.Name = "panel20";
            panel20.Size = new Size(261, 24);
            panel20.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(23, 24, 29);
            label7.Dock = DockStyle.Left;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(0, 0);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(45, 17);
            label7.TabIndex = 0;
            label7.Text = "Classe";
            label7.TextAlign = ContentAlignment.BottomCenter;
            // 
            // txtboxClasse
            // 
            txtboxClasse.BackColor = Color.FromArgb(23, 24, 29);
            txtboxClasse.BorderStyle = BorderStyle.None;
            txtboxClasse.Dock = DockStyle.Right;
            txtboxClasse.Font = new Font("Segoe UI", 10F);
            txtboxClasse.ForeColor = Color.White;
            txtboxClasse.Location = new Point(45, 0);
            txtboxClasse.Margin = new Padding(0);
            txtboxClasse.Name = "txtboxClasse";
            txtboxClasse.Size = new Size(216, 18);
            txtboxClasse.TabIndex = 5;
            // 
            // panel21
            // 
            panel21.BackColor = Color.FromArgb(23, 24, 29);
            panel21.BorderStyle = BorderStyle.FixedSingle;
            panel21.Dock = DockStyle.Bottom;
            panel21.Location = new Point(0, 22);
            panel21.Margin = new Padding(0);
            panel21.Name = "panel21";
            panel21.Size = new Size(261, 2);
            panel21.TabIndex = 6;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(23, 24, 29);
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(panel9);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(3, 33);
            panel7.Name = "panel7";
            panel7.Size = new Size(259, 24);
            panel7.TabIndex = 16;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(23, 24, 29);
            panel8.Controls.Add(label3);
            panel8.Controls.Add(txtboxDatabase);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(259, 24);
            panel8.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(23, 24, 29);
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(63, 17);
            label3.TabIndex = 0;
            label3.Text = "Database";
            label3.TextAlign = ContentAlignment.BottomCenter;
            // 
            // txtboxDatabase
            // 
            txtboxDatabase.BackColor = Color.FromArgb(23, 24, 29);
            txtboxDatabase.BorderStyle = BorderStyle.None;
            txtboxDatabase.Dock = DockStyle.Right;
            txtboxDatabase.Font = new Font("Segoe UI", 10F);
            txtboxDatabase.ForeColor = Color.White;
            txtboxDatabase.Location = new Point(63, 0);
            txtboxDatabase.Margin = new Padding(0);
            txtboxDatabase.Name = "txtboxDatabase";
            txtboxDatabase.Size = new Size(196, 18);
            txtboxDatabase.TabIndex = 5;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(23, 24, 29);
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Dock = DockStyle.Bottom;
            panel9.Location = new Point(0, 22);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Size = new Size(259, 2);
            panel9.TabIndex = 6;
            // 
            // panel13
            // 
            panel13.BackColor = Color.FromArgb(23, 24, 29);
            panel13.Controls.Add(panel14);
            panel13.Controls.Add(panel15);
            panel13.Dock = DockStyle.Top;
            panel13.Location = new Point(268, 33);
            panel13.Name = "panel13";
            panel13.Size = new Size(259, 24);
            panel13.TabIndex = 17;
            // 
            // panel14
            // 
            panel14.BackColor = Color.FromArgb(23, 24, 29);
            panel14.Controls.Add(label5);
            panel14.Controls.Add(txtboxName);
            panel14.Dock = DockStyle.Top;
            panel14.Location = new Point(0, 0);
            panel14.Margin = new Padding(0);
            panel14.Name = "panel14";
            panel14.Size = new Size(259, 24);
            panel14.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(23, 24, 29);
            label5.Dock = DockStyle.Left;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(0, 0);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(44, 17);
            label5.TabIndex = 0;
            label5.Text = "Nome";
            label5.TextAlign = ContentAlignment.BottomCenter;
            // 
            // txtboxName
            // 
            txtboxName.BackColor = Color.FromArgb(23, 24, 29);
            txtboxName.BorderStyle = BorderStyle.None;
            txtboxName.Dock = DockStyle.Right;
            txtboxName.Font = new Font("Segoe UI", 10F);
            txtboxName.ForeColor = Color.White;
            txtboxName.Location = new Point(53, 0);
            txtboxName.Margin = new Padding(0);
            txtboxName.Name = "txtboxName";
            txtboxName.Size = new Size(206, 18);
            txtboxName.TabIndex = 5;
            // 
            // panel15
            // 
            panel15.BackColor = Color.FromArgb(23, 24, 29);
            panel15.BorderStyle = BorderStyle.FixedSingle;
            panel15.Dock = DockStyle.Bottom;
            panel15.Location = new Point(0, 22);
            panel15.Margin = new Padding(0);
            panel15.Name = "panel15";
            panel15.Size = new Size(259, 2);
            panel15.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(23, 24, 29);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(panel1);
            panel3.Location = new Point(533, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(261, 24);
            panel3.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(23, 24, 29);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtboxTipo);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(261, 24);
            panel2.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(23, 24, 29);
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(34, 17);
            label1.TabIndex = 0;
            label1.Text = "Tipo";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // txtboxTipo
            // 
            txtboxTipo.BackColor = Color.FromArgb(23, 24, 29);
            txtboxTipo.BorderStyle = BorderStyle.None;
            txtboxTipo.Dock = DockStyle.Right;
            txtboxTipo.Font = new Font("Segoe UI", 10F);
            txtboxTipo.ForeColor = Color.White;
            txtboxTipo.Location = new Point(45, 0);
            txtboxTipo.Margin = new Padding(0);
            txtboxTipo.Name = "txtboxTipo";
            txtboxTipo.Size = new Size(216, 18);
            txtboxTipo.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 24, 29);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 22);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(261, 2);
            panel1.TabIndex = 6;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(23, 24, 29);
            panel10.Controls.Add(panel11);
            panel10.Controls.Add(panel12);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(268, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(259, 24);
            panel10.TabIndex = 17;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(23, 24, 29);
            panel11.Controls.Add(label4);
            panel11.Controls.Add(txtboxSchema);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(0, 0);
            panel11.Margin = new Padding(0);
            panel11.Name = "panel11";
            panel11.Size = new Size(259, 24);
            panel11.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(23, 24, 29);
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 0);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(53, 17);
            label4.TabIndex = 0;
            label4.Text = "Schema";
            label4.TextAlign = ContentAlignment.BottomCenter;
            // 
            // txtboxSchema
            // 
            txtboxSchema.BackColor = Color.FromArgb(23, 24, 29);
            txtboxSchema.BorderStyle = BorderStyle.None;
            txtboxSchema.Dock = DockStyle.Right;
            txtboxSchema.Font = new Font("Segoe UI", 10F);
            txtboxSchema.ForeColor = Color.White;
            txtboxSchema.Location = new Point(53, 0);
            txtboxSchema.Margin = new Padding(0);
            txtboxSchema.Name = "txtboxSchema";
            txtboxSchema.Size = new Size(206, 18);
            txtboxSchema.TabIndex = 5;
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(23, 24, 29);
            panel12.BorderStyle = BorderStyle.FixedSingle;
            panel12.Dock = DockStyle.Bottom;
            panel12.Location = new Point(0, 22);
            panel12.Margin = new Padding(0);
            panel12.Name = "panel12";
            panel12.Size = new Size(259, 2);
            panel12.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(23, 24, 29);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(panel6);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(259, 24);
            panel4.TabIndex = 14;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(23, 24, 29);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(txtboxServidor);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(259, 24);
            panel5.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(23, 24, 29);
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(57, 17);
            label2.TabIndex = 0;
            label2.Text = "Servidor";
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // txtboxServidor
            // 
            txtboxServidor.BackColor = Color.FromArgb(23, 24, 29);
            txtboxServidor.BorderStyle = BorderStyle.None;
            txtboxServidor.Dock = DockStyle.Right;
            txtboxServidor.Font = new Font("Segoe UI", 10F);
            txtboxServidor.ForeColor = Color.White;
            txtboxServidor.Location = new Point(63, 0);
            txtboxServidor.Margin = new Padding(0);
            txtboxServidor.Name = "txtboxServidor";
            txtboxServidor.Size = new Size(196, 18);
            txtboxServidor.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(23, 24, 29);
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 22);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(259, 2);
            panel6.TabIndex = 6;
            // 
            // panel16
            // 
            panel16.BackColor = Color.White;
            panel16.Dock = DockStyle.Bottom;
            panel16.Location = new Point(0, 394);
            panel16.Name = "panel16";
            panel16.Size = new Size(800, 56);
            panel16.TabIndex = 50;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(dgvPesquisar, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 103);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(800, 347);
            tableLayoutPanel2.TabIndex = 49;
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
            dgvPesquisar.Size = new Size(640, 327);
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
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(panel17, 0, 5);
            tableLayoutPanel3.Controls.Add(panel18, 0, 4);
            tableLayoutPanel3.Controls.Add(panel23, 0, 3);
            tableLayoutPanel3.Controls.Add(panel24, 0, 2);
            tableLayoutPanel3.Controls.Add(panel25, 0, 1);
            tableLayoutPanel3.Controls.Add(panel26, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(643, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 6;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(154, 153);
            tableLayoutPanel3.TabIndex = 40;
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
            // FormMeusObjetos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(panel16);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMeusObjetos";
            Text = "FormMeusObjetos";
            Load += FormMeusObjetos_Load;
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel22.ResumeLayout(false);
            panel19.ResumeLayout(false);
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel13.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel10.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPesquisar).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
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

        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel22;
        private Button btn_limpar_filtros;
        private Button btn_pesquisar_form_pesquisar;
        private Panel panel19;
        private Panel panel20;
        private Label label7;
        private TextBox txtboxClasse;
        private Panel panel21;
        private Panel panel7;
        private Panel panel8;
        private Label label3;
        private TextBox txtboxDatabase;
        private Panel panel9;
        private Panel panel13;
        private Panel panel14;
        private Label label5;
        private TextBox txtboxName;
        private Panel panel15;
        private Panel panel3;
        private Panel panel2;
        private Label label1;
        private TextBox txtboxTipo;
        private Panel panel1;
        private Panel panel10;
        private Panel panel11;
        private Label label4;
        private TextBox txtboxSchema;
        private Panel panel12;
        private Panel panel4;
        private Panel panel5;
        private Label label2;
        private TextBox txtboxServidor;
        private Panel panel6;
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
        private TableLayoutPanel tableLayoutPanel3;
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