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
    public class EditGroupMemberRecords : ClearItems
    {
        /*public void clearAll(TextBox Number, TextBox Name, TextBox Email, TextBox Address, TextBox ID, ComboBox Designation, ComboBox Status)
        {
            Number.Clear();
            Name.Clear();
            Email.Clear();
            Address.Clear();
            ID.Clear();
            Designation.SelectedIndex = -1;
            Status.SelectedIndex = -1;
        }*/

        public void Search(DataTable emp, TextBox Name, TextBox Email, TextBox Address, TextBox ID, ComboBox Designation, ComboBox Status)
        {
            Name.Text = emp.Rows[0][1].ToString();
            Email.Text = emp.Rows[0][2].ToString();
            Address.Text = emp.Rows[0][3].ToString();
            ID.Text = emp.Rows[0][4].ToString();
            Designation.Text = emp.Rows[0][5].ToString();
            Status.Text = emp.Rows[0][6].ToString();
        }

        public void message1()
        {
            MessageBox.Show("There is not record with this Mobile... Try again!", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void update(TextBox Number, TextBox Name, TextBox Email, TextBox Address, TextBox ID, ComboBox Designation, ComboBox Status)
        {
            string mySQL = string.Empty;

            Int64 mobile = Int64.Parse(Number.Text);
            string name = Name.Text;
            string email = Email.Text;
            string address = Address.Text;
            int id = int.Parse(ID.Text);
            string designation = Designation.Text;
            string status = Status.Text;

            mySQL += "UPDATE NewEmp SET EmpName = '" + name + "', EmpEmail = '" + email + "', EmpAddress = '" + address + "', EmpID = '" + id + "', EmpDesignation = '" + designation + "', EmpWoking = '" + status + "'";
            mySQL += "WHERE EmpMobile = '" + mobile + "'";

            SQLServerConnection.executeSQL(mySQL);
        }

        public void message2()
        {
            MessageBox.Show("Data Updated Succesfuly!", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void Delete(TextBox Number)
        {
            string mySQL = string.Empty;

            mySQL += "DELETE FROM NewEmp WHERE EmpMobile = '" + Number.Text + "'";

            SQLServerConnection.executeSQL(mySQL);
        }

        public void message3()
        {
            MessageBox.Show("Data Deleted Succesfuly!", "Delete",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

    }
}
