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
    public partial class AddGroupMember : Form
    {
        AddGroupMemberRecords agmr = new AddGroupMemberRecords();

        public AddGroupMember()
        {
            InitializeComponent();
        }

        private void AddGroupMember_Load(object sender, EventArgs e)
        {
            this.Location = new Point(716, 257);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string Tag = "";

            if (textMobileNum.Text == Tag || textName.Text == Tag || textEmail.Text == Tag ||
                textAddress.Text == Tag || textID.Text == Tag || comboBox.SelectedIndex == -1)
            {
                agmr.message1();
            }
            else
            {
                agmr.passValues(textMobileNum, textName, textEmail, textAddress, textID, comboBox);

                agmr.message2();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            agmr.clearAll(textMobileNum, textName, textEmail, textAddress, textID, comboBox);
        }
    }
}
