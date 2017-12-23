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
    public partial class CreateReservation : Form {
        private MainDBFacade db = MainDBFacade.getMainDBFacade();

        // space is prepended to datetune format staring to move text in center of date time picker widget
        private const string TIME_PICKER_FORMAT= "                  hh:mm tt";
        private const string DATE_PICKER_FORMAT= " dd-MMMM-yyyy";

        public CreateReservation() {
            InitializeComponent();
            loadFormData();
        }

        private void loadFormData() {
            DatePicker.Format = DateTimePickerFormat.Custom;
            DatePicker.CustomFormat = DATE_PICKER_FORMAT;

            StartTimePicker.Format  = DateTimePickerFormat.Custom;
            StartTimePicker.CustomFormat= TIME_PICKER_FORMAT;

            EndTimePicker.Format = DateTimePickerFormat.Custom;
            EndTimePicker.CustomFormat = TIME_PICKER_FORMAT;

            RoomTypeCB.DataSource = db.getRoomTypeNames();
        }

        private void PicRandomRoomButton_Click(object sender, EventArgs e) {

        }

        private void MakeReservationButton_Click(object sender, EventArgs e) {

        }
    }
}
