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
    public class UncollectedCustAmountRecords : ClearItems
    {
        /*public void clearAll(TextBox Mobile, TextBox Name, TextBox Email, TextBox Amount, TextBox MeetingName)
        {
            Mobile.Clear();
            Name.Clear();
            Email.Clear();
            Amount.Clear();
            MeetingName.Clear();
        }
        */
        public void message1()
        {
            MessageBox.Show("Please enter inputs.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void Search(TextBox Mobile, TextBox Name, TextBox Email, TextBox MeetingName)
        {
            string mySQL = string.Empty;
            
            mySQL += "SELECT FullName, Email, MeetingName FROM AddClient WHERE MobileNum = '" + Mobile.Text + "'";

            DataTable user = SQLServerConnection.executeSQL(mySQL);

            if (user.Rows.Count == 0)
            {
                MessageBox.Show("Not an Existing Record.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Name.Text = user.Rows[0][0].ToString();
                Email.Text = user.Rows[0][1].ToString();
                MeetingName.Text = user.Rows[0][2].ToString();
            }
        }

        public void message2()
        {
            MessageBox.Show("Fees payment.", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void message3()
        {
            MessageBox.Show("Choose another day to pay.", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

    }
}
