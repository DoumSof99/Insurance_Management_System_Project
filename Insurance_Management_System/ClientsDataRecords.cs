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
    public partial class ClientsDataRecords : Form
    {

        ClientsDataRecordsClass cdrc = new ClientsDataRecordsClass();

        public ClientsDataRecords()
        {
            InitializeComponent();
        }

        private void ClientsDataRecords_Load(object sender, EventArgs e)
        {
            this.Location = new Point(616, 257);

            userDataNoBooked();
            userDataBooked();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void userDataBooked()
        {
            cdrc.Booked(dataGridView1);
        }

        public void userDataNoBooked()
        {
            cdrc.NotBooked(dataGridView2);

        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
