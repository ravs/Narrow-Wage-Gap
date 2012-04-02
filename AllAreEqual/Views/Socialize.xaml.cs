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
using Microsoft.Phone.Tasks;

namespace AllAreEqual.Views
{
    public partial class Socialize : PhoneApplicationPage
    {
        public Socialize()
        {
            InitializeComponent();
        }

        private void wage_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Uri uri = new Uri("http://www.wageproject.org/index.php");
            WebBrowserTask webBrowserTask = new WebBrowserTask();
            webBrowserTask.Uri = uri;
            webBrowserTask.Show();
        }

        private void bpwFoundation_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Uri uri = new Uri("http://www.bpwfoundation.org/");
            WebBrowserTask webBrowserTask = new WebBrowserTask();
            webBrowserTask.Uri = uri;
            webBrowserTask.Show();
        }

        private void nine2Five_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Uri uri = new Uri("http://9to5.org/");
            WebBrowserTask webBrowserTask = new WebBrowserTask();
            webBrowserTask.Uri = uri;
            webBrowserTask.Show();
        }

        private void ncpe_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Uri uri = new Uri("http://www.pay-equity.org/index.html");
            WebBrowserTask webBrowserTask = new WebBrowserTask();
            webBrowserTask.Uri = uri;
            webBrowserTask.Show();
        }

        private void aauw_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Uri uri = new Uri("http://www.aauw.org/");
            WebBrowserTask webBrowserTask = new WebBrowserTask();
            webBrowserTask.Uri = uri;
            webBrowserTask.Show();
        }
    }
}