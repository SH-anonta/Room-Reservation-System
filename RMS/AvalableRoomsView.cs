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
    public partial class AvalableRoomsView : Form {
        public AvalableRoomsView(List<Room> data) {
            InitializeComponent();
            LoadData(data);
        }

        private void AvalableRoomsView_Load(object sender, EventArgs e) {

        }

        public void LoadData(List<Room> data) {
            var show = data.Select(x => new {
                                RoomNumber = x.Number,
                                Name = x.Name,
                                Type = x.RoomType.TypeName,
                                Annex = x.Annex.Name,
                                Capacity = x.RoomCapacity,
                            }).ToList();
            
            RoomsDataGridView.DataSource = show;
        }
    }
}
