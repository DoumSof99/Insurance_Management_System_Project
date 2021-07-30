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
    public partial class UncollectedCustAmount : Form
    {
        UncollectedCustAmountRecords ucar = new UncollectedCustAmountRecords();

        public UncollectedCustAmount()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UncollectedCustAmount_Load(object sender, EventArgs e)
        {
            this.Location = new Point(716, 257);
            dateTime.Format = DateTimePickerFormat.Custom;
            dateTime.CustomFormat = "dd MMMM yyyy";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (textMobile.Text == "")
            {
                ucar.message1();
            }
            else
            {
                ucar.Search(textMobile, textName, textEmail, textMeetingName);
                setDataGrid(Int64.Parse(textMobile.Text));
            }
        }

        public void setDataGrid(Int64 mobile)
        {
            string mySQL = string.Empty;
            mySQL += "SELECT * FROM ClientFees WHERE MobileNum = '" + textMobile.Text + "'";

            DataTable userData = SQLServerConnection.executeSQL(mySQL);

            dataGridView1.DataSource = userData;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (textMobile.Text == "" || textAmount.Text == "")
            {
                MessageBox.Show("Please provide an input", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string mySQL = string.Empty;
                mySQL += "SELECT MobileNum, Date, Amount FROM ClientFees WHERE MobileNum = '" + Int64.Parse(textMobile.Text) + "' AND Date = '" + dateTime.Text + "'";

                DataTable user = SQLServerConnection.executeSQL(mySQL);

                if (user.Rows.Count == 0)
                {
                    Int64 mobile = Int64.Parse(textMobile.Text);
                    string date = dateTime.Text;
                    Int64 amount = Int64.Parse(textAmount.Text);

                    mySQL += "INSERT INTO ClientFees VALUES ('" + mobile + "', '" + date + "', '" + amount + "')";

                    SQLServerConnection.executeSQL(mySQL);

                    ucar.message2();

                    ucar.clearAll(textMobile, textName, textEmail, textAmount, textMeetingName);
                }
                else
                {
                    ucar.message3();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ucar.clearAll(textMobile, textName, textEmail, textAmount, textMeetingName);
            dataGridView1.DataSource = 0;
        }

        
    }
}
