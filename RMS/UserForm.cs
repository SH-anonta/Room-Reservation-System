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
        private const string DATE_PICKER_FORMAT= "  dd-MMMM-yyyy";

        public UserForm() {
            InitializeComponent();
            DatePicker.Format = DateTimePickerFormat.Custom;
            DatePicker.CustomFormat = DATE_PICKER_FORMAT;

            TimePicker.Format  = DateTimePickerFormat.Custom;
            TimePicker.CustomFormat= TIME_PICKER_FORMAT;


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
    }
}
