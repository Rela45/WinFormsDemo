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
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 305);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(97, 34);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 345);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(97, 36);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += ButtonCancelOperation_Clicl;
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(12, 262);
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
            btnOpen.Location = new Point(527, 332);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(153, 63);
            btnOpen.TabIndex = 4;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnLoadEventPlay
            // 
            btnLoadEventPlay.Location = new Point(505, 404);
            btnLoadEventPlay.Name = "btnLoadEventPlay";
            btnLoadEventPlay.Size = new Size(75, 23);
            btnLoadEventPlay.TabIndex = 5;
            btnLoadEventPlay.Text = "PlayAgain";
            btnLoadEventPlay.UseVisualStyleBackColor = true;
            // 
            // btnExitApp
            // 
            btnExitApp.Location = new Point(623, 404);
            btnExitApp.Name = "btnExitApp";
            btnExitApp.Size = new Size(75, 23);
            btnExitApp.TabIndex = 6;
            btnExitApp.Text = "Exit";
            btnExitApp.UseVisualStyleBackColor = true;
            btnExitApp.Click += btnExitApp_Click;
            // 
            // btnOperation1
            // 
            btnOperation1.Location = new Point(243, 59);
            btnOperation1.Name = "btnOperation1";
            btnOperation1.Size = new Size(75, 23);
            btnOperation1.TabIndex = 7;
            btnOperation1.Text = "0";
            btnOperation1.UseVisualStyleBackColor = true;
            // 
            // btnOperation2
            // 
            btnOperation2.Location = new Point(341, 59);
            btnOperation2.Name = "btnOperation2";
            btnOperation2.Size = new Size(75, 23);
            btnOperation2.TabIndex = 8;
            btnOperation2.Text = "0";
            btnOperation2.UseVisualStyleBackColor = true;
            // 
            // btnOperation3
            // 
            btnOperation3.Location = new Point(436, 59);
            btnOperation3.Name = "btnOperation3";
            btnOperation3.Size = new Size(75, 23);
            btnOperation3.TabIndex = 9;
            btnOperation3.Text = "0";
            btnOperation3.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(98, 60);
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
            lblHelp.Location = new Point(98, 197);
            lblHelp.Name = "lblHelp";
            lblHelp.Size = new Size(257, 15);
            lblHelp.TabIndex = 11;
            lblHelp.Text = "Click the button to display the user information";
            // 
            // btnDisplayInformation
            // 
            btnDisplayInformation.Location = new Point(171, 127);
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
            lblUsername.Location = new Point(562, 235);
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
            lblUserProfession.Location = new Point(562, 272);
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
            lblUserAge.Location = new Point(562, 289);
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
            lblError.Location = new Point(322, 404);
            lblError.Name = "lblError";
            lblError.Size = new Size(94, 15);
            lblError.TabIndex = 16;
            lblError.Text = "Error in Program";
            lblError.TextAlign = ContentAlignment.TopCenter;
            // 
            // tbxName
            // 
            tbxName.Location = new Point(562, 107);
            tbxName.Name = "tbxName";
            tbxName.PlaceholderText = "Type your Name...";
            tbxName.Size = new Size(194, 23);
            tbxName.TabIndex = 17;
            // 
            // lblInput
            // 
            lblInput.BackColor = SystemColors.ActiveCaption;
            lblInput.BorderStyle = BorderStyle.FixedSingle;
            lblInput.Location = new Point(562, 253);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(202, 15);
            lblInput.TabIndex = 18;
            lblInput.Text = "Password";
            lblInput.TextAlign = ContentAlignment.TopCenter;
            // 
            // tbxAge
            // 
            tbxAge.Location = new Point(562, 136);
            tbxAge.Name = "tbxAge";
            tbxAge.PlaceholderText = "Type your Age...";
            tbxAge.Size = new Size(194, 23);
            tbxAge.TabIndex = 19;
            // 
            // tbxPassword
            // 
            tbxPassword.Location = new Point(562, 165);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.PasswordChar = '*';
            tbxPassword.PlaceholderText = "Enter Password...";
            tbxPassword.Size = new Size(194, 23);
            tbxPassword.TabIndex = 20;
            // 
            // tbxProfession
            // 
            tbxProfession.Location = new Point(562, 197);
            tbxProfession.Name = "tbxProfession";
            tbxProfession.PlaceholderText = "Type your Profession...";
            tbxProfession.Size = new Size(194, 23);
            tbxProfession.TabIndex = 21;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(453, 215);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 22;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
