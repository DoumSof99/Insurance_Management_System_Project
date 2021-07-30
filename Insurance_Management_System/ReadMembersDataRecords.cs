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
    public class ReadMembersDataRecords
    {
        public void data(DataGridView dataGrid)
        {
            string mySQL = string.Empty;

            mySQL += "SELECT EmpMobile, EmpName, EmpEmail, EmpAddress, EmpID, EmpDesignation, EmpWoking";
            mySQL += " FROM NewEmp WHERE EmpWoking = 'Yes'";

            DataTable dataEmp = SQLServerConnection.executeSQL(mySQL);

            dataGrid.DataSource = dataEmp;
            dataGrid.Columns[0].HeaderText = "Mobile Number";
            dataGrid.Columns[1].HeaderText = "Member Name";
            dataGrid.Columns[2].HeaderText = "Email";
            dataGrid.Columns[3].HeaderText = "Address";
            dataGrid.Columns[4].HeaderText = "Personal ID";
            dataGrid.Columns[5].HeaderText = "Designation";
            dataGrid.Columns[6].HeaderText = "Status";
        }
    }
}
