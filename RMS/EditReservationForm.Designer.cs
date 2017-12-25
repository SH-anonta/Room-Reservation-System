namespace RMS {
    partial class EditReservationForm {
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DateTB = new System.Windows.Forms.TextBox();
            this.StartTimeTB = new System.Windows.Forms.TextBox();
            this.EndTimeTB = new System.Windows.Forms.TextBox();
            this.Roomlabel = new System.Windows.Forms.Label();
            this.RoomNumberTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CancleReservationButton = new System.Windows.Forms.Button();
            this.ReservationDescriptionTB = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 257F));
            this.tableLayoutPanel2.Controls.Add(this.Time, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.DateTB, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.StartTimeTB, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.EndTimeTB, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.Roomlabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.RoomNumberTB, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.CancleReservationButton, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.ReservationDescriptionTB, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(290, 276);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // Time
            // 
            this.Time.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(3, 13);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(30, 13);
            this.Time.TabIndex = 0;
            this.Time.Text = "Date";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Start Time";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "End Time";
            // 
            // DateTB
            // 
            this.DateTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DateTB.Location = new System.Drawing.Point(92, 10);
            this.DateTB.Name = "DateTB";
            this.DateTB.ReadOnly = true;
            this.DateTB.Size = new System.Drawing.Size(100, 20);
            this.DateTB.TabIndex = 15;
            // 
            // StartTimeTB
            // 
            this.StartTimeTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StartTimeTB.Location = new System.Drawing.Point(92, 50);
            this.StartTimeTB.Name = "StartTimeTB";
            this.StartTimeTB.ReadOnly = true;
            this.StartTimeTB.Size = new System.Drawing.Size(100, 20);
            this.StartTimeTB.TabIndex = 16;
            // 
            // EndTimeTB
            // 
            this.EndTimeTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EndTimeTB.Location = new System.Drawing.Point(92, 90);
            this.EndTimeTB.Name = "EndTimeTB";
            this.EndTimeTB.ReadOnly = true;
            this.EndTimeTB.Size = new System.Drawing.Size(100, 20);
            this.EndTimeTB.TabIndex = 17;
            // 
            // Roomlabel
            // 
            this.Roomlabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Roomlabel.AutoSize = true;
            this.Roomlabel.Location = new System.Drawing.Point(3, 133);
            this.Roomlabel.Name = "Roomlabel";
            this.Roomlabel.Size = new System.Drawing.Size(73, 13);
            this.Roomlabel.TabIndex = 1;
            this.Roomlabel.Text = "Room number";
            // 
            // RoomNumberTB
            // 
            this.RoomNumberTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RoomNumberTB.Location = new System.Drawing.Point(92, 130);
            this.RoomNumberTB.Name = "RoomNumberTB";
            this.RoomNumberTB.ReadOnly = true;
            this.RoomNumberTB.Size = new System.Drawing.Size(100, 20);
            this.RoomNumberTB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Description";
            // 
            // CancleReservationButton
            // 
            this.CancleReservationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancleReservationButton.Location = new System.Drawing.Point(166, 236);
            this.CancleReservationButton.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.CancleReservationButton.Name = "CancleReservationButton";
            this.CancleReservationButton.Size = new System.Drawing.Size(105, 29);
            this.CancleReservationButton.TabIndex = 3;
            this.CancleReservationButton.Text = "Cancle reservation";
            this.CancleReservationButton.UseVisualStyleBackColor = true;
            this.CancleReservationButton.Click += new System.EventHandler(this.CancleReservationButton_Click);
            // 
            // ReservationDescriptionTB
            // 
            this.ReservationDescriptionTB.Location = new System.Drawing.Point(92, 163);
            this.ReservationDescriptionTB.Multiline = true;
            this.ReservationDescriptionTB.Name = "ReservationDescriptionTB";
            this.ReservationDescriptionTB.ReadOnly = true;
            this.ReservationDescriptionTB.Size = new System.Drawing.Size(179, 55);
            this.ReservationDescriptionTB.TabIndex = 18;
            // 
            // EditReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 276);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "EditReservationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditReservationForm";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RoomNumberTB;
        private System.Windows.Forms.Label Roomlabel;
        private System.Windows.Forms.Button CancleReservationButton;
        private System.Windows.Forms.TextBox DateTB;
        private System.Windows.Forms.TextBox StartTimeTB;
        private System.Windows.Forms.TextBox EndTimeTB;
        private System.Windows.Forms.TextBox ReservationDescriptionTB;
    }
}