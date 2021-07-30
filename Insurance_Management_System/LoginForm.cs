using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Insurance_Management_System.Connection;

namespace Insurance_Management_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            usernameTextBox.Select();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openRegisterFormLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm register = new RegistrationForm();
            register.ShowDialog();
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoginRecords displayLr = new LoginRecords();
            displayLr.displayPass(showPasswordCheckBox, passwordTextBox);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(usernameTextBox.Text) && !string.IsNullOrEmpty(passwordTextBox.Text))
            {
                string mySQL = string.Empty;

                mySQL += "SELECT * FROM LoginTbl ";
                mySQL += "WHERE Username = '" + usernameTextBox.Text + "' ";
                mySQL += "AND Password = '" + passwordTextBox.Text + "'";

                DataTable userData = SQLServerConnection.executeSQL(mySQL);

                if(userData.Rows.Count > 0)
                {
                    LoginRecords checkLr = new LoginRecords();
                    checkLr.checkLogin(usernameTextBox, passwordTextBox, showPasswordCheckBox);

                    this.Show();
                    this.usernameTextBox.Select();
                }
                else
                {
                    LoginRecords message = new LoginRecords();
                    message.message1();
                    usernameTextBox.Focus();
                    usernameTextBox.SelectAll();
                }
            }
            else
            {
                LoginRecords message = new LoginRecords();
                message.message2();
                usernameTextBox.Select();
            }
        }
    }
}
