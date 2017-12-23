using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace RMS {
    public partial class AdminPanel : Form {
        MainDBFacade dbFacade = MainDBFacade.getMainDBFacade();
        const string COMBOBOX_ALLOPTIOPNS_NAME= MainDBFacade.COMBOBOX_ALL_OPTIOPNS_NAME;

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
            reloadAllFormData();
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

        
        private void AnnexPanelButton_Click(object sender, EventArgs e) {
            MainTabContainer.SelectedIndex = 5;
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
            UpdateUserDataGridView();
        }

        private void AccountTypeCB_SelectedIndexChanged(object sender, EventArgs e) {
            // this even reilies the TextBox text changed event to update the Users Data grid view
            UpdateUserDataGridView();
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
            
            // Collect which usersnames need to be deleted
            foreach(DataGridViewRow  row in UsersDataGridView.SelectedRows) {
                usernames.Add(row.Cells[0].Value.ToString());
            }

            
            foreach (string uname in usernames) {
                dbFacade.DeleteAccount(uname);
            }

            UpdateUserDataGridView();
        }

        
        private void RoomNumberSearchTB_TextChanged(object sender, EventArgs e) {
            UpdateRoomDataGridView();
        }

        private void RoomTypeFIlterCB_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateRoomDataGridView();
        }

        private void AnnexFilterCB_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateRoomDataGridView();
        }

        // Data grid view updaters
        private void UpdateUserDataGridView() {
            string search_name = SearchByNameTextBox.Text;
            string account_type = AccountTypeCB.Text;

            var data = dbFacade.filterUsersByNameAndType(search_name, account_type);
            var show= data.Select(x => new { 
                                UserName = x.UserName,
                                Password= x.Password,
                                UserType= x.UserType.TypeName
                            }).ToList();

            UsersDataGridView.DataSource= show;
        }

        private void UpdateRoomDataGridView() {
            string roomNumber = RoomNumberSearchTB.Text;
            string annex = AnnexFilterCB.Text;
            string type = RoomTypeFIlterCB.Text;

            var data = dbFacade.filterRoomsByNumberTypeAnnex(roomNumber, type, annex);
            var show = data.Select(x => new {
                                RoomNumber = x.Number,
                                Name = x.Name,
                                Type = x.RoomType.TypeName,
                                Annex = x.Annex.Name,
                                Capacity = x.RoomCapacity,
                            }).ToList();
            
            RoomDataGridView.DataSource = show;
        }

        private void UpdateRoutineExceptionGridView() {

            List<RoutineException> data= null;

            if (RoutineExceptionsShowEntriesCHB.Checked) {
                data= dbFacade.getAllRoutineExceptions();
            }
            else {
                data= dbFacade.getFutureRoutineExceptions();
            }
            
            var show = data.Select(x => new {
                                Id = x.Id,
                                Date = x.Date,
                                Day = x.WeekDay.Name
                            }).ToList();
            
            RoutineExceptionsGridView.DataSource= show;
        }

        private void RoomDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }


        // Form component data loading methods...
        // CB -> combobox, TB-> TextBox, DGV-> DataGridview

        private void reloadAllFormData() {           
            loadRoomTypesCB();
            loadUserTypeCB();
            loadAnnxCB();

            // Make comboboxes readonly
            //AccountTypeCB.readone


            //IMPORTANT: These methods need to be invoked as they load data based on other component settings
            UpdateUserDataGridView();
            UpdateRoomDataGridView();
            UpdateRoutineExceptionGridView();
        }

        private void loadUserTypeCB() {
            var user_type_names = dbFacade.getUserTypeNames().ToList();
            CreateAccountTypeTB.DataSource = user_type_names;
            
            // the seearch filter combobox has an extra "all" types option
            user_type_names.Insert(0, COMBOBOX_ALLOPTIOPNS_NAME);
            AccountTypeCB.DataSource= user_type_names;
        }

        private void loadRoomTypesCB() {
            var type_names = dbFacade.getRoomTypeNames();
            RoomTypeCB.DataSource = type_names;

            type_names.Insert(0, COMBOBOX_ALLOPTIOPNS_NAME);
            RoomTypeFIlterCB.DataSource = type_names;
        }

        private void loadAnnxCB() {
            var annex_names = dbFacade.getAnnexNames();
            AnnexCB.DataSource = annex_names;

            annex_names.Insert(0, COMBOBOX_ALLOPTIOPNS_NAME);
            AnnexFilterCB.DataSource= annex_names;
        }

        private void UsersDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            int clicked_row = e.RowIndex;
            string uname = (string) UsersDataGridView.Rows[clicked_row].Cells[0].Value;

            User user = dbFacade.getUser(uname);
            AccountEditForm profile = new AccountEditForm(user);
            profile.Show();

        }

        private void CreateRoomButton_Click(object sender, EventArgs e) {
            string room_number = RoomNumberTB.Text;

            bool operation_successfull= true;

            // if a range of numbers in given
            if (room_number.Contains(",")){
                string l = room_number.Split(',')[0];
                string r = room_number.Split(',')[1];

                try {
                    dbFacade.createRooms(l, r, RoomTypeCB.Text, AnnexCB.Text, int.Parse(RoomCapacityTB.Text));
                }
                catch(DuplicateRecordException exc) {
                    MessageBox.Show(String.Format("{0}", exc.Message), "Error");
                    operation_successfull= false;
                }
            }
            else {
                string room_name  = RoomNameTB.Text;
                if(room_name == "") {
                    room_name = room_number;
                }

                try {
                    dbFacade.createRoom(room_number, room_name, RoomTypeCB.Text, AnnexCB.Text, int.Parse(RoomCapacityTB.Text));
                }
                catch(DuplicateRecordException exc) {
                    MessageBox.Show(String.Format("{0}", exc.Message), "Error");
                    operation_successfull= false;
                }
                
            }


            if (operation_successfull) {
                UpdateRoomDataGridView();
                MessageBox.Show("Room Created");
            }
            
        }

        private void CreateRoutineException_Click(object sender, EventArgs e) {
            
            CreateRoutineExceptionForm creator = new CreateRoutineExceptionForm();
            creator.Show();
        }

        private void RoutineExceptionsShowEntriesCHB_CheckedChanged(object sender, EventArgs e) {
            UpdateRoutineExceptionGridView();
        }

        
        private void RoutineExceptionsGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            int row_index= e.RowIndex;

            int id = (int) RoutineExceptionsGridView.Rows[row_index].Cells[0].Value;

            RoutineException exception = dbFacade.getRoutineException(id);
            var editor = new EditRoutineExceptionForm(exception);
            editor.Show();
        }
    }
}
