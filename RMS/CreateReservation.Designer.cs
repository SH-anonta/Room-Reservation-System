namespace RMS {
    partial class CreateReservation {
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Time = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Roomlabel = new System.Windows.Forms.Label();
            this.RoomNumberTB = new System.Windows.Forms.TextBox();
            this.PicRandomRoomButton = new System.Windows.Forms.Button();
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.ReservationDescriptionRTB = new System.Windows.Forms.RichTextBox();
            this.MakeReservationButton = new System.Windows.Forms.Button();
            this.EndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.RoomTypeCB = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 286F));
            this.tableLayoutPanel2.Controls.Add(this.Time, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.DatePicker, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.StartTimePicker, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.EndTimePicker, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.MakeReservationButton, 2, 6);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.ReservationDescriptionRTB, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.RoomNumberTB, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.Roomlabel, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.RoomTypeCB, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.PicRandomRoomButton, 2, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(408, 415);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // Time
            // 
            this.Time.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(3, 18);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(30, 13);
            this.Time.TabIndex = 0;
            this.Time.Text = "Date";
            // 
            // DatePicker
            // 
            this.DatePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DatePicker.Location = new System.Drawing.Point(83, 15);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(153, 20);
            this.DatePicker.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Start Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 260);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Description";
            // 
            // Roomlabel
            // 
            this.Roomlabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Roomlabel.AutoSize = true;
            this.Roomlabel.Location = new System.Drawing.Point(3, 218);
            this.Roomlabel.Name = "Roomlabel";
            this.Roomlabel.Size = new System.Drawing.Size(73, 13);
            this.Roomlabel.TabIndex = 1;
            this.Roomlabel.Text = "Room number";
            // 
            // RoomNumberTB
            // 
            this.RoomNumberTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RoomNumberTB.Location = new System.Drawing.Point(83, 215);
            this.RoomNumberTB.Name = "RoomNumberTB";
            this.RoomNumberTB.Size = new System.Drawing.Size(153, 20);
            this.RoomNumberTB.TabIndex = 4;
            // 
            // PicRandomRoomButton
            // 
            this.PicRandomRoomButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PicRandomRoomButton.Location = new System.Drawing.Point(248, 211);
            this.PicRandomRoomButton.Name = "PicRandomRoomButton";
            this.PicRandomRoomButton.Size = new System.Drawing.Size(141, 27);
            this.PicRandomRoomButton.TabIndex = 2;
            this.PicRandomRoomButton.Text = "Pick For Me";
            this.PicRandomRoomButton.UseVisualStyleBackColor = true;
            this.PicRandomRoomButton.Click += new System.EventHandler(this.PicRandomRoomButton_Click);
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StartTimePicker.Location = new System.Drawing.Point(83, 65);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.ShowUpDown = true;
            this.StartTimePicker.Size = new System.Drawing.Size(153, 20);
            this.StartTimePicker.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "End Time";
            // 
            // ReservationDescriptionRTB
            // 
            this.ReservationDescriptionRTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel2.SetColumnSpan(this.ReservationDescriptionRTB, 2);
            this.ReservationDescriptionRTB.Location = new System.Drawing.Point(83, 253);
            this.ReservationDescriptionRTB.Margin = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this.ReservationDescriptionRTB.Name = "ReservationDescriptionRTB";
            this.ReservationDescriptionRTB.Size = new System.Drawing.Size(306, 85);
            this.ReservationDescriptionRTB.TabIndex = 6;
            this.ReservationDescriptionRTB.Text = "";
            // 
            // MakeReservationButton
            // 
            this.MakeReservationButton.Location = new System.Drawing.Point(248, 356);
            this.MakeReservationButton.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.MakeReservationButton.Name = "MakeReservationButton";
            this.MakeReservationButton.Size = new System.Drawing.Size(141, 30);
            this.MakeReservationButton.TabIndex = 3;
            this.MakeReservationButton.Text = "Make Reservation";
            this.MakeReservationButton.UseVisualStyleBackColor = true;
            this.MakeReservationButton.Click += new System.EventHandler(this.MakeReservationButton_Click);
            // 
            // EndTimePicker
            // 
            this.EndTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EndTimePicker.Location = new System.Drawing.Point(83, 115);
            this.EndTimePicker.Name = "EndTimePicker";
            this.EndTimePicker.ShowUpDown = true;
            this.EndTimePicker.Size = new System.Drawing.Size(153, 20);
            this.EndTimePicker.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Room type";
            // 
            // RoomTypeCB
            // 
            this.RoomTypeCB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RoomTypeCB.FormattingEnabled = true;
            this.RoomTypeCB.Location = new System.Drawing.Point(83, 164);
            this.RoomTypeCB.Name = "RoomTypeCB";
            this.RoomTypeCB.Size = new System.Drawing.Size(153, 21);
            this.RoomTypeCB.TabIndex = 14;
            // 
            // CreateReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 421);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "CreateReservation";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "CreateReservation";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Roomlabel;
        private System.Windows.Forms.TextBox RoomNumberTB;
        private System.Windows.Forms.Button PicRandomRoomButton;
        private System.Windows.Forms.DateTimePicker StartTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox ReservationDescriptionRTB;
        private System.Windows.Forms.Button MakeReservationButton;
        private System.Windows.Forms.DateTimePicker EndTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox RoomTypeCB;
    }
}