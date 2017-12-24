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
        private User reservee;
        
        public CreateReservation(User user) {
            InitializeComponent();
            reservee= user;
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
            DateTime date = DatePicker.Value;
            DateTime start  = StartTimePicker.Value;
            DateTime end  = EndTimePicker.Value;

            // create datetimes with given date and time of day. second is always 0
            DateTime start_time = new DateTime(date.Year, date.Month, date.Day, start.Hour, start.Minute, 0);
            DateTime end_time = new DateTime(date.Year, date.Month, date.Day, end.Hour, end.Minute, 0);

            try {
                string picked_room = db.getRandomAvalableRoom(start_time, end_time, db.getRoomTypeIdfromName(RoomTypeCB.Text));
                RoomNumberTB.Text= picked_room;
            }
            catch (NoRoomFoundException ex) {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void MakeReservationButton_Click(object sender, EventArgs e) {
            DateTime date = DatePicker.Value;
            DateTime start  = StartTimePicker.Value;
            DateTime end  = EndTimePicker.Value;

            // create datetimes with given date and time of day. second is always 0
            DateTime start_time = new DateTime(date.Year, date.Month, date.Day, start.Hour, start.Minute, 0);
            DateTime end_time = new DateTime(date.Year, date.Month, date.Day, end.Hour, end.Minute, 0);

            int room_id = db.getRoomIdFormRoomNumber(RoomNumberTB.Text);

            bool success = false;

            try{
                db.createReservation(start_time, end_time, reservee.Id, room_id, ReservationDescriptionRTB.Text);
                success = true;
            }
            catch(RoomUnavalableException ex) {
                MessageBox.Show(ex.Message);
            }

            if(success){
                MessageBox.Show("Reservations made");
            }

        }
    }
}
