namespace GPBooking
{
    partial class GPForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GPTabControl = new TabControl();
            AuthenticationTab = new TabPage();
            NewBookingTab = new TabPage();
            ViewBookingTab = new TabPage();
            ViewDoctorTab = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            UsernameLabel = new Label();
            PasswordLabel = new Label();
            UsernameTextbox = new TextBox();
            PasswordTextBox = new TextBox();
            LoginButton = new Button();
            LogoutButton = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            PatientNameLabel = new Label();
            AttendingDoctorLabel = new Label();
            AppointmentDateLabel = new Label();
            AppointmentTimeLabel = new Label();
            SaveButton = new Button();
            CancelButton = new Button();
            DoctorCombobox = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            PatientNameTextbox = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            PatientBookingNameLabel = new Label();
            AssignedDoctorBookingLabel = new Label();
            BookingDateTimeLabel = new Label();
            PatientDataGridview = new DataGridView();
            DoctorDataGridView = new DataGridView();
            DateTimeDataGridView = new DataGridView();
            tableLayoutPanel4 = new TableLayoutPanel();
            DoctorNameViewLabel = new Label();
            DoctorSpecialityViewLabel = new Label();
            DoctorNameCombobox = new ComboBox();
            SpecialtyGridview = new DataGridView();
            GPTabControl.SuspendLayout();
            AuthenticationTab.SuspendLayout();
            NewBookingTab.SuspendLayout();
            ViewBookingTab.SuspendLayout();
            ViewDoctorTab.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PatientDataGridview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DoctorDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DateTimeDataGridView).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SpecialtyGridview).BeginInit();
            SuspendLayout();
            // 
            // GPTabControl
            // 
            GPTabControl.Controls.Add(AuthenticationTab);
            GPTabControl.Controls.Add(NewBookingTab);
            GPTabControl.Controls.Add(ViewBookingTab);
            GPTabControl.Controls.Add(ViewDoctorTab);
            GPTabControl.Location = new Point(1, 1);
            GPTabControl.Name = "GPTabControl";
            GPTabControl.SelectedIndex = 0;
            GPTabControl.Size = new Size(798, 452);
            GPTabControl.TabIndex = 0;
            // 
            // AuthenticationTab
            // 
            AuthenticationTab.Controls.Add(tableLayoutPanel1);
            AuthenticationTab.Location = new Point(4, 34);
            AuthenticationTab.Name = "AuthenticationTab";
            AuthenticationTab.Padding = new Padding(3);
            AuthenticationTab.Size = new Size(790, 414);
            AuthenticationTab.TabIndex = 0;
            AuthenticationTab.Text = "Authentication";
            AuthenticationTab.UseVisualStyleBackColor = true;
            // 
            // NewBookingTab
            // 
            NewBookingTab.Controls.Add(tableLayoutPanel2);
            NewBookingTab.Location = new Point(4, 34);
            NewBookingTab.Name = "NewBookingTab";
            NewBookingTab.Padding = new Padding(3);
            NewBookingTab.Size = new Size(790, 414);
            NewBookingTab.TabIndex = 1;
            NewBookingTab.Text = "New Booking";
            NewBookingTab.UseVisualStyleBackColor = true;
            // 
            // ViewBookingTab
            // 
            ViewBookingTab.Controls.Add(tableLayoutPanel3);
            ViewBookingTab.Location = new Point(4, 34);
            ViewBookingTab.Name = "ViewBookingTab";
            ViewBookingTab.Padding = new Padding(3);
            ViewBookingTab.Size = new Size(790, 414);
            ViewBookingTab.TabIndex = 2;
            ViewBookingTab.Text = "View Booking";
            ViewBookingTab.UseVisualStyleBackColor = true;
            // 
            // ViewDoctorTab
            // 
            ViewDoctorTab.Controls.Add(tableLayoutPanel4);
            ViewDoctorTab.Location = new Point(4, 34);
            ViewDoctorTab.Name = "ViewDoctorTab";
            ViewDoctorTab.Padding = new Padding(3);
            ViewDoctorTab.Size = new Size(790, 414);
            ViewDoctorTab.TabIndex = 3;
            ViewDoctorTab.Text = "View Doctor";
            ViewDoctorTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(UsernameLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(PasswordTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(LoginButton, 0, 2);
            tableLayoutPanel1.Controls.Add(LogoutButton, 1, 2);
            tableLayoutPanel1.Controls.Add(UsernameTextbox, 1, 0);
            tableLayoutPanel1.Controls.Add(PasswordLabel, 0, 1);
            tableLayoutPanel1.Location = new Point(76, 46);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 81F));
            tableLayoutPanel1.Size = new Size(465, 259);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.BorderStyle = BorderStyle.FixedSingle;
            UsernameLabel.Dock = DockStyle.Fill;
            UsernameLabel.Location = new Point(3, 0);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(226, 89);
            UsernameLabel.TabIndex = 0;
            UsernameLabel.Text = "Username";
            UsernameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.BorderStyle = BorderStyle.FixedSingle;
            PasswordLabel.Dock = DockStyle.Fill;
            PasswordLabel.Location = new Point(3, 89);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(226, 89);
            PasswordLabel.TabIndex = 1;
            PasswordLabel.Text = "Password";
            PasswordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UsernameTextbox
            // 
            UsernameTextbox.Dock = DockStyle.Fill;
            UsernameTextbox.Location = new Point(235, 3);
            UsernameTextbox.Name = "UsernameTextbox";
            UsernameTextbox.Size = new Size(227, 31);
            UsernameTextbox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Dock = DockStyle.Fill;
            PasswordTextBox.Location = new Point(235, 92);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(227, 31);
            PasswordTextBox.TabIndex = 3;
            // 
            // LoginButton
            // 
            LoginButton.Dock = DockStyle.Fill;
            LoginButton.Location = new Point(3, 181);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(226, 75);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            // 
            // LogoutButton
            // 
            LogoutButton.Dock = DockStyle.Fill;
            LogoutButton.Location = new Point(235, 181);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(227, 75);
            LogoutButton.TabIndex = 5;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(PatientNameLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(AttendingDoctorLabel, 0, 1);
            tableLayoutPanel2.Controls.Add(AppointmentDateLabel, 0, 2);
            tableLayoutPanel2.Controls.Add(AppointmentTimeLabel, 0, 3);
            tableLayoutPanel2.Controls.Add(SaveButton, 0, 4);
            tableLayoutPanel2.Controls.Add(CancelButton, 1, 4);
            tableLayoutPanel2.Controls.Add(DoctorCombobox, 1, 1);
            tableLayoutPanel2.Controls.Add(dateTimePicker1, 1, 2);
            tableLayoutPanel2.Controls.Add(dateTimePicker2, 1, 3);
            tableLayoutPanel2.Controls.Add(PatientNameTextbox, 1, 0);
            tableLayoutPanel2.Location = new Point(7, 7);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 77F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 74F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            tableLayoutPanel2.Size = new Size(536, 375);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // PatientNameLabel
            // 
            PatientNameLabel.AutoSize = true;
            PatientNameLabel.BorderStyle = BorderStyle.FixedSingle;
            PatientNameLabel.Dock = DockStyle.Fill;
            PatientNameLabel.Location = new Point(3, 0);
            PatientNameLabel.Name = "PatientNameLabel";
            PatientNameLabel.Size = new Size(262, 74);
            PatientNameLabel.TabIndex = 1;
            PatientNameLabel.Text = "Patient Name";
            PatientNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AttendingDoctorLabel
            // 
            AttendingDoctorLabel.AutoSize = true;
            AttendingDoctorLabel.BorderStyle = BorderStyle.FixedSingle;
            AttendingDoctorLabel.Dock = DockStyle.Fill;
            AttendingDoctorLabel.Location = new Point(3, 74);
            AttendingDoctorLabel.Name = "AttendingDoctorLabel";
            AttendingDoctorLabel.Size = new Size(262, 74);
            AttendingDoctorLabel.TabIndex = 2;
            AttendingDoctorLabel.Text = "Attending Doctor";
            AttendingDoctorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AppointmentDateLabel
            // 
            AppointmentDateLabel.AutoSize = true;
            AppointmentDateLabel.BorderStyle = BorderStyle.FixedSingle;
            AppointmentDateLabel.Dock = DockStyle.Fill;
            AppointmentDateLabel.Location = new Point(3, 148);
            AppointmentDateLabel.Name = "AppointmentDateLabel";
            AppointmentDateLabel.Size = new Size(262, 77);
            AppointmentDateLabel.TabIndex = 3;
            AppointmentDateLabel.Text = "Appointment Date";
            AppointmentDateLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AppointmentTimeLabel
            // 
            AppointmentTimeLabel.AutoSize = true;
            AppointmentTimeLabel.BorderStyle = BorderStyle.FixedSingle;
            AppointmentTimeLabel.Dock = DockStyle.Fill;
            AppointmentTimeLabel.Location = new Point(3, 225);
            AppointmentTimeLabel.Name = "AppointmentTimeLabel";
            AppointmentTimeLabel.Size = new Size(262, 74);
            AppointmentTimeLabel.TabIndex = 4;
            AppointmentTimeLabel.Text = "Appointment Time";
            AppointmentTimeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SaveButton
            // 
            SaveButton.Dock = DockStyle.Fill;
            SaveButton.Location = new Point(3, 302);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(262, 70);
            SaveButton.TabIndex = 5;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            CancelButton.Dock = DockStyle.Fill;
            CancelButton.Location = new Point(271, 302);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(262, 70);
            CancelButton.TabIndex = 6;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // DoctorCombobox
            // 
            DoctorCombobox.Dock = DockStyle.Fill;
            DoctorCombobox.FormattingEnabled = true;
            DoctorCombobox.Location = new Point(271, 77);
            DoctorCombobox.Name = "DoctorCombobox";
            DoctorCombobox.Size = new Size(262, 33);
            DoctorCombobox.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(271, 151);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(262, 31);
            dateTimePicker1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(271, 228);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(262, 31);
            dateTimePicker2.TabIndex = 9;
            dateTimePicker2.Value = new DateTime(2023, 12, 12, 18, 42, 0, 0);
            // 
            // PatientNameTextbox
            // 
            PatientNameTextbox.Dock = DockStyle.Fill;
            PatientNameTextbox.Location = new Point(271, 3);
            PatientNameTextbox.Name = "PatientNameTextbox";
            PatientNameTextbox.Size = new Size(262, 31);
            PatientNameTextbox.TabIndex = 10;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.875F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.125F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 213F));
            tableLayoutPanel3.Controls.Add(PatientBookingNameLabel, 0, 0);
            tableLayoutPanel3.Controls.Add(AssignedDoctorBookingLabel, 1, 0);
            tableLayoutPanel3.Controls.Add(BookingDateTimeLabel, 2, 0);
            tableLayoutPanel3.Controls.Add(PatientDataGridview, 0, 1);
            tableLayoutPanel3.Controls.Add(DoctorDataGridView, 1, 1);
            tableLayoutPanel3.Controls.Add(DateTimeDataGridView, 2, 1);
            tableLayoutPanel3.Location = new Point(7, 6);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 18.87324F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 81.12676F));
            tableLayoutPanel3.Size = new Size(671, 291);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // PatientBookingNameLabel
            // 
            PatientBookingNameLabel.AutoSize = true;
            PatientBookingNameLabel.BorderStyle = BorderStyle.FixedSingle;
            PatientBookingNameLabel.Dock = DockStyle.Fill;
            PatientBookingNameLabel.Location = new Point(3, 0);
            PatientBookingNameLabel.Name = "PatientBookingNameLabel";
            PatientBookingNameLabel.Size = new Size(208, 54);
            PatientBookingNameLabel.TabIndex = 0;
            PatientBookingNameLabel.Text = "Patient Name";
            PatientBookingNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AssignedDoctorBookingLabel
            // 
            AssignedDoctorBookingLabel.AutoSize = true;
            AssignedDoctorBookingLabel.BorderStyle = BorderStyle.FixedSingle;
            AssignedDoctorBookingLabel.Dock = DockStyle.Fill;
            AssignedDoctorBookingLabel.Location = new Point(217, 0);
            AssignedDoctorBookingLabel.Name = "AssignedDoctorBookingLabel";
            AssignedDoctorBookingLabel.Size = new Size(237, 54);
            AssignedDoctorBookingLabel.TabIndex = 1;
            AssignedDoctorBookingLabel.Text = "Assigned Doctor";
            AssignedDoctorBookingLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BookingDateTimeLabel
            // 
            BookingDateTimeLabel.AutoSize = true;
            BookingDateTimeLabel.BorderStyle = BorderStyle.FixedSingle;
            BookingDateTimeLabel.Dock = DockStyle.Fill;
            BookingDateTimeLabel.Location = new Point(460, 0);
            BookingDateTimeLabel.Name = "BookingDateTimeLabel";
            BookingDateTimeLabel.Size = new Size(208, 54);
            BookingDateTimeLabel.TabIndex = 2;
            BookingDateTimeLabel.Text = "Date/Time";
            BookingDateTimeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PatientDataGridview
            // 
            PatientDataGridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PatientDataGridview.Location = new Point(3, 57);
            PatientDataGridview.Name = "PatientDataGridview";
            PatientDataGridview.RowHeadersWidth = 62;
            PatientDataGridview.Size = new Size(208, 225);
            PatientDataGridview.TabIndex = 3;
            // 
            // DoctorDataGridView
            // 
            DoctorDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DoctorDataGridView.Location = new Point(217, 57);
            DoctorDataGridView.Name = "DoctorDataGridView";
            DoctorDataGridView.RowHeadersWidth = 62;
            DoctorDataGridView.Size = new Size(237, 225);
            DoctorDataGridView.TabIndex = 4;
            // 
            // DateTimeDataGridView
            // 
            DateTimeDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DateTimeDataGridView.Location = new Point(460, 57);
            DateTimeDataGridView.Name = "DateTimeDataGridView";
            DateTimeDataGridView.RowHeadersWidth = 62;
            DateTimeDataGridView.Size = new Size(208, 225);
            DateTimeDataGridView.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(DoctorNameViewLabel, 0, 0);
            tableLayoutPanel4.Controls.Add(DoctorSpecialityViewLabel, 1, 0);
            tableLayoutPanel4.Controls.Add(DoctorNameCombobox, 0, 1);
            tableLayoutPanel4.Controls.Add(SpecialtyGridview, 1, 1);
            tableLayoutPanel4.Location = new Point(7, 6);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 19.8433418F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 80.1566544F));
            tableLayoutPanel4.Size = new Size(565, 299);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // DoctorNameViewLabel
            // 
            DoctorNameViewLabel.AutoSize = true;
            DoctorNameViewLabel.BorderStyle = BorderStyle.FixedSingle;
            DoctorNameViewLabel.Dock = DockStyle.Fill;
            DoctorNameViewLabel.Location = new Point(3, 0);
            DoctorNameViewLabel.Name = "DoctorNameViewLabel";
            DoctorNameViewLabel.Size = new Size(276, 59);
            DoctorNameViewLabel.TabIndex = 0;
            DoctorNameViewLabel.Text = "Doctor Name";
            DoctorNameViewLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DoctorSpecialityViewLabel
            // 
            DoctorSpecialityViewLabel.AutoSize = true;
            DoctorSpecialityViewLabel.BorderStyle = BorderStyle.FixedSingle;
            DoctorSpecialityViewLabel.Dock = DockStyle.Fill;
            DoctorSpecialityViewLabel.Location = new Point(285, 0);
            DoctorSpecialityViewLabel.Name = "DoctorSpecialityViewLabel";
            DoctorSpecialityViewLabel.Size = new Size(277, 59);
            DoctorSpecialityViewLabel.TabIndex = 1;
            DoctorSpecialityViewLabel.Text = "Specialty";
            DoctorSpecialityViewLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DoctorNameCombobox
            // 
            DoctorNameCombobox.Dock = DockStyle.Fill;
            DoctorNameCombobox.FormattingEnabled = true;
            DoctorNameCombobox.Location = new Point(3, 62);
            DoctorNameCombobox.Name = "DoctorNameCombobox";
            DoctorNameCombobox.Size = new Size(276, 33);
            DoctorNameCombobox.TabIndex = 2;
            // 
            // SpecialtyGridview
            // 
            SpecialtyGridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SpecialtyGridview.Location = new Point(285, 62);
            SpecialtyGridview.Name = "SpecialtyGridview";
            SpecialtyGridview.RowHeadersWidth = 62;
            SpecialtyGridview.Size = new Size(277, 225);
            SpecialtyGridview.TabIndex = 3;
            // 
            // GPForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GPTabControl);
            Name = "GPForm";
            Text = "GP BOOKING";
            Load += Form1_Load;
            GPTabControl.ResumeLayout(false);
            AuthenticationTab.ResumeLayout(false);
            NewBookingTab.ResumeLayout(false);
            ViewBookingTab.ResumeLayout(false);
            ViewDoctorTab.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PatientDataGridview).EndInit();
            ((System.ComponentModel.ISupportInitialize)DoctorDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)DateTimeDataGridView).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SpecialtyGridview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl GPTabControl;
        private TabPage AuthenticationTab;
        private TabPage NewBookingTab;
        private TabPage ViewBookingTab;
        private TabPage ViewDoctorTab;
        private TableLayoutPanel tableLayoutPanel1;
        private Label UsernameLabel;
        private Label PasswordLabel;
        private TextBox UsernameTextbox;
        private TextBox PasswordTextBox;
        private Button LoginButton;
        private Button LogoutButton;
        private TableLayoutPanel tableLayoutPanel2;
        private Label PatientNameLabel;
        private Label AttendingDoctorLabel;
        private Label AppointmentDateLabel;
        private Label AppointmentTimeLabel;
        private Button SaveButton;
        private Button CancelButton;
        private ComboBox DoctorCombobox;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private TextBox PatientNameTextbox;
        private TableLayoutPanel tableLayoutPanel3;
        private Label PatientBookingNameLabel;
        private Label AssignedDoctorBookingLabel;
        private Label BookingDateTimeLabel;
        private DataGridView PatientDataGridview;
        private DataGridView DoctorDataGridView;
        private DataGridView DateTimeDataGridView;
        private TableLayoutPanel tableLayoutPanel4;
        private Label DoctorNameViewLabel;
        private Label DoctorSpecialityViewLabel;
        private ComboBox DoctorNameCombobox;
        private DataGridView SpecialtyGridview;
    }
}
