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
    public partial class Books : PhoneApplicationPage
    {
        public Books()
        {
            InitializeComponent();
        }

        private void Book1_preview_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Uri uri = new Uri("http://www.amazon.com/gp/product/B000WMKKII/ref=as_li_ss_tl?ie=UTF8&tag=salary-20&linkCode=as2&camp=1789&creative=390957&creativeASIN=B000WMKKII");
            WebBrowserTask webBrowserTask = new WebBrowserTask();
            webBrowserTask.Uri = uri;
            webBrowserTask.Show();
        }

        private void Book2_preview_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Uri uri = new Uri("http://www.amazon.com/gp/product/0553383876/ref=as_li_ss_tl?ie=UTF8&tag=salary-20&linkCode=as2&camp=217145&creative=399369&creativeASIN=0553383876");
            WebBrowserTask webBrowserTask = new WebBrowserTask();
            webBrowserTask.Uri = uri;
            webBrowserTask.Show();
        }

        private void Book3_preview_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Uri uri = new Uri("http://www.amazon.com/Ask-Women-Power-Negotiation-Really/dp/0553384554/ref=pd_sim_b_1");
            WebBrowserTask webBrowserTask = new WebBrowserTask();
            webBrowserTask.Uri = uri;
            webBrowserTask.Show();
        }

        private void Book4_preview_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Uri uri = new Uri("http://www.amazon.co.uk/Why-Women-Dont-Ask-Negotiation/dp/0749929006/ref=sr_1_1?s=books&ie=UTF8&qid=1299592355&sr=1-1");
            WebBrowserTask webBrowserTask = new WebBrowserTask();
            webBrowserTask.Uri = uri;
            webBrowserTask.Show();
        }

        private void Book5_preview_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Uri uri = new Uri("http://www.amazon.co.uk/Ask-Women-Really-Power-Negotiation/dp/0749927844/ref=sr_1_1?s=books&ie=UTF8&qid=1299592406&sr=1-1");
            WebBrowserTask webBrowserTask = new WebBrowserTask();
            webBrowserTask.Uri = uri;
            webBrowserTask.Show();
        }

        private void saraLashcever_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Uri uri = new Uri("http://saralaschever.com/womendontask/Home.html");
            WebBrowserTask webBrowserTask = new WebBrowserTask();
            webBrowserTask.Uri = uri;
            webBrowserTask.Show();
        }

        private void linda_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Uri uri = new Uri("http://www.heinz.cmu.edu/faculty-and-research/faculty-profiles/faculty-details/index.aspx?faculty_id=6");
            WebBrowserTask webBrowserTask = new WebBrowserTask();
            webBrowserTask.Uri = uri;
            webBrowserTask.Show();
        }

        private void evelyn_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Uri uri = new Uri("http://www.wageproject.org/files/evelyn.php");
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

        private void pdf1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Uri uri = new Uri("http://www.aauw.org/learn/research/upload/SimpleTruthAboutPayGap.pdf");
            WebBrowserTask webBrowserTask = new WebBrowserTask();
            webBrowserTask.Uri = uri;
            webBrowserTask.Show();
        }
    }
}