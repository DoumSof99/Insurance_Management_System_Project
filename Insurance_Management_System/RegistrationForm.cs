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
    public partial class RegistrationForm : Form
    {

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void clearButton_Click(object sender, EventArgs e)
        {
            ClearControls();
            firstNameTextBox.Select();

        }
        public void ClearControls()
        {
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                tb.Text = string.Empty;
            }
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            RegistrationRecords rr = new RegistrationRecords();
            rr.loadUserData(dataGridView1);
            firstNameTextBox.Select();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            RegistrationRecords deleteRr = new RegistrationRecords();
            deleteRr.deleteRecord(dataGridView1);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            RegistrationRecords saveRr = new RegistrationRecords();
            saveRr.saveRecord(firstNameTextBox, lastNameTextBox, emailTextBox, usernameTextBox, passwordTextBox, confirmPasswordTextBox);
                    
            saveRr.loadUserData(dataGridView1);
            ClearControls();
        }
    }
}
