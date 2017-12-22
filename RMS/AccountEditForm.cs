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
    public partial class AccountEditForm : Form {
        MainDBFacade db = new MainDBFacade();
        private User user_acocunt;

        public AccountEditForm(User user) {
            InitializeComponent();
            user_acocunt = user;
            loadFormData();
        }

        private void SaveButton_Click(object sender, EventArgs e) {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e) {

        }

        private void AccountEditForm_Load(object sender, EventArgs e) {

        }

        private void loadFormData() {
            UserNameTB.Text = user_acocunt.UserName;

            UserAccountType.DataSource = db.getUserTypeNames();
            UserAccountType.Text= user_acocunt.UserType.TypeName;
        }
    }
}
