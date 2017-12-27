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
            string description = ReservationDescriptionRTB.Text;
            string room_number = RoomNumberTB.Text;
            string room_type = RoomTypeCB.Text;
            string min_capacity = MinCapacityTB.Text;

            // create datetimes with given date and time of day. second is always 0
            DateTime start_time = new DateTime(date.Year, date.Month, date.Day, start.Hour, start.Minute, 0);
            DateTime end_time = new DateTime(date.Year, date.Month, date.Day, end.Hour, end.Minute, 0);

            string error_msg= "";
            if(!DataValidator.validateReservationDataForRoomPicker(start, end, description, room_type, min_capacity, out error_msg)) {
                MessageBox.Show(error_msg, "Error");
                return;
            }

            int capacity =  int.Parse(min_capacity);

            try {
                string picked_room = db.getRandomAvalableRoom(start_time, end_time, capacity, db.getRoomTypeIdfromName(room_type));
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
            string description = ReservationDescriptionRTB.Text;
            string room_number = RoomNumberTB.Text;
            string room_type = RoomTypeCB.Text;

            // create datetimes with given date and time of day. second is always 0
            DateTime start_time = new DateTime(date.Year, date.Month, date.Day, start.Hour, start.Minute, 0);
            DateTime end_time = new DateTime(date.Year, date.Month, date.Day, end.Hour, end.Minute, 0);

            

            string error_msg= "";
            if(!DataValidator.validateReservationData(start, end, description, room_number, room_type, out error_msg)) {
                MessageBox.Show(error_msg, "Error");
                return;
            }

            bool success = false;
            int room_id = db.getRoomIdFormRoomNumber(room_number );

            try{
                db.createReservation(start_time, end_time, reservee.Id, room_id, description);
                success = true;
            }
            catch(RoomUnavalableException ex) {
                MessageBox.Show(ex.Message);
            }

            if(success){
                MessageBox.Show("Reservations made");
                this.Close();
            }

        }

        private void RoomNumberTB_DoubleClick(object sender, EventArgs e) {

        }
    }
}
