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
    public partial class InactiveMembersData : Form
    {
        InactivateMemberDataRecords imdr = new InactivateMemberDataRecords();

        public InactiveMembersData()
        {
            InitializeComponent();
        }

        private void InactiveMembersData_Load(object sender, EventArgs e)
        {
            this.Location = new Point(616, 257);

            imdr.data(dataGridView);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
