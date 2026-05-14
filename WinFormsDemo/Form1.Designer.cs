namespace WinFormsDemo
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
            btnSave = new Button();
            btnCancel = new Button();
            btnPlay = new Button();
            btnOpen = new Button();
            btnLoadEventPlay = new Button();
            btnExitApp = new Button();
            btnOperation1 = new Button();
            btnOperation2 = new Button();
            btnOperation3 = new Button();
            btnCalculate = new Button();
            lblHelp = new Label();
            btnDisplayInformation = new Button();
            lblUsername = new Label();
            lblUserProfession = new Label();
            lblUserAge = new Label();
            lblError = new Label();
            tbxName = new TextBox();
            lblInput = new Label();
            tbxAge = new TextBox();
            tbxPassword = new TextBox();
            tbxProfession = new TextBox();
            btnSubmit = new Button();
            radioVisa = new RadioButton();
            radioCash = new RadioButton();
            radioPaypal = new RadioButton();
            lblSelection = new Label();
            cbCheese = new CheckBox();
            cbPatatine = new CheckBox();
            cbPepperoni = new CheckBox();
            btnOrder = new Button();
            comboVehicle = new ComboBox();
            tbxVehicleNum = new TextBox();
            lblVehicleNum = new Label();
            lblVehicleType = new Label();
            lblParkHouse = new Label();
            btnPark = new Button();
            gbPark = new GroupBox();
            btnPay = new Button();
            panelPark = new Panel();
            btnDisplayOrder = new Button();
            tabParkingControl = new TabControl();
            tabPagePay = new TabPage();
            tabPark = new TabPage();
            lbxName = new ListBox();
            tbxUserInput = new TextBox();
            btnInsertIntoSystem = new Button();
            btnClearList = new Button();
            btnSelection = new Button();
            lblShowSelection = new Label();
            btnDelete = new Button();
            panelPark.SuspendLayout();
            tabParkingControl.SuspendLayout();
            tabPagePay.SuspendLayout();
            tabPark.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 216);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(97, 34);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 256);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(97, 36);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += ButtonCancelOperation_Clicl;
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(12, 173);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(97, 37);
            btnPlay.TabIndex = 3;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnOpen
            // 
            btnOpen.Enabled = false;
            btnOpen.Location = new Point(116, 187);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(153, 63);
            btnOpen.TabIndex = 4;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnLoadEventPlay
            // 
            btnLoadEventPlay.Location = new Point(116, 263);
            btnLoadEventPlay.Name = "btnLoadEventPlay";
            btnLoadEventPlay.Size = new Size(75, 23);
            btnLoadEventPlay.TabIndex = 5;
            btnLoadEventPlay.Text = "PlayAgain";
            btnLoadEventPlay.UseVisualStyleBackColor = true;
            // 
            // btnExitApp
            // 
            btnExitApp.Location = new Point(197, 263);
            btnExitApp.Name = "btnExitApp";
            btnExitApp.Size = new Size(75, 23);
            btnExitApp.TabIndex = 6;
            btnExitApp.Text = "Exit";
            btnExitApp.UseVisualStyleBackColor = true;
            btnExitApp.Click += btnExitApp_Click;
            // 
            // btnOperation1
            // 
            btnOperation1.Location = new Point(98, 12);
            btnOperation1.Name = "btnOperation1";
            btnOperation1.Size = new Size(75, 23);
            btnOperation1.TabIndex = 7;
            btnOperation1.Text = "0";
            btnOperation1.UseVisualStyleBackColor = true;
            // 
            // btnOperation2
            // 
            btnOperation2.Location = new Point(179, 12);
            btnOperation2.Name = "btnOperation2";
            btnOperation2.Size = new Size(75, 23);
            btnOperation2.TabIndex = 8;
            btnOperation2.Text = "0";
            btnOperation2.UseVisualStyleBackColor = true;
            // 
            // btnOperation3
            // 
            btnOperation3.Location = new Point(260, 12);
            btnOperation3.Name = "btnOperation3";
            btnOperation3.Size = new Size(75, 23);
            btnOperation3.TabIndex = 9;
            btnOperation3.Text = "0";
            btnOperation3.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(12, 12);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 10;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblHelp
            // 
            lblHelp.AutoSize = true;
            lblHelp.Location = new Point(12, 111);
            lblHelp.Name = "lblHelp";
            lblHelp.Size = new Size(257, 15);
            lblHelp.TabIndex = 11;
            lblHelp.Text = "Click the button to display the user information";
            // 
            // btnDisplayInformation
            // 
            btnDisplayInformation.Location = new Point(12, 41);
            btnDisplayInformation.Name = "btnDisplayInformation";
            btnDisplayInformation.Size = new Size(116, 67);
            btnDisplayInformation.TabIndex = 12;
            btnDisplayInformation.Text = "Display Information";
            btnDisplayInformation.UseVisualStyleBackColor = true;
            btnDisplayInformation.Click += btnDisplayInformation_Click;
            // 
            // lblUsername
            // 
            lblUsername.BackColor = SystemColors.ActiveCaption;
            lblUsername.BorderStyle = BorderStyle.FixedSingle;
            lblUsername.Location = new Point(272, 169);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(202, 15);
            lblUsername.TabIndex = 13;
            lblUsername.Text = "Username";
            lblUsername.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblUserProfession
            // 
            lblUserProfession.BackColor = SystemColors.ActiveCaption;
            lblUserProfession.BorderStyle = BorderStyle.FixedSingle;
            lblUserProfession.Location = new Point(272, 206);
            lblUserProfession.Name = "lblUserProfession";
            lblUserProfession.Size = new Size(202, 15);
            lblUserProfession.TabIndex = 14;
            lblUserProfession.Text = "Profession";
            lblUserProfession.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblUserAge
            // 
            lblUserAge.BackColor = SystemColors.ActiveCaption;
            lblUserAge.BorderStyle = BorderStyle.FixedSingle;
            lblUserAge.Location = new Point(272, 223);
            lblUserAge.Name = "lblUserAge";
            lblUserAge.Size = new Size(202, 15);
            lblUserAge.TabIndex = 15;
            lblUserAge.Text = "Age";
            lblUserAge.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.BackColor = Color.FromArgb(192, 0, 0);
            lblError.ForeColor = SystemColors.ActiveCaptionText;
            lblError.Location = new Point(12, 295);
            lblError.Name = "lblError";
            lblError.Size = new Size(94, 15);
            lblError.TabIndex = 16;
            lblError.Text = "Error in Program";
            lblError.TextAlign = ContentAlignment.TopCenter;
            // 
            // tbxName
            // 
            tbxName.Location = new Point(272, 41);
            tbxName.Name = "tbxName";
            tbxName.PlaceholderText = "Type your Name...";
            tbxName.Size = new Size(194, 23);
            tbxName.TabIndex = 17;
            // 
            // lblInput
            // 
            lblInput.BackColor = SystemColors.ActiveCaption;
            lblInput.BorderStyle = BorderStyle.FixedSingle;
            lblInput.Location = new Point(272, 187);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(202, 15);
            lblInput.TabIndex = 18;
            lblInput.Text = "Password";
            lblInput.TextAlign = ContentAlignment.TopCenter;
            // 
            // tbxAge
            // 
            tbxAge.Location = new Point(272, 70);
            tbxAge.Name = "tbxAge";
            tbxAge.PlaceholderText = "Type your Age...";
            tbxAge.Size = new Size(194, 23);
            tbxAge.TabIndex = 19;
            // 
            // tbxPassword
            // 
            tbxPassword.Location = new Point(272, 99);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.PasswordChar = '*';
            tbxPassword.PlaceholderText = "Enter Password...";
            tbxPassword.Size = new Size(194, 23);
            tbxPassword.TabIndex = 20;
            // 
            // tbxProfession
            // 
            tbxProfession.Location = new Point(272, 131);
            tbxProfession.Name = "tbxProfession";
            tbxProfession.PlaceholderText = "Type your Profession...";
            tbxProfession.Size = new Size(194, 23);
            tbxProfession.TabIndex = 21;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(163, 149);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 22;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // radioVisa
            // 
            radioVisa.AutoSize = true;
            radioVisa.Location = new Point(33, 15);
            radioVisa.Name = "radioVisa";
            radioVisa.Size = new Size(46, 19);
            radioVisa.TabIndex = 23;
            radioVisa.TabStop = true;
            radioVisa.Text = "Visa";
            radioVisa.UseVisualStyleBackColor = true;
            radioVisa.CheckedChanged += RadioButtonSelection_CheckedChanged;
            // 
            // radioCash
            // 
            radioCash.AutoSize = true;
            radioCash.Location = new Point(33, 41);
            radioCash.Name = "radioCash";
            radioCash.Size = new Size(51, 19);
            radioCash.TabIndex = 24;
            radioCash.TabStop = true;
            radioCash.Text = "Cash";
            radioCash.UseVisualStyleBackColor = true;
            radioCash.CheckedChanged += RadioButtonSelection_CheckedChanged;
            // 
            // radioPaypal
            // 
            radioPaypal.AutoSize = true;
            radioPaypal.Location = new Point(33, 66);
            radioPaypal.Name = "radioPaypal";
            radioPaypal.Size = new Size(60, 19);
            radioPaypal.TabIndex = 25;
            radioPaypal.TabStop = true;
            radioPaypal.Text = "Paypal";
            radioPaypal.UseVisualStyleBackColor = true;
            radioPaypal.CheckedChanged += RadioButtonSelection_CheckedChanged;
            // 
            // lblSelection
            // 
            lblSelection.AutoSize = true;
            lblSelection.Location = new Point(172, 81);
            lblSelection.Name = "lblSelection";
            lblSelection.Size = new Size(38, 15);
            lblSelection.TabIndex = 26;
            lblSelection.Text = "label1";
            // 
            // cbCheese
            // 
            cbCheese.AutoSize = true;
            cbCheese.Location = new Point(33, 93);
            cbCheese.Name = "cbCheese";
            cbCheese.Size = new Size(64, 19);
            cbCheese.TabIndex = 27;
            cbCheese.Text = "Cheese";
            cbCheese.UseVisualStyleBackColor = true;
            cbCheese.CheckedChanged += PizzaSelection_CheckedChanged;
            // 
            // cbPatatine
            // 
            cbPatatine.AutoSize = true;
            cbPatatine.Location = new Point(33, 118);
            cbPatatine.Name = "cbPatatine";
            cbPatatine.Size = new Size(69, 19);
            cbPatatine.TabIndex = 28;
            cbPatatine.Text = "Patatine";
            cbPatatine.UseVisualStyleBackColor = true;
            cbPatatine.CheckedChanged += PizzaSelection_CheckedChanged;
            // 
            // cbPepperoni
            // 
            cbPepperoni.AutoSize = true;
            cbPepperoni.Location = new Point(33, 143);
            cbPepperoni.Name = "cbPepperoni";
            cbPepperoni.Size = new Size(80, 19);
            cbPepperoni.TabIndex = 29;
            cbPepperoni.Text = "Pepperoni";
            cbPepperoni.UseVisualStyleBackColor = true;
            cbPepperoni.CheckedChanged += PizzaSelection_CheckedChanged;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(33, 176);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(204, 23);
            btnOrder.TabIndex = 30;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // comboVehicle
            // 
            comboVehicle.DropDownStyle = ComboBoxStyle.DropDownList;
            comboVehicle.FormattingEnabled = true;
            comboVehicle.Location = new Point(152, 48);
            comboVehicle.Name = "comboVehicle";
            comboVehicle.Size = new Size(203, 23);
            comboVehicle.TabIndex = 31;
            // 
            // tbxVehicleNum
            // 
            tbxVehicleNum.Location = new Point(152, 19);
            tbxVehicleNum.Name = "tbxVehicleNum";
            tbxVehicleNum.Size = new Size(203, 23);
            tbxVehicleNum.TabIndex = 32;
            // 
            // lblVehicleNum
            // 
            lblVehicleNum.AutoSize = true;
            lblVehicleNum.Location = new Point(10, 22);
            lblVehicleNum.Name = "lblVehicleNum";
            lblVehicleNum.Size = new Size(136, 15);
            lblVehicleNum.TabIndex = 33;
            lblVehicleNum.Text = "Register Vehicle Number";
            // 
            // lblVehicleType
            // 
            lblVehicleType.AutoSize = true;
            lblVehicleType.Location = new Point(108, 51);
            lblVehicleType.Name = "lblVehicleType";
            lblVehicleType.Size = new Size(31, 15);
            lblVehicleType.TabIndex = 34;
            lblVehicleType.Text = "Type";
            // 
            // lblParkHouse
            // 
            lblParkHouse.AutoSize = true;
            lblParkHouse.Location = new Point(230, 94);
            lblParkHouse.Name = "lblParkHouse";
            lblParkHouse.Size = new Size(84, 15);
            lblParkHouse.TabIndex = 35;
            lblParkHouse.Text = "Parking House";
            // 
            // btnPark
            // 
            btnPark.Location = new Point(90, 94);
            btnPark.Name = "btnPark";
            btnPark.Size = new Size(75, 23);
            btnPark.TabIndex = 36;
            btnPark.Text = "Park";
            btnPark.UseVisualStyleBackColor = true;
            btnPark.Click += btnPark_Click;
            // 
            // gbPark
            // 
            gbPark.Location = new Point(12, 331);
            gbPark.Name = "gbPark";
            gbPark.Size = new Size(130, 94);
            gbPark.TabIndex = 37;
            gbPark.TabStop = false;
            gbPark.Text = "Park Your Vehicle";
            // 
            // btnPay
            // 
            btnPay.Location = new Point(133, 53);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(115, 61);
            btnPay.TabIndex = 38;
            btnPay.Text = "Pay Park Fee";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // panelPark
            // 
            panelPark.BackColor = SystemColors.ActiveCaption;
            panelPark.Controls.Add(radioPaypal);
            panelPark.Controls.Add(radioVisa);
            panelPark.Controls.Add(radioCash);
            panelPark.Controls.Add(btnOrder);
            panelPark.Controls.Add(lblSelection);
            panelPark.Controls.Add(cbPepperoni);
            panelPark.Controls.Add(cbCheese);
            panelPark.Controls.Add(cbPatatine);
            panelPark.Location = new Point(512, 41);
            panelPark.Name = "panelPark";
            panelPark.Size = new Size(393, 216);
            panelPark.TabIndex = 39;
            // 
            // btnDisplayOrder
            // 
            btnDisplayOrder.Location = new Point(601, 263);
            btnDisplayOrder.Name = "btnDisplayOrder";
            btnDisplayOrder.Size = new Size(210, 33);
            btnDisplayOrder.TabIndex = 40;
            btnDisplayOrder.Text = "Enable Ordering";
            btnDisplayOrder.UseVisualStyleBackColor = true;
            btnDisplayOrder.Click += btnDisplayOrder_Click;
            // 
            // tabParkingControl
            // 
            tabParkingControl.Controls.Add(tabPagePay);
            tabParkingControl.Controls.Add(tabPark);
            tabParkingControl.Location = new Point(163, 331);
            tabParkingControl.Name = "tabParkingControl";
            tabParkingControl.SelectedIndex = 0;
            tabParkingControl.Size = new Size(380, 185);
            tabParkingControl.TabIndex = 41;
            // 
            // tabPagePay
            // 
            tabPagePay.Controls.Add(btnPay);
            tabPagePay.Location = new Point(4, 24);
            tabPagePay.Name = "tabPagePay";
            tabPagePay.Padding = new Padding(3);
            tabPagePay.Size = new Size(372, 157);
            tabPagePay.TabIndex = 0;
            tabPagePay.Text = "Pay";
            tabPagePay.UseVisualStyleBackColor = true;
            // 
            // tabPark
            // 
            tabPark.Controls.Add(comboVehicle);
            tabPark.Controls.Add(tbxVehicleNum);
            tabPark.Controls.Add(lblVehicleType);
            tabPark.Controls.Add(lblParkHouse);
            tabPark.Controls.Add(lblVehicleNum);
            tabPark.Controls.Add(btnPark);
            tabPark.Location = new Point(4, 24);
            tabPark.Name = "tabPark";
            tabPark.Padding = new Padding(3);
            tabPark.Size = new Size(372, 157);
            tabPark.TabIndex = 1;
            tabPark.Text = "Park";
            tabPark.UseVisualStyleBackColor = true;
            // 
            // lbxName
            // 
            lbxName.FormattingEnabled = true;
            lbxName.Location = new Point(618, 355);
            lbxName.Name = "lbxName";
            lbxName.Size = new Size(165, 214);
            lbxName.TabIndex = 42;
            lbxName.SelectedIndexChanged += lbxName_SelectedIndexChanged;
            // 
            // tbxUserInput
            // 
            tbxUserInput.Location = new Point(789, 355);
            tbxUserInput.Name = "tbxUserInput";
            tbxUserInput.Size = new Size(168, 23);
            tbxUserInput.TabIndex = 43;
            // 
            // btnInsertIntoSystem
            // 
            btnInsertIntoSystem.Location = new Point(830, 402);
            btnInsertIntoSystem.Name = "btnInsertIntoSystem";
            btnInsertIntoSystem.Size = new Size(75, 23);
            btnInsertIntoSystem.TabIndex = 44;
            btnInsertIntoSystem.Text = "Insert";
            btnInsertIntoSystem.UseVisualStyleBackColor = true;
            btnInsertIntoSystem.Click += btnInsertIntoSystem_Click;
            // 
            // btnClearList
            // 
            btnClearList.Location = new Point(830, 460);
            btnClearList.Name = "btnClearList";
            btnClearList.Size = new Size(75, 23);
            btnClearList.TabIndex = 45;
            btnClearList.Text = "Clear List";
            btnClearList.UseVisualStyleBackColor = true;
            btnClearList.Click += btnClearList_Click;
            // 
            // btnSelection
            // 
            btnSelection.Location = new Point(830, 546);
            btnSelection.Name = "btnSelection";
            btnSelection.Size = new Size(75, 23);
            btnSelection.TabIndex = 46;
            btnSelection.Text = "Select";
            btnSelection.UseVisualStyleBackColor = true;
            btnSelection.Click += btnSelection_Click;
            // 
            // lblShowSelection
            // 
            lblShowSelection.AutoSize = true;
            lblShowSelection.BackColor = SystemColors.ActiveCaption;
            lblShowSelection.Location = new Point(653, 582);
            lblShowSelection.Name = "lblShowSelection";
            lblShowSelection.Size = new Size(87, 15);
            lblShowSelection.TabIndex = 47;
            lblShowSelection.Text = "Show Selection";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(830, 431);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 48;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(999, 691);
            Controls.Add(btnDelete);
            Controls.Add(lblShowSelection);
            Controls.Add(btnSelection);
            Controls.Add(btnClearList);
            Controls.Add(btnInsertIntoSystem);
            Controls.Add(tbxUserInput);
            Controls.Add(lbxName);
            Controls.Add(tabParkingControl);
            Controls.Add(btnDisplayOrder);
            Controls.Add(panelPark);
            Controls.Add(gbPark);
            Controls.Add(btnSubmit);
            Controls.Add(tbxProfession);
            Controls.Add(tbxPassword);
            Controls.Add(tbxAge);
            Controls.Add(lblInput);
            Controls.Add(tbxName);
            Controls.Add(lblError);
            Controls.Add(lblUserAge);
            Controls.Add(lblUserProfession);
            Controls.Add(lblUsername);
            Controls.Add(btnDisplayInformation);
            Controls.Add(lblHelp);
            Controls.Add(btnCalculate);
            Controls.Add(btnOperation3);
            Controls.Add(btnOperation2);
            Controls.Add(btnOperation1);
            Controls.Add(btnExitApp);
            Controls.Add(btnLoadEventPlay);
            Controls.Add(btnOpen);
            Controls.Add(btnPlay);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bank Application";
            Load += Form1_Load;
            panelPark.ResumeLayout(false);
            panelPark.PerformLayout();
            tabParkingControl.ResumeLayout(false);
            tabPagePay.ResumeLayout(false);
            tabPark.ResumeLayout(false);
            tabPark.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private Button btnPlay;
        private Button btnOpen;
        private Button btnLoadEventPlay;
        private Button btnExitApp;
        private Button btnOperation1;
        private Button btnOperation2;
        private Button btnOperation3;
        private Button btnCalculate;
        private Label lblHelp;
        private Button btnDisplayInformation;
        private Label lblUsername;
        private Label lblUserProfession;
        private Label lblUserAge;
        private Label lblError;
        private TextBox tbxName;
        private Label lblInput;
        private TextBox tbxAge;
        private TextBox tbxPassword;
        private TextBox tbxProfession;
        private Button btnSubmit;
        private RadioButton radioVisa;
        private RadioButton radioCash;
        private RadioButton radioPaypal;
        private Label lblSelection;
        private CheckBox cbCheese;
        private CheckBox cbPatatine;
        private CheckBox cbPepperoni;
        private Button btnOrder;
        private ComboBox comboVehicle;
        private TextBox tbxVehicleNum;
        private Label lblVehicleNum;
        private Label lblVehicleType;
        private Label lblParkHouse;
        private Button btnPark;
        private GroupBox gbPark;
        private Button btnPay;
        private Panel panelPark;
        private Button btnDisplayOrder;
        private TabControl tabParkingControl;
        private TabPage tabPagePay;
        private TabPage tabPark;
        private ListBox lbxName;
        private TextBox tbxUserInput;
        private Button btnInsertIntoSystem;
        private Button btnClearList;
        private Button btnSelection;
        private Label lblShowSelection;
        private Button btnDelete;
    }
}
