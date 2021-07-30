using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Insurance_Management_System.Connection;

namespace Insurance_Management_System
{
    public class ManageMeetingRecords
    {
        public void headersGrid(DataGridView dataGrid)
        {
            dataGrid.Columns[0].HeaderText = "Meeting Name";
            dataGrid.Columns[1].HeaderText = "Active";
            dataGrid.Columns[2].HeaderText = "Client Booked";
            dataGrid.Columns[0].Width = 123;
            dataGrid.Columns[1].Width = 123;
            dataGrid.Columns[2].Width = 123;
        }

        public void message1()
        {
            MessageBox.Show("Data Inserted.", "Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void message2()
        {
            MessageBox.Show("Data Updated.", "Data",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void message3()
        {
            MessageBox.Show("Trying to update a non-existing Client.", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void message4()
        {
            MessageBox.Show("Data Deleted.", "Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void message5()
        {
            MessageBox.Show("Trying to delete a non-existing Client.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
