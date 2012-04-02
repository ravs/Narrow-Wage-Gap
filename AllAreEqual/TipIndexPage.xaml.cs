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

namespace AllAreEqual.Views
{
    public partial class TipIndexPage : PhoneApplicationPage
    {
        public TipIndexPage()
        {
            InitializeComponent();
            DataContext = App.ViewModel;
        }

        private void Tip1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/NegotiatePage.xaml", UriKind.Relative));
        }

        private void Tip2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/NegotiatePage1.xaml", UriKind.Relative));
        }

        private void Tip3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/NegotiatePage2.xaml", UriKind.Relative));
        }

        private void Tip4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/NegotiatePage3.xaml", UriKind.Relative));
        }

        private void Tip5_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/NegotiatePage4.xaml", UriKind.Relative));
        }

        private void Tip6_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/NegotiatePage5.xaml", UriKind.Relative));
        }

        private void Tip7_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/NegotiatePage6.xaml", UriKind.Relative));
        }

        private void Tip8_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/NegotiatePage7.xaml", UriKind.Relative));
        }

        private void Tip9_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/NegotiatePage8.xaml", UriKind.Relative));
        }

        private void Tip10_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/NegotiatePage9.xaml", UriKind.Relative));
        }
    }
}