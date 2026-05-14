using System.Diagnostics.CodeAnalysis;

namespace WinFormsDemo
{
    public partial class Form1 : Form
    {
        string name;
        string age;
        string profession;
        string password;
        string toppings = "";
        string[] vehicle = { "Car", "Bike", "Bus" };
        public Form1()
        {
            InitializeComponent();
            comboVehicle.Items.AddRange(vehicle);
            gbPark.Enabled = false;
            panelPark.Enabled = false;
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

            if (!string.IsNullOrEmpty(name) &&
                !string.IsNullOrEmpty(age) &&
                !string.IsNullOrEmpty(password) &&
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

        private void RadioButtonSelection_CheckedChanged(object sender, EventArgs e)
        {
            if (radioVisa.Checked)
            {
                lblSelection.Text = radioVisa.Text;
            }
            else if (radioCash.Checked)
            {
                lblSelection.Text = radioCash.Text;
            }
            else if (radioPaypal.Checked)
            {
                lblSelection.Text = radioPaypal.Text;
            }

        }

        private void PizzaSelection_CheckedChanged(object sender, EventArgs e)
        {
            toppings = "";

            if (cbCheese.Checked)
            {
                toppings = cbCheese.Text + ", ";
            }
            if (cbPepperoni.Checked)
            {
                toppings += cbPepperoni.Text + ", ";
            }
            if (cbPatatine.Checked)
            {
                toppings += cbPatatine.Text + ", ";
            }
            lblSelection.Text = toppings != ""
                ? toppings
                : "you did not select any topping";
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (toppings != "")
            {
                MessageBox.Show("You have ordered a pizza with the following toppings: " + toppings);
            }
            else
            {
                MessageBox.Show("You have not selected any toppings for your pizza.");
            }
        }

        private void btnPark_Click(object sender, EventArgs e)
        {
            string regNumber = tbxVehicleNum.Text;
            bool regNumberValid = !string.IsNullOrEmpty(regNumber) && regNumber.Length >= 5;

            // Check if a vehicle type is selected
            if (comboVehicle.SelectedItem != null && regNumberValid)
            {
                string type = comboVehicle.SelectedItem.ToString();
                lblParkHouse.Text = "type: " + type + "\n Vehicle Number: " + regNumber;
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            gbPark.Enabled = true;
            tabParkingControl.SelectedTab = tabPark;
        }

        private void btnDisplayOrder_Click(object sender, EventArgs e)
        {
            panelPark.Enabled = true;
        }

        private void btnInsertIntoSystem_Click(object sender, EventArgs e)
        {
            string name = tbxUserInput.Text;

            if (!string.IsNullOrEmpty(name))
            {
                lbxName.Items.Add(name);
            }
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            lbxName.Items.Clear();
        }

        private void btnSelection_Click(object sender, EventArgs e)
        {
            //button method to display the selected item in the listbox
            int selectedIndex = lbxName.SelectedIndex;

            if (selectedIndex != -1)
            {
                string selectedName = lbxName.SelectedItem.ToString();
                lblShowSelection.Text = "Item index is: " + selectedIndex + "\n Selected Item Name: " + lbxName.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Please select an item from the list.");
            }
        }

        private void lbxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //live method to display the selected item in the listbox when the selection changes
            int selectedIndex = lbxName.SelectedIndex;

            if (selectedIndex != -1)
            {
                string selectedName = lbxName.SelectedItem.ToString();
                lblShowSelection.Text = "Item index is: " + selectedIndex + "\n Selected Item Name: " + lbxName.SelectedItem.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = lbxName.SelectedIndex;

            if (selectedIndex != -1)
            {
                lbxName.Items.RemoveAt(selectedIndex);
            }
            else
            {
                MessageBox.Show("Please select an item from the list to delete.");
            }
        }
    }
}
