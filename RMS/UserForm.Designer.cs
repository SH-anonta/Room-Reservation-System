namespace RMS {
    partial class UserForm {
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ReservationsDataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ShowPastReservationsCHB = new System.Windows.Forms.CheckBox();
            this.CreateReservation = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationsDataGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(645, 483);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(637, 457);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "My Reservations";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ReservationsDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.05987F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.94013F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(631, 451);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ReservationsDataGridView
            // 
            this.ReservationsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReservationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReservationsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReservationsDataGridView.Location = new System.Drawing.Point(3, 107);
            this.ReservationsDataGridView.Name = "ReservationsDataGridView";
            this.ReservationsDataGridView.Size = new System.Drawing.Size(625, 341);
            this.ReservationsDataGridView.TabIndex = 0;
            this.ReservationsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReservationsDataGridView_CellDoubleClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ShowPastReservationsCHB, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.CreateReservation, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(625, 98);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // ShowPastReservationsCHB
            // 
            this.ShowPastReservationsCHB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ShowPastReservationsCHB.AutoSize = true;
            this.ShowPastReservationsCHB.Location = new System.Drawing.Point(486, 16);
            this.ShowPastReservationsCHB.Name = "ShowPastReservationsCHB";
            this.ShowPastReservationsCHB.Size = new System.Drawing.Size(136, 17);
            this.ShowPastReservationsCHB.TabIndex = 0;
            this.ShowPastReservationsCHB.Text = "Show past reservations";
            this.ShowPastReservationsCHB.UseVisualStyleBackColor = true;
            this.ShowPastReservationsCHB.CheckedChanged += new System.EventHandler(this.ShowPastReservationsCHB_CheckedChanged);
            // 
            // CreateReservation
            // 
            this.CreateReservation.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CreateReservation.Location = new System.Drawing.Point(487, 62);
            this.CreateReservation.Name = "CreateReservation";
            this.CreateReservation.Size = new System.Drawing.Size(135, 23);
            this.CreateReservation.TabIndex = 1;
            this.CreateReservation.Text = "Make reservation";
            this.CreateReservation.UseVisualStyleBackColor = true;
            this.CreateReservation.Click += new System.EventHandler(this.CreateReservation_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 483);
            this.Controls.Add(this.tabControl1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReservationsDataGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView ReservationsDataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox ShowPastReservationsCHB;
        private System.Windows.Forms.Button CreateReservation;
    }
}