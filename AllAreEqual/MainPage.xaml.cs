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

using System.IO;
using System.ServiceModel.Syndication;
using System.Xml;
using Microsoft.Phone.Tasks;


namespace AllAreEqual
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
            this.Loaded += new RoutedEventHandler(MainPage_Loaded);
        }

        // Load data for the ViewModel Items
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private void NegotiationTip_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TipIndexPage.xaml", UriKind.Relative));
        }

        private void NegotiateAndExpand_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/NegotiateAndExpand.xaml", UriKind.Relative));
        }

        private void Books_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/Books.xaml", UriKind.Relative));
        }

        private void dolStats_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/OEW_May2010.xaml", UriKind.Relative));
        }

        private void websites_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/Socialize.xaml", UriKind.Relative));
        }

        private void epday_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/equalPayDay.xaml", UriKind.Relative));
        }

        private void epAct_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Uri uri = new Uri("http://www.eeoc.gov/laws/statutes/epa.cfm");
            WebBrowserTask webBrowserTask = new WebBrowserTask();
            webBrowserTask.Uri = uri;
            webBrowserTask.Show();
        }

        private void womansBureau_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Uri uri = new Uri("http://www.dol.gov/wb/welcome.html");
            WebBrowserTask webBrowserTask = new WebBrowserTask();
            webBrowserTask.Uri = uri;
            webBrowserTask.Show();
        }

        private void upcomingEvents_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Uri uri = new Uri("http://www.dol.gov/wb/events.htm");
            WebBrowserTask webBrowserTask = new WebBrowserTask();
            webBrowserTask.Uri = uri;
            webBrowserTask.Show();
        }

        private void dolNews_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            String rssLink = "http://www.dol.gov/rss/news.xml";
            String pageTitle = "DoL News Releases";
            String queryString = "?rssLink=" + rssLink + "&pageTitle=" + pageTitle;
            NavigationService.Navigate(new Uri("/Views/RssFeedPage.xaml" + queryString, UriKind.Relative));
        }

        private void subscribe_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Uri uri = new Uri("https://public.govdelivery.com/accounts/USDOL/subscriber/new?");
            WebBrowserTask webBrowserTask = new WebBrowserTask();
            webBrowserTask.Uri = uri;
            webBrowserTask.Show();
        }

        private void DailyMuseRss_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            String rssLink = "http://www.thedailymuse.com/tag/thedailymuseepac/feed/atom/";
            String pageTitle = "The Daily Muse";
            String queryString = "?rssLink=" + rssLink + "&pageTitle=" + pageTitle;
            NavigationService.Navigate(new Uri("/Views/RssFeedPage.xaml" + queryString, UriKind.Relative));
        }

        private void appBar_About(object sender, EventArgs e)
        {
            MessageBox.Show("Unfair and Illegal\n"+
                             "Nearly 50 years after President Kennedy signed the Equal Pay Act, on average women are still paid less than their male counterparts for doing comparable jobs in the U.S. — that's called the pay gap. \n"+
                             "\nUse this app and spread the word to narrow this gap.\n"+
                             "\n\nThis app is brought to you by, \n         Samatva Org.");
        }

        private void appBar_Sources(object sender, EventArgs e)
        {
            MessageBox.Show("Information shared in this app is provided by U.S. Department of Labor.\n"+
                            "We would also like to thank: \n- Dr. Linda Babcock, PROGRESS, Carnegie \n   Mellon University, \n- interviewstreet.com, and \n- narrowthegapp.com\nfor tips and spreading the word.");
        }
    }
}