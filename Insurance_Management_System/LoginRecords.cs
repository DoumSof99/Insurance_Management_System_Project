using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Insurance_Management_System.Connection;

namespace Insurance_Management_System
{
    public class LoginRecords
    {
        public void displayPass(CheckBox showPass, TextBox pass)
        {
            if (showPass.Checked == true)
            {
                pass.UseSystemPasswordChar = false;
            }
            else
            {
                pass.UseSystemPasswordChar = true;
            }
        }

        public void checkLogin(TextBox user, TextBox pass, CheckBox show)
        {

            user.Clear();
            pass.Clear();
            show.Checked = false;

            
            MainForm formMain = new MainForm();
            formMain.ShowDialog();
            formMain = null;

        }

        public void message1()
        {
            MessageBox.Show("The username or password is incorrect. Try again!",
                       "Login Form", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        public void message2()
        {
            MessageBox.Show("Please enter username and password.", "Login Form",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

    }
}
