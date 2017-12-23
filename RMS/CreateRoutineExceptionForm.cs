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
    public partial class CreateRoutineExceptionForm : Form {
        MainDBFacade db = MainDBFacade.getMainDBFacade();

        public CreateRoutineExceptionForm() {
            InitializeComponent();
            loadFormData();
        }

        private void loadFormData() {
            WeekDayCB.DataSource = db.getWeekDayNames();
        }

        private void CreateButton_Click(object sender, EventArgs e) {
            bool success = true;

            try {
                db.createRoutineException(ExceptionDateDTP.Value, WeekDayCB.Text);
            }
            catch(DuplicateRecordException ex) {
                success = false;
                MessageBox.Show(ex.Message, "Error");
            }

            
            if(success){
                MessageBox.Show("Room exception created");

            }
        }
    }
}
