namespace TimeTracker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TimeTrackerTab = new System.Windows.Forms.TabPage();
            this.DescLbl = new System.Windows.Forms.Label();
            this.DescriptionTxtBox = new System.Windows.Forms.RichTextBox();
            this.PauseBtn = new System.Windows.Forms.Button();
            this.StopWatchBtn = new System.Windows.Forms.Button();
            this.StartWatchBtn = new System.Windows.Forms.Button();
            this.TodayDate = new System.Windows.Forms.Label();
            this.ProjectComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeLbl = new System.Windows.Forms.Label();
            this.ManualTrackerTab = new System.Windows.Forms.TabPage();
            this.SaveManualTrackerBtn = new System.Windows.Forms.Button();
            this.HoursNumeric = new System.Windows.Forms.NumericUpDown();
            this.MinutesNumeric = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ManualDescTxt = new System.Windows.Forms.RichTextBox();
            this.ManualDate = new Atf.UI.DateTimeSelector();
            this.label4 = new System.Windows.Forms.Label();
            this.ManualProjectCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TimeTrackingGrid = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platformDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persianDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hourCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minutesCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackingInvoiceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackingInvoiceDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeTrackingModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.InvoiceGrid = new System.Windows.Forms.DataGridView();
            this.SaveInvoiceBtn = new System.Windows.Forms.Button();
            this.InvoiceDescription = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.calculatedTrackingModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ToDatePicker = new Atf.UI.DateTimeSelector();
            this.label2 = new System.Windows.Forms.Label();
            this.FromDatePicker = new Atf.UI.DateTimeSelector();
            this.label8 = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.ProjectMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.invoiceModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceDetailGrid = new System.Windows.Forms.DataGridView();
            this.platformDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Platform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabControl.SuspendLayout();
            this.TimeTrackerTab.SuspendLayout();
            this.ManualTrackerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoursNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesNumeric)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeTrackingGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTrackingModelBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculatedTrackingModelBindingSource)).BeginInit();
            this.Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDetailGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TimeTrackerTab);
            this.TabControl.Controls.Add(this.ManualTrackerTab);
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Location = new System.Drawing.Point(6, 30);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1223, 564);
            this.TabControl.TabIndex = 0;
            // 
            // TimeTrackerTab
            // 
            this.TimeTrackerTab.Controls.Add(this.DescLbl);
            this.TimeTrackerTab.Controls.Add(this.DescriptionTxtBox);
            this.TimeTrackerTab.Controls.Add(this.PauseBtn);
            this.TimeTrackerTab.Controls.Add(this.StopWatchBtn);
            this.TimeTrackerTab.Controls.Add(this.StartWatchBtn);
            this.TimeTrackerTab.Controls.Add(this.TodayDate);
            this.TimeTrackerTab.Controls.Add(this.ProjectComboBox);
            this.TimeTrackerTab.Controls.Add(this.label1);
            this.TimeTrackerTab.Controls.Add(this.TimeLbl);
            this.TimeTrackerTab.Location = new System.Drawing.Point(4, 25);
            this.TimeTrackerTab.Name = "TimeTrackerTab";
            this.TimeTrackerTab.Padding = new System.Windows.Forms.Padding(3);
            this.TimeTrackerTab.Size = new System.Drawing.Size(1215, 535);
            this.TimeTrackerTab.TabIndex = 0;
            this.TimeTrackerTab.Text = "Auto Tracker";
            this.TimeTrackerTab.UseVisualStyleBackColor = true;
            // 
            // DescLbl
            // 
            this.DescLbl.AutoSize = true;
            this.DescLbl.Location = new System.Drawing.Point(6, 122);
            this.DescLbl.Name = "DescLbl";
            this.DescLbl.Size = new System.Drawing.Size(87, 17);
            this.DescLbl.TabIndex = 9;
            this.DescLbl.Text = "Description :";
            // 
            // DescriptionTxtBox
            // 
            this.DescriptionTxtBox.Location = new System.Drawing.Point(100, 122);
            this.DescriptionTxtBox.Name = "DescriptionTxtBox";
            this.DescriptionTxtBox.Size = new System.Drawing.Size(214, 100);
            this.DescriptionTxtBox.TabIndex = 8;
            this.DescriptionTxtBox.Text = "";
            // 
            // PauseBtn
            // 
            this.PauseBtn.Image = global::TimeTracker.Properties.Resources.pause_flat;
            this.PauseBtn.Location = new System.Drawing.Point(507, 140);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(54, 50);
            this.PauseBtn.TabIndex = 7;
            this.PauseBtn.UseVisualStyleBackColor = true;
            this.PauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // StopWatchBtn
            // 
            this.StopWatchBtn.Image = global::TimeTracker.Properties.Resources.stop_flat;
            this.StopWatchBtn.Location = new System.Drawing.Point(567, 140);
            this.StopWatchBtn.Name = "StopWatchBtn";
            this.StopWatchBtn.Size = new System.Drawing.Size(56, 50);
            this.StopWatchBtn.TabIndex = 6;
            this.StopWatchBtn.UseVisualStyleBackColor = true;
            this.StopWatchBtn.Click += new System.EventHandler(this.StopWatchBtn_Click);
            // 
            // StartWatchBtn
            // 
            this.StartWatchBtn.Image = global::TimeTracker.Properties.Resources.start_button_hi;
            this.StartWatchBtn.Location = new System.Drawing.Point(446, 140);
            this.StartWatchBtn.Name = "StartWatchBtn";
            this.StartWatchBtn.Size = new System.Drawing.Size(55, 50);
            this.StartWatchBtn.TabIndex = 5;
            this.StartWatchBtn.UseVisualStyleBackColor = true;
            this.StartWatchBtn.Click += new System.EventHandler(this.StartWatchBtn_Click);
            // 
            // TodayDate
            // 
            this.TodayDate.Location = new System.Drawing.Point(100, 79);
            this.TodayDate.Name = "TodayDate";
            this.TodayDate.Size = new System.Drawing.Size(214, 23);
            this.TodayDate.TabIndex = 4;
            // 
            // ProjectComboBox
            // 
            this.ProjectComboBox.FormattingEnabled = true;
            this.ProjectComboBox.Location = new System.Drawing.Point(100, 34);
            this.ProjectComboBox.Name = "ProjectComboBox";
            this.ProjectComboBox.Size = new System.Drawing.Size(214, 24);
            this.ProjectComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Project :";
            // 
            // TimeLbl
            // 
            this.TimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLbl.Location = new System.Drawing.Point(426, 34);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(298, 87);
            this.TimeLbl.TabIndex = 0;
            // 
            // ManualTrackerTab
            // 
            this.ManualTrackerTab.Controls.Add(this.SaveManualTrackerBtn);
            this.ManualTrackerTab.Controls.Add(this.HoursNumeric);
            this.ManualTrackerTab.Controls.Add(this.MinutesNumeric);
            this.ManualTrackerTab.Controls.Add(this.label7);
            this.ManualTrackerTab.Controls.Add(this.label6);
            this.ManualTrackerTab.Controls.Add(this.label5);
            this.ManualTrackerTab.Controls.Add(this.ManualDescTxt);
            this.ManualTrackerTab.Controls.Add(this.ManualDate);
            this.ManualTrackerTab.Controls.Add(this.label4);
            this.ManualTrackerTab.Controls.Add(this.ManualProjectCombo);
            this.ManualTrackerTab.Controls.Add(this.label3);
            this.ManualTrackerTab.Location = new System.Drawing.Point(4, 25);
            this.ManualTrackerTab.Name = "ManualTrackerTab";
            this.ManualTrackerTab.Padding = new System.Windows.Forms.Padding(3);
            this.ManualTrackerTab.Size = new System.Drawing.Size(1215, 535);
            this.ManualTrackerTab.TabIndex = 1;
            this.ManualTrackerTab.Text = "Manual Tracker";
            this.ManualTrackerTab.UseVisualStyleBackColor = true;
            // 
            // SaveManualTrackerBtn
            // 
            this.SaveManualTrackerBtn.Location = new System.Drawing.Point(513, 133);
            this.SaveManualTrackerBtn.Name = "SaveManualTrackerBtn";
            this.SaveManualTrackerBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveManualTrackerBtn.TabIndex = 17;
            this.SaveManualTrackerBtn.Text = "Save";
            this.SaveManualTrackerBtn.UseVisualStyleBackColor = true;
            this.SaveManualTrackerBtn.Click += new System.EventHandler(this.SaveManualTrackerBtn_Click);
            // 
            // HoursNumeric
            // 
            this.HoursNumeric.Location = new System.Drawing.Point(513, 43);
            this.HoursNumeric.Name = "HoursNumeric";
            this.HoursNumeric.Size = new System.Drawing.Size(120, 22);
            this.HoursNumeric.TabIndex = 16;
            // 
            // MinutesNumeric
            // 
            this.MinutesNumeric.Location = new System.Drawing.Point(513, 86);
            this.MinutesNumeric.Name = "MinutesNumeric";
            this.MinutesNumeric.Size = new System.Drawing.Size(120, 22);
            this.MinutesNumeric.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(402, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Minutes :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Hours :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Description :";
            // 
            // ManualDescTxt
            // 
            this.ManualDescTxt.Location = new System.Drawing.Point(103, 139);
            this.ManualDescTxt.Name = "ManualDescTxt";
            this.ManualDescTxt.Size = new System.Drawing.Size(214, 100);
            this.ManualDescTxt.TabIndex = 10;
            this.ManualDescTxt.Text = "";
            // 
            // ManualDate
            // 
            this.ManualDate.Location = new System.Drawing.Point(103, 80);
            this.ManualDate.Name = "ManualDate";
            this.ManualDate.Size = new System.Drawing.Size(160, 23);
            this.ManualDate.TabIndex = 6;
            this.ManualDate.UsePersianFormat = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date :";
            // 
            // ManualProjectCombo
            // 
            this.ManualProjectCombo.FormattingEnabled = true;
            this.ManualProjectCombo.Location = new System.Drawing.Point(103, 37);
            this.ManualProjectCombo.Name = "ManualProjectCombo";
            this.ManualProjectCombo.Size = new System.Drawing.Size(214, 24);
            this.ManualProjectCombo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Project :";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TimeTrackingGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1215, 535);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Worked Hours";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TimeTrackingGrid
            // 
            this.TimeTrackingGrid.AllowUserToAddRows = false;
            this.TimeTrackingGrid.AutoGenerateColumns = false;
            this.TimeTrackingGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TimeTrackingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TimeTrackingGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.projectDataGridViewTextBoxColumn,
            this.platformDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.persianDateDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.hourCountDataGridViewTextBoxColumn,
            this.minutesCountDataGridViewTextBoxColumn,
            this.trackingInvoiceIDDataGridViewTextBoxColumn,
            this.trackingInvoiceDescriptionDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn});
            this.TimeTrackingGrid.DataSource = this.timeTrackingModelBindingSource;
            this.TimeTrackingGrid.Location = new System.Drawing.Point(6, 6);
            this.TimeTrackingGrid.Name = "TimeTrackingGrid";
            this.TimeTrackingGrid.RowTemplate.Height = 24;
            this.TimeTrackingGrid.Size = new System.Drawing.Size(1203, 523);
            this.TimeTrackingGrid.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // projectDataGridViewTextBoxColumn
            // 
            this.projectDataGridViewTextBoxColumn.DataPropertyName = "Project";
            this.projectDataGridViewTextBoxColumn.HeaderText = "Project";
            this.projectDataGridViewTextBoxColumn.Name = "projectDataGridViewTextBoxColumn";
            // 
            // platformDataGridViewTextBoxColumn
            // 
            this.platformDataGridViewTextBoxColumn.DataPropertyName = "Platform";
            this.platformDataGridViewTextBoxColumn.HeaderText = "Platform";
            this.platformDataGridViewTextBoxColumn.Name = "platformDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // persianDateDataGridViewTextBoxColumn
            // 
            this.persianDateDataGridViewTextBoxColumn.DataPropertyName = "PersianDate";
            this.persianDateDataGridViewTextBoxColumn.HeaderText = "PersianDate";
            this.persianDateDataGridViewTextBoxColumn.Name = "persianDateDataGridViewTextBoxColumn";
            this.persianDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // hourCountDataGridViewTextBoxColumn
            // 
            this.hourCountDataGridViewTextBoxColumn.DataPropertyName = "HourCount";
            this.hourCountDataGridViewTextBoxColumn.HeaderText = "HourCount";
            this.hourCountDataGridViewTextBoxColumn.Name = "hourCountDataGridViewTextBoxColumn";
            // 
            // minutesCountDataGridViewTextBoxColumn
            // 
            this.minutesCountDataGridViewTextBoxColumn.DataPropertyName = "MinutesCount";
            this.minutesCountDataGridViewTextBoxColumn.HeaderText = "MinutesCount";
            this.minutesCountDataGridViewTextBoxColumn.Name = "minutesCountDataGridViewTextBoxColumn";
            // 
            // trackingInvoiceIDDataGridViewTextBoxColumn
            // 
            this.trackingInvoiceIDDataGridViewTextBoxColumn.DataPropertyName = "TrackingInvoiceID";
            this.trackingInvoiceIDDataGridViewTextBoxColumn.HeaderText = "TrackingInvoiceID";
            this.trackingInvoiceIDDataGridViewTextBoxColumn.Name = "trackingInvoiceIDDataGridViewTextBoxColumn";
            // 
            // trackingInvoiceDescriptionDataGridViewTextBoxColumn
            // 
            this.trackingInvoiceDescriptionDataGridViewTextBoxColumn.DataPropertyName = "TrackingInvoiceDescription";
            this.trackingInvoiceDescriptionDataGridViewTextBoxColumn.HeaderText = "TrackingInvoiceDescription";
            this.trackingInvoiceDescriptionDataGridViewTextBoxColumn.Name = "trackingInvoiceDescriptionDataGridViewTextBoxColumn";
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "User";
            this.userDataGridViewTextBoxColumn.HeaderText = "User";
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            // 
            // timeTrackingModelBindingSource
            // 
            this.timeTrackingModelBindingSource.DataSource = typeof(TimeTracker.Models.TimeTrackingModel);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.InvoiceDetailGrid);
            this.tabPage2.Controls.Add(this.InvoiceGrid);
            this.tabPage2.Controls.Add(this.SaveInvoiceBtn);
            this.tabPage2.Controls.Add(this.InvoiceDescription);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.ToDatePicker);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.FromDatePicker);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1215, 535);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Calculation";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // InvoiceGrid
            // 
            this.InvoiceGrid.AutoGenerateColumns = false;
            this.InvoiceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvoiceGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.descriptionDataGridViewTextBoxColumn1,
            this.periodStartDateDataGridViewTextBoxColumn,
            this.periodEndDateDataGridViewTextBoxColumn,
            this.isPaidDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn1});
            this.InvoiceGrid.DataSource = this.invoiceModelBindingSource;
            this.InvoiceGrid.Location = new System.Drawing.Point(3, 106);
            this.InvoiceGrid.Name = "InvoiceGrid";
            this.InvoiceGrid.RowTemplate.Height = 24;
            this.InvoiceGrid.Size = new System.Drawing.Size(556, 423);
            this.InvoiceGrid.TabIndex = 14;
            // 
            // SaveInvoiceBtn
            // 
            this.SaveInvoiceBtn.Location = new System.Drawing.Point(963, 37);
            this.SaveInvoiceBtn.Name = "SaveInvoiceBtn";
            this.SaveInvoiceBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveInvoiceBtn.TabIndex = 13;
            this.SaveInvoiceBtn.Text = "Calculate";
            this.SaveInvoiceBtn.UseVisualStyleBackColor = true;
            this.SaveInvoiceBtn.Click += new System.EventHandler(this.SaveInvoiceBtn_Click);
            // 
            // InvoiceDescription
            // 
            this.InvoiceDescription.Location = new System.Drawing.Point(735, 37);
            this.InvoiceDescription.Name = "InvoiceDescription";
            this.InvoiceDescription.Size = new System.Drawing.Size(160, 42);
            this.InvoiceDescription.TabIndex = 12;
            this.InvoiceDescription.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(625, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Description";
            // 
            // calculatedTrackingModelBindingSource
            // 
            this.calculatedTrackingModelBindingSource.DataSource = typeof(TimeTracker.Models.CalculatedTrackingModel);
            // 
            // ToDatePicker
            // 
            this.ToDatePicker.Location = new System.Drawing.Point(406, 37);
            this.ToDatePicker.Name = "ToDatePicker";
            this.ToDatePicker.Size = new System.Drawing.Size(160, 23);
            this.ToDatePicker.TabIndex = 9;
            this.ToDatePicker.UsePersianFormat = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "To Date :";
            // 
            // FromDatePicker
            // 
            this.FromDatePicker.Location = new System.Drawing.Point(133, 37);
            this.FromDatePicker.Name = "FromDatePicker";
            this.FromDatePicker.Size = new System.Drawing.Size(160, 23);
            this.FromDatePicker.TabIndex = 7;
            this.FromDatePicker.UsePersianFormat = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "From Date :";
            // 
            // Info
            // 
            this.Info.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Info.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem});
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(125, 28);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.ProjectMenuItem});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(1241, 24);
            this.radMenu1.TabIndex = 1;
            this.radMenu1.Text = "radMenu1";
            // 
            // ProjectMenuItem
            // 
            this.ProjectMenuItem.Name = "ProjectMenuItem";
            this.ProjectMenuItem.Text = "Project";
            this.ProjectMenuItem.Click += new System.EventHandler(this.ProjectMenuItem_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // invoiceModelBindingSource
            // 
            this.invoiceModelBindingSource.DataSource = typeof(TimeTracker.DataModel.InvoiceModel);
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            // 
            // periodStartDateDataGridViewTextBoxColumn
            // 
            this.periodStartDateDataGridViewTextBoxColumn.DataPropertyName = "PeriodStartDate";
            this.periodStartDateDataGridViewTextBoxColumn.HeaderText = "PeriodStartDate";
            this.periodStartDateDataGridViewTextBoxColumn.Name = "periodStartDateDataGridViewTextBoxColumn";
            // 
            // periodEndDateDataGridViewTextBoxColumn
            // 
            this.periodEndDateDataGridViewTextBoxColumn.DataPropertyName = "PeriodEndDate";
            this.periodEndDateDataGridViewTextBoxColumn.HeaderText = "PeriodEndDate";
            this.periodEndDateDataGridViewTextBoxColumn.Name = "periodEndDateDataGridViewTextBoxColumn";
            // 
            // isPaidDataGridViewTextBoxColumn
            // 
            this.isPaidDataGridViewTextBoxColumn.DataPropertyName = "IsPaid";
            this.isPaidDataGridViewTextBoxColumn.HeaderText = "IsPaid";
            this.isPaidDataGridViewTextBoxColumn.Name = "isPaidDataGridViewTextBoxColumn";
            // 
            // userDataGridViewTextBoxColumn1
            // 
            this.userDataGridViewTextBoxColumn1.DataPropertyName = "User";
            this.userDataGridViewTextBoxColumn1.HeaderText = "User";
            this.userDataGridViewTextBoxColumn1.Name = "userDataGridViewTextBoxColumn1";
            // 
            // InvoiceDetailGrid
            // 
            this.InvoiceDetailGrid.AutoGenerateColumns = false;
            this.InvoiceDetailGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InvoiceDetailGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvoiceDetailGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.platformDataGridViewTextBoxColumn1,
            this.ProjectID,
            this.ProjectName,
            this.Platform,
            this.Hours});
            this.InvoiceDetailGrid.DataSource = this.calculatedTrackingModelBindingSource;
            this.InvoiceDetailGrid.Location = new System.Drawing.Point(572, 106);
            this.InvoiceDetailGrid.Name = "InvoiceDetailGrid";
            this.InvoiceDetailGrid.RowTemplate.Height = 24;
            this.InvoiceDetailGrid.Size = new System.Drawing.Size(613, 287);
            this.InvoiceDetailGrid.TabIndex = 15;
            // 
            // platformDataGridViewTextBoxColumn1
            // 
            this.platformDataGridViewTextBoxColumn1.DataPropertyName = "Platform";
            this.platformDataGridViewTextBoxColumn1.HeaderText = "Platform";
            this.platformDataGridViewTextBoxColumn1.Name = "platformDataGridViewTextBoxColumn1";
            // 
            // ProjectID
            // 
            this.ProjectID.DataPropertyName = "ProjectID";
            this.ProjectID.HeaderText = "ProjectID";
            this.ProjectID.Name = "ProjectID";
            // 
            // ProjectName
            // 
            this.ProjectName.DataPropertyName = "ProjectName";
            this.ProjectName.HeaderText = "ProjectName";
            this.ProjectName.Name = "ProjectName";
            // 
            // Platform
            // 
            this.Platform.DataPropertyName = "Platform";
            this.Platform.HeaderText = "Platform";
            this.Platform.Name = "Platform";
            // 
            // Hours
            // 
            this.Hours.DataPropertyName = "Hours";
            this.Hours.HeaderText = "Hours";
            this.Hours.Name = "Hours";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 601);
            this.Controls.Add(this.radMenu1);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Time Tracker";
            this.TabControl.ResumeLayout(false);
            this.TimeTrackerTab.ResumeLayout(false);
            this.TimeTrackerTab.PerformLayout();
            this.ManualTrackerTab.ResumeLayout(false);
            this.ManualTrackerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoursNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesNumeric)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TimeTrackingGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTrackingModelBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculatedTrackingModelBindingSource)).EndInit();
            this.Info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDetailGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TimeTrackerTab;
        private System.Windows.Forms.TabPage ManualTrackerTab;
        private System.Windows.Forms.ContextMenuStrip Info;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem ProjectMenuItem;
        private System.Windows.Forms.Button PauseBtn;
        private System.Windows.Forms.Button StopWatchBtn;
        private System.Windows.Forms.Button StartWatchBtn;
        private System.Windows.Forms.Label TodayDate;
        private System.Windows.Forms.ComboBox ProjectComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TimeLbl;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label DescLbl;
        private System.Windows.Forms.RichTextBox DescriptionTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ManualProjectCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveManualTrackerBtn;
        private System.Windows.Forms.NumericUpDown HoursNumeric;
        private System.Windows.Forms.NumericUpDown MinutesNumeric;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox ManualDescTxt;
        private Atf.UI.DateTimeSelector ManualDate;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Atf.UI.DateTimeSelector ToDatePicker;
        private System.Windows.Forms.Label label2;
        private Atf.UI.DateTimeSelector FromDatePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView TimeTrackingGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn platformDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persianDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minutesCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackingInvoiceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackingInvoiceDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource timeTrackingModelBindingSource;
        private System.Windows.Forms.Button SaveInvoiceBtn;
        private System.Windows.Forms.RichTextBox InvoiceDescription;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource calculatedTrackingModelBindingSource;
        private System.Windows.Forms.DataGridView InvoiceGrid;
        private System.Windows.Forms.BindingSource invoiceModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodEndDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isPaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView InvoiceDetailGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn platformDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Platform;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hours;
    }
}