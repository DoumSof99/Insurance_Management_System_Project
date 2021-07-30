using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insurance_Management_System
{
    public partial class MainForm : Form
    {
        Boolean isVisible = true;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            MainFomRecords mr = new MainFomRecords();
            mr.logOutBt();
            this.Hide();
        }

        private void btnMeeting_Click(object sender, EventArgs e)
        {
            ManageMeeting mm = new ManageMeeting();
            mm.Show();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isVisible == true)
            {
                IMSLabel.Visible = true;
                isVisible = false;
            }
            else
            {
                IMSLabel.Visible = false;
                isVisible = true;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            AddClient ac = new AddClient();
            ac.Show();
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            UpdateDeleteClient udc = new UpdateDeleteClient();
            udc.Show();
        }

        private void btnClientUncollected_Click(object sender, EventArgs e)
        {
            UncollectedCustAmount uca = new UncollectedCustAmount();
            uca.Show();
        }

        private void btnClientData_Click(object sender, EventArgs e)
        {
            ClientsDataRecords cdr = new ClientsDataRecords();
            cdr.Show();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            AddGroupMember agm = new AddGroupMember();
            agm.Show();
        }

        private void btnEditMember_Click(object sender, EventArgs e)
        {
            EditMemberGroup emg = new EditMemberGroup();
            emg.Show();
        }

        private void btnMemberPayment_Click(object sender, EventArgs e)
        {
            EmpPayment ep = new EmpPayment();
            ep.Show();
        }

        private void btnMembersData_Click(object sender, EventArgs e)
        {
            ReadMembersData rmd = new ReadMembersData();
            rmd.Show();
        }

        private void btnInactiveMember_Click(object sender, EventArgs e)
        {
            InactiveMembersData igm = new InactiveMembersData();
            igm.Show();
        }
    }
}
