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
    public partial class NegotiateAndExpand : PhoneApplicationPage
    {
        public NegotiateAndExpand()
        {
            InitializeComponent();
            /*
             * Data for increase after negotiation
             */
            List<IncreaseFromNego> increaseData = new List<IncreaseFromNego>();
            increaseData.Add(new IncreaseFromNego() { Number = 1000 }); increaseData.Add(new IncreaseFromNego() { Number = 1500 }); increaseData.Add(new IncreaseFromNego() { Number = 2000 });
            increaseData.Add(new IncreaseFromNego() { Number = 2500 }); increaseData.Add(new IncreaseFromNego() { Number = 3000 }); increaseData.Add(new IncreaseFromNego() { Number = 3500 });
            increaseData.Add(new IncreaseFromNego() { Number = 4000 }); increaseData.Add(new IncreaseFromNego() { Number = 4500 }); increaseData.Add(new IncreaseFromNego() { Number = 5000 });
            increaseData.Add(new IncreaseFromNego() { Number = 5500 }); increaseData.Add(new IncreaseFromNego() { Number = 6000 }); increaseData.Add(new IncreaseFromNego() { Number = 6500 });
            increaseData.Add(new IncreaseFromNego() { Number = 7000 }); increaseData.Add(new IncreaseFromNego() { Number = 7500 }); increaseData.Add(new IncreaseFromNego() { Number = 8000 });
            increaseData.Add(new IncreaseFromNego() { Number = 8500 }); increaseData.Add(new IncreaseFromNego() { Number = 9000 }); increaseData.Add(new IncreaseFromNego() { Number = 9500 });
            increaseData.Add(new IncreaseFromNego() { Number = 10000 });

            this.increasePicker.ItemsSource = increaseData;

            /*
             * 
             */
            List<RetireAge> retireAge = new List<RetireAge>();
            retireAge.Add(new RetireAge() { Number = 60 }); retireAge.Add(new RetireAge() { Number = 61 }); retireAge.Add(new RetireAge() { Number = 62 }); retireAge.Add(new RetireAge() { Number = 63 }); retireAge.Add(new RetireAge() { Number = 64 });
            retireAge.Add(new RetireAge() { Number = 65 }); retireAge.Add(new RetireAge() { Number = 66 }); retireAge.Add(new RetireAge() { Number = 67 }); retireAge.Add(new RetireAge() { Number = 68 }); retireAge.Add(new RetireAge() { Number = 69 });
            retireAge.Add(new RetireAge() { Number = 70 }); retireAge.Add(new RetireAge() { Number = 71 }); retireAge.Add(new RetireAge() { Number = 72 }); retireAge.Add(new RetireAge() { Number = 73 }); retireAge.Add(new RetireAge() { Number = 74 });
            retireAge.Add(new RetireAge() { Number = 75 }); retireAge.Add(new RetireAge() { Number = 76 }); retireAge.Add(new RetireAge() { Number = 77 }); retireAge.Add(new RetireAge() { Number = 78 }); retireAge.Add(new RetireAge() { Number = 79 });
            retireAge.Add(new RetireAge() { Number = 80 }); retireAge.Add(new RetireAge() { Number = 81 }); retireAge.Add(new RetireAge() { Number = 82 }); retireAge.Add(new RetireAge() { Number = 83 }); retireAge.Add(new RetireAge() { Number = 84 });
            retireAge.Add(new RetireAge() { Number = 85 }); retireAge.Add(new RetireAge() { Number = 86 }); retireAge.Add(new RetireAge() { Number = 87 }); retireAge.Add(new RetireAge() { Number = 88 }); retireAge.Add(new RetireAge() { Number = 89 });
            retireAge.Add(new RetireAge() { Number = 90 }); retireAge.Add(new RetireAge() { Number = 91 }); retireAge.Add(new RetireAge() { Number = 92 }); retireAge.Add(new RetireAge() { Number = 93 }); retireAge.Add(new RetireAge() { Number = 94 });
            retireAge.Add(new RetireAge() { Number = 95 }); retireAge.Add(new RetireAge() { Number = 96 }); retireAge.Add(new RetireAge() { Number = 97 }); retireAge.Add(new RetireAge() { Number = 98 }); retireAge.Add(new RetireAge() { Number = 99 }); retireAge.Add(new RetireAge() { Number = 100 });

            this.retie_agePicker.ItemsSource = retireAge;

            /*
             * 
             */
            List<NegoAge> negoAge = new List<NegoAge>();
            negoAge.Add(new NegoAge() { Number = 25 }); negoAge.Add(new NegoAge() { Number = 26 }); negoAge.Add(new NegoAge() { Number = 27 }); negoAge.Add(new NegoAge() { Number = 28 }); negoAge.Add(new NegoAge() { Number = 29 }); negoAge.Add(new NegoAge() { Number = 30 }); negoAge.Add(new NegoAge() { Number = 31 }); negoAge.Add(new NegoAge() { Number = 32 }); negoAge.Add(new NegoAge() { Number = 33 }); negoAge.Add(new NegoAge() { Number = 34 });
            negoAge.Add(new NegoAge() { Number = 35 }); negoAge.Add(new NegoAge() { Number = 36 }); negoAge.Add(new NegoAge() { Number = 37 }); negoAge.Add(new NegoAge() { Number = 38 }); negoAge.Add(new NegoAge() { Number = 39 }); negoAge.Add(new NegoAge() { Number = 40 }); negoAge.Add(new NegoAge() { Number = 41 }); negoAge.Add(new NegoAge() { Number = 42 }); negoAge.Add(new NegoAge() { Number = 43 }); negoAge.Add(new NegoAge() { Number = 44 });
            negoAge.Add(new NegoAge() { Number = 45 }); negoAge.Add(new NegoAge() { Number = 46 }); negoAge.Add(new NegoAge() { Number = 47 }); negoAge.Add(new NegoAge() { Number = 48 }); negoAge.Add(new NegoAge() { Number = 49 }); negoAge.Add(new NegoAge() { Number = 50 }); negoAge.Add(new NegoAge() { Number = 51 }); negoAge.Add(new NegoAge() { Number = 52 }); negoAge.Add(new NegoAge() { Number = 53 }); negoAge.Add(new NegoAge() { Number = 54 });
            negoAge.Add(new NegoAge() { Number = 55 }); negoAge.Add(new NegoAge() { Number = 56 }); negoAge.Add(new NegoAge() { Number = 57 }); negoAge.Add(new NegoAge() { Number = 58 }); negoAge.Add(new NegoAge() { Number = 59 }); negoAge.Add(new NegoAge() { Number = 60 }); negoAge.Add(new NegoAge() { Number = 61 }); negoAge.Add(new NegoAge() { Number = 62 }); negoAge.Add(new NegoAge() { Number = 63 }); negoAge.Add(new NegoAge() { Number = 64 });
            negoAge.Add(new NegoAge() { Number = 65 }); negoAge.Add(new NegoAge() { Number = 66 }); negoAge.Add(new NegoAge() { Number = 67 }); negoAge.Add(new NegoAge() { Number = 68 }); negoAge.Add(new NegoAge() { Number = 69 }); negoAge.Add(new NegoAge() { Number = 70 }); negoAge.Add(new NegoAge() { Number = 71 }); negoAge.Add(new NegoAge() { Number = 72 }); negoAge.Add(new NegoAge() { Number = 73 }); negoAge.Add(new NegoAge() { Number = 74 });
            negoAge.Add(new NegoAge() { Number = 75 }); negoAge.Add(new NegoAge() { Number = 76 }); negoAge.Add(new NegoAge() { Number = 77 }); negoAge.Add(new NegoAge() { Number = 78 }); negoAge.Add(new NegoAge() { Number = 79 }); negoAge.Add(new NegoAge() { Number = 80 }); negoAge.Add(new NegoAge() { Number = 81 }); negoAge.Add(new NegoAge() { Number = 82 }); negoAge.Add(new NegoAge() { Number = 83 }); negoAge.Add(new NegoAge() { Number = 84 });
            negoAge.Add(new NegoAge() { Number = 85 }); negoAge.Add(new NegoAge() { Number = 86 }); negoAge.Add(new NegoAge() { Number = 87 }); negoAge.Add(new NegoAge() { Number = 88 }); negoAge.Add(new NegoAge() { Number = 89 }); negoAge.Add(new NegoAge() { Number = 90 }); negoAge.Add(new NegoAge() { Number = 91 }); negoAge.Add(new NegoAge() { Number = 92 }); negoAge.Add(new NegoAge() { Number = 93 }); negoAge.Add(new NegoAge() { Number = 94 });
            negoAge.Add(new NegoAge() { Number = 95 }); negoAge.Add(new NegoAge() { Number = 96 }); negoAge.Add(new NegoAge() { Number = 97 }); negoAge.Add(new NegoAge() { Number = 98 }); negoAge.Add(new NegoAge() { Number = 99 }); negoAge.Add(new NegoAge() { Number = 100 });

            this.nego_agePicker.ItemsSource = negoAge;

            /*
             * 
             */
            List<PercentageHike> percentageHike = new List<PercentageHike>();
            percentageHike.Add(new PercentageHike() { Number = 01 }); percentageHike.Add(new PercentageHike() { Number = 02 }); percentageHike.Add(new PercentageHike() { Number = 03 }); percentageHike.Add(new PercentageHike() { Number = 04 }); percentageHike.Add(new PercentageHike() { Number = 05 }); percentageHike.Add(new PercentageHike() { Number = 06 }); percentageHike.Add(new PercentageHike() { Number = 07 }); percentageHike.Add(new PercentageHike() { Number = 08 }); percentageHike.Add(new PercentageHike() { Number = 09 }); percentageHike.Add(new PercentageHike() { Number = 10 });
            percentageHike.Add(new PercentageHike() { Number = 11 }); percentageHike.Add(new PercentageHike() { Number = 12 }); percentageHike.Add(new PercentageHike() { Number = 13 }); percentageHike.Add(new PercentageHike() { Number = 14 }); percentageHike.Add(new PercentageHike() { Number = 15 }); percentageHike.Add(new PercentageHike() { Number = 16 }); percentageHike.Add(new PercentageHike() { Number = 17 }); percentageHike.Add(new PercentageHike() { Number = 18 }); percentageHike.Add(new PercentageHike() { Number = 19 }); percentageHike.Add(new PercentageHike() { Number = 20 });
            percentageHike.Add(new PercentageHike() { Number = 21 }); percentageHike.Add(new PercentageHike() { Number = 22 }); percentageHike.Add(new PercentageHike() { Number = 23 }); percentageHike.Add(new PercentageHike() { Number = 24 }); percentageHike.Add(new PercentageHike() { Number = 25 }); percentageHike.Add(new PercentageHike() { Number = 26 }); percentageHike.Add(new PercentageHike() { Number = 27 }); percentageHike.Add(new PercentageHike() { Number = 28 }); percentageHike.Add(new PercentageHike() { Number = 29 }); percentageHike.Add(new PercentageHike() { Number = 30 });
            percentageHike.Add(new PercentageHike() { Number = 35 }); percentageHike.Add(new PercentageHike() { Number = 40 }); percentageHike.Add(new PercentageHike() { Number = 45 }); percentageHike.Add(new PercentageHike() { Number = 50 });

            this.hikePicker.ItemsSource = percentageHike;
        }

        public class IncreaseFromNego
        {
            public int Number { get; set; }
        }

        public class RetireAge
        {
            public int Number { get; set; }
        }

        public class NegoAge
        {
            public int Number { get; set; }
        }

        public class PercentageHike
        {
            public int Number { get; set; }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ListPickerItem selectedIncrease = this.increasePicker.ItemContainerGenerator.ContainerFromItem(this.increasePicker.SelectedItem) as ListPickerItem;
            IncreaseFromNego selectedIncreaseData = selectedIncrease.DataContext as IncreaseFromNego;
            int increase = selectedIncreaseData.Number;

            ListPickerItem selectedRetAge = this.retie_agePicker.ItemContainerGenerator.ContainerFromItem(this.retie_agePicker.SelectedItem) as ListPickerItem;
            RetireAge selectedRetAgeData = selectedRetAge.DataContext as RetireAge;
            int retAge = selectedRetAgeData.Number;

            ListPickerItem selectedNegAge = this.nego_agePicker.ItemContainerGenerator.ContainerFromItem(this.nego_agePicker.SelectedItem) as ListPickerItem;
            NegoAge selectedNegAgeData = selectedNegAge.DataContext as NegoAge;
            int negAge = selectedNegAgeData.Number;

            ListPickerItem selectedPercHike = this.hikePicker.ItemContainerGenerator.ContainerFromItem(this.hikePicker.SelectedItem) as ListPickerItem;
            PercentageHike selectedPercHikeData = selectedPercHike.DataContext as PercentageHike;
            double hike = selectedPercHikeData.Number;

            Double extraAmount = 0;
            for (double i = 0; i <= (retAge-negAge); i++)
            {
                extraAmount += increase * Math.Pow( (1 + (hike / 100) ), i);
            }
            this.textBlock2.Text = "Extra amount you earned = $" + (Int64)extraAmount;
        }
        
    }
}