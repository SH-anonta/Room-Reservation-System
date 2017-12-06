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
        const string ERROR_MESSAGE_LOGIN_FAILD= "Login Failed: The requested account does not exist.";

        public LoginForm() {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e) {

        }

        private void LoginButton_Click(object sender, EventArgs e) {
            string uname = UserNameTextBox.Text;
            string password = PasswordTextBox.Text;

            showLoginFaildError();
        }

        // helper methods

        private void showLoginFaildError() {
            MessageBox.Show(ERROR_MESSAGE_LOGIN_FAILD);
        }
    }
}

