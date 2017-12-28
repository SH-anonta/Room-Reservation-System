namespace RMS {
    partial class AvalableRoomsView {
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
            this.RoomsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RoomsDataGridView
            // 
            this.RoomsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.RoomsDataGridView.Name = "RoomsDataGridView";
            this.RoomsDataGridView.Size = new System.Drawing.Size(523, 514);
            this.RoomsDataGridView.TabIndex = 0;
            // 
            // AvalableRoomsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 514);
            this.Controls.Add(this.RoomsDataGridView);
            this.Name = "AvalableRoomsView";
            this.Text = "AvalableRoomsView";
            this.Load += new System.EventHandler(this.AvalableRoomsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoomsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView RoomsDataGridView;
    }
}