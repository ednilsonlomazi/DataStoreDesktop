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
            label1 = new Label();
            btnSideBarExpand = new PictureBox();
            pannelSideBar = new FlowLayoutPanel();
            menuHomeContainer = new FlowLayoutPanel();
            btnMenuHome = new Button();
            btnHomeMeusObjetos = new Button();
            btnHomeSolicitacoes = new Button();
            pnPesquisar = new FlowLayoutPanel();
            button1 = new Button();
            pnCarrinho = new FlowLayoutPanel();
            button4 = new Button();
            pnSair = new FlowLayoutPanel();
            button7 = new Button();
            timerMenuTransition = new System.Windows.Forms.Timer(components);
            sideBarTransition = new System.Windows.Forms.Timer(components);
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
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSideBarExpand);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 28);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            // 
            // pnPesquisar
            // 
            pnPesquisar.BackColor = Color.FromArgb(32, 33, 36);
            pnPesquisar.Controls.Add(button1);
            pnPesquisar.Location = new Point(3, 51);
            pnPesquisar.Name = "pnPesquisar";
            pnPesquisar.Size = new Size(167, 42);
            pnPesquisar.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(23, 24, 29);
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.pesquisar_16;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(167, 42);
            button1.TabIndex = 3;
            button1.Text = "          Pesquisar";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // pnCarrinho
            // 
            pnCarrinho.BackColor = Color.FromArgb(32, 33, 36);
            pnCarrinho.Controls.Add(button4);
            pnCarrinho.Location = new Point(3, 99);
            pnCarrinho.Name = "pnCarrinho";
            pnCarrinho.Size = new Size(167, 42);
            pnCarrinho.TabIndex = 4;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(23, 24, 29);
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = Properties.Resources.carrinho_16;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 0);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(167, 42);
            button4.TabIndex = 3;
            button4.Text = "          Carrinho";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
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
        private Button button1;
        private FlowLayoutPanel pnCarrinho;
        private Button button4;
        private FlowLayoutPanel pnSair;
        private Button button7;
    }
}
