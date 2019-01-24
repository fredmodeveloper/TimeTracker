using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTracker.Models;

namespace TimeTracker
{
    public partial class MainForm : Form
    {
        private Stopwatch watch;

        private DateTime StartTime;
        private DateTime PausedTime;
        private TimeSpan PausedElapsedTime = new TimeSpan();
        private TimeSpan ElapsedTime = new TimeSpan();
        private bool isPaused = false;

        public MainForm()
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

            if (loginForm.isLogin)
            {
                InitializeComponent();
                this.CenterToScreen();

                this.Show();

                BindProjectComboBox();
                GetTrackingList();
                SetInvoiceFromDate();
                GetInvoiceList();
                this.TodayDate.Text = DateTime.Now.Date.ToShortDateString();
                watch = new Stopwatch();
                this.StopWatchBtn.Visible = false;
                this.PauseBtn.Visible = false;
            }
            else
                this.Close();
        }

        private void ProjectMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BindProjectComboBox()
        {
            var userProjects = Tools.Context.UserProjects.Where(o => o.UserID == Tools.CurrentUser.ID).Select(o => o.ProjectID).ToList();
            var projects = Tools.Context.Projects.Where(o => userProjects.Contains(o.ID)).Select(o => o.ProjectName).ToList();
            this.ProjectComboBox.DataSource = projects;
            this.ManualProjectCombo.DataSource = projects;

        }
        private void StartWatch()
        {
            if (isPaused == false)
                StartTime = DateTime.Now;
            else
            {

                PausedElapsedTime += DateTime.Now - PausedTime;
                isPaused = false;

            }
            watch.Start();
            Timer.Enabled = true;
            this.StartWatchBtn.Visible = false;
            this.StopWatchBtn.Visible = true;
            this.PauseBtn.Visible = true;

        }

        //public void LoadDataGridData()
        //{
        //    using (var context = Tools.Context)
        //    {
        //        var trackings = context.TimeTrackings.ToList();
        //        this.TimeTrackingGrid.AutoGenerateColumns = true;

        //        this.TimeTrackingGrid.DataSource = trackings;
        //    }
        //}

        public void GetTrackingList()
        {
            var list = new List<TimeTrackingModel>();
            using (var context = Tools.Context)
            {
                 list = (from tracking in context.TimeTrackings
                                join user in context.Users on tracking.UserID equals user.ID
                                join project in context.Projects on tracking.ProjectID equals project.ID
                                join platform in context.Platforms on project.ProjectPlatformID equals platform.ID
                                join invoice in context.TrackingInvoices on tracking.TrackingInvoiceID equals invoice.ID into invoiceObj
                                from invoiceValue in invoiceObj.DefaultIfEmpty()
                                select new TimeTrackingModel
                                {
                                    ID = tracking.ID,
                                    CreateDate = tracking.CreateDate,
                                    Date = tracking.Date,
                                    Description=tracking.Description,
                                    HourCount=tracking.HourCount,
                                    MinutesCount=tracking.MinutesCount,
                                    Platform=platform.Platform1,
                                    Project=project.ProjectName,
                                    TrackingInvoiceDescription=invoiceValue.Description,
                                    TrackingInvoiceID=invoiceValue.ID,
                                    User=user.Username

                                }).ToList();



               
            }
            this.TimeTrackingGrid.DataSource = list;

        }
        public void SetInvoiceFromDate()
        {
            using(var context = new Models.TimeTrackerDBContext())
            {
              
                    var lastInvoice = context.TrackingInvoices.ToList().OrderByDescending(o => o.ID).FirstOrDefault();
                    if (lastInvoice != null)
                    {
                        this.FromDatePicker.Value = lastInvoice.PeriodEndDate;
                        this.ToDatePicker.Value = lastInvoice.PeriodEndDate.AddMonths(1);
                    }
                    else
                    {
                        var firsttrack = context.TimeTrackings.ToList().OrderBy(o => o.Date).FirstOrDefault();
                        if (firsttrack != null)
                        {
                            this.FromDatePicker.Value = firsttrack.Date;
                            this.ToDatePicker.Value = firsttrack.Date.AddMonths(1);
                        }
                    }
                
               
            }
          

        }
        private void Timer_Tick(object sender, EventArgs e)
        {

            ElapsedTime = (DateTime.Now - StartTime) - PausedElapsedTime;
            //if (isPaused == true)
            //{

            //    ElapsedTime = ElapsedTime - PausedElapsedTime;
            //    PausedElapsedTime = new TimeSpan();
            //    isPaused = false;
            //}

            // Start with the days if greater than 0.
            string text = "";
            if (ElapsedTime.Days > 0)
                text += ElapsedTime.Days.ToString() + ".";

            // Convert milliseconds into tenths of seconds.
            int tenths = ElapsedTime.Milliseconds / 100;

            // Compose the rest of the elapsed time.
            text +=
                ElapsedTime.Hours.ToString("00") + ":" +
                ElapsedTime.Minutes.ToString("00") + ":" +
                ElapsedTime.Seconds.ToString("00") + "." +
                tenths.ToString("0");

            TimeLbl.Text = text;
        }

