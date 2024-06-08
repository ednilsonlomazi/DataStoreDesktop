namespace DataStoreDesktop
{
    public partial class Form1 : Form
    {
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
                }
            }
            else
            {
                pannelSideBar.Width += 10;
                if (pannelSideBar.Width >= 167)
                {
                    sidebarExpandida = true;
                    sideBarTransition.Stop();
                }
            }
        }

        private void btnSideBarExpand_Click(object sender, EventArgs e)
        {
            sideBarTransition.Start();
        }
    }
}
