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


        public EditRoutineExceptionForm(RoutineException routine_exception) {
            this.routine_exception = routine_exception;
            InitializeComponent();
            loadFormData();
        }


        private void loadFormData() {
            
        }

        private void CreateButton_Click(object sender, EventArgs e) {
            if (true) {
                MessageBox.Show("Routine exception created");
            }
            
        }

        private void DeleteButton_Click(object sender, EventArgs e) {

        }
    }
}
