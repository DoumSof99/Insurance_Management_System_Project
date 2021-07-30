using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Insurance_Management_System.Connection;

namespace Insurance_Management_System
{
    public partial class ManageMeeting : Form
    {
        private string tag = "Meeting Found";
        ManageMeetingRecords mmr = new ManageMeetingRecords();
        public ManageMeeting()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageMeeting_Load(object sender, EventArgs e)
        {
            this.Location = new Point(716, 257);
            labelMeeting.Visible = false;
            labelMeetingExist.Visible = false;

            DataTable userMeeting = SQLServerConnection.executeSQL("SELECT MeetingName, MeetingStatus, MeetingBooked FROM Meeting");
            dataGridView1.DataSource = userMeeting;
            mmr.headersGrid(dataGridView1);
        }

        private void btnAddMeeting_Click(object sender, EventArgs e)
        {
            string mySQL = string.Empty;

            mySQL += "SELECT * FROM Meeting ";
            mySQL += "WHERE MeetingName = '" + textBoxMeetingName1.Text + "' ";

            DataTable userMeeting = SQLServerConnection.executeSQL(mySQL);
            
            if(userMeeting.Rows.Count == 0)
            {
                string status;

                if (checkBox1.Checked)
                {
                    status = "Yes";
                }
                else
                {
                    status = "No";
                }

                labelMeetingExist.Visible = false;

                mySQL += "INSERT INTO Meeting (MeetingName, MeetingStatus, MeetingBooked) ";
                mySQL += "values('" + textBoxMeetingName1.Text + "', '" + status + "', 'No')";

                SQLServerConnection.executeSQL(mySQL);

                mmr.message1();
                
                ManageMeeting_Load(this, null);
            }
            else
            {
                labelMeetingExist.Text = "This Meeting already Scheduled.";
                labelMeetingExist.Visible = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string mySQL = string.Empty;

            mySQL += "SELECT * FROM Meeting ";
            mySQL += "WHERE MeetingName = '" + textBoxMeetingName2.Text + "' ";

            DataTable userMeetingSchedule = SQLServerConnection.executeSQL(mySQL);

            if(userMeetingSchedule.Rows.Count == 0)
            {
                labelMeeting.Text = "This Meeting Does't Exist";
                labelMeeting.Visible = true;
                checkBox2.Checked = false;
            }
            else
            {
                labelMeeting.Text = "Meeting Found";
                labelMeeting.Visible = true;

                string status = "Yes";

                if (userMeetingSchedule.Rows[0][2].ToString() != status)
                {
                    checkBox2.Checked = false;
                }
                else
                {
                    checkBox2.Checked = true;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string status;
            string mySQL = string.Empty;

            if (checkBox2.Checked)
            {
                status = "Yes";
            }
            else
            {
                status = "No";
            }

            mySQL += "UPDATE Meeting SET MeetingStatus = '" + status + "' WHERE MeetingName = '" + textBoxMeetingName2.Text + "'";

            SQLServerConnection.executeSQL(mySQL);

            if(labelMeeting.Text == tag)
            {
                mmr.message2();

            }
            else
            {
                mmr.message3();
            }

            ManageMeeting_Load(this, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string mySQL = string.Empty;
            
            if (labelMeeting.Text == tag)
            {
                mySQL += "DELETE FROM Meeting WHERE MeetingName  = '" + textBoxMeetingName2.Text + "'";

                SQLServerConnection.executeSQL(mySQL);

                mmr.message4();
                ManageMeeting_Load(this, null);
            }
            else
            {
                mmr.message5();
            }
        }
    }
}
