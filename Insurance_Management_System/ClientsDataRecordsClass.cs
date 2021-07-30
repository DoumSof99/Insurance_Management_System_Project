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
    public class ClientsDataRecordsClass
    {
        public void Booked(DataGridView dataGrid1)
        {
            string mySQL = string.Empty;

            mySQL += "SELECT FullName, FatherName, Age, MobileNum, Email, Address, PersonalID, MeetingName, Booked";
            mySQL += " FROM AddClient WHERE Booked = 'Yes'";

            DataTable dataBooked = SQLServerConnection.executeSQL(mySQL);

            dataGrid1.DataSource = dataBooked;
            dataGrid1.Columns[0].HeaderText = "Full Name";
            dataGrid1.Columns[1].HeaderText = "Father Name";
            dataGrid1.Columns[2].HeaderText = "Age";
            dataGrid1.Columns[3].HeaderText = "Mobile Number";
            dataGrid1.Columns[4].HeaderText = "Email";
            dataGrid1.Columns[5].HeaderText = "Address";
            dataGrid1.Columns[6].HeaderText = "Personal ID";
            dataGrid1.Columns[7].HeaderText = "Meeting Name";
            dataGrid1.Columns[8].HeaderText = "Booking Status";
        }

        public void NotBooked(DataGridView dataGrid2)
        {
            string mySQL = string.Empty;

            mySQL += "SELECT FullName, FatherName, Age, MobileNum, Email, Address, PersonalID, MeetingName, Booked";
            mySQL += " FROM AddClient WHERE Booked = 'No' ";

            DataTable userNoBooked = SQLServerConnection.executeSQL(mySQL);

            dataGrid2.DataSource = userNoBooked;
            dataGrid2.Columns[0].HeaderText = "Full Name";
            dataGrid2.Columns[1].HeaderText = "Father Name";
            dataGrid2.Columns[2].HeaderText = "Age";
            dataGrid2.Columns[3].HeaderText = "Mobile Number";
            dataGrid2.Columns[4].HeaderText = "Email";
            dataGrid2.Columns[5].HeaderText = "Address";
            dataGrid2.Columns[6].HeaderText = "Personal ID";
            dataGrid2.Columns[7].HeaderText = "Meeting Name";
            dataGrid2.Columns[8].HeaderText = "Booking Status";
        }

    }
}
