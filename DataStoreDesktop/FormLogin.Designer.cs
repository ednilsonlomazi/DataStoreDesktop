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
            textBox1 = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            textBox2 = new TextBox();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
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
            btn_login.Location = new Point(103, 0);
            btn_login.Margin = new Padding(0);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(103, 28);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(23, 24, 29);
            textBox1.Dock = DockStyle.Top;
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(0, 15);
            textBox1.MaximumSize = new Size(0, 42);
            textBox1.MinimumSize = new Size(0, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 28);
            textBox1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(btn_login);
            panel1.Location = new Point(53, 161);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 28);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(53, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(206, 48);
            panel2.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(53, 107);
            panel3.Name = "panel3";
            panel3.Size = new Size(206, 48);
            panel3.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(23, 24, 29);
            textBox2.Dock = DockStyle.Top;
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(0, 15);
            textBox2.MinimumSize = new Size(0, 28);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(206, 28);
            textBox2.TabIndex = 5;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 0;
            label2.Text = "Senha";
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
            flowLayoutPanel1.Padding = new Padding(50);
            flowLayoutPanel1.Size = new Size(307, 450);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
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
        private TextBox textBox1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox textBox2;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}