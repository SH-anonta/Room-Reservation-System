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
        MainDBFacade db = MainDBFacade.getMainDBFacade();

        // spaces are prepended to the format so the text appears at the center
        private string loggedInAsUser;

        public UserForm(string user_name) {
            loggedInAsUser= user_name;
            
            InitializeComponent();
            UpdteResevationsGridview();
        }
        
        private void UpdteResevationsGridview() {
            const string DATE_FORMAT= "dd-MMMM-yy";
            int user_id = db.UserNameToID(loggedInAsUser);

            bool show_past_records = ShowPastReservationsCHB.Checked;
            
            List<Reservation> data = null;
            
            if(show_past_records) data = db.getAllReservationsofUser(user_id);
            else data = db.getFutureReservationsofUser(user_id);
            
            var show = from x in data
                       select new{ ID=x.Id,
                                   Date= x.StartTime.Date.ToString(DATE_FORMAT),
                                   From= x.StartTime.TimeOfDay,
                                   To= x.EndTime.TimeOfDay,
                                   RoomNumber = x.Room.Number,
                                   Reservee = x.User.UserName
                                   };

            ReservationsDataGridView.DataSource= show.ToList();
        }

        private void CreateReservation_Click(object sender, EventArgs e) {
            CreateReservation creator =  new CreateReservation(db.getUser(loggedInAsUser));
            creator.Show();
        }

        private void ShowPastReservationsCHB_CheckedChanged(object sender, EventArgs e) {
            UpdteResevationsGridview();
        }

        private void ReservationsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            int row = e.RowIndex;

            int reservation_id = (int) ReservationsDataGridView.Rows[row].Cells[0].Value;

            EditReservationForm editor = new EditReservationForm(reservation_id, loggedInAsUser);
            editor.Show();
        }
    }
}
