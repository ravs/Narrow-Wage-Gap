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

namespace AllAreEqual.Views
{
    public partial class RssFeedPage : PhoneApplicationPage
    {
        private String rssLink;
        private String pageTitle;

        public RssFeedPage()
        {
            InitializeComponent();
        }
 
        private void loadFeedButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadStringCompleted += new DownloadStringCompletedEventHandler(webClient_DownloadStringCompleted); 
            webClient.DownloadStringAsync(new System.Uri(rssLink));
        }

        private void webClient_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                Deployment.Current.Dispatcher.BeginInvoke(() =>
                {
                    MessageBox.Show(e.Error.Message);
                });
            }
            else
            { 
                this.State["feed"] = e.Result;

                UpdateFeedList(e.Result);
            }
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            loadFeedButton.Content = "Loading...";
            rssLink = "";
            pageTitle = "";
            NavigationContext.QueryString.TryGetValue("rssLink", out rssLink);
            NavigationContext.QueryString.TryGetValue("pageTitle", out pageTitle);

            this.ApplicationTitle.Text = this.ApplicationTitle.Text + " " + pageTitle;
            WebClient webClient = new WebClient();
            webClient.DownloadStringCompleted += new DownloadStringCompletedEventHandler(webClient_DownloadStringCompleted);
            webClient.DownloadStringAsync(new System.Uri(rssLink));

            if (this.State.ContainsKey("feed"))
            {
                if (feedListBox.Items.Count == 0)
                {
                    UpdateFeedList(State["feed"] as string);
                }
            }
        }

        private void UpdateFeedList(string feedXML)
        {
            StringReader stringReader = new StringReader(feedXML);
            XmlReader xmlReader = XmlReader.Create(stringReader);
            SyndicationFeed feed = SyndicationFeed.Load(xmlReader);

            Deployment.Current.Dispatcher.BeginInvoke(() =>
            {
                feedListBox.ItemsSource = feed.Items;

                loadFeedButton.Content = "Refresh Feed";
            });

        }

        private void feedListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox listBox = sender as ListBox;

            if (listBox != null && listBox.SelectedItem != null)
            {
                SyndicationItem sItem = (SyndicationItem)listBox.SelectedItem;

                if (sItem.Links.Count > 0)
                {
                    Uri uri = sItem.Links.FirstOrDefault().Uri;

                    WebBrowserTask webBrowserTask = new WebBrowserTask();
                    webBrowserTask.Uri = uri;
                    webBrowserTask.Show();
                }
            }
        }
    }
}