namespace WinFormsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnOpen.Enabled = true;
            btnLoadEventPlay.Enabled = true;
            btnExitApp.Enabled = true;
        }

        private void ButtonCancelOperation_Clicl(object sender, EventArgs e)
        {
            btnOpen.Enabled = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome my Application");
            btnExitApp.Enabled = false;
            btnLoadEventPlay.Enabled = false;
            lblUserAge.Text = "Age: ";
            lblUsername.Text = "Username: ";
            lblUserProfession.Text = "Profession: ";
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            btnOperation1.Text = 10.ToString();
            btnOperation2.Text = (2 + 2).ToString();
            btnOperation3.Text = (10 + 10).ToString();
        }

        private void btnDisplayInformation_Click(object sender, EventArgs e)
        {
            lblUserAge.Text = "Age: " + "25";
            lblUsername.Text = "Username: "+ "JohnDoe";
            lblUserProfession.Text = "Profession: " + "Salumiere";
        }
    }
}
