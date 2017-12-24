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

            RoomNumberTB.Text= room.Number;
            RoomNameTB.Text= room.Name;
            RoomTypeCB.Text = room.RoomType.TypeName;
            AnnexCB.Text= room.Annex.Name;
            RoomCapacityTB.Text= room.RoomCapacity.ToString();
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            
            string room_name  = RoomNameTB.Text;
            if(room_name == "") {
                room_name = to_edit_room_number;
            }

            db.updateRoom(to_edit_room_number, room_name, RoomTypeCB.Text, AnnexCB.Text, int.Parse(RoomCapacityTB.Text));

            MessageBox.Show("Changes saved");
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e) {
            db.deleteRoom(to_edit_room_number);
            MessageBox.Show("Room deleted");
            this.Close();
        }

        
    }
}
