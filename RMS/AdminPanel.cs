using System;
using System.Windows.Forms;

namespace RMS {
    public partial class AdminPanel : Form {

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

        // END of sidebar navigation button event listeners
    }
}
