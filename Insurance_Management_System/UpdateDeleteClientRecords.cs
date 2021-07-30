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
    public class UpdateDeleteClientRecords : ClearItems
    {
        /*
        public void clearAll(TextBox Number, TextBox Name, TextBox FName, TextBox Age, TextBox Email, TextBox Address, TextBox ID, TextBox MeetingName, ComboBox Status)
        {
            Number.Clear();
            Name.Clear();
            FName.Clear();
            Age.Clear();
            Email.Clear();
            Address.Clear();
            ID.Clear();
            MeetingName.Clear();
            Status.SelectedIndex = -1;
        }
        */
        public void Update(TextBox Number, TextBox Name, TextBox FName, TextBox Age, TextBox Email, TextBox Address, TextBox ID, TextBox MeetingName, ComboBox Status)
        {
            string mySQL = string.Empty;

            Int64 mobile = Int64.Parse(Number.Text);
            string name = Name.Text;
            string fname = FName.Text;
            int age = int.Parse(Age.Text);
            string email = Email.Text;
            string address = Address.Text;
            int id = int.Parse(ID.Text);
            string meetingName = MeetingName.Text;
            string status = Status.Text;

            mySQL += "UPDATE AddClient SET FullName = '" + name + "', FatherName = '" + fname + "', Age = '" + age + "', Email = '" + email + "', Address = '" + address + "', PersonalID = '" + id + "', MeetingName = '" + meetingName + "', Booked = '" + status + "'";
            mySQL += "WHERE MobileNum = '" + mobile + "'";
            mySQL += "UPDATE Meeting SET MeetingBooked = '" + status + "'";
            mySQL += "WHERE MeetingName = '" + meetingName + "'";

            SQLServerConnection.executeSQL(mySQL);
        }
        public void message1()
        {
            MessageBox.Show("Data Updated Succesfuly!", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void Delete(TextBox Number)
        {
            string mySQL = string.Empty;

            mySQL += "DELETE FROM AddClient WHERE MobileNum = '" + Number.Text + "'";

            SQLServerConnection.executeSQL(mySQL);
        }

        public void message2()
        {
            MessageBox.Show("Data Deleted Succesfuly!", "Delete",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void message3()
        {
            MessageBox.Show("There is not record with this Mobile... Try again!", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void btnSearch(DataTable user, TextBox Name, TextBox FName, TextBox Age, TextBox Email, TextBox Address, TextBox ID, TextBox MeetingName, ComboBox Status)
        {
            Name.Text = user.Rows[0][1].ToString();
            FName.Text = user.Rows[0][2].ToString();
            Age.Text = user.Rows[0][3].ToString();
            Email.Text = user.Rows[0][5].ToString();
            Address.Text = user.Rows[0][6].ToString();
            ID.Text = user.Rows[0][7].ToString();
            MeetingName.Text = user.Rows[0][8].ToString();
            Status.Text = user.Rows[0][9].ToString();
        }
    }
}
