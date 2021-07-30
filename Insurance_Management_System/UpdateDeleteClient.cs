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
    public partial class UpdateDeleteClient : Form
    {
        UpdateDeleteClientRecords udcr = new UpdateDeleteClientRecords();

        public UpdateDeleteClient()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateDeleteClient_Load(object sender, EventArgs e)
        {
            this.Location = new Point(716, 257);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            udcr.clearAll(textNumber, textName, textFName, textAge, textEmail, textAddress, textID, textMeetingName, comboBoxStatus);
        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            udcr.Update(textNumber, textName, textFName, textAge, textEmail, textAddress, textID, textMeetingName, comboBoxStatus);

            udcr.message1();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            udcr.Delete(textNumber);

            udcr.message2();

            udcr.clearAll(textNumber, textName, textFName, textAge, textEmail, textAddress, textID, textMeetingName, comboBoxStatus);
        }

        // TODO: btnSearch
        private void button1_Click(object sender, EventArgs e)
        {
            string mySQL = string.Empty;

            mySQL += "SELECT * FROM AddClient WHERE MobileNum = '" + textNumber.Text + "'";

            DataTable userSearch = SQLServerConnection.executeSQL(mySQL);

            if (userSearch.Rows.Count != 0)
            {
                udcr.btnSearch(userSearch, textName, textFName, textAge, textEmail, textAddress, textID, textMeetingName, comboBoxStatus);
            }
            else
            {
                udcr.clearAll(textNumber, textName, textFName, textAge, textEmail, textAddress, textID, textMeetingName, comboBoxStatus);

                udcr.message3();
            }
        }
    }
}
