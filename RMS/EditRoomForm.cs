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
    public partial class EditRoomForm : Form {

        private MainDBFacade db = MainDBFacade.getMainDBFacade();
        private string to_edit_room_number;

        public EditRoomForm(string room_number) {
            this.to_edit_room_number = room_number;
            InitializeComponent();
            LoadFormData();
        }

        public void LoadFormData() {
            int id = db.getRoomIdFormRoomNumber(to_edit_room_number);
            Room room = db.getRoomByID(id);
            
            RoomTypeCB.DataSource = db.getRoomTypeNames();
            AnnexCB.DataSource = db.getAnnexNames();

            RoomNumberTB.Text= room.Number;
            RoomNameTB.Text= room.Name;
            RoomTypeCB.Text = room.RoomType.TypeName;
            AnnexCB.Text= room.Annex.Name;
            RoomCapacityTB.Text= room.RoomCapacity.ToString();
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            
            string room_name  = RoomNameTB.Text;
            string room_type = RoomTypeCB.Text;
            string annex_name = AnnexCB.Text;
            string room_capacity = RoomCapacityTB.Text;

            if(room_name == "") {
                room_name = to_edit_room_number;
            }

            string error_msg = "";
            if(!DataValidator.validateRoomData(to_edit_room_number, room_name, room_type, annex_name, room_capacity, out error_msg)) {
                MessageBox.Show(error_msg, "Error");
                return;
            }

            db.updateRoom(to_edit_room_number, room_name, room_type, annex_name, int.Parse(room_capacity));

            MessageBox.Show("Changes saved");
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e) {

            if (db.roomHasReservations(to_edit_room_number)) {
                var confirmResult =  MessageBox.Show("This room has existing reservations, delete them alogn with this room?", "Confirm Delete!!", MessageBoxButtons.YesNo);

                if(confirmResult == DialogResult.Yes) {
                    db.deleteAllReservationsOfRoom(to_edit_room_number);
                    db.deleteRoom(to_edit_room_number);
                    MessageBox.Show("Room deleted");

                }
                else {
                    return;
                }
            }
            else {
                db.deleteRoom(to_edit_room_number);
                MessageBox.Show("Room deleted");
            }
            
            this.Close();
        }

        
    }
}
