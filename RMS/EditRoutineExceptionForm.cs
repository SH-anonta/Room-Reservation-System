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
    public partial class EditRoutineExceptionForm : Form {
        MainDBFacade db = MainDBFacade.getMainDBFacade();
        RoutineException routine_exception; 
        string CUSTOM_DATE_FORMAT = "dd-MMM-yy";

        public EditRoutineExceptionForm(RoutineException routine_exception) {
            this.routine_exception = routine_exception;
            InitializeComponent();
            loadFormData();
        }


        private void loadFormData() {
            ShowDateTB.Text= routine_exception.Date.ToString(CUSTOM_DATE_FORMAT);
            WeekDayCB.DataSource = db.getWeekDayNames();
            WeekDayCB.Text = routine_exception.WeekDay.Name;
        }


        private void DeleteButton_Click(object sender, EventArgs e) {
            db.DeleteRoutineException(routine_exception.Id);
            MessageBox.Show("Routine exception deleted");
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            db.UpdateRoutineException(routine_exception, WeekDayCB.Text);
            MessageBox.Show("Changes saved");
            this.Close();
        }
    }
}
