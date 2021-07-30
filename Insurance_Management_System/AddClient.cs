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
    public partial class AddClient : Form
    {
        AddClientRecords acr = new AddClientRecords();

        public AddClient()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            this.Location = new Point(716, 257);
            acr.Add(comboBoxMeetingName);
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            acr.clearAll(textFullName, textFatherName, textAge, textNumber, textEmail, textAddress, textID, comboBoxMeetingName);
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            

            if (textFullName.Text == "" || textFatherName.Text == "" || textNumber.Text == "" || textEmail.Text == "" || textAddress.Text == "" || textID.Text == "" || comboBoxMeetingName.SelectedIndex == -1)
            {
                acr.message1();
            }
            else
            {
                acr.passValues(textFullName, textFatherName, textAge, textNumber, textEmail, textAddress, textID, comboBoxMeetingName);

                acr.message2();

                acr.clearAll(textFullName, textFatherName, textAge, textNumber, textEmail, textAddress, textID, comboBoxMeetingName);
            }
        }
    }
}
