using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Insurance_Management_System.Connection;

namespace Insurance_Management_System
{
    public class AddGroupMemberRecords : ClearItems
    {
        public void passValues(TextBox MobileNum, TextBox Name, TextBox Email, TextBox Address, TextBox ID, ComboBox combobox)
        {
            string mySQL = string.Empty;

            Int64 mobile = Int64.Parse(MobileNum.Text);
            string name = Name.Text;
            string email = Email.Text;
            string address = Address.Text;
            string id = ID.Text;
            string designation = combobox.Text;

            mySQL += "INSERT INTO NewEmp (EmpMobile, EmpName, EmpEmail, EmpAddress, EmpID, EmpDesignation, EmpWoking) ";
            mySQL += "VALUES ('" + mobile + "', '" + name + "', '" + email + "', '" + address + "', '" + id + "', '" + designation + "', 'Yes')";

            SQLServerConnection.executeSQL(mySQL);
        }

        public void message1()
        {
            MessageBox.Show("Please fill all the information.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void message2()
        {
            MessageBox.Show("Data Succesfuly Added.", "Data",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /*
        public void clearAll(TextBox MobileNum, TextBox Name, TextBox Email, TextBox Address, TextBox ID, ComboBox combobox)
        {
            MobileNum.Clear();
            Name.Clear();
            Email.Clear();
            Address.Clear();
            ID.Clear();
            combobox.SelectedIndex = -1;

        }
        */
    }
}
