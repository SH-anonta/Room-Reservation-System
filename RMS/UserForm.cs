using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS {
    public partial class UserForm : Form {

        // spaces are prepended to the format so the text appears at the center
        private const string TIME_PICKER_FORMAT= "         hh:mm tt";
        private const string DATE_PICKER_FORMAT= " dd-MMMM-yyyy";
        private string loggedInAsUser;
        public UserForm(string user_name) {
            loggedInAsUser= user_name;
            
            InitializeComponent();
            
            DatePicker.Format = DateTimePickerFormat.Custom;
            DatePicker.CustomFormat = DATE_PICKER_FORMAT;

            StartTimePicker.Format  = DateTimePickerFormat.Custom;
            StartTimePicker.CustomFormat= TIME_PICKER_FORMAT;

            EndTimePicker.Format = DateTimePickerFormat.Custom;
            EndTimePicker.CustomFormat = TIME_PICKER_FORMAT;

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void buttonMake_Click(object sender, EventArgs e) {

        }

        private void buttonPick_Click(object sender, EventArgs e) {

        }
    }
}
