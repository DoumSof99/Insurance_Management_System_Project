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
    public partial class EditMemberGroup : Form
    {
        EditGroupMemberRecords emgr = new EditGroupMemberRecords();

        public EditMemberGroup()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditMemberGroup_Load(object sender, EventArgs e)
        {
            this.Location = new Point(716, 257);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            emgr.clearAll(textNumber, textName, textEmail, textAddress, textID, comboBoxDesignation, comboBoxStatus);
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string mySQL = string.Empty;

            mySQL += "SELECT EmpMobile, EmpName, EmpEmail, EmpAddress, EmpID, EmpDesignation, EmpWoking";
            mySQL += " FROM NewEmp WHERE EmpMobile = '" + textNumber.Text + "'";

            DataTable empSearch = SQLServerConnection.executeSQL(mySQL);

            if (empSearch.Rows.Count != 0)
            {
                emgr.Search(empSearch, textName, textEmail, textAddress, textID, comboBoxDesignation, comboBoxStatus);

            }
            else
            {
                emgr.clearAll(textNumber, textName, textEmail, textAddress, textID, comboBoxDesignation, comboBoxStatus);

                emgr.message1();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            emgr.update(textNumber, textName, textEmail, textAddress, textID, comboBoxDesignation, comboBoxStatus);

            emgr.message2();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            emgr.Delete(textNumber);

            emgr.message3();
            
            emgr.clearAll(textNumber, textName, textEmail, textAddress, textID, comboBoxDesignation, comboBoxStatus);
            
        }
    }
}
