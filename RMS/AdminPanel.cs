using System;
using System.Windows.Forms;
using System.Linq;

namespace RMS {
    public partial class AdminPanel : Form {
        const string ALL_USER_TYPES_COMBOBOX_ITEM= "All types";
        DBDataContext db = new DBDataContext();
        MainDBFacade dBFacade = new MainDBFacade();

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
            
            var user_type_names = dBFacade.getUserTypeNames().ToList();
            user_type_names.Insert(0, ALL_USER_TYPES_COMBOBOX_ITEM);
            AccountTypeCB.DataSource= user_type_names;
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

        private void groupBox1_Enter(object sender, EventArgs e) {

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

        private void SearchByNameTextBox_TextChanged(object sender, EventArgs e) {
            string text = SearchByNameTextBox.Text;

            if(text == "") {
                UsersDataGridView.DataSource = db.Users;
            }
            else {
                UsersDataGridView.DataSource = from x in db.Users
                                               where x.UserName.Contains(text)
                                               select x;
            }
        }

        private void button1_Click_1(object sender, EventArgs e) {

        }

        private void AccountTypeCB_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
