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
    public class AddClientRecords : ClearItems
    {
        public void passValues(TextBox fullName, TextBox fName, TextBox Age, TextBox Number, TextBox Email, TextBox Address, TextBox ID, ComboBox MeetingName)
        {
            string mySQL = string.Empty;

            string name = fullName.Text;
            string fname = fName.Text;
            int age = int.Parse(Age.Text);
            Int64 number = Int64.Parse(Number.Text);
            string email = Email.Text;
            string address = Address.Text;
            int id = int.Parse(ID.Text);
            string meetingName = MeetingName.Text;

            mySQL += "INSERT INTO AddClient (FullName, FatherName, Age, MobileNum, Email, Address, PersonalID, MeetingName, Booked)";
            mySQL += "VALUES ('" + name + "','" + fname + "','" + age + "','" + number + "','" + email + "','" + address + "','" + id + "','" + meetingName + "', 'Yes')";
            mySQL += "UPDATE Meeting SET MeetingBooked = 'Yes' WHERE MeetingName = '" + meetingName + "'";

            SQLServerConnection.executeSQL(mySQL);
        }

        public void Add(ComboBox meetingName)
        {
            string mySQL = string.Empty;

            mySQL += "SELECT MeetingName FROM Meeting ";
            mySQL += "WHERE MeetingStatus = 'Yes' AND MeetingBooked = 'No'";

            DataTable addClient = SQLServerConnection.executeSQL(mySQL);

            for (int i = 0; i < addClient.Rows.Count; i++)
            {
                string client = addClient.Rows[i][0].ToString();
                meetingName.Items.Add(client);
            }
        }

        /*public void clearAll(TextBox fullName, TextBox fName, TextBox Age, TextBox Number, TextBox Email, TextBox Address, TextBox ID, ComboBox MeetingName)
        {
            fullName.Clear();
            fName.Clear();
            Age.Clear();
            Number.Clear();
            Email.Clear();
            Address.Clear();
            ID.Clear();
            MeetingName.SelectedIndex = -1;

        }*/

        public void message1()
        {
            MessageBox.Show("Please fill all the information.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        public void message2()
        {
            MessageBox.Show("Now,you can see the client details.", "Client Added",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
