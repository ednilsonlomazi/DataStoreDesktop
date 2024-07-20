namespace GUI
{
    public partial class FormMain : Form
    {
        FormHome formHome;
        FormPesquisar formPesquisar;
        FormSolicitacoes formSolicitacoes;
        FormLogin formLogin;
        FormMeusObjetos formMeusObjetos;
        FormSobre formSobre;
        internal string usuario;


        public FormMain(string usuario, FormLogin formLogin)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.lbInfoSession.Text = usuario;
            this.formLogin = formLogin;

            if (formHome == null)
            {
                formHome = new FormHome();
                formHome.FormClosed += FormHome_FormClosed;
                formHome.MdiParent = this;
                formHome.Dock = DockStyle.Fill;
                formHome.Show();
            }
            else
            {
                formHome.Activate();
            }

        }



        private void FormHome_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formHome = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnMenuHome_Click(object sender, EventArgs e)
        {
            if (formHome == null)
            {
                formHome = new FormHome();
                formHome.FormClosed += FormHome_FormClosed;
                formHome.MdiParent = this;
                formHome.Dock = DockStyle.Fill;
                formHome.Show();
            }
            else
            {
                formHome.Activate();
            }
        }
        bool expandeMenu = false;
        private void timerMenuTransition_Tick(object sender, EventArgs e)
        {
            if (expandeMenu == false)
            {
                menuHomeContainer.Height += 10;
                if (menuHomeContainer.Height >= 126) // tamanho maximo do container
                {
                    timerMenuTransition.Stop();
                    expandeMenu = true;
                }
            }
            else
            {
                menuHomeContainer.Height -= 10;
                if (menuHomeContainer.Height <= 42) // altura do button
                {
                    timerMenuTransition.Stop();
                    expandeMenu = false;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pannelSideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        bool sidebarExpandida = true;
        private void sideBarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpandida)
            {
                pannelSideBar.Width -= 10;
                if (pannelSideBar.Width <= 37)
                {
                    sidebarExpandida = false;
                    sideBarTransition.Stop();

                    menuHomeContainer.Width = pannelSideBar.Width;
                    pnPesquisar.Width = pannelSideBar.Width;
                    pnCarrinho.Width = pannelSideBar.Width;

                    pnSair.Width = pannelSideBar.Width;
                }
            }
            else
            {
                pannelSideBar.Width += 10;
                if (pannelSideBar.Width >= 167)
                {
                    sidebarExpandida = true;
                    sideBarTransition.Stop();

                    menuHomeContainer.Width = pannelSideBar.Width;
                    pnPesquisar.Width = pannelSideBar.Width;
                    pnCarrinho.Width = pannelSideBar.Width;

                    pnSair.Width = pannelSideBar.Width;
                }
            }
        }

        private void btnSideBarExpand_Click(object sender, EventArgs e)
        {
            sideBarTransition.Start();
        }

        private void btnHomeMeusObjetos_Click(object sender, EventArgs e)
        {
            if (formMeusObjetos == null)
            {
                formMeusObjetos = new FormMeusObjetos();
                formMeusObjetos.FormClosed += FormMeusObjetos_FormClosed;
                formMeusObjetos.MdiParent = this;
                formMeusObjetos.Dock = DockStyle.Fill;
                formMeusObjetos.Show();
            }
            else
            {
                formMeusObjetos.Activate();
            }
        }

        private void FormMeusObjetos_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formMeusObjetos = null;
        }

        private void btnHomeSolicitacoes_Click(object sender, EventArgs e)
        {
            if (formSobre == null)
            {
                formSobre = new FormSobre();
                formSobre.FormClosed += FormSolicitacoesRealizadas_FormClosed;
                formSobre.MdiParent = this;
                formSobre.Dock = DockStyle.Fill;
                formSobre.Show();
            }
            else
            {
                formSobre.Activate();
            }
        }

        private void FormSolicitacoesRealizadas_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formSobre = null;
        }



        private void btnSolicitacoes_Click(object sender, EventArgs e)
        {
            if (this.formLogin.logado)
            {
                if (formSolicitacoes == null)
                {
                    formSolicitacoes = new FormSolicitacoes();
                    formSolicitacoes.FormClosed += FormCarrinho_FormClosed;
                    formSolicitacoes.MdiParent = this;
                    formSolicitacoes.Dock = DockStyle.Fill;
                    formSolicitacoes.Show();
                }
                else
                {
                    formSolicitacoes.Activate();
                }
            }

        }

        private void FormCarrinho_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formSolicitacoes = null;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (formPesquisar == null)
            {
                formPesquisar = new FormPesquisar();
                formPesquisar.FormClosed += FormPesquisar_FormClosed;
                formPesquisar.MdiParent = this;
                formPesquisar.Dock = DockStyle.Fill;
                formPesquisar.Show();
            }
            else
            {
                formPesquisar.Activate();
            }
        }

        private void FormPesquisar_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formPesquisar = null;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {

                System.Windows.Forms.Application.Exit();
            }
        }

        private void btn_maximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }


        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout efetuado com sucesso!");
            this.Hide();
            this.formLogin.Show();

        }

        private void FormLogin_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formLogin = null;
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            if (formSobre == null)
            {
                formSobre = new FormSobre();
                formSobre.FormClosed += FormSobre_FormClosed; ;
                formSobre.MdiParent = this;
                formSobre.Dock = DockStyle.Fill;
                formSobre.Show();
            }
            else
            {
                formSobre.Activate();
            }
        }

        private void FormSobre_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formSobre = null;
        }
    }
}
