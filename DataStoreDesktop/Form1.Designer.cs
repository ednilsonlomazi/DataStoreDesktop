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
            btn_maximizar = new Button();
            btn_sair = new Button();
            label1 = new Label();
            btnSideBarExpand = new PictureBox();
            pannelSideBar = new FlowLayoutPanel();
            menuHomeContainer = new FlowLayoutPanel();
            btnMenuHome = new Button();
            btnHomeMeusObjetos = new Button();
            btnHomeSolicitacoes = new Button();
            pnPesquisar = new FlowLayoutPanel();
            btnPesquisar = new Button();
            pnCarrinho = new FlowLayoutPanel();
            btnCarrinho = new Button();
            pnSair = new FlowLayoutPanel();
            button7 = new Button();
            timerMenuTransition = new System.Windows.Forms.Timer(components);
            sideBarTransition = new System.Windows.Forms.Timer(components);
            btn_minimizar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSideBarExpand).BeginInit();
            pannelSideBar.SuspendLayout();
            menuHomeContainer.SuspendLayout();
            pnPesquisar.SuspendLayout();
            pnCarrinho.SuspendLayout();
            pnSair.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btn_minimizar);
            panel1.Controls.Add(btn_maximizar);
            panel1.Controls.Add(btn_sair);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSideBarExpand);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 28);
            panel1.TabIndex = 0;
            // 
            // btn_maximizar
            // 
            btn_maximizar.BackColor = Color.White;
            btn_maximizar.BackgroundImageLayout = ImageLayout.Center;
            btn_maximizar.Dock = DockStyle.Right;
            btn_maximizar.FlatAppearance.BorderSize = 0;
            btn_maximizar.FlatStyle = FlatStyle.Flat;
            btn_maximizar.ForeColor = Color.FromArgb(23, 24, 29);
            btn_maximizar.Image = Properties.Resources.maximizar_16;
            btn_maximizar.Location = new Point(748, 0);
            btn_maximizar.Margin = new Padding(0);
            btn_maximizar.Name = "btn_maximizar";
            btn_maximizar.Size = new Size(26, 28);
            btn_maximizar.TabIndex = 5;
            btn_maximizar.TextAlign = ContentAlignment.MiddleLeft;
            btn_maximizar.UseVisualStyleBackColor = false;
            btn_maximizar.Click += btn_maximizar_Click;
            // 
            // btn_sair
            // 
            btn_sair.BackColor = Color.White;
            btn_sair.BackgroundImageLayout = ImageLayout.Center;
            btn_sair.Dock = DockStyle.Right;
            btn_sair.FlatAppearance.BorderSize = 0;
            btn_sair.FlatStyle = FlatStyle.Flat;
            btn_sair.ForeColor = Color.FromArgb(23, 24, 29);
            btn_sair.Image = Properties.Resources.x_16;
            btn_sair.Location = new Point(774, 0);
            btn_sair.Margin = new Padding(0);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(26, 28);
            btn_sair.TabIndex = 4;
            btn_sair.TextAlign = ContentAlignment.MiddleLeft;
            btn_sair.UseVisualStyleBackColor = false;
            btn_sair.Click += btn_sair_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.ForeColor = Color.FromArgb(23, 24, 29);
            label1.Location = new Point(37, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(152, 28);
            label1.TabIndex = 1;
            label1.Text = "Data Store Desktop";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSideBarExpand
            // 
            btnSideBarExpand.Dock = DockStyle.Left;
            btnSideBarExpand.Image = Properties.Resources.menu_16;
            btnSideBarExpand.Location = new Point(0, 0);
            btnSideBarExpand.Name = "btnSideBarExpand";
            btnSideBarExpand.Size = new Size(37, 28);
            btnSideBarExpand.SizeMode = PictureBoxSizeMode.CenterImage;
            btnSideBarExpand.TabIndex = 0;
            btnSideBarExpand.TabStop = false;
            btnSideBarExpand.Click += btnSideBarExpand_Click;
            // 
            // pannelSideBar
            // 
            pannelSideBar.BackColor = Color.FromArgb(23, 24, 29);
            pannelSideBar.Controls.Add(menuHomeContainer);
            pannelSideBar.Controls.Add(pnPesquisar);
            pannelSideBar.Controls.Add(pnCarrinho);
            pannelSideBar.Controls.Add(pnSair);
            pannelSideBar.Dock = DockStyle.Left;
            pannelSideBar.Location = new Point(0, 28);
            pannelSideBar.Name = "pannelSideBar";
            pannelSideBar.Size = new Size(167, 422);
            pannelSideBar.TabIndex = 1;
            pannelSideBar.Paint += pannelSideBar_Paint;
            // 
            // menuHomeContainer
            // 
            menuHomeContainer.BackColor = Color.FromArgb(32, 33, 36);
            menuHomeContainer.Controls.Add(btnMenuHome);
            menuHomeContainer.Controls.Add(btnHomeMeusObjetos);
            menuHomeContainer.Controls.Add(btnHomeSolicitacoes);
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
            btnMenuHome.Text = "          Home";
            btnMenuHome.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuHome.UseVisualStyleBackColor = false;
            btnMenuHome.Click += btnMenuHome_Click;
            // 
            // btnHomeMeusObjetos
            // 
            btnHomeMeusObjetos.BackColor = Color.FromArgb(32, 33, 36);
            btnHomeMeusObjetos.BackgroundImageLayout = ImageLayout.Center;
            btnHomeMeusObjetos.FlatAppearance.BorderSize = 0;
            btnHomeMeusObjetos.FlatStyle = FlatStyle.Flat;
            btnHomeMeusObjetos.Image = Properties.Resources.círculo_preenchido_12;
            btnHomeMeusObjetos.ImageAlign = ContentAlignment.MiddleLeft;
            btnHomeMeusObjetos.Location = new Point(0, 42);
            btnHomeMeusObjetos.Margin = new Padding(0);
            btnHomeMeusObjetos.Name = "btnHomeMeusObjetos";
            btnHomeMeusObjetos.Size = new Size(167, 42);
            btnHomeMeusObjetos.TabIndex = 5;
            btnHomeMeusObjetos.Text = "          Meus objetos";
            btnHomeMeusObjetos.TextAlign = ContentAlignment.MiddleLeft;
            btnHomeMeusObjetos.UseVisualStyleBackColor = false;
            btnHomeMeusObjetos.Click += btnHomeMeusObjetos_Click;
            // 
            // btnHomeSolicitacoes
            // 
            btnHomeSolicitacoes.BackColor = Color.FromArgb(32, 33, 36);
            btnHomeSolicitacoes.BackgroundImageLayout = ImageLayout.Center;
            btnHomeSolicitacoes.FlatAppearance.BorderSize = 0;
            btnHomeSolicitacoes.FlatStyle = FlatStyle.Flat;
            btnHomeSolicitacoes.Image = Properties.Resources.círculo_preenchido_12;
            btnHomeSolicitacoes.ImageAlign = ContentAlignment.MiddleLeft;
            btnHomeSolicitacoes.Location = new Point(0, 84);
            btnHomeSolicitacoes.Margin = new Padding(0);
            btnHomeSolicitacoes.Name = "btnHomeSolicitacoes";
            btnHomeSolicitacoes.Size = new Size(167, 42);
            btnHomeSolicitacoes.TabIndex = 6;
            btnHomeSolicitacoes.Text = "          Solicitações realizadas";
            btnHomeSolicitacoes.TextAlign = ContentAlignment.MiddleLeft;
            btnHomeSolicitacoes.UseVisualStyleBackColor = false;
            btnHomeSolicitacoes.Click += btnHomeSolicitacoes_Click;
            // 
            // pnPesquisar
            // 
            pnPesquisar.BackColor = Color.FromArgb(32, 33, 36);
            pnPesquisar.Controls.Add(btnPesquisar);
            pnPesquisar.Location = new Point(3, 51);
            pnPesquisar.Name = "pnPesquisar";
            pnPesquisar.Size = new Size(167, 42);
            pnPesquisar.TabIndex = 3;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.FromArgb(23, 24, 29);
            btnPesquisar.BackgroundImageLayout = ImageLayout.Center;
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Image = Properties.Resources.pesquisar_16;
            btnPesquisar.ImageAlign = ContentAlignment.MiddleLeft;
            btnPesquisar.Location = new Point(0, 0);
            btnPesquisar.Margin = new Padding(0);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(167, 42);
            btnPesquisar.TabIndex = 4;
            btnPesquisar.Text = "          Pesquisar";
            btnPesquisar.TextAlign = ContentAlignment.MiddleLeft;
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // pnCarrinho
            // 
            pnCarrinho.BackColor = Color.FromArgb(32, 33, 36);
            pnCarrinho.Controls.Add(btnCarrinho);
            pnCarrinho.Location = new Point(3, 99);
            pnCarrinho.Name = "pnCarrinho";
            pnCarrinho.Size = new Size(167, 42);
            pnCarrinho.TabIndex = 4;
            // 
            // btnCarrinho
            // 
            btnCarrinho.BackColor = Color.FromArgb(23, 24, 29);
            btnCarrinho.BackgroundImageLayout = ImageLayout.Center;
            btnCarrinho.FlatAppearance.BorderSize = 0;
            btnCarrinho.FlatStyle = FlatStyle.Flat;
            btnCarrinho.Image = Properties.Resources.carrinho_16;
            btnCarrinho.ImageAlign = ContentAlignment.MiddleLeft;
            btnCarrinho.Location = new Point(0, 0);
            btnCarrinho.Margin = new Padding(0);
            btnCarrinho.Name = "btnCarrinho";
            btnCarrinho.Size = new Size(167, 42);
            btnCarrinho.TabIndex = 4;
            btnCarrinho.Text = "          Carrinho";
            btnCarrinho.TextAlign = ContentAlignment.MiddleLeft;
            btnCarrinho.UseVisualStyleBackColor = false;
            btnCarrinho.Click += btnCarrinho_Click;
            // 
            // pnSair
            // 
            pnSair.BackColor = Color.FromArgb(32, 33, 36);
            pnSair.Controls.Add(button7);
            pnSair.Location = new Point(3, 147);
            pnSair.Name = "pnSair";
            pnSair.Size = new Size(167, 42);
            pnSair.TabIndex = 6;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(23, 24, 29);
            button7.BackgroundImageLayout = ImageLayout.Center;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Image = Properties.Resources.porta_16;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(0, 0);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.Size = new Size(167, 42);
            button7.TabIndex = 3;
            button7.Text = "          Sair";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = false;
            // 
            // timerMenuTransition
            // 
            timerMenuTransition.Interval = 10;
            timerMenuTransition.Tick += timerMenuTransition_Tick;
            // 
            // sideBarTransition
            // 
            sideBarTransition.Interval = 10;
            sideBarTransition.Tick += sideBarTransition_Tick;
            // 
            // btn_minimizar
            // 
            btn_minimizar.BackColor = Color.White;
            btn_minimizar.BackgroundImageLayout = ImageLayout.Center;
            btn_minimizar.Dock = DockStyle.Right;
            btn_minimizar.FlatAppearance.BorderSize = 0;
            btn_minimizar.FlatStyle = FlatStyle.Flat;
            btn_minimizar.ForeColor = Color.FromArgb(23, 24, 29);
            btn_minimizar.Image = Properties.Resources.minimizar_16;
            btn_minimizar.ImageAlign = ContentAlignment.BottomCenter;
            btn_minimizar.Location = new Point(722, 0);
            btn_minimizar.Margin = new Padding(0);
            btn_minimizar.Name = "btn_minimizar";
            btn_minimizar.Size = new Size(26, 28);
            btn_minimizar.TabIndex = 6;
            btn_minimizar.TextAlign = ContentAlignment.MiddleLeft;
            btn_minimizar.UseVisualStyleBackColor = false;
            btn_minimizar.Click += btn_minimizar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pannelSideBar);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnSideBarExpand).EndInit();
            pannelSideBar.ResumeLayout(false);
            menuHomeContainer.ResumeLayout(false);
            pnPesquisar.ResumeLayout(false);
            pnCarrinho.ResumeLayout(false);
            pnSair.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel pannelSideBar;
        private Button btnMenuHome;
        private FlowLayoutPanel menuHomeContainer;
        private Button btnHomeMeusObjetos;
        private Button btnHomeSolicitacoes;
        private System.Windows.Forms.Timer timerMenuTransition;
        private System.Windows.Forms.Timer sideBarTransition;
        private PictureBox btnSideBarExpand;
        private Label label1;
        private FlowLayoutPanel pnPesquisar;
        private FlowLayoutPanel pnCarrinho;
        private FlowLayoutPanel pnSair;
        private Button button7;
        private Button btnCarrinho;
        private Button btnPesquisar;
        private Button btn_sair;
        private Button btn_maximizar;
        private Button btn_minimizar;
    }
}
