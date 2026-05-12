using System.Diagnostics.CodeAnalysis;

namespace WinFormsDemo
{
    public partial class Form1 : Form
    {
        string name;
        string age;
        string profession;
        string password;
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
            MessageBox.Show("Welcome to my Application");
            btnExitApp.Enabled = false;
            btnLoadEventPlay.Enabled = false;
            lblUserAge.Text = "Age: ";
            lblUsername.Text = "Username: ";
            lblUserProfession.Text = "Profession: ";
            lblInput.Text = "Password: ";
            lblError.Enabled = false;
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
            lblUsername.Text = "Username: " + name;
            lblUserProfession.Text = "Profession: " + profession;
            lblUserAge.Text = "Age: " + age;
            lblInput.Text = "Password: ******** ";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Get the user input from the labels and store them in variables
            name = tbxName.Text;
            age = tbxAge.Text;
            password = tbxPassword.Text;
            profession = tbxProfession.Text;

            if(!string.IsNullOrEmpty(name) &&
                !string.IsNullOrEmpty(age)&&
                !string.IsNullOrEmpty(password)&&
                !string.IsNullOrEmpty(profession))
            {
                btnDisplayInformation_Click(sender, e);
                btnSubmit.Enabled = false;
            }
            else
            {
                lblError.Enabled = true;
                MessageBox.Show("Please fill in all the fields before submitting.");
            }

        }
    }
}