        private void StartWatchBtn_Click(object sender, EventArgs e)
        {
            if (this.ProjectComboBox.SelectedItem != null)
                StartWatch();

        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
            PausedTime = DateTime.Now;

            this.Timer.Enabled = false;
            isPaused = true;
            this.StartWatchBtn.Visible = true;
            this.StopWatchBtn.Visible = true;
            this.PauseBtn.Visible = true;
        }

        private void StopWatchBtn_Click(object sender, EventArgs e)
        {
            this.Timer.Enabled = false;
            this.isPaused = false;
            this.StartWatchBtn.Visible = true;
            this.StopWatchBtn.Visible = false;
            this.PauseBtn.Visible = false;
            TimeSpan total = (DateTime.Now - StartTime) - PausedElapsedTime;
            if (total.Hours == 0)
            {
                if (total.Minutes > 10)
                {
                    SaveAutoTracker();
                }
            }
            else
            {
                SaveAutoTracker();

            }

            StartTime = DateTime.Now;
            PausedTime = DateTime.MinValue;
            PausedElapsedTime = new TimeSpan();
            ElapsedTime = new TimeSpan();
            isPaused = false;
        }
        private void SaveAutoTracker()
        {
            using (var context = new Models.TimeTrackerDBContext())
            {
                TimeSpan elapsed = (DateTime.Now - StartTime) - PausedElapsedTime;
                var tracker = new Models.TimeTracking();
                tracker.CreateDate = DateTime.Now;
                tracker.Date = DateTime.Now.Date;
                var project = context.Projects.Where(o => o.ProjectName == this.ProjectComboBox.SelectedItem.ToString()).FirstOrDefault();
                tracker.ProjectID = project.ID;
                tracker.HourCount = elapsed.Hours;
                tracker.MinutesCount = elapsed.Minutes;
                tracker.UserID = Tools.CurrentUser.ID;
                tracker.Description = this.DescriptionTxtBox.Text;
                context.TimeTrackings.Add(tracker);
                context.SaveChanges();
                MessageBox.Show("Tracker is saved.");
                makefieldsEmptyInAuto();
            }
        }

        private void SaveManualTrackerBtn_Click(object sender, EventArgs e)
        {
            if (HoursNumeric.Value == 0 && MinutesNumeric.Value == 0)
            {

            }
            else
            {
                if (HoursNumeric.Value == 0)
                {
                    if (MinutesNumeric.Value > 0)
                    {
                        SaveManualTracker();

                    }
                }
                else
                {
                    SaveManualTracker();
                }


            }
        }
        private void SaveManualTracker()
        {
            using (var context = new Models.TimeTrackerDBContext())
            {
                var tracker = new Models.TimeTracking();
                tracker.CreateDate = DateTime.Now;
                tracker.Date = ManualDate.Value.Value;
                var project = context.Projects.Where(o => o.ProjectName == this.ManualProjectCombo.SelectedItem.ToString()).FirstOrDefault();
                tracker.ProjectID = project.ID;
                tracker.HourCount = Convert.ToDouble(HoursNumeric.Value);
                tracker.MinutesCount = Convert.ToDouble(MinutesNumeric.Value);
                tracker.UserID = Tools.CurrentUser.ID;
                tracker.Description = this.ManualDescTxt.Text;
               context.TimeTrackings.Add(tracker);
                context.SaveChanges();
                MessageBox.Show("Tracker is saved.");
                makefieldsEmptyInManual();
            }
        }
        private void makefieldsEmptyInManual()
        {
            this.ManualProjectCombo.SelectedItem = null;
            this.ManualDescTxt.Text = "";
            this.ManualDate.Value = null;
            this.HoursNumeric.Value = 0;
            this.MinutesNumeric.Value = 0;
        }
        private void makefieldsEmptyInAuto()
        {
            this.ProjectComboBox.SelectedItem = null;
            this.DescriptionTxtBox.Text = "";

            this.TimeLbl.Text = "00:00:00";
        }
        public void GetInvoiceList()
        {
            using(var context=new Models.TimeTrackerDBContext())
            {
                var list = (from invoice in context.TrackingInvoices
                           join user in context.Users on invoice.UserID equals user.ID
                           select new DataModel.InvoiceModel
                           {
                               ID=invoice.ID,
                               Description=invoice.Description,
                               IsPaid=invoice.IsPaid==false?"No":"Yes",
                               PeriodEndDateTime=invoice.PeriodEndDate,
                               PeriodStartDateTime=invoice.PeriodStartDate,
                               User=user.Username
                           }).ToList();
                this.InvoiceGrid.DataSource = list;
            }
        }
        private async void SaveInvoiceBtn_Click(object sender, EventArgs e)
        {
            using(var context = new Models.TimeTrackerDBContext())
            {
                var invoice = new Models.TrackingInvoice();
                invoice.Description = this.InvoiceDescription.Text;
                invoice.IsPaid = false;
                invoice.PeriodStartDate = this.FromDatePicker.Value.Value;
                invoice.PeriodEndDate = this.ToDatePicker.Value.Value;
                invoice.UserID = Tools.CurrentUser.ID;
                context.TrackingInvoices.Add(invoice);
               await context.SaveChangesAsync();
              await context.Database.ExecuteSqlCommandAsync("UPDATE TimeTracking SET TrackingInvoiceID={0} where Date>={1} and Date<={2}", invoice.ID, invoice.PeriodStartDate, invoice.PeriodEndDate);
                
            }
        }
    }
}
