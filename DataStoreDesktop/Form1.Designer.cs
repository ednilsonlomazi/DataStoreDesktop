namespace DataStoreDesktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            menuHomeContainer = new FlowLayoutPanel();
            btnMenuHome = new Button();
            button4 = new Button();
            button5 = new Button();
            button1 = new Button();
            button3 = new Button();
            button6 = new Button();
            timerMenuTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            menuHomeContainer.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 28);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.menu_16;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(23, 24, 29);
            flowLayoutPanel1.Controls.Add(menuHomeContainer);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 28);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 422);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // menuHomeContainer
            // 
            menuHomeContainer.BackColor = Color.FromArgb(32, 33, 36);
            menuHomeContainer.Controls.Add(btnMenuHome);
            menuHomeContainer.Controls.Add(button4);
            menuHomeContainer.Controls.Add(button5);
            menuHomeContainer.Location = new Point(3, 3);
            menuHomeContainer.Name = "menuHomeContainer";
            menuHomeContainer.Size = new Size(167, 42);
            menuHomeContainer.TabIndex = 2;
            // 
            // btnMenuHome
            // 
            btnMenuHome.BackColor = Color.FromArgb(23, 24, 29);
            btnMenuHome.BackgroundImageLayout = ImageLayout.Center;
            btnMenuHome.FlatAppearance.BorderSize = 0;
            btnMenuHome.FlatStyle = FlatStyle.Flat;
            btnMenuHome.Image = Properties.Resources.casa_16;
            btnMenuHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuHome.Location = new Point(0, 0);
            btnMenuHome.Margin = new Padding(0);
            btnMenuHome.Name = "btnMenuHome";
            btnMenuHome.Size = new Size(167, 42);
            btnMenuHome.TabIndex = 3;
            btnMenuHome.Text = "        Home";
            btnMenuHome.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuHome.UseVisualStyleBackColor = false;
            btnMenuHome.Click += btnMenuHome_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(32, 33, 36);
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = Properties.Resources.círculo_preenchido_12;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 42);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(167, 42);
            button4.TabIndex = 5;
            button4.Text = "        Meus objetos";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(32, 33, 36);
            button5.BackgroundImageLayout = ImageLayout.Center;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Image = Properties.Resources.círculo_preenchido_12;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 84);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(167, 42);
            button5.TabIndex = 6;
            button5.Text = "        Histórico de solicitações";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(23, 24, 29);
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.pesquisar_16;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 51);
            button1.Name = "button1";
            button1.Size = new Size(167, 42);
            button1.TabIndex = 2;
            button1.Text = "        Pesquisar";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(23, 24, 29);
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.carrinho_16;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(3, 99);
            button3.Name = "button3";
            button3.Size = new Size(167, 42);
            button3.TabIndex = 4;
            button3.Text = "        Carrinho";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(23, 24, 29);
            button6.BackgroundImageLayout = ImageLayout.Center;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = Properties.Resources.porta_16;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(3, 147);
            button6.Name = "button6";
            button6.Size = new Size(167, 42);
            button6.TabIndex = 5;
            button6.Text = "        Sair";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            // 
            // timerMenuTransition
            // 
            timerMenuTransition.Tick += timerMenuTransition_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            menuHomeContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button btnMenuHome;
        private Button button3;
        private FlowLayoutPanel menuHomeContainer;
        private Button button4;
        private Button button5;
        private Button button6;
        private System.Windows.Forms.Timer timerMenuTransition;
    }
}
