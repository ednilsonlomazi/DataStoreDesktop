namespace DataStoreDesktop
{
    partial class FormMain
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
            lbInfoSession = new Label();
            btn_minimizar = new Button();
            btn_maximizar = new Button();
            btn_sair = new Button();
            label1 = new Label();
            pannelSideBar = new FlowLayoutPanel();
            menuHomeContainer = new FlowLayoutPanel();
            btnMenuHome = new Button();
            btnHomeMeusObjetos = new Button();
            btnHomeSolicitacoes = new Button();
            pnPesquisar = new FlowLayoutPanel();
            btnPesquisar = new Button();
            pnCarrinho = new FlowLayoutPanel();
            btnSolicitacoes = new Button();
            pnSair = new FlowLayoutPanel();
            btn_logout = new Button();
            timerMenuTransition = new System.Windows.Forms.Timer(components);
            sideBarTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
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
            panel1.Controls.Add(lbInfoSession);
            panel1.Controls.Add(btn_minimizar);
            panel1.Controls.Add(btn_maximizar);
            panel1.Controls.Add(btn_sair);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 28);
            panel1.TabIndex = 0;
            // 
            // lbInfoSession
            // 
            lbInfoSession.Dock = DockStyle.Right;
            lbInfoSession.ForeColor = Color.FromArgb(23, 24, 29);
            lbInfoSession.Location = new Point(570, 0);
            lbInfoSession.Margin = new Padding(0);
            lbInfoSession.Name = "lbInfoSession";
            lbInfoSession.Size = new Size(152, 28);
            lbInfoSession.TabIndex = 7;
            lbInfoSession.Text = "Data Store Desktop";
            lbInfoSession.TextAlign = ContentAlignment.MiddleCenter;
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
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(141, 28);
            label1.TabIndex = 1;
            label1.Text = "Data Store Desktop";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            pannelSideBar.Margin = new Padding(0);
            pannelSideBar.Name = "pannelSideBar";
            pannelSideBar.Size = new Size(141, 422);
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
            btnMenuHome.Size = new Size(138, 42);
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
            btnPesquisar.Size = new Size(138, 42);
            btnPesquisar.TabIndex = 4;
            btnPesquisar.Text = "          Pesquisar";
            btnPesquisar.TextAlign = ContentAlignment.MiddleLeft;
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // pnCarrinho
            // 
            pnCarrinho.BackColor = Color.FromArgb(32, 33, 36);
            pnCarrinho.Controls.Add(btnSolicitacoes);
            pnCarrinho.Location = new Point(3, 99);
            pnCarrinho.Name = "pnCarrinho";
            pnCarrinho.Size = new Size(167, 42);
            pnCarrinho.TabIndex = 4;
            // 
            // btnSolicitacoes
            // 
            btnSolicitacoes.BackColor = Color.FromArgb(23, 24, 29);
            btnSolicitacoes.BackgroundImageLayout = ImageLayout.Center;
            btnSolicitacoes.FlatAppearance.BorderSize = 0;
            btnSolicitacoes.FlatStyle = FlatStyle.Flat;
            btnSolicitacoes.Image = Properties.Resources.documento_16;
            btnSolicitacoes.ImageAlign = ContentAlignment.MiddleLeft;
            btnSolicitacoes.Location = new Point(0, 0);
            btnSolicitacoes.Margin = new Padding(0);
            btnSolicitacoes.Name = "btnSolicitacoes";
            btnSolicitacoes.Size = new Size(138, 42);
            btnSolicitacoes.TabIndex = 4;
            btnSolicitacoes.Text = "          Solicitacoes";
            btnSolicitacoes.TextAlign = ContentAlignment.MiddleLeft;
            btnSolicitacoes.UseVisualStyleBackColor = false;
            btnSolicitacoes.Click += btnSolicitacoes_Click;
            // 
            // pnSair
            // 
            pnSair.BackColor = Color.FromArgb(32, 33, 36);
            pnSair.Controls.Add(btn_logout);
            pnSair.Location = new Point(3, 147);
            pnSair.Name = "pnSair";
            pnSair.Size = new Size(167, 42);
            pnSair.TabIndex = 6;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.FromArgb(23, 24, 29);
            btn_logout.BackgroundImageLayout = ImageLayout.Center;
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Image = Properties.Resources.porta_16;
            btn_logout.ImageAlign = ContentAlignment.MiddleLeft;
            btn_logout.Location = new Point(0, 0);
            btn_logout.Margin = new Padding(0);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(138, 42);
            btn_logout.TabIndex = 3;
            btn_logout.Text = "          Logout";
            btn_logout.TextAlign = ContentAlignment.MiddleLeft;
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
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
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pannelSideBar);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "FormMain";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
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
        private Label label1;
        private FlowLayoutPanel pnPesquisar;
        private FlowLayoutPanel pnCarrinho;
        private FlowLayoutPanel pnSair;
        private Button btn_logout;
        private Button btnSolicitacoes;
        private Button btnPesquisar;
        private Button btn_sair;
        private Button btn_maximizar;
        private Button btn_minimizar;
        private Label lbInfoSession;
    }
}
