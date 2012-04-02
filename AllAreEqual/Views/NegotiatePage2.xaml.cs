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
    public partial class NegotiatePage2 : PhoneApplicationPage
    {
        public NegotiatePage2()
        {
            InitializeComponent();
        }

        private void salaryDotCom_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Uri uri = new Uri("http://www.salary.com/");
            WebBrowserTask webBrowserTask = new WebBrowserTask();
            webBrowserTask.Uri = uri;
            webBrowserTask.Show();
        }
    }
}