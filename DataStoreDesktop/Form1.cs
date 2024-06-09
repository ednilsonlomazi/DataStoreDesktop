namespace DataStoreDesktop
{
    public partial class Form1 : Form
    {
        FormHome formHome;
        FormPesquisar formPesquisar;
        FormCarrinho formCarrinho;
        FormLogout formLogout;
        FormMeusObjetos formMeusObjetos;
        FormSolicitacoesRealizadas formSolicitacoesRealizadas;


        public Form1()
        {
            InitializeComponent();
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
    }
}
