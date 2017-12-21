using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace RMS {
    public partial class AdminPanel : Form {
        const string ALL_USER_TYPES_COMBOBOX_ITEM= "All types";
        DBDataContext db = new DBDataContext();
        MainDBFacade dbFacade = new MainDBFacade();

        public AdminPanel() {
            InitializeComponent();
            hideTabHeaders();
        }

        
        //The MainTabContainer Tab control is used as a stacked container, that contains many panels and shows them one at a time
        //This method is used to hide the MainTabContainer headers, so the tabs aren't visible
        // this is done thorugh setting some properties on MainTabContainer
        // Config: Set ItemSize 0 for Width and 1 for Height,  Set SizeMode to Fixed
        // the above size property are set at run time through this method so it's easeir to work with
        private void hideTabHeaders() {
            MainTabContainer.ItemSize = new System.Drawing.Size(0,1);
        }

        private void AdminPanel_Load(object sender, EventArgs e) {
            UsersDataGridView.DataSource = db.Users;
            RoomDataGridView.DataSource = db.Rooms;
            
            // Load the Account type names to the comboboxes
            var user_type_names = dbFacade.getUserTypeNames().ToList();
            
            CreateAccountTypeTB.DataSource = user_type_names;

            user_type_names.Insert(0, ALL_USER_TYPES_COMBOBOX_ITEM);
            AccountTypeCB.DataSource= user_type_names;

            // Make comboboxes readonly
            //AccountTypeCB.readone
        }


        // sidebar navigation button event listeners
        //The bellow methods are event listeners that change the tab according to pushed button
        private void AccountsPanelButton_Click(object sender, EventArgs e) {
            MainTabContainer.SelectedIndex = 0;
        }

        private void RoomsPanelButton_Click(object sender, EventArgs e) {
            MainTabContainer.SelectedIndex = 1;
        }

        private void ReservationsPanelButton_Click(object sender, EventArgs e) {
            MainTabContainer.SelectedIndex = 2;
        }

        private void FlagsPanelButton_Click(object sender, EventArgs e) {
            MainTabContainer.SelectedIndex = 3;
        }

        private void SemesterDaysPanelButton_Click(object sender, EventArgs e) {
            MainTabContainer.SelectedIndex = 4;
        }
        
        private void button1_Click(object sender, EventArgs e) {

        }

        private void UsersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        

        // END of sidebar navigation button event listeners

        private void tabPage1_Click(object sender, EventArgs e) {
            
        }

        private void mainDBDataSetBindingSource_CurrentChanged(object sender, EventArgs e) {

        }

        private void UsersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        //IMPORTANT: This event is used to update the UserDatagridView, other methods send event with arguments set to null
        private void SearchByNameTextBox_TextChanged(object sender, EventArgs e) {
            string search_name = SearchByNameTextBox.Text;
            string account_type = AccountTypeCB.Text;

            
            var data = dbFacade.filterUsersByNameAndType(search_name, account_type);

            var show= data.Select(x => new { UserName = x.UserName, Password= x.Password, UserType= x.UserType.TypeName}).ToList();

            UsersDataGridView.DataSource= show;
        }

        private void AccountTypeCB_SelectedIndexChanged(object sender, EventArgs e) {
            // this even reilies the TextBox text changed event to update the Users Data grid view
            SearchByNameTextBox_TextChanged(null, null);
        }

        private void CreateAccountButton_Click(object sender, EventArgs e) {
            string uname = UserNameTB.Text;
            string pass = PasswordTB.Text;
            string user_type_name = CreateAccountTypeTB.Text;

            if(dbFacade.UserNameExists(uname))
                MessageBox.Show("This username is not avalable");
            else {
                dbFacade.createAccount(uname, pass, dbFacade.UserTypeNameToID(user_type_name));
                MessageBox.Show("Account Created");
            }

        }

        private void DeleteSelectedAccount_Click(object sender, EventArgs e) {
            var usernames = new HashSet<string>();
            
            foreach(DataGridViewRow  row in UsersDataGridView.SelectedRows) {
                usernames.Add(row.Cells[0].Value.ToString());
            }

            
            foreach (string uname in usernames) {
                dbFacade.DeleteAccount(uname);
                
            }

            SearchByNameTextBox_TextChanged(null, null);
        }
    }
}
