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
        MainDBFacade db = MainDBFacade.getMainDBFacade();
        private User user_acocunt;

        public AccountEditForm(User user) {
            InitializeComponent();
            user_acocunt = user;
            loadFormData();
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            // The modified user entry is returned

            string new_uname = UserNameTB.Text;
            string account_type =  UserAccountTypeCB.Text;
            string new_password = PasswordTB.Text;


            string error_msg= "";
            if(!DataValidator.validateUserDataForEditor(new_uname, new_password,account_type,  out error_msg)) {
                MessageBox.Show(error_msg, "Error");
                return;
            }
            
            user_acocunt = db.updateUserAccount(user_acocunt.UserName, new_uname, account_type, new_password);
            

            MessageBox.Show("Changes Saved");
            this.Close();
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e) {

        }

        private void AccountEditForm_Load(object sender, EventArgs e) {

        }

        private void loadFormData() {
            UserNameTB.Text = user_acocunt.UserName;

            UserAccountTypeCB.DataSource = db.getUserTypeNames();
            UserAccountTypeCB.Text= user_acocunt.UserType.TypeName;
        }
    }
}
