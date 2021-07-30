using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insurance_Management_System
{
    public class ClearItems
    {
        public void clearAll(TextBox Mobile, TextBox Name, TextBox Email, TextBox Amount, ComboBox combobox)
        {
            Mobile.Clear();
            Name.Clear();
            Email.Clear();
            Amount.Clear();
            combobox.SelectedIndex = -1;
        }

        public void clearAll(TextBox MobileNum, TextBox Name, TextBox Email, TextBox Address, TextBox ID, ComboBox combobox)
        {
            MobileNum.Clear();
            Name.Clear();
            Email.Clear();
            Address.Clear();
            ID.Clear();
            combobox.SelectedIndex = -1;

        }

        public void clearAll(TextBox Mobile, TextBox Name, TextBox Email, TextBox Amount, TextBox MeetingName)
        {
            Mobile.Clear();
            Name.Clear();
            Email.Clear();
            Amount.Clear();
            MeetingName.Clear();
        }

        public void clearAll(TextBox Number, TextBox Name, TextBox FName, TextBox Age, TextBox Email, TextBox Address, TextBox ID, TextBox MeetingName, ComboBox Status)
        {
            Number.Clear();
            Name.Clear();
            FName.Clear();
            Age.Clear();
            Email.Clear();
            Address.Clear();
            ID.Clear();
            MeetingName.Clear();
            Status.SelectedIndex = -1;
        }

        public void clearAll(TextBox fullName, TextBox fName, TextBox Age, TextBox Number, TextBox Email, TextBox Address, TextBox ID, ComboBox MeetingName)
        {
            fullName.Clear();
            fName.Clear();
            Age.Clear();
            Number.Clear();
            Email.Clear();
            Address.Clear();
            ID.Clear();
            MeetingName.SelectedIndex = -1;

        }

        public void clearAll(TextBox Number, TextBox Name, TextBox Email, TextBox Address, TextBox ID, ComboBox Designation, ComboBox Status)
        {
            Number.Clear();
            Name.Clear();
            Email.Clear();
            Address.Clear();
            ID.Clear();
            Designation.SelectedIndex = -1;
            Status.SelectedIndex = -1;
        }
    }
}
