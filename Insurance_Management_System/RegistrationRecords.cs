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
    public class RegistrationRecords
    {
        public void loadUserData(DataGridView dataGridView)
        {
            // Todo
            DataTable userData = SQLServerConnection.executeSQL("SELECT (First_Name + ' ' + Last_Name) AS Fullname, Username FROM LoginTbl");
            dataGridView.DataSource = userData;
            dataGridView.Columns[0].HeaderText = "Full Name";
            dataGridView.Columns[1].HeaderText = "Username";
            dataGridView.Columns[0].Width = 234;
            dataGridView.Columns[1].Width = 234;
        }

        public void saveRecord(TextBox first, TextBox last,TextBox email, TextBox user, TextBox pass, TextBox confPass)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;
            string caption = "Save Data";

            if (string.IsNullOrEmpty(first.Text))
            {
                MessageBox.Show("Please enter First Name", caption, btn, ico);
                first.Select();
                return;
            }

            if (string.IsNullOrEmpty(last.Text))
            {
                MessageBox.Show("Please enter Last Name", caption, btn, ico);
                last.Select();
                return;
            }

            if (string.IsNullOrEmpty(user.Text))
            {
                MessageBox.Show("Please enter UserName", caption, btn, ico);
                user.Select();
                return;
            }

            if (string.IsNullOrEmpty(pass.Text))
            {
                MessageBox.Show("Please enter Password", caption, btn, ico);
                pass.Select();
                return;
            }

            if (string.IsNullOrEmpty(confPass.Text))
            {
                MessageBox.Show("Please enter Confirmation Password", caption, btn, ico);
                confPass.Select();
                return;
            }

            if (pass.Text != confPass.Text)
            {
                MessageBox.Show("Your password and confirmation password do not match", caption, btn, ico);
                confPass.Select();
                return;
            }

            string theSQL = "SELECT Username FROM LoginTbl WHERE Username = '" + user.Text + "'";
            DataTable checkDuplicates = Insurance_Management_System.Connection.SQLServerConnection.executeSQL(theSQL);

            if (checkDuplicates.Rows.Count > 0)
            {
                MessageBox.Show("The username already exists. Please try another username",
                    "Registration Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                user.SelectAll();
                return;
            }

            DialogResult result;
        
            result = MessageBox.Show("Do you want to save the record?", "Save Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string mySQL = string.Empty;

                mySQL += "INSERT INTO LoginTbl (First_Name, Last_Name, Email_Address, Username, Password) ";
                mySQL += "VALUES ('" + first.Text + "','" + last.Text + "','" + email.Text + "','" + user.Text + "','" + pass.Text + "')";

                Insurance_Management_System.Connection.SQLServerConnection.executeSQL(mySQL);

                MessageBox.Show("The record has beem saved successfully.", "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void deleteRecord(DataGridView dataGridView)
        {
            try
            {
                if (MessageBox.Show("Do you want to permantly delete the selected record?",
                    "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    SQLServerConnection.executeSQL("DELETE FROM LoginTbl WHERE Username = '" + dataGridView.CurrentRow.Cells[1].Value + "'");

                    RegistrationRecords rr = new RegistrationRecords();
                    rr.loadUserData(dataGridView);

                    MessageBox.Show("The record has been deleted.",
                        "Delete Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }
            }
            catch (Exception)
            {
                //ana error occured
            }
        }

    }
}
