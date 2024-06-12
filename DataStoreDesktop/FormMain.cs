namespace DataStoreDesktop
{
    public partial class FormMain : Form
    {
        FormHome formHome;
        FormPesquisar formPesquisar;
        FormCarrinho formCarrinho;
        FormLogin formLogin;
        FormMeusObjetos formMeusObjetos;
        FormSolicitacoesRealizadas formSolicitacoesRealizadas;
        
        

        public FormMain()
        {
            InitializeComponent();

            if (formLogin == null)
            {
                formLogin = new FormLogin();
                formLogin.FormClosed += FormLogin_FormClosed;
                formLogin.MdiParent = this;
                formLogin.Dock = DockStyle.Fill;
                formLogin.Show();
            }
            else
            {
                formLogin.Activate();
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
            timerMenuTransition.Start();
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
            if (formSolicitacoesRealizadas == null)
            {
                formSolicitacoesRealizadas = new FormSolicitacoesRealizadas();
                formSolicitacoesRealizadas.FormClosed += FormSolicitacoesRealizadas_FormClosed;
                formSolicitacoesRealizadas.MdiParent = this;
                formSolicitacoesRealizadas.Dock = DockStyle.Fill;
                formSolicitacoesRealizadas.Show();
            }
            else
            {
                formSolicitacoesRealizadas.Activate();
            }
        }

        private void FormSolicitacoesRealizadas_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formSolicitacoesRealizadas = null;
        }



        private void btnCarrinho_Click(object sender, EventArgs e)
        {
            if (this.formLogin.logado)
            {
                if (formCarrinho == null)
                {
                    formCarrinho = new FormCarrinho();
                    formCarrinho.FormClosed += FormCarrinho_FormClosed;
                    formCarrinho.MdiParent = this;
                    formCarrinho.Dock = DockStyle.Fill;
                    formCarrinho.Show();
                }
                else
                {
                    formCarrinho.Activate();
                }
            }

        }

        private void FormCarrinho_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formCarrinho = null;
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
            formLogin.logado = false;
            
            if (formLogin == null)
            {
                formLogin = new FormLogin();
                formLogin.FormClosed += FormLogin_FormClosed;
                formLogin.MdiParent = this;
                formLogin.Dock = DockStyle.Fill;
                formLogin.Show();
            }
            else
            {
                formLogin.Activate();
            }
        }

        private void FormLogin_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formLogin = null;
        }
    }
}
