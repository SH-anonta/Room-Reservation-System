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
    public partial class EditReservationForm : Form {
        private MainDBFacade db = MainDBFacade.getMainDBFacade();
        private readonly int reservation_id;
        private readonly string loggedInAs;

        private const string TIME_FORMAT= "hh:mm tt";
        private const string DATE_FORMAT= "dd-MMMM-yyyy";

        public EditReservationForm(int reservation_id, string user_name) {
            InitializeComponent();
            this.reservation_id= reservation_id;
            loggedInAs= user_name;

            loadFormData();
        }

        private void loadFormData() {
            Reservation res = db.getRservation(reservation_id);

            StartTimeTB.Text= res.StartTime.ToString(TIME_FORMAT);
            EndTimeTB.Text= res.EndTime.ToString(TIME_FORMAT);
            DateTB.Text = res.StartTime.ToString(DATE_FORMAT);

            RoomNumberTB.Text = res.Room.Number;
            ReservationDescriptionTB.Text = res.Description;


        }

        private void CancleReservationButton_Click(object sender, EventArgs e) {
            db.deleteReservation(reservation_id);
            MessageBox.Show("Reservation cancled");
            this.Close();
        }
    }
}
