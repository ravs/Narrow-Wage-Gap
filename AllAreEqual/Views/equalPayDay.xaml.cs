using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Text.RegularExpressions;
using Microsoft.Phone.Scheduler;

namespace AllAreEqual.Views
{
    public partial class equalPayDay : PhoneApplicationPage
    {
        public equalPayDay()
        {
            InitializeComponent();

            this.epdDate.Text = "17";
            this.epdYear.Text = "2012";

            WebClient webClient = new WebClient();
            webClient.DownloadStringCompleted += new DownloadStringCompletedEventHandler(webClient_DownloadStringCompleted);
            webClient.DownloadStringAsync(new System.Uri("https://www.google.com/calendar/feeds/m64g4u8qqrfsi3namgaoornfu0%40group.calendar.google.com/public/basic"));
        }

        // Event handler which runs after the feed is fully downloaded.
        private void webClient_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                //Display default date 17/04/2012
            }
            else
            {
                //Read the feed and get the event date
                string fixedString = "";

                // Remove HTML tags. 
                fixedString = Regex.Replace(e.Result.ToString(), "<[^>]+>", string.Empty);

                // Remove newline characters
                fixedString = fixedString.Replace("\r", "").Replace("\n", "");

                // Remove encoded HTML characters
                fixedString = HttpUtility.HtmlDecode(fixedString);
                int start = fixedString.IndexOf("When:") + 6;
                int end = fixedString.IndexOf("<br>");
                fixedString = fixedString.Substring(start, end - start);
                string[] temp = fixedString.Split(' ');
                string date = temp[1]; string year = temp[3];
                this.epdDate.Text = date;
                this.epdYear.Text = year;
            }
        }

        private void addReminder_Click(object sender, RoutedEventArgs e)
        {
            // Get the begin time for the notification by combining the DatePicker
            // value and the TimePicker value.
            DateTime date;
            if (this.beginDatePicker.IsEnabled)
            {
                date = (DateTime)beginDatePicker.Value;
            }
            else
            {
                date = new DateTime(int.Parse(this.epdYear.Text), 04, int.Parse(this.epdDate.Text));
            }

            DateTime time = (DateTime)beginTimePicker.Value;
            DateTime beginTime = date + time.TimeOfDay;

            // Make sure that the begin time has not already passed.
            if (beginTime < DateTime.Now)
            {
                MessageBox.Show("the begin date must be in the future.");
                return;
            }

            // Get the expiration time for the notification
            if (this.expirationDatePicker.IsEnabled)
            {
                date = (DateTime)expirationDatePicker.Value;
            }
            else
            {
                date = new DateTime(int.Parse(this.epdYear.Text), 04, int.Parse(this.epdDate.Text));
            }
            time = (DateTime)expirationTimePicker.Value;
            DateTime expirationTime = date + time.TimeOfDay;

            // Make sure that the expiration time is after the begin time.
            if (expirationTime < beginTime)
            {
                MessageBox.Show("expiration time must be after the begin time.");
                return;
            }

            String name = "EqualPayDayReminder";
            Reminder reminder = new Reminder(name);
            reminder.Title = "Equal Pay Day";
            reminder.Content = "Wear RED on Equal Pay Day to symbolize how far women and minorities are \"in the red\" with their pay!";

            reminder.BeginTime = beginTime;
            reminder.ExpirationTime = expirationTime;
            reminder.RecurrenceType = RecurrenceInterval.None;

            // Register the reminder with the system.
            try
            {
                ScheduledActionService.Add(reminder);
                MessageBox.Show("Reminder set  at : " + beginTime.ToString());
            }
            catch (InvalidOperationException ex)
            {
                ScheduledActionService.Remove("EqualPayDayReminder");
                ScheduledActionService.Add(reminder);
                MessageBox.Show("Reminder set  at : " + beginTime.ToString());
            }
            NavigationService.GoBack();
        }

        private void changeDate_Checked(object sender, RoutedEventArgs e)
        {
            this.beginDatePicker.Visibility = Visibility.Visible;
            this.beginDatePicker.IsEnabled = true;
            this.expirationDatePicker.Visibility = Visibility.Visible;
            this.expirationDatePicker.IsEnabled = true;
        }

        private void changeDate_Unchecked(object sender, RoutedEventArgs e)
        {
            this.beginDatePicker.IsEnabled = false;
            this.beginDatePicker.Visibility = Visibility.Collapsed;
            this.expirationDatePicker.IsEnabled = false;
            this.expirationDatePicker.Visibility = Visibility.Collapsed;
        }

        private void removeReminder_Click(object sender, RoutedEventArgs e)
        {
            ScheduledActionService.Remove("EqualPayDayReminder");
            MessageBox.Show("Reminder removed.");
            NavigationService.GoBack();
        }

        private void ReminderToggleSwitch_Checked(object sender, RoutedEventArgs e)
        {
            this.ReminderStackPanel.Visibility = Visibility.Visible;
            this.ReminderToggleSwitch.Content = "Show";
        }

        private void ReminderToggleSwitch_Unchecked(object sender, RoutedEventArgs e)
        {
            this.ReminderStackPanel.Visibility = Visibility.Collapsed;
            this.ReminderToggleSwitch.Content = "Hide";
        }
    }
}