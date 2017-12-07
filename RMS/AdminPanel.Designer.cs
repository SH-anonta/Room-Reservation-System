namespace RMS {
    partial class AdminPanel {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AccountsPanelButton = new System.Windows.Forms.Button();
            this.RoomsPanelButton = new System.Windows.Forms.Button();
            this.ReservationsPanelButton = new System.Windows.Forms.Button();
            this.FlagsPanelButton = new System.Windows.Forms.Button();
            this.SemesterDaysPanelButton = new System.Windows.Forms.Button();
            this.MainTabContainer = new System.Windows.Forms.TabControl();
            this.AccountsPanelTabPage = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.AccountsUsersTabPage = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MaintenanceStaffTabPage = new System.Windows.Forms.TabPage();
            this.AccountsAdministratorTabPage = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.MainTabContainer.SuspendLayout();
            this.AccountsPanelTabPage.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.AccountsUsersTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.MainTabContainer);
            this.splitContainer1.Size = new System.Drawing.Size(804, 531);
            this.splitContainer1.SplitterDistance = 110;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.AccountsPanelButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RoomsPanelButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ReservationsPanelButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.FlagsPanelButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.SemesterDaysPanelButton, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.68421F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(108, 529);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // AccountsPanelButton
            // 
            this.AccountsPanelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccountsPanelButton.Location = new System.Drawing.Point(0, 0);
            this.AccountsPanelButton.Margin = new System.Windows.Forms.Padding(0);
            this.AccountsPanelButton.Name = "AccountsPanelButton";
            this.AccountsPanelButton.Size = new System.Drawing.Size(108, 27);
            this.AccountsPanelButton.TabIndex = 0;
            this.AccountsPanelButton.Text = "Accounts";
            this.AccountsPanelButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AccountsPanelButton.UseVisualStyleBackColor = true;
            this.AccountsPanelButton.Click += new System.EventHandler(this.AccountsPanelButton_Click);
            // 
            // RoomsPanelButton
            // 
            this.RoomsPanelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomsPanelButton.Location = new System.Drawing.Point(0, 27);
            this.RoomsPanelButton.Margin = new System.Windows.Forms.Padding(0);
            this.RoomsPanelButton.Name = "RoomsPanelButton";
            this.RoomsPanelButton.Size = new System.Drawing.Size(108, 27);
            this.RoomsPanelButton.TabIndex = 1;
            this.RoomsPanelButton.Text = "Rooms";
            this.RoomsPanelButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RoomsPanelButton.UseVisualStyleBackColor = true;
            this.RoomsPanelButton.Click += new System.EventHandler(this.RoomsPanelButton_Click);
            // 
            // ReservationsPanelButton
            // 
            this.ReservationsPanelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReservationsPanelButton.Location = new System.Drawing.Point(0, 54);
            this.ReservationsPanelButton.Margin = new System.Windows.Forms.Padding(0);
            this.ReservationsPanelButton.Name = "ReservationsPanelButton";
            this.ReservationsPanelButton.Size = new System.Drawing.Size(108, 27);
            this.ReservationsPanelButton.TabIndex = 2;
            this.ReservationsPanelButton.Text = "Reservations";
            this.ReservationsPanelButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReservationsPanelButton.UseVisualStyleBackColor = true;
            this.ReservationsPanelButton.Click += new System.EventHandler(this.ReservationsPanelButton_Click);
            // 
            // FlagsPanelButton
            // 
            this.FlagsPanelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlagsPanelButton.Location = new System.Drawing.Point(0, 81);
            this.FlagsPanelButton.Margin = new System.Windows.Forms.Padding(0);
            this.FlagsPanelButton.Name = "FlagsPanelButton";
            this.FlagsPanelButton.Size = new System.Drawing.Size(108, 27);
            this.FlagsPanelButton.TabIndex = 3;
            this.FlagsPanelButton.Text = "Flags";
            this.FlagsPanelButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FlagsPanelButton.UseVisualStyleBackColor = true;
            this.FlagsPanelButton.Click += new System.EventHandler(this.FlagsPanelButton_Click);
            // 
            // SemesterDaysPanelButton
            // 
            this.SemesterDaysPanelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SemesterDaysPanelButton.Location = new System.Drawing.Point(0, 108);
            this.SemesterDaysPanelButton.Margin = new System.Windows.Forms.Padding(0);
            this.SemesterDaysPanelButton.Name = "SemesterDaysPanelButton";
            this.SemesterDaysPanelButton.Size = new System.Drawing.Size(108, 27);
            this.SemesterDaysPanelButton.TabIndex = 4;
            this.SemesterDaysPanelButton.Text = "Semester Days";
            this.SemesterDaysPanelButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SemesterDaysPanelButton.UseVisualStyleBackColor = true;
            this.SemesterDaysPanelButton.Click += new System.EventHandler(this.SemesterDaysPanelButton_Click);
            // 
            // MainTabContainer
            // 
            this.MainTabContainer.Controls.Add(this.AccountsPanelTabPage);
            this.MainTabContainer.Controls.Add(this.tabPage2);
            this.MainTabContainer.Controls.Add(this.tabPage3);
            this.MainTabContainer.Controls.Add(this.tabPage4);
            this.MainTabContainer.Controls.Add(this.tabPage5);
            this.MainTabContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabContainer.ItemSize = new System.Drawing.Size(50, 20);
            this.MainTabContainer.Location = new System.Drawing.Point(0, 0);
            this.MainTabContainer.Margin = new System.Windows.Forms.Padding(0);
            this.MainTabContainer.Name = "MainTabContainer";
            this.MainTabContainer.Padding = new System.Drawing.Point(0, 0);
            this.MainTabContainer.SelectedIndex = 0;
            this.MainTabContainer.Size = new System.Drawing.Size(688, 529);
            this.MainTabContainer.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MainTabContainer.TabIndex = 0;
            // 
            // AccountsPanelTabPage
            // 
            this.AccountsPanelTabPage.BackColor = System.Drawing.Color.Transparent;
            this.AccountsPanelTabPage.Controls.Add(this.AccountsUsersTabPage);
            this.AccountsPanelTabPage.Location = new System.Drawing.Point(4, 24);
            this.AccountsPanelTabPage.Name = "AccountsPanelTabPage";
            this.AccountsPanelTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AccountsPanelTabPage.Size = new System.Drawing.Size(680, 501);
            this.AccountsPanelTabPage.TabIndex = 0;
            this.AccountsPanelTabPage.Text = "Accounts panel";
            this.AccountsPanelTabPage.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(680, 501);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(680, 501);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Rooms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Reservations";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(680, 501);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Flags";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(680, 501);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Semester days";
            // 
            // AccountsUsersTabPage
            // 
            this.AccountsUsersTabPage.Controls.Add(this.tabPage1);
            this.AccountsUsersTabPage.Controls.Add(this.MaintenanceStaffTabPage);
            this.AccountsUsersTabPage.Controls.Add(this.AccountsAdministratorTabPage);
            this.AccountsUsersTabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccountsUsersTabPage.Location = new System.Drawing.Point(3, 3);
            this.AccountsUsersTabPage.Name = "AccountsUsersTabPage";
            this.AccountsUsersTabPage.SelectedIndex = 0;
            this.AccountsUsersTabPage.Size = new System.Drawing.Size(674, 495);
            this.AccountsUsersTabPage.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(666, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Users";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MaintenanceStaffTabPage
            // 
            this.MaintenanceStaffTabPage.Location = new System.Drawing.Point(4, 22);
            this.MaintenanceStaffTabPage.Name = "MaintenanceStaffTabPage";
            this.MaintenanceStaffTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MaintenanceStaffTabPage.Size = new System.Drawing.Size(666, 469);
            this.MaintenanceStaffTabPage.TabIndex = 1;
            this.MaintenanceStaffTabPage.Text = "Maintenance staffs";
            this.MaintenanceStaffTabPage.UseVisualStyleBackColor = true;
            // 
            // AccountsAdministratorTabPage
            // 
            this.AccountsAdministratorTabPage.Location = new System.Drawing.Point(4, 22);
            this.AccountsAdministratorTabPage.Name = "AccountsAdministratorTabPage";
            this.AccountsAdministratorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AccountsAdministratorTabPage.Size = new System.Drawing.Size(666, 469);
            this.AccountsAdministratorTabPage.TabIndex = 2;
            this.AccountsAdministratorTabPage.Text = "Administrators";
            this.AccountsAdministratorTabPage.UseVisualStyleBackColor = true;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 531);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.MainTabContainer.ResumeLayout(false);
            this.AccountsPanelTabPage.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.AccountsUsersTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button AccountsPanelButton;
        private System.Windows.Forms.Button RoomsPanelButton;
        private System.Windows.Forms.Button ReservationsPanelButton;
        private System.Windows.Forms.Button FlagsPanelButton;
        private System.Windows.Forms.Button SemesterDaysPanelButton;
        private System.Windows.Forms.TabControl MainTabContainer;
        private System.Windows.Forms.TabPage AccountsPanelTabPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl AccountsUsersTabPage;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage MaintenanceStaffTabPage;
        private System.Windows.Forms.TabPage AccountsAdministratorTabPage;
    }
}