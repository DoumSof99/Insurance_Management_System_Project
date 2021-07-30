using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Insurance_Management_System.Connection;

namespace Insurance_Management_System
{
    public class EmpPaymentRecord : ClearItems
    {
       /* public void ClearAll(TextBox Mobile, TextBox Name, TextBox Email, TextBox Amount, ComboBox combobox)
        {
            Mobile.Clear();
            Name.Clear();
            Email.Clear();
            Amount.Clear();
            combobox.SelectedIndex = -1;
        }
       */
        public void message1()
        {
            MessageBox.Show("Please enter inputs.", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void Search(TextBox Mobile, TextBox Name, TextBox Email, ComboBox combobox)
        {
            string mySQL = string.Empty;
            mySQL += "SELECT EmpName, EmpEmail, EmpDesignation FROM NewEmp WHERE EmpMobile = '" + Mobile.Text + "'";

            DataTable emp = SQLServerConnection.executeSQL(mySQL);

            if (emp.Rows.Count == 0)
            {
                MessageBox.Show("Not an Existing Record.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Name.Text = emp.Rows[0][0].ToString();
                Email.Text = emp.Rows[0][1].ToString();
                combobox.Text = emp.Rows[0][2].ToString();

            }
        }

        public void message2()
        {
            MessageBox.Show("Please provide an input", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        public void message3()
        {
            MessageBox.Show("Succesfully payment procedure.", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void message4()
        {
            MessageBox.Show("Choose another day to pay.", "Information",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

    }
}
