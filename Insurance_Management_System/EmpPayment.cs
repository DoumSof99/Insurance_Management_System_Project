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
    public partial class EmpPayment : Form
    {
        EmpPaymentRecord epr = new EmpPaymentRecord(); 

        public EmpPayment()
        {
            InitializeComponent();
        }

        private void EmpPayment_Load(object sender, EventArgs e)
        {
            this.Location = new Point(716, 257);
            dateTime.Format = DateTimePickerFormat.Custom;
            dateTime.CustomFormat = "dd MMMM yyyy";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            epr.clearAll(textMobile, textName, textEmail, textAmount, comboBox);
            dataGridView1.DataSource = 0;
        }

       

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (textMobile.Text == "")
            {
                epr.message1();
            }
            else
            {
                epr.Search(textMobile, textName, textEmail, comboBox);
                setDataGrid(Int64.Parse(textMobile.Text));
            }

        }
        public void setDataGrid(Int64 mobile)
        {
            string mySQL = string.Empty;
            mySQL += "SELECT * FROM EmpPayment WHERE EmpMobile = '" + textMobile.Text + "'";

            DataTable EmpData = SQLServerConnection.executeSQL(mySQL);

            dataGridView1.DataSource = EmpData;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (textMobile.Text == "" || textAmount.Text == "")
            {
                epr.message2();
            }
            else
            {
                string mySQL = string.Empty;
                mySQL += "SELECT EmpMobile, EmpDate, EmpAmount FROM EmpPayment WHERE EmpMobile = '" + Int64.Parse(textMobile.Text) + "' AND EmpDate = '" + dateTime.Text + "'";

                DataTable user = SQLServerConnection.executeSQL(mySQL);

                if (user.Rows.Count == 0)
                {
                    Int64 mobile = Int64.Parse(textMobile.Text);
                    string date = dateTime.Text;
                    Int64 amount = Int64.Parse(textAmount.Text);

                    mySQL += "INSERT INTO EmpPayment VALUES ('" + mobile + "', '" + date + "', '" + amount + "')";

                    SQLServerConnection.executeSQL(mySQL);
                    epr.message3();

                    epr.clearAll(textMobile, textName, textEmail, textAmount, comboBox);
                }
                else
                {
                    epr.message4();
                }
            }
        }
    }
}
