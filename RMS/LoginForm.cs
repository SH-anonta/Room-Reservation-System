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
    public partial class LoginForm : Form {
        

        private const string ERROR_MESSAGE_LOGIN_FAILD= "Login Failed: The requested account does not exist.";
        private MainDBFacade db = MainDBFacade.getMainDBFacade();

        public LoginForm() {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e) {

        }

        private void LoginButton_Click(object sender, EventArgs e) {
            string uname = UserNameTextBox.Text;
            string password = PasswordTextBox.Text;

            if (!db.LoginIsValid(uname, password)) {
                showLoginFaildError();
                return;
            }
            
            if(db.userIsAdmin(uname)) {
                AdminPanel admin_window = new AdminPanel(uname);
                admin_window.Show();

                admin_window.FormClosed += (x, y) => this.Close();
                this.Hide();
            }
            else{
                UserForm user_window = new UserForm(uname);
                user_window.Show();

                user_window.FormClosed += (x, y) => this.Close();
                this.Hide();
            }
            
        }


        // helper methods
        private void showLoginFaildError() {
            MessageBox.Show(ERROR_MESSAGE_LOGIN_FAILD);
        }
    }
}

