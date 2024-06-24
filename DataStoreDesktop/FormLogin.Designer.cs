namespace DataStoreDesktop
{
    partial class FormLogin
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
            label1 = new Label();
            btn_login = new Button();
            txtboxLoginUsuario = new TextBox();
            panel1 = new Panel();
            btn_login_sair = new Button();
            panel2 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            txtboxLoginSenha = new TextBox();
            label2 = new Label();
            panel5 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuário";
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.White;
            btn_login.BackgroundImageLayout = ImageLayout.Center;
            btn_login.Dock = DockStyle.Right;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.ForeColor = Color.FromArgb(23, 24, 29);
            btn_login.ImageAlign = ContentAlignment.MiddleLeft;
            btn_login.Location = new Point(121, 30);
            btn_login.Margin = new Padding(0);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(85, 28);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // txtboxLoginUsuario
            // 
            txtboxLoginUsuario.BackColor = Color.FromArgb(23, 24, 29);
            txtboxLoginUsuario.BorderStyle = BorderStyle.None;
            txtboxLoginUsuario.Dock = DockStyle.Top;
            txtboxLoginUsuario.ForeColor = Color.White;
            txtboxLoginUsuario.Location = new Point(47, 0);
            txtboxLoginUsuario.Margin = new Padding(0);
            txtboxLoginUsuario.MaximumSize = new Size(0, 42);
            txtboxLoginUsuario.MinimumSize = new Size(0, 20);
            txtboxLoginUsuario.Name = "txtboxLoginUsuario";
            txtboxLoginUsuario.Size = new Size(159, 20);
            txtboxLoginUsuario.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(btn_login_sair);
            panel1.Controls.Add(btn_login);
            panel1.Location = new Point(50, 201);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 30, 0, 0);
            panel1.Size = new Size(206, 58);
            panel1.TabIndex = 9;
            // 
            // btn_login_sair
            // 
            btn_login_sair.BackColor = Color.White;
            btn_login_sair.BackgroundImageLayout = ImageLayout.Center;
            btn_login_sair.Dock = DockStyle.Left;
            btn_login_sair.FlatAppearance.BorderSize = 0;
            btn_login_sair.FlatStyle = FlatStyle.Flat;
            btn_login_sair.ForeColor = Color.FromArgb(23, 24, 29);
            btn_login_sair.ImageAlign = ContentAlignment.MiddleLeft;
            btn_login_sair.Location = new Point(0, 30);
            btn_login_sair.Margin = new Padding(0);
            btn_login_sair.Name = "btn_login_sair";
            btn_login_sair.Size = new Size(85, 28);
            btn_login_sair.TabIndex = 13;
            btn_login_sair.Text = "Sair";
            btn_login_sair.UseVisualStyleBackColor = false;
            btn_login_sair.Click += btn_login_sair_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(txtboxLoginUsuario);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(50, 140);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(206, 24);
            panel2.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 22);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(206, 2);
            panel4.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.Controls.Add(txtboxLoginSenha);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(50, 164);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 8, 0, 0);
            panel3.Size = new Size(206, 37);
            panel3.TabIndex = 11;
            // 
            // txtboxLoginSenha
            // 
            txtboxLoginSenha.BackColor = Color.FromArgb(23, 24, 29);
            txtboxLoginSenha.BorderStyle = BorderStyle.None;
            txtboxLoginSenha.Dock = DockStyle.Top;
            txtboxLoginSenha.ForeColor = Color.White;
            txtboxLoginSenha.Location = new Point(39, 8);
            txtboxLoginSenha.MinimumSize = new Size(0, 20);
            txtboxLoginSenha.Name = "txtboxLoginSenha";
            txtboxLoginSenha.Size = new Size(167, 20);
            txtboxLoginSenha.TabIndex = 5;
            txtboxLoginSenha.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 8);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 0;
            label2.Text = "Senha";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 35);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(206, 2);
            panel5.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(23, 24, 29);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.ForeColor = SystemColors.ControlText;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(50, 140, 50, 50);
            flowLayoutPanel1.Size = new Size(307, 450);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(23, 24, 29);
            label3.Image = Properties.Resources.banco_de_dados_100;
            label3.Location = new Point(307, 0);
            label3.MaximumSize = new Size(2000, 340);
            label3.MinimumSize = new Size(0, 40);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 140, 0, 0);
            label3.Size = new Size(493, 340);
            label3.TabIndex = 13;
            label3.Text = "Data Store Desktop";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            Text = "FormLogin";
            Load += FormLogout_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btn_login;
        private TextBox txtboxLoginUsuario;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtboxLoginSenha;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn_login_sair;
        private Label label3;
        private Panel panel4;
        private Panel panel5;
    }
}